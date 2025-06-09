﻿using System.Globalization;
using Secao06_Ex_List;

List<Employee> list = new List<Employee>();

Console.Write("How many employees will be registered ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i <= number; i++)
{
    Console.WriteLine("Employee #" + i + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add(new Employee(id, name, salary));
}

Console.Write("Enter the employee id that will have salary increase: ");
int serachId = int.Parse(Console.ReadLine());

Employee emp = list.Find(x => x.Id == serachId);
if (emp != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employee obj in list)
{
    Console.WriteLine(obj);
}
