using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12._10
{
    enum Vacancies
    {
        Manager=1,
        Boss,
        Clerk,
        Salesman
    };
    struct Employee
    {
        public string name;

        public int age;

        public Vacancies vacancy;

        public int Vacancy
        {
            get { return (int)vacancy; }
            set { vacancy = (Vacancies)value; }
        }

        public int salary;

        public int employmentDate;

        public Employee(string name, int age, Vacancies vacancy, int salary,int employmentDate)
        {
            this.name = name;
            this.age = age;
            this.vacancy = vacancy;
            this.salary = salary;
            this.employmentDate = employmentDate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  " +
                $"Age: {age} " +
                $"vacancy: {vacancy} " +
                $"salary: {salary} " +
                $"EmploymentDate: {employmentDate}");
        }
        
    }
}
