using HarpEngine;
using HarpEngine.Graphics;
using HarpEngine.Utilities;
using System.Numerics;

// Entity control and properties live here

internal class Hello : Entity
{
	private Vector2 position;
	private string text = "Hello!";
	private Color[] colors =
	[
		Colors.Red,
		Colors.Green,
		Colors.Blue,
		Colors.Yellow
	];
	private Color color;
	private const int fontSize = 50;

	public Hello()
	{
		int halfWidth = Text.MeasureWidth(text, fontSize) / 2;
		int halfHeight = fontSize / 2;
		position = new(
			Generate.Float(halfWidth, Engine.GameWidth - halfWidth) - halfWidth,
			Generate.Float(halfHeight, Engine.GameHeight - halfHeight) - halfHeight
		);

		color = colors[Generate.Integer(colors.Length)];
	}

	public override void OnDraw()
	{
		Text.Draw(text, position, fontSize, color);
	}
}
