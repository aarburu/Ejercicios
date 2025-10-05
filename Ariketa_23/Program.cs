using Ariketa_23.Models.Pieces;
using Ariketa_23.Models;
var game = new GameTable(10, 20);
game.ActivePiece = game.GenerateRandomPiece();

while (true)
{
    game.DisplayWithActivePieceOverlay();

    ConsoleKey key = Console.ReadKey(true).Key;

    switch (key)
    {
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
            game.DrawActivePieceOnTable();
            var fullRows = game.CheckFullRow();

            foreach (var row in fullRows)
                game.DeleteRow(row);

            game.ActivePiece = game.GenerateRandomPiece();
            break;
    }
    // Sin un delay, si se mantiene una tecla pulsada, el tablero se vuelve completamente negro por refrescos constantes.
    // Añado un delay minimo para que se vea constantemente la tabla.
    Thread.Sleep(1);
}