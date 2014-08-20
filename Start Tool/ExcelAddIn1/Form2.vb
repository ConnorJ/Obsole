Public Class Form2

    Dim LTBC_FORM As LTBC_FORM
    'Public Samples As Single
    'Public Buy_total(500000) As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim K As String
        Dim Buffer As Single

        Buffer = TextBox1.Text

        K = "Error:" & vbNewLine

        Dim Total_Demand_wBuffer As Single = Label23.Text * (1 + TextBox1.Text)
        Dim Trigger, Buffer_percent As Single
        Buffer_percent = 1

        Dim Samples As Single
        Samples = TextBox1.Text


        For i = 1 To Samples
            If Trigger = 0 Then
                'If Buy_total(i) >= Total_Demand_wBuffer Then
                Trigger = 1
                Buffer_percent = (i / Samples)
                'End If
            End If
        Next
        Label27.Text = Total_Demand_wBuffer
        Label28.Text = Buffer_percent



    End Sub
End Class