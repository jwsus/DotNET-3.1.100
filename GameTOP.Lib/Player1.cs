using GameTOP.Interface;

namespace GameTOP.Lib
{
   public class Player1 : iPlayer
    {
        public Player1(string _Name) 
        {
            this._Name = _Name;
               
        }
        public string _Name { get; set; }

        public string kick()
        {
            return $"{_Name} is kicking ";
        }
        public string run()
        {
            return $"{_Name} is runing ";
        }
        public string pass()
        {
            return $"{_Name} is passing ";
        }

    }
}