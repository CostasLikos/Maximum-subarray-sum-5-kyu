using System;

public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
    int res = 0;
    for (int i = 0, x = 0; i < arr.Length; i++)
    {
      x += arr[i];
      x = Math.Max(x, 0);
      res = Math.Max(res, x);
    }
    return res;
  }
}
