using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHW
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.ShowDialog();

        }

         public void button1_Click(object sender, EventArgs e)
        {
            Data.users.Add(new Users()
            {
                Name = textBox1.Text,
                firstName = textBox2.Text,
                phoneNumber = int.Parse(textBox3.Text),
                Login = textBox4.Text,
                Password = textBox5.Text,
                eMail = textBox6.Text
            });
            Start start = new Start();
            this.Hide();
            start.ShowDialog();
        }
    }
}
