﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class RealEstate
    {
        public int Area { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }
        public string PropertyType { get; set; }
        public string Condition { get; set; }
        public string Location { get; set; }

        public RealEstate(int area, int rooms, int floor, string propertyType, string condition, string location)
        {
            if (area <= 0)
            {
                throw new ArgumentException("Incorrect area");
            }
            Area = area;

            if (rooms <= 0)
            {
                throw new ArgumentException("Incorrect rooms count");
            }
            Rooms = rooms;

            if (floor <= 0)
            {
                throw new ArgumentException("Incorrect floor");
            }
            Floor = floor;

            if (propertyType != "квартира" && propertyType != "дом" && propertyType != "студия")
            {
                throw new ArgumentException("Incorrect appartment type");
            }
            PropertyType = propertyType;

            if (condition != "новое" && condition != "хорошее" && condition != "требует ремонта")
            {
                throw new ArgumentException("Incorrect object state");
            }
            Condition = condition;

            if (location != "центр" && location != "пригород" && location != "отдаленный район")
            {
                throw new ArgumentException("Incorrect location");
            }
            Location = location;
        }

        public decimal CalculatePrice()
        {
            decimal basePrice = PropertyType switch
            {
                "квартира" => Area * 30000,
                "дом" => Area * 40000,
                "студия" => Area * 25000,
                _ => throw new ArgumentException("Incorrect apartment type")
            };

            if (Rooms > 3)
                basePrice *= 1.10m;
            else if (Rooms == 1)
                basePrice *= 0.95m;

            if (Floor > 5)
                basePrice *= 1.15m;
            else if (Floor == 1)
                basePrice *= 0.90m;

            if (Condition == "требует ремонта")
                basePrice *= 0.80m;
            else if (Condition == "новое")
                basePrice *= 1.10m;

            if (Location == "центр")
                basePrice *= 1.25m;

            return basePrice;
        }
    }
}
