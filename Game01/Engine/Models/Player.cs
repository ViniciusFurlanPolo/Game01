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

        private int level;

        private int gold;


        public void setNome(String model)
        {
            this.nome = model;
        }

        public void setClasse(String model)
        {
            this.classe = model;
        }

        public void setHitPoints(int model)
        {
            this.hitPoints = model;
        }

        public void setExp(int model)
        {
            this.exp = model;
        }

        public void setLevel(int model)
        {
            this.level = model;
        }

        public void setGold(int model)
        {
            this.gold = model;
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

        public int getLevel()
        {
            return level;
        }

        public int getGold()
        {
            return gold;
        }

    }
}
