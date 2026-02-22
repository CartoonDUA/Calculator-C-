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
