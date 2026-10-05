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
bool ProgramOn = true;
string answer;
string name;
float salary;
var StaffRegister = new List<Staff>();

PrintConsoleInstructions();

while (ProgramOn){

    answer = Console.ReadLine();
    if (answer == "1")
    {
        // Enter name and salary
        Console.WriteLine("Skriv in den anställdes fullständiga namn:");
        name = Console.ReadLine();
        Console.WriteLine($"Ange {name}s lön i kronor utan mellanslag:");
        salary = float.Parse(Console.ReadLine());
        var StaffAdded = new Staff { Name = name, Salary = salary };
        StaffRegister.Add(StaffAdded);

        Console.WriteLine("Personen har lagts till i registret.");
        PrintConsoleInstructions();
    }
    else if (answer == "2")
    {
        if (StaffRegister.Count == 0) 
        {
            Console.WriteLine("Personalregistret är tomt.");
            PrintConsoleInstructions();
        }
        //print list
        else {
            Console.WriteLine("Ditt personalregister: ");
            foreach (Staff person in StaffRegister)
            {
                Console.WriteLine($"Namn: {person.Name}, lön: {person.Salary}");
            }
            Console.WriteLine();
            PrintConsoleInstructions();
        }
    }
    else if (answer == "9")
    {
        ProgramOn = false;
        //break;
    }
    else 
    {
        PrintConsoleInstructions();
    }
}

void PrintConsoleInstructions()
{
    Console.WriteLine("Tryck 1+enter för att lägga till personal till registret.");
    Console.WriteLine("Tryck 2+enter för att se all personal i registret.");
    Console.WriteLine("Tryck 9+enter för att stänga programmet.");
}
class Staff
{
    public string Name { get; set; }
    public float Salary { get; set; }

}