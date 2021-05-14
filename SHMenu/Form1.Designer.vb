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
        Me.MenuOne = New System.Windows.Forms.Panel()
        Me.BotaoMenuOne = New System.Windows.Forms.Button()
        Me.MenuTwo = New System.Windows.Forms.Panel()
        Me.BotaoMenuTwo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuOne.SuspendLayout()
        Me.MenuTwo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuOne
        '
        Me.MenuOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MenuOne.Controls.Add(Me.Button1)
        Me.MenuOne.Location = New System.Drawing.Point(12, 12)
        Me.MenuOne.Name = "MenuOne"
        Me.MenuOne.Size = New System.Drawing.Size(200, 537)
        Me.MenuOne.TabIndex = 0
        '
        'BotaoMenuOne
        '
        Me.BotaoMenuOne.Location = New System.Drawing.Point(218, 12)
        Me.BotaoMenuOne.Name = "BotaoMenuOne"
        Me.BotaoMenuOne.Size = New System.Drawing.Size(75, 23)
        Me.BotaoMenuOne.TabIndex = 2
        Me.BotaoMenuOne.Text = "Open/Close"
        Me.BotaoMenuOne.UseVisualStyleBackColor = True
        '
        'MenuTwo
        '
        Me.MenuTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MenuTwo.Controls.Add(Me.Button2)
        Me.MenuTwo.Location = New System.Drawing.Point(299, 12)
        Me.MenuTwo.Name = "MenuTwo"
        Me.MenuTwo.Size = New System.Drawing.Size(273, 537)
        Me.MenuTwo.TabIndex = 1
        '
        'BotaoMenuTwo
        '
        Me.BotaoMenuTwo.Location = New System.Drawing.Point(218, 41)
        Me.BotaoMenuTwo.Name = "BotaoMenuTwo"
        Me.BotaoMenuTwo.Size = New System.Drawing.Size(75, 23)
        Me.BotaoMenuTwo.TabIndex = 3
        Me.BotaoMenuTwo.Text = "Open/Close"
        Me.BotaoMenuTwo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Menu1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Menu2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.BotaoMenuTwo)
        Me.Controls.Add(Me.MenuTwo)
        Me.Controls.Add(Me.BotaoMenuOne)
        Me.Controls.Add(Me.MenuOne)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 600)
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show/Hide Menu"
        Me.MenuOne.ResumeLayout(False)
        Me.MenuTwo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuOne As System.Windows.Forms.Panel
    Friend WithEvents BotaoMenuOne As System.Windows.Forms.Button
    Friend WithEvents MenuTwo As System.Windows.Forms.Panel
    Friend WithEvents BotaoMenuTwo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
