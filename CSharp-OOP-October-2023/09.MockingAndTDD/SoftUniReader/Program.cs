using SoftUniReader;

SoftuniReader reader = new SoftuniReader(new HTTPRequester());

Console.WriteLine(reader.ReadSoftUniData());