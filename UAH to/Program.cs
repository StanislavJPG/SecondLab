class Converter
{
    static void Main(string[] args)
    {
        double UsdToUah = 37.17;
        double EurToUah = 36.01;
        double RubToUah = 0.64;
        double UAH;


        Console.WriteLine("Write in USD, EUR, RUB:");


        UAH = double.Parse(Console.ReadLine());

        Console.WriteLine(UAH + " USD в UAH = " + UAH * UsdToUah);
        Console.WriteLine(UAH + " EUR в UAH = " + UAH * EurToUah);
        Console.WriteLine(UAH + " RUB в UAH = " + UAH * RubToUah);

    }
}