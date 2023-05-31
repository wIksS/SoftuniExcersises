

string folder = @"../../../";//Console.ReadLine();

Console.WriteLine($"{FolderSize(new DirectoryInfo(folder), 0) / 1024.0 / 1024.0} mb");

//Console.WriteLine(new DirectoryInfo(folder).GetFiles("*", SearchOption.AllDirectories);

long FolderSize(DirectoryInfo folder, int level)
{
    Console.WriteLine($"{new string(' ', level * 3)}{folder.Name}");
    long bytes = 0;

    FileInfo[] files = folder.GetFiles();

    foreach (var file in files)
    {
        
        bytes += file.Length;
        //Console.WriteLine($"{new string(' ', level * 3)}{file.Name}");

    }

    DirectoryInfo[] subDirs = folder.GetDirectories();    

    foreach (var subDir in subDirs)
    {
        bytes += FolderSize(new DirectoryInfo(subDir.FullName), level + 1);
    }

    return bytes;
}