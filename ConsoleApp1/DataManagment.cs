using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace ConsoleApp1
{
    public static class DataManagment
    {
        public static void SavePlayerdata(Player p)
        {
            string jsP = JsonSerializer.Serialize(p);
            Console.WriteLine("Saving {0}", jsP);
            Console.WriteLine("where do you want to save? be very specific ex: e:\\vgd\\PMPlayerData.txt >");
            string fileName = Console.ReadLine();
            File.WriteAllText(fileName, jsP);
            Console.WriteLine("Player Data Saved");
            return;
        }

        public static Player LoadPlayerData(Player p)
        {
            Console.WriteLine("where is save file? be very specific ex: e:\\vgd\\PMPlayerData.txt >");
            string fileName = Console.ReadLine();
            //    string fileName = " e:\\vgd\\PMPlayerData.txt";
            string jsp = File.ReadAllText(fileName);
            Player P = JsonSerializer.Deserialize<Player>(jsp);
            Console.WriteLine("Player data restored");
            return P;
        }
    }
}
