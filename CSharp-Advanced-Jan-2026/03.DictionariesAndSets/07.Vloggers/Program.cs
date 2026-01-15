

Dictionary<string, List<string>> influencers = new Dictionary<string, List<string>>();
Dictionary<string, List<string>> following = new Dictionary<string, List<string>>(); 

string input = Console.ReadLine();    

while (input != "Statistics")
{
    // A followed B
    // A joined B
    string[] split = input.Split();

    string firstInfluencer = split[0];
    string secondInfluencer = split[2];
    string command = split[1];

    if (command == "joined")
    {
        if (!influencers.ContainsKey(firstInfluencer))
        {
            influencers.Add(firstInfluencer, new List<string>());
            following.Add(firstInfluencer, new List<string>());
        }
    }
    if (command == "followed")
    {
        if (influencers.ContainsKey(firstInfluencer) && influencers.ContainsKey(secondInfluencer))
        {
            if (firstInfluencer != secondInfluencer 
                && !influencers[secondInfluencer].Contains(firstInfluencer))
            {
                influencers[secondInfluencer].Add(firstInfluencer);
                following[firstInfluencer].Add(secondInfluencer);
            }
        }
    }

    input = Console.ReadLine(); 
}

influencers = influencers.OrderByDescending(influencer => influencer.Value.Count)
    .ThenBy(influencer => following[influencer.Key].Count)
    .ToDictionary(item => item.Key, item => item.Value);

Console.WriteLine($"The V-Logger has a total of {influencers.Count} vloggers in its logs.");
int index = 1;
bool isMostInfluential = true;
foreach (var (influencer, followers) in influencers)
{
    Console.WriteLine($"{index++}. {influencer} : {followers.Count} followers, {following[influencer].Count} following");

    if (!isMostInfluential)
    {
        continue;
    }

    isMostInfluential = false;

    string[] sortedFollowers = followers.OrderBy(follower => follower).ToArray();

    foreach (var follower in sortedFollowers)
    {
        Console.WriteLine($"*  {follower}");
    }
}
