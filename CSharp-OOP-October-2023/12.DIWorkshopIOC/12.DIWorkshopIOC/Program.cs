using _12.DIWorkshopIOC.DI;
using Renderers;
using Renderers.Renderers;

// global depency inversion/injection
// IoC Container - inversion of control container


Canvas canvas = DIProvider.GetServiceProvider().GetRequiredService<Canvas>();

canvas.Draw();