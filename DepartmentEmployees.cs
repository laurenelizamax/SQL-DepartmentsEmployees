using DepartmentsEmployees.Data;
using DepartmentsEmployees.Models;
using System;

namespace DepartmentsEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get All Departments
            var departmentRepo = new DepartmentRepository();
            var allDepartments = departmentRepo.GetAllDepartments();

            Console.WriteLine("All Departments");
            Console.WriteLine("---------------");
            foreach (var dept in allDepartments)
            {
                Console.WriteLine(dept.DepartmentName);
            }
            // Get Department by Id
            var hardCodedId = 3;
            var departmentWithId3 = departmentRepo.GetDepartmentById(hardCodedId);
            Console.WriteLine("---------------");
            Console.WriteLine($"Department with id {hardCodedId} is {departmentWithId3.DepartmentName}");

            // Get all Employees
            var employeeRepo = new EmployeeRepository();
            var allEmployees = employeeRepo.GetAllEmployees();

            Console.WriteLine("All Employees");
            Console.WriteLine("-------------");
            foreach (var employee in allEmployees)
            {
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
            }

            // Get Employee by Id
            var emHardCodedId = 4;
            var employeeWithId4 = employeeRepo.GetEmployeeById(emHardCodedId);
            Console.WriteLine("-------------");
            Console.WriteLine($"{employeeWithId4.FirstName}{employeeWithId4.LastName}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Adding new department
            var legal = new Department();
            Console.WriteLine("What department would you lke to add?");
            legal.DepartmentName = Console.ReadLine();
            departmentRepo.AddDepartment(legal);

            // Updating a department
            Console.WriteLine("What department would you like to update?");
            var departmentToUpdate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What should the new department name be called?");
            var newDepartmentName = Console.ReadLine();

            departmentRepo.UpdateDepartment(departmentToUpdate, new Department { DepartmentName = newDepartmentName });


            // Deleting a department
            departmentRepo.DeleteDepartment(7);
            departmentRepo.DeleteDepartment(8);
            departmentRepo.DeleteDepartment(9);

        }
    }
}
