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

  //double HourArr = 6;
  //double MinArr = 60;
  //if (MinArr > 60) MinArr = 60;
  //if (HourArr > 12) HourArr = 12;
  //double Distance = 360 / 12;
  //double AngleBetween = Math.Abs(HourArr - MinArr / 5) * Distance;
  //Console.WriteLine(AngleBetween);
