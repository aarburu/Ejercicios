using Ariketa_23.Models.Pieces;
using Ariketa_23.Models;
var game = new GameTable(10, 20);
game.ActivePiece = game.GenerateRandomPiece();

while (true)
{
    game.DisplayWithActivePieceOverlay();

    ConsoleKey key = Console.ReadKey().Key;

    switch (key)
    {
        // TODO:: Rotación al pulsar espacio, al pulsar arriba bajar y colocar la pieza automaticamente.

        case ConsoleKey.LeftArrow:
            game.MovePiece(-1, 0);
            break;
        case ConsoleKey.RightArrow:
            game.MovePiece(1, 0);
            break;
        case ConsoleKey.DownArrow:
            game.MovePiece(0, 1);
            break;
        case ConsoleKey.UpArrow:
            game.RotateActivePiece();
            break;
        case ConsoleKey.Spacebar:
            // TODO:: En lugar de pulsar espacio, provocar el bloqueo cuando llegue abajo. Pasar la rotación al espacio.
            game.DrawActivePieceOnTable();
            var fullRows = game.CheckFullRow();

            foreach (var row in fullRows)
                game.DeleteRow(row);

            game.ActivePiece = game.GenerateRandomPiece();
            break;
    }

    // TODO:: Provocar que las piezas caigan 1 posición cada segundo.
}