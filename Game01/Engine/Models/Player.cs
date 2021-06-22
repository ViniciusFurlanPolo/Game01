using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {

        private String Nome;

        private String Classe;

        private int HP;

        private int Xp;

        private int Level;

        private int Gold;

        public String nome 
        {
            get { return Nome; } 
            set 
            {
                Nome = value;
                OnPropertyChanged(nameof(nome));
            }
        }

        public String classe 
        { 
            get { return Classe; }
            set 
            {
                Classe = value;
                OnPropertyChanged(nameof(classe));
            }
        }

        public int hitPoints 
        { 
            get { return HP; }
            set
            {
                HP = value;
                OnPropertyChanged(nameof(hitPoints));
            }
        }

        public int exp 
        {
            get { return Xp; }
            set 
            {
                Xp = value;
                OnPropertyChanged(nameof(exp));
            }
        }

        public int level 
        {
            get { return Level; } 
            set
            {
                Level = value;
                OnPropertyChanged(nameof(level));
            }
        }

        public int gold 
        {
            get { return Gold; }
            set
            {
                Gold = value;
                OnPropertyChanged(nameof(gold));
            }
        }

       

    }
}
