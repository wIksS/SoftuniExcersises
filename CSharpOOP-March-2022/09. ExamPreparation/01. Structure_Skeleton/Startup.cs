using System;
using WarCroft.Core;
using WarCroft.Core.IO;
using WarCroft.Core.IO.Contracts;

namespace WarCroft
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            var engine = new Engine(reader, writer);
            engine.Run();

                /* Use the below configuration instead of the usual one if you wish to print all output messages together after the inputs for easier comparison with the example output. */

            //IReader reader = new ConsoleReader();
            //var sbWriter = new StringBuilderWriter();

            //var engine = new Engine(reader, sbWriter);
            //engine.Run();

            //Console.WriteLine(sbWriter.sb.ToString().Trim());
        }
	}
}