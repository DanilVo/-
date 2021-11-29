//Удалить вторую цифру трёхзначного числа
int random = new Random().Next(100,199);
Console.WriteLine("this is random: " + random);
int second = (random / 10);
Console.WriteLine("after division: " + second);
int final = random - (second * 10 - 100);
int last = final - 90;
Console.WriteLine("result: " + last);
