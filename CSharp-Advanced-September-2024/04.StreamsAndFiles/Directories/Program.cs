

//Directory.Move("../../../Moqta", "../../Moqta");

string[] filePaths = Directory.GetFiles(".");

//foreach (string filePath in filePaths)
//{
//    FileInfo fileInfo = new FileInfo(filePath);

//    Console.WriteLine(fileInfo.FullName);
//    Console.WriteLine(fileInfo.Extension);
//    Console.WriteLine(fileInfo.Length);
//    Console.WriteLine(fileInfo.CreationTimeUtc);
//    Console.WriteLine(fileInfo.LastWriteTimeUtc);
//    Console.WriteLine(filePath);
//}

string[] dirPaths = Directory.GetDirectories("../../../../../../");


foreach (string dirPath in dirPaths)
{
    Console.WriteLine(dirPath);
}