using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            
            //
            //
            //implement the required code here and within the methods below.
            //
            //
            Console.WriteLine("Please enter your String");
            userInputString = Console.ReadLine();

            Console.WriteLine("Please enter the index of the start of your substring");
            string userNum = Console.ReadLine();
            elementNum = Int32.Parse(userNum);

            Console.WriteLine("Please enter the character you want to search for");
            char1 = Console.ReadLine()[0];
            

            Console.WriteLine("Please enter your first name");
            fName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            lName = Console.ReadLine();

            StringSubstring(userInputString, elementNum);
            SearchChar(userInputString, char1);
            userFullName = ConcatNames(fName, lName);

            Console.WriteLine(userInputString); 
            Console.WriteLine(elementNum);      
            Console.WriteLine(char1);           
            Console.WriteLine(fName);           
            Console.WriteLine(lName);           
            Console.WriteLine(userFullName);

        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            //throw new NotImplementedException("StringToUpper method not implemented.");
            return x.ToUpper();
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            //throw new NotImplementedException("StringToUpper method not implemented.");
            return x.ToLower();
        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
            //throw new NotImplementedException("StringTrim method not implemented.");
            string s = "";
            for(int i = 0; i < x.Length; i++){
                if(x.Substring(i, 1) == " "){/*Do nothing*/}
                else{s = s + x.Substring(i,1);} //concat that letter onto the resulting string
            } return s;
        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            //throw new NotImplementedException("StringSubstring method not implemented.");
            StringTrim(x);
            return x.Substring(elementNum, x.Length - elementNum);
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            //throw new NotImplementedException("SearchChar method not implemented.");
            int index = -1; //index returns -1 if the letter is not present in the string
            StringToUpper(userInputString);
            string ch = "" + x;
            x = StringToUpper(ch)[0];
            int f = userInputString.Length;
            for(int i = 0; i < f; i++) {
                if(userInputString.Substring(i, 1)[0] == x){index = i;} //sets index to last found index of the char
                else{/*Do nothing*/}
            } return index;
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            //throw new NotImplementedException("ConcatNames method not implemented.");
            StringTrim(fName);
            StringTrim(lName);
            return fName + " " + lName;
        }



    }//end of program
}
