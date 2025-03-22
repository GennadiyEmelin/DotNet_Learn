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
            //Данные БД
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MSSQLlocalDB",
                InitialCatalog = "MSSQLTestDemo",
                IntegratedSecurity = true
            };

            Console.WriteLine(strCon.ConnectionString);

            SqlConnection sqlConnection = new SqlConnection()
            {
                ConnectionString = strCon.ConnectionString,
            };

            sqlConnection.StateChange += (s, e) => 
            { 
                Console.WriteLine($@"{nameof(sqlConnection)} " +
                $"в состоянии: {(s as SqlConnection).State}"); 
            };

            //Подключение к БД
            try
            {
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(sqlConnection.State);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
