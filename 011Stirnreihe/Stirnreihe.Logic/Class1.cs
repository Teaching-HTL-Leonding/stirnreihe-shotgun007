namespace Stirnreihe.Logic;

public class Person (string lastName, string firstName, int height)
{
    public string LastName { get; set; } = lastName;
    public string FirstName { get; set; } = firstName;
    public int Height { get; set; } = height;
    // Die Methode ToString() gibt Nachname, Vorname und Größe einer Person aus
    public override string ToString()
    {
        return $"{LastName}, {FirstName} ({Height} cm)";
    }
}

// Mit dieser Klasse werden verknüpfungen erstellt
public class Node(Person person, Node? next)
{
    public Person Person { get; } = person;
    public Node? Next { get; set; } = next;
}

public class LineOfPeople
{
    public Node? First { get; set; } = null;
    // Die neue Person wird vorne hinzugefügt
    public void AddToFront(Person person)
    {
        // neue Person wird erstellt und First wird newPerson.Next
        var newPerson = new Node(person, First);
        First = newPerson;
    }
    public int AddSorted(Person person)
    {
        var newPerson = new Node(person, null);
        if (First is null || newPerson.Person.Height < First.Person.Height)
        {
            AddToFront(person);
            return 0;
        }
        else
        {
            int index;
            var help = First;
            // Der richtige Platz für die Person wird gesucht
            for (index = 1; help.Next != null && help.Next.Person.Height <=  newPerson.Person.Height; index++)
            {
                help = help.Next;
            }
            // die neue Person wird eingefügt
            newPerson.Next = help.Next;
            help.Next = newPerson;
            return index;
        }
    }
    public void Clear()
    {
        // First wird gelöscht, der Rest wird vom Garbage collector bereinigt
        First = null;
    }
}


































