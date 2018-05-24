namespace SocketServer
{
    partial class ServerForm
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
            this.Listen_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartServer_button = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_IPAdress = new System.Windows.Forms.TextBox();
            this.Receive_textBox = new System.Windows.Forms.TextBox();
            this.SendtextBox = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.Send_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Listen_backgroundWorker
            // 
            this.Listen_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Listen_backgroundWorker_DoWork);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Server";
            // 
            // StartServer_button
            // 
            this.StartServer_button.Location = new System.Drawing.Point(97, 65);
            this.StartServer_button.Name = "StartServer_button";
            this.StartServer_button.Size = new System.Drawing.Size(423, 21);
            this.StartServer_button.TabIndex = 20;
            this.StartServer_button.Text = "Start Server";
            this.StartServer_button.UseVisualStyleBackColor = true;
            this.StartServer_button.Click += new System.EventHandler(this.StartServer_button_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(420, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 19;
            // 
            // tb_IPAdress
            // 
            this.tb_IPAdress.Location = new System.Drawing.Point(97, 35);
            this.tb_IPAdress.Name = "tb_IPAdress";
            this.tb_IPAdress.Size = new System.Drawing.Size(100, 21);
            this.tb_IPAdress.TabIndex = 18;
            // 
            // Receive_textBox
            // 
            this.Receive_textBox.Location = new System.Drawing.Point(8, 174);
            this.Receive_textBox.Multiline = true;
            this.Receive_textBox.Name = "Receive_textBox";
            this.Receive_textBox.Size = new System.Drawing.Size(622, 172);
            this.Receive_textBox.TabIndex = 17;
            // 
            // SendtextBox
            // 
            this.SendtextBox.Location = new System.Drawing.Point(9, 351);
            this.SendtextBox.Multiline = true;
            this.SendtextBox.Name = "SendtextBox";
            this.SendtextBox.Size = new System.Drawing.Size(540, 43);
            this.SendtextBox.TabIndex = 16;
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(555, 351);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(75, 42);
            this.Send_button.TabIndex = 15;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // Send_backgroundWorker
            // 
            this.Send_backgroundWorker.WorkerSupportsCancellation = true;
            this.Send_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Send_backgroundWorker_DoWork);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 414);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartServer_button);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tb_IPAdress);
            this.Controls.Add(this.Receive_textBox);
            this.Controls.Add(this.SendtextBox);
            this.Controls.Add(this.Send_button);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker Listen_backgroundWorker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartServer_button;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_IPAdress;
        private System.Windows.Forms.TextBox Receive_textBox;
        private System.Windows.Forms.TextBox SendtextBox;
        private System.Windows.Forms.Button Send_button;
        private System.ComponentModel.BackgroundWorker Send_backgroundWorker;
    }
}

