namespace Chess.BLL.Pieces
{
    public class Pawn : BasePiece
    {
        public override PiecesType Piece => PiecesType.Pawn;
        public override PlayerColor Color { get; }

        public Pawn(PlayerColor color)
        {
            Color = color;
        }


        public override BasePiece Copy()
        {
            Pawn pawn = new Pawn(Color);
            pawn.IsMoved = IsMoved;
            return pawn;
        }


    }
}
