

Child child = new Child();

if (child is Parent && child is IParent)
{
    Console.WriteLine("Child is parent and IParent");
}

Parent parent = new Parent();

Child parentAsChild = (Child) parent;

Console.WriteLine();
interface IParent
{

}
class Parent : IParent
{

}

class Child : Parent
{

}