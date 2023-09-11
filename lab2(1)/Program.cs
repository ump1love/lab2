using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        int temp;
        do
        {
            Console.WriteLine("Choose what task do you want to check, from 1 to 4 or 5 for exit: ");
            temp = int.Parse(Console.ReadLine());

            switch (temp)
            {

                case 1:
                    Address address = new Address();
                    address.Index = 123;
                    address.Country = "Ukraine";
                    address.City = "Kyiv";
                    address.House = 123;
                    address.Apartment = 123;
                    Console.WriteLine(address);

                    for (int line = 0; line < 45; ++line) { Console.Write('-'); }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.Write("CONVERTOR");
                    Converter currencyConverter = new Converter(36.95, 39.64, 8.54);

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

                            case 'E':
                            case 'e':
                                Console.WriteLine("Exiting...");
                                return;

                            default:
                                Console.WriteLine("Invalid choice. Please select a valid option.");
                                break;
                        }
                    }
                    for (int line = 0; line < 45; ++line) { Console.Write('-'); }
                    Console.WriteLine();
                    return;

                case 5:
                    break;
                default:
                    Console.WriteLine("Error in choosing task. ");
                    return;
            }
        } while (temp != 5);

    }
}