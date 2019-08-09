using System;

class MainClass {
  public static void Main (string[] args) {
    int[] arr1 = {4, 3, 9, 5};
    Console.Write("Input: ");
    Console.WriteLine(string.Join(",", arr1));
    Odometer(arr1,1);
    Console.Write("Output: ");
    Console.WriteLine(string.Join(",", arr1));
    Console.WriteLine("Expected: 4,3,9,6");
    Console.WriteLine("----");

    int[] arr2 = {4, 3, 4, 9};
    Console.Write("Input: ");
    Console.WriteLine(string.Join(",", arr2));
    Odometer(arr2,1);
    Console.Write("Output: ");
    Console.WriteLine(string.Join(",", arr2));
    Console.WriteLine("Expected: 4,3,5,0");
    Console.WriteLine("----");

    int[] arr3 = {9, 9, 9, 9};
    Console.Write("Input: ");
    Console.WriteLine(string.Join(",", arr3));
    Odometer(arr3,1);
    Console.Write("Output: ");
    Console.WriteLine(string.Join(",", arr3));
    Console.WriteLine("Expected: 1,0,0,0");
    Console.WriteLine("----");
  }

  public static void Odometer (int[] arr, int change) {
    int pos = arr.Length - 1;
    while (pos >= 0 && change != 0) {
      int sum = arr[pos] + change;
      change = (int) Math.Floor(sum / 10d);
      arr[pos] = BetterMod(sum, 10);
      pos--;
    }
    if (change == 1) {
      arr[0] = 1;
    }
  }

  public static int BetterMod(int a, int b) {
    int modded = a % b;
    if (b > 0 && modded < 0) {
      while (modded < 0) {
        modded += b;
      }
    }
    return modded;
  }
}