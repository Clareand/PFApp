Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class landingPageMaterial

    Dim input As String
    Dim ucode As Integer

    'FORM LOAD
    Private Sub LandingPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (addItemMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized

            'REFRESH
            ResetBindings()
            dataFindResult.Refresh()

            Call bukaDB()
            Call TampilAllData()
            Call cbOption()
            Call totalMat()
            Call Sugest1()
            Call Sugest2()
            Call Sugest3()

        End If
    End Sub

    'TOOLSSTRIP LOGOUT
    Private Sub toolStripLogOut_Click(sender As System.Object, e As System.EventArgs) Handles toolStripLogOut.Click
        Me.Close()
        MessageBox.Show("You are logged out!")
    End Sub

    'TOOLSTRIP MATERIAL
    Private Sub MaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        addItemMaterial.Show()
        Me.Visible = False
    End Sub

    'TOOLSTRIP HISTORY
    Private Sub HistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        history.Show()
        Me.Visible = False
    End Sub

    'HEADERS COLUMN
    Sub DGView()

        dataFindResult.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dataFindResult.Columns("mat_desc").DefaultCellStyle.WrapMode = DataGridViewTriState.False
        dataFindResult.Columns("mat_brand").DefaultCellStyle.WrapMode = DataGridViewTriState.False
        dataFindResult.Columns("mat_um").DefaultCellStyle.WrapMode = DataGridViewTriState.False
        dataFindResult.Columns("equipment_name").DefaultCellStyle.WrapMode = DataGridViewTriState.False
        dataFindResult.Columns("mat_type").DefaultCellStyle.WrapMode = DataGridViewTriState.False
        dataFindResult.Columns("mat_location").DefaultCellStyle.WrapMode = DataGridViewTriState.False
        dataFindResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dataFindResult.AutoResizeColumns()

        dataFindResult.Columns("id_material").HeaderText = "PF Code"
        dataFindResult.Columns("mat_part_number").HeaderText = "Part Number"
        dataFindResult.Columns("mat_desc").HeaderText = "Material Description"
        dataFindResult.Columns("mat_brand").HeaderText = "Brand"
        dataFindResult.Columns("mat_stock").HeaderText = "Stock"
        dataFindResult.Columns("mat_um").HeaderText = "UM"
        dataFindResult.Columns("mat_type").HeaderText = "Type"
        dataFindResult.Columns("equipment_name").HeaderText = "Equipment"
        dataFindResult.Columns("mat_location").HeaderText = "Location"
        dataFindResult.Columns("mat_remark").HeaderText = "Remarks"

        dataFindResult.Columns("id_material").Width = 300
        dataFindResult.Columns("mat_part_number").Width = 300
        dataFindResult.Columns("mat_desc").Width = 300
        dataFindResult.Columns("mat_brand").Width = 300
        dataFindResult.Columns("mat_stock").Width = 300
        dataFindResult.Columns("mat_um").Width = 300
        dataFindResult.Columns("mat_type").Width = 300
        dataFindResult.Columns("equipment_name").Width = 300
        dataFindResult.Columns("mat_location").Width = 300
        dataFindResult.Columns("mat_remark").Width = 300

        dataFindResult.Columns(0).Width = 300
        dataFindResult.Columns(1).Width = 300
        dataFindResult.Columns(2).Width = 300
        dataFindResult.Columns(3).Width = 300
        dataFindResult.Columns(4).Width = 300
        dataFindResult.Columns(5).Width = 300
        dataFindResult.Columns(6).Width = 300
        dataFindResult.Columns(7).Width = 300
        dataFindResult.Columns(8).Width = 300
        dataFindResult.Columns(9).Width = 300
    End Sub

    'STATUS TOTAL MATERIAL
    Sub totalMat()
        Call bukaDB()
        Try
            CMD = New MySqlCommand("SELECT COUNT(id_material) from material", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            totalMaterial.Text = RD.Item("COUNT(id_material)")

        Catch ex As Exception
            MsgBox("Total Count Failed")
        End Try
    End Sub


    'TAMPIL ALL DATA
    Sub TampilAllData()

        Call bukaDB()
        dataFindResult.DataSource = Nothing


        Try
            DA = New MySqlDataAdapter("SELECT material.id_material, material.mat_part_number, material.mat_desc, material.mat_brand, material.mat_stock, material.mat_um, material.mat_type, group_concat(distinct equipment.equipment_name, 0 order by equipment.equipment_name separator ', ') as equipment_name, material.mat_location, material.mat_remark FROM material LEFT JOIN equipment_list ON material.id_material=equipment_list.PKid_material LEFT JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment group by id_material UNION SELECT material.id_material, alternatif.alt_part_number, material.mat_desc, alternatif.alt_brand, alternatif.alt_stock, alternatif.alt_um, alternatif.alt_type, group_concat(distinct equipment.equipment_name order by equipment.equipment_name separator ', ') as equipment_name, alternatif.alt_location, alternatif.alt_remark FROM material LEFT JOIN equipment_list ON material.id_material=equipment_list.PKid_material  LEFT JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif group by alt_part_number, id_material ORDER BY id_material", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.ReadOnly = True
            Conn.Close()
            Call DGView()
        Catch ex As Exception
            MsgBox("Failed Load Data")
        End Try

    End Sub

    'EXPORT TO EXCEL
    Sub export()
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)

        'EXCEL COLUMN WIDTH
        ExcelApp.Columns(1).ColumnWidth = 15
        ExcelApp.Columns(2).ColumnWidth = 20
        ExcelApp.Columns(3).ColumnWidth = 35
        ExcelApp.Columns(4).ColumnWidth = 20
        ExcelApp.Columns(5).ColumnWidth = 20
        ExcelApp.Columns(6).ColumnWidth = 27
        ExcelApp.Columns(7).ColumnWidth = 25
        ExcelApp.Columns(8).ColumnWidth = 40
        ExcelApp.Columns(9).ColumnWidth = 25
        ExcelApp.Columns(10).ColumnWidth = 50

        'EXCEL COLUMN STYLE
        ExcelApp.Range("A1:J1").Font.Bold = True
        ExcelApp.Columns("A:S").EntireColumn.AutoFit()
        ExcelApp.Range("A:S").VerticalAlignment = Excel.Constants.xlCenter
        ExcelApp.Range("A1:J1").HorizontalAlignment = Excel.Constants.xlCenter
        ExcelApp.Range("A1:J1").interior.colorindex = 37
        ExcelApp.Range("A2:J" & dataFindResult.RowCount + 1).WrapText = True
        ExcelApp.Range("A1:J" & dataFindResult.RowCount + 1).Borders.Color = RGB(0, 0, 0)

        'EXCEL EXPORT
        Try
            With ExcelSheet
                For Each column As DataGridViewColumn In dataFindResult.Columns
                    .cells(1, column.Index + 1) = column.HeaderText
                Next
                For i = 1 To Me.dataFindResult.RowCount
                    .cells(i + 1, 1) = Me.dataFindResult.Rows(i - 1).Cells("id_material").Value
                    For j = 1 To dataFindResult.Columns.Count - 1
                        .cells(i + 1, j + 1) = dataFindResult.Rows(i - 1).Cells(j).Value
                    Next
                Next
            End With

        Catch ex As Exception
            MsgBox("Export Excel Error")
        End Try

        'EXCEL SAVE
        Dim savePath As String = Nothing
        Using sd As New SaveFileDialog
            With sd
                .RestoreDirectory = True
                .Filter = "Excel XLS Files(*.xls)|*.xls"
                .FilterIndex = 3
                If .ShowDialog = DialogResult.OK Then
                    savePath = .FileName
                End If
            End With
        End Using

        If savePath IsNot Nothing AndAlso savePath.Trim <> "" Then
            ExcelBook.SaveAs(savePath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            MessageBox.Show("Your File is successfully saved " & savePath)
            ExcelBook.Close(True, misValue, misValue)
            ExcelApp.Quit()
        Else
            ExcelBook.Close(False, misValue, misValue)
            ExcelApp.Quit()
        End If

        releaseObject(ExcelSheet)
        releaseObject(ExcelSheet)
        releaseObject(ExcelApp)

    End Sub

    'RELEASE OBJECT
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    'SEARCH MATERIAL BY ID_MATERIAL
    Sub FindMaterialByUniqueCode()
        Call bukaDB()
        Try
            DA = New MySqlDataAdapter("SELECT material.id_material, material.mat_part_number, material.mat_desc, material.mat_brand, material.mat_stock, material.mat_um, material.mat_type, group_concat(distinct equipment.equipment_name order by equipment.equipment_name separator ', ') as equipment_name, material.mat_location, material.mat_remark FROM material LEFT JOIN equipment_list ON material.id_material=equipment_list.PKid_material LEFT JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment WHERE id_material='" & tbSearchItem.Text & "' group by id_material UNION SELECT material.id_material, alternatif.alt_part_number, material.mat_desc, alternatif.alt_brand, alternatif.alt_stock, alternatif.alt_um, alternatif.alt_type, group_concat(distinct equipment.equipment_name order by equipment.equipment_name separator ', ') as equipment_name, alternatif.alt_location, alternatif.alt_remark FROM material LEFT JOIN equipment_list ON material.id_material=equipment_list.PKid_material LEFT JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif WHERE id_material='" & tbSearchItem.Text & "'  group by alt_part_number, id_material ORDER BY id_material", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.ReadOnly = True
            Call DGView()
            Conn.Close()


        Catch ex As Exception
            MsgBox("Failed load data from UQ")
        End Try
    End Sub


    'SEARCH MATERIAL BY PART NUMBER
    Sub FindMaterialByPartNumber()
        Call bukaDB()

        Try
            DA = New MySqlDataAdapter("SELECT material.id_material, material.mat_part_number, material.mat_desc, material.mat_brand, material.mat_stock, material.mat_um, material.mat_type, group_concat(distinct equipment.equipment_name order by equipment.equipment_name separator ', ') as equipment_name, material.mat_location, material.mat_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment WHERE mat_part_number='" & tbSearchItem.Text & "' group by id_material UNION SELECT material.id_material, alternatif.alt_part_number, material.mat_desc, alternatif.alt_brand, alternatif.alt_stock, alternatif.alt_um, alternatif.alt_type, group_concat(distinct equipment.equipment_name order by equipment.equipment_name separator ', ') as equipment_name, alternatif.alt_location, alternatif.alt_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material  INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif WHERE mat_part_number='" & tbSearchItem.Text & "'  group by alt_part_number, id_material ORDER BY id_material", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.ReadOnly = True
            Call DGView()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Failed load data from PN")
        End Try
    End Sub

    'SEARCH EQUIPMENT
    Sub FindMaterialByEquipment()
        Call bukaDB()
        Try
            DA = New MySqlDataAdapter("SELECT id_material, mat_part_number, mat_desc, mat_brand, mat_stock, mat_um, mat_type, equipment_name, mat_location, mat_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment WHERE equipment_name= '" & tbSearchItem.Text & "' UNION SELECT id_material, alt_part_number, mat_desc, alt_brand, alt_stock, alt_um, alt_type,  equipment_name, alt_location, alt_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material  INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif WHERE equipment_name= '" & tbSearchItem.Text & "' ORDER BY id_material asc", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.ReadOnly = True
            Call DGView()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Failed load data from Equip")
        End Try
    End Sub

    'TAMPILAN COMBO BOX OPTION
    Sub cbOption()
        Me.cbSearchType.Items.Add("PF Code")
        Me.cbSearchType.Items.Add("Part Number")
        Me.cbSearchType.Items.Add("Equipment")
    End Sub

    'INIT SEARCH
    Sub Search()
        input = tbSearchItem.Text
        MsgBox(input)

        If cbSearchType.SelectedItem = "PF Code" Then
            Call FindMaterialByUniqueCode()

        ElseIf cbSearchType.SelectedItem = "Part Number" Then
            Call FindMaterialByPartNumber()

        ElseIf cbSearchType.SelectedItem = "Equipment" Then
            Call FindMaterialByEquipment()

        Else
            MsgBox("Please Choose Your Search Type.")
        End If


    End Sub

    'SUGGEST FOR MATERIAL FROM ID_MATERIAL
    Sub Sugest1()
        bukaDB()
        CMD = New MySqlCommand("select id_material from material WHERE id_material LIKE '%" & tbSearchItem.Text & "%'", Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            With tbSearchItem
                .AutoCompleteCustomSource.Add(RD(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        Conn.Close()
    End Sub

    'SUGGEST FOR MATERIAL FROM MATERIAL PART NUMBER
    Sub Sugest2()
        bukaDB()
        CMD = New MySqlCommand("select mat_part_number from material WHERE mat_part_number LIKE '%" & tbSearchItem.Text & "%'", Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            With tbSearchItem
                .AutoCompleteCustomSource.Add(RD(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        Conn.Close()
    End Sub

    'SEARCH EQUIPMENT
    Sub Sugest3()
        bukaDB()
        CMD = New MySqlCommand("select equipment_name from equipment WHERE equipment_name LIKE '%" & tbSearchItem.Text & "%'", Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            With tbSearchItem
                .AutoCompleteCustomSource.Add(RD(0).ToString)
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        Conn.Close()
    End Sub


    'SEARCH BY PART NUMER OR ID_MATERIAL
    Sub ordb()
        input = tbSearchItem.Text

        MsgBox(input)

        Call bukaDB()
        Try
            DA = New MySqlDataAdapter("SELECT id_material, mat_part_number, mat_desc, mat_brand, mat_stock, mat_um, mat_type, equipment_name, mat_location, mat_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment WHERE id_material='" & tbSearchItem.Text & "'or mat_part_number='" & tbSearchItem.Text & "' UNION SELECT id_material, alt_part_number, mat_desc, alt_brand, alt_stock, alt_um, alt_type,  equipment_name, alt_location, alt_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material  INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif  WHERE id_material='" & tbSearchItem.Text & "' or mat_part_number='" & tbSearchItem.Text & "' ORDER BY id_material asc", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            If dataFindResult.ReadOnly = True Then
                dataFindResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dataFindResult.AutoResizeColumns()
                Conn.Close()
            Else
                MsgBox("Data Not Found.")
            End If

        Catch ex As Exception
            MsgBox("Failed load data.")
        End Try
    End Sub


    'BUTTON EXPORT
    Private Sub buttonExport_Click(sender As System.Object, e As System.EventArgs) Handles buttonExport.Click
        Call export()
    End Sub

    'BUTTON SEARCH
    Private Sub buttonSearch_Click(sender As System.Object, e As System.EventArgs) Handles buttonSearch.Click
        Call Search()
    End Sub

    Private Sub tbSearchItem_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbSearchItem.TextChanged
        If tbSearchItem.Text = "" Then
            Call TampilAllData()
        End If
    End Sub

    Private Sub dataFindResult_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataFindResult.CellContentClick
        TampilAllData()
    End Sub
End Class
