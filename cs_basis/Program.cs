 using System.Text;
 using System.Threading.Tasks;
 
 namespace Problem
 {
     class Program
     {
         static void Main(string[] args)
         {
            Console.Write("数字を入力：");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
                return;
            int input = int.Parse(inputString);
            if (!int.TryParse(inputString, out int number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (input < 50)
                Console.Write("Number is less than 50");
         }
     }
 }