using System;
using System.Collections.Generic;
using System.Globalization;

class CurrencyConverter
{
    static void Main()
    {
        // Exchange rates to USD
        Dictionary<string, double> exchangeRates = new Dictionary<string, double>()
        {
            { "USD", 1.0 },
            { "EUR", 0.92 },
            { "GBP", 0.79 },
            { "JPY", 150.25 },
            { "CAD", 1.35 },
            { "AUD", 1.52 }
        };

        Console.WriteLine("Currency Converter");
        Console.WriteLine("Available currencies: USD, EUR, GBP, JPY, CAD, AUD");

         while (true)
        {
            // Connect real API later on here
            Console.Write("\nConvert FROM (or type EXIT to quit): ");
            string fromCurrency = Console.ReadLine().ToUpper();

            if (fromCurrency == "EXIT")
                break;

            Console.Write("Convert TO: ");
            string toCurrency = Console.ReadLine().ToUpper();

            if (!exchangeRates.ContainsKey(fromCurrency) || 
                !exchangeRates.ContainsKey(toCurrency))
            {
                Console.WriteLine("Invalid currency code!");
                continue;
            }

            Console.Write("Enter amount: ");
            if (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double amount))
            {
                Console.WriteLine("Invalid amount!");
                continue;
            }

            // Convert to USD first
            double amountInUSD = amount / exchangeRates[fromCurrency];

            // Convert to target currency
            double convertedAmount = amountInUSD * exchangeRates[toCurrency];

            Console.WriteLine($"{amount:F2} {fromCurrency} = {convertedAmount:F2} {toCurrency}");
        }

