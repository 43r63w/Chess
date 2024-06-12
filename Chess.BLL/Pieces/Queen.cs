namespace Chess.BLL.Pieces
{
    public class Queen : BasePiece
    {
        public override PiecesType Piece => PiecesType.Queen;
        public override PlayerColor Color { get; }
        
        public Queen(PlayerColor color)
        {
            Color = color;
        }

        public override BasePiece Copy()
        {
            Queen queen = new Queen(Color);
            queen.IsMoved = IsMoved;

            return queen;
        }
    }
}
