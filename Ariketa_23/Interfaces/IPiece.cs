namespace Ariketa_23.Interfaces
{
    internal interface IPiece
    {
        int[,] Form { get; set; }
        int Rotation { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
    }
}
