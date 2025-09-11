using HarpEngine;
using HarpEngine.Graphics;
using HarpEngine.Utilities;
using System.Numerics;

// Entity control and properties live here

internal class Hello : Entity
{
	private Vector2 position;
	private string text = "Hello!";
	private Color[] colors = new[]
	{
		Colors.Red,
		Colors.Green,
		Colors.Blue,
		Colors.Yellow
	};
	private Color color;
	private const int fontSize = 50;

	public Hello(Scene scene) : base(scene)
	{
		Random random = new();

		int halfWidth = Text.MeasureWidth(text, fontSize) / 2;
		int halfHeight = fontSize / 2;
		position = new(
			random.NextFloat(halfWidth, Engine.GameWidth - halfWidth) - halfWidth,
			random.NextFloat(halfHeight, Engine.GameHeight - halfHeight) - halfHeight
		);

		color = colors[random.Next(colors.Length)];
	}

	public override void Draw()
	{
		Text.Draw(text, position, fontSize, color);
	}
}
