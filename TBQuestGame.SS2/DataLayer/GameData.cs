using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

/// <summary>
/// Game Data Class
/// </summary>
namespace TBQuestGame.DataLayer
{
    class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Zane",
                Age = 20,
                Title = Player.TitleName.Adventurer,
                Clan = Player.ClanType.HalfHuman,
                Health = 100,
                Lives = 3,
                Experience = 0,
                LocationId = 0

            };
            
        }

        public static GameMapCoordinates InitialGameMapLocation()
        {
            return new GameMapCoordinates() { Row = 0, Column = 0 };
        }

        public static Map GameMap()
        {
            int rows = 2;
            int columns = 2;

            Map gameMap = new Map(rows, columns);
                        
            // row 1
            gameMap.MapLocations[0, 0] = new Location()
            {
                Id = 1,
                Name = "Town of MillStone",
                Description = "The Town of MillStone Is souronded by fields and forest that the people can thrive on" +
                "But Beasts also lerk in the dark ",
                Accessible = true,
                ModifiyExperiencePoints = 10,
              
            };

            gameMap.MapLocations[0, 1] = new Location()
            {
                Id = 2,
                Name = "Yelma Forest",
                Description = "The Yelma Forest holds both treasure and reward. " +
                "But also treachery for wondering Adventurers looking for said treasure and rewards." ,
                Accessible = true,
                ModifyLives = -1,
                ModifiyExperiencePoints = +20
            };

            
            // row 2
            
            gameMap.MapLocations[1, 0] = new Location()
            {
                Id = 3,
                Name = "Fenral Field",
                Description = "The Felandrian Plains are a common destination for tourist. Located just north of the " +
                "equatorial line on the planet of Corlon, they provide excellent habitat for a rich ecosystem of flora and fauna.",
                Accessible = true,
                ModifiyExperiencePoints = +20
            };

            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 4,
                Name = "Temple of Altaya",
                Description = "The Temple of Altaya is said to be built by demons and angels," +
                "but they have been at war for centurys. " ,
                Accessible = false,
                ModifiyExperiencePoints = +20,
                ModifyLives = 3,
                RequiredExperiencePoints = 40
            };
            
            return gameMap;
        }
    }
}
