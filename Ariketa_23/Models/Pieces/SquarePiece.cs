using Ariketa_23.Interfaces;

namespace Ariketa_23.Models.Pieces
{
    internal class SquarePiece : Piece
    {
		public override int[,] Form { get; set; } = {
            { 1, 1 },
            { 1, 1 }
        };
    }
}
