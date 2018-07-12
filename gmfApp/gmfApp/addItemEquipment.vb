Public Class addItemEquipment

    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        LandingPage.Show()
        Me.Visible = False
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        addItemMaterial.Show()
        Me.Visible = False
    End Sub

    Private Sub addItemEquipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (LandingPage.WindowState = FormWindowState.Maximized Or addItemMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class