Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1
    Dim LTBForm As New Form1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        LTBForm.ShowDialog()
    End Sub
End Class
