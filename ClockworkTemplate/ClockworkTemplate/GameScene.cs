using Clockwork;
using Clockwork.Utilities;

// Entity creation and scene properties live here

internal class GameScene : Scene
{
	public GameScene()
	{
		FireTimer fireTimer = AddEntity(new FireTimer(0.1f));
		fireTimer.Fired += Hello;
		fireTimer.Start();
	}

	public void Hello()
	{
		AddEntity(new Hello());
	}
}
