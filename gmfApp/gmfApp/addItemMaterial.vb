Imports MySql.Data.MySqlClient

Public Class addItemMaterial

    Private Sub addItemMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (landingPageMaterial.WindowState = FormWindowState.Maximized Or addItemEquipment.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If

        cbMaterialType.Items.Add("Air Filter")
        cbMaterialType.Items.Add("Fuel Filter")
        cbMaterialType.Items.Add("Oil Filter")
        cbMaterialType.Items.Add("Other Filter")
    End Sub

    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        landingPageMaterial.Show()
        Me.Visible = False
    End Sub

    Private Sub EquipmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentToolStripMenuItem.Click
        addItemEquipment.Show()
        Me.Visible = False
    End Sub

    Private Sub buttonDelete_Click(sender As System.Object, e As System.EventArgs) Handles buttonDelete.Click
        

    End Sub
End Class