namespace Shooting
{
    class Bullet : GameObject
    {
        public int BulletPositionX
        {
            get;
            set => mConsolPosition.x = value;
        }
        public int BulletPositionY
        {
            get;
            set => mConsolPosition.y = value;
        }
        public Bullet(ConsolePosition playerPosition)
        {
            mTexture = "♠";

            BulletPositionX = playerPosition.x;
            BulletPositionY = playerPosition.y;

            mColor = ConsoleColor.Yellow;
        }


    }
}
