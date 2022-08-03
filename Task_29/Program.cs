//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] GenerateArray(int[] genArray)
{
  int length = genArray.Length;
  int index = 0;
  while(index < length)
  {
    genArray[index] = new Random().Next(1, 100);
    index++;
  }
  return genArray;
}

void PrintArray(int[] arrayPrint)
{
  int lengthArray = arrayPrint.Length;
  int position = 0;
  while(position < lengthArray)
  {
    System.Console.Write(arrayPrint[position] + ", ");
    position++;
  }
}


PrintArray(GenerateArray(8));



/*
int[] GenerateArray(int arg1, int arg2)
{
  int [] genArray;
  int length = genArray.Length;
  int index = 0;
  while(index < length)
  {
    genArray[index] = new Random().Next(arg1, arg2);
    index++;
  }
  return genArray;
}


void PrintArray(int[] arrayPrint)
{
  int lengthArray = arrayPrint.Length;
  int position = 0;
  while(position < lengthArray)
  {
    System.Console.Write(arrayPrint[position] + ", ");
    position++;
  }
}

//int[] myMassiv = new int[8];


PrintArray(GenerateArray(1, 9));
*/