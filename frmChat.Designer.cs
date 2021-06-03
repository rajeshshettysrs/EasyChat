namespace EasyChat
{
    partial class frmChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMe = new System.Windows.Forms.GroupBox();
            this.groupBoxFriend = new System.Windows.Forms.GroupBox();
            this.lblIPMe = new System.Windows.Forms.Label();
            this.lblPortMe = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPortFriend = new System.Windows.Forms.Label();
            this.lblIPFriend = new System.Windows.Forms.Label();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.txtRemotelPort = new System.Windows.Forms.TextBox();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBoxMe.SuspendLayout();
            this.groupBoxFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMe
            // 
            this.groupBoxMe.Controls.Add(this.txtLocalPort);
            this.groupBoxMe.Controls.Add(this.txtLocalIP);
            this.groupBoxMe.Controls.Add(this.lblPortMe);
            this.groupBoxMe.Controls.Add(this.lblIPMe);
            this.groupBoxMe.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMe.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMe.Name = "groupBoxMe";
            this.groupBoxMe.Size = new System.Drawing.Size(273, 131);
            this.groupBoxMe.TabIndex = 0;
            this.groupBoxMe.TabStop = false;
            this.groupBoxMe.Text = "Me";
            // 
            // groupBoxFriend
            // 
            this.groupBoxFriend.Controls.Add(this.txtRemoteIP);
            this.groupBoxFriend.Controls.Add(this.txtRemotelPort);
            this.groupBoxFriend.Controls.Add(this.lblPortFriend);
            this.groupBoxFriend.Controls.Add(this.lblIPFriend);
            this.groupBoxFriend.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFriend.Location = new System.Drawing.Point(291, 12);
            this.groupBoxFriend.Name = "groupBoxFriend";
            this.groupBoxFriend.Size = new System.Drawing.Size(266, 131);
            this.groupBoxFriend.TabIndex = 0;
            this.groupBoxFriend.TabStop = false;
            this.groupBoxFriend.Text = "Friend";
            // 
            // lblIPMe
            // 
            this.lblIPMe.AutoSize = true;
            this.lblIPMe.Location = new System.Drawing.Point(24, 33);
            this.lblIPMe.Name = "lblIPMe";
            this.lblIPMe.Size = new System.Drawing.Size(20, 14);
            this.lblIPMe.TabIndex = 0;
            this.lblIPMe.Text = "IP";
            // 
            // lblPortMe
            // 
            this.lblPortMe.AutoSize = true;
            this.lblPortMe.Location = new System.Drawing.Point(24, 66);
            this.lblPortMe.Name = "lblPortMe";
            this.lblPortMe.Size = new System.Drawing.Size(40, 14);
            this.lblPortMe.TabIndex = 1;
            this.lblPortMe.Text = "PORT";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(563, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 38);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPortFriend
            // 
            this.lblPortFriend.AutoSize = true;
            this.lblPortFriend.Location = new System.Drawing.Point(19, 66);
            this.lblPortFriend.Name = "lblPortFriend";
            this.lblPortFriend.Size = new System.Drawing.Size(40, 14);
            this.lblPortFriend.TabIndex = 3;
            this.lblPortFriend.Text = "PORT";
            // 
            // lblIPFriend
            // 
            this.lblIPFriend.AutoSize = true;
            this.lblIPFriend.Location = new System.Drawing.Point(19, 33);
            this.lblIPFriend.Name = "lblIPFriend";
            this.lblIPFriend.Size = new System.Drawing.Size(20, 14);
            this.lblIPFriend.TabIndex = 2;
            this.lblIPFriend.Text = "IP";
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(81, 30);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.Size = new System.Drawing.Size(150, 22);
            this.txtLocalIP.TabIndex = 2;
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(81, 63);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(79, 22);
            this.txtLocalPort.TabIndex = 3;
            // 
            // txtRemotelPort
            // 
            this.txtRemotelPort.Location = new System.Drawing.Point(77, 63);
            this.txtRemotelPort.Name = "txtRemotelPort";
            this.txtRemotelPort.Size = new System.Drawing.Size(74, 22);
            this.txtRemotelPort.TabIndex = 4;
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(77, 33);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(150, 22);
            this.txtRemoteIP.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(12, 357);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(545, 22);
            this.txtMessage.TabIndex = 3;
            // 
            // lstMessage
            // 
            this.lstMessage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.ItemHeight = 14;
            this.lstMessage.Location = new System.Drawing.Point(12, 157);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(545, 186);
            this.lstMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(564, 356);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 389);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBoxFriend);
            this.Controls.Add(this.groupBoxMe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAT APPLICATION";
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.groupBoxMe.ResumeLayout(false);
            this.groupBoxMe.PerformLayout();
            this.groupBoxFriend.ResumeLayout(false);
            this.groupBoxFriend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMe;
        private System.Windows.Forms.Label lblPortMe;
        private System.Windows.Forms.Label lblIPMe;
        private System.Windows.Forms.GroupBox groupBoxFriend;
        private System.Windows.Forms.Label lblPortFriend;
        private System.Windows.Forms.Label lblIPFriend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.TextBox txtLocalIP;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.TextBox txtRemotelPort;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.Button btnSend;
    }
}

