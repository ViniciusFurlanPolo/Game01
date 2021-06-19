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
        }

        public void setClasse(Player model)
        {
            this.classe = model.classe;
        }

        public void setHitPoints(Player model)
        {
            this.hitPoints = model.hitPoints;
        }

        public void setExp(Player model)
        {
            this.exp = model.exp;
        }

        public void setLevel(Player model)
        {
            this.level = model.level;
        }

        public void setGold(Player model)
        {
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
