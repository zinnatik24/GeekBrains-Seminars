// ZaDACHA 39
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[size];

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(11);
// }

// Console.WriteLine($" Array: [{String.Join("; ", array)} ]");

// int [] result_array = new int[size];
// int lastIndex = size - 1;
// for (int i = 0; i < size; i++)
// {
//     result_array[i] = array[lastIndex - i];
// }
// Console.WriteLine($" Reverse Array: [{String.Join("; ", result_array)} ]");

//----------------------------------------------------------------
// another way to reserve with a help of methods

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return result;

// }

// Void ResersArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length/2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length -i -1];
//         inArray[inArray.Length -i -1] = k;
//     }
// }

// Void CopyArray(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length -1 - i];
//     }
//     return result;
// }
//--------------------------------------------------------------------------------------------------------------------------------
// ZADACHA 40

int [] Array = new int[3];

for (int i = 0; i < Array.Length; i++)
{
     Array[i] = new Random().Next(1,11);
}
if (Array[0]+Array[1]>Array[2] && Array[1]+Array[2]>Array[0] && Array[2]+Array[0]>Array[1]) Console.WriteLine($"Array: [{String.Join("; ", Array)} ], DA");
else Console.WriteLine($"Array: [{String.Join("; ", Array)} ], NET");