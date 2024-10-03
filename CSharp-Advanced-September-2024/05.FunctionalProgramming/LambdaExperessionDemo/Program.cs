
var isEven = (int n) => n % 2 == 0;
var isEven2 = (int n, int index) => n % 2 == 0;

var isEven3 = (int n, int index) =>
{
    Console.WriteLine($"Checking {n}%2={n % 2}");
    return n % 2 == 0;
};





bool IsEven(int n)
{
    Console.WriteLine($"Checking {n}%2={n % 2}");
    return n % 2 == 0;
}