class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new("Jonathan", "Davis"); 

        emp1.Print(); 
        emp1.Oklad(args); 
    }
}
class Employee
{
    public string name;
    public string lastname;
    public Employee(string name = "Unk", string lastname = "Unk") 
    {
        this.name = name;
        this.lastname = lastname;
    }
    public void Print() => Console.WriteLine($"Name: {name}  Lastname: {lastname}");
    public void Oklad(string[] args) 
    {
        int min = 13000, posada, exp; 

        double oklad = 0, coef_posada = 0, coef_exp = 0, podatok = 0; 

        Console.WriteLine("Вкажiть посаду вашого працiвника цифрою вiд 1 до 3"); 
        Console.WriteLine("1 - junior");
        Console.WriteLine("2 - middle");
        Console.WriteLine("3 - senior");
        posada = int.Parse(Console.ReadLine());

        switch (posada) 
        {
            case 1: 
                coef_posada = 1.08;
                break;

            case 2: 
                coef_posada = 2;
                break;

            case 3: 
                coef_posada = 2.5;
                break;

            default:
                Console.WriteLine("You are banned from this server :3 Try again"); 
                break;

        }
        Console.WriteLine($"Вкажiть стаж вашого працiвника в роках: "); 
        exp = int.Parse(Console.ReadLine());
        if (exp <= 5)         
        {
            coef_exp = 1.15;
        }
        if (exp > 5 && exp <= 10)
        {
            coef_exp = 1.30;
        }
        if (exp > 10)
        {
            coef_exp = 1.50;
        }

        Console.WriteLine($"Оклад Вашого працiвника: {oklad = min * coef_posada * coef_exp}"); 


        Console.WriteLine($"Податок на зарплатню працiвника: {podatok = oklad * 0.18}"); 
    }
}

