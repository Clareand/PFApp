Imports MySql.Data.MySqlClient

Public Class addItemMaterial


    Private Sub addItemMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bukaDB()
        tampilComboEquipmentList()
        'tampilDataMaterial()
        'tampilDataAlternatif()

        If (landingPageMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If


    End Sub



    Private Sub tampilComboEquipmentList()
        Try
            CMD = New MySqlCommand("SELECT equipment_name from equipment", Conn)
            RD = CMD.ExecuteReader

            If RD.HasRows Then
                comboBoxEquipment.Items.Clear()
                While RD.Read()
                    comboBoxEquipment.Items.Add(RD("equipment_name"))
                End While
            End If
            RD.Close()
        Catch ex As Exception
            MsgBox("Failed")
        End Try

    End Sub

    Private Sub tampilDataMaterial()
        Try
            DA = New MySqlDataAdapter("SELECT id_material 'Unique Code', mat_part_number 'Part Number', mat_desc 'Description', mat_brand 'Brand', mat_stock 'Stock', mat_um 'UM', mat_type 'Type', equipment_name 'Equipment', mat_location 'Location', mat_remark 'Remark' FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list")
            dataGridViewMaterial.DataSource = DS.Tables("material, equipment, equipment_list")
            dataGridViewMaterial.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed")
        End Try
    End Sub

    Private Sub tampilDataAlternatif()
        Try
            DA = New MySqlDataAdapter("SELECT id_material 'Unique Code' ,alt_part_number 'Part Number', alt_brand 'Brand', alt_stock 'Stock', alt_um 'UM', alt_type 'Type',  equipment_name 'Equipment', alt_location 'Location', alt_remark 'Remark' FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material  INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif ORDER BY alt_part_number asc", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataGridViewAlernatif.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataGridViewAlernatif.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed")
        End Try
    End Sub

    Private Sub toolStripLogOut_Click(sender As System.Object, e As System.EventArgs) Handles toolStripLogOut.Click
        Me.Close()
        MessageBox.Show("You are logged out!")
    End Sub

    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        landingPageMaterial.Show()
        Me.Visible = False
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        history.Show()
        Me.Visible = False
    End Sub

    Private Sub buttonUniqueCode_Click(sender As System.Object, e As System.EventArgs) Handles buttonUniqueCode.Click
        Try
            DA = New MySqlDataAdapter("SELECT id_material 'Unique Code', mat_part_number 'Part Number', mat_desc 'Description', mat_brand 'Brand', mat_stock 'Stock', mat_um 'UM', mat_type 'Type', equipment_name 'Equipment', mat_location 'Location', mat_remark 'Remark' FROM material INNER JOIN equipment ON material.id_material='" & tbUniqueCode.Text & "'" & "WHERE equipment.id_equipment  IN (SELECT equipment_list.PKid_equipment FROM equipment_list WHERE PKid_material IN (SELECT material.id_material FROM material WHERE material.id_material='" & tbUniqueCode.Text & "'", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list")
            dataGridViewMaterial.DataSource = DS.Tables("material, equipment, equipment_list")
            dataGridViewMaterial.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed")
        End Try
    End Sub
End Class