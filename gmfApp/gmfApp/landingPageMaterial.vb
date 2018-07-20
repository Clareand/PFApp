﻿Imports MySql.Data.MySqlClient

Public Class landingPageMaterial

    Private Sub LandingPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dataFindResult.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        If (addItemMaterial.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
            Call bukaDB()
            Call TampilAllData()
            Call totalMat()
        End If


    End Sub

    Private Sub toolStripLogOut_Click(sender As System.Object, e As System.EventArgs) Handles toolStripLogOut.Click
        Me.Close()
        MessageBox.Show("You are logged out!")
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        addItemMaterial.Show()
        Me.Visible = False
    End Sub
    
    Private Sub HistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        history.Show()
        Me.Visible = False
    End Sub

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

    Sub TampilAllData()
        Call bukaDB()
        Try
            DA = New MySqlDataAdapter("SELECT id_material, mat_part_number, mat_desc, mat_brand, mat_stock, mat_um, mat_type, equipment_name, mat_location, mat_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment UNION SELECT id_material, alt_part_number, mat_desc, alt_brand, alt_stock, alt_um, alt_type,  equipment_name, alt_location, alt_remark FROM material INNER JOIN equipment_list ON material.id_material=equipment_list.PKid_material  INNER JOIN equipment ON equipment_list.PKid_equipment=equipment.id_equipment INNER JOIN alternatif_list ON material.id_material=alternatif_list.PKid_material INNER JOIN alternatif ON alternatif.id_alternatif=alternatif_list.PKid_alternatif ORDER BY id_material asc", Conn)
            DS = New DataSet
            DA.Fill(DS, "material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.DataSource = DS.Tables("material, equipment, equipment_list, alternatif, alternatif_list")
            dataFindResult.ReadOnly = True
        Catch ex As Exception
            MsgBox("Failed Load Data")
        End Try

    End Sub

    
    
    Private Sub buttonExport_Click(sender As System.Object, e As System.EventArgs) Handles buttonExport.Click
        Call export()
    End Sub

    Sub export()
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim i As Integer
        Dim j As Integer
        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)

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

        
        ExcelApp.Visible = True
        ExcelSheet = Nothing
        ExcelBook = Nothing
        ExcelApp = Nothing
    End Sub

    
End Class
