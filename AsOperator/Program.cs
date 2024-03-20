using System;

namespace ExampleProj{

    class Program {
    static void Main(String[] args){
        string s1 = "abc";
        object obj1 = s1;
        string s2 = obj1 as string;
        System.Console.WriteLine(s2);
    }

} 
}