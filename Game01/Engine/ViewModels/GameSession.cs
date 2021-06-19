using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player PlayerAtual { get; set; }
        public Location LocalAtual { get; set; }

        public GameSession()
        {
            PlayerAtual = new Player();
            PlayerAtual.nome = "Arthur";
            PlayerAtual.gold = 100;
            PlayerAtual.classe = "Fighter";
            PlayerAtual.hitPoints = 10;
            PlayerAtual.exp = 0;
            PlayerAtual.level = 1;

            LocalAtual = new Location();
            LocalAtual.lugar = "Home";
            LocalAtual.coordenadaX = 0;
            LocalAtual.coordenadaY = -1;
            LocalAtual.descricao = "This is your house";
            LocalAtual.imageFile = "pack://application:,,,/Engine;component/Images/Locations/Home.png";

        }
    }
}
