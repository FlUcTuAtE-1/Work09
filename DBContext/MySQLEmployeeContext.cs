using crud_test_solid2.Interfaces;
using crud_test_solid2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace crud_test_solid2.DBContext
{
    public class MySQLEmployeeContext : IEmployeeManager
    {
        private string _conStr = Helpers.MySQLHelpers.GetConnectionString();

        public void Save(Employee e)
        {

            using (MySqlConnection conn = new MySqlConnection(_conStr))
            {
                //resource manager for connection
                string sqlQry = "INSERT INTO " +
                                "tblemployee (Lname, Mname, Fname, Gender, Address, Bday) " +
                                "VALUES (@Lname, @Mname, @Fname, @Gender, @Address, @Bday)";

                using (MySqlCommand cmd = new MySqlCommand(sqlQry, conn))
                {
                    //resource manager for commands
                    //data mapping from model to table    

                    cmd.Parameters.AddWithValue("@Lname", e.Lastname);
                    cmd.Parameters.AddWithValue("@Mname", e.Middlename);
                    cmd.Parameters.AddWithValue("@Fname", e.Firstname);
                    cmd.Parameters.AddWithValue("@Gender", e.Gender);
                    cmd.Parameters.AddWithValue("@Address", e.Address);
                    cmd.Parameters.AddWithValue("@Bday", e.Birthdate);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee Added.", "New Employee", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    conn.Close();
                }
            } 
        }

        public Employee GetById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_conStr)) {
                string sqlQry = "Select * from tblemployee where id=@id";

                using (MySqlCommand cmd = new MySqlCommand(sqlQry, conn)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader()){

                        if (!reader.Read()) return null;

                        RegularEmployee emp = new RegularEmployee() {
                            Lastname = reader["Lname"].ToString(),
                            Firstname = reader["Fname"].ToString(),
                            Middlename = reader["Mname"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Address = reader["Address"].ToString(),
                            Birthdate = Convert.ToDateTime(reader["Bday"])
                        };

                        conn.Close();
                        return emp;
                    }
                }
            }

        }

        public List<Employee> GetEmployeeList() {

            using (MySqlConnection conn = new MySqlConnection(_conStr))
            {
                string sqlQry = "Select * from tblemployee";

                using (MySqlCommand cmd = new MySqlCommand(sqlQry, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader == null) return null;

                        List<Employee> empList = new List<Employee>();

                        while (reader.Read())
                        {
                            RegularEmployee emp = new RegularEmployee()
                            {
                                Lastname = reader["Lname"].ToString(),
                                Firstname = reader["Fname"].ToString(),
                                Middlename = reader["Mname"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Address = reader["Address"].ToString(),
                                Birthdate = Convert.ToDateTime(reader["Bday"])
                            };

                            emp.setID(Convert.ToInt32(reader["id"]));

                            empList.Add(emp);

                            Console.WriteLine(emp.Lastname);
                        }
                        conn.Close();
                        return empList;
                    }
                }
            }
        }
    }
}
