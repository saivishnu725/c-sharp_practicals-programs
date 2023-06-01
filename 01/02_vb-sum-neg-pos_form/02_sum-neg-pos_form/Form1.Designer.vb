<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TheForm
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
        Me.toplabel = New System.Windows.Forms.Label()
        Me.inputlabel = New System.Windows.Forms.Label()
        Me.negoutputlabel = New System.Windows.Forms.Label()
        Me.posoutputlabel = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.negoutput = New System.Windows.Forms.TextBox()
        Me.posoutput = New System.Windows.Forms.TextBox()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.calcbtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'toplabel
        '
        Me.toplabel.AutoSize = True
        Me.toplabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toplabel.Location = New System.Drawing.Point(155, 34)
        Me.toplabel.Name = "toplabel"
        Me.toplabel.Size = New System.Drawing.Size(287, 23)
        Me.toplabel.TabIndex = 0
        Me.toplabel.Text = "Sum of Negative and Positive numbers"
        '
        'inputlabel
        '
        Me.inputlabel.AutoSize = True
        Me.inputlabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputlabel.Location = New System.Drawing.Point(93, 118)
        Me.inputlabel.Name = "inputlabel"
        Me.inputlabel.Size = New System.Drawing.Size(217, 23)
        Me.inputlabel.TabIndex = 1
        Me.inputlabel.Text = "Enter the number of inputs: "
        '
        'negoutputlabel
        '
        Me.negoutputlabel.AutoSize = True
        Me.negoutputlabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.negoutputlabel.Location = New System.Drawing.Point(113, 257)
        Me.negoutputlabel.Name = "negoutputlabel"
        Me.negoutputlabel.Size = New System.Drawing.Size(206, 23)
        Me.negoutputlabel.TabIndex = 2
        Me.negoutputlabel.Text = "Sum of Negative numbers: "
        '
        'posoutputlabel
        '
        Me.posoutputlabel.AutoSize = True
        Me.posoutputlabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.posoutputlabel.Location = New System.Drawing.Point(113, 310)
        Me.posoutputlabel.Name = "posoutputlabel"
        Me.posoutputlabel.Size = New System.Drawing.Size(197, 23)
        Me.posoutputlabel.TabIndex = 3
        Me.posoutputlabel.Text = "Sum of Positive numbers: "
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(369, 118)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(189, 20)
        Me.input.TabIndex = 4
        '
        'negoutput
        '
        Me.negoutput.Location = New System.Drawing.Point(369, 261)
        Me.negoutput.Name = "negoutput"
        Me.negoutput.Size = New System.Drawing.Size(189, 20)
        Me.negoutput.TabIndex = 5
        '
        'posoutput
        '
        Me.posoutput.Location = New System.Drawing.Point(369, 314)
        Me.posoutput.Name = "posoutput"
        Me.posoutput.Size = New System.Drawing.Size(189, 20)
        Me.posoutput.TabIndex = 6
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.clearbtn.Location = New System.Drawing.Point(52, 206)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(75, 23)
        Me.clearbtn.TabIndex = 7
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'calcbtn
        '
        Me.calcbtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.calcbtn.Location = New System.Drawing.Point(262, 206)
        Me.calcbtn.Name = "calcbtn"
        Me.calcbtn.Size = New System.Drawing.Size(75, 23)
        Me.calcbtn.TabIndex = 8
        Me.calcbtn.Text = "Calculate"
        Me.calcbtn.UseVisualStyleBackColor = False
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.exitbtn.Location = New System.Drawing.Point(455, 205)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(75, 23)
        Me.exitbtn.TabIndex = 9
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'TheForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(634, 416)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.calcbtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.posoutput)
        Me.Controls.Add(Me.negoutput)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.posoutputlabel)
        Me.Controls.Add(Me.negoutputlabel)
        Me.Controls.Add(Me.inputlabel)
        Me.Controls.Add(Me.toplabel)
        Me.Name = "TheForm"
        Me.Text = "Sum of negative and positive numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toplabel As Label
    Friend WithEvents inputlabel As Label
    Friend WithEvents negoutputlabel As Label
    Friend WithEvents posoutputlabel As Label
    Friend WithEvents input As TextBox
    Friend WithEvents negoutput As TextBox
    Friend WithEvents posoutput As TextBox
    Friend WithEvents clearbtn As Button
    Friend WithEvents calcbtn As Button
    Friend WithEvents exitbtn As Button
End Class
