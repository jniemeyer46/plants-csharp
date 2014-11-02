## plants-csharp

This solution is set up to work with .NET 4.0 by default so that it can be opened with Visual Studio 2010, 2012, or 2013.  

If you would like to utilize .NET 4.5, you will need to make a simple modification to both projects: Library and Plants.  To use .NET 4.5, right-click on the `Library` project and go to `Configuration Properties->General->Platform Toolset` and change `Visual Studio 2010 (v100)` to `Visual Studio 2013 (v120)`.  Next, right-click on the `Plants` project and go to `Application->Target Framework` and change `.NET Framework 4.0` to `.NET Framework 4.5`.  Rebuild the solution and you're good to go.