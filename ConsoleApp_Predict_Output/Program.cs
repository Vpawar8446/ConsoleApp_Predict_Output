using System;

namespace ConsoleApp_Predict_Output
{
    class Car
    {
        public int Model;
        public Car(int a)
        {
            Model = a;
        }
        public void Display_Model()
        {
            Console.WriteLine(Model);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           
                Car Ford = new Car(22);
                Ford.Model = 10;
                Car BMW = Ford;
                BMW.Display_Model(); //10
                Ford.Display_Model(); //10
            

        }
    }
}
