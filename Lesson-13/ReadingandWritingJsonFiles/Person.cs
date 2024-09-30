namespace ReadingandWritingJsonFiles;

public class Person
{
    public DateTime CreatedAt { get; set; }
    
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";

    public int Age { get; set; }

    public Address Address { get; set; } = new Address();

    public override string ToString()
    {
        return $"Created at: {CreatedAt}, Name: {FirstName}, {LastName}, Email: {Email}, Phone Number: {PhoneNumber}, Age: {Age}";
    }
}