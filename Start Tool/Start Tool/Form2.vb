Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Bin_number, Bin_width, min_plot, max_plot As Single
        'Struger Rule
        Bin_number = 1 + Math.Log(Samples) / Math.Log(2)
        Bin_width = 2 * Plot_Range * Stddev_value / Bin_number

        min_plot = mean_value - Plot_Range * Stddev_value
        max_plot = mean_value + Plot_Range * Stddev_value

        Dim Bin_Quat(100), high_bin As Single
        Dim Bin_name As String


        For j = 1 To Bin_number
            For i = 1 To Samples
                If Buy_total(i) > (min_plot + ((j - 1) * Bin_width)) Then
                    If Buy_total(i) <= (min_plot + (j * Bin_width)) Then
                        Bin_Quat(j) = Bin_Quat(j) + 1
                        high_bin = i
                    End If
                End If

            Next
            Bin_name = CStr(Buy_total(high_bin) - Bin_width / 2)
            MsgBox(Bin_name & " " & Bin_Quat(j))
            Me.Chart1.Series("Series1").Points.AddXY(Bin_name, Bin_Quat(j))
        Next
    End Sub
End Class