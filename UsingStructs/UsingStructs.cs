using System;

namespace UsingStructs
{
    enum WindowState
    {
        Quoted, Ordered, Manufactured, Shipped, Installed
    }
    struct Window
    {
        public double width;
        public double height;
        public String description;
        public WindowState state;
    }
    class UsingStructs
    {
        static void Main(string[] args)
        {
            Window win1;
            win1.width = 20;
            win1.height = 40;
            win1.description = "Glass with wood panels";
            win1.state = WindowState.Manufactured;
            PrintInfo(win1);
        }

        public static void PrintInfo(Window w)
        {
            Console.WriteLine($"The window's width is {w.width}");
            Console.WriteLine($"The window's height is {w.height}");
            Console.WriteLine($"The window's description is {w.description}");
            Console.WriteLine($"The window's account is {w.state}");
        }
    }
}
