
new Child().Test(new int[] {1,2});
class Parent
{
    public int weight;
}

class Child : Parent
{
    public string weight = "test";

    public void Test(int[] weight)
    {

        Console.WriteLine(weight); // int[]
        Console.WriteLine(this.weight.GetType().Name); // string
        Console.WriteLine(base.weight); // int
    }
}