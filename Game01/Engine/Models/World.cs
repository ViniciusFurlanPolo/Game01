using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location loc = new Location();
            loc.coordenadaX = xCoordinate;
            loc.coordenadaY = yCoordinate;
            loc.lugar = name;
            loc.descricao = description;
            loc.imageFile = imageName;

            locations.Add(loc);
        }

        public Location localAtual(int cordX, int cordY)
        {
            foreach (Location location in locations)
            {
                if (location.coordenadaX == cordX && location.coordenadaY == cordY)
                {
                    return location;
                }
            }

            return null;
        }

    }
}
