﻿using VehEvalu8.Models.Interfaces;

namespace VehEvalu8.Models.Motocross
{
    public class KTM : IMotocross
    {
        public KTM(int cc, int year, double priceForeign, string link, int distance)
        {
            Make = "KTM";
            Model = "SX-F";
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
                    MarketPrice = 4800; break;
                case 2008:
                    MarketPrice = 5300; break;
                case 2009:
                    MarketPrice = 5400; break;
                case 2010:
                    MarketPrice = 5700; break;
                case 2011:
                    MarketPrice = 6100; break;
                case 2012:
                    MarketPrice = 6400; break;
                case 2013:
                    MarketPrice = 6700; break;
                case 2014:
                    MarketPrice = 7200; break;
                case 2015:
                    MarketPrice = 7500; break;
                case 2016:
                    MarketPrice = 8000; break;
                case 2017:
                    MarketPrice = 8300; break;
                case 2018:
                    MarketPrice = 9200; break;
                case 2019:
                    MarketPrice = 9700; break;
                case 2020:
                    MarketPrice = 10300; break;
                case 2021:
                    MarketPrice = 11000; break;
                case 2022:
                    MarketPrice = 11500; break;
                case 2023:
                    MarketPrice = 12500; break;
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

