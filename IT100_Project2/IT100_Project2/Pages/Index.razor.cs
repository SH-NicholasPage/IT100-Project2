using System;

namespace IT100_Project2.Pages
{
    public partial class Index
    {
        private String helloWorld = String.Empty;

        //Consider this method to be your Main() method.
        protected override void OnInitialized()
        {
            helloWorld = "Hello, world!";
            //You will not be able to see Console.WriteLine()s in the terminal anymore.
            //  To view Console.WriteLine()s, when the application is running in a browser, hit F12 (or FN + F12),
            //  then go to the Console tab in the browser dev console.
            Console.WriteLine("Testing, testing, 1 2 3.");
        }
    }
}
