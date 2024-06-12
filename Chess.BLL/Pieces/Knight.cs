namespace Chess.BLL.Pieces
{
    public class Knight : BasePiece
    {
        public override PiecesType Piece => PiecesType.Knight;
        public override PlayerColor Color { get; }
        public Knight(PlayerColor color)
        {
            Color = color;
        }
        public override BasePiece Copy()
        {
            Knight knight = new Knight(Color);
            knight.IsMoved = IsMoved;

            return knight;
        }
    }
}
