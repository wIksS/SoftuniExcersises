
StreamReader reader = new StreamReader("");

SafelyCloseStream<StreamReader>(reader);
SafelyCloseStream<FileStream>(null);

void SafelyCloseStream<T>(T stream) where T: IDisposable
{
    stream.Dispose();
}