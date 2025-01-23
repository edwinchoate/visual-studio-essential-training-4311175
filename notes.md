# Notes

Install different versions of .NET

* Visual Studio Installer -> Modify -> Individual components -> .NET

Supported testing frameworks:

* NUnit
* xUnit
* MSTest

Node.js and npm are supported in the ASP.NET web tools

_Browser Link_ 

_Live Share_ - realtime collaboration, with simultaneous debugging, shared terminals

_Azure functions_ - serverless computing features

> A solution is a container of one or more projects

Anatomy of a solution file:

* Visual Studio versions
    * Recommended version
    * Minimum version
* List of Projects
* Build configurations

Example solution file:

```
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.28917.181
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "WpfApp1", "WpfApp1\WpfApp1.csproj", "{6B9C050B-F20D-4664-A16B-EBFB0A52D08A}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ToolsLib", "ToolsLib\ToolsLib.csproj", "{4E16F782-DD69-489C-B775-91A760834246}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{6B9C050B-F20D-4664-A16B-EBFB0A52D08A}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{6B9C050B-F20D-4664-A16B-EBFB0A52D08A}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{6B9C050B-F20D-4664-A16B-EBFB0A52D08A}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{6B9C050B-F20D-4664-A16B-EBFB0A52D08A}.Release|Any CPU.Build.0 = Release|Any CPU
		{4E16F782-DD69-489C-B775-91A760834246}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{4E16F782-DD69-489C-B775-91A760834246}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{4E16F782-DD69-489C-B775-91A760834246}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{4E16F782-DD69-489C-B775-91A760834246}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {E4F6A60E-F5D8-4AD4-A84E-AA044D6E51D0}
	EndGlobalSection
EndGlobal
```

If you open a `.csproj` file, Visual Studio will either 

A. Open the whole solution associated with that project (and all the other associated projects)
B. Create a temporary solution file for that project

> Visual Studio always works with a Solution context

* Solution
    * _Project_ - a container for everything needed to compile an executable or library.
        * _Reference_ - referenced libraries and packages. Dependencies

MSBuild - the build engine for Visual Studio

> The contents of the Solution Explorer, References, Class view, etc. are populated from the _Project file_ (ex: .csproj)

* Project files automatically update themselves as files change
* The build engine reads the Project file to receive compiler instructions and build settings.
* Other systems like CICD pipelines, Azure DevOps, etc. read the Project file 

The References in the Project file XML can also be viewed in the Solution Explorer

```XML 
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Net.Http" />
    <Reference Include="System.Xaml">
      <RequiredTargetFramework>4.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
  </ItemGroup>
``` 

_Startup project_ - You can change this via Right-click -> Set as Startup Project

_Output type_ - This tells you what type the project is: Console app vs. Windows Application vs. Class Library, etc. You can view this at the project level: Right-click on Project -> Properties -> Output type

Put a panel back in its original position: CTRL+Double-click on title bar

You can Right-click -> Properties on anything in the Solution Explorer

Add a new/existing Project to a Solution: Right-click on Solution (in Solution Explorer) -> Add -> New/Existing Project

Folder View

* in VS, you can switch to a much more literal view of the files in the filesystem in the Solution Explorer
* Solution Explorer > [Icon] Switch between solution and available views > Folder View
* To see hidden files (e.g. /obj, /bin), click on [Icon] Show All Files at the top of the Solution Explorer

There a Collapse All button at the top of Solution Explorer

_Right-click -> Scope to This_ - This sets the top-level context of the Solution Explorer to any Project/folder. You can press the little home or little back button at the top of Solution Explorer to undo.

_Window_ > _Reset Window Layout_ sets the Visual Studio layout back to default factory settings. You can also Save and Apply your own windows layouts.

_CodeLens_ - the feature that displays "X references", etc. inline in your code. You can turn this off.

You can Import/Export all of your VS settings

* Tools > Import and Export Settings...
    * Import selected environment settings
    * Export selected environment settings
    * Reset all settings
    * `.vssettings` file

`F9` adds a breakpoint to the current line (where the cursor is)

CTRL+Q launch the Settings search

Region syntax

```C#
#region MyRegionName
    ...
#endregion
```

**Stub interface implementation** You can stub out all of the implemented methods of an interface in one click with Quick Actions (lightbulb icon)

**Preview method signatures** CTRL+SHIFT+SPACEBAR inside of the parentheses of a method launches a flyout that lets you cycle through all of the method signatures for that method

**Automatically complete symbol** CTRL+SPACEBAR finishes typing an incomplete symbol. This feature is called Complete Word

**Refactor order of parameters** (with cursor in method parentheses), Right-click -> Quick Actions and Refactorings -> Change signature... To change the order of the params in a method signature, and have that change be reflected everywhere in the code.

A Code Snippet is a small bit of generate code that results from a shortcut code (ex: `cw`, `ctor`, `for`). 

Examples of useful code snippets: 

```C#
// `cw` generates: 
Console.WriteLine();

// `ctor` generates: 
public MyClass () 
{

}

// `for` generates: 
for (int i = 0; i < length; i++)
{

}
```

Code snippets are also interactive, so you can tab through the code generated to fill in the pertinent variables and values. 

See all of the Code Snippets in the system: 

* Tools -> Code Snippets Manager

**Automatic Formatting (Code Style)**

* You can auto apply style rules based on rules defined in settings:
    * Format entire document: Edit > Advanced > Format Document (CTRL+K, CTRL+D)
    * Format selection: Edit > Advanced > Format Selection (CTRL+K, CTRL+F)
* You can set the style rules in: Tools > Options > Text Editor > C# > Code Style

_Code Style_

Visual Studio lets you systematically enforce subjective code style rules. 

* Tools > Options > Text Editor > C# > Code Styles > General
    * These are rules about when to use things like `var`, parentheses, etc. 
    * Ex: Namespace declarations Block scope Refactoring only
* Tools > Options > Text Editor > C# > Code Styles > Naming
    * These are rules about naming conventions
    * Ex: Non-Field Members Pascal Case Suggestion
* You can set the different level of enforcement of these rules of 4 options:
    1. Refactoring Only
    2. Suggestion
    3. Warning
    4. Error
* Visual Studio lets you export all of these style decisions as a single `.editorconfig` file
    * .editorconfig | [editorconfig.org](https://editorconfig.org)
        * A format supported by many IDEs
        * You can use a .editorconfig file by placing it in your project's root directory
        * Visual Studio applies the styles defined by .editorconfig upon Save of a file
        * The .editorconfig file from the [dotnet/runtime project](https://github.com/dotnet/runtime/blob/main/.editorconfig) is a gold standard that Microsoft uses in their own documentation

_Class Designer_

Visual Studio has a tool for class diagrams, _Class Designer_

* To install: Visual Studio Installer -> Individual components -> search for Class Designer
* Add a new class diagram to a project: Right-click (on Project) -> Add -> New item... -> search "diagram" -> "Class Diagram"
* `.cd` file extension

_Navigating code_

Right-click -> _Go to Definition_ is very useful

Right-click -> _Peek Definition_ shows a code preview in a flyout without navigating away from the current code file 

Right-click -> _View Call Hierarchy_ shows a tree view of a given method/property and all of the code that calls that object, with the code that call those methods nested underneath, and so on. 

Right-click -> _Find All References_ finds everywhere where a Class (for instance) is being used

CTRL+T launches _Code Search_

CTRL+Q launches _Feature Search_

---
End of document
