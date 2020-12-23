using System;

  

public class GFG {

  

    static int NO_OF_CHARS = 256;

  

    / * функция для проверки наличия двух строк

    являются анаграммами друг друга * /

    static bool areAnagram(char[] str1, char[] str2)

    {

        // Создаем 2 массива и инициализируем

        // все значения как 0

        int[] count1 = new int[NO_OF_CHARS];

        int[] count2 = new int[NO_OF_CHARS];

        int i;

  

        // Для каждого символа во входных строках,

        // увеличиваем счетчик в соответствующем

        // подсчитать массив

        for (i = 0; i < str1.Length && i < str2.Length;

             i++) {

            count1[str1[i]]++;

            count2[str2[i]]++;

        }

  

        // Если обе строки имеют разную длину.

        // Удаление этого условия сделает программу

        // сбой для строк типа "aaca" и "aca"

        if (str1.Length != str2.Length)

            return false;