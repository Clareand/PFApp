Imports MySql.Data.MySqlClient
Public Class history

    Dim hcode As String

    Private Sub history_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilHistory()
    End Sub

    Sub initHcode()
        If DataGridHistory.CurrentRow.Index <> DataGridHistory.NewRowIndex Then
            hcode = DataGridHistory.Item(0, DataGridHistory.CurrentRow.Index).Value
        End If
        'MsgBox(hcode)
    End Sub

    Sub tampilHistory()
        Call bukaDB()
        Try
            DA = New MySqlDataAdapter("select id_Material 'PF Code',waktu 'Time', h_part_number 'Part Number', h_desc 'Description', h_brand 'Brand', h_stock 'Stock', h_um 'UM', h_type 'Type', h_location 'Location', h_remark 'Remark' from history ORDER BY id_material asc", Conn)
            DS = New DataSet
            DA.Fill(DS, "history")
            DataGridHistory.DataSource = DS.Tables("history")
            DataGridHistory.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed Load Data")
        End Try
        Conn.Close()
    End Sub


    Sub tampilEquipHist(ByVal hcode As String)
        Call bukaDB()
        Try
            DA = New MySqlDataAdapter("SELECT DISTINCT equipment_name 'Equipment' from history INNER JOIN equipment_history ON id_material=PKid_material INNER JOIN equipment ON id_equipment=PKid_equipment WHERE id_material ='" & hcode & "'", Conn)
            DS = New DataSet
            DA.Fill(DS, "history,equipment,equipment_history")
            DataGridEquipHist.DataSource = DS.Tables("history,equipment,equipment_history")
            DataGridEquipHist.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed Load Data")
        End Try
        Conn.Close()
    End Sub


    Sub tampilHistoryAlt(ByVal hcode As String)
        Call bukaDB()
        Try
            DA = New MySqlDataAdapter("select DISTINCT alt_part_number 'Part Number', alt_brand 'Brand', alt_stock 'Stock', alt_um 'UM', alt_type 'Type', alt_location 'Location', alt_remark 'Remark' from history inner join alternatif_history on id_material = Pkid_material inner join alternatif on id_alternatif=PKid_alternatif where id_material = '" & hcode & "'", Conn)
            DS = New DataSet
            DA.Fill(DS, "history,alternatif,alternatif_history")
            DataGridAlternatifHist.DataSource = DS.Tables("history,alternatif,alternatif_history")
            DataGridAlternatifHist.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed Load Data")
        End Try
        Conn.Close()
    End Sub




    Private Sub StatusCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusCheckToolStripMenuItem.Click
        landingPageMaterial.TampilAllData()
        landingPageMaterial.Show()
        Me.Visible = False
    End Sub

    Private Sub AddMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMaterialToolStripMenuItem.Click
        addItemMaterial.Show()
        Me.Visible = False
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        MessageBox.Show("You are logged out!")
        login.Show()
        login.tbPassword.Text = ""
        login.tbUsername.Text = ""
    End Sub

   
    Private Sub DataGridHistory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridHistory.CellContentClick
        Call initHcode()
        Call tampilEquipHist(hcode)
        Call tampilHistoryAlt(hcode)
    End Sub

End Class