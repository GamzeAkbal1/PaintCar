using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _11253003HW2
{
    class PaintCar
    {
        Point Car = new Point(0,0); 
      
       
         
        public string[,] CreateRoom(string xx="1") 
        { 
            int x=Convert.ToInt32(xx);
            string[,] Room = new string[x,x];

            for (int i = 0; i<x; i++)
            {
                for (int j = 0; j<x; j++)
                {
                    Room[i, j] = "0";
                }
                
            }
            return Room;
        }
        public void MatrisDisplay(string[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine();
            }
        }

        public bool Brush(string[,] array,string x = "2") 
        {
            if (x == "1")
            {
                array[Car.X, Car.Y] = "*";
                return true; }
               
            else
                return false;
        }

        public int Left(string way="1") 
        {
            int direction = Convert.ToInt16(way);
            int tempWay;
            if (direction == 1)  
                tempWay = 3;
            else if (direction == 2) 
                tempWay = 1;
            else if (direction == 3)
                tempWay = 4;
            else 
                tempWay = 2;
            return tempWay;
        }
        public int Right(string way = "1") 
        {
            int direction = Convert.ToInt16(way);
            int tempWay;
            if (direction == 1)
                tempWay = 2;
            else if (direction == 2)
                tempWay = 4;
            else if (direction == 3)
                tempWay = 1;
            else
                tempWay = 3;
            return tempWay;
        }
        public void Move(string steps,string way,string[,]array,bool brushh) 
        {   int step=Convert.ToInt16(steps); 
            if (way == "1")
            {

                for (int i = 0; i < step; i++) 
                {
                    if (brushh) 
                    {
                        Car.Y++; 
                        array[Car.X, Car.Y] = "*"; 
                    }
                    else 
                    {
                        Car.Y++;
                    }
                    if (Car.Y > array.GetLength(1) - 1) 
                    {
                        Car.Y =Car.Y % array.GetLength(1);
                    }
                }


            }
            else if (way == "2") 
            {

                for (int i = 0; i < step; i++)
                {
                    if (brushh)
                    {
                        Car.X++;
                        array[Car.X, Car.Y] = "*";
                        
                        
                    }
                    else
                    {
                        Car.X++;
                    }
                    if (Car.X > array.Length - 1) 
                    {
                        Car.X = Car.X % array.GetLength(0);
                    }
                }


            }
            else if (way == "3") 
            {
                while (step != 0)
                {
                    if (brushh)
                    {
                        Car.X--;
                        array[Car.X, Car.Y] = "*";
                    }
                    else
                    {
                        Car.X--;

                    }
                    if (Car.X < 0)
                    {
                        Car.X = array.GetLength(0) - 1;
                    }
                    step--;
                }
            }
            else
            {

                while (step != 0) 
                {
                    if (brushh)
                    {
                        Car.Y--;
                        array[Car.X,Car.Y] = "*";
                    }
                    else
                    {
                        Car.Y--;

                    }
                    if (Car.Y < 0)
                    {
                        Car.Y = array.GetLength(1) - 1;
                    }
                    step--;
                }
            }
        }
        public int TurnBack(string way="1") 
        {
            int direction = Convert.ToInt16(way); 
            int tempWay;
            if (direction == 1) 
                tempWay = 4;
            else if (direction == 2)
                tempWay = 3;
            else if (direction == 3)
                tempWay = 2;
            else
                tempWay = 1;
            return tempWay;
        }
        public bool Jump(string way, string[,] array, bool brushh) 
        {
            if (brushh)  
                brushh = false;
            if (way == "1")
            {

                for (int i = 0; i < 3; i++) 
                {
                   
                    Car.Y++;
                   
                    
                    
                    if (Car.Y > array.GetLength(1) - 1)
                    {
                        Car.Y = Car.Y % array.GetLength(1);
                    }
                }


            }
            else if (way == "2")
            {

                for (int i = 0; i < 3; i++)
                {
                    
                        Car.X++;
                        


                    
                   
                    if (Car.X > array.Length - 1)
                    {
                        Car.X = Car.X % array.GetLength(0);
                    }
                }


            }
            else if (way == "3")
            {
                for (int i = 0; i < 3; i++)
                {
                    Car.X--;
                    
                    if (Car.X < 0)
                    {
                        Car.X = array.GetLength(0) - 1;
                    }
                }
                    
            }
            
            else
            {

                for (int i = 0; i < 3; i++)
                {
                    Car.Y--;
                    
                    if (Car.Y < 0)
                    {
                        Car.Y = array.GetLength(1) - 1;
                    }
                }             
                
            }
            return brushh; 
        }


    }
}
