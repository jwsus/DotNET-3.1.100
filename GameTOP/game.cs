using GameTOP.Interface;

namespace GameTOP
{
    class game
    {
        private readonly iPlayer _player1;
        private readonly iPlayer _player2;

        public game(iPlayer player1,iPlayer player2)
        {
            this._player1 = player1;
            this._player2 = player2;
        }
        public void startGame()
        {
            System.Console.WriteLine(_player1.pass());
            System.Console.WriteLine(_player1.run());
            System.Console.WriteLine(_player1.kick());

            System.Console.WriteLine(_player2.pass());
            System.Console.WriteLine(_player2.run());
            System.Console.WriteLine(_player2.kick());
        }
    }
}