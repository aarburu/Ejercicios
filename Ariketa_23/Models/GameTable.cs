using Ariketa_23.Interfaces;
using Ariketa_23.Models.Pieces;

namespace Ariketa_23.Models
{
    internal class GameTable
    {
        public int DimensionX { get; set; } = 10;
        public int DimensionY { get; set; } = 20;
        public List<IPiece> PiecesInGame { get; set; }
        public List<IPiece> PiecesToCome { get; set; }
        public IPiece ActivePiece { get; set; }

        public string[,] Table { get; set; }

        public GameTable(int DimensionX, int DimensionY)
        {
            this.DimensionX = DimensionX;
            this.DimensionY = DimensionY;
            this.Table = new string[DimensionX, DimensionY];
        }

        public List<int> CheckFullRow()
        {
            var fullRows = new List<int>();

            for (int y = 0; y < DimensionY; y++) {
                bool isRowFull = true;

                for (int x = 0; x < DimensionX; x++) {
                    if (string.IsNullOrWhiteSpace(Table[x, y])) {
                        isRowFull = false;
                        break;
                    }
                }

                if (isRowFull)
                    fullRows.Add(y);
            }

            return fullRows;
        }


        public void DeleteRow(int row)
        {
            for (int y = row; y > 0; y--)
                for (int x = 0; x < DimensionX; x++)
                    Table[x, y] = Table[x, y - 1];
               

            for (int x = 0; x < DimensionX; x++)
                Table[x, 0] = "";
        }

        public void DisplayMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]}  ");
                Console.Write(" |");
                Console.WriteLine();
            }
            for (int i = 0; i < this.DimensionX +2; i++)
                Console.Write(" _ ");
        }

        public void DisplayWithActivePieceOverlay()
        {
            Console.Clear();

            for (int y = 0; y < DimensionY; y++)
            {
                Console.Write("| ");
                for (int x = 0; x < DimensionX; x++)
                {
                    bool isPieceCell = false;

                    if (ActivePiece != null)
                    {
                        for (int i = 0; i < ActivePiece.Form.GetLength(0); i++)
                        {
                            for (int j = 0; j < ActivePiece.Form.GetLength(1); j++)
                            {
                                if (ActivePiece.Form[i, j] == 1)
                                {
                                    int px = ActivePiece.PositionX + i;
                                    int py = ActivePiece.PositionY + j;

                                    if (px == x && py == y)
                                    {
                                        isPieceCell = true;
                                        break;
                                    }
                                }
                            }
                            if (isPieceCell) break;
                        }
                    }

                    string cell = isPieceCell ? "■ " : (string.IsNullOrWhiteSpace(Table[x, y]) ? "· " : "■ ");
                    Console.Write(cell);
                }
                Console.WriteLine("|");
            }

            Console.Write("  ");
            for (int i = 0; i < DimensionX; i++)
                Console.Write("==");
            Console.WriteLine();
            DrawControlls();
        }

        public void DrawControlls()
        {
            Console.WriteLine();
            Console.WriteLine("Controles:");
            Console.WriteLine(" - Flecha izquierda/derecha: Mover la pieza a la izquierda/derecha.");
            Console.WriteLine(" - Flecha abajo: Mover la pieza hacia abajo.");
            Console.WriteLine(" - Flecha arriba: Rotar la pieza.");
            Console.WriteLine(" - Espacio: Bloquear la pieza.");
        }

        public void DrawActivePieceOnTable()
        {
            if (ActivePiece == null) return;

            for (int i = 0; i < ActivePiece.Form.GetLength(0); i++)
            {
                for (int j = 0; j < ActivePiece.Form.GetLength(1); j++)
                {
                    if (ActivePiece.Form[i, j] == 1)
                    {
                        int x = ActivePiece.PositionX + i;
                        int y = ActivePiece.PositionY + j;

                        if (x >= 0 && x < DimensionX && y >= 0 && y < DimensionY)
                        {
                            Table[x, y] = "■";
                        }
                    }
                }
            }
        }


        public bool CanMove(int offsetX, int offsetY)
        {
            for (int i = 0; i < ActivePiece.Form.GetLength(0); i++)
            {
                for (int j = 0; j < ActivePiece.Form.GetLength(1); j++)
                {
                    if (ActivePiece.Form[i, j] == 1)
                    {
                        int newX = ActivePiece.PositionX + i + offsetX;
                        int newY = ActivePiece.PositionY + j + offsetY;

                        if (newX < 0 || newX >= DimensionX || newY < 0 || newY >= DimensionY)
                            return false;

                        if (!string.IsNullOrWhiteSpace(Table[newX, newY]))
                            return false;
                    }
                }
            }
            return true;
        }

        public void MovePiece(int offsetX, int offsetY)
        {
            if (CanMove(offsetX, offsetY))
            {
                ActivePiece.PositionX += offsetX;
                ActivePiece.PositionY += offsetY;
            }
        }
        public void RotateActivePiece()
        {
            var piece = (Piece)ActivePiece;
            if (piece.CanRotate(Table, DimensionX, DimensionY))
            {
                piece.Form = piece.RotateClockwise();
            }
        }


        public IPiece GenerateRandomPiece()
        {
            var rng = new Random();
            int choice = rng.Next(5);

            IPiece piece = choice switch
            {
                0 => new SquarePiece(),
                1 => new LPiece(),
                2 => new SPiece(),
                3 => new StickPiece(),
                4 => new ZPiece(),
                _ => new SquarePiece()
            };
            piece.PositionX = 4;
            piece.PositionY = 0;
            return piece;
        }
    }
}
