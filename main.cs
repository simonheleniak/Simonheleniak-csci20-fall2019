using System;

class MainClass 
{
 static void Main ()
  {
    int cents, Q, N, D, P, R, fee; // all the number variables
    double total;
    string cent; 
    Console.WriteLine ("Give me Your money in cents");
    cent = Console.ReadLine(); // reading there input
    cents = int.Parse(cent);// changing there string input to an int
    
    Q = cents/25;//getting the amount of quarters
    R = cents%25;//finding amount left over after quarters are subtracted

    D = R/10;//getting the amount of dimes
    R = R%10;//finding amount left over after dimes are subtracted
    
    N = R/5;//getting amount of nickles 
    R = R%5;//finding amount left over after nickles are subtracted

    P = R;// your left over after nickles is the amount of pennies you have

    Console.WriteLine("You Have Entered "+ cent+ " cents.");
    Console.WriteLine("That was "+Q+" quarters, "+D+" Dimes, "+N+" Nickles, and "+P+" Pennies.");

    total = cents - (cents *.109); // making the total the amount you recieve after the fee
    fee = Convert.ToInt32(total); // converting the total to an int without any decimals 

    Console.WriteLine("The Total is "+cent+" cents. After the fee you get "+fee+" cents.");


    


  }
}