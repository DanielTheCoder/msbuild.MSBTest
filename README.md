MSBuild.MSBTest
===============

MSBTest is a simple testing framework for testing MSBuild scripts


How to use  
---------------------

- Add a new project to your solution by using the [MSBuild-project-template](http://visualstudiogallery.msdn.microsoft.com/4b75d0cc-b693-4c1c-8105-fbaeb0714b03)
- Install nuget package [MSBuild.MSBTest](https://www.nuget.org/packages/MSBuild.MSBTest)

The nuget package will install the following files to your project  

- Properties/MSBTest.props
- readme/MSBTest.readme.txt

## project structure

Based on conventions MSBTest will find tests, extensions and the collection of scripts which should be test.  
The typicall folder structure will look like similar to this:  
```
project  
|-Properties  
|-|-MSBTest.props
|-extensions
|-|-imports.targets
|-readme
|-|-MSBTest.readme.txt
|-src
|-|-imports.targets
|-tests  
|-|-sample-test-suite  
|-|-|-sample.test.targets
|-|-test.import  
```
### Properties/MSBTest.props
Global settings to control the behaviour of MSBTest like tracing or additional project specific configurations.

### extensions/imports.targets
If a folder extensions with a containing imports.targets file is present you'll can use this to add custom MSBuild tasks of inline MSBuild tasks to your testsuite.
Import with
``` 
<Import Project="$(ExtensionsImports)" Condition="Exists('$(ExtensionsImports)')" />
```  
  
### readme/MSBTest.readme.txt
Readme with some additional information about available variables

### src/imports.targets
If a folder src with a containing imports.target file is present you'll can use this to import custom MSBuild targets, projects and props.
Import with
```
<Import Project="$(SourceImports)" Condition="Exists('$(SourceImports)')"/>
```

### tests/**/*.test.targets
Files named *.test.targets placed in the folder tests will be identified as test scripts.
These files will be excecuted during build time.
Contributing
------------
If you are interested in contributing,  
  
1. Get a Github account  
1. Fork the project  
1. Make your feature addition or bugfix. Please also update the [changelog](https://github.com/DanielTheCoder/MSBuild.MSBTest/blob/master/changelog.txt).  
1. Send me a pull request via GitHub  
