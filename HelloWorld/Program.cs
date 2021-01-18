using System;

namespace HelloWorld
{  
    class Program
    {
        // static void Main(string region = null,
        //     string session = null,
        //     string package = null,
        //     string project = null,
        //     string[] args = null)
        // {
        //     switch (region)
        //     {
        //         case "intro":
        //             Intro();
        //             break;               
        //     }
        // }
    
        public static void Intro()
        {
            #region intro
            Console.WriteLine("Hello World!");
            #endregion
        }
    }             
}
