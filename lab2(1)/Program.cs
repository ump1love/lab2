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
        Console.WriteLine();

        Console.WriteLine("CONVERTOR");
        Converter currencyConverter = new Converter(36.95, 39.64, 8.54);
        bool inputSuccess = false;
        while (!inputSuccess)
        {
            while (true)
            {
                char userChoice = currencyConverter.MyChoiceFirst();

                switch (userChoice)
                {
                    case 'A':
                    case 'a':
                    case 'B':
                    case 'b':
                        currencyConverter.MyChoiceSecond(userChoice);
                        break;
                        inputSuccess = true;

                    case 'E':
                    case 'e':
                        Console.WriteLine("Exiting...");
                        inputSuccess = true;
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

    }
}