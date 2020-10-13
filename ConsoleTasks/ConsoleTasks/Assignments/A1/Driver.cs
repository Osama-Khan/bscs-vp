/* 
 * PROBLEM:
 * Create a class called Employee that includes three pieces of information as data members,
 * a name (type string), ID (type integer) and a monthly salary (type integer). Employee class
 * should have a constructor that initializes the three data members. And employee class should
 * have a destructor which shows message when object of the class is destroyed from the memory.
 * Provide a “setData” and a “getData” function for each data member. If the monthly salary is
 * not positive, set it to -1. Write a test program that demonstrates class Employee’s 
 * functionalities. Create two Employee objects and display each object’s yearly salary after 
 * deducting 4% tax.
 * 
 */

using System;

namespace ConsoleTasks.Assignments.A1
{
    class Driver
    {
        public Driver()
        {
            Employee e = new Employee("Ali", 0, 4000),
                e2 = new Employee("Junaid", 1, 7500);

            e.setData();
            e.getData();

            e.getAnnualSalary();
            e2.getAnnualSalary();
            Console.ReadKey();
        }
    }
}
