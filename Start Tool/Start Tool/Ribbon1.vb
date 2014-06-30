Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1
    Dim LTBForm As New Form1
    Dim Form2 As New Form2
    Dim TimeCalcForm As New Form3
    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        LTBForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs) Handles Button2.Click
        TimeCalcForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As RibbonControlEventArgs) Handles Button3.Click
        Form2.ShowDialog()
    End Sub
End Class
