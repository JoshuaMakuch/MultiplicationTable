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
        Dim Index As Integer
        Dim Index2 As Integer
        Dim IndexString As String
        Dim Total As Integer

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

        For Index = 1 To userNumber
            For Index2 = 1 To userNumber
                Total = Index * Index2
                IndexString = String.Format(CStr(Total))
                Console.Write(IndexString.PadLeft(5))
            Next
            Console.WriteLine("")
        Next


    End Sub
End Module