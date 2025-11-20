using crud_test_solid2.DBContext;
using crud_test_solid2.Interfaces;
using crud_test_solid2.Models;
using crud_test_solid2.Services;
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
    public partial class FrmEmpployeeList : Form
    {
        IEmployeeManager MySQLContext = new MySQLEmployeeContext();
        public FrmEmpployeeList()
        {
            InitializeComponent();
        }

        private void FrmEmpployeeList_Load(object sender, EventArgs e)
        {
            EmployeeManager empMgr = new EmployeeManager(MySQLContext);
            List<Employee> empList = new List<Employee>();

            empList = empMgr.GetAllEmployees();

            Console.WriteLine(empList.Count);

            dgEmployeeList.DataSource = empList;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure, you want to remove employee?", "Remove Employee", MessageBoxButtons.YesNo);
            if (choice == DialogResult.No) return;

            EmployeeManager empMgr = new EmployeeManager(MySQLContext);
            int id =int.Parse(dgEmployeeList.CurrentRow.Cells[0].Value.ToString());

            MessageBox.Show(empMgr.getEmployeeByID(id).GetFullName(),"Empoyee Removed!");
        }

        private void dgEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
