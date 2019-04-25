namespace MqttClientDemo
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.BtnSubscribe = new System.Windows.Forms.Button();
            this.txtReceiveMessage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPubTopic = new System.Windows.Forms.TextBox();
            this.txtSendMessage = new System.Windows.Forms.RichTextBox();
            this.BtnPublish = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.CombServer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订阅主题";
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTopic.Location = new System.Drawing.Point(211, 15);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(438, 21);
            this.txtSubTopic.TabIndex = 1;
            // 
            // BtnSubscribe
            // 
            this.BtnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubscribe.Location = new System.Drawing.Point(665, 13);
            this.BtnSubscribe.Name = "BtnSubscribe";
            this.BtnSubscribe.Size = new System.Drawing.Size(72, 23);
            this.BtnSubscribe.TabIndex = 2;
            this.BtnSubscribe.Text = "订阅";
            this.BtnSubscribe.UseVisualStyleBackColor = true;
            this.BtnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // txtReceiveMessage
            // 
            this.txtReceiveMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiveMessage.Location = new System.Drawing.Point(12, 48);
            this.txtReceiveMessage.Name = "txtReceiveMessage";
            this.txtReceiveMessage.Size = new System.Drawing.Size(874, 235);
            this.txtReceiveMessage.TabIndex = 3;
            this.txtReceiveMessage.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "发布主题";
            // 
            // txtPubTopic
            // 
            this.txtPubTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPubTopic.Location = new System.Drawing.Point(95, 301);
            this.txtPubTopic.Name = "txtPubTopic";
            this.txtPubTopic.Size = new System.Drawing.Size(510, 21);
            this.txtPubTopic.TabIndex = 5;
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendMessage.Location = new System.Drawing.Point(12, 339);
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(874, 124);
            this.txtSendMessage.TabIndex = 6;
            this.txtSendMessage.Text = "";
            // 
            // BtnPublish
            // 
            this.BtnPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPublish.Location = new System.Drawing.Point(270, 480);
            this.BtnPublish.Name = "BtnPublish";
            this.BtnPublish.Size = new System.Drawing.Size(215, 28);
            this.BtnPublish.TabIndex = 7;
            this.BtnPublish.Text = "发布";
            this.BtnPublish.UseVisualStyleBackColor = true;
            this.BtnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(758, 14);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(72, 23);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "清空";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // CombServer
            // 
            this.CombServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombServer.FormattingEnabled = true;
            this.CombServer.Location = new System.Drawing.Point(25, 16);
            this.CombServer.Name = "CombServer";
            this.CombServer.Size = new System.Drawing.Size(93, 20);
            this.CombServer.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 545);
            this.Controls.Add(this.CombServer);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnPublish);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.txtPubTopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceiveMessage);
            this.Controls.Add(this.BtnSubscribe);
            this.Controls.Add(this.txtSubTopic);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubTopic;
        private System.Windows.Forms.Button BtnSubscribe;
        private System.Windows.Forms.RichTextBox txtReceiveMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPubTopic;
        private System.Windows.Forms.RichTextBox txtSendMessage;
        private System.Windows.Forms.Button BtnPublish;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ComboBox CombServer;
    }
}

