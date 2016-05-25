using System.Threading.Tasks;

namespace MudDesigner.MudEngine.Actors
{
    public class MudPlayer : MudCharacter, IPlayer
    {
        protected override Task Load()
        {
            return Task.FromResult(0);
        }

        protected override Task Unload()
        {
            return Task.FromResult(0);
        }
    }
}
