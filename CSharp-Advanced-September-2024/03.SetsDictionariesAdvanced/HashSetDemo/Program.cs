

HashSet<string> loggedInUsersTokens = new HashSet<string>();

loggedInUsersTokens.Add("viktor-token");

loggedInUsersTokens.Add("gosho-token");

loggedInUsersTokens.Add("Soner Balikci-token");

Console.WriteLine(IsLoggedIn("viktor-token"));

Console.WriteLine(IsLoggedIn("Soner Balikci-token"));

Console.WriteLine(IsLoggedIn("niki-token"));



bool IsLoggedIn(string token)
{
    return loggedInUsersTokens.Contains(token);
}