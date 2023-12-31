﻿using VehEvalu8.Models.Interfaces;

namespace VehEvalu8.Models.Motocross
{
    public class Yamaha : IMotocross
    {
        public Yamaha(int cc, int year, double priceForeign, string link, int distance)
        {
            Make = "Yamaha";
            Model = "YZ-F";
            CC = cc;
            Year = year;
            PriceForeign = priceForeign;
            Link = link;
            DistanceToPickUp = distance;
            FuelCost = (double)(DistanceToPickUp * 2 / 100.0) * (IMotorcycle.dieselPriceBGN * 11);
            PriceBGN = PriceForeign * IMotorcycle.exchangeRateSEK;
            TotalCost = FuelCost + PriceBGN + IMotorcycle.commission;

            switch (Year)
            {
                case 2007:
                    MarketPrice = 5000; break;
                case 2008:
                    MarketPrice = 5100; break;
                case 2009:
                    MarketPrice = 5200; break;
                case 2010:
                    MarketPrice = 5300; break;
                case 2011:
                    MarketPrice = 5600; break;
                case 2012:
                    MarketPrice = 5900; break;
                case 2013:
                    MarketPrice = 6200; break;
                case 2014:
                    MarketPrice = 6600; break;
                case 2015:
                    MarketPrice = 6800; break;
                case 2016:
                    MarketPrice = 7300; break;
                case 2017:
                    MarketPrice = 7800; break;
                case 2018:
                    MarketPrice = 8400; break;
                case 2019:
                    MarketPrice = 9100; break;
                case 2020:
                    MarketPrice = 9800; break;
                case 2021:
                    MarketPrice = 10300; break;
                case 2022:
                    MarketPrice = 10800; break;
                case 2023:
                    MarketPrice = 11500; break;
            }

            Profit = MarketPrice - TotalCost;
            ROI = (this.Profit / this.TotalCost) * 100.0;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int CC { get; set; }

        public int Year { get; set; }

        public double PriceForeign { get; set; }

        public double PriceBGN { get; set; }

        public double MarketPrice { get; set; }

        public int DistanceToPickUp { get; set; }

        public double FuelCost { get; set; }

        public double TotalCost { get; set; }

        public double Profit { get; set; }

        public double ROI { get; set; }

        public string Link { get; set; }
    }
}
