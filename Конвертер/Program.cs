class Converter
{
    static void Main(string[] args)
    {
        double UahToUsd = 0.027;
        double UahToEur = 0.028;
        double UahToRub = 1.56;
        double UAH;


        Console.WriteLine("Write in UAH:");

        UAH = double.Parse(Console.ReadLine());

        Console.WriteLine(UAH + " UAH в USD = " + UAH * UahToUsd);
        Console.WriteLine(UAH + " UAH в EUR = " + UAH * UahToEur);
        Console.WriteLine(UAH + " UAH в RUB = " + UAH * UahToRub);

    }
}