using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    internal class MSSQL
    {
        /// <summary>
        /// Подключение к базе данных
        /// Еще доработаю и разобью на несколько методов, пока что все в одном.
        /// </summary>
        public void ConnectionSQL(string id, string name, string workerSurname, 
            string age, string passport, string idDepartment, string idDirector)
        {
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
                string sql = $@"INSERT INTO Workers([id],[workerName],[workerSurname],[age],[passport],[idDepartment],[idDirector]) 
                     values ({id},'{name}','{workerSurname}','{age}','{passport}',{idDepartment},{idDirector})";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
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
