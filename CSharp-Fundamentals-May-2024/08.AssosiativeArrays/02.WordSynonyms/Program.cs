

Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!wordSynonyms.ContainsKey(word))
    {
        wordSynonyms.Add(word, new List<string>());
    }

    wordSynonyms[word].Add(synonym);
}

foreach (var wordSynonym in wordSynonyms)
{
    Console.WriteLine($"{wordSynonym.Key} - {String.Join(", ", wordSynonym.Value)}");

}



//List<string> synonyms = wordSynonym.Value;
//foreach (var synonym in synonyms)
//{
//    Console.Write(synonym + ", ");
//}

//Console.WriteLine();
//wordSynonyms.Add("gotin", new List<string>());

//wordSynonyms["gotin"].Add("simpatichen");
//wordSynonyms["gotin"].Add("priqten");
//wordSynonyms["gotin"].Add("mnogo gotin");
//wordSynonyms["gotin"].Add("nai gotin");

//wordSynonyms.Add("umen", new List<string>());

//wordSynonyms["umen"].Add("inteligenten");
//wordSynonyms["umen"].Add("nacheten");