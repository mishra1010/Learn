using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagement.Models
{
    public class MockEmployeeRepocitory : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepocitory()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name ="Mary", Department = Dept.HR, Email = "x@y.com"},
                new Employee() { Id = 2, Name = "Mary2", Department = Dept.IT, Email = "x@y.com" },
                new Employee(){Id = 3, Name ="Mary3", Department = Dept.IT, Email = "x@y.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
