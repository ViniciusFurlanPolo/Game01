using Engine.Factories;
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
        public World MundoAtual { get; set; }

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
    }
}
