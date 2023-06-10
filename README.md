
The project is built on C#, Selenium, Nunit. 
I could use Java as well, It shares lots of common practices & approach such as
-	Manage packages & libs: Maven (java) vs Nuget Management (C#)
-	Control test flow: TestNG (java) vs Nunit (C#)
-	Selenium libs are almost the same in Java & C#
The repos contain 2 projects.
CoreFrameWork: I built it as a lightweight framework (Control test flow with Nunit, provide keyworks which used in TestProject, Manage driver lifecycle)
TestProject: I follow basic rules for POM design

The project is built on C#, Selenium, Nunit. 
I could use Java as well, It shares lots of common practices & approach such as
-	Manage packages & libs: Maven (java) vs Nuget Management (C#)
-	Control test flow: TestNG (java) vs Nunit (C#)
-	Selenium libs are almost the same in Java & C#
To run the test:
-	install Visual Studio (2019)
-	Install .Net lib (.NET Standard 2.1 and .NET Core 3.1 )
-	Clone the test repos: You will get 2 folders (AutomationTest_SMG and CoreFrameWork)
-	Go to AutomationTest_SMG and open AutomationTest_SMG.sln file with Visual Studio
-	Open Test Explore window: Go to Test>Test Explore then you will see 3 test cases (NUnit format) and run it
-	In case you want to change the para to simulate different test condition, go to SearchForPageContain.csclass and modify them.
List of libs I used in this repos
-	    <PackageReference Include="DotNetSeleniumExtras.WaitHelpers" Version="3.11.0" />
-	    <PackageReference Include="NUnit" Version="3.12.0" />
-	    <PackageReference Include="NUnit3TestAdapter" Version="3.16.1" />
-	    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.5.0" />
-	    <PackageReference Include="Selenium.Support" Version="4.9.1" />
-	    <PackageReference Include="Selenium.WebDriver" Version="4.9.1" />
-	    <PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="114.0.5735.9000" />


