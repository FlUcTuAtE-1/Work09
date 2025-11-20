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
    public partial class FrmSearchEmployee : Form
    {
        IEmployeeManager MySQLContext = new MySQLEmployeeContext();

        public FrmSearchEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate if text is empty.
            if (txtIDkey.Text == "") return;
            
            //validate if text is not a number.
            int id;
            if(!int.TryParse(txtIDkey.Text, out id)) return;

            EmployeeManager emp = new EmployeeManager(MySQLContext);
            RegularEmployee employeeFound = new RegularEmployee();

            employeeFound =  (RegularEmployee)emp.getEmployeeByID(id);

            if (employeeFound == null) {
                MessageBox.Show("Employee not found.");
                clearFields();
                return;
            }

            //map data to UI
            txtLname.Text = employeeFound.Lastname;
            txtFname.Text = employeeFound.Firstname;
            txtMname.Text = employeeFound.Middlename;
            txtBday.Text = employeeFound.Birthdate.ToString("MMMM dd yyyy");
            txtGender.Text = employeeFound.Gender;
            txtAddress.Text = employeeFound.Address;
        }


        private void clearFields()
        {
            txtLname.Text = "";
            txtFname.Text = "";
            txtMname.Text = "";
            txtBday.Text = "";
            txtGender.Text = "";
            txtAddress.Text = "";
        }
    }
}
