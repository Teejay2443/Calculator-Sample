// See https://aka.ms/new-console-template for more information
Console.WriteLine("You are welcome");
Console.WriteLine("please enter the calculation that you want");
Console.WriteLine("if you want addition enter 1");
Console.WriteLine("if you want subtraction enter 2");
Console.WriteLine("if you want multiplication table enter 3");
Console.WriteLine("if you want division enter 4");
 Console.WriteLine("if you want perimeter of circle enter 5");
Console.WriteLine("if you conversion enter 6");
 int cal = Convert.ToInt32(Console.ReadLine());
  switch (cal)
{
  case 1 :
  Console.WriteLine("Now let us do some addition calculation. ");
  Console.WriteLine("Write the  first number you want add up.");
  int myNumber1 =Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine("Write the second number you want to add up with the first number");
  int myNumber2 =Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine("Your Answer is = " +  (myNumber1 + myNumber2));
   break;
  case 2:
  Console.WriteLine("In this app we will help you with some mathematical calculations.");
  Console.WriteLine("Now let us do some subtraction calculation. ");
  Console.WriteLine("Write the  first number you want subtract up.");
  int myNum1 =Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine("Write the second number you want to subtract from first number");
  int myNum2 =Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine("Your Answer is = " +  (myNum1 - myNum2));
   break;
  case 3:
  Console.WriteLine("please enter the number you wish to know the mutiplication table:");
  int h = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Multiplication Table of " + h ); 
  for (int i = 1; i < 13; i++) 
 {
  Console.WriteLine(h + "*" + i + "=" + h*i);
 }
 break;
  case 4:
  Console.WriteLine("Write the  first number you want divide.");
  int divide1 =Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine("Write the  second number you want to divide.");
  int divide2 =Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Your answer is = " + (divide1/divide2));
  break;

  case 5:
  Console.WriteLine("Let have the value of your radius");
  int myRadius =Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("the perimeter of the circle is = " + 2 * Math.PI * myRadius );
break;

  case 6:
  Console.WriteLine("We will be converting your degree celsius to fahrenheit and vice versa");
Console.WriteLine("Now give us your temperature in celcius:");
int myDegree =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Your answer is : " + myDegree *33.8) + "F");
Console.WriteLine("We are now going to move convert from fahrenhiet to celcius ");
Console.WriteLine("Now give us your temperature in fahrenheit:");
int myF =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your answer is : " + ((myF - 32) *5)/9 +"C");

Console.WriteLine("We will now move to convertion of celcius to kelvin and vice versa ");
Console.WriteLine("Now give us your temperature in celcius:");
int myC =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Your answer is : " + (myC + 273) + "k"));

Console.WriteLine("Now give us your temperature in Kelvin:");
int myK =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Your answer is : " + (myK - 273) + "C"));
break;

  default:
  Console.WriteLine("Please enter a valid calculation number ");
  break;

}