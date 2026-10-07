namespace Övn_2_Flow_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler
            bool ProgramOn = true;
            string userSelection = "";

            // Visa menyn för användaren
            Console.WriteLine("Du har kommit till huvudmenyn!\nGör ett val och tryck enter:");
            Console.WriteLine("0: Stäng av programmet.");
            userSelection = Console.ReadLine();

            while (ProgramOn)
            {switch (userSelection)
                {
                    case "0":
                        {
                            Console.WriteLine("Stänger av programmet...");
                            ProgramOn = false;
                            break;
                        }

                    default:
                        Console.WriteLine("Du har angivit en felaktig input.");
                        break;
                }
            }
        }
    }
}
