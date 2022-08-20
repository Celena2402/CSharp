//
void FillArray(int[] collection)  // создает массив. Voit - метод ничего не возвращает
{
    int length = collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }

}
void PrintArray(int[] col)   // печатает-заполняет массив
{
    int count=col.Length;
    int position=-1;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count=collection.Length;
    int index=0;
    int position=0;

    while (index<count)
    {
        if(collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}

int [] array=new int[10]; // создает новый массив в котором 10 элеменов

FillArray(array);
array[4]=4;
array[6]=4;
PrintArray(array);
Console.WriteLine();

int pos=IndexOf(array,4);
Console.WriteLine(pos);