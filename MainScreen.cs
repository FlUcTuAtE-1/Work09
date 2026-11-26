using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_test_solid2
{
    public partial class MainScreen : Form
    {
        private int childFormNumber = 0;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployeeForm frmEmployeeForm = new FrmEmployeeForm();
            frmEmployeeForm.MdiParent = this;
            frmEmployeeForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchEmployee frmSearch = new FrmSearchEmployee();
            frmSearch.MdiParent = this;
            frmSearch.Show();

        }

        private void viewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpployeeList frmList = new FrmEmpployeeList();
            frmList.MdiParent = this;
            frmList.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
