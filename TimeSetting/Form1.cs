using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TimeSetting
{
    public partial class Form1 : Form
    {
        DateTime serverTime;     // Time, retrieved from internet time server
        TimeSetter ts;           // Time setter instance

        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            ts = new TimeSetter();
            labelInfo.Text = "";
            GetTime();
            labelOutput.Text += serverTime.ToString();
        }

        /// <summary>
        /// Retrieve current time from time server in GMT +00:00
        /// </summary>
        private void GetTime ()
        {
            try
            {
                StreamReader rdr = new StreamReader(new TcpClient("132.163.4.102", 13).GetStream());
                string response = rdr.ReadToEnd();
                string[] rr = response.Split(' ');
                string day = rr[1];
                string[] dd = day.Split('-');
                day = dd[2] + "-" + dd[1] + "-" + dd[0];
                response = day + " " + rr[2];
                serverTime = Convert.ToDateTime(response).AddHours(3);
            }
            catch
            {
                MessageBox.Show("При получении данных с сервера произошла ошибка");
            }
        }

        private void buttonSetTime_Click (object sender, EventArgs e)
        {
            ts.ChangeTime(serverTime);
        }

        private void buttonRefresh_Click (object sender, EventArgs e)
        {
            GetTime();
            labelOutput.Text = "Время сервера: " + serverTime.ToString();
        }

        private void buttonRefresh_MouseEnter (object sender, EventArgs e)
        {
            labelInfo.Text = "Обновить время с сервера";
        }

        private void buttonRefresh_MouseLeave (object sender, EventArgs e)
        {
            labelInfo.Text = "";
        }

        private void buttonSetTime_MouseEnter (object sender, EventArgs e)
        {
            labelInfo.Text = "Сделать это время системным";
        }

        private void buttonOpenLast_MouseEnter (object sender, EventArgs e)
        {
            labelInfo.Text = "Открыть последние данные из файла";
        }

        private void buttonWrite_MouseEnter (object sender, EventArgs e)
        {
            labelInfo.Text = "Записать текущее СИСТЕМНОЕ время в файл";
        }

        private void buttonWrite_Click (object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"E:\time_setting.txt");
            if (fi.Exists)
                fi.Delete();
            FileStream fstr = fi.Create();
            fstr.Close();
            StreamWriter w = fi.CreateText();
            w.WriteLine(DateTime.Now.ToString());
            w.Close();
        }

        private void buttonOpenLast_Click (object sender, EventArgs e)
        {
            DateTime date = new DateTime();            
            foreach (string line in File.ReadLines(@"E:\time_setting.txt"))
                date = Convert.ToDateTime(line);
            FormOpenLast f = new FormOpenLast(date);
            f.ShowDialog();
        }
    }
}
