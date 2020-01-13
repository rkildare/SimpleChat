namespace SimpleChat
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocPort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemIP = new System.Windows.Forms.TextBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.rtxtOut = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLocPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLocIP);
            this.groupBox1.Location = new System.Drawing.Point(343, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // txtLocIP
            // 
            this.txtLocIP.Location = new System.Drawing.Point(70, 13);
            this.txtLocIP.Name = "txtLocIP";
            this.txtLocIP.Size = new System.Drawing.Size(100, 20);
            this.txtLocIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // txtLocPort
            // 
            this.txtLocPort.Location = new System.Drawing.Point(70, 39);
            this.txtLocPort.Name = "txtLocPort";
            this.txtLocPort.Size = new System.Drawing.Size(100, 20);
            this.txtLocPort.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRemPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRemIP);
            this.groupBox2.Location = new System.Drawing.Point(528, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 73);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // txtRemPort
            // 
            this.txtRemPort.Location = new System.Drawing.Point(70, 39);
            this.txtRemPort.Name = "txtRemPort";
            this.txtRemPort.Size = new System.Drawing.Size(100, 20);
            this.txtRemPort.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "IP Address";
            // 
            // txtRemIP
            // 
            this.txtRemIP.Location = new System.Drawing.Point(70, 13);
            this.txtRemIP.Name = "txtRemIP";
            this.txtRemIP.Size = new System.Drawing.Size(100, 20);
            this.txtRemIP.TabIndex = 0;
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(713, 22);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(75, 24);
            this.btnHost.TabIndex = 5;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(712, 51);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 24);
            this.btnConn.TabIndex = 6;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(14, 91);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(774, 250);
            this.rtxtLog.TabIndex = 7;
            this.rtxtLog.Text = "";
            // 
            // rtxtOut
            // 
            this.rtxtOut.Location = new System.Drawing.Point(13, 348);
            this.rtxtOut.Name = "rtxtOut";
            this.rtxtOut.Size = new System.Drawing.Size(694, 64);
            this.rtxtOut.TabIndex = 8;
            this.rtxtOut.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(714, 348);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 64);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtxtOut);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.btnHost);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemIP;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.RichTextBox rtxtOut;
        private System.Windows.Forms.Button btnSend;
    }
}

