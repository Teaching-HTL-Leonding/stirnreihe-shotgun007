using Stirnreihe.Logic;
string selection;
LineOfPeople l = new();
string lastName = "";
string firstName = "";
int height = 0;

Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?");
Console.WriteLine("1) Add a person to the line");
Console.WriteLine("1b) Add a person to the line (sorted)");
Console.WriteLine("2) Print the line");
Console.WriteLine("3) Clear the line");
Console.WriteLine("4) Exit");
do
{
    selection = Console.ReadLine()!;
    Console.WriteLine($"Your choice {selection}");

    switch (selection)
    {
        case "1":
            // Daten für eine neue Person werden abgefragt
            Console.Write("Last Name: ");
            lastName = Console.ReadLine()!;
            Console.Write("First Name: ");
            firstName = Console.ReadLine()!;
            Console.Write("Height (cm): ");
            height = int.Parse(Console.ReadLine()!);
            // Person wird erstellt
            var newPerson = new Person(lastName, firstName, height);
            // Person wird vorne hinzugefügt
            l.AddToFront(newPerson);
            break;
        case "1b":
             // Daten für eine neue Person werden abgefragt
            Console.Write("Last Name: ");
            lastName = Console.ReadLine()!;
            Console.Write("First Name: ");
            firstName = Console.ReadLine()!;
            Console.Write("Height (cm): ");
            height = int.Parse(Console.ReadLine()!);
            // Person wird erstellt
            var newPerson2 = new Person(lastName, firstName, height);
            // Person wird sortiert nach Größe hinzugefügt
            l.AddSorted(newPerson2);
            break;
        case "2":
            // wird ausgegeben wenn keine Personen vorhanden sind
            if (l.First is null)
            {
                Console.WriteLine("Empty line");
            }
            // Alle vorhandenen Personen werden ausgegeben
            else
            {
                var ElementToDisplay = l.First;
                Console.WriteLine(ElementToDisplay.Person.ToString());
                while (ElementToDisplay?.Next is not null)
                {
                    ElementToDisplay = ElementToDisplay.Next;
                    Console.WriteLine(ElementToDisplay.Person.ToString());
                }
            }
            break;
        case "3":
            // Alle Personen werden gelöscht
            l.Clear();
            Console.WriteLine("Cleared");
            break;
        case "4":
            // Programm wird beendet
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
}
while (selection != "4");




















