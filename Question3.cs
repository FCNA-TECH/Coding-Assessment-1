Console.WriteLine(" "); 
Console.WriteLine("Enter the month as a number in the format MM"); 
int month = Convert.ToInt32(Console.ReadLine()); 
while (month < 1 || month > 12) 
{ 
    Console.WriteLine(" "); 
    Console.WriteLine("ERROR - You entered an invalid number!"); 
    Console.WriteLine("Enter the month as a number in the format MM"); 
    month = Convert.ToInt32(Console.ReadLine()); 
} 

Console.WriteLine(" "); 
Console.WriteLine("Enter the year as a number in the format YYYYY "); 
int year = Convert.ToInt32(Console.ReadLine()); 

if  (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) 
{ 
    Console.WriteLine("31 Days"); 
} 

if (month == 4 || month == 6 || month == 9 || month == 11) 
{ 
    Console.WriteLine("30 Days"); 
} 

if (month == 2) 
{ 
    bool leapyear = false; 
    if (year % 400 == 0)
    {
      leapyear = true;
    } 
    else if (year % 4 == 0 && year % 100 != 0)
    {
      leapyear = true;
    } 
    else 
    {
      leapyear = false;
    } 

  
    if (leapyear == false)
    {
      Console.WriteLine("28 days");
    } 
    else
    {
      Console.WriteLine("29 days");
    } 

} 
