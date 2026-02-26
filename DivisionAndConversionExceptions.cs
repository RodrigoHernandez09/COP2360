using System;
class DivisionConversionExceptions {
	static void Main() {
		//Asking for the first and second number as strings
		Console.WriteLine("What is the first number?");
		string first = Console.ReadLine();

		Console.WriteLine("What is the second number?");
		string second = Console.ReadLine();
		//Trys to convert each string into a int then divide them
		try {
			int firstNumber = Convert.ToInt32(first);
			int secondNumber = Convert.ToInt32(second);
			int division = Divide(firstNumber,secondNumber);
			Console.WriteLine("The result of " + firstNumber + " divided by " + secondNumber + " is: " + division);
		}
		//catches some common exceptions that might occur
		catch(DivideByZeroException zero) {
			Console.WriteLine("You can not divide by zero.");
			Console.WriteLine("Error message: " + zero.Message);
		}
		catch(FormatException form) {
			Console.WriteLine("You need to enter a number.");
			Console.WriteLine("Error message: " + form.Message);
		}
		catch(InvalidCastException cast) {
			Console.WriteLine("The number(s) entered was not an integer.");
			Console.WriteLine("Error message: " + cast.Message);
		}
		catch(OverflowException over) {
			Console.WriteLine("The number(s) entered was too big.");
			Console.WriteLine("Error message: " + over.Message);
		}
		//catches any exception that was not previously accounted for
		catch(Exception e) {
			Console.WriteLine("Sorry an unexpected error has occured.");
			Console.WriteLine("Error message: " + e.Message);
		}
	}
	static int Divide(int a,int b) {
		return a / b;
	}
}
