﻿using System.Runtime.CompilerServices;

namespace VehEvalu8.Models.Interfaces
{
    public interface IMotorcycle
    {
        //TODO - HOW CAN I HAVE A REAL-TIME CURRENCY CONVERSION AND DIESEL PRICE UPDATES? HTMLAGILITYPACK / SCRAPE-PARSE?

        const double exchangeRateSEK = 0.1688; // LAST UPDATE - 02.10.2023
        const double dieselPriceBGN = 4.32; // LAST UPDATE - 02.10.2023
        const int commission = 800;
        string Make { get; }
        string Model { get; }
        int CC { get; }
        int Year { get; }
        double PriceForeign { get; }
        double PriceBGN { get; }
        double MarketPrice { get; }
        int DistanceToPickUp { get; }
        double FuelCost { get; }
        double TotalCost { get; }
        double Profit { get; }
        double ROI { get; }
        string Link { get; }
    }
}
