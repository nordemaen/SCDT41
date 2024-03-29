﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    /* Used for the type of property that the service offers cleaning for */

    public class EnumProperties
    {
        public enum DomesticType
        {
            DEATCHED,
            SEMIDEATCHED,
            TERRACED,
            BUNGALOW,
            FLAT,
            APARTMENT
        }

        public enum CommercialType
        {
            OFFICE,
            WAREHOUSE,
            FACTORY,
            INDUSTRIAL_UNIT,
            RETAIL
        }

        // Loop Through Types
        public static void DomesticTypes()
        {
            Console.WriteLine("Domestic Properties");

            foreach(var type in Enum.GetValues(typeof(DomesticType)))
            {
                Console.WriteLine(type);
            }
        }

        public static void CommericalTypes()
        {
            Console.WriteLine("Commercial Properties");

            foreach (var type in Enum.GetValues(typeof(CommercialType)))
            {
                Console.WriteLine(type);
            }
        }
    }
}
