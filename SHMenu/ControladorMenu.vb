Public Class ControladorMenu

    Public Sub AbreMenuPrincipal()
        Form1.MenuOne.Location = New Point(12, 12)
        Form1.BotaoMenuOne.Location = New Point(218, 12)
    End Sub
    Public Sub FechaMenuPrincipal()
        Form1.MenuOne.Location = New Point(-200, 0)
        Form1.BotaoMenuOne.Location = New Point(12, 12)
    End Sub

    Public Sub AbreMenuSecundario()
        Form1.MenuTwo.Location = New Point(299, 12)
        Form1.BotaoMenuTwo.Location = New Point(218, 41)
    End Sub
    Public Sub FechaMenuSecundario()
        Form1.MenuTwo.Location = New Point(601, 0)
        Form1.BotaoMenuTwo.Location = New Point(497, 41)
    End Sub
End Class