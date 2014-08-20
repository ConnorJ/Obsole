Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1
    Dim LTBForm As New LTBC_FORM
    Dim Form2 As New Form2
    Dim TimeCalcForm As New Form3



    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs) Handles ReDesign.Click
        TimeCalcForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As RibbonControlEventArgs) Handles Button3.Click
        Form2.ShowDialog()
    End Sub


    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As RibbonControlEventArgs) Handles Button7.Click
        LTBForm.ShowDialog()
    End Sub
End Class
