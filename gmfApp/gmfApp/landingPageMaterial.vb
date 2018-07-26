Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class landingPageMaterial

    Dim input As String
    Dim ucode As Integer

    'FORM LOAD
    Private Sub LandingPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dataFindResult.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        If (addItemMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
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


    'TAMPILAN HEADERS
    Sub HeadersDGV()

        dataFindResult.DataSource = DS.Tables("material, alternatif, equipment equipment_list, alternatif_list")

        With dataFindResult
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "PF Code"
            .Columns(1).HeaderCell.Value = "Part Number"
            .Columns(2).HeaderCell.Value = "Material Description"
            .Columns(3).HeaderCell.Value = "Batch"
            .Columns(4).HeaderCell.Value = "Brand"
            .Columns(5).HeaderCell.Value = "Stock"
            .Columns(6).HeaderCell.Value = "UM"
            .Columns(7).HeaderCell.Value = "Type"
            .Columns(9).HeaderCell.Value = "Location"
            .Columns(10).HeaderCell.Value = "Remarks"
        End With

        'dataFindResult.Columns("id_material").HeaderText = "PF Code"
        'dataFindResult.Columns("mat_part_number").HeaderText = "Part Number"
        'dataFindResult.Columns("mat_desc").HeaderText = "Material Description"
        'dataFindResult.Columns("mat_brand").HeaderText = "Brand"
        'dataFindResult.Columns("mat_stock").HeaderText = "Stock"
        'dataFindResult.Columns("mat_um").HeaderText = "UM"
        'dataFindResult.Columns("mat_type").HeaderText = "Type"
        'dataFindResult.Columns("mat_location").HeaderText = "Location"
        'dataFindResult.Columns("mat_remark").HeaderText = "Remarks"
    End Sub

    'STATUS TOTAL MATERIAL
    Sub totalMat()
        Call bukaDB()
        Try
            CMD = New MySqlCommand("SELECT COUNT(id_material) from material", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            totalMaterial.Text = RD.Item("COUNT(id_material)")
            Conn.Close()

        Catch ex As Exception
            MsgBox("Total Count Failed")
        End Try
    End Sub


    'TAMPIL ALL DATA
    Sub TampilAllData()
        'Call HeadersDGV()
        Call bukaDB()

        Try
            DA = New MySqlDataAdapter("SELECT id_material , mat_part_number, mat_desc, mat_brand, mat_stock, mat_um, mat_type, GROUP_CONCAT(equipment_name SEPARATOR ', ') As Equipment, mat_location, mat_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment UNION SELECT id_material, alt_part_number, mat_desc, alt_brand, alt_stock, alt_um, alt_type, equipment_name, alt_location, alt_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material  INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif ORDER BY id_material asc", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.ReadOnly = True
            Conn.Close()

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
        ExcelApp.Columns(3).ColumnWidth = 30
        ExcelApp.Columns(4).ColumnWidth = 15
        ExcelApp.Columns(5).ColumnWidth = 15
        ExcelApp.Columns(6).ColumnWidth = 20
        ExcelApp.Columns(7).ColumnWidth = 25
        ExcelApp.Columns(8).ColumnWidth = 40
        ExcelApp.Columns(9).ColumnWidth = 25
        ExcelApp.Columns(10).ColumnWidth = 40

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
            DA = New MySqlDataAdapter("SELECT id_material, mat_part_number, mat_desc, mat_brand, mat_stock, mat_um, mat_type, equipment_name, mat_location, mat_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment WHERE id_material='" & tbSearchItem.Text & "' UNION SELECT id_material, alt_part_number, mat_desc, alt_brand, alt_stock, alt_um, alt_type,  equipment_name, alt_location, alt_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material  INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif WHERE id_material='" & tbSearchItem.Text & "' ORDER BY id_material asc", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.ReadOnly = True
            Conn.Close()

        Catch ex As Exception
            MsgBox("Failed load data from UQ")
        End Try
    End Sub


    'SEARCH MATERIAL BY PART NUMBER
    Sub FindMaterialByPartNumber()
        Call bukaDB()

        Try
            DA = New MySqlDataAdapter("SELECT id_material, mat_part_number, mat_desc, mat_brand, mat_stock, mat_um, mat_type, equipment_name, mat_location, mat_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment WHERE mat_part_number LIKE '%" & tbSearchItem.Text & "%' UNION SELECT id_material, alt_part_number, mat_desc, alt_brand, alt_stock, alt_um, alt_type,  equipment_name, alt_location, alt_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material  INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif WHERE mat_part_number LIKE '%" & tbSearchItem.Text & "%' ORDER BY id_material asc", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.ReadOnly = True
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

        Else
            Call FindMaterialByEquipment()
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
            dataFindResult.ReadOnly = True
            Conn.Close()

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
End Class
