' Visual Basic NetCore App 3.1 
' Writes Next Easter Date to Command-Line.

Module EasterDate
    Sub Main(args As String())

        ' No Arguments, return event date for current year,
        ' Or next year if beyond event date in current year.
        If args.Length = 0 Then
            Console.WriteLine(Holidays.EasterDate.GetEasterDate().ToString("MM/dd/yyyy", Globalization.CultureInfo.InvariantCulture))
            Return
        End If

        ' Arguments passed, return event date(s) for year(s) in arguments..
        Dim counter As Integer = 0
        For Each arg In args
            Try
                ArgValue = Convert.ToInt32(Right("0000" + args(counter), 4)) ' Pad left with 0's
                If ArgValue > 1 And ArgValue < 9999 Then
                    Console.WriteLine(Holidays.EasterDate.CalculateEasterDate(ArgValue).ToString("MM/dd/yyyy", Globalization.CultureInfo.InvariantCulture))
                Else
                    Throw New NotImplementedException()
                End If
            Catch ex As Exception
                Console.WriteLine(" - " + args(counter) + " is not a valid year..." + Chr(10) + " - Use a 4 digit number between 1 and 9999.")
            End Try
            counter += 1
        Next

    End Sub

End Module
