using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        private Location Location;

        public Player PlayerAtual { get; set; }
        public World MundoAtual { get; set; }
        public Location LocalAtual
        {
            get { return Location; }
            set
            {
                Location = value;

                OnPropertyChanged(nameof(LocalAtual));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToSouth));
            }
        }

        public bool HasLocationToNorth
        {
            get
            {
                return MundoAtual.localAtual(LocalAtual.coordenadaX, LocalAtual.coordenadaY + 1) != null;
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                return MundoAtual.localAtual(LocalAtual.coordenadaX + 1, LocalAtual.coordenadaY) != null;
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                return MundoAtual.localAtual(LocalAtual.coordenadaX, LocalAtual.coordenadaY - 1) != null;
            }
        }

        public bool HasLocationToWest
        {
            get
            {
                return MundoAtual.localAtual(LocalAtual.coordenadaX - 1, LocalAtual.coordenadaY) != null;
            }
        }

        public GameSession()
        {
            PlayerAtual = new Player();
            PlayerAtual.nome = "Arthur";
            PlayerAtual.gold = 100;
            PlayerAtual.classe = "Fighter";
            PlayerAtual.hitPoints = 10;
            PlayerAtual.exp = 0;
            PlayerAtual.level = 1;

            WorldFactory factory = new WorldFactory();
            MundoAtual = factory.CreateWorld();

            LocalAtual = MundoAtual.localAtual(0, 0);

        }
        public void MoveNorth()
        {
            LocalAtual = MundoAtual.localAtual(LocalAtual.coordenadaX, LocalAtual.coordenadaY + 1);
        }

        public void MoveEast()
        {
            LocalAtual = MundoAtual.localAtual(LocalAtual.coordenadaX + 1, LocalAtual.coordenadaY);
        }

        public void MoveSouth()
        {
            LocalAtual = MundoAtual.localAtual(LocalAtual.coordenadaX, LocalAtual.coordenadaY - 1);
        }

        public void MoveWest()
        {
            LocalAtual = MundoAtual.localAtual(LocalAtual.coordenadaX - 1, LocalAtual.coordenadaY);
        }
    }
}
