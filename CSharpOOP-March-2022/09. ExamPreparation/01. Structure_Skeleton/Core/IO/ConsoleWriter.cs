using System;
using WarCroft.Core.IO.Contracts;

namespace WarCroft.Core.IO
{
	public class ConsoleWriter : IWriter
	{
		public void WriteLine(string message)
		{
			Console.WriteLine(message);
		}
	}
}