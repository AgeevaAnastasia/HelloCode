// Вид 1. Ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Агеева Анастасия"); // метод просто каждый раз печатает, например, имя автора. Или что-то подобное
}
Method1(); //это вызов этого метода () - обязательны!! 



// Вид 2. Что-то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); // вызов этого метода. В скобках именно то сообщение, которое положится в аргумент msg (и он же распечатается)
// msg: явно указывает, какому именно аргументу присвоить данный текст. Полезно, когда их несколько

void Method21(string msg, int count, string msg1)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    Console.WriteLine(msg1);
}
Method21(msg1: "Текст", msg: "Like", count: 4); // указываем, сколько раз хотим увидеть сообщение


// Вид 3. Ничего не принимают, что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// Вид 4. Что-то принимают, что-то возвращают
// string Method4(int count, string text) // char - условный тип данных
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text) // char - условный тип данных
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(5, "asdf");
Console.WriteLine(res);