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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.users.Exists(x => x.Login == textBox1.Text)) {
                int index = Data.users.FindIndex(x => x.Login == textBox1.Text);
                if(Data.users[index].Password == textBox2.Text)
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    Error error = new Error();
                    error.Show();
                    this.Hide();
                }
            }
            else
            {
                Error error = new Error();
                error.Show();
                this.Hide();
            }

        }
    }
}
