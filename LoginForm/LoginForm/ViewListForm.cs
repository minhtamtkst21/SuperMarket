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
            this.Load += ViewListForm_Load;
            this.btnAdd.Click += btnAdd_Click;
            this.btnDel.Click += btnDel_Click;
            this.btnEdit.Click += btnEdit_Click;
            this.btnViewAZ.Click += btnViewAZ_Click;
            this.btnViewNumber.Click += btnViewNumber_Click;
            this.btnViewId.Click += btnViewId_Click;
            this.grdViewList.DoubleClick += grdViewList_DoubleClick;
        }

        void grdViewList_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnViewId_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnViewNumber_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnViewAZ_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void ViewListForm_Load(object sender, EventArgs e)
        {
            
        }
        void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
