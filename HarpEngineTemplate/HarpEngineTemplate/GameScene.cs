using HarpEngine;
using HarpEngine.Utilities;

// Entity creation and scene properties live here

internal class GameScene : Scene
{
	public GameScene()
	{
		FireTimer fireTimer = new(this, 0.5f);
		fireTimer.Fired += Hello;
		fireTimer.Start();
	}

	public void Hello()
	{
		new Hello(this);
	}
}
