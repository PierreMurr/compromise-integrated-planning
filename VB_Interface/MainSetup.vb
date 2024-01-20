Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Xml
Imports Microsoft.VisualBasic.FileIO
Imports Newtonsoft.Json

Public Class MainSetup

    Private Sub bReset_Click(sender As Object, e As EventArgs)
        'Dim Y As Integer = 110
        'Dim X As Integer = 15
        'For i = 0 To ListWareHouse.Items.Count - 1
        '    Dim newwar As New System.Windows.Forms.Label()
        '    'newtext.Height = 110
        '    newwar.Width = 50
        '    newwar.Top = Y
        '    newwar.Left = X
        '    GroupCosts.Controls.Add(newwar)
        '    newwar.Name = "LabW" + i.ToString
        '    newwar.Text = ListWareHouse.Items(i).SubItems(1).Text
        '    newwar.Font = New Font("Times New Roman", 12)
        '    newwar.ForeColor = Color.Red
        '    Y = Y + 50
        '    X = X + 0
        'Next
        'Y = 85
        'X = 15 + 50
        'For i = 0 To ListCustomer.Items.Count - 1
        '    Dim newwar As New System.Windows.Forms.Label()
        '    newwar.Width = 50
        '    newwar.Top = Y
        '    newwar.Left = X
        '    GroupCosts.Controls.Add(newwar)
        '    newwar.Name = "LabC" + i.ToString
        '    newwar.Text = ListCustomer.Items(i).SubItems(1).Text
        '    newwar.Font = New Font("Times New Roman", 12)
        '    newwar.ForeColor = Color.Red
        '    Y = Y + 0
        '    X = X + 50
        'Next
        'Y = 110
        'X = 65
        'For i = 0 To ListWareHouse.Items.Count - 1
        '    For j = 0 To ListCustomer.Items.Count - 1
        '        Dim newwar As New System.Windows.Forms.TextBox
        '        newwar.Width = 50
        '        newwar.Top = Y
        '        newwar.Left = X
        '        GroupCosts.Controls.Add(newwar)
        '        newwar.Name = "txt" + i.ToString + j.ToString
        '        newwar.Text = 0
        '        newwar.Font = New Font("Times New Roman", 12)
        '        newwar.ForeColor = Color.Black
        '        X = X + 50
        '    Next
        '    X = 65
        '    Y = Y + 50
        'Next



    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim FILE_NAME As String = "data.txt"
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        Dim ci As Int16 = 0

        For Each dr As DataGridViewRow In WareGrid.Rows
            If ci < WareGrid.RowCount - 1 Then
                Dim col1 As String = dr.Cells("ColWNamw").Value.ToString()
                objWriter.Write(col1)
                If ci < WareGrid.RowCount - 2 Then
                    objWriter.Write(",")
                Else
                    objWriter.WriteLine("")
                End If
                ci = ci + 1
            End If
        Next
        ci = 0
        For Each dr As DataGridViewRow In WareGrid.Rows
            If ci < WareGrid.RowCount - 1 Then
                Dim col1 As String = dr.Cells("Colavqty").Value.ToString()
                objWriter.Write(col1)
                If ci < WareGrid.RowCount - 2 Then
                    objWriter.Write(",")
                Else
                    objWriter.WriteLine("")
                End If
                ci = ci + 1
            End If
        Next
        ci = 0
        For Each dr As DataGridViewRow In custGrid.Rows
            If ci < custGrid.RowCount - 1 Then
                Dim col1 As String = dr.Cells("cuName").Value.ToString()
                objWriter.Write(col1)
                If ci < custGrid.RowCount - 2 Then
                    objWriter.Write(",")
                Else
                    objWriter.WriteLine("")
                End If
                ci = ci + 1
            End If
        Next
        ci = 0
        For Each dr As DataGridViewRow In custGrid.Rows
            If ci < custGrid.RowCount - 1 Then
                Dim col1 As String = dr.Cells("cuDem").Value.ToString()
                objWriter.Write(col1)
                If ci < custGrid.RowCount - 2 Then
                    objWriter.Write(",")
                Else
                    objWriter.WriteLine("")
                End If
                ci = ci + 1
            End If
        Next

        ci = 0
        For Each dr As DataGridViewRow In TypeGrid.Rows
            If ci < TypeGrid.RowCount - 1 Then
                Dim col1 As String = dr.Cells("ColName").Value.ToString()
                objWriter.Write(col1)
                If ci < TypeGrid.RowCount - 2 Then
                    objWriter.Write(",")
                Else
                    objWriter.WriteLine("")
                End If
                ci = ci + 1

            End If
        Next

        objWriter.Close()

        Dim FILE_CR As String = "costrisks.txt"
        Dim objWriter1 As New System.IO.StreamWriter(FILE_CR)
        objWriter1.WriteLine(txtCost.Text)
        objWriter1.WriteLine(txtRisk.Text)
        objWriter1.Close()

    End Sub

    Public Class clsIcons

        Public value()() As Integer


    End Class
    Private Sub bLoad_Click(sender As Object, e As EventArgs) Handles bLoad.Click

        Dim tfp As New TextFieldParser("data.txt")
        tfp.Delimiters = New String() {","}
        tfp.TextFieldType = FieldType.Delimited
        Dim wnames = tfp.ReadFields()
        Dim wcap = tfp.ReadFields()
        For i = 0 To wnames.Length() - 1
            WareGrid.Rows.Add(wnames(i), wcap(i))
        Next

        Dim wcnames = tfp.ReadFields()
        Dim wdem = tfp.ReadFields()
        For i = 0 To wdem.Length() - 1
            custGrid.Rows.Add(wcnames(i), wdem(i))
        Next

        Dim wtype = tfp.ReadFields()
        For i = 0 To wtype.Length() - 1
            TypeGrid.Rows.Add(wtype(i))
        Next

        Try
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader("costrisks.txt")

            txtCost.Text = reader.ReadLine
            txtRisk.Text = reader.ReadLine
            reader.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub bCosts_Click(sender As Object, e As EventArgs) Handles bCosts.Click
        Costs.Show()
    End Sub


End Class