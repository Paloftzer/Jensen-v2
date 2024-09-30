namespace ReadWriteFiles;

class Program
{
    static void Main()
    {
        var path = Environment.CurrentDirectory + "/data/log.txt";
        Console.WriteLine(path);

        var message = $"info added - {DateTime.Now.ToShortDateString()}";

        File.WriteAllText(path, message);

        Console.WriteLine(File.ReadAllText(path));
    }
}
