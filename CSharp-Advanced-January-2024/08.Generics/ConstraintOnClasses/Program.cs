
University<FinishedStudent> students;
University<SoftUniStudent> students2;
University<StudentWannaBeStudent> students23;
class University<T> where T : Student
{
    public void AddStudents<V>() where V : T
    {

    }
}

class Student
{
    public Student()
    {

    }
}

class FinishedStudent : Student
{

}

class SoftUniStudent : Student
{

}

class StudentWannaBeStudent : Student
{

}