namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string noise)
    {
        if (IsDriveable)
        {
            System.Console.WriteLine($"{Year} {Make} {Model} engine: {noise}");
        }
        else
        {
            System.Console.WriteLine($"{Year} {Make} {Model} engine won't start — not driveable.");
        }
    }

    public void MakeHonkNoise(string noise)
    {
        if (IsDriveable)
        {
            System.Console.WriteLine($"{Year} {Make} {Model} horn: {noise}");
        }
        else
        {
            System.Console.WriteLine($"{Year} {Make} {Model} horn doesn't work — not driveable.");
        }
    }
}