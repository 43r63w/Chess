
namespace Chess.BLL.Extensions
{
    public static class PlayerExtension
    {
        public static PlayerColor GetOpponetColor(this PlayerColor playerColor)
        {
            return playerColor switch
            {
                PlayerColor.Black => PlayerColor.White,
                PlayerColor.White => PlayerColor.Black,
                _ => PlayerColor.None
            };
        }
        
        
    }
}
