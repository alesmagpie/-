namespace Shooting
{
    class Enemy : GameObject
    {
        public int EnemyPositionX
        {
            get;
            set => mConsolPosition.x = value;
        }
        public int EnemyPositionY
        {
            get;
            set => mConsolPosition.y = value;
        }

        //시간마다 이동


        public Enemy(ConsolePosition spawnPoint)
        {
            mTexture = "▼";

            EnemyPositionX = spawnPoint.x;
            EnemyPositionY = spawnPoint.y;

            mColor = ConsoleColor.Red;
        }


    public static void SpawnEnemy(ConsolePosition spawnPoint) => new Enemy(spawnPoint); 


    }
}

