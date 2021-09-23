using System;

namespace dz3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal padik = 6;
            decimal floors = 6;
            decimal flatsByfloor = 3;

            decimal pair = Math.Floor(floors / 3);

            decimal flats = padik * floors * flatsByfloor;
            decimal flatsInPadik = floors * flatsByfloor;

            Console.WriteLine($"flats: {flats}; flats in padik: {flatsInPadik}");
            //  7 8 9   16 17 18   25 26 27   34 35 36
            //  4 5 6   13 14 15   22 23 24   31 32 33
            //  1 2 3   10 11 12   19 20 21   28 29 30
            //  w w w
            //  r r r
            //  w w w
            for (decimal flat = 1; flat <= flats; flat++)
            {
                string color = "W";

                decimal curPadik = Math.Ceiling(flat / flatsInPadik);
                decimal numb = flat - (curPadik - 1) * flatsInPadik;
                decimal curFloor = Math.Ceiling(numb / flatsByfloor);

                decimal startFloor = 1 * pair + 1;
                decimal finishFloor = 2 * pair;

                if (curFloor >= startFloor && curFloor <= finishFloor)
                {
                    color = "R";
                }

                Console.WriteLine($"flat number: {flat} - {color}; padik: {curPadik}; floor: {curFloor}");
            }

            Console.WriteLine("");
            decimal totalFlatsPerFloor = flatsByfloor * padik;

            for (decimal floor = 1; floor <= floors; floor++)
            {
                string color = "W";
                Console.ForegroundColor = ConsoleColor.White;

                decimal startFloor = pair + 1;
                decimal finishFloor = 2 * pair;

                if (floor >= startFloor && floor <= finishFloor)
                {
                    color = "R";
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                string floorStr = "";
                for (decimal num = 1; num <= totalFlatsPerFloor; num++)
                {
                    floorStr += color;
                }
                Console.WriteLine($"\t\t{floorStr}");
            }
        }
    }
}
