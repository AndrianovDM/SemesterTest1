# Итоговая проверочная работа

## Условие задачи

_Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами_

## Описание методов программы
Программа содержит 3 метода:

*  _**PrintArray**_ типа _void_: на вход принимает массив типа  _string_ и выводит его на экран.

*  _**CreateArray**_ типа _string_: на вход принимает размер массива и возвращает массив, переменные которого вводятся с консоли пользователем.

*  _**modifiedArray**_ типа _void_: данный метод на вход принимает созданный раннее массив и формирует новый, исходя из условий задачи.

## Описание алгоритма программы

Изначально пользователь формирует массив, основное решение задачи находится в методе _**modifiedArray**_, в котором на основании заданного массива, формируется еще один такой же длины **arrMod**, запускается счетчик подсчета элементов массива которые меньше либо равны "3-м" символам, запускается цикл на основе длины заданного массива, который проходит по всем ячейкам, проверяется условие, в случае его выполнения. Элемент заносится в **arrMod**. После присвоения увеличивается переменная count на +1 и возвращается к циклу for в котором i увеличивается на 1. 

Результате работы программы выводятся в консоль.





