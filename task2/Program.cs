﻿static int ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return ackermann(m - 1, ackermann(m, n - 1));
    }
    return -1;
}
Console.Write(ackermann(0, 0));
// для проверки ипользовались данные из таблицы https://math.fandom.com/ru/wiki/Функция_Аккермана