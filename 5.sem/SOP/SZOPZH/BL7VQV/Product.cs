using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Product
    {
        static uint ID;
        uint id;
        WineType wineType;

        public Product (WineType wineType)
        {
            id = ID++;
            this.wineType = wineType;
        }

        internal WineType WineType { get => wineType; set => wineType = value; }


        public override string ToString()
        {
            return $"Product_ID: {id}, WineType: {wineType}";
        }
            

    }
}
