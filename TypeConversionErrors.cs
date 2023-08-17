// https://ulearn.me/course/basicprogramming/Oshibki_preobrazovaniya_tipov_04d61c06-8a32-41a6-a47e-2ae2d095def3

public static void Main()
{
    double PI = Math.PI;
    int tenThousand = 10000;
    double tenThousandPi = PI * (double)tenThousand;
    int roundedTenThousandPi = (int)Math.Ceiling(tenThousandPi);
    int integerPartOfTenThousandPi = (int)tenThousandPi;
    Console.WriteLine(integerPartOfTenThousandPi);
    Console.WriteLine(roundedTenThousandPi);
}
