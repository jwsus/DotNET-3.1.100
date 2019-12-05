namespace GameTOP
{
   public class Player1 : iPlayer
    {
        public string _Name { get; set; }

        public Player1(string Name)
        {
            this._Name = Name;
        }

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