Product product = new Product();

product.SetName("Teniska");
product.SetModel("Slim Fit");

Console.WriteLine(product.GetFullName());

class Product
{
    private string name;

    public string GetFullName()
    {
        return $"{GetName()} {GetModel()}";
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        if (value.Length < 2)
        {
            throw new ArgumentException("Nqma ime s edin simvol????");
        }

        name = value;
    }

    private string model;

    public string GetModel()
    {
        return model;
    }

    public void SetModel(string value)
    {
        model = value;  
    }
}