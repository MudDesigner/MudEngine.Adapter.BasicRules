namespace MudDesigner.MudEngine.Actors
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer()
        {
            var player = new MudPlayer();

            return player;
        }
    }
}