
GrandChild grandChild;


Parent parent = new Parent();
parent = new Child();
parent = new GrandChild();

class Parent
{

    public int ParentProp { get; set; }
}

class Child : Parent
{
    public int ChildProp { get; set; }
}

class GrandChild : Child
{
    public int GrandChildProp { get; set; }

    public void Test()
    {

    }
}