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
        Dim total As Integer
        Dim printedValue As String

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

                total = index * index2  'This does the math for the value of the column in the row based on which row/column it is in which changes every for loop
                printedValue = CStr(total).PadLeft(5) 'Pads the value to be a certain total length by adding spaces to the left of it. This alings all rows to the right.
                Console.Write(printedValue) 'Prints the padded value

            Next

            Console.WriteLine("") 'Starts a new line for each of the rows

        Next

    End Sub

End Module
