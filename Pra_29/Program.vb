

Module Program
    Sub Main()
        Dim studentName As String = "Priyanka Rani"
        Dim grade As String = " A+ "

        Dim fullDetails As String
        fullDetails = "Student " & studentName & " has achevied grade" & grade & "."

        Console.WriteLine("Concatenated String:")
        Console.WriteLine(fullDetails)

        Console.ReadKey()

    End Sub
End Module
