// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string [] VvodMassiva (int RazmerMassiva)
{
string[] Massiv = new string [RazmerMassiva];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < RazmerMassiva ; i++ )
    {
        Massiv[i] =  Console.ReadLine();
    }
return Massiv;
}
void VivodMassiva (string[] Massiv,int RazmerMassiva)
{
for (int i = 0; i < RazmerMassiva ; i++ )
    {
        Console.Write("{0}, ",Massiv[i]);
    }
}
Console.WriteLine("Введите количество элементов в массиве");
int RazmerMassiva = Convert.ToInt32(Console.ReadLine());
string[] IshodniiMassiv = new string [RazmerMassiva];
IshodniiMassiv = VvodMassiva(RazmerMassiva);
VivodMassiva(IshodniiMassiv,RazmerMassiva);