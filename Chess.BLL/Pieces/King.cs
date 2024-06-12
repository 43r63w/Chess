namespace Chess.BLL.Pieces
{
    public class King : BasePiece
    {
        public King(PlayerColor color)
        {
            Color = color;
        }

        public override PiecesType Piece => PiecesType.King;

        public override PlayerColor Color { get; }

        public override BasePiece Copy()
        {
            King king = new King(Color);
            king.IsMoved = IsMoved;
            return king;
        }
    }
}
