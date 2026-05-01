using System;
using System.Data;

namespace Pract8_Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();
            expr = expr.Replace(" ", "");
            try
            {
                DataTable dt = new DataTable();
                object result = dt.Compute(expr, "");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}