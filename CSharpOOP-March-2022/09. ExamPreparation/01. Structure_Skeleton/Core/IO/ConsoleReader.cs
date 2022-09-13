using System;
using WarCroft.Core.IO.Contracts;

namespace WarCroft.Core.IO
{
	public class ConsoleReader : IReader
	{
		public string ReadLine()
		{
			return Console.ReadLine();
		}
	}
}
