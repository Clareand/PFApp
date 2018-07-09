Public Class addItemMaterial

    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        LandingPage.Show()
        Me.Visible = False
    End Sub

    Private Sub EquipmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentToolStripMenuItem.Click
        addItemEquipment.Show()
        Me.Visible = False
    End Sub

    Private Sub addItemMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (LandingPage.WindowState = FormWindowState.Maximized Or addItemEquipment.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class