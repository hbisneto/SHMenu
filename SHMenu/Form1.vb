Public Class Form1

    Dim MenuController As ControladorMenu = New ControladorMenu()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Valores padrões antes da janela ser carregada (assim como é mostrado no design)
        Console.WriteLine(MenuOne.Location.X) '12
        Console.WriteLine(MenuOne.Location.Y) '12
        Console.WriteLine(BotaoMenuOne.Location.X) '218
        Console.WriteLine(BotaoMenuOne.Location.Y) '12

        Console.WriteLine(MenuTwo.Location.X) '299
        Console.WriteLine(MenuTwo.Location.Y) '12
        Console.WriteLine(BotaoMenuTwo.Location.X) '218
        Console.WriteLine(BotaoMenuTwo.Location.Y) '41
        ' Valores padrões antes da janela ser carregada (assim como é mostrado no design)

        ' Valores configurados para serem carregados com a janela
        MenuOne.Location = New Point(-200, 0)
        BotaoMenuOne.Location = New Point(12, 12)

        MenuTwo.Location = New Point(601, 12)
        BotaoMenuTwo.Location = New Point(497, 41)
        ' Valores configurados para serem carregados com a janela

    End Sub

    Private Sub BotaoMenuOne_Click(sender As Object, e As EventArgs) Handles BotaoMenuOne.Click
        If MenuOne.Location.X = -200 Then
            MenuController.AbreMenuPrincipal()
            MenuController.FechaMenuSecundario()
        Else
            MenuController.FechaMenuPrincipal()
        End If
    End Sub

    Private Sub BotaoMenuTwo_Click(sender As Object, e As EventArgs) Handles BotaoMenuTwo.Click
        If MenuTwo.Location.X = 601 Then
            MenuController.AbreMenuSecundario()
            MenuController.FechaMenuPrincipal()
        Else
            MenuController.FechaMenuSecundario()
        End If
    End Sub
End Class