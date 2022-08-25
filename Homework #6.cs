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

// int [] Array = new int[3];

// for (int i = 0; i < Array.Length; i++)
// {
//      Array[i] = new Random().Next(1,11);
// }
// if (Array[0]+Array[1]>Array[2] && Array[1]+Array[2]>Array[0] && Array[2]+Array[0]>Array[1]) Console.WriteLine($"Array: [{String.Join("; ", Array)} ], DA");
// else Console.WriteLine($"Array: [{String.Join("; ", Array)} ], NET");
//--------------------------------------------------------------------------------------------------------------------------------
// int[] fibonnachi = new int[20];
// fibonnachi[0] = 0;
// fibonnachi[1] = 1;
// for (int i = 0; i < fibonnachi.Length-2; i++)
// {
//     fibonnachi[2+i] = fibonnachi[i]+fibonnachi[i+1];
// }
// Console.WriteLine($"Array: [{String.Join("; ", fibonnachi)} ]");
//--------------------------------------------------------------------------------------------------------------------------------
// !!!HOMEWOOOOOOOOOOOORK!!!
// ZADACHA 41

// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// int count = 0;
// for (int i = 0; i < N; i++)
// {
//     array[i] = new Random().Next(-3,4);
//     if (array[i]>0) count++;
// }
// Console.WriteLine($"Array: [{String.Join("; ", array)}] positive numbers: {count}");
//--------------------------------------------------------------------------------------------------------------------------------
// ZADACHA 43
// int[] line1 = new int[2];
// int[] line2 = new int[2];
// for (int i = 0; i < 2; i++)
// {
//     line1[i] = new Random().Next(-3,4);
//     line2[i] = new Random().Next(-3,4);
// }
// int x = (line2[1]-line1[1])/(line1[1]-line1[0]);
// int y = (line1[0]*x + line1[1]);
// Console.WriteLine($"Array: [{String.Join("; ", line1)}], [{String.Join("; ", line2)}] X: {x}, Y: {y}");
//--------------------------------------------------------------------------------------------------------------------------------
// DOP ZADACHA
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[10];

// public int transfromed(int n)
// {
//     if (n/2%2 == 0) return array[i]=0;
//     if (n/2%2 == 1) return array[i]=1;
//     else return transfromed(n/2);
// }
// Console.WriteLine($"Array: [{String.Join("; ", array)}]");