Imports MySql.Data.MySqlClient
Public Class history

    Private Sub StatusCheckToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StatusCheckToolStripMenuItem.Click
        landingPageMaterial.Show()
        Me.Visible = False
    End Sub

    Private Sub AddMaterialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddMaterialToolStripMenuItem.Click
        addItemMaterial.Show()
        Me.Visible = False
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        MessageBox.Show("You are logged out!")
    End Sub
End Class