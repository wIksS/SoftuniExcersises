decimal one = 0;
for (int i = 0; i < 10000; i++) one += 0.0001m;
Console.WriteLine(one);


Console.WriteLine(100000000000000.0f + 0.3f);
// 100000000000000 (loss of precision)
decimal a = 1.0m, b = 0.33m, sum = 1.33m;
Console.WriteLine("a+b={0} sum={1} equal={2}",
 a + b, sum, (a + b == sum));
// a+b = 1.33000001311302 sum=1.33 equal = False