using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Player2 : iPlayer
    {
        public string kick()
        {
            return ("Goku is kicking");
        }

        public string run()
        {
            return ("Goku is runking");
        }

        public string pass()
        {
            return ("Goku is passing");
        }
    }
}