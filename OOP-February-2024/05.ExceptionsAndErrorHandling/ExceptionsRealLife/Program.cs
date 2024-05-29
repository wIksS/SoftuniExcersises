

using ExceptionsRealLife;

Student student = new StudentDataReader().ReadStudent();

try
{
    Student student2 = new Student();

    student.Age = -2;
}
catch (Exception ex)
{

    throw ex;
}
