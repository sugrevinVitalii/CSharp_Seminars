﻿// 31 Задача.
// Создать массив из восьми чисел и вывести на экран.

//int[] a=new int[8]{0,1,2,3,4,5,6,7,8,9}; //команда создания массива целых чисел из 10 элементов.
//int[] a={0,1,2,3,4,5,6,7,8,9}; //запись короче.

//System.Console.WriteLine(a[0]); //вывести нулевой элемент массива.
//System.Console.WriteLine(a[9]); //вывести девятый элемент массива.

double[] a=new double[8]; //команда создания массива из 8 элементов.

for(int i=0;i<a.Length;i++)
    a[i]=new Random().Next(0,100);//создание нового массива с 8 числами от 0 до 100

for(int i=0;i<a.Length;i++) //Стандартная конструкция по работе с массивами.
    System.Console.Write($"{a[i]} ");
