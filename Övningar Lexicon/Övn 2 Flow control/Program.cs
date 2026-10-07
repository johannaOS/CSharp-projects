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
//            PrintMenueChoices();

            while (ProgramOn)
            {
                PrintMenueChoices();
                userSelection = Console.ReadLine();
                switch (userSelection)
                {
                    case "0":
                        {
                            Console.WriteLine("Stänger av programmet...");
                            ProgramOn = false;
                            break;
                        }
                    case "1":
                        bool ageEnterSuccess = false;
                        while (!ageEnterSuccess)
                        {
                            Console.Write("Ange ålder för den som ska ha biljetten:");
                            try
                            {
                                int age = int.Parse(Console.ReadLine());
                                if (age == 0) { break; }
                                ageEnterSuccess = CheckAge(age);

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Ogiltigt nummer! Ange åldern i siffror. Tryck 0 för att gå tillbaka.\n"); //om ogiltig input
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("Ogiltigt nummer! Ange åldern i siffror. Tryck 0 för att gå tillbaka till menyn.\n"); //om ogiltig input
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Du har angivit en felaktig input.");
                        break;
                }
            }
        }

        static bool CheckAge(int age)
        {
            //Kolla otillåtna värden
            if (age < 0) { Console.WriteLine($"Fel: åldern måste vara > 0. Tryck 0 för att gå tillbaka till menyn."); return false; }
            else if (age > 120) { Console.WriteLine($"Du är väldigt gammal! Säker på att du angav rätt ålder? Tryck 0 för att gå tillbaka till menyn."); return false; }
            //Tillåtna värden
            else if (age < 20) { Console.WriteLine($"Ungdomspriset är 80 kr."); return true; }
            else if (age > 64) { Console.WriteLine($"Pensionärspriset är 90 kr."); return true; }
            else { Console.WriteLine($"Standardpriset är 120 kr."); return true; }
        }
        static void PrintMenueChoices()
        {
            Console.WriteLine("\n******** MENY ********\nGör ett val och tryck enter:");
            Console.WriteLine("0: Stäng av programmet. 1: Se priser.");

        }
    }
}
