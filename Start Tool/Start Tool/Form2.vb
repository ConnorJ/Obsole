Public Class Form2
    Public Property mean_value As Single
    Public Property Stddev_value As Single
    Public Property Samples As Single
    Public Property Buy_total(100000) As Single()
    Public Property Confidence_Value As Single





    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Chart1.Series("Series1").Points.AddXY("Mark", 33)
        Me.Chart1.Series("Series1").Points.AddXY("John", 31)
        Me.Chart1.Series("Series1").Points.AddXY("John", 43)
        Me.Chart1.Series("Series1").Points.AddXY("Mark", 50)
        Me.Chart1.Series("")
    End Sub
End Class