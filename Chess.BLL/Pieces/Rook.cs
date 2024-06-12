using System.ComponentModel;

namespace Chess.BLL.Pieces
{
    public class Rook : BasePiece
    {
        public override PiecesType Piece => PiecesType.Rook;
        public override PlayerColor Color { get; }

        public Rook(PlayerColor color)
        {
            Color = color;
        }
        public override BasePiece Copy()
        {
            Rook rook = new Rook(Color);
            rook.IsMoved = IsMoved;

            return rook;
        }
    }
}
