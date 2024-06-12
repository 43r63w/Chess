namespace Chess.BLL.Board
{
    public class Position
    {
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
        public int Row { get; }
         public int Column { get; }


         public PlayerColor SquareColor()
         {
             return (Row + Column) % 2 == 0 ? PlayerColor.White : PlayerColor.Black;
         }
         
        /// <summary>
        /// Override logic to compare 2 objects(like Position instance)
        /// </summary>
         protected bool Equals(Position other)
         {
             return Row == other.Row && Column == other.Column;
         }
         public override bool Equals(object? obj)
         {
             if (ReferenceEquals(null, obj))
             {
                 return false;
             }
             if (ReferenceEquals(this, obj))
             {
                 return true;
             }
             if (obj.GetType() != this.GetType())
             {
                 return false;
             }
             return Equals((Position)obj);
         }
         public override int GetHashCode()
         {
             return HashCode.Combine(Row, Column);
         }
         public static bool operator ==(Position? left, Position? right)
         {
             return Equals(left, right);
         }
         public static bool operator !=(Position? left, Position? right)
         {
             return !Equals(left, right);
         }
            
         /// <summary>
         ///  Calculate next position
         /// </summary>
         public static Position operator +(Position currentPosition, Direction possibleDirection)
         {
             return new Position(currentPosition.Row + possibleDirection.RowDelta, 
             currentPosition.Column + possibleDirection.ColumnDelta);
         }
    }
}
