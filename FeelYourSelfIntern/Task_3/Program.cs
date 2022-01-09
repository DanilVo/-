//string[] Days = {"sunday", "monday", "thursday", "wednesday", "thersday", "friday", "saturday"};
Console.WriteLine("enter your day");
string Days = Console.ReadLine();

if(Days == "1")
{
    Console.WriteLine("sunday");
}
else if(Days == "2")
{
    Console.WriteLine("monday");
}
else if(Days == "3")
{
    Console.WriteLine("thursday");
}
else if(Days == "4")
{
    Console.WriteLine("wednesday");
}
else if(Days == "5")
{
    Console.WriteLine("thersday");
}
else if(Days == "6")
{
    Console.WriteLine("friday");
}
else if(Days == "7")
{
    Console.WriteLine("saturday");
}
else
{
    Console.WriteLine("there only 7 days!");
}