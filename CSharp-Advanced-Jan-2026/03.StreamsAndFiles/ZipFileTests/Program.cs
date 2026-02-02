using System.IO.Compression;

string zipPath = @"../../../test.zip";
string extractPath = @"../../../Extracted";

using (ZipArchive zip = ZipFile.Open(zipPath, ZipArchiveMode.Update))
{
    zip.CreateEntryFromFile("../../../copyMe.png", "copyMe.png");

    //zip.ExtractToDirectory(extractPath);
}

using (ZipArchive zip = ZipFile.Open(zipPath, ZipArchiveMode.Read))
{
    if (File.Exists(extractPath))
    {
        Console.WriteLine("Exists!");
        return;
    }

    zip.ExtractToDirectory(extractPath);
}
