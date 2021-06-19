using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player PlayerAtual { get; set; }

        public GameSession()
        {
            PlayerAtual = new Player();
            PlayerAtual.nome = "Arthur";
            PlayerAtual.gold = 100;
            PlayerAtual.classe = "Fighter";
            PlayerAtual.hitPoints = 10;
            PlayerAtual.exp = 0;
            PlayerAtual.level = 1;
        }
    }
}
