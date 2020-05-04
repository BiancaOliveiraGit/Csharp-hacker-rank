using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public class Actions
    {
        // My question was , can we have a function returned from a Dictionary
        // Define the dictionary and add the function reference as the value, using System.Action as the type:
        public Dictionary<string, System.Action> myActions = new Dictionary<string, System.Action>();
        public Dictionary<string, System.Func<int>> myFunc = new Dictionary<string, System.Func<int>>();
        public Actions()
        {
            myActions["myKey"] = TheAction;
            myFunc["myKey"] = TheFunction;
        }

        public void TheAction()
        {
            // your logic here
            Console.WriteLine("action function in dictionary has been called");
        }
        public int TheFunction()
        {
            // your logic here
            Console.WriteLine("function function in dictionary has been called");
            return 5;
        }
    }
    // call like this
    //Actions.myActions["myKey"]();
}
