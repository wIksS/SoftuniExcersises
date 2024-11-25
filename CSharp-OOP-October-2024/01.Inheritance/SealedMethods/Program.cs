


class A
{
    public virtual void Method()
    {

    }
}

class B : A
{
    public sealed override void Method()
    {
        base.Method();
    }
}

class C : B
{
    public override void Method()
    {

    }
}