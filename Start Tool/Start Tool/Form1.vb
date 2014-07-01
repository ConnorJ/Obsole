

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
    Dim rows() As Object = {row1, row2, row3, row4, row5, row6, row7, row8, row9, row10}







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
        For Each rowArray In rows
            DataGridView1.Rows.Add(rowArray)
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
        Dim Period As Integer, Mode As Single, Std As Single, Low As Single, High As Single
        Dim K As String
        K = "Error: " & vbNewLine
        If IsNumeric(TextBox14.Text) Then
            If CSng(TextBox14.Text) >= 1 Then
                If CSng(TextBox14.Text) <= 10 Then
                    Period = CInt(TextBox14.Text)
                Else : K = K & "The Selected Period is larger than 10." & vbNewLine
                End If
            Else : K = K & "The Selected Period is samller than 1." & vbNewLine
            End If
        Else
            K = K & "The Selected Period is not a Number." & vbNewLine
        End If

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
            Dim newrow() As String = {CStr(TextBox14.Text), CStr(ComboBox3.Text), CStr(TextBox12.Text), CStr(TextBox11.Text), CStr(TextBox10.Text), CStr(TextBox13.Text)}

            rows(CInt(TextBox14.Text) - 1) = {CStr(TextBox14.Text), CStr(ComboBox3.Text), CStr(TextBox12.Text), CStr(TextBox11.Text), CStr(TextBox10.Text), CStr(TextBox13.Text), CStr(TextBox15.Text)}

            DataGridView1.Rows.Clear()

            Dim rowArray As String()
            For Each rowArray In rows
                DataGridView1.Rows.Add(rowArray)
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

        Dim Samples As Integer
        If IsNumeric(TextBox1.Text) Then
            If TextBox1.Text > 0 Then
                Samples = CInt(TextBox1.Text)
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
     
        Dim Stand_Dev As Integer = CInt(TextBox3.Text)

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
                If TextBox9.Text > TextBox8.Text Then
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
            Dim Demand_Dist(10) As String
            Demand_Dist(1) = row1(1)
            Demand_Dist(2) = row2(1)
            Demand_Dist(3) = row3(1)
            Demand_Dist(4) = row4(1)
            Demand_Dist(5) = row5(1)
            Demand_Dist(6) = row6(1)
            Demand_Dist(7) = row7(1)
            Demand_Dist(8) = row8(1)
            Demand_Dist(9) = row9(1)
            Demand_Dist(10) = row10(1)

            Dim Demand_Mode(10) As Single
            Dim Demand_Stdev(10) As Single
            Dim Demand_Low(10) As Single
            Dim Demand_High(10) As Single
            Dim Demand_Corr(10) As Single

            ' Demand Period 1
            If Demand_Dist(1) = "Normal" Then
                Demand_Mode(1) = CSng(row1(2))
                Demand_Stdev(1) = CSng(row1(3))
                Demand_Corr(1) = CSng(row1(6))
            End If
            If Demand_Dist(1) = "Trianglar" Then
                Demand_Mode(1) = CSng(row1(2))
                Demand_Low(1) = CSng(row1(4))
                Demand_High(1) = CSng(row1(5))
                Demand_Corr(1) = CSng(row1(6))
            End If
            If Demand_Dist(1) = "Uniform" Then
                Demand_Low(1) = CSng(row1(4))
                Demand_High(1) = CSng(row1(5))
                Demand_Corr(1) = CSng(row1(6))
            End If
            If Demand_Dist(1) = "None" Then
                Demand_Mode(1) = CSng(row1(2))
                Demand_Corr(1) = CSng(row1(6))
            End If

            ' Demand Period 2
            If Demand_Dist(2) = "Normal" Then
                Demand_Mode(2) = CSng(row2(2))
                Demand_Stdev(2) = CSng(row2(3))
                Demand_Corr(2) = CSng(row2(6))
            End If
            If Demand_Dist(2) = "Trianglar" Then
                Demand_Mode(2) = CSng(row2(2))
                Demand_Low(2) = CSng(row2(4))
                Demand_High(2) = CSng(row2(5))
                Demand_Corr(2) = CSng(row2(6))
            End If
            If Demand_Dist(2) = "Uniform" Then
                Demand_Low(2) = CSng(row2(4))
                Demand_High(2) = CSng(row2(5))
                Demand_Corr(2) = CSng(row2(6))
            End If
            If Demand_Dist(2) = "None" Then
                Demand_Mode(2) = CSng(row2(2))
                Demand_Corr(2) = CSng(row2(6))
            End If

            ' Demand Period 3
            If Demand_Dist(3) = "Normal" Then
                Demand_Mode(3) = CSng(row3(2))
                Demand_Stdev(3) = CSng(row3(3))
                Demand_Corr(3) = CSng(row3(6))
            End If
            If Demand_Dist(3) = "Trianglar" Then
                Demand_Mode(3) = CSng(row3(2))
                Demand_Low(3) = CSng(row3(4))
                Demand_High(3) = CSng(row3(5))
                Demand_Corr(3) = CSng(row3(6))
            End If
            If Demand_Dist(3) = "Uniform" Then
                Demand_Low(3) = CSng(row3(4))
                Demand_High(3) = CSng(row3(5))
                Demand_Corr(3) = CSng(row3(6))
            End If
            If Demand_Dist(3) = "None" Then
                Demand_Mode(3) = CSng(row3(2))
                Demand_Corr(3) = CSng(row3(6))
            End If

            ' Demand Period 4
            If Demand_Dist(4) = "Normal" Then
                Demand_Mode(4) = CSng(row4(2))
                Demand_Stdev(4) = CSng(row4(3))
                Demand_Corr(4) = CSng(row4(6))
            End If
            If Demand_Dist(4) = "Trianglar" Then
                Demand_Mode(4) = CSng(row4(2))
                Demand_Low(4) = CSng(row4(4))
                Demand_High(4) = CSng(row4(5))
                Demand_Corr(4) = CSng(row4(6))
            End If
            If Demand_Dist(4) = "Uniform" Then
                Demand_Low(4) = CSng(row4(4))
                Demand_High(4) = CSng(row4(5))
                Demand_Corr(4) = CSng(row4(6))
            End If
            If Demand_Dist(4) = "None" Then
                Demand_Mode(4) = CSng(row4(2))
                Demand_Corr(4) = CSng(row4(6))
            End If

            ' Demand Period 5
            If Demand_Dist(5) = "Normal" Then
                Demand_Mode(5) = CSng(row5(2))
                Demand_Stdev(5) = CSng(row5(3))
                Demand_Corr(5) = CSng(row5(6))
            End If
            If Demand_Dist(5) = "Trianglar" Then
                Demand_Mode(5) = CSng(row5(2))
                Demand_Low(5) = CSng(row5(4))
                Demand_High(5) = CSng(row5(5))
                Demand_Corr(5) = CSng(row5(6))
            End If
            If Demand_Dist(5) = "Uniform" Then
                Demand_Low(5) = CSng(row5(4))
                Demand_High(5) = CSng(row5(5))
                Demand_Corr(5) = CSng(row5(6))
            End If
            If Demand_Dist(5) = "None" Then
                Demand_Mode(5) = CSng(row5(2))
                Demand_Corr(5) = CSng(row5(6))
            End If

            ' Demand Period 6
            If Demand_Dist(6) = "Normal" Then
                Demand_Mode(6) = CSng(row6(2))
                Demand_Stdev(6) = CSng(row6(3))
                Demand_Corr(6) = CSng(row6(6))
            End If
            If Demand_Dist(6) = "Trianglar" Then
                Demand_Mode(6) = CSng(row6(2))
                Demand_Low(6) = CSng(row6(4))
                Demand_High(6) = CSng(row6(5))
                Demand_Corr(6) = CSng(row6(6))
            End If
            If Demand_Dist(6) = "Uniform" Then
                Demand_Low(6) = CSng(row6(4))
                Demand_High(6) = CSng(row6(5))
                Demand_Corr(6) = CSng(row6(6))
            End If
            If Demand_Dist(6) = "None" Then
                Demand_Mode(6) = CSng(row6(2))
                Demand_Corr(6) = CSng(row6(6))
            End If

            ' Demand Period 7
            If Demand_Dist(7) = "Normal" Then
                Demand_Mode(7) = CSng(row7(2))
                Demand_Stdev(7) = CSng(row7(3))
                Demand_Corr(7) = CSng(row7(6))
            End If
            If Demand_Dist(7) = "Trianglar" Then
                Demand_Mode(7) = CSng(row7(2))
                Demand_Low(7) = CSng(row7(4))
                Demand_High(7) = CSng(row7(5))
                Demand_Corr(7) = CSng(row7(6))
            End If
            If Demand_Dist(7) = "Uniform" Then
                Demand_Low(7) = CSng(row7(4))
                Demand_High(7) = CSng(row7(5))
                Demand_Corr(7) = CSng(row7(6))
            End If
            If Demand_Dist(7) = "None" Then
                Demand_Mode(7) = CSng(row7(2))
                Demand_Corr(7) = CSng(row7(6))
            End If

            ' Demand Period 8
            If Demand_Dist(8) = "Normal" Then
                Demand_Mode(8) = CSng(row8(2))
                Demand_Stdev(8) = CSng(row8(3))
                Demand_Corr(8) = CSng(row8(6))
            End If
            If Demand_Dist(8) = "Trianglar" Then
                Demand_Mode(8) = CSng(row8(2))
                Demand_Low(8) = CSng(row8(4))
                Demand_High(8) = CSng(row8(5))
                Demand_Corr(8) = CSng(row8(6))
            End If
            If Demand_Dist(8) = "Uniform" Then
                Demand_Low(8) = CSng(row8(4))
                Demand_High(8) = CSng(row8(5))
                Demand_Corr(8) = CSng(row8(6))
            End If
            If Demand_Dist(8) = "None" Then
                Demand_Mode(8) = CSng(row8(2))
                Demand_Corr(8) = CSng(row8(6))
            End If

            ' Demand Period 9
            If Demand_Dist(9) = "Normal" Then
                Demand_Mode(9) = CSng(row9(2))
                Demand_Stdev(9) = CSng(row9(3))
                Demand_Corr(9) = CSng(row9(6))
            End If
            If Demand_Dist(9) = "Trianglar" Then
                Demand_Mode(9) = CSng(row9(2))
                Demand_Low(9) = CSng(row9(4))
                Demand_High(9) = CSng(row9(5))
                Demand_Corr(9) = CSng(row9(6))
            End If
            If Demand_Dist(9) = "Uniform" Then
                Demand_Low(9) = CSng(row9(4))
                Demand_High(9) = CSng(row9(5))
                Demand_Corr(9) = CSng(row9(6))
            End If
            If Demand_Dist(9) = "None" Then
                Demand_Mode(9) = CSng(row9(2))
                Demand_Corr(9) = CSng(row9(6))
            End If

            ' Demand Period 10
            If Demand_Dist(10) = "Normal" Then
                Demand_Mode(10) = CSng(row10(2))
                Demand_Stdev(10) = CSng(row10(3))
                Demand_Corr(10) = CSng(row10(6))
            End If
            If Demand_Dist(10) = "Trianglar" Then
                Demand_Mode(10) = CSng(row10(2))
                Demand_Low(10) = CSng(row10(4))
                Demand_High(10) = CSng(row10(5))
                Demand_Corr(10) = CSng(row10(6))
            End If
            If Demand_Dist(10) = "Uniform" Then
                Demand_Low(10) = CSng(row10(4))
                Demand_High(10) = CSng(row10(5))
                Demand_Corr(10) = CSng(row10(6))
            End If
            If Demand_Dist(10) = "None" Then
                Demand_Mode(10) = CSng(row10(2))
                Demand_Corr(10) = CSng(row10(6))
            End If


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
                ElseIf Int_Buy_Length > 10 Then
                    Int_Buy_Length = 10
                End If

                'Sample Demands for Buy Lengths
                For j = 1 To Int_Buy_Length
                    Demand = Demand_Sampler(j, Demand_Dist(j), Demand_Mode(j), Demand_Stdev(j), Demand_Low(j), Demand_High(j), Demand_Corr(j))
                    Total_Demand = Total_Demand + Demand
                Next

                'Account for the factional last year
                If Int_Buy_Length < 10 Then
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

            Dim Charts_Form As New Form2

            Charts_Form.ShowDialog()

            'Dim Charts As New Form2
            'Charts.mean_value = Mean_value
            'Charts.Stddev_value = Stddev_value
            'Charts.Samples = Samples
            'For i = 1 To Samples
            'Charts.Buy_total(i) = Buy_total(i)
            'Next





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
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

End Class