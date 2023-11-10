

using Renderers;
using Renderers.Renderers;

Canvas consoleCanvas = new Canvas(new ConsoleRenderer());

Canvas textCanvas = new Canvas(new TextRenderer());

consoleCanvas.Draw();

textCanvas.Draw();