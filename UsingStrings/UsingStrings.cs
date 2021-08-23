using System;

namespace UsingStrings
{
    class UsingStrings
    {
        
        static void Main(string[] args)
        {
            string[] sentence = "My mother made me munch my mangoes too.".Split(' ');
            string noSpace = "";
            foreach (string x in sentence)
            {
                noSpace += x;
            }
            Console.WriteLine($"The string without spaces is: {noSpace}");


            string sentence2 = "This is a lovely sentence to test if I can take out the spaces in em!";
            string sentWithoutSpace = sentence2.Replace(" ", "");
            Console.WriteLine($"This is the sentence without spaces: {sentWithoutSpace}");
        }
    }
}
