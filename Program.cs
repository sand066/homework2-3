using System;

class Program
{
  static void Main(string[] args)
  {
    string numOp;

    do
    {
      numOp = Console.ReadLine();
      if (numOp == "+" || numOp == "-")
      {

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        float[,] num = new float[n, m];
        float[,] num2 = new float[n, m];

        for ( int i = 0; i < n; i++) 
        {
          for (int j = 0; j < m; j++)
          {
            num[i, j] = float.Parse(Console.ReadLine());
          }
        }

        for (int i = 0; i < n; i++) 
        {
          for (int j = 0; j < m; j++)
          {
            num2[i, j] = float.Parse(Console.ReadLine());
          }
        }

        for (int i = 0; i < n; i++) 
        {
          for (int j = 0; j < m; j++)
          {
             switch (numOp)
            {
              case "+":
                num[i, j] = num[i, j] + num2[i, j];
                break;
              case "-":
                num[i, j] = num[i, j] - num2[i, j];
                break;
            }
          }
        }
         for (int i = 0; i < n; i++) 
        {
          for (int j = 0; j < m; j++)
          {
            Console.Write("{0} ", num[i, j]);
          }
          Console.WriteLine("");
        }
      }

    } while (numOp == "+" || numOp == "-");

  }

}