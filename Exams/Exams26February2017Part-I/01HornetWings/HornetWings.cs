﻿namespace _01HornetWings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class HornetWings
    {
        public static void Main()
        {
            decimal flapsHornet = decimal.Parse(Console.ReadLine());
            decimal distanceHornetTravels = decimal.Parse(Console.ReadLine());
            decimal enduranceHornet = decimal.Parse(Console.ReadLine());


            decimal test = 1000 / distanceHornetTravels;
            decimal distanceMeters = (flapsHornet / 1000) * distanceHornetTravels;
            //Console.WriteLine(distanceMeters); output
            decimal hornetFlapsSeconds = flapsHornet / 100;
            //decimal.WriteLine(hornetFlapsSeconds);
            long result = (long)(flapsHornet / enduranceHornet) * 5;
            long resultFinish = (long) (result + hornetFlapsSeconds);
            //Console.WriteLine(resultFinish);

            Console.WriteLine($"{distanceMeters:F2} m.");
            Console.WriteLine($"{resultFinish} s.");
        }
    }
}
