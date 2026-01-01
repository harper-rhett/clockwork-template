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
		Window.SetRendererUnclipped(Colors.DarkGray);
		Window.Resize(800, 600);

		activeScene = new MenuScene();
	}

	public override void OnUpdate()
	{
		activeScene.Update();
	}

	public override void OnDraw()
	{
		activeScene.Draw();
	}

	public void Start()
	{
		activeScene = new GameScene();
	}
}
