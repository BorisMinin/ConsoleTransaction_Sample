// See https://aka.ms/new-console-template for more information
using ConsoleTransaction_Sample.Data;

Console.WriteLine("Ласкаво просимо до транзакции без транзакции");
var context = new SchoolContext();

var courses = context.Courses.ToList();
Console.WriteLine(courses);
Console.ReadLine();