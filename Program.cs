using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _11253003HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            PaintCar paintCar = new PaintCar();
            
            Console.WriteLine("Enter the command like..SIZEOFMATRIS+5_5+3+5_1+3+1+5_4+4+5_7+4+5_4+4+5_3+4+5_2+7+6 +8+0");
          
            string[] commandArray= Console.ReadLine().Split('+');
            string[,] tempMatris=paintCar.CreateRoom(commandArray[0].Trim());
            string tempWay="1";
            bool tempBool = false;
            int temp = 1; 
            for (int i = 1; i < commandArray.Length; i++)
            {
                if (commandArray[i].Trim().Contains("_"))
                {
                    string step = commandArray[i].Substring(2);
                    
                    paintCar.Move(step,tempWay,tempMatris,tempBool);
                }
                else
                { 
                    
                    switch (commandArray[i].Trim())
                    {
                        case "1":
                            tempBool=paintCar.Brush(tempMatris,commandArray[i]);
                            break;
                        case "2":
                           tempBool=paintCar.Brush(tempMatris,commandArray[i]);
                            break;
                        case "3":
                            temp = paintCar.Right(tempWay);
                            break;
                        case "4":
                            temp = paintCar.Left(tempWay);
                            break;
                        case "6":
                            paintCar.Jump(tempWay,tempMatris,tempBool);
                            break;
                        case "7":
                            temp= paintCar.TurnBack(tempWay);
                            break;
                        case "8":
                            paintCar.MatrisDisplay(tempMatris);
                            break;
                        case "0":
                            break;
                        default:
                            Console.WriteLine(commandArray[i]+"  This command not defined");
                            break;
                            
                    }
                    tempWay = temp.ToString(); 
                }
              
            }
         
           
             

        }
    }
}
