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
                        GetAge(true); // true = skriv ut priser i consol
                        break;
                    case "2":
                        bool amountEnterSuccess = false;
                        int amount = 0;
                        while (!amountEnterSuccess)
                        {
                            Console.WriteLine("Hur många är ni i sällskapet?");
                            try {
                                amount = int.Parse(Console.ReadLine());
                                if (amount == 0) { break; }
                                if (amount < 0) { Console.WriteLine("Ogiltigt antal. Ange sällskapets antal i nummer. Tryck 0 för att återgå till menyn."); }
                                else if (amount > 250) { Console.WriteLine("Det finns bara 250 platser i biosalongen. Ange ett antal mellan 2 - 250. Tryck 0 för att återgå till menyn."); }
                                else
                                {
                                    Console.WriteLine($"Ni är {amount} i sällskapet.");
                                    amountEnterSuccess = true; }
                                //Skapa lista över grupp för att samla in var och ens ålder.
                                var group = new List<int>();
                             /*   for (int i = 0; i < amount; i++)
                                {

                                }*/
                               // ageEnterSuccess = CheckAge(age);

                            }
                            catch (FormatException) { Console.WriteLine("Ogiltigt antal! Ange antal i siffror. Tryck 0 för att återgå till menyn.\n");}
                            catch (OverflowException) { Console.WriteLine("Ogiltigt antal! Ange antal i siffror. Tryck 0 för att återgå till menyn.\n");}
                        }
                        break;

                    default:
                        Console.WriteLine("Du har angivit en felaktig input.");
                        break;
                }
            }
        }

        static void GetAge(bool writeToConsol = false)
        {
            bool ageEnterSuccess = false;
            int age = 0;
            while (!ageEnterSuccess)
            {
                Console.Write("Ange ålder för den som ska ha biljetten:");
                try
                {
                    age = int.Parse(Console.ReadLine());
                    if (age == 0) { break; }
                    ageEnterSuccess = CheckAge(age, writeToConsol);
                }
                catch (FormatException) { Console.WriteLine("Ogiltigt nummer! Ange åldern i siffror. Tryck 0 för att återgå till menyn.\n"); }
                catch (OverflowException) { Console.WriteLine("Ogiltigt nummer! Ange åldern i siffror. Tryck 0 för att återgå till menyn.\n"); }
            }
           // return age;
        }

        static bool CheckAge(int age, bool writeToConsol)
        {
            //Kolla otillåtna värden
            if (age < 0) { Console.WriteLine($"Fel: åldern måste vara > 0. Tryck 0 för att återgå till menyn."); return false; }
            else if (age > 120) { Console.WriteLine($"Du är väldigt gammal! Säker på att du angav rätt ålder? Tryck 0 för att återgå till menyn."); return false; }
            //Tillåtna värden
            if (writeToConsol) {
                if (age < 20) { Console.WriteLine($"Ungdomspriset är 80 kr."); return true; }
                else if (age > 64) { Console.WriteLine($"Pensionärspriset är 90 kr."); return true; }
                else { Console.WriteLine($"Standardpriset är 120 kr."); return true; }
            } 
            else { return true; }
        }
        static void PrintMenueChoices()
        {
            Console.WriteLine("\n******** MENY ********\nGör ett val och tryck enter:");
            Console.WriteLine("0: Stäng av programmet. 1: Se priser. 2: Beräkna priset för grupp.");

        }
    }
}
