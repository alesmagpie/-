using System.Collections.ObjectModel;

namespace Shooting
{
    class RenderManager
    {
        public static void Render(List<GameObject> gameObjects)
        {
            foreach (GameObject gameObject in gameObjects)
            {              
                
                DrawObject();
            }
        }

        public void DrawObject(ConsolePosition consolPosition, string texture, ConsoleColor color)
        {
            Console.SetCursorPosition(consolPosition.x, consolPosition.y);
            Console.ForegroundColor = color;
            Console.Write(texture);
        }
        

    }
}