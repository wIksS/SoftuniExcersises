

string[] files = Directory.GetFiles("../../../../");

Console.WriteLine(String.Join("\n", files));
FileInfo fileInfo = new FileInfo(files[0]);
Console.WriteLine(fileInfo.CreationTime);

string[] directories = Directory.GetDirectories("../../../../");

Console.WriteLine(String.Join("\n", directories));


