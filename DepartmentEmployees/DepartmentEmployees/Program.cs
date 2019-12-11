using DepartmentsEmployees.Data;
using DepartmentsEmployees.Models;
using System;

namespace DepartmentsEmployees
{
    class Program
    {
        private static string lastName;

        static void Main(string[] args)
        {
            //// Get All Departments
            //var departmentRepo = new DepartmentRepository();
            //var allDepartments = departmentRepo.GetAllDepartments();

            //Console.WriteLine("All Departments");
            //Console.WriteLine("---------------");
            //foreach (var dept in allDepartments)
            //{
            //    Console.WriteLine(dept.DepartmentName);
            //}
            //// Get Department by Id
            //var hardCodedId = 3;
            //var departmentWithId3 = departmentRepo.GetDepartmentById(hardCodedId);
            //Console.WriteLine("---------------");
            //Console.WriteLine($"Department with id {hardCodedId} is {departmentWithId3.DepartmentName}");


            // Get all Employees
            var employeeRepo = new EmployeeRepository();
            var allEmployees = employeeRepo.GetAllEmployees();

            Console.WriteLine("All Employees");
            Console.WriteLine("---------------");
            foreach (var employee in allEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.DeptName}");
            }

            // Get Employee by Id
            var employeeHardCodedId = 3;
            var employeeWithId4 = employeeRepo.GetEmployeeById(employeeHardCodedId);
            Console.WriteLine("---------------");
            Console.WriteLine($"Employee with id {employeeHardCodedId} is {employeeWithId4.FirstName}{employeeWithId4.LastName}");

            Console.WriteLine();
            Console.WriteLine();
         

            Console.WriteLine("-----------------");

            //// Add a new Department
            //var legal = new Department();
            //Console.WriteLine("What department do you like to add?");
            //legal.DepartmentName = Console.ReadLine();
            //departmentRepo.AddDepartment(legal);

            //// Update a Department
            //Console.WriteLine("What Department (ID) would you like to update?");
            //var departmentToUpdate = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("What should the new department name be called?");
            //var newDepartmentName = Console.ReadLine();
            //departmentRepo.UpdateDepartment(departmentToUpdate, new Department { DepartmentName = newDepartmentName });

            //// Delete a Department
            //Console.WriteLine("What Department (ID) would you like to delete?");
            //var departmentDelete = Int32.Parse(Console.ReadLine());
            //departmentRepo.DeleteDepartment(departmentDelete);

            //// Add a new Employee
            //var newEmployee = new Employee();
            //Console.WriteLine("What is your Employee's first name?");
            //newEmployee.FirstName = Console.ReadLine();
            //Console.WriteLine("What is your Employee's last name?");
            //newEmployee.LastName = Console.ReadLine();
            //Console.WriteLine("What department does your Employee work in?");
            //newEmployee.DepartmentId = Int32.Parse(Console.ReadLine());

            //employeeRepo.AddEmployee(newEmployee);


            ////// Update an Employee
            //Console.WriteLine("What is the ID of the Employee would you like to update?");
            //var employeeToUpdate = Int32.Parse(Console.ReadLine());
          
            //var updateEmployee = new Employee();
            //Console.WriteLine("What is the employee's new first name?");
            //updateEmployee.FirstName = Console.ReadLine();
            //Console.WriteLine("What is the employee's new first name?");
            //updateEmployee.LastName = Console.ReadLine();
            //Console.WriteLine("What is the new department (ID) of your employee?");
            //updateEmployee.DepartmentId = Int32.Parse(Console.ReadLine());

            //employeeRepo.UpdateEmployee(employeeToUpdate, updateEmployee);

            //// Delete a Department
            Console.WriteLine("What Employee (ID) would you like to delete?");
            var employeeDelete = Int32.Parse(Console.ReadLine());
            employeeRepo.DeleteEmployee(employeeDelete);

        }
    }
}
