using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string GetHelloWorld(string user)
        {
            return String.Format("Hello {0}", user);
        }

        public string GetHelloWorld()
        {
            return "Hello world";
        }
    }
}
