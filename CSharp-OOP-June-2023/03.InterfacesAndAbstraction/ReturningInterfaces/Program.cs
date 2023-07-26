

IEnumerable<int> list = Method();

List<int> list2 = Method().ToList();

IEnumerable<int> Method()
{
    return new List<int>();
}