using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Kursovaya
{
    public partial class Messenger : Form
    {
        List<string> mes = new List<string>();
        public Messenger()
        {
            InitializeComponent();
            COM1ComboBox.Items.AddRange(SerialPort.GetPortNames());
            COM2ComboBox.Items.AddRange(SerialPort.GetPortNames());
            SetDefaults();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string NewMes = MessageBoxSend.Text;
            mes.Add(NewMes);
            HistoryBox.Items.Add("Новое сообщение!");

        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            int CountNewMes = mes.Count;
            if (CountNewMes != 0)
            {
                int CountMes = HistoryBox.Items.Count;
                HistoryBox.Items[CountMes - CountNewMes] = mes[0];
                mes.RemoveAt(0);
            }
            //HistoryBox.Items[CountMes - 1] = mes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void COM1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SetDefaults()
        {
            COM1ComboBox.SelectedIndex = 0;
            COM2ComboBox.SelectedIndex = 1;
            Speed1ComboBox.SelectedIndex = 5;
            Speed2ComboBox.SelectedIndex = 5;
            Parity1Box.SelectedIndex = 0;
            Parity2Box.SelectedIndex = 0;
            StopBits1Box.SelectedIndex = 1;
            StopBits2Box.SelectedIndex = 1;
            DataBits1Box.SelectedIndex = 1;
            DataBits2Box.SelectedIndex = 1;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            HistoryBox.Items.Add("Установка соединения...");
            this.Refresh();
            string COMName1 = COM1ComboBox.SelectedItem.ToString(); 
            string COMName2 = COM2ComboBox.SelectedItem.ToString();
            int Speed1 = Convert.ToInt32(Speed1ComboBox.SelectedItem.ToString());
            int Speed2 = Convert.ToInt32(Speed2ComboBox.SelectedItem.ToString());
            int DataBits1 = Convert.ToInt32(DataBits1Box.SelectedItem.ToString());
            int DataBits2 = Convert.ToInt32(DataBits2Box.SelectedItem.ToString());
            string strStopBit1 = StopBits1Box.SelectedItem.ToString();
            string strStopBit2 = StopBits2Box.SelectedItem.ToString();
            string strParity1 = Parity1Box.SelectedItem.ToString();
            string strParity2 = Parity2Box.SelectedItem.ToString();
            int StopBit1 = 0;
            int StopBit2 = 0;
            byte Parity1 = 0;
            byte Parity2 = 0;
            switch (strStopBit1)
            {
                case "None":
                    StopBit1 = 0;
                    break;
                case "One":
                    StopBit1 = 1;
                    break;
                case "OnePointFive":
                    StopBit1 = 3;
                    break;
                case "Two":
                    StopBit1 = 2;
                    break;
            }
            switch (strStopBit2)
            {
                case "None":
                    StopBit2 = 0;
                    break;
                case "One":
                    StopBit2 = 1;
                    break;
                case "OnePointFive":
                    StopBit2 = 3;
                    break;
                case "Two":
                    StopBit2 = 2;
                    break;
            }
            switch (strParity1)
            {
                case "Even":
                    Parity1 = 2;
                    break;
                case "Mark":
                    Parity1 = 3;
                    break;
                case "None":
                    Parity1 = 0;
                    break;
                case "Odd":
                    Parity1 = 1;
                    break;
                case "Space":
                    Parity1 = 4;
                    break;
            }
            switch (strParity2)
            {
                case "Even":
                    Parity2 = 2;
                    break;
                case "Mark":
                    Parity2 = 3;
                    break;
                case "None":
                    Parity2 = 0;
                    break;
                case "Odd":
                    Parity2 = 1;
                    break;
                case "Space":
                    Parity2 = 4;
                    break;
            }
            Phislvl.com_params params1 = new Phislvl.com_params(
                COMName1,
                Speed1,
                DataBits1,
                StopBit1,
                Parity1);            
            Phislvl.com_params params2 = new Phislvl.com_params(
                COMName2,
                Speed2,
                DataBits2,
                StopBit2,
                Parity2);
            Phislvl connectflag = new Phislvl();
            int f = connectflag.Connect(params1, params2);
            if (f == 1)
                HistoryBox.Items.Add("Соединение установлено");
            if (f == 0)
                HistoryBox.Items.Add("Не удалось установить связь (таймаут)");
            if (f == 2)
                HistoryBox.Items.Add("Порты заняты");
        }
    }
}

