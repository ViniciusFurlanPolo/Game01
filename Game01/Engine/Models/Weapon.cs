using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximunDamage { get; set; }
        public Weapon(int itemId, string nome, int preco, int min, int max) 
            : base(itemId, nome, preco)
        {
            MinimumDamage = min;
            MaximunDamage = max;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeId, Name, Price, MinimumDamage, MaximunDamage);
        }
    }
}
