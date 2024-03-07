
using System.Threading.Tasks;
using Task1;
using Task2;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Select the task number(1 or 2): ");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
                Task1.Program.Main_Task1();
                break;

            case 2:
                Task2.Program.Main_Task2();
                break;

            default:
                Console.WriteLine("Error");
                break;
        }
    }
}