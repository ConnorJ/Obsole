

Public Class Form1
    Dim Form1 As Form1
    Dim row1() As String = {"1", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row2() As String = {"2", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row3() As String = {"3", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row4() As String = {"4", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row5() As String = {"5", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row6() As String = {"6", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row7() As String = {"7", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row8() As String = {"8", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row9() As String = {"9", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row10() As String = {"10", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row11() As String = {"11", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row12() As String = {"12", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row13() As String = {"13", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row14() As String = {"14", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row15() As String = {"15", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row16() As String = {"16", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row17() As String = {"17", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row18() As String = {"18", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row19() As String = {"19", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row20() As String = {"20", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row21() As String = {"21", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row22() As String = {"22", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row23() As String = {"23", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row24() As String = {"24", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row25() As String = {"25", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row26() As String = {"26", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row27() As String = {"27", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row28() As String = {"28", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row29() As String = {"29", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row30() As String = {"30", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row31() As String = {"31", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row32() As String = {"32", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row33() As String = {"33", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row34() As String = {"34", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row35() As String = {"35", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row36() As String = {"36", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row37() As String = {"37", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row38() As String = {"38", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row39() As String = {"39", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row40() As String = {"40", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row41() As String = {"41", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row42() As String = {"42", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row43() As String = {"43", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row44() As String = {"44", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row45() As String = {"45", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row46() As String = {"46", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row47() As String = {"47", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row48() As String = {"48", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row49() As String = {"49", "Normal", "10000", "100", "NA", "NA", "0"}
    Dim row50() As String = {"50", "Normal", "10000", "100", "NA", "NA", "0"}


    Dim rows() As Object = {row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13, row14, row15, row16, row17, row18, row19, row20, row21, row22, row23, row24, row25, row26, row27, row28, row29, row30, row31, row32, row33, row34, row35, row36, row37, row38, row39, row40, row41, row42, row43, row44, row45, row46, row47, row48, row49, row50}







    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = 10000
        TextBox2.Text = 0.9
        TextBox3.Text = 3

        ComboBox1.Text = "Select from..."
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("None")
        ComboBox1.Items.Add("Normal")
        ComboBox1.Items.Add("Trianglar")
        ComboBox1.Items.Add("Uniform")

        ComboBox2.Items.Clear()
        ComboBox2.Text = "Select from..."
        ComboBox2.Items.Add("Normal")
        ComboBox2.Items.Add("None")
        ComboBox2.Items.Add("Trianglar")
        ComboBox2.Items.Add("Uniform")

        ComboBox4.Items.Clear()
        ComboBox4.Text = CStr(10)
        For i = 5 To 10
            ComboBox4.Items.Add(CStr(i))
        Next
        For i = 15 To 50 Step 5
            ComboBox4.Items.Add(CStr(i))
        Next


        DataGridView1.Rows.Clear()
        DataGridView1.ColumnCount = 7
        DataGridView1.ColumnHeadersVisible = True
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False

        ' Set the column header names.
        DataGridView1.Columns(0).Name = "Time Period"
        DataGridView1.Columns(1).Name = "Distribution"
        DataGridView1.Columns(2).Name = "Mode"
        DataGridView1.Columns(3).Name = "Standard Deviation"
        DataGridView1.Columns(4).Name = "Low"
        DataGridView1.Columns(5).Name = "High"
        DataGridView1.Columns(6).Name = "Correlation"

        ' Populate the rows. 
        Dim rowArray As String()
        Dim count As Single
        For Each rowArray In rows
            count = count + 1
            If count <= CSng(ComboBox4.Text) Then
                DataGridView1.Rows.Add(rowArray)
            End If
        Next rowArray


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "None" Then
            Label7.Text = "Not Needed"
            Label8.Text = "Not Needed"
            TextBox4.Text = "XXXXX"
            TextBox5.Text = "XXXXX"
        End If

        If ComboBox1.Text = "Normal" Then
            Label7.Text = "Standard Deviation"
            Label8.Text = "Not Needed"
            TextBox4.Text = ""
            TextBox5.Text = "XXXXX"
        End If

        If ComboBox1.Text = "Uniform" Then
            Label7.Text = "Low"
            Label8.Text = "High"
            TextBox4.Text = ""
            TextBox5.Text = ""
        End If

        If ComboBox1.Text = "Trianglar" Then
            Label7.Text = "Low"
            Label8.Text = "High"
            TextBox4.Text = ""
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "None" Then
            Label10.Text = "Not Needed"
            Label9.Text = "Not Needed"
            TextBox8.Text = "XXXXX"
            TextBox6.Text = "XXXXX"
        End If

        If ComboBox2.Text = "Normal" Then
            Label10.Text = "Standard Deviation"
            Label9.Text = "Not Needed"
            TextBox8.Text = ""
            TextBox6.Text = "XXXXX"
        End If

        If ComboBox2.Text = "Uniform" Then
            Label10.Text = "Low"
            Label9.Text = "High"
            TextBox8.Text = ""
            TextBox6.Text = ""
        End If

        If ComboBox2.Text = "Trianglar" Then
            Label10.Text = "Low"
            Label9.Text = "High"
            TextBox8.Text = ""
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("Normal")
        ComboBox3.Items.Add("None")
        ComboBox3.Items.Add("Trianglar")
        ComboBox3.Items.Add("Uniform")

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow

            row = Me.DataGridView1.Rows(e.RowIndex)
            TextBox14.Text = row.Cells("Time Period").Value.ToString
            ComboBox3.Text = row.Cells("Distribution").Value.ToString
            TextBox12.Text = row.Cells("Mode").Value.ToString
            TextBox11.Text = row.Cells("Standard Deviation").Value.ToString
            TextBox10.Text = row.Cells("Low").Value.ToString
            TextBox13.Text = row.Cells("High").Value.ToString
            TextBox15.Text = row.Cells("Correlation").Value.ToString
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "None" Then
            TextBox12.Text = ""
            TextBox11.Text = "NA"
            TextBox10.Text = "NA"
            TextBox13.Text = "NA"
        End If

        If ComboBox3.Text = "Normal" Then
            TextBox12.Text = ""
            TextBox11.Text = ""
            TextBox10.Text = "NA"
            TextBox13.Text = "NA"
        End If

        If ComboBox3.Text = "Uniform" Then
            TextBox12.Text = "NA"
            TextBox11.Text = "NA"
            TextBox10.Text = ""
            TextBox13.Text = ""
        End If

        If ComboBox3.Text = "Trianglar" Then
            TextBox12.Text = ""
            TextBox11.Text = "NA"
            TextBox10.Text = ""
            TextBox13.Text = ""
        End If
    End Sub


    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click

        '{"1", "Normal", "10000", "100", "NA", "NA", "0"}
        Dim Period As String, Mode As Single, Std As Single, Low As Single, High As Single
        Dim K As String
        K = "Error: " & vbNewLine

        If ComboBox3.Text = "Normal" Then
            If IsNumeric(TextBox12.Text) Then
                Mode = TextBox12.Text
            Else
                K = K & "The Selected Mode is not a Number." & vbNewLine
            End If

            If IsNumeric(TextBox11.Text) Then
                Std = TextBox11.Text
            Else
                K = K & "The Selected Standard Deviation is not a Number." & vbNewLine
            End If

            If TextBox10.Text <> "NA" Then
                K = K & "The Selected Low is not set equal to 'NA'." & vbNewLine
            End If

            If TextBox13.Text <> "NA" Then
                K = K & "The Selected High is not set equal to 'NA'." & vbNewLine
            End If

        End If

        If ComboBox3.Text = "Uniform" Then
            If TextBox12.Text <> "NA" Then
                K = K & "The Selected Mode is not set equal to 'NA'." & vbNewLine
            End If

            If TextBox11.Text <> "NA" Then
                K = K & "The Selected Standard Deviation is not set equal to 'NA'." & vbNewLine
            End If

            If IsNumeric(TextBox10.Text) Then
                Low = TextBox10.Text
            Else
                K = K & "The Selected Low is not a number." & vbNewLine
            End If

            If IsNumeric(TextBox13.Text) Then
                If TextBox13.Text > Low Then
                    High = TextBox13.Text
                Else
                    K = K & "The Selected High is not greater than the low." & vbNewLine
                End If

            Else
                K = K & "The Selected High is not a number." & vbNewLine
            End If

        End If

        If ComboBox3.Text = "Trianglar" Then
            If IsNumeric(TextBox12.Text) Then
                Mode = TextBox12.Text
            Else
                K = K & "The Selected Mode is not a number." & vbNewLine
            End If


            If TextBox11.Text <> "NA" Then
                K = K & "The Selected Standard Deviation is not set equal to 'NA'." & vbNewLine
            End If

            If IsNumeric(TextBox10.Text) Then
                If Mode > TextBox10.Text Then
                    Low = TextBox10.Text
                Else
                    K = K & "The Selected Low is not lower than the Mode." & vbNewLine
                End If
            Else
                K = K & "The Selected Low is not a number." & vbNewLine
            End If

            If IsNumeric(TextBox13.Text) Then
                If Mode < TextBox13.Text Then
                    High = TextBox13.Text
                Else
                    K = K & "The Selected High is not higher than the Mode." & vbNewLine
                End If
            Else
                K = K & "The Selected High is not a number." & vbNewLine
            End If

        End If

        If ComboBox3.Text = "None" Then
            If IsNumeric(TextBox12.Text) Then
                Mode = TextBox12.Text
            Else
                K = K & "The Selected Mode is not a Number." & vbNewLine
            End If
            If TextBox11.Text <> "NA" Then
                K = K & "The Selected Standard Deviation is not set equal to 'NA'." & vbNewLine
            End If

            If TextBox10.Text <> "NA" Then
                K = K & "The Selected Low is not set equal to 'NA'." & vbNewLine
            End If

            If TextBox13.Text <> "NA" Then
                K = K & "The Selected High is not set equal to 'NA'." & vbNewLine
            End If

        End If




        If K = "Error: " & vbNewLine Then
           Dim Periods As String = TextBox14.Text
            If Periods.Contains(":") Then
                Dim Colon As String() = Periods.Split(New Char() {":"c})
                Dim q As Single
                Dim Time_One, Time_Two As Single
                For Each col In Colon
                    q = q + 1
                    If q = 1 Then Time_One = col
                    If q = 2 Then Time_Two = col
                Next

                For q = Time_One To Time_Two
                    rows(q - 1) = {CStr(q), CStr(ComboBox3.Text), CStr(TextBox12.Text), CStr(TextBox11.Text), CStr(TextBox10.Text), CStr(TextBox13.Text), CStr(TextBox15.Text)}
                Next
            Else
                rows(CSng(Periods) - 1) = {CStr(Periods), CStr(ComboBox3.Text), CStr(TextBox12.Text), CStr(TextBox11.Text), CStr(TextBox10.Text), CStr(TextBox13.Text), CStr(TextBox15.Text)}
            End If

            DataGridView1.Rows.Clear()
            Dim Count As Single
            Dim rowArray As String()
            For Each rowArray In rows
                Count = Count + 1
                If Count <= CSng(ComboBox4.Text) Then
                    DataGridView1.Rows.Add(rowArray)
                End If
            Next rowArray

        Else
            MsgBox(K)
        End If

    End Sub


    Private Sub CancelBTN_Click(sender As Object, e As EventArgs) Handles CancelBTN.Click
        Me.Close()
    End Sub

    Private Sub CalculateBTN_Click(sender As Object, e As EventArgs) Handles CalculateBTN.Click
        Dim i, j As Integer
        Dim K As String
        K = "Error: " & vbNewLine

        Dim Samples As Single
        If IsNumeric(TextBox1.Text) Then
            If TextBox1.Text > 0 Then
                Samples = CSng(TextBox1.Text)
                If TextBox1.Text > 100000 Then
                    Samples = 100000
                End If
            Else
                K = K + "Sample is smaller than Zero." & vbNewLine
            End If
        Else
            K = K + "Sample is not a number." & vbNewLine
        End If

        Dim Confidence As Single
        If IsNumeric(TextBox2.Text) Then
            If TextBox2.Text > 0 Then
                If TextBox2.Text < 1 Then
                    Confidence = CSng(TextBox2.Text)
                Else
                    K = K + "Confidence is larger than One." & vbNewLine
                End If
            Else
                K = K + "Confidence is smaller than Zero." & vbNewLine
            End If
        Else
            K = K + "Confidence is not a number." & vbNewLine
        End If

        Dim Plot_Range As Single
        If IsNumeric(TextBox3.Text) Then
            If TextBox3.Text > 0 Then
                Plot_Range = CSng(TextBox3.Text)
            Else
                K = K + "Error is smaller than Zero." & vbNewLine
            End If
        Else
            K = K + "Error is not a number." & vbNewLine
        End If

        Dim Buffer As Single
        If IsNumeric(TextBox16.Text) Then
            If TextBox16.Text > 0 Then
                If TextBox16.Text < 1 Then
                    Buffer = CSng(TextBox16.Text)
                Else
                    K = K + "Buffer is larger than One." & vbNewLine
                End If
            Else
                K = K + "Buffer is smaller than Zero." & vbNewLine
            End If
        Else
            K = K + "Buffer is not a number." & vbNewLine
        End If

        If ComboBox1.Text = "Select from..." Then
            K = K + "Select a Length of Buy Distibustion" & vbNewLine
        End If

        If ComboBox2.Text = "Select from..." Then
            K = K + "Select a Length of Redesign Distibustion" & vbNewLine
        End If

        Dim Length_Of_Buy_Dist As String = CStr(ComboBox1.Text)
        Dim Length_Of_Buy_Mean As Single
        Dim Length_Of_Buy_First As Single
        Dim Length_Of_Buy_Second As Single


        If Length_Of_Buy_Dist = "Normal" Then
            If IsNumeric(TextBox7.Text) Then
                Length_Of_Buy_Mean = CSng(TextBox7.Text)
            Else
                K = K + "Length of Buy Mode is not a Number" & vbNewLine
            End If
            If IsNumeric(TextBox4.Text) Then
                Length_Of_Buy_First = CSng(TextBox4.Text)
            Else
                K = K + "Length of Buy Standard Deviation is not a Number" & vbNewLine
            End If
        End If

        If Length_Of_Buy_Dist = "Uniform" Then
            If IsNumeric(TextBox4.Text) Then
                Length_Of_Buy_First = CSng(TextBox4.Text)
            Else
                K = K + "Length of Buy Low is not a Number" & vbNewLine
            End If
            If IsNumeric(TextBox5.Text) Then
                If TextBox5.Text > TextBox4.Text Then
                    Length_Of_Buy_Second = CSng(TextBox5.Text)
                Else
                    K = K + "Length of Buy Low is greater than the Length of Buy High" & vbNewLine
                End If
            Else
                K = K + "Length of Buy High is not a Number" & vbNewLine
            End If
        End If

        If Length_Of_Buy_Dist = "Trianglar" Then
            If IsNumeric(TextBox7.Text) Then
                Length_Of_Buy_Mean = CSng(TextBox7.Text)
            Else
                K = K + "Length of Buy Mode is not a Number" & vbNewLine
            End If
            If IsNumeric(TextBox4.Text) Then
                If TextBox7.Text > TextBox4.Text Then
                    Length_Of_Buy_First = CSng(TextBox4.Text)
                Else
                    K = K + "Length of Buy Mode is smaller than Length of Buy Low" & vbNewLine
                End If
            Else
                K = K + "Length of Buy Low is not a Number" & vbNewLine
            End If
            If IsNumeric(TextBox5.Text) Then
                If TextBox5.Text > TextBox7.Text Then
                    Length_Of_Buy_Second = CSng(TextBox5.Text)
                Else
                    K = K + "Length of Buy Low is greater than the Length of Buy Mode" & vbNewLine
                End If
            Else
                K = K + "Length of Buy High is not a Number" & vbNewLine
            End If
        End If

        If Length_Of_Buy_Dist = "None" Then
            If IsNumeric(TextBox7.Text) Then
                Length_Of_Buy_Mean = CSng(TextBox7.Text)
            Else
                K = K + "Length of Buy Mode is not a Number" & vbNewLine
            End If
        End If

        Dim Length_Of_Redesign_Dist As String = CStr(ComboBox2.Text)
        Dim Length_Of_Redesign_Mean As Single
        Dim Length_Of_Redesign_First As Single
        Dim Length_Of_Redesign_Second As Single

        If Length_Of_Redesign_Dist = "Normal" Then
            If IsNumeric(TextBox9.Text) Then
                Length_Of_Redesign_Mean = CSng(TextBox9.Text)
            Else
                K = K + "Length of Redesign Mode is not a Number" & vbNewLine
            End If
            If IsNumeric(TextBox8.Text) Then
                Length_Of_Redesign_First = CSng(TextBox8.Text)
            Else
                K = K + "Length of Redesign Standard Deviation is not a Number" & vbNewLine
            End If
        End If
        If Length_Of_Redesign_Dist = "Uniform" Then
            If IsNumeric(TextBox8.Text) Then
                Length_Of_Redesign_First = CSng(TextBox8.Text)
            Else
                K = K + "Length of Redesign Low is not a Number" & vbNewLine
            End If
            If IsNumeric(TextBox6.Text) Then
                If TextBox6.Text > TextBox8.Text Then
                    Length_Of_Redesign_Second = CSng(TextBox6.Text)
                Else
                    K = K + "Length of Redesign Low is greater than the Length of Redesign High" & vbNewLine
                End If
            Else
                K = K + "Length of Redesign High is not a Number" & vbNewLine
            End If
        End If
        If Length_Of_Redesign_Dist = "Trianglar" Then
            If IsNumeric(TextBox9.Text) Then
                Length_Of_Redesign_Mean = CSng(TextBox9.Text)
            Else
                K = K + "Length of Redesign Mode is not a Number" & vbNewLine
            End If
            If IsNumeric(TextBox8.Text) Then
                If CSng(TextBox9.Text) > CSng(TextBox8.Text) Then
                    Length_Of_Redesign_First = CSng(TextBox8.Text)
                Else
                    K = K + "Length of Redesign Mode is smaller than Length of Redesign Low" & vbNewLine
                End If
            Else
                K = K + "Length of Redesign Low is not a Number" & vbNewLine
            End If
            If IsNumeric(TextBox6.Text) Then
                If TextBox6.Text > TextBox9.Text Then
                    Length_Of_Redesign_Second = CSng(TextBox6.Text)
                Else
                    K = K + "Length of Redesign Low is greater than the Length of Redesign Mode" & vbNewLine
                End If
            Else
                K = K + "Length of Redesign High is not a Number" & vbNewLine
            End If
        End If

        If Length_Of_Redesign_Dist = "None" Then
            If IsNumeric(TextBox9.Text) Then
                Length_Of_Redesign_Mean = CSng(TextBox9.Text)
            Else
                K = K + "Length of Redesign Mode is not a Number" & vbNewLine
            End If
        End If


        If K = "Error: " & vbNewLine Then
            Dim Demand_Dist(50) As String
            Dim Demand_Mode(50) As Single
            Dim Demand_Stdev(50) As Single
            Dim Demand_Low(50) As Single
            Dim Demand_High(50) As Single
            Dim Demand_Corr(50) As Single

            For j = 1 To CSng(ComboBox4.Text)
                Demand_Dist(j) = CStr(DataGridView1.Item(1, j - 1).Value)
                If Demand_Dist(j) = "Normal" Then
                    Demand_Mode(j) = CSng(DataGridView1.Item(2, j - 1).Value)
                    Demand_Stdev(j) = CSng(DataGridView1.Item(3, j - 1).Value)
                    Demand_Corr(j) = CSng(DataGridView1.Item(6, j - 1).Value)
                End If
                If Demand_Dist(j) = "Trianglar" Then
                    Demand_Mode(j) = CSng(DataGridView1.Item(2, j - 1).Value)
                    Demand_Low(j) = CSng(DataGridView1.Item(4, j - 1).Value)
                    Demand_High(j) = CSng(DataGridView1.Item(5, j - 1).Value)
                    Demand_Corr(j) = CSng(DataGridView1.Item(6, j - 1).Value)
                End If
                If Demand_Dist(j) = "Uniform" Then
                    Demand_Low(j) = CSng(DataGridView1.Item(4, j - 1).Value)
                    Demand_High(j) = CSng(DataGridView1.Item(5, j - 1).Value)
                    Demand_Corr(j) = CSng(DataGridView1.Item(6, j - 1).Value)
                End If
                If Demand_Dist(j) = "None" Then
                    Demand_Mode(j) = CSng(DataGridView1.Item(2, j - 1).Value)
                    Demand_Corr(j) = CSng(DataGridView1.Item(6, j - 1).Value)
                End If
            Next

            Dim Length_Of_Buy, Length_Of_Redesign As Single
            Dim Int_Buy_Length As Integer
            Dim Demand, Total_Demand, Sum, Buy_total(Samples) As Single

            ' Start Monte Carlo Loop
            For i = 1 To Samples
                Total_Demand = 0
                ' Buy length Sample
                Length_Of_Buy = Sampler(Length_Of_Buy_Dist, Length_Of_Buy_Mean, Length_Of_Buy_First, Length_Of_Buy_Second)
                ' Redesign length Sample
                Length_Of_Redesign = Sampler(Length_Of_Redesign_Dist, Length_Of_Redesign_Mean, Length_Of_Redesign_First, Length_Of_Redesign_Second)

                ' Integer Periods in Buy Length
                Int_Buy_Length = Math.Floor(Length_Of_Buy - Length_Of_Redesign_Mean + Length_Of_Redesign)
                If Int_Buy_Length < 1 Then
                    Int_Buy_Length = 0
                ElseIf Int_Buy_Length > ComboBox4.Text Then
                    Int_Buy_Length = ComboBox4.Text
                End If

                'Sample Demands for Buy Lengths
                For j = 1 To Int_Buy_Length
                    Demand = Demand_Sampler(j, Demand_Dist(j), Demand_Mode(j), Demand_Stdev(j), Demand_Low(j), Demand_High(j), Demand_Corr(j))
                    Total_Demand = Total_Demand + Demand
                Next

                'Account for the factional last year
                If Int_Buy_Length < ComboBox4.Text Then
                    j = Int_Buy_Length + 1
                    Demand = Demand_Sampler(j, Demand_Dist(j), Demand_Mode(j), Demand_Stdev(j), Demand_Low(j), Demand_High(j), Demand_Corr(j))
                End If
                Buy_total(i) = Total_Demand + ((Length_Of_Buy - Length_Of_Redesign_Mean + Length_Of_Redesign) - Int_Buy_Length) * Demand
                Sum = Sum + Buy_total(i)
            Next


            'Calculate the Mean 
            Dim Mean_value As Single
            Mean_value = Sum / Samples

            'Calculate the Std Dev
            Sum = 0
            Dim Stddev_value As Single
            For i = 1 To Samples
                Sum = Sum + (Buy_total(i) - Mean_value) * (Buy_total(i) - Mean_value)
            Next
            Stddev_value = Math.Sqrt(Sum / Samples)

            'Order the Buy Totals
            Array.Sort(Buy_total)

            'Calculate Confidence Levels
            Dim Conf_Quat As Integer = Math.Floor(Samples * Confidence)
            Dim Confidence_Value As Single = (Buy_total(Conf_Quat) + Buy_total(Conf_Quat + 1)) / 2

            Dim Bin_number, Bin_width, min_plot, max_plot As Single
            'Struger Rule
            Bin_number = 1 + Math.Log(Samples) / Math.Log(2)
            Bin_width = 2 * Plot_Range * Stddev_value / Bin_number

            min_plot = Mean_value - Plot_Range * Stddev_value
            max_plot = Mean_value + Plot_Range * Stddev_value

            Dim Bin_Quat(100), high_bin As Single
            Dim Bin_name As String
            Dim Charts_Form As New Form2

            Dim Total_Demand_wBuffer As Single = Confidence_Value * (1 + Buffer)
            Dim Trigger, Buffer_percent As Single

            For j = 1 To Bin_number
                For i = 1 To Samples
                    If Buy_total(i) > (min_plot + ((j - 1) * Bin_width)) Then
                        If Buy_total(i) <= (min_plot + (j * Bin_width)) Then
                            Bin_Quat(j) = Bin_Quat(j) + 1
                            high_bin = i
                        End If
                    End If
                    'Calculate Buy Percentage including Buffer
                    If Trigger = 0 Then
                        If Buy_total(i) >= Total_Demand_wBuffer Then
                            Trigger = 1
                            Buffer_percent = (i / Samples)
                        End If
                    End If
                Next
                Bin_name = CStr(Buy_total(high_bin) - Bin_width / 2)
                Charts_Form.Chart1.Series("Total Buy Quanties").Points.AddXY(Bin_name, Bin_Quat(j))
            Next

            Charts_Form.Label1.Text = Math.Round(Mean_value)
            Charts_Form.Label2.Text = Math.Round(Stddev_value)
            Charts_Form.Label3.Text = Math.Round(Confidence_Value)
            Charts_Form.Label4.Text = Math.Round(((Mean_value) / (Total_Demand) - 1) * 100, 2) & " %"
            Charts_Form.Label5.Text = Math.Round(Total_Demand)
            Charts_Form.Label6.Text = Math.Round(Buffer_percent, 4) & " %"

            If CInt(TextBox1.Text) > 100000 Then
                MsgBox("Sample was too large and was set to 100,000.")
            End If

            Charts_Form.ShowDialog()

        Else
            ' Msgbox of read in errors on left side of screen
            MsgBox(K)
        End If

    End Sub


    Function Sampler(ByVal Dist As String, ByVal Mode As Single, ByVal First As Single, ByVal Second As Single) As Single
        Dim Z, U1, U2, Sample As Single
        U1 = Rnd()
        U2 = Rnd()

        If Dist = "Normal" Then
            Z = Math.Sqrt(-2 * Math.Log(U1)) * Math.Sin(2 * Math.PI * U2)
            Sample = Mode + First * Z
        End If

        If Dist = "Trianglar" Then
            Sample = First + Math.Sqrt(U1 * (Second - First) * (Mode - First))
        End If

        If Dist = "None" Then
            Sample = Mode
        End If

        If Dist = "Uniform" Then
            Sample = (Second - First) * U1 + First
        End If

        Sampler = Sample
    End Function

    Function Demand_Sampler(ByVal Period As Single, ByVal Dist As String, ByVal Mode As Single, ByVal Std_Dev As Single, ByVal Low As Single, ByVal High As Single, ByVal Corr As Single) As Single
        Dim Z, U1, U2, Sample As Single
        U1 = Rnd()
        U2 = Rnd()

        If Dist = "Normal" Then
            Z = Math.Sqrt(-2 * Math.Log(U1)) * Math.Sin(2 * Math.PI * U2)
            Sample = Mode + Std_Dev * Z
        End If

        If Dist = "Trianglar" Then
            Sample = Low + Math.Sqrt(U1 * (High - Low) * (Mode - Low))
        End If

        If Dist = "None" Then
            Sample = Mode
        End If

        If Dist = "Uniform" Then
            Sample = (High - Low) * U1 + Low
        End If

        Demand_Sampler = Sample
    End Function
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim Demand_Mode(10) As Single
        Dim Demand_Low(10) As Single
        Dim Demand_High(10) As Single
        Dim Demand_Stdev(10) As Single
        Dim Demand_Dist(10) As String

        Demand_Mode(1) = 1
        If IsNumeric(DataGridView1.Rows.Item(2).Cells(2).Value) Then Demand_Mode(1) = CSng(row1(2))
        MsgBox(DataGridView1.Rows.Item(2).Cells(2).Value)


        If Demand_Dist(1) = "Normal" Then
            Demand_Mode(1) = CSng(row1(2))
            Demand_Stdev(1) = CSng(row1(3))
        ElseIf Demand_Dist(1) = "None" Then
            Demand_Low(1) = CSng(row1(4))
            Demand_High(1) = CSng(row1(5))
        ElseIf Demand_Dist(1) = "Trianglar" Then
            Demand_Mode(1) = CSng(row1(2))
            Demand_Low(1) = CSng(row1(4))
            Demand_High(1) = CSng(row1(5))
        ElseIf Demand_Dist(1) = "Uniform" Then
            Demand_Low(1) = CSng(row1(4))
            Demand_High(1) = CSng(row1(5))
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim Z, U1, U2 As Single
        ' http://en.wikipedia.org/wiki/Box-Muller_transform
        Dim K, Max As Single
        Max = 0
        For i = 1 To 10000
            U1 = Rnd()
            U2 = Rnd()
            Z = Math.Sqrt(-2 * Math.Log(U1)) * Math.Sin(2 * Math.PI * U2)
            K = K + Z
            If Z > Max Then Max = Z
        Next
        Dim A, B, C, Tri, tot, Min As Single
        A = 1
        B = 10
        C = 8
        Min = 5
        For i = 1 To 10000
            U1 = Rnd()
            Tri = A + Math.Sqrt(U1 * (B - A) * (C - A))
            tot = tot + Tri
            If Tri > Max Then Max = Tri
            If Tri < Min Then Min = Tri
        Next


        MsgBox(Rnd() & " next " & K / 10000 & "  halhfkehjh  " & vbNewLine & Max & "   osihfhs   " & tot / 10000 & " Min " & Min)

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim Arr(6) As Single

        Arr(1) = 4
        Arr(2) = 4
        Arr(3) = 3
        Arr(4) = 2
        Arr(5) = 9
        Arr(6) = 1
        Array.Sort(Arr)

        MsgBox(Arr(1) & "   " & Arr(6))

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim rowArray As String()
        Dim K As Single
        DataGridView1.Rows.Clear()
        For Each rowArray In rows
            K = K + 1
            If K <= CSng(ComboBox4.Text) Then
                DataGridView1.Rows.Add(rowArray)
            End If
        Next rowArray
    End Sub


End Class