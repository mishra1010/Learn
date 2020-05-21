﻿using System;
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

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
