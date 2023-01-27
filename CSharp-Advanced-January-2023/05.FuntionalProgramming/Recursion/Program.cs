
//int x = int.Parse(Console.ReadLine());
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Dimitrichko");
//}

//if (x % 2 ==0)
//{

//}
//else
//{

//}

PrintDimitrichko(10);

//static void PrintDimitrcihko(int 0)
//{
//}
static void PrintDimitrichko(int times)
{
    //if (times <= 0)
    //{
    //    return;
    //}

    Console.WriteLine("Dimitrichko");
    PrintDimitrichko(times - 1);
}