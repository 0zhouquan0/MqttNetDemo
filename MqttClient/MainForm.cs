using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Packets;
using MQTTnet.Protocol;



namespace MqttClientDemo
{
    public partial class Main : Form
    {
        private IMqttClient mqttClient = null;

        public Main()
        {
            InitializeComponent();

            //Task.Run(async () => { await ConnectMqttServerAsync(); });
        }

        private async Task ConnectMqttServerAsync()
        {
            if (mqttClient == null)
            {
                mqttClient = new MqttFactory().CreateMqttClient();
                mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;
                mqttClient.Connected += MqttClient_Connected;
                mqttClient.Disconnected += MqttClient_Disconnected;
            }

            try
            {
                var index = this.CombServer.InvokeRequired ? (int)this.CombServer.EndInvoke(this.CombServer.BeginInvoke(new Func<int>(()=> { return this.CombServer.SelectedIndex; }) )): this.CombServer.SelectedIndex;

                if (index == 1)
                {
                    var options = new MqttClientOptionsBuilder()
                                     .WithClientId(Guid.NewGuid().ToString().Substring(0, 5))
                                     .WithTcpServer(ConfigurationManager.AppSettings["MqttUrl"],Convert.ToInt32(ConfigurationManager.AppSettings["MqttPort"]))
                                     .WithCredentials(ConfigurationManager.AppSettings["MqttUserName"], ConfigurationManager.AppSettings["MqttPassWord"])
                                     .WithKeepAlivePeriod(TimeSpan.FromSeconds(60))
                                     .WithCommunicationTimeout(TimeSpan.FromSeconds(30))
                                     .Build();
                    await mqttClient.ConnectAsync(options);
                }
                else
                {
                    var options = new MqttClientOptionsBuilder()
                                   .WithClientId(Guid.NewGuid().ToString().Substring(0, 5))
                                   .WithTcpServer(ConfigurationManager.AppSettings["local_MqttUrl"])
                                   .WithCredentials(ConfigurationManager.AppSettings["local_MqttUserName"], ConfigurationManager.AppSettings["local_MqttPassWord"])
                                   .WithKeepAlivePeriod(TimeSpan.FromSeconds(60))
                                   .WithCommunicationTimeout(TimeSpan.FromSeconds(30))
                                   .Build();
                    await mqttClient.ConnectAsync(options);
                }

            }
            catch (Exception ex)
            {
                Invoke((new Action(() =>
                {
                    txtReceiveMessage.AppendText($"连接到MQTT服务器失败！" + Environment.NewLine + ex.Message + Environment.NewLine);
                })));
            }
        }

        private void MqttClient_Connected(object sender, EventArgs e)
        {
            Invoke((new Action(() =>
            {
                txtReceiveMessage.AppendText("已连接到MQTT服务器！" + Environment.NewLine);
            })));
        }

        private void MqttClient_Disconnected(object sender, EventArgs e)
        {
            Invoke((new Action(() =>
            {
                txtReceiveMessage.AppendText("已断开MQTT连接！" + Environment.NewLine);
            })));
        }

        private void MqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            Invoke((new Action(() =>
            {
                txtReceiveMessage.AppendText($">>{e.ClientId} {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}{Environment.NewLine}");
            })));
        }

        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            string topic = txtSubTopic.Text.Trim();

            if (string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("订阅主题不能为空！");
                return;
            }

            if (!mqttClient.IsConnected)
            {
                MessageBox.Show("MQTT客户端尚未连接！");
                return;
            }

            mqttClient.SubscribeAsync(new List<TopicFilter> {
                new TopicFilter(topic, MqttQualityOfServiceLevel.AtMostOnce)
            });

            txtReceiveMessage.AppendText($"已订阅[{topic}]主题" + Environment.NewLine);
            //txtSubTopic.Enabled = false;
            //BtnSubscribe.Enabled = false;
        }

        private void BtnPublish_Click(object sender, EventArgs e)
        {
            string topic = txtPubTopic.Text.Trim();

            if (string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("发布主题不能为空！");
                return;
            }

            string inputString = txtSendMessage.Text.Trim();
            var appMsg = new MqttApplicationMessage
            {
                Topic = topic,
                Payload = Encoding.UTF8.GetBytes(inputString),
                QualityOfServiceLevel = MqttQualityOfServiceLevel.ExactlyOnce,//只有一次
                Retain = false
            };

            mqttClient.PublishAsync(appMsg).Wait();
        }

        private void Main_Load(object sender, EventArgs e)
        {
      
            this.CombServer.Items.Add("本地服务器");
            this.CombServer.Items.Add("EMQ服务器");
            this.CombServer.SelectedIndex = 0;
        }

        private void CombServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mqttClient!=null)
            {
                mqttClient.Dispose();
                mqttClient = null;
            }
          
            Task.Run(async () => { await ConnectMqttServerAsync(); });
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Invoke((new Action(() =>
            {
                txtReceiveMessage.Clear();
            })));
        }
    }
}
