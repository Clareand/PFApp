<<<<<<< HEAD:gmfApp/gmfApp/landingPageMaterial.vb
﻿Imports System.Data.OleDb

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
=======
﻿Public Class LandingPage
>>>>>>> parent of 8587768... Add Login Form:gmfApp/gmfApp/landingPage.vb

    Private Sub MaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        addItemMaterial.Show()
        Me.Visible = False
    End Sub


<<<<<<< HEAD:gmfApp/gmfApp/landingPageMaterial.vb

    
=======
    Private Sub LandingPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (addItemMaterial.WindowState = FormWindowState.Maximized Or addItemEquipment.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
>>>>>>> parent of 8587768... Add Login Form:gmfApp/gmfApp/landingPage.vb
End Class
