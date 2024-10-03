
using System.Text;

CustomClass<int> custom;
CustomClass<StringBuilder> custom1;
CustomClass<DateTime> custom2;
CustomClass<StreamReader> custom3;

class CustomClass<T> where T : struct
{

}