// See https://aka.ms/new-console-template for more information
using System;

namespace Loops{
    class Project{
        static void Main(){
            List<string> collection = new List<string>(){"a", "b", "c"};

            for(int i = 0; i < collection.Count; i++){
                System.Console.WriteLine(collection[i]);
            }
        }
    }
}
