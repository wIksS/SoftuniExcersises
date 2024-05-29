

Type type = typeof(DateTime);
DateTime time = (DateTime) Activator.CreateInstance(type, new object[] {2005,10,25});

Console.WriteLine(time);