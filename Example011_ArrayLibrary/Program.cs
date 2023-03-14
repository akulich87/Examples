void FillArray(int[] collection) // void - метод который ничего не возвращает, при данном методе мы не используем оператор return
{
 int length = collection.Length;
 int index = 0;
 while (index < length)
 {
 collection[index] = new Random().Next(1, 10);
 index++; // index = index + 1;
 }
}


void PrintArray(int[] col) // различные аргументы называем различными именами collection и col
{
 int count = col.Length;
 int position = 0;
 while (position < count)
 {
  Console.WriteLine(col[position]);
  position++;
 }

}

int IndexOf(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1; // искусстенный прием, если элемента нет значит будет -1

  while (index < count)
  {
    if(collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}

int[] array = new int[10]; // создай новый массив в котором будет 10 элементов

FillArray(array); //метод который заполняет массив
array[4] = 4; // принудительно добавили 4 на позицию 4
array[6] = 4; // принудительно добавили 4 на позицию 6
PrintArray(array); // метод который печатает массив
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
