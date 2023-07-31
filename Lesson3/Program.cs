// Типы методов
// Ничего не возвращают и ничего не принимают, пустой аргумент, название Void, тело метода
void Method1() 
{
    Console.WriteLine("Просто показывает текст.");
}
Method1();

// Методы 2. Ничего не возвращают, но принимают аргументы. Void, идентификатор, какое-то количетво аргументов. 
// Можно при выводе метода указать, какому аргументу и какое значение придать.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Метод21", 5);
Method21(msg: "Еще один способ", count: 5);

// Методы, которые что-то возвращают, но ничего не принимают.
// Обязательно указать тип данных, который мы ожидаем, аргументы он не принимает.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Методы, которые принимают и возвращают.
String Method4 (int count, string c)
{
int i = 0;
string result = String.Empty;
while(i < count)
{
    result = result + c;
    i++;
}
return result;
}
string res = Method4(10, "Прив");
Console.WriteLine(res);