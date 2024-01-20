<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bLoad = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WareGrid = New System.Windows.Forms.DataGridView()
        Me.ColWNamw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAvQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.custGrid = New System.Windows.Forms.DataGridView()
        Me.cuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuDem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TypeGrid = New System.Windows.Forms.DataGridView()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bCosts = New System.Windows.Forms.Button()
        Me.ChInRisk = New System.Windows.Forms.CheckBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.WareGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.custGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TypeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Calibri", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(497, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(489, 58)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Transportation Problem"
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.LightYellow
        Me.bSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bSave.ForeColor = System.Drawing.Color.RoyalBlue
        Me.bSave.Location = New System.Drawing.Point(443, 581)
        Me.bSave.Margin = New System.Windows.Forms.Padding(2)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(157, 49)
        Me.bSave.TabIndex = 8
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'bLoad
        '
        Me.bLoad.BackColor = System.Drawing.Color.LightYellow
        Me.bLoad.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bLoad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.bLoad.Location = New System.Drawing.Point(602, 581)
        Me.bLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.bLoad.Name = "bLoad"
        Me.bLoad.Size = New System.Drawing.Size(157, 49)
        Me.bLoad.TabIndex = 9
        Me.bLoad.Text = "Load"
        Me.bLoad.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox1.Controls.Add(Me.WareGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 409)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Warehouses"
        '
        'WareGrid
        '
        Me.WareGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.WareGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WareGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColWNamw, Me.ColAvQty})
        Me.WareGrid.Location = New System.Drawing.Point(19, 27)
        Me.WareGrid.Name = "WareGrid"
        Me.WareGrid.RowHeadersWidth = 51
        Me.WareGrid.RowTemplate.Height = 29
        Me.WareGrid.Size = New System.Drawing.Size(424, 372)
        Me.WareGrid.TabIndex = 0
        '
        'ColWNamw
        '
        Me.ColWNamw.HeaderText = "Name"
        Me.ColWNamw.MinimumWidth = 6
        Me.ColWNamw.Name = "ColWNamw"
        Me.ColWNamw.Width = 220
        '
        'ColAvQty
        '
        Me.ColAvQty.HeaderText = "Supply"
        Me.ColAvQty.MinimumWidth = 6
        Me.ColAvQty.Name = "ColAvQty"
        Me.ColAvQty.Width = 150
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox2.Controls.Add(Me.custGrid)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(514, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 409)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customers"
        '
        'custGrid
        '
        Me.custGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.custGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.custGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuName, Me.cuDem})
        Me.custGrid.Location = New System.Drawing.Point(16, 27)
        Me.custGrid.Name = "custGrid"
        Me.custGrid.RowHeadersWidth = 51
        Me.custGrid.RowTemplate.Height = 29
        Me.custGrid.Size = New System.Drawing.Size(424, 372)
        Me.custGrid.TabIndex = 1
        '
        'cuName
        '
        Me.cuName.HeaderText = "Name"
        Me.cuName.MinimumWidth = 6
        Me.cuName.Name = "cuName"
        Me.cuName.Width = 220
        '
        'cuDem
        '
        Me.cuDem.HeaderText = "Demand"
        Me.cuDem.MinimumWidth = 6
        Me.cuDem.Name = "cuDem"
        Me.cuDem.Width = 150
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox3.Controls.Add(Me.TypeGrid)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(993, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(461, 415)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transport type"
        '
        'TypeGrid
        '
        Me.TypeGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.TypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TypeGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColName})
        Me.TypeGrid.Location = New System.Drawing.Point(26, 27)
        Me.TypeGrid.Name = "TypeGrid"
        Me.TypeGrid.RowHeadersWidth = 51
        Me.TypeGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TypeGrid.RowTemplate.Height = 29
        Me.TypeGrid.Size = New System.Drawing.Size(424, 372)
        Me.TypeGrid.TabIndex = 7
        '
        'ColName
        '
        Me.ColName.HeaderText = "Type Name"
        Me.ColName.MinimumWidth = 6
        Me.ColName.Name = "ColName"
        Me.ColName.Width = 370
        '
        'bCosts
        '
        Me.bCosts.BackColor = System.Drawing.Color.LightYellow
        Me.bCosts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bCosts.ForeColor = System.Drawing.Color.Red
        Me.bCosts.Location = New System.Drawing.Point(763, 581)
        Me.bCosts.Margin = New System.Windows.Forms.Padding(2)
        Me.bCosts.Name = "bCosts"
        Me.bCosts.Size = New System.Drawing.Size(157, 49)
        Me.bCosts.TabIndex = 13
        Me.bCosts.Text = "Costs"
        Me.bCosts.UseVisualStyleBackColor = False
        '
        'ChInRisk
        '
        Me.ChInRisk.AutoSize = True
        Me.ChInRisk.BackColor = System.Drawing.Color.LightYellow
        Me.ChInRisk.Checked = True
        Me.ChInRisk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChInRisk.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChInRisk.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ChInRisk.Location = New System.Drawing.Point(1315, 541)
        Me.ChInRisk.Name = "ChInRisk"
        Me.ChInRisk.Size = New System.Drawing.Size(139, 28)
        Me.ChInRisk.TabIndex = 14
        Me.ChInRisk.Text = "Include Risks"
        Me.ChInRisk.UseVisualStyleBackColor = False
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(1127, 542)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(68, 27)
        Me.txtCost.TabIndex = 15
        Me.txtCost.Text = "0"
        '
        'txtRisk
        '
        Me.txtRisk.Location = New System.Drawing.Point(1127, 575)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(68, 27)
        Me.txtRisk.TabIndex = 16
        Me.txtRisk.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(1055, 545)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Cost %"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(1055, 578)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Risk %"
        '
        'MainSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1482, 653)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.ChInRisk)
        Me.Controls.Add(Me.bCosts)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bLoad)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transportation Problem Setup"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.WareGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.custGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TypeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents bSave As Button
    Friend WithEvents bLoad As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TypeGrid As DataGridView
    Friend WithEvents WareGrid As DataGridView
    Friend WithEvents custGrid As DataGridView
    Friend WithEvents bCosts As Button
    Friend WithEvents ColWNamw As DataGridViewTextBoxColumn
    Friend WithEvents ColAvQty As DataGridViewTextBoxColumn
    Friend WithEvents cuName As DataGridViewTextBoxColumn
    Friend WithEvents cuDem As DataGridViewTextBoxColumn
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents ChInRisk As CheckBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtRisk As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
