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

namespace Kursovaya
{
    public partial class Messenger : Form
    {
        List<string> mes = new List<string>();
        public Messenger()
        {
            InitializeComponent();
            COM1ComboBox.Items.AddRange(SerialPort.GetPortNames());
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
    }
}
