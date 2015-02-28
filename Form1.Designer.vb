<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ClearClipboard = New System.Windows.Forms.Button()
        Me.Pasted = New System.Windows.Forms.RichTextBox()
        Me.Copyed = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'ClearClipboard
        '
        Me.ClearClipboard.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearClipboard.Location = New System.Drawing.Point(12, 12)
        Me.ClearClipboard.Name = "ClearClipboard"
        Me.ClearClipboard.Size = New System.Drawing.Size(1033, 85)
        Me.ClearClipboard.TabIndex = 0
        Me.ClearClipboard.Text = "Clear Clipboard"
        Me.ClearClipboard.UseVisualStyleBackColor = True
        '
        'Pasted
        '
        Me.Pasted.Location = New System.Drawing.Point(12, 179)
        Me.Pasted.Name = "Pasted"
        Me.Pasted.Size = New System.Drawing.Size(503, 262)
        Me.Pasted.TabIndex = 1
        Me.Pasted.Text = ""
        '
        'Copyed
        '
        Me.Copyed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Copyed.Location = New System.Drawing.Point(542, 179)
        Me.Copyed.Name = "Copyed"
        Me.Copyed.Size = New System.Drawing.Size(503, 262)
        Me.Copyed.TabIndex = 1
        Me.Copyed.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(503, 70)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Paste"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(542, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(503, 69)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Copy"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 447)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(503, 37)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(542, 447)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(503, 37)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Load"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Clips|*.clip|Text file|*.txt"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Clips|*.clip|Text file|*.txt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ezClip - Open Source Clipboard Manager - version 0.9"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(995, 491)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(50, 17)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Author"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1057, 513)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Copyed)
        Me.Controls.Add(Me.Pasted)
        Me.Controls.Add(Me.ClearClipboard)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1075, 560)
        Me.MinimumSize = New System.Drawing.Size(1075, 560)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClearClipboard As System.Windows.Forms.Button
    Friend WithEvents Pasted As System.Windows.Forms.RichTextBox
    Friend WithEvents Copyed As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
