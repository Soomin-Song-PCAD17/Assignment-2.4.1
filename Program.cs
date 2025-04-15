/// 1. Write a program in C# Sharp to find the sum of all array elements.
/// Test Data :
/// Input the number of elements to be stored in the array :3
/// Input 3 elements in the array :
/// element - 0 : 2
/// element - 1 : 5
/// element - 2 : 8
/// Expected Output :
/// Sum of all elements stored in the array is : 15

Console.Write("Input the number of elements to be stored in the array : ");
double[] array = new double[Convert.ToInt32(Console.ReadLine())];
double sum = 0;
for(int i=0;i<array.Length;i++) {
    Console.Write($"element - {i} : ");
    array[i] = Convert.ToDouble(Console.ReadLine());
    sum += array[i];
}

Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
