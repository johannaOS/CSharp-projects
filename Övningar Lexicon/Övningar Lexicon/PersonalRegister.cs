/*
Bakgrund
Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet personalregister.
De har endast två krav:
1. Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning
i konsolen, inget krav på persistent lagring)
1. Programmet skall kunna skriva ut registret i en konsol.
Uppgift 1
Vilka klasser bör ingå i programmet?
Svar:
1. En klass: Personal
Uppgift 2
Vilka attribut och metoder bör ingå i dessa klasser?
Svar:
Attribut:
Namn
Lön
Metoder:
Uppgift 3
Skriv programmet
 */
using Övningar_Lexicon;

bool ProgramOn = true;
string answer;
string name;
float salary;
var StaffRegister = new List<Staff>();

Utilities.PrintConsoleInstructions();

while (ProgramOn){

    answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
            // Enter name and salary
            Console.WriteLine("Skriv in den anställdes fullständiga namn:");
            name = Console.ReadLine();
            Console.WriteLine($"Ange {name}s lön i kronor utan mellanslag:");
            salary = float.Parse(Console.ReadLine());
            var StaffAdded = new Staff { Name = name, Salary = salary };
            StaffRegister.Add(StaffAdded);

            Console.WriteLine("Personen har lagts till i registret.");
            Utilities.PrintConsoleInstructions();
            break;
        case "2":
            if (StaffRegister.Count == 0)
            {
                Console.WriteLine("Personalregistret är tomt.");
                Utilities.PrintConsoleInstructions();
            }
            //print list
            else
            {
                Console.WriteLine("Ditt personalregister: ");
                foreach (Staff person in StaffRegister)
                {
                    Console.WriteLine($"Namn: {person.Name}, lön: {person.Salary}");
                }
                Console.WriteLine();
                Utilities.PrintConsoleInstructions();
            }
            break;
        case "9":
            ProgramOn = false;
            break;
        default:
            Utilities.PrintConsoleInstructions();
            break;

    }
}

class Staff
{
    public string Name { get; set; }
    public float Salary { get; set; }

}