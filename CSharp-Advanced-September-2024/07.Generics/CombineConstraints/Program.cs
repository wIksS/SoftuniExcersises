
using System.Collections;

GenericMethod<List<int>>();

void GenericMethod<T>()
    where T: IEnumerable, new()
{

}