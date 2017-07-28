Public MustInherit Class block
    Public Const firstItemX As Integer = 6
    Public Const firstItemY As Integer = 23
    Public Sub konfig(Title As String, bgcolor As Color, Optional sizeX As Integer = 250, Optional sizeY As Integer = 100)
        TitelLabel.Text = Title
        BackColor = bgcolor
        Size = New Size(sizeX, sizeY)
    End Sub

    Public Sub ShowHelp()

    End Sub
    Public Sub delete()
        Me.Dispose()
    End Sub
    Public Sub block_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyData
            Case Keys.F1
                ShowHelp()
            Case Keys.Delete
                delete()
        End Select
    End Sub

    Private Sub Help_MouseUp(sender As Object, e As MouseEventArgs) Handles Help.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left And Me.Focused = True Then
            ShowHelp()
        End If
    End Sub

    Private Sub Remove_MouseUp(sender As Object, e As MouseEventArgs) Handles Remove.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left And Me.Focused = True Then
            delete()
        End If
    End Sub

    Public Sub block_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        'abrunden(Me, 0, 0, Me.Width, Me.Height, 30, True)
    End Sub
    Public Sub block_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BorderStyle = Windows.Forms.BorderStyle.None
        'abrunden(Me, 0, 0, Me.Width, Me.Height, 30, False)
    End Sub
    Sub abrunden(ByVal was As Object, _
  ByVal x As Integer, ByVal y As Integer, _
  ByVal width As Integer, ByVal height As Integer, _
  ByVal radius As Integer, ByVal border As Boolean)


        Dim gp As System.Drawing.Drawing2D.GraphicsPath = _
          New System.Drawing.Drawing2D.GraphicsPath()

        gp.AddLine(x + radius, y, x + width - radius, y)
        gp.AddArc(x + width - radius, y, radius, radius, 270, 90)
        gp.AddLine(x + width, y + radius, x + width, y + height - radius)
        gp.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90)
        gp.AddLine(x + width - radius, y + height, x + radius, y + height)
        gp.AddArc(x, y + height - radius, radius, radius, 90, 90)
        gp.AddLine(x, y + height - radius, x, y + radius)
        gp.AddArc(x, y, radius, radius, 180, 90)
        gp.CloseFigure()

        was.region = New System.Drawing.Region(gp)
    End Sub

    Private Sub block_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrunden(Me, 0, 0, Me.Width, Me.Height, 30, False)
    End Sub
    Public Sub setHandler()
        For Each item As Control In Me.Controls
            If TypeOf (item) Is TextBox Or TypeOf (item) Is Label Or TypeOf (item) Is PictureBox Then
                AddHandler item.KeyUp, AddressOf block_KeyUp
            End If
        Next
    End Sub
End Class
