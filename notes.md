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

---
End of document
