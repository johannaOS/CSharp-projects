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
                        int amount = 0;
                        GetAmount(ref amount);

                        //Skapa array av grupp och samla in var och ens ålder.
                        int[] groupAge = new int[amount];
                        for (int i = 0; i < amount; i++)
                        {
                            groupAge[i] = GetAge();
                            if (groupAge[i] == 0) { break; } //Användaren avbröt.
                        }
                        //beräkna gruppriset
                        int sum = 0;
                        foreach (int age in groupAge)
                        {
                            if (age<20) { sum += 80; }
                            else if (age > 64) { sum += 90; }
                            else { sum += 120; }
                        }
                        Console.WriteLine($"Priset för ditt sällskap är: {sum} kr.");
                        break;
                    case "3":
                        Console.WriteLine("Skriv in en text här:");
                        string userInput = Console.ReadLine();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(userInput);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Skriv in en text här på minst 3 ord:"); 
                        bool userLongInputSuccess = false;
                        while (!userLongInputSuccess) {
                            string userLongInput = Console.ReadLine();
                            var userInputSplit = userLongInput.Split(" ");
                            try { 
                                Console.WriteLine(userInputSplit[2]); 
                                userLongInputSuccess = true; 
                            }
                            catch (IndexOutOfRangeException) { Console.WriteLine("Fel! Skriv in en text med minst 3 ord!"); }
                        }
                        break;
                    default:
                        Console.WriteLine("Du har angivit en felaktig input.");
                        break;
                }
            }
        }
        static void GetAmount(ref int amount)
        {
            bool amountEnterSuccess = false;
            while (!amountEnterSuccess)
            {
                Console.WriteLine("Hur många är ni i sällskapet?");
                try
                {
                    amount = int.Parse(Console.ReadLine());
                    if (amount == 0) { break; }
                    if (amount < 0) { Console.WriteLine("Ogiltigt antal. Ange sällskapets antal i nummer. Tryck 0 för att återgå till menyn."); }
                    else if (amount > 250) { Console.WriteLine("Det finns bara 250 platser i biosalongen. Ange ett antal mellan 2 - 250. Tryck 0 för att återgå till menyn."); }
                    else { amountEnterSuccess = true;}
                }
                catch (FormatException) { Console.WriteLine("Ogiltigt antal! Ange antal i siffror. Tryck 0 för att återgå till menyn.\n"); }
                catch (OverflowException) { Console.WriteLine("Ogiltigt antal! Ange antal i siffror. Tryck 0 för att återgå till menyn.\n"); }
            }
        }
        static int GetAge(bool writeToConsol = false)
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
           return age;
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
            Console.WriteLine("0: Stäng av programmet. 1: Se priser. 2: Beräkna priset för grupp. 3: Monkey see, monkey do. 4. Monkey does selectively.");

        }
    }
}
