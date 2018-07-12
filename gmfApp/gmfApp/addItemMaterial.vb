<<<<<<< HEAD
﻿Imports System.Data.OleDb

Public Class addItemMaterial

    Private Sub addItemMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (landingPageMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If

        comboBoxMaterialType.Items.Add("Air Filter")
        comboBoxMaterialType.Items.Add("Fuel Filter")
        comboBoxMaterialType.Items.Add("Oil Filter")
        comboBoxMaterialType.Items.Add("Other Filter")
    End Sub

    Private Sub toolStripLogOut_Click(sender As System.Object, e As System.EventArgs) Handles toolStripLogOut.Click
        Me.Close()
        MessageBox.Show("You are logged out!")
=======
﻿Public Class addItemMaterial

    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        LandingPage.Show()
        Me.Visible = False
>>>>>>> parent of 8587768... Add Login Form
    End Sub

    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        landingPageMaterial.Show()
        Me.Visible = False
    End Sub
<<<<<<< HEAD
=======

    Private Sub addItemMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (LandingPage.WindowState = FormWindowState.Maximized Or addItemEquipment.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
>>>>>>> parent of 8587768... Add Login Form
End Class