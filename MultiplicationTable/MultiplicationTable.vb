'Joshua Makuch
'RCET 0265
'Fall 2023
'Multiplication Table
'https://github.com/JoshuaMakuch/MultiplicationTable.git

Option Strict On
Option Explicit On

Imports System

Module MultiplicationTable
    Sub Main(args As String())

        Dim userNumber As Integer
        Dim correctInput As Boolean = False
        Dim index As Integer
        Dim index2 As Integer
        Dim indexString As String
        Dim total As Integer

        Console.WriteLine("Hello user, please input an integer from 1 to 32. For viewing sake.")

        'Identifies if the user input a number within the range and is a
        'number that can be converted into an integer.
        Do Until correctInput = True And userNumber < 33 And userNumber > 0
            Try
                userNumber = CInt(Console.ReadLine())
                correctInput = True
            Catch ex As Exception
                Console.WriteLine("That didn't work, please input a correct value.")
            End Try
        Loop


        For index = 1 To userNumber 'This generates each row of values
            For index2 = 1 To userNumber    'This generates each column of values for every row
                total = index * index2
                indexString = String.Format(CStr(total))    'Creates an array whose value is amended every "for" loop
                Console.Write(indexString.PadLeft(5))   'Pads a string to be a certain length by adding spaces to the left of it. This alings all rows to the right.
            Next
            Console.WriteLine("")
        Next

    End Sub

End Module
