using System;

using UIKit;

namespace _Calculator
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{

		}


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


		}
		partial void Num0_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;

			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true; 
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true; 
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true; 
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true; 
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "0";
		}

		partial void Num1_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "1";
		}



		partial void Num2_TouchUpInside(UIButton sender)
		{

			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true;
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "2";
		}


		partial void Num3_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "3";
		}

		partial void Num4_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "4";
		}

		partial void Num5_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "5";
		}

		partial void Num6_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "6";
		}

		partial void Num7_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "7";;ef
		}

		partial void Num8_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true) 
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "8";
		}

		partial void Num9_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.first_Add_Loop == true)
			{
				Data.second_Add_Loop = true;
			}
			if (Data.first_Subtract_Loop == true)
			{
				Data.second_Subtract_Loop = true;
			}
			if (Data.first_Devide_Loop == true)
			{
				Data.second_Devide_Loop = true;
			}
			if (Data.first_Multiply_Loop == true)
			{
				Data.second_Multipy_Loop = true;
			}
			if (Data.Times_Add_First_Loop == true)
			{
				Data.Times_Add_Second_Loop = true;
			}
			if (Data.Times_Subtract_First_Loop == true)
			{
				Data.Times_Subtract_Second_Loop = true;
			}
			if (Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add_Second_Loop = true;
			}
			if (Data.Devide_Subtract_First_Loop == true)
			{
				Data.Devide_Subtract_Second_Loop = true; 
			}
			if (Data.Delete == true)
			{
				text_field.Text = "";
				Data.Delete = false;
			}
			text_field.Text = text_field.Text + "9";
		}

		partial void Clear_button_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;

			text_field.Text = "";

			Data.Previous_value = 0.0;
			Data.middle_Value = 0.0;
			Data.RhValue = 0.0;

			Data.Times_Add = false;
			Data.Times_Add_First_Loop = false;
			Data.Times_Add_Second_Loop = false;
			Data.Times_Subtract = false;
			Data.Times_Subtract_First_Loop = false;
			Data.Times_Subtract_Second_Loop = false;

			Data.Devide_Add = false;
			Data.Devide_Add_First_Loop = false;
			Data.Devide_Add_Second_Loop = false;

			Data.Devide_Subtract = false;
			Data.Devide_Subtract_First_Loop = false;
			Data.Devide_Subtract_Second_Loop = false;

			Data.Delete = false;
			Data.Add = false;
			Data.Subtract = false;
			Data.Multiply = false;
			Data.Devide = false;

			Data.first_Add_Loop = false;
			Data.second_Add_Loop = false;
			Data.first_Subtract_Loop = false;
			Data.second_Subtract_Loop = false;
			Data.first_Devide_Loop = false;
			Data.second_Devide_Loop = false;
			Data.first_Multiply_Loop = false;
			Data.second_Multipy_Loop = false;

		}

		partial void Add_button_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;

			//These four code below are very important as it defines why on the right hand side of the first loop 
			if (Data.Times_Add_First_Loop == true && Data.Times_Add_Second_Loop == true)		//We need four loops just in case - is pressed in the + button and so on 
			{
				Data.Times_Add = true;
			}
			if(Data.Devide_Add_First_Loop == true && Data.Devide_Add_Second_Loop == true)
			{
				Data.Devide_Add = true;
			}
			if (Data.Times_Subtract_First_Loop == true && Data.Times_Subtract_Second_Loop == true)
			{
				Data.Times_Subtract = true; 
			}
			if(Data.Devide_Subtract_First_Loop == true && Data.Devide_Subtract_Second_Loop == true)
			{
				Data.Devide_Subtract = true;
			}
			//This is where it ends

			//This is the 2 code Preparing for prioritzing a mathmatical term over a other 
			if (Data.first_Add_Loop == true && Data.second_Add_Loop == true && Data.Times_Add == true)		//This code runs 2 + 4 * 6 + 2 + 6) This code will run when 2 + is pressed fpr the second time																								//This is because add = true but we can't let it do the normal add, we need a diffrent add which stores value to middle_value rather then pREVIOUS-VALUE 
			{		
				Data.Add = true;
				Data.first_Add_Loop = false;
				Data.second_Add_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.middle_Value);
				Data.Times_Add = false; 	//If this wasn't set false it will run the Data.Times_Add loop below as well
			}
			if (Data.first_Add_Loop == true && Data.second_Add_Loop == true && Data.Devide_Add == true)
			{
				Data.Devide = true;
				Data.first_Add_Loop = false;
				Data.second_Add_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.middle_Value);
				Data.Devide = false;
			}
			//Diffrent code as above
			if (Data.first_Add_Loop == true && Data.second_Add_Loop == true)				//If add is pressed normally such as 2 + 4 + 5 + 100 // This another works does the most basic calculation witn no prioritizing and so on
			{
				Data.Add = true;
				Data.first_Add_Loop = false;
				Data.second_Add_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			//This is where the leading up prioritizing finishes 

			//These are the important four bits of code in this Calcualtor
			if (Data.Times_Add == true)														//This loop will run if prioritzing in numbers is needed (2 + 5 * 6 * 5) Here we have to Prioritize the times more then the add	
			{	//This becomes true only if the calculation looks something like this 2 + 5 * 6 + 5. It wil become true after the * button after the 5 
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false;
				Data.Times_Add = false;
				Data.Times_Add_First_Loop = false;
				Data.Times_Add_Second_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.middle_Value = Data.middle_Value * Data.RhValue;
				Data.Previous_value = Data.middle_Value + Data.Previous_value; //Just in case, * is pressed more then once we are going to store the overall answer for the three digit to Previous_value
				text_field.Text = Convert.ToString(Data.Previous_value);                                   
			}
			if (Data.Devide_Add == true)    //This loop will run when devide has been pressed after the subtract of add
			{
				Data.first_Devide_Loop = false;
				Data.second_Devide_Loop = false;
				Data.Devide_Add = false;
				Data.Devide_Add_First_Loop = false;
				Data.Devide_Add_Second_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.middle_Value = Data.middle_Value / Data.RhValue;
				Data.Previous_value = Data.middle_Value + Data.Previous_value; //Just in case, * is pressed more then once we are going to store the overall answer for the three digit to Previous_value
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			if (Data.Times_Subtract == true)	//This is when priortizing is needed
			{
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false;
				Data.Times_Subtract = false;
				Data.Times_Subtract_First_Loop = false;
				Data.Times_Subtract_Second_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);		//RhvALUE will be 6 + 5 * 6 + 5(It will be the 6)
				Data.middle_Value = Data.middle_Value* Data.RhValue;    //Another words in this exsample it is doing 6 * 5 = 30 
				Data.Previous_value = Data.middle_Value - Data.Previous_value; //If we are using the above equation it will be doing 30 - 6(Data.Previous_Value will be the firstNumber entered)
				Data.Previous_value = Data.Previous_value - Data.Previous_value - Data.Previous_value;
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			if (Data.Devide_Subtract == true)	//This is when priortizing is needed
			{
				Data.first_Devide_Loop = false;
				Data.second_Devide_Loop = false;
				Data.Devide_Subtract = false;
				Data.Devide_Subtract_First_Loop = false;
				Data.Devide_Subtract_Second_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);		//RhvALUE will be 6 + 5 * 6 + 5(It will be the 6)
				Data.middle_Value = Data.middle_Value / Data.RhValue;    //Another words in this exsample it is doing 6 * 5 = 30 
				Data.Previous_value = Data.middle_Value - Data.Previous_value; //If we are using the above equation it will be doing 30 - 6(Data.Previous_Value will be the firstNumber entered)
				Data.Previous_value = Data.Previous_value - Data.Previous_value - Data.Previous_value;
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			//Aboe we have four similar loops for subtract and Add. the only reason we have one for both matmatccal operator is what happens if (5+2/10-2/5) Data.devide_Add will become true in the subtract loop so we have to be prepared 

			//This cod below is the code which does not need any prioritzing such as normal and simple caluclation ( 2 * 6 + 4 - 3 ) || 2 - 3 + 5) and so on 
			if (Data.first_Multiply_Loop == true && Data.second_Multipy_Loop == true)		//If mutiply is pressed before Exsmaple (6 * 2 + 5 + 10) No prioritizing needed. But it still means * Was pressed before the add button 
			{
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);   
				Data.Previous_value = Data.Previous_value * Data.RhValue;
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			if (Data.first_Devide_Loop == true && Data.second_Devide_Loop == true)
			{
				Data.first_Devide_Loop = false;
				Data.second_Devide_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);   
				Data.Previous_value = Data.Previous_value / Data.RhValue;
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			if (Data.first_Subtract_Loop == true && Data.second_Subtract_Loop == true)
			{
				Data.first_Subtract_Loop = false;
				Data.second_Subtract_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Previous_value - Data.RhValue;
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			//This is where the non Prioritzing code finishes 

			//This code will run everysingle time where the caluclator is reset or restarted. 
			Boolean Vertification_final = false;	//Starting value is false 

			if (text_field.Text == "")		//If text_field.Text is blank
			{
				Vertification_final = true;	//We are going to chnage the starting value to a true  
			}

			if (Data.Previous_value == 0 && Vertification_final == false)	//If starting value hasn't been changed and Previous_value = 0
			{
				Data.Previous_value = Convert.ToDouble(text_field.Text);	//We are going to store the number to the data.Previous_value
			}

			if (Vertification_final == false)	//If starting value hasn't be changed it means that text_field was not blank
			{
				Data.Delete = true;				//If it is not blank
				Data.first_Add_Loop = true;	//Make these 2 values true
				//We made this loop so it prevents errors 
			}
		}









		partial void Minus_button_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			//We know have to do the exact same for the Minus Button as well as the Plus button 

			if (Data.Times_Subtract_First_Loop == true && Data.Times_Subtract_Second_Loop == true)		//We have four loops just in case if add was pressed in the minus loop and so on
			{
				Data.Times_Subtract = true; 
			}
			if(Data.Devide_Subtract_First_Loop == true && Data.Devide_Subtract_Second_Loop == true)
			{
				Data.Devide_Subtract = true;
			}
			if (Data.Times_Add_First_Loop == true && Data.Times_Add_Second_Loop == true)
			{
				Data.Times_Add = true;
			}
			if (Data.Devide_Add_First_Loop == true && Data.Devide_Add_First_Loop == true)
			{
				Data.Devide_Add = true; 
			}

			//These 3 code below you can see are the code that is leading up to the prioritzing. A good exsample will be 2 + 3 * 6. This code stores the number 3 so next time it can do the prioritizing caluclation 
			if (Data.first_Subtract_Loop == true && Data.second_Subtract_Loop == true && Data.Times_Subtract == true)  //A good exsample for this code will be 2 - 3 * 5 - 6 (Data.Times_Subtract) only = true when times button is pressed and previously minus button has been pressed. 
			{
				Data.Subtract = true;
				Data.first_Subtract_Loop = false;
				Data.second_Subtract_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.Previous_value);

				Data.Times_Subtract = false;		//If this wasn't set false it will also run the Data.Times-subtract loop 2 sets below us 
			}
			if (Data.first_Devide_Loop == true && Data.second_Devide_Loop == true && Data.Devide_Subtract == true)  //A good exsample for this code will be 2 - 3 * 5 - 6 (Data.Times_Subtract) only = true when times button is pressed and previously minus button has been pressed. 
			{
				Data.Subtract = true;
				Data.first_Subtract_Loop = false;
				Data.second_Subtract_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.Previous_value);

				Data.Devide_Subtract = false;		//If this wasn't set false it will also run the Data.Times-subtract loop 2 sets below us 
			}
			if (Data.first_Subtract_Loop == true && Data.second_Subtract_Loop == true)	//This is normal subtracting such as 2 - 3 - 4 - 5 - 4 - 5 - 2
			{
				Data.Subtract = true;
				Data.first_Subtract_Loop = false;
				Data.second_Subtract_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			//This is where the three Leading up prioritizng code finshes 

			//This four loops below are the most important code because it has everything about prioritizing Matmatical operators over some. 
			if (Data.Times_Subtract == true)	//This is when priortizing is needed
			{
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false;
				Data.Times_Subtract = false;
				Data.Times_Subtract_First_Loop = false;
				Data.Times_Subtract_Second_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);		//RhvALUE will be 6 + 5 * 6 + 5(It will be the 6)
				Data.middle_Value = Data.middle_Value * Data.RhValue;	//Another words in this exsample it is doing 6 * 5 = 30 
				Data.Previous_value = Data.middle_Value - Data.Previous_value; //If we are using the above equation it will be doing 30 - 6(Data.Previous_Value will be the firstNumber entered)
				Data.Previous_value = Data.Previous_value - Data.Previous_value - Data.Previous_value;
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			if (Data.Devide_Subtract == true)	//This is when priortizing is needed
			{
				Data.first_Devide_Loop = false;
				Data.second_Devide_Loop = false;
				Data.Devide_Subtract = false;
				Data.Devide_Subtract_First_Loop = false;
				Data.Devide_Subtract_Second_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);		//RhvALUE will be 6 + 5 * 6 + 5(It will be the 6)
				Data.middle_Value = Data.middle_Value / Data.RhValue;    //Another words in this exsample it is doing 6 * 5 = 30 
				Data.Previous_value = Data.middle_Value - Data.Previous_value; //If we are using the above equation it will be doing 30 - 6(Data.Previous_Value will be the firstNumber entered)
				Data.Previous_value = Data.Previous_value - Data.Previous_value - Data.Previous_value;
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			if (Data.Times_Add == true)														//This loop will run if prioritzing in numbers is needed (2 + 5 * 6 * 5) Here we have to Prioritize the times more then the add	
			{	//This becomes true only if the calculation looks something like this 2 + 5 * 6 + 5. It wil become true after the * button after the 5 
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false;
				Data.Times_Add = false;
				Data.Times_Add_First_Loop = false;
				Data.Times_Add_Second_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.middle_Value = Data.middle_Value* Data.RhValue;
				Data.Previous_value = Data.middle_Value + Data.Previous_value; //Just in case, * is pressed more then once we are going to store the overall answer for the three digit to Previous_value
				text_field.Text = Convert.ToString(Data.Previous_value);                                   
			}
			if (Data.Devide_Add == true)    //This loop will run when devide has been pressed after the subtract of add
			{
				Data.first_Devide_Loop = false;
				Data.second_Devide_Loop = false;
				Data.Devide_Add = false;
				Data.Devide_Add_First_Loop = false;
				Data.Devide_Add_Second_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.middle_Value = Data.middle_Value / Data.RhValue;
				Data.Previous_value = Data.middle_Value + Data.Previous_value; //Just in case, * is pressed more then once we are going to store the overall answer for the three digit to Previous_value
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			//This is where the important 4 piece of loop finishes. Without this we will not be able to do Calculations with + and - and * and /. 

			//The code below are the code that doesn't need any prioritizing. Its could be a calculation like 2 * 3 + 5 - 4 or something similar 
			if (Data.first_Multiply_Loop == true && Data.second_Multipy_Loop == true)       //If mutiply is pressed before Exsmaple (6 * 2 + 5 + 10) No prioritizing needed. But it still means * Was pressed before the add button 
			{
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Previous_value * Data.RhValue;
				text_field.Text = Convert.ToString(Data.Previous_value);
			}
			if (Data.first_Devide_Loop == true && Data.second_Devide_Loop == true)
			{
				Data.first_Devide_Loop = false;
				Data.second_Devide_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Previous_value / Data.RhValue;
				text_field.Text = Convert.ToString(Data.Previous_value); 
			}
			if (Data.first_Add_Loop == true && Data.second_Add_Loop == true)
			{
				Data.first_Add_Loop = false;
				Data.second_Add_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Previous_value + Data.RhValue;
				text_field.Text = Convert.ToString(Data.Previous_value); 
			}
			//This is where the non Prioritizing code finishes

			//This code below is the code which will run whenerver the programm has been reset or restararted
			Boolean Vertification_final = false;	//Starting value is false 

			if (text_field.Text == "")		//If text_field.Text is blank
			{
				Vertification_final = true;	//We are going to chnage the starting value to a true  
			}

			if (Data.Previous_value == 0 && Vertification_final == false)	//If starting value hasn't been changed and Previous_value = 0
			{
				Data.Previous_value = Convert.ToDouble(text_field.Text);	//We are going to store the number to the data.Previous_value
			}

			if (Vertification_final == false)	//If starting value hasn't be changed it means that text_field was not blank
			{
				Data.Delete = true;				//If it is not blank
				Data.first_Subtract_Loop = true;	//Make these 2 values true
				//We made this loop so it prevents errors 
			}

		}







		partial void Times_button_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;

			//This code below is the code which makes the value true and false to prepare for the prioritzing
			if (Data.Times_Add_First_Loop == true && Data.Times_Add_Second_Loop == true)	//If add has been pressed previously and a button has been pressed afterwrds this will become true 
			{
				Data.Times_Add = true; //By making this true it will be able to do the sepcial calculation for prioritizing numbers
			}
			if (Data.Times_Subtract_First_Loop == true && Data.Times_Subtract_Second_Loop == true)
			{
				Data.Times_Subtract = true; 
			}
			//This is where the making values true and false for the prioritzing finishes

			//This code is the preparation for the prioritzing 
			if (Data.first_Add_Loop == true && Data.second_Add_Loop == true)			//Add has been pressed previously Exsample ( 2 + 5 * 6)/ We have to prioritize * over + and this is when middle_Value becomes in good use
			{
				Data.first_Add_Loop = false;          									//Make both Add values to false                                  
				Data.second_Add_Loop = false; 											
				Data.middle_Value = Convert.ToDouble(text_field.Text);
     			Data.Times_Add = false;						//The only place the Data.Times_Add can - true is here.
				Data.Times_Add_First_Loop = true; 			//This is a simple vertification. Times_Add will only become true again if a number is entered. This means if someone pressed the times button2 accidentaly it will do nothing to the code
			}






			//This code is bascially for ocassions like 2 - 5 * 6. We have to do - 5 * 6 instead of 5 * 6
			if (Data.first_Subtract_Loop == true && Data.second_Subtract_Loop == true)	//This means if - was pressed Previously so something like 2 - 5 * 6
			{
				Double to_get_Negative = Convert.ToDouble(text_field.Text);     //This is so we can solve equations like 6 - 3 * 6. we have to do - 3 * 6 rather then 3 * 6 
				to_get_Negative = to_get_Negative - to_get_Negative - to_get_Negative;			//Here we are saying 3 - 3 - 3 = - 3 so we can then * - 3
				Data.first_Subtract_Loop = false;
				Data.second_Subtract_Loop = false;
				Data.middle_Value = to_get_Negative;
				Data.Times_Subtract = false;
				Data.Times_Subtract_First_Loop = true; 
			}










			//This is where the preparation finishes

			//This is where the prioritzing is calculated and so on. It does all the addition and subtraction for everysingle mathmatical operator
			if (Data.first_Multiply_Loop == true && Data.second_Multipy_Loop == true && Data.Times_Add == true)	//This means that if mutiply button is pressed and a number is pressed but Previously Add was true (This is what the Data.Times_add = true) is
			{																									
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Times_Add = false; 
				Data.middle_Value = Data.middle_Value * Data.RhValue;
				text_field.Text = Convert.ToString(Data.middle_Value);

			}
			if (Data.first_Multiply_Loop == true & Data.second_Multipy_Loop == true && Data.Times_Subtract == true)	//A good exsample will be 2 - 6 * 5. This code is doing the 6 * 5 first before subtracting it by 2
			{
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Times_Subtract = false; 
				Data.middle_Value = Data.middle_Value * Data.RhValue;
				text_field.Text = Convert.ToString(Data.middle_Value);
			}
			//This is where the real Prioritzing loop finhses 

			//This code below is the non Prioritizing code such as 2 * 6 * 5 
			if (Data.first_Multiply_Loop == true && Data.second_Multipy_Loop == true)		//If Mutiply is pressed such as 6 * 5 * 5 it will go through this loop
			{
				Data.Multiply = true;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.Previous_value);
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false; 
			}
			if (Data.first_Devide_Loop == true && Data.second_Devide_Loop == true)
			{
				Data.Devide = true;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.Previous_value);
				Data.first_Devide_Loop = false;
				Data.second_Devide_Loop = false; 
			}
			//This is where the Non prioritizing code finishes
		
			Boolean Vertification_final = false;	//Starting value is false 

			if (text_field.Text == "")		//If text_field.Text is blank
			{
				Vertification_final = true;	//We are going to chnage the starting value to a true  
			}

			if (Data.Previous_value == 0 && Vertification_final == false)	//If starting value hasn't been changed and Previous_value = 0
			{
				Data.Previous_value = Convert.ToDouble(text_field.Text);	//We are going to store the number to the data.Previous_value
			}

			if (Vertification_final == false)	//If starting value hasn't be changed it means that text_field was not blank
			{
				Data.Delete = true;				//If it is not blank
				Data.first_Multiply_Loop = true;	//Make these 2 values true
				//We made this loop so it prevents errors 
			}
	}











		partial void Devide_button_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;

			//This is the code which is making the values true and false to prepare for the prioritizing loop
			if (Data.Devide_Add_First_Loop == true && Data.Devide_Add_Second_Loop == true)	//If add has been pressed previously and a button has been pressed afterwrds this will become true 
			{
				Data.Devide = true; //By making this true it will be able to do the sepcial calculation for prioritizing numbers
			}
			if (Data.Devide_Subtract_First_Loop == true && Data.Devide_Subtract_Second_Loop == true)
			{
				Data.Devide_Subtract = true; 
			}
			//This is where the making values true and false finishes

			//This is the preparation for the prioritzing code, Another words it's preparing for the code below us 
			if(Data.first_Add_Loop == true && Data.second_Add_Loop == true)
			{
				Data.first_Add_Loop = false;          									//Make both Add values to false                                  
				Data.second_Add_Loop = false; 											
				Data.middle_Value = Convert.ToDouble(text_field.Text);
				Data.Devide_Add = false;						//The only place the Data.Times_Add can - true is here.
				Data.Devide_Add_First_Loop = true; 			//This is a simple vertification. Times_Add will only become true again if a number is entered. This means if someone pressed the times button2 accidentaly it will do nothing to the code
			}

			if (Data.first_Subtract_Loop == true && Data.second_Subtract_Loop == true)	//If subtract has been pressed before the devide button 
			{
				Data.first_Subtract_Loop = false;
				Data.second_Subtract_Loop = false;
				Data.middle_Value = Convert.ToDouble(text_field.Text);
				Data.Devide_Subtract = false;
				Data.Devide_Subtract_First_Loop = true; 
			}
			//This is where the preparation for the prioritzing finishes

			//This is the actuall Prioritizing code, when it caluclates stores and then does + & - next 
			if (Data.first_Devide_Loop == true && Data.second_Devide_Loop == true && Data.Devide_Subtract == true)	//This means that if mutiply button is pressed and a number is pressed but Previously Add was true (This is what the Data.Times_add = true) is
			{																									
				Data.first_Subtract_Loop = false;
				Data.second_Subtract_Loop = false;
				Data.Times_Subtract = false; 
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.middle_Value = Data.middle_Value / Data.RhValue;
				text_field.Text = Convert.ToString(Data.middle_Value);
			}
			if (Data.first_Devide_Loop == true & Data.second_Devide_Loop == true && Data.Devide_Add == true)	//A good exsample will be 2 - 6 * 5. This code is doing the 6 * 5 first before subtracting it by 2
			{
				Data.first_Add_Loop = false;
				Data.second_Add_Loop = false;
				Data.Times_Add = false;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.middle_Value = Data.middle_Value / Data.RhValue;
				text_field.Text = Convert.ToString(Data.middle_Value);
			}
			//This is where the prioritzing code finishes

			//This is where the non Prioritzing Mathmatics coding happens 
			if (Data.first_Devide_Loop == true && Data.second_Devide_Loop == true)		//If Devide is pressed such as 6 / 5 / 5 it will go through this loop
			{
				Data.Devide = true;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.Previous_value);
				Data.first_Devide_Loop = false;
				Data.second_Devide_Loop = false; 
			}
			if (Data.first_Multiply_Loop == true && Data.second_Multipy_Loop == true)		//If Mutiply is pressed such as 6 * 5 * 5 it will go through this loop
			{
				Data.Multiply = true;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
				text_field.Text = Convert.ToString(Data.Previous_value);
				Data.first_Multiply_Loop = false;
				Data.second_Multipy_Loop = false; 
			}
			//This is where it ends 
			Boolean Vertification_final = false;	//Starting value is false 

			if (text_field.Text == "")		//If text_field.Text is blank
			{
				Vertification_final = true;	//We are going to chnage the starting value to a true  
			}

			if (Data.Previous_value == 0 && Vertification_final == false)	//If starting value hasn't been changed and Previous_value = 0
			{
				Data.Previous_value = Convert.ToDouble(text_field.Text);	//We are going to store the number to the data.Previous_value
			}

			if (Vertification_final == false)	//If starting value hasn't be changed it means that text_field was not blank
			{
				Data.Delete = true;				//If it is not blank
				Data.first_Devide_Loop = true;	//Make these 2 values true
				//We made this loop so it prevents errors 
			}
		}



		 










		partial void Equal_button_TouchUpInside(UIButton sender)
		{
			second_Calculator_settings Data = second_Calculator_settings.instance;
			if (Data.Times_Add_First_Loop == true && Data.Times_Add_Second_Loop == true)	//These are the important four piece of code because it is making values true and false. Without this the code will not work 
			{
				Data.Times_Add = true; //Make Data.Tims = true; 
			}
			if (Data.Times_Subtract_First_Loop == true && Data.Times_Subtract_Second_Loop == true)
			{
				Data.Times_Subtract = true; 
			}
			if (Data.Devide_Add_First_Loop == true && Data.Devide_Add_Second_Loop == true)
			{
				Data.Devide_Add = true;
			}
			if (Data.Devide_Subtract_First_Loop == true && Data.Devide_Subtract_Second_Loop == true)
			{
				Data.Devide_Subtract = true; 
			}
			//This is where the imporant making true and false code finishes

			//This is the code which tells the computer to do a pacifc caluclation depedning on what value is true and false
			if (Data.first_Multiply_Loop == true && Data.second_Multipy_Loop == true)		//This another words means if the calculation ended witha times Exsample 2 + 6 * 5 =. It ends with a * button 
			{
				Data.Multiply = true;									//By making Multiply to true when it goes into the calucaltor_settings.cs it will be able to Mutiply 
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);

			}
			if (Data.first_Devide_Loop == true && Data.second_Devide_Loop == true)
			{
				Data.Devide = true;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
			}
			if (Data.first_Add_Loop == true && Data.second_Add_Loop == true)				
			{
				Data.Add = true;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue); 
			}
			if (Data.first_Subtract_Loop == true && Data.second_Subtract_Loop == true)
			{
				Data.Subtract = true;
				Data.RhValue = Convert.ToDouble(text_field.Text);
				Data.Previous_value = Data.Equals(Data.RhValue);
			}
			//This is where all the code of the calcualtion is done. (The computer now knows what number to print out and so on 
			text_field.Text = Convert.ToString(Data.Previous_value);
			//This is the actuall moment when it prints out the final answer to the text_field.Text

			//This code below is basically the reset. when = is pressed finally, we want everything to reset so it is read to do a another caluclation without delay, errors, warrnings and so on 


			Data.Times_Add = false;
			Data.Times_Add_First_Loop = false;
			Data.Times_Add_Second_Loop = false;
			Data.Times_Subtract = false;
			Data.Times_Subtract_First_Loop = false;
			Data.Times_Subtract_Second_Loop = false;

			Data.Devide_Add = false;
			Data.Devide_Add_First_Loop = false;
			Data.Devide_Add_Second_Loop = false;

			Data.Devide_Subtract = false;
			Data.Devide_Subtract_First_Loop = false;
			Data.Devide_Subtract_Second_Loop = false;

			Data.Delete = false;
			Data.Add = false;
			Data.Subtract = false;
			Data.Multiply = false;
			Data.Devide = false;

			Data.first_Add_Loop = false;
			Data.second_Add_Loop = false;
			Data.first_Subtract_Loop = false;
			Data.second_Subtract_Loop = false;
			Data.first_Devide_Loop = false;
			Data.second_Devide_Loop = false;
			Data.first_Multiply_Loop = false;
			Data.second_Multipy_Loop = false;

		}

		//when = is pressed more than once it will return the value 0 because it does not make sense to have something like 2 + 3 == // == does not make any sense
		//We made this functionality to prevent errors and further promblems, we like to be very precice with our calculation. You will never see in a math exam 2 + 3 == becasuser it makesd no sense

		partial void Dot_button_TouchUpInside(UIButton sender)
		{
			if (text_field.Text == "")		//If text_field is blank print out the number 0
			{
				text_field.Text = text_field.Text + Convert.ToDouble(0);	
			}
			if (!text_field.Text.Contains("."))	//Using the above statement, if text_field.Text does not contain the dot print out the dot
			{
				text_field.Text = text_field.Text + '.';
			}
			else
			{
				//If it isn't blank and contains a dot don't do anything
			}

		}

		partial void Pluse_minus_TouchUpInside(UIButton sender)
		{
			if (!text_field.Text.Contains("-")) //If text_field does not contain the minus button 
			{
				text_field.Text = ('-') + text_field.Text;  //Print out the minus button 

			}
			else
			{
				//If it does contain the minus button
				text_field.Text = text_field.Text.Replace("-","");	//Replaces the - sign to a blank sign 
			}

		}

		partial void Percent_button_TouchUpInside(UIButton sender)
		{
			Boolean Vertification_final = false;    //Starting value is false 

			if (text_field.Text == "")      //If text_field.Text is blank
			{
				Vertification_final = true; //We are going to chnage the starting value to a true  
			}

			if (text_field.Text == Convert.ToString(0))  //If text_field is 0 don;t do anything 
			{ }
			if (Vertification_final == false)   //If text_field is not blank do the following assignement below 
			{
				Double text_field_value = Convert.ToDouble(text_field.Text);
				text_field.Text = Convert.ToString(text_field_value / 100);
			}

		}

	}
}

