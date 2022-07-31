Console.Clear();
Console.WriteLine("Выберите: камень, ножницы или бумага?");
string userText = Console.ReadLine();
string user = String.Empty;

string Enter(string userText1)
{
    if (userText1 == "к" || userText == "камень")
    {
        return "камень";
    }
    else if (userText1 == "н" || userText == "ножницы")
    {
        return "ножницы";
    }
    else if (userText1 == "б" || userText == "бумага")
    {
        return "бумага";    
    }
    else 
    {
        Console.WriteLine("Вы ввели неверное значение!");
        throw new ArgumentException("Вы ввели неверное значение");
    }
}

user = Enter(userText);
int comp = new Random().Next(0, 3);
int count = 0;
string compText = String.Empty;

string CompText(int comp1)
{
    if (comp1 == 0)
    {
        compText = "камень";
    }
    else if (comp1 == 1)
    {
        compText = "ножницы";
    }
    else 
    {
        compText = "бумага";
    }
    return compText; 
}

int Win(string user1)
{
    if (user1 == "камень")
    {
        if (comp == 1)
        {
            count = count - 1;
        }
        if (comp == 2)
        {
            count = count + 1;
        }
    }

    else if (user1 == "ножницы")
    {
        if (comp == 2)
        {
           count = count - 1;
        }
        if (comp == 0)
        {
            count = count + 1;
        }
    }

    else
    {
        if (comp == 0)
        {
            count = count - 1;
        }
        if (comp == 1)
        {
            count = count + 1;
        }
    }
    return count;
}

void SetResult(int count1)
{
    if (count1 < 0)
    {
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine($"ПОЗДРАВЛЯЕМ! ВЫ ВЫИГРАЛИ! Вы выбрали {user}, а компьютер - {compText}.");
        Console.WriteLine("-------------------------------------------------------------------");
    }
    else if (count1 > 0)
    {
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($"Увы, вы проиграли! Вы выбрали {user}, а компьютер - {compText}.");
        Console.WriteLine("------------------------------------------------------------");
    }
    else 
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"У вас ничья! Вы выбрали {user}, а компьютер - {compText}.");
        Console.WriteLine("------------------------------------------------------");
    }
}


int win = Win(user);
string compText1 = CompText(comp);
SetResult(count);
int gameCount = count;

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Второй тур! Выберите: камень, ножницы или бумага?");
userText = Console.ReadLine();
user = Enter(userText);
comp = new Random().Next(0, 3);
count = 0;
compText = String.Empty;

int win1 = Win(user);
string compText11 = CompText(comp);
SetResult(count);
gameCount = gameCount + count;
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Третий тур, финальный! Выберите: камень, ножницы или бумага?");
userText = Console.ReadLine();
user = Enter(userText);
comp = new Random().Next(0, 3);
count = 0;
compText = String.Empty;


int win2 = Win(user);
string compText12 = CompText(comp);
SetResult(count);
gameCount = gameCount + count;

Console.WriteLine();
Console.WriteLine();
void GameResult(int gameCount1)
{
    if (gameCount < 0)
    {
        Console.WriteLine("||=================================================||");
        Console.WriteLine("||ВЫ ПОБЕДИЛИ В ИГРЕ ПОСЛЕ ТРЁХ ТУРОВ. ПОЗДРАВЛЯЕМ!||");
        Console.WriteLine("||=================================================||");
    }
    else if (gameCount > 0)
    {
        Console.WriteLine("||=======================================||");
        Console.WriteLine("||Вы програли в игре после трёх туров ;-(||");
        Console.WriteLine("||=======================================||");
    }
    else
    {
        Console.WriteLine("||======================================================||");
        Console.WriteLine("||После трёх туров у вас ничья. Можно сыграть еще раз ;)||"); 
        Console.WriteLine("||======================================================||");
    }
}

GameResult(gameCount);



