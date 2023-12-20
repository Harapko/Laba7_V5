using Laba7_V5;

TFraction fraction = new TFraction(2,4);
fraction.Expanse(2);
fraction.Reduction(4);
Console.WriteLine(fraction);

Console.Write("Press any key...");
Console.ReadKey();
Console.Clear();

TRectangle rectangle = new TRectangle(1,2,3,4,5, 6);
rectangle[0] = 10;
rectangle[1] = 5;
Console.WriteLine(rectangle[1]);
Console.WriteLine(rectangle);