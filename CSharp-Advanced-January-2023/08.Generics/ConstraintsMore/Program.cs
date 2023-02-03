StreamReader reader = new StreamReader("");

reader.Dispose();

UseResource<StreamReader>(reader);
UseResource<CustomResource>(new CustomResource());

void UseResource<T>(T resource) where T : IDisposable
{
    using (resource)
    {

    }
    resource.Dispose();
}

class CustomResource : IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}