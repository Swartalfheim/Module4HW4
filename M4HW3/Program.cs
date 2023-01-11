using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace M4HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Employees.ToList();
            }
            Console.Read();
        }
    }
}