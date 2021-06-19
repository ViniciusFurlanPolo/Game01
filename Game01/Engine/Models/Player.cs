using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
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
                OnPropertyChanged("nome");
            }
        }

        public String classe 
        { 
            get { return Classe; }
            set 
            {
                Classe = value;
                OnPropertyChanged("classe");
            }
        }

        public int hitPoints 
        { 
            get { return HP; }
            set
            {
                HP = value;
                OnPropertyChanged("hitPoints");
            }
        }

        public int exp 
        {
            get { return Xp; }
            set 
            {
                Xp = value;
                OnPropertyChanged("exp");
            }
        }

        public int level 
        {
            get { return Level; } 
            set
            {
                Level = value;
                OnPropertyChanged("level");
            }
        }

        public int gold 
        {
            get { return Gold; }
            set
            {
                Gold = value;
                OnPropertyChanged("gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(String PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

    }
}
