## <img src="https://cdn4.iconfinder.com/data/icons/Hypic_Icon_Pack_by_shlyapnikova/64/plugin_64.png" width="32"> &nbsp; PostSharp.Community.HelloWorld 
An example add-in for [PostSharp](https://postsharp.net).

You can use the code in this repository as a base on which to build your own add-in for PostSharp.

*This is an add-in for [PostSharp](https://postsharp.net). It modifies your assembly during compilation by using IL weaving. The add-in functionality is in preview, and not yet public. This add-in might not work and is unsupported.*

## Creating an add-in
To create your PostSharp add-in using this template as a base, do the following:
1. Change "PostSharp.Community.HelloWorld" in all file and folder names to the name of your add-in.
2. Change the text "PostSharp.Community.HelloWorld" in all files to the name/namespace of your add-in.
3. Replace the `HelloWorldAttribute` in `PostSharp.Community.HelloWorld` with any attributes or classes that you want the user of your add-in to be able to access at IntelliSense time, build time and possibly runtime.
4. Update the class `HelloWorldTask` in `PostSharp.Community.HelloWorld.Weaver` with the code of your add-in.

Then, if you want to distribute the add-in as a NuGet package:
1. Update any other files, such as the `nuspec` file.
2. Use `nuget pack PostSharp.Community.HelloWorld.nuspec` to create a NuGet package from your add-in.
3. To use the add-in, the user just needs to add and install that NuGet package.

Or, if you want to distribute the add-in as a project or an assembly:
1. The user of the add-in must reference the NuGet package PostSharp.
2. The user of the add-in must reference the client assembly or the client assembly project (`PostSharp.Community.HelloWorld`).
3. The directory that contains the weaver assembly (`PostSharp.Community.HelloWorld.Weaver`) must be placed on the PostSharp search path with the MSBuild property `PostSharpSearchPath`. See the project `PostSharp.Community.HelloWorld.Tests` for an example on how to do this.


## Documentation of the HelloWorld add-in
This add-in adds the line `Console.WriteLine("Hello, world!");` at the beginning of each target method in your code.
 
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