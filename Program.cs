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
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MAAQLlocalDB",
                InitialCatalog = "MSSQLTestDemo",
                IntegratedSecurity = true
            };

            Console.WriteLine(strCon.ConnectionString);

            SqlConnection sqlConnection = new SqlConnection()
            {
                ConnectionString = strCon.ConnectionString,
            };

            sqlConnection.StateChange += (s, e) => 
            { Console.WriteLine($"{nameof(sqlConnection)} " +
                $"в состоянии: {(s as SqlConnection).State}"); 
            };

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
