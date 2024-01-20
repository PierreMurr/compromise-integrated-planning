<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Costs
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
        Me.bCalc = New System.Windows.Forms.Button()
        Me.bLoad = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bCalc
        '
        Me.bCalc.BackColor = System.Drawing.Color.LightYellow
        Me.bCalc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bCalc.ForeColor = System.Drawing.Color.Red
        Me.bCalc.Location = New System.Drawing.Point(601, 645)
        Me.bCalc.Margin = New System.Windows.Forms.Padding(2)
        Me.bCalc.Name = "bCalc"
        Me.bCalc.Size = New System.Drawing.Size(180, 49)
        Me.bCalc.TabIndex = 16
        Me.bCalc.Text = "Results"
        Me.bCalc.UseVisualStyleBackColor = False
        '
        'bLoad
        '
        Me.bLoad.BackColor = System.Drawing.Color.LightYellow
        Me.bLoad.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bLoad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.bLoad.Location = New System.Drawing.Point(440, 645)
        Me.bLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.bLoad.Name = "bLoad"
        Me.bLoad.Size = New System.Drawing.Size(157, 49)
        Me.bLoad.TabIndex = 15
        Me.bLoad.Text = "Load"
        Me.bLoad.UseVisualStyleBackColor = False
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.LightYellow
        Me.bSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bSave.ForeColor = System.Drawing.Color.RoyalBlue
        Me.bSave.Location = New System.Drawing.Point(279, 645)
        Me.bSave.Margin = New System.Windows.Forms.Padding(2)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(157, 49)
        Me.bSave.TabIndex = 14
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'Costs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1482, 703)
        Me.Controls.Add(Me.bCalc)
        Me.Controls.Add(Me.bLoad)
        Me.Controls.Add(Me.bSave)
        Me.Name = "Costs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bCalc As Button
    Friend WithEvents bLoad As Button
    Friend WithEvents bSave As Button
End Class
