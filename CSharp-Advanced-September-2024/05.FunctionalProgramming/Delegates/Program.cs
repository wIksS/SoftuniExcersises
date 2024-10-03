
NumberFilter isEvenFunc = IsEven;
NumberFilter isBiggerThan10 = n => n > 10;
StrangeDelegate test = StrangeMethod;




bool IsEven(int n)
{
    return n % 2 == 0;
}

List<List<DateTime>> StrangeMethod(Dictionary<int, DateTime> test)
{
    return null;
}

delegate bool NumberFilter(int n);

delegate List<List<DateTime>> StrangeDelegate(Dictionary<int, DateTime> another);
