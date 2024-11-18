using System.Text;

namespace Assignments_3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string evenNumbers = GetEvenNumbers();
            Console.WriteLine(evenNumbers);
        }

        static string GetEvenNumbers()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 2; i < 100; i += 2) 
            {
                sb.Append(i);
                if (i < 98) 
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString(); 
        }
    }
}
