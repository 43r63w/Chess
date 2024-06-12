namespace Chess.BLL.Pieces
{
    public abstract class BasePiece
    {
        public abstract PiecesType Piece { get; }
        public abstract PlayerColor Color { get; }

        public bool IsMoved { get; set; }

        public abstract BasePiece Copy();
        
    }
}
