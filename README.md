## <img src="https://cdn4.iconfinder.com/data/icons/Hypic_Icon_Pack_by_shlyapnikova/64/plugin_64.png" width="32"> &nbsp; PostSharp.Community.HelloWorld 
An example add-in for [PostSharp](https://postsharp.net).

You can use the code in this repository as a base on which to build your own add-in for PostSharp.

## Creating an add-in
TODO Create documentation.
## Documentation of the HelloWorld add-in
This add-in adds the line `Console.WriteLine("Hello, world!")` at the beginning of each target method in your code.
 
#### Example
Your code:
```csharp
[HelloWorld]
static int ReturnTheAnswer() 
{
    return 42;
}
```
What gets compiled:
```csharp
static int ReturnTheAnswer() 
{
    Console.WriteLine("Hello, world!");
    return 42;
}
```
#### Installation (as a user of this plugin)
1. Install the NuGet package: `PM> Install-Package PostSharp.Community.HelloWorld`
2. Get a free PostSharp Community license at https://www.postsharp.net/essentials
3. When you compile for the first time, you'll be asked to enter the license key.

#### How to use
Add `[HelloWorld]` to the methods or classes where you want it to apply, or apply it to the entire assembly with [multicasting](https://doc.postsharp.net/attribute-multicasting).

#### Copyright notices
Published under the MIT license.

* Copyright © PostSharp Technologies
* Icon by Shlyapnikova, https://www.iconfinder.com/icons/51412/24_plugin_icon, CC BY 3.0