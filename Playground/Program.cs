using Chess;

var board = new ChessBoard();

while (!board.IsEndGame)
{
    Console.WriteLine(board.ToAscii());
    board.Move(Console.ReadLine());
}