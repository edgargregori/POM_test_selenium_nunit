


# Setup project MSTest(.NET CORE) C# Linux(Ubuntu18.04).
	
> 	Initilize project

		$ mkdir POM_test_selenium_nunit
		$ cd POM_test_selenium_nunit
		$ dotnet new solution
		$ mkdir TestSeleniumNunit
		$ cd TestSeleniumNunit
		$ dotnet new mstest
		$ cd ..
		$ dotnet sln add TestSeleniumNunit
		

##	Install Dependencies:
		
>		Download chromedriver into TestSeleniumNunit/bin/Debug/netcoreapp2.2/
		+ $ wget https://chromedriver.storage.googleapis.com/78.0.3904.11/chromedriver_linux64.zip
		+ $ unzip chromedriver_linux64.zip 

>		Into dir TestSeleniumNunit/
 		* $ dotnet add package Selenium.WebDriver --version 3.141.0
		* $ dotnet test && dotnet build
		* $ dotnet add package Microsoft.NET.Test.Sdk 
		* $ dotnet add package Nunit3TestAdapter  
		* $ dotnet add package NUnit 

>		Open folder with Visual Studio Code	
		- Inside VSCode:
		- Press Ctrl+P to launch VS Code Quick Open
		- Paste "ext install ms-vscode.csharp" into the little dialog.

##	Running Tests:
		>Run one by one the unit test cases, from TestSeleniumNunit/AllTestsClass.cs.


##	Refs:
> 	- https://swimburger.net/blog/dotnet/how-to-ui-test-using-selenium-and-net-core-on-windows-ubuntu-and-maybe-macos
>	- https://blog.thecodewhisperer.com/permalink/from-zero-to-nunit-with-visual-studio-code

