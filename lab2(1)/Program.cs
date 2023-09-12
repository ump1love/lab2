using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        User user = new User("test_login", "test_username", 2);

        char task;
        do
        {
            start:
            Console.WriteLine("Choose what task do you want to check, from 1 to 4 or 5 for exit: ");
            task = Console.ReadKey().KeyChar;

            switch (task)
            {

                case '1':
                    Console.WriteLine();
                    for (int line = 0; line < 45; ++line) { Console.Write('-'); }
                    Console.WriteLine();
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
                case '2':
                    Console.WriteLine();
                    for (int line = 0; line < 45; ++line) { Console.Write('-'); }
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
                                for (int line = 0; line < 45; ++line) { Console.Write('-'); }
                                Console.WriteLine();
                                goto start;

                            default:
                                Console.WriteLine("Invalid choice. Please select a valid option.");
                                break;
                        }
                    }

                case '3':
                    Console.WriteLine();
                    for (int line = 0; line < 45; ++line) { Console.Write('-'); }
                    Console.WriteLine();
                    Employee employee = new Employee("Edward", "Steward");
                    employee.setPosition("Back end");
                    employee.setExperience(3);
                    employee.displayEmployee();
                    for (int line = 0; line < 45; ++line) { Console.Write('-'); }
                    Console.WriteLine();

                    break;

                case '4':
                    Console.WriteLine();
                    for (int line = 0; line < 45; ++line) { Console.Write('-'); }
                    Console.WriteLine();
                    user.displayUser();
                    for (int line = 0; line < 45; ++line) { Console.Write('-'); }
                    Console.WriteLine();


                    break;

                case '5':
                    Console.WriteLine();
                    Console.WriteLine("Exitig...");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Error in choosing task. ");
                    Console.WriteLine("Exiting...");
                    return;
            }
        } while (task != '5');

    }
}