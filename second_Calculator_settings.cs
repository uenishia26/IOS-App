using System;
namespace _Calculator
{
	public class second_Calculator_settings
	{
		public static readonly second_Calculator_settings instance = new second_Calculator_settings();


		private second_Calculator_settings()
		{

			Previous_value = 0.0;
			middle_Value = 0.0;
			RhValue = 0.0;

			Times_Add = false;
			Times_Add_First_Loop = false;
			Times_Add_Second_Loop = false;

			Times_Subtract = false;
			Times_Subtract_First_Loop = false;
			Times_Subtract_Second_Loop = false;

			Devide_Add = false;;
			Devide_Add_First_Loop = false;
			Devide_Add_Second_Loop = false;

			Devide_Subtract = false;
			Devide_Subtract_First_Loop = false;
			Devide_Subtract_Second_Loop = false;

			Delete = false;
			Add = false;
			Subtract = false;
			Multiply = false;
			Devide = false;

			first_Add_Loop = false;
			second_Add_Loop = false;
			first_Subtract_Loop = false;
			second_Subtract_Loop = false;
			first_Devide_Loop = false;
			second_Devide_Loop = false;
			first_Multiply_Loop = false;
			second_Multipy_Loop = false;


		}




		public Double Previous_value;
		public Double middle_Value;
		public Double RhValue;

		public Boolean Times_Add;
		public Boolean Times_Add_First_Loop;
		public Boolean Times_Add_Second_Loop;

		public Boolean Times_Subtract;
		public Boolean Times_Subtract_First_Loop;
		public Boolean Times_Subtract_Second_Loop;

		public Boolean Devide_Add;
		public Boolean Devide_Add_First_Loop;
		public Boolean Devide_Add_Second_Loop;

		public Boolean Devide_Subtract;
		public Boolean Devide_Subtract_First_Loop;
		public Boolean Devide_Subtract_Second_Loop;

		public Boolean Delete;
		public Boolean Add; 
		public Boolean Subtract;
		public Boolean Multiply;
		public Boolean Devide;

		public Boolean first_Add_Loop;
		public Boolean second_Add_Loop;
		public Boolean first_Subtract_Loop;
		public Boolean second_Subtract_Loop;
		public Boolean first_Devide_Loop;
		public Boolean second_Devide_Loop;
		public Boolean first_Multiply_Loop;
		public Boolean second_Multipy_Loop;

		public Double Equals(Double RhValue)
		{
			if (Add == true && Times_Add == true || Add == true && Devide_Add == true)		//This exsmaple ( 2 + 3 * 6) There must of been a equation similar to this which we have to priroritize the times more then the add
			{
				Add = false;		//Both values to false to prevent further prombelms
				Times_Add = false;
				return Previous_value + RhValue;	//Return something like 2 + 6 + 5) (This means it will return 2 + 5 instead
			}
			if (Add == true)		//This is for a equation looking something like ( 2 + 3 + 5). There could be negative numbers somewhere in there 
			{
				Add = false;
				return Previous_value + RhValue + middle_Value; //We can have middle value here because if Times_Add hasn't been pressed and middle_value = 0 it won't effect the code
			}

			if (Subtract == true && Times_Subtract == true || Subtract == true && Devide_Subtract == true)	//This means subtract is pressed before times 6 - 3 * 6.
			{
				Add = false;
				Times_Add = false;
				return Previous_value - RhValue;
			}
			if (Subtract == true)
			{
				Subtract = false;
				return Previous_value - RhValue - middle_Value; 
			}

			if (Multiply == true && Times_Add == true) 	//This is for Equations like 2 + 3 * 6
			{
				Multiply = false;
				Times_Add = false;
				return middle_Value * RhValue + Previous_value;
			}
			if (Multiply == true && Times_Subtract == true)	//Same as above
			{
				Multiply = false;
				Times_Subtract = false;
				return middle_Value * RhValue + Previous_value;
			}

			if (Devide == true && Devide_Add == true) 	//This is for Equations like 2 + 3 * 6
			{
				Devide = false;
				Devide_Add = false;
				return middle_Value / RhValue + Previous_value;
			}
			if (Devide == true && Devide_Subtract == true)	//Same as above
			{
				Devide = false;
				Devide_Subtract = false;
				return Previous_value - middle_Value / RhValue;
			}

			if (Multiply == true)
			{
				Multiply = false;
				return Previous_value * RhValue; 
			}
			if (Devide == true)
			{
				Devide = false;
				return Previous_value / RhValue; 
			}
			return 0;		//Without this it will not allow us to make this Equals loop because code doesn't kno what to do if everything = false.What to return
			//when equal is pressed more than once it will return the value 0 
		}
	}
}



