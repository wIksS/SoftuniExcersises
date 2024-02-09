

object obj = 5;

obj = DateTime.Now;

obj = "hello";

SayHello("hello");
SayHello(5);

Hello("hello");
Hello(5);

void Hello(object obj)
{
    Console.WriteLine(obj);
}


void SayHello<T>(T message)
{
    Console.WriteLine(message);
}

