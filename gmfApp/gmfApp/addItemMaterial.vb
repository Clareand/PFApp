Imports MySql.Data.MySqlClient

Public Class addItemMaterial

    Dim ucode As Integer
    Dim pncode As String
    Dim altcode As String
    Dim equip_id As Integer
    Dim var As Integer = 0
    Dim xcode As Integer
    Dim pxcode As String
    Dim axcode As Integer
    Dim Pkid_alt As Integer
    'test Merge

    Private Sub addItemMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bukaDB()
        tampilComboEquipmentList()
        Call autocompleteUcode()
        Call autocompletePN()


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
        comboBoxUM.ResetText()
        comboBoxMaterialType.ResetText()
        comboBoxEquipment.ResetText()
        tbLocation.Text = ""
        tbRemarksMaterial.Text = ""
        dataGridViewEquipment.DataSource = Nothing
        dataGridViewAlernatif.DataSource = Nothing
        dataGridViewMaterial.DataSource = Nothing
    End Sub
    Sub clearform()
        tbPartNumber.Text = ""
        tbMaterialDesc.Text = ""
        tbBrand.Text = ""
        tbStock.Text = ""
        comboBoxUM.ResetText()
        comboBoxMaterialType.ResetText()
        comboBoxEquipment.ResetText()
        tbLocation.Text = ""
        tbRemarksMaterial.Text = ""
    End Sub

    'inisialisasi var Ucode
    Sub initUcode()
        If tbUniqueCode.Text <> "" And tbPartNumber.Text = "" Then
            ucode = CInt(tbUniqueCode.Text)

        ElseIf tbUniqueCode.Text = "" And tbPartNumber.Text <> "" Then
            Call initPN()
            MsgBox("Init Ucode, Ucode :" & ucode)
        ElseIf tbUniqueCode.Text <> "" And tbPartNumber.Text <> "" Then
            If tbUniqueCode.Text = ucode Then
                tbUniqueCode.Text = ""
                pncode = tbPartNumber.Text
                Call initPN()
            ElseIf tbPartNumber.Text = pncode Or tbPartNumber.Text <> pncode Then
                tbPartNumber.Text = ""
                ucode = tbUniqueCode.Text
            ElseIf tbUniqueCode.Text <> ucode Then
                tbUniqueCode.Text = ""
            End If
        End If
    End Sub

    'inisialisasi var pncode
    Sub initPN()
        Call bukaDB()
        pncode = tbPartNumber.Text
        MsgBox("InitPN, pncode : " & pncode)
        CX = New MySqlCommand("SELECT id_material FROM material WHERE mat_part_number='" & pncode & "'", Conn)
        RD2 = CX.ExecuteReader
        RD2.Read()
        If RD2.HasRows Then
            ucode = RD2.Item("id_material")
        Else
            ucode = 0
        End If
        RD2.Close()
        If ucode = 0 Then
            tbUniqueCode.Text = ""
        Else
            tbUniqueCode.Text = ucode
        End If
    End Sub



    Sub initAltCode()
        Call bukaDB()
        altcode = tbPartNumber.Text
        MsgBox("InitPN, altcode : " & altcode)
        CX = New MySqlCommand("SELECT id_alternatif FROM alternatif WHERE alt_part_number='" & altcode & "'", Conn)
        RD2 = CX.ExecuteReader
        RD2.Read()
        If RD2.HasRows Then
            axcode = RD2.Item("id_alternatif")
        End If
        RD2.Close()
    End Sub

    Sub addOrEdit()
        If var = 0 Then
            Call addMaterial()
        ElseIf var = 1 Then
            tbUniqueCode.Enabled = False
            Call UpdateMaterial()
            var = 0
        ElseIf var = 2 Then
            Call addAlt()
            var = 0
        ElseIf var = 3 Then
            tbUniqueCode.Enabled = False
            Call UpdateAlt()
            var = 0
        End If

    End Sub

    Sub addEquipment()
        bukaDB()
        CX = New MySqlCommand("select id_equipment from equipment where equipment_name='" & comboBoxEquipment.SelectedItem & "'", Conn)
        RD2 = CX.ExecuteReader
        RD2.Read()
        equip_id = RD2.Item("id_equipment")
        RD2.Close()
        MsgBox("AddEquipment, Ucode :" & ucode)
        MsgBox("AddEquipment, Equip_id: " & equip_id)

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
                    MsgBox("Succes addEquipment")
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
                MsgBox("success Add Material")
            End With
            RD.Close()
        Catch ex As Exception
            MsgBox("Failed Add Material")
        End Try
        tbUniqueCode.Enabled = True
    End Sub

    Sub addAlt()
        tbMaterialDesc.Enabled = False
        Call bukaDB()
        CX = New MySqlCommand("select id_alternatif from alternatif where alt_part_number = '" & altcode & "'", Conn)
        RD2 = CX.ExecuteReader
        RD2.Read()
        If RD.HasRows Then
            axcode = RD2.Item("id_alternatif")
            RD2.Close()
            Call addAlt_list()
        Else
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
                    MsgBox("success Add Alt")
                End With
                Conn.Close()
            Catch ex As Exception
                MsgBox("Failed Add Alt")
            End Try
            tbMaterialDesc.Enabled = True
            tbBrand.Enabled = True
            tbStock.Enabled = True
            comboBoxUM.Enabled = True
            comboBoxMaterialType.Enabled = True
            tbLocation.Enabled = True
            tbRemarksMaterial.Enabled = True
            Call addAlt_list()
        End If
    End Sub

    Sub addAlt_list()
        Call bukaDB()
        CX = New MySqlCommand("select id_alternatif from alternatif where alt_part_number='" & altcode & "'", Conn)
        RD2 = CX.ExecuteReader
        RD2.Read()
        If RD2.HasRows Then
            axcode = RD2.Item("id_alternatif")
            MsgBox("axcode:" & axcode)
        End If
        RD2.Close()

        Call bukaDB()
        Try
            simpan = "INSERT INTO alternatif_list (PKid_material, PKid_alternatif) VALUES (?,?)"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = simpan
                .Connection = Conn
                .Parameters.Add("A1", MySqlDbType.Int16).Value = ucode
                .Parameters.Add("A2", MySqlDbType.Int16).Value = axcode
                .ExecuteNonQuery()
                MsgBox("success Add Alt_list")
            End With
            Conn.Close()
        Catch ex As Exception
            MsgBox("Failed Add Alt")
        End Try
        axcode = 0
    End Sub



    Sub UpdateMaterial()
        Call bukaDB()
        Try
            ubah = "update material set mat_desc=@desc, mat_brand=@brand, mat_stock=@stock, mat_um=@um, mat_type=@type, mat_location=@locat,mat_remark=@remark where id_material ='" & ucode & "'"
            CMD = Conn.CreateCommand
            With CMD
                .Connection = Conn
                .CommandText = ubah
                .Parameters.AddWithValue("@desc", tbMaterialDesc.Text)
                .Parameters.AddWithValue("@brand", tbBrand.Text)
                .Parameters.AddWithValue("@stock", tbStock.Text)
                .Parameters.AddWithValue("@um", comboBoxUM.SelectedItem)
                .Parameters.AddWithValue("@type", comboBoxMaterialType.SelectedItem)
                .Parameters.AddWithValue("@locat", tbLocation.Text)
                .Parameters.AddWithValue("@remark", tbRemarksMaterial.Text)
            End With
            CMD.ExecuteNonQuery()
            tbUniqueCode.Enabled = True
            tbPartNumber.Enabled = True
        Catch ex As Exception
            MsgBox("Failed Update Material")
        End Try
    End Sub


    Sub UpdateAlt()
        Call bukaDB()
        Try
            ubah = "update alternatif set alt_brand=@brand, alt_stock=@stock, alt_um=@um, alt_type=@type, alt_location=@locat,alt_remark=@remark where id_alternatif ='" & axcode & "'"
            CMD = Conn.CreateCommand
            With CMD
                .Connection = Conn
                .CommandText = ubah
                .Parameters.AddWithValue("@desc", tbMaterialDesc.Text)
                .Parameters.AddWithValue("@brand", tbBrand.Text)
                .Parameters.AddWithValue("@stock", tbStock.Text)
                .Parameters.AddWithValue("@um", comboBoxUM.SelectedItem)
                .Parameters.AddWithValue("@type", comboBoxMaterialType.SelectedItem)
                .Parameters.AddWithValue("@locat", tbLocation.Text)
                .Parameters.AddWithValue("@remark", tbRemarksMaterial.Text)

                buttonUniqueCode.Enabled = True
                buttonSearchPN.Enabled = True
                tbUniqueCode.Enabled = True
                tbPartNumber.Enabled = True
                tbMaterialDesc.Enabled = True
                tbBrand.Enabled = True
                tbStock.Enabled = True
                comboBoxUM.Enabled = True
                comboBoxMaterialType.Enabled = True
                tbLocation.Enabled = True
                tbRemarksMaterial.Enabled = True
            End With
            CMD.ExecuteNonQuery()
            tbPartNumber.ReadOnly = False
        Catch ex As Exception
            MsgBox("Failed Update alternaitf")
        End Try
    End Sub




    'Mencari Material melalui ID_MATERIAL alias Code Unique yang akan tampil di dataGridViewMaterial
    Sub findMaterial(ByVal ucode As Integer)

        Try
            DA = New MySqlDataAdapter("SELECT DISTINCT id_material 'Code', mat_part_number 'Part Number', mat_desc 'Description', mat_brand 'Brand', mat_stock 'Stock', mat_um 'UM', mat_type 'Type', mat_location 'Location', mat_remark 'Remark' FROM material where id_material ='" & ucode & "'", Conn)
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
            DA = New MySqlDataAdapter("select id_material 'material', alt_part_number 'Part Number', alt_brand 'Brand', alt_stock 'Stock', alt_UM 'UM', alt_type 'Type', alt_remark 'Remark' from material inner join alternatif on id_material='" & ucode & "' where id_alternatif in(select PKid_alternatif from alternatif_list where PKid_material in (select id_material from material where id_material='" & ucode & "'))", Conn)
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

    Sub autocompleteUcode()
        bukaDB()
        CMD = New MySqlCommand("SELECT id_material FROM material", Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            With tbUniqueCode
                .AutoCompleteCustomSource.Remove(tbPartNumber.AutoCompleteSource)
                .AutoCompleteCustomSource.Add(RD(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        Conn.Close()
    End Sub


    Sub autocompletePN()
        With tbPartNumber
            .AutoCompleteCustomSource.Clear()
        End With
        If var = 2 Then
            bukaDB()
            CMD = New MySqlCommand("select alt_part_number from alternatif", Conn)
            RD = CMD.ExecuteReader
            While RD.Read
                With tbPartNumber
                    .AutoCompleteCustomSource.Add(RD(0).ToString)
                    .AutoCompleteMode = AutoCompleteMode.Suggest
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                End With
            End While
            Conn.Close()
        ElseIf var = 0 Then
            bukaDB()
            CMD = New MySqlCommand("select mat_part_number from material", Conn)
            RD = CMD.ExecuteReader
            While RD.Read
                With tbPartNumber

                    .AutoCompleteCustomSource.Add(RD(0).ToString)
                    .AutoCompleteMode = AutoCompleteMode.Suggest
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                End With
            End While
            Conn.Close()
        End If
    End Sub

    'Memanggil Equipment yang di Add di Material
    Sub tampilDataEquipment(ByVal ucode As Integer)
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

    'delete alternatif'

    Sub deleteAlt()
        If dataGridViewAlernatif.CurrentRow.Index <> dataGridViewAlernatif.NewRowIndex Then
            Call bukaDB()
            CMD = New MySqlCommand("select id_alternatif from alternatif where alt_part_number='" & dataGridViewAlernatif.Item(1, dataGridViewAlernatif.CurrentRow.Index).Value & "'", Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows = True Then
                While RD.Read
                    Pkid_alt = RD.Item("id_alternatif")
                End While
            End If
            RD.Close()
        End If
        Dim ubahrow As String = "delete from alternatif_list where PKid_alternatif= " & Pkid_alt & ""
        CMD = New MySql.Data.MySqlClient.MySqlCommand(ubahrow, Conn)
        CMD.ExecuteNonQuery()

        MsgBox("Delete Success")

        Call findAlternatif(ucode)

    End Sub

    Sub deleteEquipment()
        If dataGridViewEquipment.CurrentRow.Index <> dataGridViewEquipment.NewRowIndex Then
            Call bukaDB()
            CMD = New MySqlCommand("select id_equipment from equipment where equipment_name='" & dataGridViewEquipment.Item(0, dataGridViewEquipment.CurrentRow.Index).Value & "'", Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows = True Then
                While RD.Read
                    Pkid_alt = RD.Item("id_equipment")
                End While
            End If
            RD.Close()
        End If
        MsgBox(Pkid_alt)
        Dim ubahrow As String = "delete from equipment_list where PKid_equipment= " & Pkid_alt & ""
        CMD = New MySql.Data.MySqlClient.MySqlCommand(ubahrow, Conn)
        CMD.ExecuteNonQuery()

        MsgBox("Delete Success")

        Call tampilDataEquipment(ucode)
    End Sub

    'editing in textbox
    Sub viewInTextbox()
        tbUniqueCode.Enabled = False
        tbPartNumber.Enabled = False
        buttonUniqueCode.Enabled = False
        buttonSearchPN.Enabled = False
        If var = 1 Then
            Call bukaDB()
            CMD = New MySqlCommand("select * from material where id_material ='" & ucode & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                tbPartNumber.Text = RD.Item("mat_part_number")
                tbMaterialDesc.Text = RD.Item("mat_desc")
                tbBrand.Text = RD.Item("mat_brand")
                tbStock.Text = RD.Item("mat_stock")
                comboBoxUM.Text = RD.Item("mat_um")
                comboBoxMaterialType.Text = RD.Item("mat_type")
                tbLocation.Text = RD.Item("mat_location").ToString
                tbRemarksMaterial.Text = RD.Item("mat_remark").ToString
            End If
            RD.Close()

        ElseIf var = 3 Then
            tbMaterialDesc.Enabled = False
            Call bukaDB()
            CMD = New MySqlCommand("select id_alternatif from alternatif where alt_part_number ='" & dataGridViewAlernatif.Item(1, dataGridViewAlernatif.CurrentRow.Index).Value & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                axcode = RD.Item("id_alternatif")
                MsgBox("axcode : " & axcode)
            Else
                MsgBox("not found")
            End If
            RD.Close()

            Call bukaDB()
            CMD = New MySqlCommand("select * from alternatif where id_alternatif ='" & axcode & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                tbPartNumber.Text = RD.Item("alt_part_number")
                tbBrand.Text = RD.Item("alt_brand")
                tbStock.Text = RD.Item("alt_stock")
                comboBoxUM.Text = RD.Item("alt_um")
                comboBoxMaterialType.Text = RD.Item("alt_type")
                tbLocation.Text = RD.Item("alt_location").ToString
                tbRemarksMaterial.Text = RD.Item("alt_remark").ToString
            End If
            RD.Close()
        End If

    End Sub

    'Tombol Keluar
    Private Sub toolStripLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripLogOut.Click
        Me.Close()
        MessageBox.Show("You are logged out!")
    End Sub

    'Menuju page Landing
    Private Sub toolStripStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripStatus.Click
        landingPageMaterial.Refresh()
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
        Call initUcode()
        MsgBox("ButtonFind, Ucode: " & ucode)
        Call findMaterial(ucode)
        Call findAlternatif(ucode)
        Call tampilDataEquipment(ucode)
    End Sub

    'Button menambahkan equipment menggunakan sub addEquipment
    Private Sub buttonAddEquipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAddEquipment.Click
        If comboBoxEquipment.SelectedItem <> "" Then
            Call addEquipment()
            Call tampilDataEquipment(ucode)
        End If
    End Sub

    Private Sub buttonSearchPN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSearchPN.Click

        Call initUcode()
        Call findMaterial(ucode)
        Call findAlternatif(ucode)
        Call tampilDataEquipment(ucode)
    End Sub


    Private Sub buttonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSave.Click
        Call initAltCode()
        Call addOrEdit()
        MsgBox("ucode :" & ucode)
        Call findMaterial(ucode)
        Call findAlternatif(ucode)
        Call tampilDataEquipment(ucode)
        MsgBox("var =" & var)
        Call autocompletePN()
        Call clearform()
    End Sub

    Private Sub buttonAddPN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAddPN.Click

        If tbUniqueCode.Text = "" Or ucode = 0 Then
            MsgBox("Please Insert Code")
        Else
            var = 2
            MsgBox("buttonAddPn, var :" & var)
            Call autocompletePN()
            Call clearform()
        End If
    End Sub

    Private Sub buttonEditMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonEditMaterial.Click
        If tbUniqueCode.Text = "" Or ucode = 0 Then
            MsgBox("please Insert A code ")
        Else
            var = 1
            MsgBox("buttonEditMat, var :" & var)
            Call viewInTextbox()
        End If
    End Sub

    Private Sub buttonEditAlternatif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonEditAlternatif.Click
        If tbUniqueCode.Text = "" Or ucode = 0 Then
            MsgBox("please Insert A code ")
        Else
            var = 3
            MsgBox("buttonEditAlt, var :" & var)
            Call viewInTextbox()
        End If
    End Sub

    Private Sub buttonDeleteAlternative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonDeleteAlternative.Click
        If tbUniqueCode.Text = "" Or ucode = 0 Then
            MsgBox("please Insert A code ")
        Else
            Call deleteAlt()
        End If
    End Sub

    Private Sub buttonDeleteEquipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonDeleteEquipment.Click
        If tbUniqueCode.Text = "" Or ucode = 0 Then
            MsgBox("please Insert A code ")
        Else
            Call deleteEquipment()
        End If
    End Sub

    Private Sub tbPartNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPartNumber.TextChanged
        If var = 2 Then
            bukaDB()
            CMD = New MySqlCommand("select id_alternatif from alternatif where alt_part_number = '" & tbPartNumber.Text & "'", Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows = True Then
                buttonSearchPN.Enabled = False
                tbMaterialDesc.Enabled = False
                tbBrand.Enabled = False
                tbStock.Enabled = False
                comboBoxUM.Enabled = False
                comboBoxMaterialType.Enabled = False
                tbLocation.Enabled = False
                tbRemarksMaterial.Enabled = False
            Else
                buttonSearchPN.Enabled = True
                tbMaterialDesc.Enabled = True
                tbBrand.Enabled = True
                tbStock.Enabled = True
                comboBoxUM.Enabled = True
                comboBoxMaterialType.Enabled = True
                tbLocation.Enabled = True
                tbRemarksMaterial.Enabled = True
            End If
            Conn.Close()
        End If

    End Sub

End Class