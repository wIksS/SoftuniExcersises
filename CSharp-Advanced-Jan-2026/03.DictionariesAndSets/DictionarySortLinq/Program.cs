

//Dictionary<int, int> dictionary = new Dictionary<int, int>()
//{
//    {5,6 }, {7,8}, {9,10},  {12,13},
//    {3,2 }, {1,10},{11,12},{15, 10}, {-5,10},{100,10}
//};

Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>()
{
    { "pesho", [2,4,6]},
    { "gosho", [6,5,6]},
    { "ivan", [2,3,2]},
};

dictionary = dictionary.OrderByDescending(item => item.Value.Average())
    .ThenBy(item => item.Key)
    .ToDictionary(item=>item.Key, item => item.Value);

foreach (var (key, value) in dictionary)
{
    Console.WriteLine($"{key} - { value.Average()}");
}
