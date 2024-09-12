  int N = 115;
  int NumLength = (int)Math.Floor(Math.Log10(N)) + 1;
  int NumRank = (int)Math.Pow(10, NumLength - 1);
  int Result = 0;
  while (N > 0)
  {
    int Reduction = N % 10;
    N /= 10;
    Result += Reduction * NumRank;
    NumRank /= 10;
  }
  Console.WriteLine(Result);
