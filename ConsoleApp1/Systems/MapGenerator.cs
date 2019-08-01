using ConsoleApp1.Core;
using RogueSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Systems
{
    class MapGenerator
    {
        private readonly int _width;
        private readonly int _height;

        private readonly DungeonMap _map;

        public DungeonMap CreateMap()
        {
            _map.Initialize(_width, _height);
            foreach (Cell cel in _map.GetAllCells())
            {
                _map.SetCellProperties(cel.X, cel.Y, false, false, true);
            }

            foreach (Cell cell in _map.GetCellsInRows(0, _height - 1))
            {
                _map.SetCellProperties(cell.X, cell.Y, false, false, true);
            }

            foreach (Cell cell in _map.GetCellsInRows(0, _width - 1))
            {
                _map.SetCellProperties(cell.X, cell.Y, false, false, true);
            }

            return _map;
        }
    }
}
