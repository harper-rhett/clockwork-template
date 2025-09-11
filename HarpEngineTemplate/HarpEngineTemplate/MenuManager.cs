using HarpEngine;
using HarpEngine.Graphics;
using HarpEngine.Input;
using System.Numerics;

// Entity control and properties live here

internal class MenuManager : Entity
{
	private string text = "ENTER to Start Game";
	private Vector2 position;
	private const int fontSize = 50;
	private const float bobSpeed = 4f;

	public MenuManager(Scene scene) : base(scene)
	{
		int width = Text.MeasureWidth(text, fontSize);
		position = new(
			Engine.HalfGameWidth - width / 2,
			Engine.HalfGameHeight - fontSize / 2
		);
	}

	public override void Update(float frameTime)
	{
		if (Keyboard.IsKeyPressed(KeyboardKey.Enter)) HelloGame.Instance.Start();
	}

	public override void Draw()
	{
		float yOffset = (int)(float.Sin(scene.Time * bobSpeed) * (fontSize / 2f));
		Vector2 offset = new(0, yOffset);
		Text.Draw(text, position + offset, fontSize, Colors.White);
	}
}
