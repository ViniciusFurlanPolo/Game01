using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    class Player
    {
        private String nome;

        private String classe;

        private int hitPoints;

        private int exp;

        private float level;

        private int gold;


        public void set(Player model)
        {
            this.nome = model.nome;
            this.classe = model.classe;
            this.hitPoints = model.hitPoints;
            this.exp = model.exp;
            this.level = model.level;
            this.gold = model.gold;

        }

        public String getNome()
        {
            return nome;
        }

        public String getClasse()
        {
            return classe;
        }

        public int getHitPionts()
        {
            return hitPoints;
        }

        public int getExp()
        {
            return exp;
        }

        public float getLevel()
        {
            return level;
        }

        public int getGold()
        {
            return gold;
        }

    }
}
