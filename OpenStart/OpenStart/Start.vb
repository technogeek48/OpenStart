Public Class Start

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'getUserPicture
        'getUserColor{
        '   store in my.settings
        '   me.BackroundColor = my.settings.usercolor
    End Sub

    Private Sub Start_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        My.Settings.Save()
        Me.Hide()
    End Sub
End Class