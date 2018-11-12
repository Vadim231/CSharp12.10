using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[numberOfEmployees];
            for (int i=0;i< numberOfEmployees; i++)
            {
                Console.WriteLine("Введите Имя, Возраст, Вакансию, Зарплату и Дату приема на работу: ");
                employees[i].name = Console.ReadLine();
                employees[i].age = int.Parse(Console.ReadLine());
                employees[i].Vacancy = int.Parse(Console.ReadLine());
                employees[i].salary = int.Parse(Console.ReadLine());
                employees[i].employmentDate = int.Parse(Console.ReadLine());
            }

            SortByFirstName(employees);//сортировка

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("Сотрудник номер: " + i);
                Console.WriteLine(employees[i].name);
                Console.WriteLine(employees[i].age);
                Console.WriteLine(employees[i].Vacancy);
                Console.WriteLine(employees[i].salary);
                Console.WriteLine(employees[i].employmentDate);
            }
            

            for (int i = 0; i < numberOfEmployees; i++)
            {
                if (employees[i].Vacancy == 1)
                {
                    Console.WriteLine("Сотрудник номер: " + i);
                    Console.WriteLine(employees[i].name);
                    Console.WriteLine(employees[i].age);
                    Console.WriteLine(employees[i].Vacancy);
                    Console.WriteLine(employees[i].salary);
                    Console.WriteLine(employees[i].employmentDate);
                }
            }
            
            for (int i = 0; i < numberOfEmployees; i++)
            {
                if (employees[i].Vacancy == 2)
                {
                    int BossEmp = employees[i].employmentDate;
                    for (int j = 0; j < numberOfEmployees; j++)
                    {
                        if (employees[i].employmentDate > BossEmp)
                        {
                            Console.WriteLine("Сотрудник номер: " + i);
                            Console.WriteLine(employees[i].name);
                            Console.WriteLine(employees[i].age);
                            Console.WriteLine(employees[i].Vacancy);
                            Console.WriteLine(employees[i].salary);
                            Console.WriteLine(employees[i].employmentDate);
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        static public Employee[] SortByFirstName(Employee[] empdata)
        {
            int min = 0;
            Employee temp;
            for (int i = 0; i < empdata.Length; i++)
            {
                for (int j = i + 1; j < empdata.Length; j++)
                {
                    if (empdata[i].name.Length < empdata[j].name.Length)
                    {
                        min = empdata[i].name.Length;
                    }
                    else
                    {
                        min = empdata[j].name.Length;
                    }

                    for (int k = 0; k < min; k++)
                    {
                        if (empdata[i].name[k] > empdata[j].name[k])
                        {
                            temp = empdata[i];
                            empdata[i] = empdata[j];
                            empdata[j] = temp;
                            break;
                        }
                        else if (empdata[i].name[k] == empdata[j].name[k])
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return empdata;

        }
    }
}
