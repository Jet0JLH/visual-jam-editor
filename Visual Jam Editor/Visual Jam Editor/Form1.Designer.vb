<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Messageblock1 = New Visual_Jam_Editor.messageblock()
        Me.Messageblock2 = New Visual_Jam_Editor.messageblock()
        Me.SuspendLayout()
        '
        'Messageblock1
        '
        Me.Messageblock1.BackColor = System.Drawing.Color.LightGreen
        Me.Messageblock1.Location = New System.Drawing.Point(42, 60)
        Me.Messageblock1.Name = "Messageblock1"
        Me.Messageblock1.Size = New System.Drawing.Size(250, 69)
        Me.Messageblock1.TabIndex = 0
        '
        'Messageblock2
        '
        Me.Messageblock2.BackColor = System.Drawing.Color.LightGreen
        Me.Messageblock2.Location = New System.Drawing.Point(413, 124)
        Me.Messageblock2.Name = "Messageblock2"
        Me.Messageblock2.Size = New System.Drawing.Size(250, 69)
        Me.Messageblock2.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 471)
        Me.Controls.Add(Me.Messageblock2)
        Me.Controls.Add(Me.Messageblock1)
        Me.Name = "Form1"
        Me.Text = "Visual Jam Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Messageblock1 As Visual_Jam_Editor.messageblock
    Friend WithEvents Messageblock2 As Visual_Jam_Editor.messageblock

End Class
