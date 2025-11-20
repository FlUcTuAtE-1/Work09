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
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_test_solid2
{
    public partial class FrmEmployeeForm : Form
    {

        IEmployeeManager MySQLContext = new MySQLEmployeeContext();
        //IEmployeeManager MySQLContext = new MSSQLEmployeeContext();

        public FrmEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeManager empMgr = new EmployeeManager(MySQLContext);

            RegularEmployee emp1 = new RegularEmployee() { 
                Lastname = txtLname.Text, 
                Firstname = txtFname.Text,
                Middlename = txtMname.Text,
                Gender = txtGender.Text,
                Address = txtAddress.Text,
                Birthdate = dtBday.Value,
            };

            empMgr.AddEmployee(emp1);
        }
    }
}
