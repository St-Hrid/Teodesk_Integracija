<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KReator_2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLabelSource1 = New System.Windows.Forms.Label()
        Me.lblTextSource1 = New System.Windows.Forms.Label()
        Me.lblLabelTarget = New System.Windows.Forms.Label()
        Me.lblTextTarget = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLabelSource1
        '
        Me.lblLabelSource1.AllowDrop = True
        Me.lblLabelSource1.AutoSize = True
        Me.lblLabelSource1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblLabelSource1.Location = New System.Drawing.Point(76, 44)
        Me.lblLabelSource1.Name = "lblLabelSource1"
        Me.lblLabelSource1.Size = New System.Drawing.Size(51, 17)
        Me.lblLabelSource1.TabIndex = 0
        Me.lblLabelSource1.Text = "Label1"
        '
        'lblTextSource1
        '
        Me.lblTextSource1.AllowDrop = True
        Me.lblTextSource1.AutoSize = True
        Me.lblTextSource1.Location = New System.Drawing.Point(76, 89)
        Me.lblTextSource1.Name = "lblTextSource1"
        Me.lblTextSource1.Size = New System.Drawing.Size(51, 17)
        Me.lblTextSource1.TabIndex = 1
        Me.lblTextSource1.Text = "Label2"
        '
        'lblLabelTarget
        '
        Me.lblLabelTarget.AllowDrop = True
        Me.lblLabelTarget.AutoSize = True
        Me.lblLabelTarget.Location = New System.Drawing.Point(420, 55)
        Me.lblLabelTarget.Name = "lblLabelTarget"
        Me.lblLabelTarget.Size = New System.Drawing.Size(51, 17)
        Me.lblLabelTarget.TabIndex = 2
        Me.lblLabelTarget.Text = "Label3"
        '
        'lblTextTarget
        '
        Me.lblTextTarget.AllowDrop = True
        Me.lblTextTarget.AutoSize = True
        Me.lblTextTarget.Location = New System.Drawing.Point(420, 109)
        Me.lblTextTarget.Name = "lblTextTarget"
        Me.lblTextTarget.Size = New System.Drawing.Size(48, 17)
        Me.lblTextTarget.TabIndex = 3
        Me.lblTextTarget.Text = "Labe7"
        '
        'KReator_2
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTextTarget)
        Me.Controls.Add(Me.lblLabelTarget)
        Me.Controls.Add(Me.lblTextSource1)
        Me.Controls.Add(Me.lblLabelSource1)
        Me.Name = "KReator_2"
        Me.Text = "KReator_2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLabelSource1 As Windows.Forms.Label
    Friend WithEvents lblTextSource1 As Windows.Forms.Label
    Friend WithEvents lblLabelTarget As Windows.Forms.Label
    Friend WithEvents lblTextTarget As Windows.Forms.Label
End Class
