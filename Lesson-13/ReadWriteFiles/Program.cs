namespace ReadWriteFiles;

class Program
{
    static void Main()
    {
        var path = Environment.CurrentDirectory + "/data/log.txt";
        Console.WriteLine(path);

        /* var message = $"Info added - {DateTime.Now.ToShortDateString()}";

        File.WriteAllText(path, message);

        Console.WriteLine(File.ReadAllText(path)); */

        using StreamWriter sw = new(path);

        var message = $"Info added - {DateTime.Now}";

        sw.WriteLine(message);

        message = $"Info added again - {DateTime.Now}";

        sw.WriteLine(message);
        sw.Close();

        using StreamReader sr = new(path);

        Console.WriteLine(sr.ReadToEnd());
        sr.Close();
    }
}
