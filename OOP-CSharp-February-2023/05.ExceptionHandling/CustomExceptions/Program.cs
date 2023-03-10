
using CustomExceptions.Exceptions;


try
{
    CreateStudent();
}
catch (StudentException ex)
{
    Console.WriteLine(ex.Message);
    throw;
}

Student CreateStudent()
{
    Student student = new Student();
    try
    {
        student.AverageScore = 8;
    }
    catch (RangeException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine($"From: {ex.From}");
        Console.WriteLine($"To: {ex.To}");

        throw new StudentException("Student was not created correctly", ex);
    }

    return student;
}



class Student
{
    private double averageScore;

    public double AverageScore
    {
        get { return averageScore; }
        set
        {
            if (value < 2 || value > 6)
            {
                throw new RangeException(2,6);
            }

            throw new ArgumentException(ExceptionMessages.RangeErrorMessage);
            averageScore = value;
        }
    }

}