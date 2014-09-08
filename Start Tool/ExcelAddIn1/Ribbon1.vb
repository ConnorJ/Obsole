Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1
    Dim LTBForm As New LTBC_FORM
    Dim Form2 As New Form2
    Dim TimeCalcForm As New Form3



    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs) Handles ReDesign.Click
        Message()
    End Sub

    Private Sub Button3_Click(sender As Object, e As RibbonControlEventArgs) Handles Button3.Click
        Message()
    End Sub


    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs)
        Message()
    End Sub

    Private Sub Button7_Click(sender As Object, e As RibbonControlEventArgs) Handles Button7.Click
        LTBForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As RibbonControlEventArgs) Handles Button4.Click
        Message()
    End Sub
    Function Message()
        MsgBox("In this Beta Testing Edition, no complete form is available for this button.")
    End Function

    Private Sub Button5_Click(sender As Object, e As RibbonControlEventArgs) Handles Button5.Click
        Message()
    End Sub

    Private Sub Button6_Click(sender As Object, e As RibbonControlEventArgs) Handles Button6.Click
        Message()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As RibbonControlEventArgs) Handles Button2.Click
        Message()
    End Sub
End Class
