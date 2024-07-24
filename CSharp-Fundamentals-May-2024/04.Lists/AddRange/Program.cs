
List<int> firstList = new List<int>(){ 1, 2, 3 };

int[] array = new int[] { 4, 5 };
List<int> list = new List<int>();

list.AddRange(firstList);
list.AddRange(array);
list.AddRange(new List<int> { 6,7,8});

Console.WriteLine();