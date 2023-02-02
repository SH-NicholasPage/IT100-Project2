using System;

namespace IT100_Project2.Pages
{
    public partial class Index
    {
        private String helloWorld = String.Empty;

        protected override void OnInitialized()
        {
            helloWorld = "Hello, world!";
        }
    }
}
