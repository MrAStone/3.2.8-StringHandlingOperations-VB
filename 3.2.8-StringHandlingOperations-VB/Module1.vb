Imports System.Globalization

Module Module1

    Sub Main()
        ' Understand and be able to use
        Dim myString As String = "This is a string"
        ' length
        Console.WriteLine(myString.Length) ' works on strings and arrays
        Console.WriteLine(Len(myString)) ' ONLY works on strings
        ' position in a string
        Console.WriteLine(myString(0)) ' the first character in a string (T)
        Console.WriteLine(myString(myString.Length - 1)) ' the last character in a string (g)
        ' the last index is always 1 less than the length due to the first index being 0

        'Substring
        Console.WriteLine(myString.Substring(2, 7)) ' start at index 2 and take a length of 7 (is is a)
        Console.WriteLine(myString.Substring(5)) ' start at index 5 and go to the end of the string (is a string)

        'Concatenation
        Console.WriteLine("My string is " + myString) ' concatenation with a + (only works on strings/chars)
        Console.WriteLine("My string is " & myString) ' concatenation with a & works on mixed data types
        Console.WriteLine($"My string is {myString}") ' string builder (string literals) allows you to add variables within a string using $ before and {} for variables
        Console.WriteLine("my string is {0}", myString) ' string builder using parameters {param number} and comma separated parameters
        Dim first As String = "Something"
        Dim second As String = "Other thing"
        Console.WriteLine(myString + first + second) ' no spaces
        Console.WriteLine($"{myString} {first} {second}") 'spaces included in string literal
        Console.WriteLine("Joining with parameters {0} {1} {2}", myString, first, second) ' spaces included in string build

        ' Convert character to character code
        Dim myChar As Char = "A"
        Console.WriteLine(Asc(myChar)) ' 65
        myChar = "a"
        Console.WriteLine(Asc(myChar)) ' 97
        ' Convert character code to character
        Dim charCode As Integer = 65
        Console.WriteLine(Chr(charCode)) ' A
        charCode = 97
        Console.WriteLine(Chr(charCode)) ' a
        For i = 65 To 90
            Console.WriteLine(Chr(i)) ' A to Z
        Next

        'String conversion operations
        ''NOTE ''''''''''''''''''''''
        ' VB.NET allows string inputs from the console to directly be converted if the data type being used in a number
        '''''''''''''''''''''''''''''
        'String to integer
        Dim numberInput As Integer
        Dim stringInput As String
        Console.Write("Enter a number: ")
        stringInput = Console.ReadLine
        numberInput = Convert.ToInt32(stringInput)
        ' convert as entering values
        numberInput = Convert.ToInt32(Console.ReadLine)
        'string to real
        Dim doubleInput As Double
        Console.Write("Enter a real number: ")
        stringInput = Console.ReadLine
        doubleInput = Convert.ToDouble(stringInput)

        'Integer to string
        Dim stringOutput As String
        stringOutput = Convert.ToString(numberInput)
        stringOutput = numberInput.ToString

        'real to string
        stringOutput = Convert.ToString(doubleInput)
        stringOutput = doubleInput.ToString

    End Sub

End Module
