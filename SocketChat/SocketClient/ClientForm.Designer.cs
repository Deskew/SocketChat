namespace SocketClient
{
    partial class ClientForm
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
            this.Send_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectToServer_button = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Receive_textBox = new System.Windows.Forms.TextBox();
            this.Send_textBox = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.Receive_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Send_backgroundWorker
            // 
            this.Send_backgroundWorker.WorkerSupportsCancellation = true;
            this.Send_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Send_backgroundWorker_DoWork);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Client";
            // 
            // ConnectToServer_button
            // 
            this.ConnectToServer_button.Location = new System.Drawing.Point(97, 100);
            this.ConnectToServer_button.Name = "ConnectToServer_button";
            this.ConnectToServer_button.Size = new System.Drawing.Size(423, 21);
            this.ConnectToServer_button.TabIndex = 19;
            this.ConnectToServer_button.Text = "Connect";
            this.ConnectToServer_button.UseVisualStyleBackColor = true;
            this.ConnectToServer_button.Click += new System.EventHandler(this.ConnectToServer_button_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(97, 70);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(420, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 17;
            // 
            // Receive_textBox
            // 
            this.Receive_textBox.Location = new System.Drawing.Point(8, 138);
            this.Receive_textBox.Multiline = true;
            this.Receive_textBox.Name = "Receive_textBox";
            this.Receive_textBox.Size = new System.Drawing.Size(622, 172);
            this.Receive_textBox.TabIndex = 16;
            // 
            // Send_textBox
            // 
            this.Send_textBox.Location = new System.Drawing.Point(9, 315);
            this.Send_textBox.Multiline = true;
            this.Send_textBox.Name = "Send_textBox";
            this.Send_textBox.Size = new System.Drawing.Size(540, 43);
            this.Send_textBox.TabIndex = 15;
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(555, 315);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(75, 42);
            this.Send_button.TabIndex = 14;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // Receive_backgroundWorker
            // 
            this.Receive_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Receive_backgroundWorker_DoWork);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConnectToServer_button);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Receive_textBox);
            this.Controls.Add(this.Send_textBox);
            this.Controls.Add(this.Send_button);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker Send_backgroundWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectToServer_button;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Receive_textBox;
        private System.Windows.Forms.TextBox Send_textBox;
        private System.Windows.Forms.Button Send_button;
        private System.ComponentModel.BackgroundWorker Receive_backgroundWorker;
    }
}

