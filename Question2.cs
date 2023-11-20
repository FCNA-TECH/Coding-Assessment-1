Console.WriteLine(" "); 
Console.WriteLine("Enter number between 1 and 100"); 
int num = Convert.ToInt32(Console.ReadLine()); 
while (num < 1 || num > 100 ) 
{ 
    Console.WriteLine("Enter number between 1 and 100"); 
    num = Convert.ToInt32(Console.ReadLine()); 
} 
Console.WriteLine(" "); 
string Validationator = Checker(num); 
Console.WriteLine("That number is {0}", Validationator); 
string Checker(int num) 
{ 
    string Value = " "; 
    if (num%2 == 0){Value = "EVEN";} 
    else{Value = "ODD";} 
    return Value; 
} 
