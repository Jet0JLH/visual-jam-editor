Public Class messageblock
    Inherits block
    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        konfig("Message", Color.LightGreen, , 69)
        Dim Label1 As New Label
        Dim Textbox1 As New TextBox

        Label1.Text = "Welche Nachricht soll ausgegeben werden?"
        Label1.AutoSize = True
        Label1.Location = New Point(firstItemX, firstItemY)

        Textbox1.Size = New Size(Me.Size.Width - (2 * (firstItemX + 3)), Textbox1.Size.Height)
        Textbox1.Location = New Point(firstItemX + 3, firstItemY + 17)


        'AddHandler Textbox1.KeyUp, AddressOf block_KeyUp
        'AddHandler Textbox1.GotFocus, AddressOf block_GotFocus
        'AddHandler Textbox1.LostFocus, AddressOf block_LostFocus

        Me.Controls.Add(Label1)
        Me.Controls.Add(Textbox1)
        setHandler()
    End Sub
End Class
