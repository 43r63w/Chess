namespace Chess.BLL.Pieces
{
    public class Bishop : BasePiece
    {
        public override PiecesType Piece => PiecesType.Bishop;
        public override PlayerColor Color { get; }

        public Bishop(PlayerColor color)
        {
            Color = color;
        }
        
        public override BasePiece Copy()
        {
            Bishop bishop = new Bishop(Color);
            bishop.IsMoved = IsMoved;

            return bishop;
        }
    }
}
