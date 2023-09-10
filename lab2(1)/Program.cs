using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        Address address = new Address();
        address.Index = 123;
        address.Country = "Ukraine";
        address.City = "Kyiv";
        address.House = 123;
        address.Apartment = 123;
        Console.WriteLine(address);
        for (int temp = 0; temp < 45; ++temp) { Console.Write('-'); }


    }
}