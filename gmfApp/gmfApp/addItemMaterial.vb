Imports MySql.Data.MySqlClient

Public Class addItemMaterial

    Dim ucode As Integer
    Dim pncode As String
    Dim equip_id As Integer

    Private Sub addItemMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bukaDB()
        tampilComboEquipmentList()
        Call clear()

        'tampilDataMaterial()
        'tampilDataAlternatif()

        If (landingPageMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Sub clear()
        Call initUcode()
        tbUniqueCode.Text = ""
        tbPartNumber.Text = ""
        tbMaterialDesc.Text = ""
        tbBrand.Text = ""
        tbStock.Text = ""
        comboBoxUM.SelectedItem = ""
        comboBoxMaterialType.SelectedItem = ""
        comboBoxEquipment.SelectedItem = ""
        tbLocation.Text = ""
        tbRemarksMaterial.Text = ""
        dataGridViewEquipment.DataSource = Nothing
        dataGridViewAlernatif.DataSource = Nothing
        dataGridViewMaterial.DataSource = Nothing
      
    End Sub

    'Tambah Equipment ke database 
    Sub initUcode()
        If tbUniqueCode.Text <> "" And tbPartNumber.Text = "" Then
            ucode = CInt(tbUniqueCode.Text)

        ElseIf tbUniqueCode.Text = "" And tbPartNumber.Text <> "" Then
            bukaDB()
            Call initPN()
            MsgBox(ucode)
        ElseIf tbUniqueCode.Text <> "" And tbPartNumber.Text <> "" Then
            If tbUniqueCode.Text = ucode Then
                tbUniqueCode.Text = ""
                pncode = tbPartNumber.Text
                Call initPN()
            ElseIf tbPartNumber.Text = pncode Then
                tbPartNumber.Text = ""
                ucode = tbUniqueCode.Text
            End If
        End If
    End Sub


    Sub initPN()
        pncode = tbPartNumber.Text
        MsgBox(pncode)
        CX = New MySqlCommand("SELECT id_material FROM material WHERE mat_part_number='" & pncode & "'", Conn)
        RD2 = CX.ExecuteReader
        RD2.Read()
        ucode = RD2.Item("id_material")
        RD2.Close()
        tbUniqueCode.Text = ucode
    End Sub


    Sub addOrEdit()
        Try
            Dim var As Integer = 1
            bukaDB()
            CMD = New MySqlCommand("select id_material from material where id_material = '" & ucode & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Call addAlt()
            End If
            RD.Close()
        Catch ex As Exception
            MsgBox("Unique Code not found")
        End Try

    End Sub




    Sub addEquipment()
        bukaDB()
        CX = New MySqlCommand("select id_equipment from equipment where equipment_name='" & comboBoxEquipment.SelectedItem & "'", Conn)
        RD2 = CX.ExecuteReader
        RD2.Read()
        equip_id = RD2.Item("id_equipment")
        RD2.Close()
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
            RD.Close()
        Catch ex As Exception
            MsgBox("Failed Add Equipment")
        End Try
    End Sub


    Sub addMaterial()
        tbUniqueCode.IsAccessible = False
        buttonAddEquipment.IsAccessible = False
        Call bukaDB()
        Try
            simpan = "INSERT INTO material (mat_part_number, mat_desc, mat_brand, mat_stock, mat_um, mat_type, mat_location, mat_remark) VALUES (?,?,?,?,?,?,?,?)"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = simpan
                .Connection = Conn
                .Parameters.Add("M1", MySqlDbType.String).Value = tbPartNumber.Text
                .Parameters.Add("M2", MySqlDbType.String).Value = tbMaterialDesc.Text
                .Parameters.Add("M3", MySqlDbType.String).Value = tbBrand.Text
                .Parameters.Add("M4", MySqlDbType.Int16).Value = tbStock.Text
                .Parameters.Add("M5", MySqlDbType.String).Value = comboBoxUM.SelectedItem
                .Parameters.Add("M6", MySqlDbType.String).Value = comboBoxMaterialType.SelectedItem
                .Parameters.Add("M7", MySqlDbType.String).Value = tbLocation.Text
                .Parameters.Add("M8", MySqlDbType.String).Value = tbRemarksMaterial.Text
                .ExecuteNonQuery()
                MsgBox("Yes")
            End With
            RD.Close()
        Catch ex As Exception
            MsgBox("Failed Add Material")
        End Try

    End Sub

    Sub addAlt()

        tbUniqueCode.IsAccessible = False
        tbMaterialDesc.IsAccessible = False
        comboBoxEquipment.IsAccessible = False
        Call bukaDB()
        Try
            simpan = "INSERT INTO alternatif (alt_part_number, alt_brand, alt_stock, alt_um, alt_type, alt_location, alt_remark) VALUES (?,?,?,?,?,?,?)"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = simpan
                .Connection = Conn
                .Parameters.Add("A1", MySqlDbType.String).Value = tbPartNumber.Text
                .Parameters.Add("A2", MySqlDbType.String).Value = tbBrand.Text
                .Parameters.Add("A3", MySqlDbType.Int16).Value = tbStock.Text
                .Parameters.Add("A4", MySqlDbType.String).Value = comboBoxUM.SelectedItem
                .Parameters.Add("A5", MySqlDbType.String).Value = comboBoxMaterialType.SelectedItem
                .Parameters.Add("A6", MySqlDbType.String).Value = tbLocation.Text
                .Parameters.Add("A7", MySqlDbType.String).Value = tbRemarksMaterial.Text
                .ExecuteNonQuery()
                MsgBox("Yes")
            End With
            RD.Close()
        Catch ex As Exception
            MsgBox("Failed Add Equipment")
        End Try

    End Sub


    Sub UpdateMaterial()

    End Sub


    Sub UpdateAlt()

    End Sub




    'Mencari Material melalui ID_MATERIAL alias Code Unique yang akan tampil di dataGridViewMaterial
    Sub findMaterial(ByVal ucode As Integer)

        Try
            DA = New MySqlDataAdapter("SELECT DISTINCT id_material 'Unique Code', mat_part_number 'Part Number', mat_desc 'Description', mat_brand 'Brand', mat_stock 'Stock', mat_um 'UM', mat_type 'Type', mat_location 'Location', mat_remark 'Remark' FROM material INNER JOIN equipment ON material.id_material='" & ucode & "'" & "WHERE equipment.id_equipment  IN (SELECT equipment_list.PKid_equipment FROM equipment_list WHERE PKid_material IN (SELECT material.id_material FROM material WHERE material.id_material='" & ucode & "'))", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list")
            dataGridViewMaterial.DataSource = DS.Tables("material, equipment, equipment_list")
            dataGridViewMaterial.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed Find Material")
        End Try

    End Sub

    'Mencari Material melalui ID_MATERIAL alias Code Unique yang akan tampil di dataGridViewAlternatif
    Sub findAlternatif(ByVal ucode As Integer)

        Try
            DA = New MySqlDataAdapter("SELECT id_material 'Unique Code', alt_part_number 'Part Number', alt_brand 'Brand', alt_stock 'Stock', alt_um 'UM', alt_type 'Type', alt_location 'Location', alt_remark 'Remark' FROM material INNER JOIN equipment_list ON material.id_material='" & ucode & "' INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material='" & ucode & "' INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif GROUP BY alt_part_number ORDER BY alt_part_number ASC", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataGridViewAlernatif.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataGridViewAlernatif.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed Find Alternatif")
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
            MsgBox("Failed Tampil Combo Equip")
        End Try

    End Sub

    'Memanggil Equipment yang di Add di Material
    Private Sub tampilDataEquipment(ByVal ucode As Integer)
        Try
            DA = New MySqlDataAdapter("SELECT equipment_name 'Equipment' FROM equipment INNER JOIN equipment_list ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN material ON material.id_material=equipment_list.PKid_material WHERE id_material='" & ucode & "'", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list")
            dataGridViewEquipment.DataSource = DS.Tables("material, equipment, equipment_list")
            dataGridViewEquipment.ReadOnly = True

        Catch ex As Exception
            MsgBox("Failed Tampil Data Eq")
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
        Call clear()
    End Sub

    'Menuju page History
    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        history.Show()
        Me.Visible = False
    End Sub

    'Button Find untuk menampilkan data dari Material, Equipment dan Alternatif ke tabel
    Private Sub buttonUniqueCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonUniqueCode.Click

        MsgBox(ucode)

        Call initUcode()
        Call findMaterial(ucode)
        Call findAlternatif(ucode)
        Call tampilDataEquipment(ucode)
    End Sub

    'Button menambahkan equipment menggunakan sub addEquipment
    Private Sub buttonAddEquipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAddEquipment.Click
        Call addEquipment()
        Call tampilDataEquipment(ucode)
        Call findMaterial(ucode)
        Call findAlternatif(ucode)
    End Sub
    
    Private Sub buttonSearchPN_Click(sender As System.Object, e As System.EventArgs) Handles buttonSearchPN.Click

        Call initUcode()
        Call findMaterial(ucode)
        Call findAlternatif(ucode)
        Call tampilDataEquipment(ucode)
    End Sub
End Class