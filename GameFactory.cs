using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GameLibLab2
{
    public class GameFactory
    {
        public List<Game> gList = new List<Game>();

        

        public void CreateGameList()
        {
            Game p = new Game("Heat", "Thunder", 101, 100);
            gList.Add(p);
            p = new Game("Dolphins", "Patriots", 25, 23);
            gList.Add(p);
            p = new Game("Marlins", "Yankees", 18, 25);
            gList.Add(p);
            p = new Game("Panthers", "Thunder", 3, 1);
            gList.Add(p);
            p = new Game("Greek", "Romans", 250, 300);
            gList.Add(p);
            p = new Game("Metallica", "Megadeth", 90, 89);
            gList.Add(p);
        }

        const string FilePath = @"..\..\games.xml";
        public bool SerializeGameList() //this method should serialize the list to a file
        {
            StreamWriter sw = new StreamWriter(FilePath);
            XmlSerializer cereal = new XmlSerializer(gList.GetType());
            cereal.Serialize(sw, gList);
            sw.Close();
            return true;
        }

        public List<Game> DeserializeGameList()
        {
            gList = new List<Game>();
            StreamReader sr = new StreamReader(FilePath);
            XmlSerializer cereal = new XmlSerializer(gList.GetType());
            gList = (List<Game>)cereal.Deserialize(sr);
            sr.Close();
            return gList;
        }

    }
}
