Imports MySql.Data.MySqlClient

Public Class addItemMaterial

    Dim ucode As Integer
    Dim equip_id As Integer

    Private Sub addItemMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bukaDB()
        tampilComboEquipmentList()
        'tampilDataMaterial()
        'tampilDataAlternatif()

        If (landingPageMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    'Tambah Equipment ke database 
    Sub addEquipment()
        ucode = CInt(tbUniqueCode.Text)

        bukaDB()
        CX = New MySqlCommand("select id_equipment from equipment where equipment_name='" & comboBoxEquipment.SelectedItem & "'", Conn)
        RD2 = CX.ExecuteReader
        RD2.Read()
        equip_id = RD2.Item("id_equipment")
        MsgBox(ucode)
        MsgBox(equip_id)

        Try
            bukaDB()
            CMD = New MySqlCommand("select id_material from material where id_material = '" & ucode & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Call bukaDB()
                simpan = "insert into equipment_list (PKid_material,PKid_equipment) values (?,?)"
                CMD = Conn.CreateCommand
                With CMD
                    .CommandText = simpan
                    .Connection = Conn
                    .Parameters.Add("R1", MySqlDbType.Int16).Value = ucode
                    .Parameters.Add("R2", MySqlDbType.Int16).Value = equip_id
                    .ExecuteNonQuery()
                    MsgBox("Yes")
                End With
            End If
        Catch ex As Exception
            MsgBox("Failed")
        End Try
    End Sub

    'Mencari Material melalui id_material alias Code Unique yang akan tampil di Data Grid View Material
    Sub findMaterial(ByVal ucode As Integer)
        Try
            DA = New MySqlDataAdapter("SELECT id_material 'Unique Code', mat_part_number 'Part Number', mat_desc 'Description', mat_brand 'Brand', mat_stock 'Stock', mat_um 'UM', mat_type 'Type', equipment_name 'Equipment', mat_location 'Location', mat_remark 'Remark' FROM material INNER JOIN equipment ON material.id_material='" & ucode & "'" & "WHERE equipment.id_equipment  IN (SELECT equipment_list.PKid_equipment FROM equipment_list WHERE PKid_material IN (SELECT material.id_material FROM material WHERE material.id_material='" & ucode & "'))", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list")
            dataGridViewMaterial.DataSource = DS.Tables("material, equipment, equipment_list")
            dataGridViewMaterial.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed")
        End Try
    End Sub

    'Mencari Material melalui id_material alias Code Unique yang akan tampil di Data Grid View Alternatif
    Sub findAlternatif(ByVal ucode As Integer)
        Try
            DA = New MySqlDataAdapter("SELECT id_material 'Unique Code', alt_part_number 'Part Number', alt_brand 'Brand', alt_stock 'Stock', alt_um 'UM', alt_type 'Type', equipment_name 'Equipment', alt_location 'Location', alt_remark 'Remark' FROM material INNER JOIN equipment_list ON material.id_material='" & ucode & "' INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material='" & ucode & "' INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif ORDER BY alt_part_number ASC", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataGridViewAlernatif.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataGridViewAlernatif.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed")
        End Try
    End Sub

    'Menampilkan list dari Equipment yg ada di database ke comboBoxEquipment
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

    'Menampilkan data Material di DataGridViewMaterial dari database
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

    'Menampilkan data Alternatif di DataGridViewAlternaatif dari database
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

    'Tombol Keluar
    Private Sub toolStripLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripLogOut.Click
        Me.Close()
        MessageBox.Show("You are logged out!")
    End Sub

    'Menuju page Landing
    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        landingPageMaterial.Show()
        Me.Visible = False
    End Sub

    'Menuju page History
    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        history.Show()
        Me.Visible = False
    End Sub

    'Button Find untuk menampilkan data dari Material, Equipment dan Alternatif ke tabel
    Private Sub buttonUniqueCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonUniqueCode.Click
        ucode = CInt(tbUniqueCode.Text)
        MsgBox(ucode)
        Call findMaterial(ucode)
        Call findAlternatif(ucode)
    End Sub

    'Button menambahkan equipment menggunakan sub addEquipment
    Private Sub buttonAddEquipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAddEquipment.Click
        Call addEquipment()
    End Sub
End Class