namespace Day1;

public class Program
{
    public static void Main(string[] args)
    {
        Sonar sonar = new();

        StreamReader inputs = new(File.Open("input.txt", FileMode.Open, FileAccess.Read));

        string? input = inputs.ReadLine();
        while (input != null)
        {
            sonar.NextInput(int.Parse(input));
            input = inputs.ReadLine();
        }

        Console.WriteLine($"Total depth increases: {sonar.DMI}");
        Console.WriteLine($"Total window depth increases: {sonar.WDMI}");
    }
}