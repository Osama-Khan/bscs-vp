using System;

namespace ConsoleTasks.Assignments.A1
{
    class Employee
    {
        string name;
        int id;
        int salary;

        public Employee(string name, int id, int salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary >= 0 ? salary : -1;
        }

        ~Employee()
        {
            Console.WriteLine(string.Format("Employee object with id {0} destroyed", id));
        }

        public void setData()
        {
            Console.Write("Enter Name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter ID: ");
            this.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            var s = int.Parse(Console.ReadLine());
            salary = s >= 0 ? s : -1;
        }

        public void getData()
        {
            Console.WriteLine("Data for Employee:");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }

        public void getAnnualSalary()
        {
            var s = salary * 12 - (salary * 12 * 0.04f);
            Console.WriteLine(name + "'s Annual Salary: " + s);
        }
    }
}
