using Ariketa_23.Interfaces;

namespace Ariketa_23.Models.Pieces
{
    internal class ZPiece : Piece
    {
        public override int[,] Form { get; set; } = {
            { 1, 1, 0 },
            { 0, 1, 1 }
        };
    }
}
