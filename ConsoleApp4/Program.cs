using System.Net.NetworkInformation;

Adress adress = new Adress();
adress.Index = "01001";
adress.Country = "Ukraine";
adress.City = "Kiev";
adress.Street = "Lobachevskogo";
adress.House = "23A";
adress.Apartment = "517";

string adressIndex = adress.Index;
string adressCountry = adress.Country;
string adressCity = adress.City;
string adressStreet = adress.Street;
string adressHouse = adress.House;
string adressApartment = adress.Apartment;

Console.WriteLine(adressIndex);
Console.WriteLine(adressCountry);
Console.WriteLine(adressCity);
Console.WriteLine(adressStreet);
Console.WriteLine(adressHouse);
Console.WriteLine(adressApartment);

class Adress
{
    private string index = "Undifined";
    private string country = "Undifined";
    private string city = "Undifined";
    private string street = "Undifined";
    private string house = "Undifined";
    private string apartment = "Undifined";

    public string Index;
    public string Country;
    public string City;
    public string Street;
    public string House;
    public string Apartment
    {
        get
        {
            return index;
            return country;
            return city;
            return street;
            return house;
            return apartment;
        }
        set
        {
            index = value;
            country = value;
            city = value;
            street = value;
            house = value;
            apartment = value;
        }
    }
}



