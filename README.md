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
- Variables store date in computer Programs.
- Each variable consisits of 2 things a type and a value.
- Every programming language has variables.
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
    2. `protected` - This means it can only be accesed by this class and other sub-classes.i.e. once that inherit from the top class.
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
- If the cast is valid, the as operator will return the object cast to the new type.!
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

### Basic Built - In data types
- The basic built-in datatypes in C# are:
    1. Ints.
    2. Floats.
    3. Strings.
    4. Characters.
    5. Booleans.

- These are the building blocks of the language.

### Slicing strings into substrings
- Substring - a smaller inside of the main string. e.g. `"abc" - [a, b, c,ab, bc. abc]`.
- Substrings are continuous for example, "ac" is NOT one of the substrings.

### StringBuilder Class
- Strings are immutable.
- String modifications are really string creations.
- Bad approach for making lots of changes to a string, takes up too much program memory.
- Solution: Use the StringBuilder Class.
- Mutable sequence of characters.
- Sealed class, cannot be subclassed.

### Constuctors
- A constructor is a special method that is called when an object is created.
- It is used to initialize the object.
- It has the same name as the class and does not have a return type.
- Constructors can take parameters to initialize the object with specific values.
- If no constructor is defined, a default constructor is provided by the compiler.
- Constructors can be overloaded, meaning you can have multiple constructors with different parameters.

### Finalizers
- A finalizer is a special method that is called when an object is being garbage collected.
- It is used to clean up any resources that the object may be holding onto.
- It has the same name as the class, prefixed with a tilde (~), and does not have a return type or parameters.

### Properties
- Properties are a way to encapsulate data in a class.
- They provide a way to get and set the value of a private field.
- Properties are defined using the `get` and `set` accessors.
- They can have different access levels for getting and setting the value.
- Properties can also have validation logic in the `set` accessor to ensure that the value being set is valid.
- Read/write properties allow both getting and setting the value, while read-only properties only allow getting the value.

### Attributes
- Attributes are a way to add metadata to classes, methods, properties, and other elements in C#.
- They are defined using square brackets and can be applied to various elements in the code.
- Attributes can be used to provide additional information about the element, such as its purpose, behavior, or any other relevant details.
- Attributes can also be used to control the behavior of the compiler or runtime, such as marking a method as obsolete or indicating that a class should be serialized.
- The target of an attribute can be specified using the `AttributeUsage` attribute, which defines where the attribute can be applied (e.g., class, method, property, etc.).
- Attributews can be applied to assemblies, classes, methods, properties, fields, events, parameters, and more.
- Attributes can be used to control the behavior of the compiler or runtime, such as marking a method as obsolete or indicating that a class should be serialized.

### Anonymous Methods and Lambda Expressions
- Anonymous methods are methods without a name that can be defined inline.
- They are often used as event handlers or for short-lived operations.
- Lambda expressions are a concise way to define anonymous methods using the `=>` syntax.
- They can take parameters and return a value, making them useful for functional programming scenarios.
- Key points:
  - Anonymous methods are defined using the `delegate` keyword.
  - Lambda expressions use the `=>` syntax to define the method body.
  - Any variables in a lambda are not dealloacated from memory until the lambda is finished executing and is ready to be garbage collected.

### Method Overloading
- Method overloading is the ability to define multiple methods with the same name but different parameters.
- It allows you to create methods that perform similar operations but with different input types or numbers of parameters.
- The compiler determines which method to call based on the number and types of arguments passed.   
- Key points:
  - Method overloading is based on the method signature, which includes the method name and parameter types.
  - It allows for cleaner and more readable code by using the same method name for similar operations.
  - Overloaded methods can have different return types, but the return type alone does not distinguish them.
  - Method overloading can improve code maintainability by reducing the need for multiple method names for similar operations.
  - It is a way to achieve polymorphism in C#.
  - It allows to redefine a function in more than one way.

### Method Overriding
- Method overriding is the ability to provide a new implementation of a method in a derived class that is already defined in its base class.
- Child classes can override methods from their parent classes to provide specific behavior.
- The `override` keyword is used to indicate that a method is being overridden.
- The base class method must be marked with the `virtual` keyword to allow overriding.
- Key points:
  - Method overriding allows for polymorphism, where a derived class can provide its own implementation of a method defined in the base class.
  - It enables code reuse and customization of behavior in derived classes.
  - The base class method can still be called using the `base` keyword within the overridden method.
  - Method overriding is a key feature of object-oriented programming and allows for dynamic dispatch at runtime.
  - It is used to achieve runtime polymorphism in C#.

### Infinite Parameters in a Function
- C# allows you to define a method that can take a variable number of parameters using the `params` keyword.
- This allows you to pass an array of values to the method without explicitly creating an array.
- It has 16384 parameters.
- The `params` keyword must be the last parameter in the method signature.
### Optional Parameters
- C# allows you to define optional parameters in a method by providing default values for them.
- This allows you to call the method without specifying all the parameters, using the default values instead.
- Optional parameters must come after any required parameters in the method signature.
- You can use named arguments to specify only the optional parameters you want to provide values for.   
- Key points:
  - Optional parameters can simplify method calls by reducing the number of arguments needed.
  - They can improve code readability by allowing you to specify only the parameters that are relevant for a particular call.
  - Optional parameters can be used in combination with `params` parameters to provide flexibility in method calls.
  - They can be useful for methods that have many parameters, some of which may not always need to be specified.

### Extension Methods
- Extension methods allow you to add new methods to existing types without modifying their source code. 
- They are defined as static methods in a static class and use the `this` keyword to specify the type they extend.
- Extension methods can be called as if they were instance methods on the extended type.
- They are useful for adding functionality to types that you do not have control over, such as built-in types or types from third-party libraries.
- Key points:
  - Extension methods can improve code readability by allowing you to use existing types in a more natural way.
  - They can be used to add utility methods or helper functions to existing types.
  - Extension methods can be used with LINQ to provide additional functionality for querying collections.
  - They can be defined in separate namespaces and imported as needed, allowing for modular code organization.
  - Extension methods are resolved at compile time, so they do not incur any runtime overhead compared to regular instance methods.

### Asynchronous Functions
- Asynchronous functions allow you to perform operations without blocking the main thread, improving responsiveness in applications.
- They are defined using the `async` keyword and return a `Task` or `Task<T>` type.
- The `await` keyword is used to pause the execution of the method until the awaited task completes.
- Asynchronous functions can be used for I/O-bound operations, such as network requests or file operations, where waiting for a response can take time.
- Key points:   
  - Asynchronous functions can improve application performance by allowing other tasks to run while waiting for a long-running operation to complete.
  - They can be used to create responsive user interfaces in desktop and web applications.
  - Asynchronous functions can be combined with `Task.WhenAll` or `Task.WhenAny` to wait for multiple tasks to complete simultaneously.
  - They can be used with exception handling using `try-catch` blocks to handle errors that may occur during asynchronous operations.
  - Asynchronous programming is a key feature in modern C# development, especially for building scalable and responsive applications.

### Documenting Code
- Documenting code is important for maintaining and understanding code over time.
- C# provides a built-in way to document code using XML comments.   
- XML comments are special comments that start with `///` and can be used to provide information about classes, methods, properties, and other elements in the code.
- XML comments can include tags such as `<summary>`, `<param>`, `<returns>`, and `<remarks>` to provide detailed information about the code.
- Examples of documentation tools includer DocFX and Sandcastle, which can generate documentation from XML comments.
- Tags:
- `<summary>`: Provides a brief summary of the code element.
- `<param>`: Describes a parameter of a method or constructor.
- `<returns>`: Describes the return value of a method.
- `<remarks>`: Provides additional information or remarks about the code element.
- `<example>`: Provides an example of how to use the code element.
- `<exception>`: Describes an exception that may be thrown by the code element. 
- `<see>`: Provides a reference to another code element, such as a class or method.
- `<seealso>`: Provides a reference to related code elements.
- `<c>`: Indicates that the enclosed text is code.
- `<code>`: Indicates that the enclosed text is a code snippet.
- `<list>`: Creates a list of items, such as parameters or exceptions.
- `<item>`: Defines an item in a list.
- `<inheritdoc>`: Inherits documentation from a base class or interface.
- `<value>`: Describes the value of a property or field.
- `<typeparam>`: Describes a type parameter of a generic class or method.
- `<typeparamref>`: References a type parameter in the documentation.
- `<permission>`: Describes the permissions required to use the code element.
- `<include>`: Includes documentation from another XML file or code element.

### OOP COncepts
- What is OOP?
  - OOP stands for Object-Oriented Programming.
  - It is a programming paradigm that uses objects to represent data and behavior.
- Key concepts of OOP:
  - Classes: Blueprints for creating objects.
  - Objects: Instances of classes that encapsulate data and behavior.
  - Inheritance: Mechanism for creating new classes based on existing ones, allowing code reuse and extension.
  - Polymorphism: Ability to treat objects of different classes as if they are of the same type, enabling flexibility in code.
  - Encapsulation: Bundling data and methods together, restricting access to internal implementation details.
  - Abstraction: Hiding complex implementation details and exposing only the necessary features to the user.
  - Covariance:
    - Covariance allows a method to return a more derived type than the one specified in the base class.
    - It enables flexibility in method return types while maintaining type safety.
  - Partial Classes:
    - Partial classes allow a class definition to be split across multiple files.
    - This can be useful for organizing large classes or separating auto-generated code from user-defined code.
    - Requirements:
      - All parts of a partial class must be defined in the same assembly.
      - All parts must have the same access modifier (e.g., public, private).
      - All parts must have the same name and namespace.
  - Indexers:
    - Indexers allow objects to be indexed like arrays, providing a way to access elements using an index.
    - They are defined using the `this` keyword and can have parameters to specify the index.
    - Indexers can be used to create collections or data structures that behave like arrays.