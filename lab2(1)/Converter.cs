using System;

class Converter
{
    private double m_usd;
    private double m_eur;
    private double m_pln;

    public Converter(double usd, double eur, double pln)
    {
        m_usd = usd;
        m_eur = eur;
        m_pln = pln;
    }

   public char MyChoiceFirst()
    {
        char input;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Enter your choice");
            Console.WriteLine("A - From UAH to USD, EUR, PLN");
            Console.WriteLine("B - From USD, EUR, PLN to UAH");
            Console.WriteLine("E - Exit");
            Console.Write("A, B, E: ");
            input = char.Parse(Console.ReadLine());
        } while (input != 'A' && input != 'a' && input != 'B' && input != 'b' && input != 'E' && input != 'e');

        return input;
    }

    public void MyChoiceSecond(char input)
    {
        switch (input)
        {
            case 'A':
            case 'a':
                Console.WriteLine("Choose currency");
                Console.WriteLine("1 - UAH > USD");
                Console.WriteLine("2 - UAH > EUR");
                Console.WriteLine("3 - UAH > PLN");
                Console.WriteLine("4 - Back");
                int currencyChoice = int.Parse(Console.ReadLine());
                if(currencyChoice == 4)
                {
                    break;
                }
                double convertedAmount = 0.0;
                Console.WriteLine($"Enter how much do you want to convert: ");
                double uahAmount = double.Parse(Console.ReadLine());
                switch (currencyChoice)
                {
                    case 1:
                        convertedAmount = uahAmount / m_usd;
                        Console.WriteLine($"Converted amount: {convertedAmount} USD. With the dollar exchange rate of {m_usd}");
                        break;
                    case 2:
                        convertedAmount = uahAmount / m_eur;
                        Console.WriteLine($"Converted amount: {convertedAmount} EUR. With the euro exchange rate of {m_eur}");
                        break;
                    case 3:
                        convertedAmount = uahAmount / m_pln;
                        Console.WriteLine($"Converted amount: {convertedAmount} PLN. With the zloty exchange rate of {m_pln}");
                        break;
                    default:
                        Console.WriteLine("Error in currency choice.");
                        break;
                }
                break;
            case 'B':
            case 'b':
                Console.WriteLine("Choose currency");
                Console.WriteLine("1 - USD > UAH");
                Console.WriteLine("2 - EUR > UAH");
                Console.WriteLine("3 - PLN > UAH");
                Console.WriteLine("4 - Back");
                int currencyChoiceSecond = int.Parse(Console.ReadLine());
                if (currencyChoiceSecond == 4)
                {
                    break;
                }
                double convertedAmountSecond = 0.0;
                Console.WriteLine($"Enter how much do you want to convert: ");
                double uahAmountSecond = double.Parse(Console.ReadLine());

                switch (currencyChoiceSecond)
                {
                    case 1:
                        convertedAmount = m_usd / uahAmountSecond;
                        Console.WriteLine($"Converted amount: {convertedAmount} USD. With the dollar exchange rate of {m_usd}");
                        break;
                    case 2:
                        convertedAmount = m_eur / uahAmountSecond;
                        Console.WriteLine($"Converted amount: {convertedAmount} EUR. With the euro exchange rate of {m_eur}");
                        break;
                    case 3:
                        convertedAmount = m_pln / uahAmountSecond;
                        Console.WriteLine($"Converted amount: {convertedAmount} PLN. With the zloty exchange rate of {m_pln}");
                        break;
                    default:
                        Console.WriteLine("Error in currency choice.");
                        break;
                }
                break;

        }
    }
}