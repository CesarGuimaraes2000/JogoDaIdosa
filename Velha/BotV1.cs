namespace Velha
{
    internal class BotV1
    {
        public int Id {get; set;}

        public BotV1(int id)
        {
            this.Id = id;   
        }

        public int Jogar()
        {
            Random random = new Random();   
            return random.Next(50);
        }
    }
}