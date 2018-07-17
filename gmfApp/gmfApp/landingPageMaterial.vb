Imports MySql.Data.MySqlClient

Public Class landingPageMaterial

    Private Sub LandingPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (addItemMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If


    End Sub

    Private Sub toolStripLogOut_Click(sender As System.Object, e As System.EventArgs) Handles toolStripLogOut.Click
        Me.Close()
        MessageBox.Show("You are logged out!")
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        addItemMaterial.Show()
        Me.Visible = False
    End Sub
    
    Private Sub HistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        history.Show()
        Me.Visible = False
    End Sub
End Class
