# VariableDefinitionAndTypes

This project is a basic introduction to defining variables and understanding their types in C#. It includes examples of different variable types, such as `int`, `string`, `double`, `bool`, `char`, and demonstrates how to work with `var` and `const`. Additionally, it covers basic type conversion techniques.

## Features
- Declaration of variables in C#.
- Understanding and using basic data types.
- Examples of implicit (`var`) and constant (`const`) variables.
- Demonstrating type conversion methods.

## Code Example
Here is a snippet of the code:
```csharp
int age = 25;
string name = "John Doe";
double height = 5.9;
bool isStudent = true;
char grade = 'A';

var message = "Hello, World!";
const double Pi = 3.14159;

string ageAsString = age.ToString();
int stringToInt = int.Parse("100");
