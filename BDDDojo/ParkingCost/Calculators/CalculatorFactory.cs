﻿using System.ComponentModel;

namespace Rain.BDDDojo.ParkingCost.Calculators
{
    public class CalculatorFactory
    {
        public static IParkingCostCalculator CreateCalculator(ParkingType type)
        {
            switch (type)
            {
                case ParkingType.ValetParking:
                    return new ValetParkingCalculator();
                case ParkingType.ShortTermParking:
                    return new ShortTermParkingCalculator();
            }

            throw new InvalidEnumArgumentException("type", (int)type, type.GetType());
        }
    }
}
