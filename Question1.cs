Random nrg = new Random(); 
bool six = false; 
int count = 1; 
Console.WriteLine(" "); 
Console.WriteLine("rolling..."); 
while (six == false) 
{ 
    int roll = nrg.Next(1, 7); 
    Console.WriteLine(roll); 
    if (roll == 6) 
    { 
      break; 
    } 
    count += 1; 
} 
Console.WriteLine("6 has been rolled, number of tries = {0}", count); 
Console.WriteLine(" "); 
