﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

        int[] array = new int[8];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент массива под индексом {i}: ");
            array[i] = int.Parse(Console.ReadLine()!);

        }
        Console.Write($"Вывод массива: ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }