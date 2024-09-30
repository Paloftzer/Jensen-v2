using System.Text.Json;

namespace ReadingandWritingJsonFiles;

class Program
{
    private static readonly JsonSerializerOptions s_writeOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };

    static void Main()
    {
        Person John = new()
        {
            CreatedAt = DateTime.Now,
            FirstName = "John",
            LastName = "Doe",
            Email = "doe@example.com",
            PhoneNumber = "555-555812",
            Age = 27
        };
    
    Console.WriteLine(John);

    var path = string.Concat(Environment.CurrentDirectory, "/data/person.json");
    var json = JsonSerializer.Serialize(John, s_writeOptions);
    // Console.WriteLine(json);

    File.WriteAllText(path, json);
    }
}