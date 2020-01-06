using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team_20
{
    public enum Days { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    public class BasicUser
    {
        private string firstName;
        private string lastName;
        private string id;
        private int age;
        private string userName;
        private string password;

        const int ID_SIZE = 9;
        // ------------------------------------------ Class Properties ------------------------------------------ //
        public string FirstName // Class Property - implements set and get for a private class variable. 
        {
            get { return this.firstName; } // Access out of the class: Person p = new Person(...); p.FirstName;
            set { this.firstName = value; } // Access out of the class: Person p = new Person(...); p.FirstName = "Mai";
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Username
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        // ------------------------------------------ Class Constructors ------------------------------------------ //
        public BasicUser() : this(null, null, null, 0, null, null) { }// Default Constructor - No parameters

        public BasicUser(string _firstName, string _lastName, string _id, int _age, string _userName, string _password) // Custom Constructor - All parameters
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.id = _id;
            this.age = _age;
            this.userName = _userName;
            this.password = _password;
        }

        // ------------------------------------------ Class Functions ------------------------------------------ //
        public bool EnterIntInput(string name) // For first and last name input, also checks if the input contains only chars
        {
            return AreAllChars(name);
                
            /*while (AreAllChars(input) == false)
            {
                Console.WriteLine("Error, your input doesn't contain chars-only, try again please.\n");
                Console.WriteLine("Enter {0} please:\n", name);
                input = EnterStringInput();
            }
            return input;
            */
        }

        public bool EnterUsernamePassInput(string name) // For username and password input, also checks if the input contains only chars or ints
        {
            return AreAllCharsOrInts(name);
            /*Console.WriteLine("Enter {0} please:\n", name);
            string input = EnterStringInput();
            while (AreAllCharsOrInts(input) == false)
            {
                Console.WriteLine("Error, your input doesn't contain only chars or ints, try again please.\n");
                Console.WriteLine("Enter {0} please:\n", name);
                input = EnterStringInput();
            }
            return input;*/
        }
        public bool EnterIDInput(string id) // For ID input, also checks if the input contains only ints and if the input contains 9 digits
        {
            return (AreAllInts(id) && id.Count() == 9);
            /*Console.WriteLine("Enter ID please(Exactly {0} digits):\n", ID_SIZE);
            string input = EnterStringInput();
            while (AreAllInts(input) == false || input.Count() != 9)
            {
                if (AreAllInts(input) == false)
                    Console.WriteLine("Error, your input doesn't contain only integers, try again please.\n");
                else
                    Console.WriteLine("Error, the ID you entered contains {0} digits, try again please.\n", input.Count());
                Console.WriteLine("Enter ID please(Exactly {0} digits):\n", ID_SIZE);
                input = EnterStringInput();
            }
            return input;
            */
        }

        public bool EnterAgeInput(int age) // For age input, also checks if the input contains only ints
        {
            return (age >= 1);
            /*Console.WriteLine("Enter age please:\n");
            int input = EnterIntInput();
            while (input < 1)
            {
                Console.WriteLine("Error, the age you entered isn't positive, try again please.\n");
                Console.WriteLine("Enter age please:\n");
                input = EnterIntInput();
            }
            return input;
            */
        }
        public String EnterStringInput()
        {
            string stringInput = null;
            bool flag = false;
            while (flag == false)
            {
                try
                {
                    stringInput = Console.ReadLine();
                    flag = true;
                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine("Error, your input isn't string(chars) ({0}), try again please.\n", ex.GetType().ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unknown error ({0}), try again please.\n", ex.GetType().ToString());
                }
            }
            return stringInput;
        }
        public int EnterIntInput()
        {
            int intInput = -1;
            bool flag = false;
            while (flag == false)
            {
                try
                {
                    intInput = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine("Error, your input isn't an integer({0}), try again please.\n", ex.GetType().ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unknown error ({0}), try again please.\n", ex.GetType().ToString());
                }
            }
            return intInput;
        }
        public float EnterFloatInput()
        {
            float floatInput = -1;
            bool flag = false;
            while (flag == false)
            {
                try
                {
                    floatInput = float.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine("Error, your input isn't a float({0}), try again please.\n", ex.GetType().ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unknown error ({0}), try again please.\n", ex.GetType().ToString());
                }
            }
            return floatInput;
        }
        public bool AreAllChars(String str)
        {
            return str.All(char.IsLetter);
        }
        public bool AreAllInts(String str)
        {
            return str.All(char.IsDigit);
        }
        public bool AreAllCharsOrInts(String str)
        {
            return str.All(char.IsLetterOrDigit);
        }

        /*public virtual void EnterPersonDetails()
        {
            this.firstName = EnterNameInput("first-name");
            this.lastName = EnterNameInput("last-name");
            this.id = EnterIDInput();
            this.age = EnterAgeInput();
            this.userName = EnterUsernamePassInput("username");
            this.password = EnterUsernamePassInput("password");
        }*/
        public virtual void PrintPersonDetails()
        {
            Console.WriteLine("First-name: {0}\n", firstName);
            Console.WriteLine("Last-name: {0}\n", lastName);
            Console.WriteLine("ID: {0}\n", id);
            Console.WriteLine("Age: {0}\n", age);
            Console.WriteLine("Username: {0}\n", userName);
            Console.WriteLine("Password: {0}\n", password);
        }
    }
}
