using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clivingstone_qa_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputInt;
            string state = "enter width";
            Rectangle rectangle = new Rectangle();

            do
            {
                switch (state)
                {
                    case "enter width":
                        Console.WriteLine("Please enter Rectable Width");
                        userInput = Console.ReadLine();

                        if (validateInput(userInput))
                        {
                            userInputInt = convertToInt(userInput);
                            rectangle.SetWidth(userInputInt);
                            state = "enter length";
                        }
                        else
                        {
                            Console.WriteLine("Please enter a vlid integer that is greater than zero.");
                        }
                        break;

                    case "enter length":
                        Console.Clear();
                        Console.WriteLine("Please enter Rectable Length");
                        userInput = Console.ReadLine();

                        if (validateInput(userInput))
                        {
                            userInputInt = convertToInt(userInput);
                            rectangle.SetLength(userInputInt);
                            state = "main menu";
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a vlid integer that is greater than zero.");
                        }
                        break;

                    case "main menu":
                        Console.Clear();
                        Console.WriteLine("1. Get Rectangle Length");
                        Console.WriteLine("2. Change Rectangle Length");
                        Console.WriteLine("3. Get Rectangle Width");
                        Console.WriteLine("4. Change Rectangle Width");
                        Console.WriteLine("5. Get Rectangle Perimeter");
                        Console.WriteLine("6. Get Rectangle Area");
                        Console.WriteLine("7. Exit");
                        userInput = Console.ReadLine();

                        if (validateMenuInput(userInput))
                        {
                            if (convertToInt(userInput) == 1)
                            {
                                state = "get rectangle length";
                            }

                            else if (convertToInt(userInput) == 2)
                            {
                                state = "set rectangle length";
                            }

                            else if (convertToInt(userInput) == 3)
                            {
                                state = "get rectangle width";
                            }

                            else if (convertToInt(userInput) == 4)
                            {
                                state = "set rectangle width";
                            }

                            else if (convertToInt(userInput) == 5)
                            {
                                state = "get rectangle perimeter";
                            }
                            else if (convertToInt(userInput) == 6)
                            {
                                state = "get rectangle area";
                            }
                            else if (convertToInt(userInput) == 7)
                            {
                                state = "complete";
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid menu item.");
                            Console.WriteLine("");
                            Console.WriteLine("Press Enter to Continue...");
                            Console.ReadLine();
                        }
                        break;

                    case "get rectangle length":
                        string convertedLength;
                        int rectLength = rectangle.GetLength();
                        convertedLength = rectLength.ToString();
                        Console.Clear();
                        Console.WriteLine("the Rectangle Length is " + convertedLength);
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadLine();
                        state = "main menu";
                        break;

                    case "set rectangle length":

                        Console.Clear();
                        Console.WriteLine("Please enter a new length for the rectangle.");
                        userInput = Console.ReadLine();

                        if (validateInput(userInput))
                        {
                            userInputInt = convertToInt(userInput);
                            rectangle.SetLength(userInputInt);
                            state = "main menu";
                            Console.Clear();
                            Console.WriteLine("Rectangle length has been updated.");
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid integer that is greater than zero.");
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                        }
                        break;

                    case "get rectangle width":
                        string convertedWidth;
                        int rectWidth = rectangle.GetWidth();
                        convertedWidth = rectWidth.ToString();
                        Console.Clear();
                        Console.WriteLine("the Rectangle width is " + convertedWidth);
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadLine();
                        state = "main menu";
                        break;

                    case "set rectangle width":

                        Console.Clear();
                        Console.WriteLine("Please enter a new width for the rectangle.");
                        userInput = Console.ReadLine();

                        if (validateInput(userInput))
                        {
                            userInputInt = convertToInt(userInput);
                            rectangle.SetWidth(userInputInt);
                            state = "main menu";
                            Console.Clear();
                            Console.WriteLine("Rectangle width has been updated.");
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid integer that is greater than zero.");
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                        }
                        break;

                    case "get rectangle perimeter":
                        string convertedPerimeter;
                        int rectPerimeter = rectangle.GetPerimeter();
                        convertedPerimeter = rectPerimeter.ToString();
                        Console.Clear();
                        Console.WriteLine("the Rectangle's perimeter is " + convertedPerimeter);
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadLine();
                        state = "main menu";
                        break;

                    case "get rectangle area":
                        string convertedArea;
                        int rectArea = rectangle.GetArea();
                        convertedArea = rectArea.ToString();
                        Console.Clear();
                        Console.WriteLine("the Rectangle's area is " + convertedArea);
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadLine();
                        state = "main menu";
                        break;

                    case "complete":
                        break;

                    default:
                        break;
                }
            } while (state != "complete");

        }        

        static int convertToInt(string str)
        {
            int returnedInt;
            Int32.TryParse(str, out returnedInt);

            return returnedInt;
        }


        static bool validateMenuInput(string input)
        {

            if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool validateInput(string input)
        {
            int inputInt;
            bool validString;
            bool isNumber;

            if (int.TryParse(input, out inputInt))
            {
                isNumber = true;

                if (inputInt > 0)
                {
                    validString = true;
                }
                else
                {
                    validString = false;
                }
            }

            else
            {
                validString = false;
                isNumber = false;
            }

            if (isNumber && validString)
            {
                return validString;
            }

            else
            {
                return false;
            }
        }
    }
}
