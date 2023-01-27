Predicate<int> predicate = FilterByAge;
Func<int, bool> funcPredicate = FilterByAge;
Filter filter = FilterByAge;

bool FilterByAge(int age)
{
    if (age < 21)
    {
        return false;
    }

    return true;
}

delegate bool Filter(int input);