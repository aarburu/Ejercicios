using Ariketa_23.Interfaces;

namespace Ariketa_23.Models.Pieces
{
    internal abstract class Piece : IPiece
    {
        public abstract int[,] Form { get; set; }
        public int Rotation { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public virtual void Draw()
        {
            for (int i = 0; i < Form.GetLength(0); i++)
            {
                for (int j = 0; j < Form.GetLength(1); j++)
                {
                    Console.Write(Form[i, j] == 1 ? "■" : " ");
                }
                Console.WriteLine();
            }
        }

        public virtual int[,] RotateClockwise()
        {
            int rows = Form.GetLength(0);
            int cols = Form.GetLength(1);
            int[,] rotated = new int[cols, rows];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    rotated[j, rows - 1 - i] = Form[i, j];

            return rotated;
        }

        public virtual bool CanRotate(string[,] table, int tableWidth, int tableHeight)
        {
            var rotatedForm = RotateClockwise();

            for (int i = 0; i < rotatedForm.GetLength(0); i++)
            {
                for (int j = 0; j < rotatedForm.GetLength(1); j++)
                {
                    if (rotatedForm[i, j] == 1)
                    {
                        int x = PositionX + i;
                        int y = PositionY + j;

                        if (x < 0 || x >= tableWidth || y < 0 || y >= tableHeight)
                            return false;

                        if (!string.IsNullOrWhiteSpace(table[x, y]))
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
