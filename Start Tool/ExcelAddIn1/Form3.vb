Public Class Form3


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Demand(5), Reorder(5) As Single
        Dim Total_Time, Total_Demand As Single
        Dim A, h, T, time As Single
        Demand(1) = TextBox1.Text
        Demand(2) = TextBox2.Text
        Demand(3) = TextBox3.Text
        Demand(4) = TextBox4.Text
        Demand(5) = TextBox5.Text

        A = TextBox6.Text
        h = TextBox7.Text
        Total_Time = 5

        For T = 1 To Total_Time
            For time = 1 To Total_Time - T
                For k = T To T + time
                    Total_Demand = Total_Demand + (time - 1) * Demand(k)
                Next
                MsgBox("Total demand " & Total_Demand & " T " & T & " Time " & time)
                If (T ^ 2) * Demand(T + 1) > A / h + Total_Demand Then
                    Reorder(T) = Reorder(T) + Demand(time)
                End If
            Next
        Next
       
        MsgBox(Reorder(1) & vbNewLine & Reorder(2) & vbNewLine & Reorder(3) & vbNewLine & Reorder(5) & vbNewLine & Reorder(5) & vbNewLine)


    End Sub
End Class