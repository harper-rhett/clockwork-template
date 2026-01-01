using HarpEngine;

// Entity creation and scene properties live here

internal class MenuScene : Scene
{
	public MenuScene()
	{
		AddEntity(new MenuManager());
	}
}
