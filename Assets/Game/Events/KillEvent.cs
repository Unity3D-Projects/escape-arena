using EcsRx.Entities;

namespace Assets.Game.Events
{
	public class KillEvent
	{
		public IEntity source;
		public IEntity target;
	}
}