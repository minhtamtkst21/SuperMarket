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
    public partial class ViewListForm : Form
    {
        public ViewListForm()
        {
            InitializeComponent();
            this.btnClose.Click += btnClose_Click;
            this.btnHome.Click += btnHome_Click;
        }

        void btnHome_Click(object sender, EventArgs e)
        {
            var main = new SMForm();
            main.ShowDialog();
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
