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
            PlayerAtual = new Player 
                            {
                                nome = "Arthur",
                                classe = "Guerreiro",
                                hitPoints = 100,
                                exp = 970,
                                level = 4,
                                gold = 800
                            };

            MundoAtual = WorldFactory.CreateWorld();

            LocalAtual = MundoAtual.localAtual(0, 0);

        }
        public void MoveNorth()
        {
            if (HasLocationToNorth)
            {
                LocalAtual = MundoAtual.localAtual(LocalAtual.coordenadaX, LocalAtual.coordenadaY + 1);
            }
            
        }

        public void MoveEast()
        {
            if (HasLocationToEast)
            {
                LocalAtual = MundoAtual.localAtual(LocalAtual.coordenadaX + 1, LocalAtual.coordenadaY);
            }
            
        }

        public void MoveSouth()
        {
            if (HasLocationToSouth)
            {
                LocalAtual = MundoAtual.localAtual(LocalAtual.coordenadaX, LocalAtual.coordenadaY - 1);
            }
            
        }

        public void MoveWest()
        {
            if (HasLocationToWest)
            {
                LocalAtual = MundoAtual.localAtual(LocalAtual.coordenadaX - 1, LocalAtual.coordenadaY);
            }
            
        }
    }
}
