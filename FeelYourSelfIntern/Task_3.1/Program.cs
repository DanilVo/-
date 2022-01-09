string[] Days = {"sunday", "monday", "thursday", "wednesday", "thersday", "friday", "saturday"};
int Day = int.Parse(Console.ReadLine());
if(Day>Days.Length)
{
    Console.WriteLine("mistake");
}
else
{
    Console.WriteLine(Days[Day-1]);
}
