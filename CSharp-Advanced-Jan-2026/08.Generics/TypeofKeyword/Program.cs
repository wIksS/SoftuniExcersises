

//Type typeofData = typeof(int);

//Console.WriteLine(typeofData.Name);
//Console.WriteLine(typeofData.FullName);
//Console.WriteLine(typeofData.Assembly);

using System.Text;

PrintGenericData<String>();
PrintGenericData<DateTime>();
PrintGenericData<StringBuilder>();
PrintGenericData<StreamReader>();

void PrintGenericData<T>()
{
    Console.WriteLine("------- Print type data: ");
    Type type = typeof(T);
    Console.WriteLine(typeof(T).Name);
    Console.WriteLine(type.FullName);
}