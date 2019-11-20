namespace LoginForm
{
    partial class ViewListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdViewList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewAZ = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewId = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewList
            // 
            this.grdViewList.AllowUserToAddRows = false;
            this.grdViewList.AllowUserToDeleteRows = false;
            this.grdViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewList.Location = new System.Drawing.Point(0, 28);
            this.grdViewList.Name = "grdViewList";
            this.grdViewList.Size = new System.Drawing.Size(284, 191);
            this.grdViewList.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.viewItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDel,
            this.btnEdit});
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addItemToolStripMenuItem.Text = "Edit item";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 22);
            this.btnAdd.Text = "Add item";
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(152, 22);
            this.btnDel.Text = "Delete item";
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 22);
            this.btnEdit.Text = "Edit item";
            // 
            // viewItemToolStripMenuItem
            // 
            this.viewItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewAZ,
            this.btnViewNumber,
            this.btnViewId});
            this.viewItemToolStripMenuItem.Name = "viewItemToolStripMenuItem";
            this.viewItemToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.viewItemToolStripMenuItem.Text = "View item";
            // 
            // btnViewAZ
            // 
            this.btnViewAZ.Name = "btnViewAZ";
            this.btnViewAZ.Size = new System.Drawing.Size(158, 22);
            this.btnViewAZ.Text = "A-Z";
            // 
            // btnViewNumber
            // 
            this.btnViewNumber.Name = "btnViewNumber";
            this.btnViewNumber.Size = new System.Drawing.Size(158, 22);
            this.btnViewNumber.Text = "Number remain";
            // 
            // btnViewId
            // 
            this.btnViewId.Name = "btnViewId";
            this.btnViewId.Size = new System.Drawing.Size(158, 22);
            this.btnViewId.Text = "ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(183, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ViewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdViewList);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewListForm";
            this.Text = "ViewListForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem viewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnViewAZ;
        private System.Windows.Forms.ToolStripMenuItem btnViewNumber;
        private System.Windows.Forms.ToolStripMenuItem btnViewId;
        private System.Windows.Forms.Button btnClose;
    }
}