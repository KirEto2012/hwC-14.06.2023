/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите числа с запятой");
int[] array = StringToArray(Console.ReadLine());

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"чисел больше нуля = {sum}");

int[] StringToArray(string input)
{
    int count = 1;
    for (var i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] num = new int [count];
    int index = 0;

    for (var i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        num[index] = Convert.ToInt32(temp);
        index++;
    }
    return num;

}