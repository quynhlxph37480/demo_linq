using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee
            {
                Id = 1,
                FirsName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000,
                IsManager = true,
                DepartmenId = 1,

            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirsName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000,
                IsManager = false,
                DepartmenId = 2,

            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirsName = "quynh",
                LastName = "le",
                AnnualSalary = 40000,
                IsManager = false,
                DepartmenId = 2,

            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 4,
                FirsName = "shit",
                LastName = "cut",
                AnnualSalary = 30000,
                IsManager = true,
                DepartmenId = 3,

            };
            employees.Add(employee);
            return employees;
        }
        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            Department department = new Department 
            { 
            Id =1,
            ShortName= "HR",
            LongName = "hum ra"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Fum Na"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 3  ,
                ShortName = "TE",
                LongName = "Tum Ea"
            };
            departments.Add(department);
            return departments;
        }
    }
}
