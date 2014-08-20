Partial Class Ribbon1
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
   Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.Button4 = Me.Factory.CreateRibbonButton
        Me.Button5 = Me.Factory.CreateRibbonButton
        Me.Button6 = Me.Factory.CreateRibbonButton
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.Options = Me.Factory.CreateRibbonGroup
        Me.ReDesign = Me.Factory.CreateRibbonButton
        Me.Button3 = Me.Factory.CreateRibbonButton
        Me.Button2 = Me.Factory.CreateRibbonButton
        Me.Group3 = Me.Factory.CreateRibbonGroup
        Me.EditBox1 = Me.Factory.CreateRibbonEditBox
        Me.DropDown1 = Me.Factory.CreateRibbonDropDown
        Me.Button7 = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.Options.SuspendLayout()
        Me.Group3.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group2)
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Groups.Add(Me.Options)
        Me.Tab1.Groups.Add(Me.Group3)
        Me.Tab1.Label = "OBSOLESCENCE"
        Me.Tab1.Name = "Tab1"
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.Button4)
        Me.Group2.Items.Add(Me.Button5)
        Me.Group2.Items.Add(Me.Button6)
        Me.Group2.Label = "Inputs"
        Me.Group2.Name = "Group2"
        '
        'Button4
        '
        Me.Button4.Label = "Import BOM"
        Me.Button4.Name = "Button4"
        '
        'Button5
        '
        Me.Button5.Label = "Inputs"
        Me.Button5.Name = "Button5"
        '
        'Button6
        '
        Me.Button6.Label = "Uncertainties"
        Me.Button6.Name = "Button6"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.Button7)
        Me.Group1.Label = "Life Time Buy Calc"
        Me.Group1.Name = "Group1"
        '
        'Options
        '
        Me.Options.Items.Add(Me.ReDesign)
        Me.Options.Items.Add(Me.Button3)
        Me.Options.Items.Add(Me.Button2)
        Me.Options.Label = "Options"
        Me.Options.Name = "Options"
        '
        'ReDesign
        '
        Me.ReDesign.Label = "ReDesign"
        Me.ReDesign.Name = "ReDesign"
        Me.ReDesign.ShowImage = True
        '
        'Button3
        '
        Me.Button3.Label = "Canibalization"
        Me.Button3.Name = "Button3"
        Me.Button3.ShowImage = True
        '
        'Button2
        '
        Me.Button2.Label = "Alterative"
        Me.Button2.Name = "Button2"
        Me.Button2.ShowImage = True
        '
        'Group3
        '
        Me.Group3.Items.Add(Me.EditBox1)
        Me.Group3.Items.Add(Me.DropDown1)
        Me.Group3.Label = "Data"
        Me.Group3.Name = "Group3"
        '
        'EditBox1
        '
        Me.EditBox1.Label = "Rate"
        Me.EditBox1.Name = "EditBox1"
        Me.EditBox1.Text = Nothing
        '
        'DropDown1
        '
        Me.DropDown1.Label = "DataBase"
        Me.DropDown1.Name = "DropDown1"
        Me.DropDown1.ShowImage = True
        '
        'Button7
        '
        Me.Button7.Label = "Life Time Buy Calc"
        Me.Button7.Name = "Button7"
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.Options.ResumeLayout(False)
        Me.Options.PerformLayout()
        Me.Group3.ResumeLayout(False)
        Me.Group3.PerformLayout()

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Options As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents ReDesign As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button3 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group3 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents EditBox1 As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents DropDown1 As Microsoft.Office.Tools.Ribbon.RibbonDropDown
    Friend WithEvents Button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button5 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button6 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button4 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button7 As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
