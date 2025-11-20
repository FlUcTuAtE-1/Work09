using crud_test_solid2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_test_solid2.Interfaces
{
    public interface IEmployeeManager
    {
         void Save(Employee e);
         Employee GetById(int id);
         List<Employee> GetEmployeeList();
    }
}
