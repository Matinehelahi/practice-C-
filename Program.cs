//1

// Console.Write("What your name?");
// string name = Console.ReadLine();

// Console.WriteLine("Hi "+name+"!");


//2
// Console.Write("Enter a Number ? ");
// int num1 =int.Parse(Console.ReadLine());
// Console.Write("Enter a Number? ");
// int num2=int.Parse(Console.ReadLine());
// int sum = num1+num2;
// Console.WriteLine("Sum of " +num1 +" and "+num2+" is " +sum);


//3 
// Console.Write("How old are you? ");

// int age = int.Parse(Console.ReadLine());
//  if (age >= 18)
// {
//     Console.WriteLine("yes");
// }
// else
// {
//     Console.WriteLine("No!");
// }


//4
// int max =int.MinValue;
// for(int i=1; i<=5 ; i++)
// {
//     Console.WriteLine("Enter a Number ? ("+i+")");
//     int num = int.Parse(Console.ReadLine());

//     if (num>max)
//     {
//         max =num;
//     }
//     Console.WriteLine("Max is Number is "+max);
// }


//5

int Factorialo (int n)
{
    int result=1;
    for(int i=1; i <= n; i++)
    
        result *=i;
        return result;
    
}

Console.Write("Enter a Number?");
int n = int.Parse(Console.ReadLine());
int f = Factorialo(n);
Console.WriteLine(f);