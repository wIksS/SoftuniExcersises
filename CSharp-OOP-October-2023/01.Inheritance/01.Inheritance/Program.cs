

using _01.Inheritance;

new TechnicalWriter() { Name="Tech writer"}.Print();

Programmer programmer = new Programmer();

programmer.Name = "Pesho";
programmer.Print();
Console.WriteLine(programmer.Name);

HR hr = new HR();

hr.Print();
hr.NationalId = "42092278";

Console.WriteLine(hr.IsNationalIdValid());