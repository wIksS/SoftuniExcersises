

// DI Framework

// Dependency Injection Framework
// Dependency Injection Containers

using _12.DependencyInjectionWorkshop;
using _12.DependencyInjectionWorkshop.DI;
using _12.DependencyInjectionWorkshop.Loggers;
using _12.DependencyInjectionWorkshop.Renderers;
using SoftuniIoC;

//ILogger logger = new ConsoleLogger();
//IRenderer renderer = new ConsoleRenderer(logger);
//Engine engine = new Engine(renderer);

ServiceProvider provider = DI.BuildServices();


//IRenderer renderer = provider.GetService<IRenderer>();

//renderer.Write("Hello from DI Framework");

Engine engine = provider.GetService<Engine>();
engine.Run();

//Shape shape = provider.GetService<Shape>();
//shape = provider.GetService<Shape>();
//shape = provider.GetService<Shape>();
//shape = provider.GetService<Shape>();
//shape = provider.GetService<Shape>();
