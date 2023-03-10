
Console.WriteLine(new Child().GetName());

class Parent
{
    public virtual string GetName()
    {
        return "Parent";
    }
}

class Child : Parent
{

    public override string GetName()
    {
        string baseName = base.GetName();
        return baseName;
    }
}