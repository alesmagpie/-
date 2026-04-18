namespace Shooting
{
    class Player : GameObject
    {
        public int PlayerPositionX
        {
            get;
            set => mConsolPosition.x = value;
        }
        public int PlayerPositionY
        {
            get;
            set => mConsolPosition.y = value;
        }

        public Player(ConsolePosition startPosition)
        {
            mTexture = "△";

            PlayerPositionX = startPosition.x;
            PlayerPositionY = startPosition.y;

            mColor = ConsoleColor.Blue;
        }

    }
}