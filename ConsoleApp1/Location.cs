using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Location
    {
        public string LocationName;
        public string Description;
        public int MonsterId;

        public Location(string locationName, string description, int monsterId)
        {
            LocationName = locationName;
            Description = description;
            MonsterId = monsterId;
        }

        // map
        public static void DrawMap(Location[,] loc, int playerX, int playerY)
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.array.length?view=net-5.0
            //Console.WriteLine(loc.Rank);
            int xDim = loc.GetUpperBound(0);
            int yDim = loc.GetUpperBound(1);
            //Console.WriteLine("{0}, {1}", xDim, yDim);
            for (int y = 0; y <= yDim; y++)
            {
                for (int x = 0; x <= xDim; x++)
                {
                    string locName = "*";

                    //if (loc[x, y].LocationName != null || loc[x, y].MonsterID != 0)
                    if (loc[x, y] != null)
                    {
                        locName = loc[x, y].LocationName.Substring(0, 1);
                        //locName = "+";
                    }
                    if (x == playerX && y == playerY)
                    {
                        locName = "X";
                    }
                    Console.Write(locName);
                }
                Console.WriteLine("");
            }
        }
    }
}
