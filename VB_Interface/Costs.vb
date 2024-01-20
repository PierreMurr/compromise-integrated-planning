Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Costs
    Private Sub Costs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ci As Int16 = 0
        Dim iniX As Int16 = 70
        Dim iniY As Int16 = 10
        For Each dr As DataGridViewRow In MainSetup.TypeGrid.Rows
            If ci < MainSetup.TypeGrid.RowCount - 1 Then
                Dim GroupBox1 = New System.Windows.Forms.GroupBox()
                GroupBox1.BackColor = System.Drawing.Color.LightYellow
                GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                GroupBox1.Location = New System.Drawing.Point(iniX, iniY)
                GroupBox1.Name = dr.Cells("colName").Value.ToString()
                GroupBox1.Size = New System.Drawing.Size(410, 300)
                GroupBox1.Text = "Cost: " + dr.Cells("colName").Value.ToString()
                Controls.Add(GroupBox1)
                Dim BoxRisk = New System.Windows.Forms.GroupBox()
                If MainSetup.ChInRisk.Checked Then
                    BoxRisk.BackColor = System.Drawing.Color.LightYellow
                    BoxRisk.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                    BoxRisk.Location = New System.Drawing.Point(iniX, iniY + 320)
                    BoxRisk.Name = "R" + dr.Cells("colName").Value.ToString()
                    BoxRisk.Size = New System.Drawing.Size(410, 300)
                    BoxRisk.Text = "Risk: " + dr.Cells("colName").Value.ToString()
                    Controls.Add(BoxRisk)
                End If

                iniX = iniX + 550
                ci += 1
                If ci Mod 3 = 0 Then
                    iniX = 70
                    iniY = iniY + 100
                End If

                Dim CostGrid As New DataGridView()
                CostGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                CostGrid.Location = New Point(10, 25)
                CostGrid.Name = dr.Cells("colName").Value.ToString()
                CostGrid.RowHeadersWidth = 62
                CostGrid.RowTemplate.Height = 33
                CostGrid.Size = New Size(400, 275)
                CostGrid.TabIndex = 0
                CostGrid.AllowUserToAddRows = False
                CostGrid.AllowUserToDeleteRows = False

                AutoScaleDimensions = New SizeF(10.0F, 25.0F)
                AutoScaleMode = AutoScaleMode.Font
                ClientSize = New Size(1372, 653)
                GroupBox1.Controls.Add(CostGrid)

                CostGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                CostGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                CostGrid.EnableHeadersVisualStyles = False
                CostGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
                CostGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

                Dim RiskGrid As New DataGridView()

                If MainSetup.ChInRisk.Checked Then
                    RiskGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                    RiskGrid.Location = New Point(10, 25)
                    RiskGrid.Name = "R" + dr.Cells("colName").Value.ToString()
                    RiskGrid.RowHeadersWidth = 62
                    RiskGrid.RowTemplate.Height = 33
                    RiskGrid.Size = New Size(400, 275)
                    RiskGrid.TabIndex = 0
                    RiskGrid.AllowUserToAddRows = False
                    RiskGrid.AllowUserToDeleteRows = False

                    AutoScaleDimensions = New SizeF(10.0F, 25.0F)
                    AutoScaleMode = AutoScaleMode.Font
                    ClientSize = New Size(1372, 653)
                    BoxRisk.Controls.Add(RiskGrid)

                    RiskGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                    RiskGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    RiskGrid.EnableHeadersVisualStyles = False
                    RiskGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
                    RiskGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                End If

                Dim ci1 As Int16 = 0
                For Each dr1 As DataGridViewRow In MainSetup.custGrid.Rows
                    If ci1 < MainSetup.custGrid.RowCount - 1 Then
                        Dim col1 As String = dr1.Cells("cuName").Value.ToString() + vbNewLine + dr1.Cells("cudem").Value.ToString()
                        Dim col As New DataGridViewTextBoxColumn
                        col.HeaderText = col1
                        col.Name = col1
                        col.Width = 50
                        CostGrid.Columns.Add(col)
                        If MainSetup.ChInRisk.Checked Then
                            Dim rcol1 As String = dr1.Cells("cuName").Value.ToString() + vbNewLine + dr1.Cells("cudem").Value.ToString()
                            Dim rcol As New DataGridViewTextBoxColumn
                            rcol.HeaderText = rcol1
                            rcol.Name = col1
                            rcol.Width = 50
                            RiskGrid.Columns.Add(rcol)
                        End If
                        ci1 = ci1 + 1
                    End If
                Next
                ci1 = 0
                For Each dr2 As DataGridViewRow In MainSetup.WareGrid.Rows
                    If ci1 < MainSetup.WareGrid.RowCount - 1 Then
                        CostGrid.Rows.Add()
                        For j = 0 To CostGrid.Columns.Count - 1
                            CostGrid.Rows(ci1).Cells(j).Value = 0
                        Next
                        CostGrid.Rows(ci1).HeaderCell.Value = dr2.Cells("ColWNamw").Value.ToString() + ":" + dr2.Cells("Colavqty").Value.ToString()
                        If MainSetup.ChInRisk.Checked Then
                            RiskGrid.Rows.Add()
                            For j = 0 To RiskGrid.Columns.Count - 1
                                RiskGrid.Rows(ci1).Cells(j).Value = 0
                            Next
                            RiskGrid.Rows(ci1).HeaderCell.Value = dr2.Cells("ColWNamw").Value.ToString() + ":" + dr2.Cells("Colavqty").Value.ToString()
                        End If

                        ci1 = ci1 + 1
                    End If
                Next
            End If
        Next



    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim FILE_NAME As String = "costs.txt"
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        Dim ci As Int16 = 0
        ci = 0
        For Each dr As DataGridViewRow In MainSetup.TypeGrid.Rows
            If ci < MainSetup.TypeGrid.RowCount - 1 Then
                Dim ci1 As Int16 = 0

                Dim curGroup As GroupBox = Me.Controls.Find(dr.Cells("colName").Value.ToString(), True)(0)
                Dim curGrid As DataGridView = curGroup.Controls.Find(dr.Cells("colName").Value.ToString(), True)(0)
                For Each dr2 As DataGridViewRow In curGrid.Rows()
                    If ci1 < MainSetup.custGrid.RowCount - 1 Then
                        For j = 0 To curGrid.Columns.Count - 1
                            If j > 0 Then objWriter.Write(",")
                            Dim col1 As String = curGrid.Rows(ci1).Cells(j).Value().ToString
                            objWriter.Write(col1)
                        Next
                        objWriter.WriteLine("")
                        ci1 = ci1 + 1
                    End If
                Next
                ci = ci + 1
            End If
        Next
        objWriter.Close()


        Dim objWriter2 As New System.IO.StreamWriter("risks.txt")
        Dim ci2 As Int16 = 0
        ci2 = 0
        For Each dr As DataGridViewRow In MainSetup.TypeGrid.Rows
            If ci2 < MainSetup.TypeGrid.RowCount - 1 Then
                Dim ci1 As Int16 = 0

                Dim curGroup As GroupBox = Me.Controls.Find("R" + dr.Cells("colName").Value.ToString(), True)(0)
                Dim curGrid As DataGridView = curGroup.Controls.Find("R" + dr.Cells("colName").Value.ToString(), True)(0)
                For Each dr2 As DataGridViewRow In curGrid.Rows()
                    If ci1 < MainSetup.custGrid.RowCount - 1 Then
                        For j = 0 To curGrid.Columns.Count - 1
                            If j > 0 Then objWriter2.Write(",")
                            Dim col1 As String = curGrid.Rows(ci1).Cells(j).Value().ToString
                            objWriter2.Write(col1)
                        Next
                        objWriter2.WriteLine("")
                        ci1 = ci1 + 1
                    End If
                Next
                ci2 = ci2 + 1
            End If
        Next
        objWriter2.Close()

    End Sub

    Private Sub bCalc_Click(sender As Object, e As EventArgs) Handles bCalc.Click
        ShowRes.Show()
    End Sub

    Private Sub bLoad_Click(sender As Object, e As EventArgs) Handles bLoad.Click
        Dim tfp As New TextFieldParser("Costs.txt")
        tfp.Delimiters = New String() {","}
        tfp.TextFieldType = FieldType.Delimited
        Dim ci As Int16 = 0
        For Each dr As DataGridViewRow In MainSetup.TypeGrid.Rows
            If ci < MainSetup.TypeGrid.RowCount - 1 Then
                Dim curGroup As GroupBox = Me.Controls.Find(dr.Cells("colName").Value.ToString(), True)(0)
                Dim curGrid As DataGridView = curGroup.Controls.Find(dr.Cells("colName").Value.ToString(), True)(0)
                For i = 0 To MainSetup.WareGrid.RowCount - 2
                    Dim values = tfp.ReadFields()
                    For j = 0 To values.Length() - 1
                        curGrid.Rows(i).Cells(j).Value = Int(values(j))
                    Next
                Next
            End If
            ci = ci + 1
        Next


        If MainSetup.ChInRisk.Checked Then
            Dim tfp2 As New TextFieldParser("risks.txt")
            tfp2.Delimiters = New String() {","}
            tfp2.TextFieldType = FieldType.Delimited
            ci = 0
            For Each dr As DataGridViewRow In MainSetup.TypeGrid.Rows
                If ci < MainSetup.TypeGrid.RowCount - 1 Then
                    Dim curGroup As GroupBox = Me.Controls.Find("R" + dr.Cells("colName").Value.ToString(), True)(0)
                    Dim curGrid As DataGridView = curGroup.Controls.Find("R" + dr.Cells("colName").Value.ToString(), True)(0)
                    For i = 0 To MainSetup.WareGrid.RowCount - 2
                        Dim values = tfp2.ReadFields()
                        For j = 0 To values.Length() - 1
                            curGrid.Rows(i).Cells(j).Value = values(j)
                        Next
                    Next
                End If
                ci = ci + 1
            Next
        End If

    End Sub
End Class