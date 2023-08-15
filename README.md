# CommandLineParse
Parser for create CLI applications using Attributes on Methods to declare commands

## Usage

### Define a class to use as a **Command Group** and define a method to use a a **Command**
```c#
[CommandGroup("printer")]
class Printer
{
    [Command("print")]
    void Print([CommandParameter] message)
    {
        Console.WriteLine(message);
    }
}
```

### Use the CommandParse.Run() method to parse and run the command
```c#
var cmd = "printer print \"Hello World\"";
await CommandParser.Run(cmd);
```
