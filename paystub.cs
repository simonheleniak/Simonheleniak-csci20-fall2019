
using System;

class MainClass {
  public static void Main () {
    string hours, wages, name; // all the strings in need to save
    double hour, wage, pay, taxed,ovr,monthly,ovrpay,actpay;// the numbers i need to save
    double tax = 0.88;//setting tax as the amount i multiply by to get my left over
    Console.WriteLine("What is your Name?");//ask who they are
    name = Console.ReadLine();// setting there responce to 'name'
    Console.WriteLine("How Many Hours Do You Work a Week "+name+" ?");//asking how many hours they work
    hours = Console.ReadLine();//setting there responce to a string called 'hours'
    Console.WriteLine("What are your Hourly Wages "+name+" ?");//asking how much they make per hour
    wages = Console.ReadLine();//setting there responce to a string called 'wages'
    hour = double.Parse(hours);//changing the string to a double
    wage = double.Parse(wages);//changing the string to a double
    if(hour>40 ){//if they work more than 40 hours
      ovr = hour-40;// ovr is the amount of time they work in overtime
      taxed = 0.12*(hour*wage);//finding how much taxes are taken out
      pay = tax*(40*wage);//setting pay to the amount they make before overtime
      ovrpay = pay +(tax* (ovr*(wage*2)));//the amount they make from overtime
      actpay = pay + ovrpay;// the amount they actually make with overtime
      monthly = actpay * 4;//taking there weekly pay and *4 to get monthly pay
      Console.WriteLine(name);//starting the paystub with name
      Console.WriteLine("Hours Worked: "+hours);// telling them the amount of hours worked
      Console.WriteLine("Your Monthly Wages are: $"+ Math.Round(monthly,2));//telling them the amount of money they made while rounding off the decimals so there are whole cents
      Console.WriteLine("Overtime Worked: "+Math.Round(ovr,2)+" hours");//telling them the amount of overtime they worked while rounding off the decimals
      Console.WriteLine("You were taxed: $"+ Math.Round(taxed,2));//telling them the amount of taxes that were taken out of there check
    }
    else{//else less than 40 hours
    pay = tax*(hour*wage);//setting pay to there hours*wages and subtracting the tax
    taxed = 0.12*(hour*wage);//finding out the amount they were taxed
    Console.WriteLine(name);//starting the paystub with there name
    monthly = pay * 4;//taking there weekly pay and *4 to get monthly pay 
    Console.WriteLine("Hours Worked: "+hours);//telling the amount of hours they worked
    Console.WriteLine("Your Monthly Wages are: $"+ Math.Round(monthly,2));//telling them the amount of money they made while rounding off the decimals so there are whole cents
    Console.WriteLine("You were taxed: $"+ Math.Round(taxed,2));//telling them the amount of taxes that were taken out of there check
    }


  }
}
