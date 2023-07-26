

using ICloneableNS;

Square square = new Square();

square.Page = new Page() { Number = 100 };
square.Width = 48;

Square clonedSquare = (Square)square.Clone();

clonedSquare.Width *= 2;
clonedSquare.Page.Number *= 2;

Console.WriteLine($"Original square - {square.Width}");
Console.WriteLine($"Cloned square - {clonedSquare.Width}");

Console.WriteLine($"Original square page - {square.Page.Number}");
Console.WriteLine($"Cloned square page- {clonedSquare.Page.Number}");