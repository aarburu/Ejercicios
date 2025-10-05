using Ariketa_23.Interfaces;

namespace Ariketa_23.Models.Pieces
{
    internal class SPiece : Piece
    {
        public override int[,] Form { get; set; } = {
            { 0, 1, 1 },
            { 1, 1, 0 }
        };
    }
}
