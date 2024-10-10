
using System.Collections;

IEnumerator<string> enumerator = GetWeekDays();

//enumerator.MoveNext();
//Console.WriteLine(enumerator.Current);

//enumerator.MoveNext();
//Console.WriteLine(enumerator.Current);

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


IEnumerator<string> GetWeekDays()
{
    Console.WriteLine("Before first move next");

    yield return "Monday";

    Console.WriteLine("After first move next");

    yield return "Tuesday";

    Console.WriteLine("After second move next");

    yield return "Wednesday";

    Console.WriteLine("After third move next");
}


//class WeekDaysEnumerator : IEnumerator<string>
//{
//    public string Current => throw new NotImplementedException();

//    object IEnumerator.Current => throw new NotImplementedException();

//    public void Dispose()
//    {
//        throw new NotImplementedException();
//    }

//    public bool MoveNext()
//    {
//        throw new NotImplementedException();
//    }

//    public void Reset()
//    {
//        throw new NotImplementedException();
//    }
//}
