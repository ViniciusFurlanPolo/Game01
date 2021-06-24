using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> gameItems;

        static ItemFactory()
        {
            gameItems = new List<GameItem>();

            gameItems.Add(new Weapon(1001, "Graveto Pontudo", 1, 1, 3));
            gameItems.Add(new Weapon(1002, "Espada Antiga", 5, 3, 6 ));
            gameItems.Add(new Weapon(1003, "A fucking GUN", 666, 999, 999));
        }

        public static GameItem CriarItem(int id)
        {
            GameItem item = gameItems.FirstOrDefault(i => i.ItemTypeId == id);

            if (item != null)
            {
                return item.Clone();
            }

            return null;
        }
    }
}
