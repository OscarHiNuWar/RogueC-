﻿using RLNET;
using RogueSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Core
{
    class DungeonMap : Map
    {
        public void Draw(RLConsole mapConsole)
        {
            mapConsole.Clear();
            foreach (Cell cell in GetAllCells())
            {
                SetConsoleSymbolForCell(mapConsole, cell);
            }
        }

        private void SetConsoleSymbolForCell(RLConsole console, Cell cell)
        {
            if (!cell.IsExplored)
            {
                return;
            }

            if (IsInFov(cell.X, cell.Y))
            {
                if (cell.IsWalkable)
                {
                    console.Set( cell.X, cell.Y, Colors.FloorFov, Colors.FloorBackgroundFov, '.' );
                }
                else
                {
                    console.Set(cell.X, cell.Y, Colors.WallFov, Colors.WallBackgroundFov, '#');
                }
            }
            else
            {
                if (cell.IsWalkable)
                {
                    console.Set(cell.X, cell.Y, Colors.FloorFov, Colors.FloorBackground, '.');
                }
                else
                {
                    console.Set(cell.X, cell.Y, Colors.Wall, Colors.WallBackground, '#');
                }
            }
        }
    }
}
