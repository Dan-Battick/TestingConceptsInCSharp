using System;

namespace UsingEnums
{
    enum TrafficLight
    {
        Green,
        Amber,
        Red
    }
    class UsingEnums
    {
        static void Main(string[] args)
        {
            TrafficLight light = TrafficLight.Green;
            Console.WriteLine(light);
        }
    }
}
