using System;


namespace WeekOne {

    //bass class
    class Vehicle
    {

        public int tires = 4;

        public int getSpeed(int EngineType)
        {

            int topSpeed = EngineType * 10;

            return topSpeed;


        }

        private string calculator(String color)
        {
            String cost = (color == "red") ? "more" : "less";
            return cost;
        }
    public string getCost(string color)
        {


            return calculator(color);
        }

    }


    class testClass {

        static void Main () {
            Vehicle redCar = new Vehicle();  //color red v6
            Vehicle yellowCar = new Vehicle();  //color yellow v4

            Console.WriteLine(redCar.getCost("yellow"));
            Console.ReadLine();


        }
    }
}