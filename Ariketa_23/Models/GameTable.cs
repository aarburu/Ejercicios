using Ariketa_23.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_23.Models
{
    internal class GameTable
    {
        public int DimensionX { get; set; } = 10;
        public int DimensionY { get; set; } = 10;
        public List<IPiece> PiecesInGame { get; set; }
        public List<IPiece> PiecesToCome { get; set; }
        public IPiece ActivePiece { get; set; }

        public string[,] Table { get; set; }

        public GameTable() { }
        public GameTable(int DimensionX, int DimensionY)
        {
            this.DimensionX = DimensionX;
            this.DimensionY = DimensionY;
            this.Table = new string[DimensionX, DimensionY];
        }

        public void CheckFullRow()
        {
            var FullRows = new List<int>(); 
            for (int i = 0; i < DimensionX; i++)
            {
                var IsRowFull = true;
                for (int j = 0; j < DimensionY; j++)
                    if (string.IsNullOrWhiteSpace(Table[i,j]))
                        IsRowFull = false;
                if (IsRowFull)
                    FullRows.Add(i);
            }
        }

        public void DeleteRow(int row)
        {
            for (int i = 0; i < DimensionX; i++)
            {
                var nextRow = row + 1;
                if (nextRow == DimensionY)
                    this.Table[i, nextRow] = "";
                else
                    this.Table[i, row] = this.Table[i, row + 1];
            }
        }

        public void RefreshWindow()
        {
            Console.Clear();
            DisplayMatrix(this.Table);
        }

        public void DisplayMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]} ");
                Console.Write("|");
                Console.WriteLine();
            }
            for (int i = 0; i < DimensionX +2; i++)
                Console.Write("_");
        }
    }
}
