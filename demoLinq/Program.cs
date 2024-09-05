using TCPData;
using TCPExtensions;

namespace demoLinq
{
    class Program
    {
        static  void Main(string[] args)
        {
            //List<Employee> employeeList = Data.GetEmployees();
            //var filteredEmployees = employeeList.Filter(emp => emp.AnnualSalary > 50000);
            //foreach (var employee in filteredEmployees)
            //{
            //    Console.WriteLine($"Firs Name: {employee.FirsName}");
            //    Console.WriteLine($"Last Name: {employee.LastName}");
            //    Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
            //    Console.WriteLine($"Manager: {employee.IsManager}");
            //    Console.WriteLine();
            //}
            //Console.ReadKey();



            //List<Department> departmentList = Data.GetDepartments();
            //var filtereDepartment = departmentList.Filter(emp => emp.Id > 1);
            //foreach (var department in filtereDepartment) 
            //{
            //    Console.WriteLine($"Id: {department.Id}");
            //    Console.WriteLine($"Short Name: {department.ShortName}");
            //    Console.WriteLine($"Long Name: {department.LongName}");
                    
            //}
            //Console.ReadKey();


            List<Employee> employeeList = Data.GetEmployees();
            List<Department>  departmentList = Data.GetDepartments();

            var resultList = from emp in employeeList
                             join dept in departmentList
                             on emp.DepartmenId equals dept.Id
                             select new
                             {
                                 FirsName = emp.FirsName,
                                 LastName = emp.LastName,
                                 AnnualSalary = emp.AnnualSalary,
                                 Manager = emp.IsManager,
                                 Department = dept.LongName


                             };
            foreach (var employee in resultList)
            {
                Console.WriteLine($"Firs Name: {employee.FirsName}");
                Console.WriteLine($"Last Name: {employee.LastName}");
                Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
                Console.WriteLine($"Manager: {employee.Manager}");
                Console.WriteLine($"Department: {employee.Department}");
                Console.WriteLine();
            }
            var Tb = resultList.Average(a => a.AnnualSalary);
            var cao = resultList.Max(a => a.AnnualSalary);
            var thap = resultList.Min(a => a.AnnualSalary);
            Console.WriteLine($"Trung Binh: {Tb}");
            Console.WriteLine($"Cao nhat: {cao}");
            Console.WriteLine($"Thap nhat: {thap}");
            Console.ReadKey();


        }
    }
}