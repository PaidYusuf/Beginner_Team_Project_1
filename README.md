Hello team,
I hope all of you doing well.
The project is currently configured to use C# 7.3 and targets the .NET Framework 4.7.2. This means that we can utilize features available in C# 7.3 while ensuring compatibility with the specified framework version.
Please make sure to keep this in mind when writing code and using libraries, as it will help us maintain consistency and avoid compatibility issues.

In this project, our primary goal is to implement a simple console application that demonstrates basic C# features and .NET functionalities. We will be focusing on:
1. Understanding C# syntax and structure.
2. Implementing basic data types and control structures.
3. Creating methods to encapsulate functionality.
4. Getting familiar with the .NET Framework libraries.
5. Getting used to team collaboration practices, such as version control and code reviews.

For our first project, I will write our distribution of tasks and assign roles here and on our project management tool. Each team member will be responsible for specific parts of the application, and we will collaborate to integrate our work into a cohesive project.
# Beginner Team Project 1
The distribution of roles for the project is outlined below:
    Date_Helper ==>     Burak Furkan Köken
    Random_Fun_Tool ==> Melek Akyol
    Simple_Math_Tool ==>Yusuf Aslan
    Text_Analyzer ==>   Kamal Kamalov
    Unit_Converter ==>  Ahmet Ziya

Explanation of the Project Features:
1. **Date_Helper**: This feature will provide a better understanding on dates. You will be responsible for implementing: 
    a. [days_until_date(target_date)](#days_until_date) - Determines calculates the number of days until a specified date.  **RETURNS AN INTEGER.**
    b. [is_leap_year(year)](#is_leap_yearyear) - Determines if a given year is a leap year. **RETURNS A BOOLEAN.**
    
2. **Random_Fun_Tool**: This feature will include various fun and random functionalities. You will be responsible for implementing:
    a. [roll_dice()](#roll_dice) - Simulates rolling a dice and returns a random number between 1 and 6.)  **RETURNS AN INTEGER.**
    b. [coin_flip()](#coin_flip) - Simulates flipping a coin and returns either "Heads" or "Tails".)    **RETURNS A STRING.**
    c. [generate_random_password(length)](#generate_random_passwordlength) - Generates a random password of a specified length using letters and digits. **RETURNS A STRING.**
      
3. **Simple_Math_Tool**: This feature will provide basic mathematical operations. You will be responsible for implementing:
    a.[basic_calculator(a, b, operator)](#basic_calculatora-b-operator) - Performs basic arithmetic operations (addition, subtraction, multiplication, division) based on the provided operator. **RETURNS A DOUBLE.**
    b.[square_root(n)](#square_rootn) - Calculates the square root of a given number. **RETURNS A DOUBLE.**
    c.[factorial(n)](#factorialn) - Calculates the factorial of a given number. **RETURNS AN INTEGER.**
 
4. **Text_Analyzer**: This feature will analyze text input. You will be responsible for implementing: 
    a.[count_words(text)](#count_wordstext) - Counts the number of words in a given text. **RETURNS AN INTEGER.**
    b.[count_letters(text)](#count_letterstext) - Counts the number of letters in a given text. **RETURNS AN INTEGER.**
    c.[is_palindrome(text)](#is_palindrometext) - Checks if a given text is a palindrome (reads the same forwards and backwards).) **RETURNS A BOOLEAN.**


5.**Unit_Converter**: This feature will convert units of measurement. You will be responsible for implementing:* 
    a. [celsius_to_fahrenheit(celsius)](#celsius_to_fahrenheitcelsius) - Converts Celsius to Fahrenheit. **RETURNS A DOUBLE.**
    b. [cm_to_inches(cm)](#cm_to_inchescm) - Converts centimeters to inches.] **RETURNS A DOUBLE.**
    c. [kg_to_pounds(kg)](#kg_to_poundskg) - Converts kilograms to pounds. **RETURNS A DOUBLE.**



    # Project Structure
# Beginner_Team_Project_1
-   App.config
-   Beginner_Team_Project_1.csproj
-   Program.cs
-   project_structure.txt
-   README.md
-   
+¦¦¦bin
-   L¦¦¦Debug
+¦¦¦Features
-       Date_Helper.cs
-       Random_Fun_Tool.cs
-       Simple_Math_Tool.cs
-       Text_Analyzer.cs
-       Unit_Converter.cs
-       
+¦¦¦obj
-   L¦¦¦Debug
-       -   .NETFramework,Version=v4.7.2.AssemblyAttributes.cs
-       -   Beginner_Team_Project_1.csproj.AssemblyReference.cache
-       -   DesignTimeResolveAssemblyReferencesInput.cache
-       -   
-       L¦¦¦TempPE
L¦¦¦Properties
        AssemblyInfo.cs



The timeline for the project is as follows:
- **Day 1-2**: Familiarization with C# and .NET Framework, setting up the development environment, and understanding the project requirements.
- **Day 3-5**: Each team member will work on their assigned feature, implementing the required functionalities.
- **Day 6-7**: Code review and integration of features into the main application.



If you have any questions or need further clarification, feel free to reach out.
Best regards,
Yusuf Aslan
