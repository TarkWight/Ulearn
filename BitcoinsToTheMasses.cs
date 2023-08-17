// https://ulearn.me/course/basicprogramming/Bitkoiny_v_massy__2b6e076c-4617-4322-9bde-c44a1d4f394f
public static void Main() 
{
    double amount = 1.11; //количество биткоинов от одного человека
    int peopleCount = 60; // количество человек
	int totalMoney = (int)Math.Round(amount * peopleCount);
    Console.WriteLine(totalMoney);
}
