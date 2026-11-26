using crud_test_solid2.Interfaces;
using crud_test_solid2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_test_solid2.Services
{
    public class EmployeeManager
    {
        private IEmployeeManager _repo;

        public EmployeeManager(IEmployeeManager repo) {
            _repo = repo;
        }
        public void AddEmployee(Employee e) {
            _repo.Save(e);
        }


        public Employee getEmployeeByID(int id) {
            return _repo.GetById(id);
        }


        public List<Employee> GetAllEmployees()
        {
            return _repo.GetEmployeeList();
        }
    }
}
