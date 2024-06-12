using System.Net.NetworkInformation;

namespace Chess.BLL.Board
{
    public class Direction
    {
        /// <summary>
        /// Base Direction For Board Chess
        /// </summary>
        public readonly static Direction North = new Direction(-1, 0);

        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);

        /// <summary>
        /// Base Diagonal Direction For Board Chess
        /// </summary>
        public readonly static Direction NorthEast = North + East;

        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction SouthWest = South + West;

        public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }
        public int RowDelta { get; }

        public int ColumnDelta { get; }

        public static Direction operator +(Direction instance1, Direction instance2)
        {
            return new Direction(instance1.RowDelta + instance2.RowDelta, instance1.ColumnDelta + instance2.ColumnDelta);
        }

        public static Direction operator *(int scale, Direction instance)
        {
            return new Direction(scale * instance.RowDelta, scale * instance.ColumnDelta);
        }

      

    }
}
