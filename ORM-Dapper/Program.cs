using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperDepartmentRepository(conn);

            Console.WriteLine("Type a new department name:");

            var departmentName = Console.ReadLine();

            repo.InsertDepartment(departmentName);

            var departments = repo.GetAllDepartments();

            foreach (var department in departments)
            {
                Console.WriteLine(department.Name);
            }
        }
    }
}
