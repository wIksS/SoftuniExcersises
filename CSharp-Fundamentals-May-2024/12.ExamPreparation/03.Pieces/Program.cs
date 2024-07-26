IRenderer console = new ConsoleRenderer();

Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

int n = int.Parse(Console.ReadLine());

//Fur Elise|Beethoven|A Minor
for (int i = 0; i < n; i++)
{
    string[] splittedInput = Console.ReadLine().Split("|");
    string piece = splittedInput[0];
    string composer = splittedInput[1];
    string key = splittedInput[2];

    Piece pieceObject = new Piece() { Composer = composer, Key = key };

    pieces.Add(piece, pieceObject);
}

string command = Console.ReadLine();

while (command != "Stop")
{
    string[] splitted = command.Split("|");

    if (splitted[0] == "Add")
    {
        string piece = splitted[1];
        string composer = splitted[2];
        string key = splitted[3];

        if (!pieces.ContainsKey(piece))
        {
            pieces.Add(piece, new Piece() { Composer = composer, Key = key });
            console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
        else
        {
            console.WriteLine($"{piece} is already in the collection!");
        }
    }
    if (splitted[0] == "Remove")
    {
        string piece = splitted[1];

        if (pieces.Remove(piece))
        {
            console.WriteLine($"Successfully removed {piece}!");
            //pieces = new Dictionary<string, Piece>(pieces);
        }
        else
        {
            console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
    if (splitted[0] == "ChangeKey")
    {
        string piece = splitted[1];
        string newKey = splitted[2];

        if (pieces.ContainsKey(piece))
        {
            Piece currentPiece = pieces[piece];

            currentPiece.Key = newKey;
            console.WriteLine($"Changed the key of {piece} to {newKey}!");
        }
        else
        {
            console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }

    command = Console.ReadLine();
}


foreach (var (piece, pieceObject) in pieces)
{
    console.WriteLine($"{piece} -> Composer: {pieceObject.Composer}, Key: {pieceObject.Key}");
}


class Piece
{
    public string Composer { get; set; }

    public string Key { get; set; }
}




public interface IRenderer
{
    void WriteLine(string message);
    void Write(string message);
}
public class TextRenderer : IRenderer
{
    string path = "../../../output.txt";

    public TextRenderer()
    {
        File.Delete(path);
    }

    public void Write(string message)
    {
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.Write(message);
        }
    }

    public void WriteLine(string message)
    {
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(message);
        }
    }
}
internal class ConsoleRenderer : IRenderer
{
    public void Write(string message)
    {
        Console.Write(message);
    }

    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}