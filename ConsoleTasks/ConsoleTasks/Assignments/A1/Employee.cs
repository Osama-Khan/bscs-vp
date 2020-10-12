using System;

namespace ConsoleTasks.Assignments.A1
{
    class Employee
    {
        string name;
        int id;
        int salary;

        public Employee()
        {
            name = "";
            id = -1;
            salary = -1;
        }

        ~Employee()
        {
            Console.WriteLine(string.Format("Employee object with id {0} destroyed", id));
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getSalary()
        {
            return salary;
        }

        public void setSalary(int salary)
        {
            if (salary < 0) this.salary = -1;
            else this.salary = salary;
        }
    }
}
