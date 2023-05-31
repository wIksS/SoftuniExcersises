

//Directory.CreateDirectory("../../../NewFolder");

//Directory.Delete("../../../NewFolder");

//Directory.Move("../../../NewFolder", "NewFolder");

DirectoryInfo directoryInfo = new DirectoryInfo("../../../NewFolder");

Console.WriteLine(directoryInfo.FullName);
Console.WriteLine(directoryInfo.Name);
Console.WriteLine(directoryInfo.CreationTime);
Console.WriteLine(directoryInfo.LastAccessTime);

FileInfo[] files = directoryInfo.GetFiles();


Console.WriteLine("Files:");
foreach (FileInfo file in files)
{
    Console.WriteLine(file.FullName);
    Console.WriteLine(file.Name);
    Console.WriteLine(file.CreationTime);
    Console.WriteLine(file.LastAccessTime);
    Console.WriteLine(file.Extension);
    Console.WriteLine($"{file.Length/1024.0/1024.0} mb");
}

DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();

Console.WriteLine("Sub dirs:");

foreach (var subDirectory in subDirectories)
{
    Console.WriteLine(subDirectory.Name);
    Console.WriteLine(subDirectory.Attributes.ToString());
}