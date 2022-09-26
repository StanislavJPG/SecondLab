class Converter
{
    static void Main(string[] args)
    {
        double UsdToUah = 37.17;
        double EurToUah = 36.01;
        double RubToUah = 0.64;
        double UAH;
        double EUR;
        double RUB;
        double USD;


        Console.WriteLine("Write in UAH:");

        USD = double.Parse(Console.ReadLine());
        EUR = double.Parse(Console.ReadLine());
        RUB = double.Parse(Console.ReadLine());

        Console.WriteLine(USD + " USD в UAH = " + USD * UsdToUah);
        Console.WriteLine(UAH + " EUR в UAH = " + UAH * EurToUah);
        Console.WriteLine(UAH + " RUB в UAH = " + UAH * RubToUah);

    }
}