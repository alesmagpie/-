namespace Shooting
{
    class Scene
    {
        const int START_POSITION_X = 10;
        const int START_POSITION_Y = 10;
        const int SPAWN_POINT_X = 0;
        const int SPAWN_POINT_Y = 0;  

        

        <GameObject> gameObjects = new List<GameObject>();
        ConsolePosition mStartPosition = new ConsolePosition();
        ConsolePosition mSpawnPoint1 = new ConsolePosition();

        public Scene()
        {
            
        }
        public void StartScene()
        {
            mStartPosition.x = START_POSITION_X;
            mStartPosition.y = START_POSITION_Y;
            Player mPlayer = new Player(mStartPosition);
            gameObjects.Add(mPlayer);

            mSpawnPoint1.x = SPAWN_POINT_X;
            mSpawnPoint1.y = SPAWN_POINT_Y;
        }
        public void Draw()
        {
            
        }

    }
}

