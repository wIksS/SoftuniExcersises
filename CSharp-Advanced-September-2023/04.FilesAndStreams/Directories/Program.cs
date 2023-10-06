

for (int i = 0; i < 30; i++)
{
    //Directory.CreateDirectory($"../../../ComputerGenerated{i}");

    Directory.Move($"../../../ComputerGenerated{i}", $"../../../ComputerGenerated/ComputerGenerated{i}");
}
