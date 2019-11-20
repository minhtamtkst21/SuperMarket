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
    public partial class SMForm : Form
    {
        public SMForm()
        {
            InitializeComponent();
            this.btnViewList.Click += btnViewList_Click;
            this.btnClose.Click += btnClose_Click;
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnViewList_Click(object sender, EventArgs e)
        {
            var ViewList = new ViewListForm();
            ViewList.ShowDialog();
        }
    }
}
