using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnOK.Click += btnOK_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text;
            string pass = this.txtPassword.Text;
            if(name=="vlu" && pass=="vlu")
            {
                var form = new SMForm();
                form.ShowDialog();
                this.Close();
            }
            else if(name != "vlu")
            {
                MessageBox.Show("Account does not exist!!!");
            }
            else
            {
                MessageBox.Show("Wrong password!!!");
            }
        }
    }
}
