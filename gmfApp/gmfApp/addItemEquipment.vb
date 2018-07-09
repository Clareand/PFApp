Imports MySql.Data.MySqlClient

Public Class addItemEquipment

    Private Sub addItemEquipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (landingPageMaterial.WindowState = FormWindowState.Maximized Or addItemMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        landingPageMaterial.Show()
        Me.Visible = False
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        addItemMaterial.Show()
        Me.Visible = False
    End Sub


    Private Sub buttonDelete_Click(sender As System.Object, e As System.EventArgs) Handles buttonDelete.Click
        tbEquipementDesc.Text = ""
        tbRemarksEquipment.Text = ""
    End Sub


End Class