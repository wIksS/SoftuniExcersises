

Type listType = typeof(Test);
Type[] interfaces = listType.GetInterfaces();

foreach (Type interfaceInstance in interfaces)
{
    Console.WriteLine(interfaceInstance.Name);
    //Console.WriteLine(interfaceInstance.IsGenericType);
}


interface ITest<T,T1,T2>
{

}
class Test : ITest<int,int,int>
{

}