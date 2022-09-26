class Program
{
    static void Main(string[] args)
    {
        User someUser = new User();
        someUser.Login = "Haisenberg";
        someUser.Name = "Travis";
        someUser.Lastname = "Maddyson";
        someUser.Age = 23;
        someUser.SetDate(DateTime.UtcNow);
        someUser.Print();
    }
}

class User
{
    private string login;
    private string name;
    private string lastname;
    private int age;
    private static DateTime date; 

    public string Login { get { return login; } set { login = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Lastname { get { return lastname; } set { lastname = value; } }
    public int Age { get { return age; } set { age = value; } }
    public void SetDate(DateTime date)
    {
        User.date = date;  
    }
    public void Print()
    {
        Console.WriteLine($"Login: {login}; Name: {name}; Lastname: {lastname}; Age: {age}; Date: {date} ");
    }
}