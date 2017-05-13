using System;
using System.Data;
using System.Data.SqlClient;

namespace DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string conn = "Server=SY-BC\\SQL2014;Database=SampleDatabase;User ID=sa;Password=Password1;";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        Console.WriteLine("Conected");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
