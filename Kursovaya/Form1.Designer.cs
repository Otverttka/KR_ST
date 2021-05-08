
namespace Kursovaya
{
    partial class Messenger
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageBoxSend = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.AdressComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NikNameBox = new System.Windows.Forms.TextBox();
            this.NikNameOkButton = new System.Windows.Forms.Button();
            this.COM1ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.COM2ComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Speed1ComboBox = new System.Windows.Forms.ComboBox();
            this.Speed2ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataBits1Box = new System.Windows.Forms.ComboBox();
            this.DataBits2Box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StopBits1Box = new System.Windows.Forms.ComboBox();
            this.StopBits2Box = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Parity1Box = new System.Windows.Forms.ComboBox();
            this.Parity2Box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MessageBoxSend
            // 
            this.MessageBoxSend.Location = new System.Drawing.Point(66, 340);
            this.MessageBoxSend.Name = "MessageBoxSend";
            this.MessageBoxSend.Size = new System.Drawing.Size(378, 20);
            this.MessageBoxSend.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(450, 337);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // AdressComboBox
            // 
            this.AdressComboBox.FormattingEnabled = true;
            this.AdressComboBox.Location = new System.Drawing.Point(296, 25);
            this.AdressComboBox.Name = "AdressComboBox";
            this.AdressComboBox.Size = new System.Drawing.Size(148, 21);
            this.AdressComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Addressee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NikName";
            // 
            // NikNameBox
            // 
            this.NikNameBox.Location = new System.Drawing.Point(66, 26);
            this.NikNameBox.Name = "NikNameBox";
            this.NikNameBox.Size = new System.Drawing.Size(143, 20);
            this.NikNameBox.TabIndex = 7;
            // 
            // NikNameOkButton
            // 
            this.NikNameOkButton.Location = new System.Drawing.Point(215, 23);
            this.NikNameOkButton.Name = "NikNameOkButton";
            this.NikNameOkButton.Size = new System.Drawing.Size(38, 23);
            this.NikNameOkButton.TabIndex = 8;
            this.NikNameOkButton.Text = "Ok";
            this.NikNameOkButton.UseVisualStyleBackColor = true;
            // 
            // COM1ComboBox
            // 
            this.COM1ComboBox.FormattingEnabled = true;
            this.COM1ComboBox.Location = new System.Drawing.Point(505, 81);
            this.COM1ComboBox.Name = "COM1ComboBox";
            this.COM1ComboBox.Size = new System.Drawing.Size(92, 21);
            this.COM1ComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "COM1:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(578, 337);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 11;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(659, 337);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 12;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            // 
            // HistoryBox
            // 
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.Location = new System.Drawing.Point(66, 81);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(378, 225);
            this.HistoryBox.TabIndex = 13;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(66, 52);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 14;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "COM2:";
            // 
            // COM2ComboBox
            // 
            this.COM2ComboBox.FormattingEnabled = true;
            this.COM2ComboBox.Location = new System.Drawing.Point(642, 81);
            this.COM2ComboBox.Name = "COM2ComboBox";
            this.COM2ComboBox.Size = new System.Drawing.Size(92, 21);
            this.COM2ComboBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Speed";
            // 
            // Speed1ComboBox
            // 
            this.Speed1ComboBox.FormattingEnabled = true;
            this.Speed1ComboBox.Location = new System.Drawing.Point(505, 127);
            this.Speed1ComboBox.Name = "Speed1ComboBox";
            this.Speed1ComboBox.Size = new System.Drawing.Size(92, 21);
            this.Speed1ComboBox.TabIndex = 18;
            // 
            // Speed2ComboBox
            // 
            this.Speed2ComboBox.FormattingEnabled = true;
            this.Speed2ComboBox.Location = new System.Drawing.Point(642, 127);
            this.Speed2ComboBox.Name = "Speed2ComboBox";
            this.Speed2ComboBox.Size = new System.Drawing.Size(92, 21);
            this.Speed2ComboBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "DataBits";
            // 
            // DataBits1Box
            // 
            this.DataBits1Box.FormattingEnabled = true;
            this.DataBits1Box.Location = new System.Drawing.Point(505, 178);
            this.DataBits1Box.Name = "DataBits1Box";
            this.DataBits1Box.Size = new System.Drawing.Size(92, 21);
            this.DataBits1Box.TabIndex = 21;
            // 
            // DataBits2Box
            // 
            this.DataBits2Box.FormattingEnabled = true;
            this.DataBits2Box.Location = new System.Drawing.Point(642, 178);
            this.DataBits2Box.Name = "DataBits2Box";
            this.DataBits2Box.Size = new System.Drawing.Size(92, 21);
            this.DataBits2Box.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "StopBits";
            // 
            // StopBits1Box
            // 
            this.StopBits1Box.FormattingEnabled = true;
            this.StopBits1Box.Location = new System.Drawing.Point(505, 227);
            this.StopBits1Box.Name = "StopBits1Box";
            this.StopBits1Box.Size = new System.Drawing.Size(92, 21);
            this.StopBits1Box.TabIndex = 24;
            // 
            // StopBits2Box
            // 
            this.StopBits2Box.FormattingEnabled = true;
            this.StopBits2Box.Location = new System.Drawing.Point(642, 227);
            this.StopBits2Box.Name = "StopBits2Box";
            this.StopBits2Box.Size = new System.Drawing.Size(92, 21);
            this.StopBits2Box.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Parity";
            // 
            // Parity1Box
            // 
            this.Parity1Box.FormattingEnabled = true;
            this.Parity1Box.Location = new System.Drawing.Point(505, 275);
            this.Parity1Box.Name = "Parity1Box";
            this.Parity1Box.Size = new System.Drawing.Size(92, 21);
            this.Parity1Box.TabIndex = 27;
            // 
            // Parity2Box
            // 
            this.Parity2Box.FormattingEnabled = true;
            this.Parity2Box.Location = new System.Drawing.Point(642, 275);
            this.Parity2Box.Name = "Parity2Box";
            this.Parity2Box.Size = new System.Drawing.Size(92, 21);
            this.Parity2Box.TabIndex = 28;
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Parity2Box);
            this.Controls.Add(this.Parity1Box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StopBits2Box);
            this.Controls.Add(this.StopBits1Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataBits2Box);
            this.Controls.Add(this.DataBits1Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Speed2ComboBox);
            this.Controls.Add(this.Speed1ComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.COM2ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COM1ComboBox);
            this.Controls.Add(this.NikNameOkButton);
            this.Controls.Add(this.NikNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdressComboBox);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.MessageBoxSend);
            this.Name = "Messenger";
            this.Text = "Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageBoxSend;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ComboBox AdressComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NikNameBox;
        private System.Windows.Forms.Button NikNameOkButton;
        private System.Windows.Forms.ComboBox COM1ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.ListBox HistoryBox;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COM2ComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Speed1ComboBox;
        private System.Windows.Forms.ComboBox Speed2ComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DataBits1Box;
        private System.Windows.Forms.ComboBox DataBits2Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StopBits1Box;
        private System.Windows.Forms.ComboBox StopBits2Box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Parity1Box;
        private System.Windows.Forms.ComboBox Parity2Box;
    }
}

