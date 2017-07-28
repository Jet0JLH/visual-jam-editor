<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class block
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.TitelLabel = New System.Windows.Forms.Label()
        Me.Remove = New System.Windows.Forms.PictureBox()
        Me.Help = New System.Windows.Forms.PictureBox()
        CType(Me.Remove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitelLabel
        '
        Me.TitelLabel.AutoSize = True
        Me.TitelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitelLabel.Location = New System.Drawing.Point(5, 5)
        Me.TitelLabel.Name = "TitelLabel"
        Me.TitelLabel.Size = New System.Drawing.Size(39, 16)
        Me.TitelLabel.TabIndex = 0
        Me.TitelLabel.Text = "Titel"
        '
        'Remove
        '
        Me.Remove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Remove.BackgroundImage = Global.Visual_Jam_Editor.My.Resources.Resources.trash1600
        Me.Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Remove.Location = New System.Drawing.Point(227, 3)
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(20, 20)
        Me.Remove.TabIndex = 1
        Me.Remove.TabStop = False
        '
        'Help
        '
        Me.Help.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Help.BackgroundImage = Global.Visual_Jam_Editor.My.Resources.Resources.Help
        Me.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Help.Location = New System.Drawing.Point(201, 3)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(20, 20)
        Me.Help.TabIndex = 1
        Me.Help.TabStop = False
        '
        'block
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Remove)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.TitelLabel)
        Me.Name = "block"
        Me.Size = New System.Drawing.Size(250, 100)
        CType(Me.Remove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitelLabel As System.Windows.Forms.Label
    Friend WithEvents Help As System.Windows.Forms.PictureBox
    Friend WithEvents Remove As System.Windows.Forms.PictureBox

End Class
