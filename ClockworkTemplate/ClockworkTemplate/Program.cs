using HarpEngine;

// Engine initialization lives here

Engine.Initialize("Hello Game", 800, 600);
HelloGame helloGame = new();
Engine.Start(helloGame);