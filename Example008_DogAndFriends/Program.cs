Console.Write("Введите расстояние между друзьями (км): ");
string tdistance = Console.ReadLine();
double distance = Convert.ToInt32(tdistance);
//int distance = 10000;
Console.Write("Введите скорость первого друга (км/ч): ");
string tFirstFriendSpeed = Console.ReadLine();
double FirstFriendSpeed = Convert.ToInt32(tFirstFriendSpeed);
//int FirstFriendSpeed = 1;
Console.Write("Введите скорость второго друга (км/ч): ");
string tSecondFriendSpeed = Console.ReadLine();
double SecondFriendSpeed = Convert.ToInt32(tSecondFriendSpeed);
//int SecondFriendSpeed = 2;
Console.Write("Введите скорость собаки (км/ч): ");
string tdogSpeed = Console.ReadLine();
double dogSpeed = Convert.ToInt32(tdogSpeed);
//int dogSpeed = 5;

int count = 0;
double time;
int friend = 1;
//bool friend = false;
while (distance > 0.01)
{
    //if (friend == false)
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + dogSpeed);
        //friend = true;
        friend = 2;
    }
    else
    {
        time = distance / (SecondFriendSpeed + dogSpeed);
        //friend = false;
        friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз.");