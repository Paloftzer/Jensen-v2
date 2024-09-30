namespace ReadingandWritingJsonFiles;

class Program
{
    static void Main()
    {
        Person person = new();
        person.CreatedAt = DateTime.Now;
        person.FirstName = "John";
        person.LastName = "Doe";
        person.Email = "doe@example.com";
        person.PhoneNumber = "555-555812";
        person.Age = 27;
    }
}
