
Random random = new Random();
int[] array = Enumerable.Range(0, 1000).ToArray();


for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * 5;
}

for (int i = 0; i < array.Length; i++)
{
    array[i] += random.Next(0, 10000);
}

for (int i = 0; i < array.Length; i++)
{
    array[i] /= 5;
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * 5;
}

for (int i = 0; i < array.Length; i++)
{
    array[i] += random.Next(0, 10000);
}

for (int i = 0; i < array.Length; i++)
{
    array[i] /= 5;
}