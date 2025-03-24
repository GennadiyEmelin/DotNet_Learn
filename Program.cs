using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DotNet
{
    class Program
    {
        /// <summary>
        /// Вход в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Workers> workers = new List<Workers>();
            MSSQL _MSSQL = new MSSQL();

            Console.WriteLine("Введите имя сотрудника: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию сотрудника: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите возраст сотрудника: ");
            string age = Console.ReadLine();
            Console.WriteLine("Введите данные паспорта сотрудника: ");
            string passport = Console.ReadLine();

            workers.Add(new Workers(name, surname, age, passport));
            _MSSQL.ConnectionSQL("1", name,surname, age, passport, "1", "1");
        }
    }
}
