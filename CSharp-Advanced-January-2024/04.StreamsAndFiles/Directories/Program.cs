

//Directory.CreateDirectory("../../../SecondFolder");

//for (int i = 0; i < 100; i++)
//{
//    Directory.CreateDirectory($"../../../GeneratedFolder/{i}Folder");

//}

//string[] subDirs = Directory.GetDirectories("../../../SecondFolder");


//foreach (string subDir in subDirs)
//{
//    Directory.Delete(subDir);
//    //Directory.Move(subDir, subDir.Replace("GeneratedFolder", "SecondFolder"));
//}
//Console.WriteLine(string.Join("\n", subDirs));


string[] files = Directory.GetFiles(@"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-Advanced-January-2024\04.StreamsAndFiles\04.EncryptFiles\Images");

foreach (var filePath in files)
{
    FileInfo fileInfo = new FileInfo(filePath);
    Console.WriteLine(fileInfo.FullName);
    Console.WriteLine(fileInfo.Extension);
    Console.WriteLine(fileInfo.Length);
    Console.WriteLine(filePath);
}