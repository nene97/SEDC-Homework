using Domain.Enums;
using Domain.Models;

Employee employee = new Employee("Petko", "Petkovski", RoleEnum.Other, 600);

employee.PrintInfo();
double employeesSalary = employee.GetSalary();
Console.WriteLine(employeesSalary);



SalesPerson salesPerson = new SalesPerson("Stefan", "Strfanovski", 0);
salesPerson.PrintInfo();

salesPerson.AddSuccessRevenue(1500);

Console.WriteLine(salesPerson.GetSalary());



Manager manager = new Manager("Nikola" , "Nikolovski" , RoleEnum.Manager , 1000);
manager.PrintInfo();

manager.AddBonus(100);
double managerSlary = manager.GetSalary();
Console.WriteLine($"The salary is : {managerSlary}");
manager.AddBonus(150);
managerSlary = manager.GetSalary();
Console.WriteLine($"The salary is : {managerSlary}");


