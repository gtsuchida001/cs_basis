 using System.Text;
 using System.Threading.Tasks;
 
 namespace Problem
 {
     class Program
     {
         static void Main(string[] args)
         {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                return;
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (number <= 20 || number >= 80)
                Console.Write("The number is under 20 or above 80");
         }
     }
 }