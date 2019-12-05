using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new game(new Player1("Michel"), 
                                new Player2());
            game.startGame();
        }
    }   
}
