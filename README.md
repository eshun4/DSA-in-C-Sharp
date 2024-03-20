# Data Structures, Concepts and Algorithms in C#

This repository holds code including Data Structures and OOP Concepts in C#.

## Section Introduction
- Hello World
- C#'s Main method
- Variables
- Console
- Conditional Statements
- Loops
- Comments
- Function Basics
- Basic C# syntax
- Modulus Operator
- Increment and Decrement Operators

### C#'s main method
- The entry point for C# code is called the Main() method.
- It is the first method that gets invoked.
- The main method is always included in every C# executable file.

- The keyword `static` in front of main means that the Main() method can be called without an object.
- The keyword `void` means this method does not return a value.
- `Main()` is the name of the method an be sure to spell it with a capital m or else it wont work. Since no access modifier was specified this method is private by default.

### Variables in C#
- Variables store dat in computer Programs.
- Each variable consisits of 2 things a type and a value.
-  Every programming language has variables.
- The rules are the syntax of the programming language.
- We use the `=` sign to set the value of  a variable. This is also referred to as the assignment operator.
- You can name a variable any name that fits the rules of the language.
- In C#, the name can only contain letters, digits, and the underscore character (_).
- No other special characters are allowed in variable names.
- The first character must be a letter or underscore.
- C# is case-sensitive with variable names.
- Can't use keyword as variable names in C#.
- The main types of variables are: integers, floats, strings, cgaracters, and booleans.
- Integers are any positive or negative number.
- Floating point numbers have decimal values with suffix "f".
- Strings are letters, word, or sentences inside of double quotes.
- Characters are one character, within single quotes.
- Booleans can either be `True` or `False`.

### C# Conditional Statement
- Conditional statement allows the computer to decide which possibilty to execute among one or more possibilities.

### C# Loops
- A loop executes a piece of code repeatedly until a condition is fulfilled.
- Many of the programs you write involve loops.
- Only write the code once but run it over and over.
- 2 main types of loops: for loops and while loops.
- A for loop iterates over elements until the specified element is reaches.
- A while loop executes unitl a specified condition is met.

### Function Basics.
- Functions, or methods are blocks of code that can be reused throughout the program.
- They make it easy to reuse without typing it over and over.
- We can make a change in the function body and not have to change  it everywhere the function is called.
- Parameters are variables that live only inside the scope of the function.

### Errors
- An error is an unexpected behaviour in the code.
- Syntax errors, Logic errors, and Runtime errors.
- Syntax Error - you typed something in the wrong.
- Logic Error - code does does something unexpected.
- Runtime error - happens while the program is running.

### C# Syntax Basics
- C# is a cases sensitive language.
- C# uses semi-colons to end lines of code.
- C# uses curly braces.
- Uses namespaces to avoid naming conflicts.
- C# code goes inside of classes.
- There are 4 main access modifiers in the C# programming language.
    1. `public` - This means it can be accessed by other classes that have a reference to this class.
    2. `protected` - This means it can only be accesed by this class and other classes.
    3. `private` - This means the only code that references it has to be in the same class.
    4. `internal` - Only code in the same assembly can run that variable or function. 

### Modulus Operator(%)
- This return the remainder between a modulo arithmetic operation.

### Increment and Decrement Operators
- `++` - Increment operator.
- `--` - Decrement operator.

### The `is` Operator
- It is used to check the type of a value.
- Help us avoid InvalidCastException.

### The `as` Operator
- Sometimes we are going to want to cast a variable of one type to another type.
- The as operator helps us to avoid an invalid cast exception.
- If the cast is valid, the as operator will return the object cast to the new type.
- If the cast is invalid, then the as operator will return null.

### Ternary Operator
- It is another way of re-writing conditional statements in C#.

### Null Coalescing operator
- variable = left operand ?? right operand.
- The null-coalescing operator will return the value of the left - hand operand if it is not null else it will evaluate to the right - hand operand and return the result.
- `??`.

### sizeOf Operator
- It is used to obtain the size, in bytes of compile time known resources.
- It reveals how many bytes of memory each type take up.
- This operator takes in a type and return an int.

### C# typeOf Operator
- Not really used in everyday programming.
- Reveals what is going on under the hood.
- ALlows us to get a type at compile time.
- Takes in C# type, return the .Net type.

### Operator Overloading
- Operator overloading is when we give a built-in C# operator special functinality for working with user-defined types. 
- Note: This is a concept that is mostly asked in a lot of interviews.

### C# Keywords and Contextual Keywords
- A keyword is a word reserved that has special meaning.
- Keywords are recognized by the compiler, and cannot be used as variable names.
- We can use them as variable names if we prefix them with the @symbol.
- Main keywords are keywords anywhere in C# code.
- A contextual keyword only has certain meaning in the context of the program.
- New keywords are usually added as contextual keywords so that they don't break legacy programs.








