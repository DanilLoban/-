// See https://aka.ms/new-console-template for more information
string[] array1 = new string[7] { "Sunday", "Mon", "Tuesday", "We", "Thursday", "F", "Saturday" };
string[] array2 = new string[array1.Length];
void StringArray(string[] array1, string[] array2)
{
    int count = 0;
    for(int i =0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
StringArray(array1, array2);
PrintArray(array2);