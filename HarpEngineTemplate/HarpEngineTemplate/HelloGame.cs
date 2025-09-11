using HarpEngine;
using HarpEngine.Graphics;
using HarpEngine.Windowing;

// Scene management lives here

internal class HelloGame : Game
{
	public static HelloGame Instance;
	private Scene activeScene;

	public HelloGame()
	{
		Instance = this;

		Window.SetResizable(true);
		Window.SetFullRenderer(Colors.DarkGray);

		activeScene = new MenuScene();
	}

	public override void Update(float frameTime)
	{
		activeScene.Update(frameTime);
	}

	public override void Draw()
	{
		Drawing.Clear(Colors.Black);
		activeScene.Draw();
	}

	public void Start()
	{
		activeScene = new GameScene();
	}
}
