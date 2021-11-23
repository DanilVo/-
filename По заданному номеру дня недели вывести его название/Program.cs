//string[] Days = {"sunday", "monday", "thursday", "wednesday", "thersday", "friday", "saturday"};
Console.WriteLine("enter your day");
string Days = Console.ReadLine();

if(Days == "1")
{
    Console.WriteLine("sunday");
}
if(Days == "2")
{
    Console.WriteLine("monday");
}
if(Days == "3")
{
    Console.WriteLine("thursday");
}
if(Days == "4")
{
    Console.WriteLine("wednesday");
}if(Days == "5")
{
    Console.WriteLine("thersday");
}
if(Days == "6")
{
    Console.WriteLine("friday");
}
if(Days == "7")
{
    Console.WriteLine("saturday");
}
else
{
    Console.WriteLine("there only 7 days!");
}