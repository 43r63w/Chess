using Chess.BLL.Pieces;

namespace Chess.BLL.Board
{
    public class Board
    {
        private readonly BasePiece[,] _pieces = new BasePiece[8, 8];

        public BasePiece this[int row, int column]
        {
            get => _pieces[row, column];
            set => _pieces[row, column] = value;
        }

        public BasePiece this[Position position]
        {
            get => this[position.Row, position.Column];
            set => this[position.Row, position.Column] = value;
        }

        public static Board CreateGame()
        {
            var board = new Board();
            board.PostPieces();
            return board;
        }

        private void PostPieces()
        {
            this[0, 0] = new Rook(PlayerColor.Black);
            this[0, 1] = new Knight(PlayerColor.Black);
            this[0, 2] = new Bishop(PlayerColor.Black);
            this[0, 3] = new Queen(PlayerColor.Black);
            this[0, 4] = new King(PlayerColor.Black);
            this[0, 5] = new Bishop(PlayerColor.Black);
            this[0, 6] = new Knight(PlayerColor.Black);
            this[0, 7] = new Rook(PlayerColor.Black);

            this[7, 0] = new Rook(PlayerColor.White);
            this[7, 1] = new Knight(PlayerColor.White);
            this[7, 2] = new Bishop(PlayerColor.White);
            this[7, 3] = new Queen(PlayerColor.White);
            this[7, 4] = new King(PlayerColor.White);
            this[7, 5] = new Bishop(PlayerColor.White);
            this[7, 6] = new Knight(PlayerColor.White);
            this[7, 7] = new Rook(PlayerColor.White);

            for (int c = 0; c < 8; c++)
            {
                this[1, c] = new Pawn(PlayerColor.Black);
                this[6, c] = new Pawn(PlayerColor.White);
            }



        }

        public static bool IsInside(Position position)
            => position.Row >= 0 && position.Row < 8
                                 && position.Column >= 0 && position.Column < 8;

        public  bool IsEmpty(Position position)
        {
            return this[position] == null;
        }


    }
}
