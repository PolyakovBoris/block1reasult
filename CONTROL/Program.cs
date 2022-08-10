// 
int size = 4; int count = 0;
string [] array1 = new string [] {"1566", "asasa", "3", "asa"};
// подсчёт количества строк длина которых меньше или равна 3 символам 
for (int i = 0; i < size; i++)
{
    if (array1[i].Length<4) count++;    
}
// создание второго массива длина определенной длиною и заполнение его в соответствии с условиями задачи
string [] array2 = new string [count];
int count2 = 0;
for (int i = 0; i < size; i++)
{
    if (array1[i].Length<4) {array2[count2]=array1[i]; count2++;}   
}
System.Console.Write($"[");
for (int i = 0; i < size; i++)
{
    System.Console.Write(array1[i]);
    if (i<size-1) System.Console.Write(", ");    
}
System.Console.Write($"] -> [");
for (int i = 0; i < count2; i++)
{
    System.Console.Write(array2[i]);
    if (i<count2-1) System.Console.Write(", "); else System.Console.Write("]");
}