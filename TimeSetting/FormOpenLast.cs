using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSetting
{
    public partial class FormOpenLast : Form
    {
        DateTime date;

        public FormOpenLast (DateTime date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void FormOpenLast_Load (object sender, EventArgs e)
        {
            textBoxDay.Text = date.Day.ToString();
            comboBoxMonth.SelectedIndex = date.Month - 1;
            textBoxYear.Text = date.Year.ToString();
            textBoxHour.Text = date.Hour.ToString();
            textBoxMin.Text = date.Minute.ToString();
        }

        private void buttonSet_Click (object sender, EventArgs e)
        {
            try
            {
                DateTime dt = new DateTime(Convert.ToInt32(textBoxYear.Text),
                                           comboBoxMonth.SelectedIndex + 1,
                                           Convert.ToInt32(textBoxDay.Text),
                                           Convert.ToInt32(textBoxHour.Text),
                                           Convert.ToInt32(textBoxMin.Text),
                                           0);
                TimeSetter ts = new TimeSetter();
                ts.ChangeTime(dt);
                MessageBox.Show(dt.ToString());
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }
    }
}
