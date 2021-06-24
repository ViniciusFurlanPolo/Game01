using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public GameItem(int id, string nome, int preco)
        {
            ItemTypeId = id;
            Name = nome;
            Price = preco;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeId, Name, Price);
        }
    }
}
