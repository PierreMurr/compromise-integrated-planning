Imports System.CodeDom.Compiler
Imports System.Globalization
Imports System.IO
Imports System.Linq.Expressions
Imports System.Net
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ShowRes
    Private Sub ShowRes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData("Costs", "", 70)
        ShowData("Risks", "R", 620)
        Dim CompGrid As New DataGridView()
        CompGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CompGrid.Location = New Point(10, 25)
        CompGrid.Name = "CompGrid"
        CompGrid.RowHeadersWidth = 62
        CompGrid.RowTemplate.Height = 33
        CompGrid.Size = New Size(400, 275)
        CompGrid.TabIndex = 0
        CompGrid.AllowUserToAddRows = False
        CompGrid.AllowUserToDeleteRows = False

        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1372, 653)
        CompromiseBox.Controls.Add(CompGrid)

        CompGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        CompGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        CompGrid.EnableHeadersVisualStyles = False
        CompGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

        Dim GroupCost As GroupBox = Me.Controls.Find("Costs", True)(0)
        Dim GroupRisk As GroupBox = Me.Controls.Find("Risks", True)(0)

        Dim curCost As DataGridView = GroupCost.Controls.Find("Costs", True)(0)
        Dim curRisk As DataGridView = GroupRisk.Controls.Find("Risks", True)(0)



        Dim ci1 As Int16 = 0
        For Each dr1 As DataGridViewRow In MainSetup.custGrid.Rows
            If ci1 < MainSetup.custGrid.RowCount - 1 Then
                Dim col1 As String = dr1.Cells("cuName").Value.ToString() + vbNewLine + dr1.Cells("cudem").Value.ToString()
                Dim col As New DataGridViewTextBoxColumn
                col.HeaderText = col1
                col.Name = col1
                col.Width = 70
                CompGrid.Columns.Add(col)
                ci1 = ci1 + 1
            End If
        Next
        ci1 = 0
        Dim objCompval As Integer = 0
        Dim objriskval As Double = 0.0
        For Each dr2 As DataGridViewRow In MainSetup.WareGrid.Rows
            If ci1 < MainSetup.WareGrid.RowCount - 1 Then
                CompGrid.Rows.Add()
                For j = 0 To CompGrid.Columns.Count - 1
                    CompGrid.Rows(ci1).Cells(j).Value = curCost.Rows(ci1).Cells(j).Value * MainSetup.txtCost.Text + curRisk.Rows(ci1).Cells(j).Value * MainSetup.txtRisk.Text
                    objCompval += CompGrid.Rows(ci1).Cells(j).Value * FindMin(ci1, j, "")
                    objriskval += CompGrid.Rows(ci1).Cells(j).Value * FindMin(ci1, j, "R") * 1.0
                Next
                CompGrid.Rows(ci1).HeaderCell.Value = dr2.Cells("ColWNamw").Value.ToString() + ":" + dr2.Cells("Colavqty").Value.ToString()
                ci1 = ci1 + 1
            End If
        Next
        lcCost.Text = String.Format("{0,6}", objCompval)
        lcRisk.Text = String.Format("{0,6}", objriskval)
        DifCost.Text = String.Format("{0,6}", (objCompval - Int(ObjCost.Text)))
        Dim valint As Double = objriskval - Int(ObjRisk.Text)
        DifRisk.Text = valint.ToString("N2", CultureInfo.InvariantCulture) ' String.Format("{0,6}", (objriskval - Int(ObjRisk.Text)))
    End Sub
    Private Function FindMin(fi As Int16, fj As Int16, gridname As String) As Double
        Dim theMin As Double = 1000000.0
        Dim ci As Int16 = 0
        For Each dr As DataGridViewRow In MainSetup.TypeGrid.Rows
            If ci < MainSetup.TypeGrid.RowCount - 1 Then
                Dim ci1 As Int16 = 0
                Dim curGroup As GroupBox = Costs.Controls.Find(gridname + dr.Cells("colName").Value.ToString(), True)(0)
                Dim curGrid As DataGridView = curGroup.Controls.Find(gridname + dr.Cells("colName").Value.ToString(), True)(0)
                For Each dr2 As DataGridViewRow In curGrid.Rows()
                    For j = 0 To curGrid.Columns.Count - 1
                        If ci1 = fi And j = fj Then
                            If curGrid.Rows(ci1).Cells(j).Value() < theMin Then theMin = curGrid.Rows(ci1).Cells(j).Value()
                        End If
                    Next
                    ci1 += 1
                Next
            End If
            ci = ci + 1
        Next

        Return theMin
    End Function
    Private Sub ShowData(varName As String, gridname As String, xPos As Int16)
        Dim ci As Int16 = 0
        Dim iniX As Int16 = xPos
        Dim iniY As Int16 = 10
        Dim GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.BackColor = System.Drawing.Color.LightYellow
        GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        GroupBox1.Location = New System.Drawing.Point(iniX, iniY)
        GroupBox1.Name = varName
        GroupBox1.Size = New System.Drawing.Size(410, 300)
        GroupBox1.Text = varName
        Controls.Add(GroupBox1)


        Dim CostGrid As New DataGridView()
        CostGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CostGrid.Location = New Point(10, 25)
        CostGrid.Name = varName
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
        CostGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders


        Dim ci1 As Int16 = 0
        For Each dr1 As DataGridViewRow In MainSetup.custGrid.Rows
            If ci1 < MainSetup.custGrid.RowCount - 1 Then
                Dim col1 As String = dr1.Cells("cuName").Value.ToString() + vbNewLine + dr1.Cells("cudem").Value.ToString()
                Dim col As New DataGridViewTextBoxColumn
                col.HeaderText = col1
                col.Name = col1
                col.Width = 70
                CostGrid.Columns.Add(col)
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
                ci1 = ci1 + 1
            End If
        Next


        Dim varToSend = ""
        varToSend += "{""Demand"": ["
        ci1 = 0
        Dim ttemp As String = ""

        For Each dr2 As DataGridViewRow In MainSetup.custGrid.Rows
            If ci1 < MainSetup.custGrid.RowCount - 1 Then
                If ci1 > 0 Then ttemp += ","
                ttemp += dr2.Cells("cudem").Value.ToString()
                ci1 = ci1 + 1
            End If
        Next
        varToSend += ttemp
        varToSend += "],""Capacity"": ["
        ci1 = 0
        ttemp = ""
        For Each dr2 As DataGridViewRow In MainSetup.WareGrid.Rows
            If ci1 < MainSetup.WareGrid.RowCount - 1 Then
                If ci1 > 0 Then ttemp += ","
                ttemp += dr2.Cells("colAvQty").Value.ToString()
                ci1 = ci1 + 1
            End If
        Next
        varToSend += ttemp + "],"

        ci = 0
        varToSend += " ""Costs"": ["
        For Each dr As DataGridViewRow In MainSetup.TypeGrid.Rows

            If ci < MainSetup.TypeGrid.RowCount - 1 Then
                If ci > 0 Then varToSend += ","
                varToSend += "{""Type"":" + """" + dr.Cells("colName").Value.ToString() + """"
                varToSend += ",""Cost"":["

                ci1 = 0

                Dim curGroup As GroupBox = Costs.Controls.Find(gridname + dr.Cells("colName").Value.ToString(), True)(0)
                Dim curGrid As DataGridView = curGroup.Controls.Find(gridname + dr.Cells("colName").Value.ToString(), True)(0)

                For Each dr2 As DataGridViewRow In curGrid.Rows()
                    If ci1 > 0 Then varToSend += ","
                    varToSend += "["
                    For j = 0 To curGrid.Columns.Count - 1
                        If j > 0 Then varToSend += ","
                        varToSend += curGrid.Rows(ci1).Cells(j).Value().ToString
                    Next
                    varToSend += "]"
                    ci1 += 1
                Next
                varToSend += "]}"

            End If
            ci = ci + 1
        Next

        varToSend += " ]}"
        Clipboard.SetText(varToSend)
        ' MsgBox(varToSend)
        'Return


        Dim client As New WebClient
        'Dim JSONdata As String = client.DownloadString("http://localhost:5000/mainform?data=" + varToSend)
        Dim JSONdata As String = client.DownloadString("https://pierremurr.pythonanywhere.com/mainform?data=" + varToSend)
        'Clipboard.SetText(JSONdata)
        Dim jvalues = JsonConvert.DeserializeObject(Of List(Of List(Of Integer)))(JSONdata)

        Dim gi, gj As Int16
        gi = 0
        gj = 0
        Dim stkNbr As Int16 = 0
        For Each valx In jvalues
            If stkNbr < MainSetup.WareGrid.RowCount - 1 Then
                For Each y In valx
                    CostGrid.Rows(gi).Cells(gj).Value = Str(y)
                    gj += 1
                Next
                gi += 1
                gj = 0
            Else
                If varName = "Costs" Then
                    ObjCost.Visible = True
                    ObjCost.Text = String.Format("{0,5}", valx(0))
                End If
                If varName = "Risks" Then
                    ObjRisk.Visible = True
                    ObjRisk.Text = String.Format("{0,5}", valx(0))
                End If
            End If
            stkNbr += 1
        Next

    End Sub


End Class