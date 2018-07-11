<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class landingPageMaterial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(landingPageMaterial))
        Me.toolStripStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripAddItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dataFindResult = New System.Windows.Forms.DataGridView()
        Me.UniqueCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonSearch = New System.Windows.Forms.Button()
        Me.searchStatusItem = New System.Windows.Forms.TextBox()
        Me.buttonExport = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataFindResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolStripStatus
        '
        Me.toolStripStatus.Name = "toolStripStatus"
        Me.toolStripStatus.Size = New System.Drawing.Size(87, 20)
        Me.toolStripStatus.Text = "Status Check"
        '
        'toolStripAddItem
        '
        Me.toolStripAddItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaterialToolStripMenuItem})
        Me.toolStripAddItem.Name = "toolStripAddItem"
        Me.toolStripAddItem.Size = New System.Drawing.Size(68, 20)
        Me.toolStripAddItem.Text = "Add Item"
        '
        'MaterialToolStripMenuItem
        '
        Me.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem"
        Me.MaterialToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MaterialToolStripMenuItem.Text = "Material"
        '
        'toolStripLogOut
        '
        Me.toolStripLogOut.Name = "toolStripLogOut"
        Me.toolStripLogOut.Size = New System.Drawing.Size(62, 20)
        Me.toolStripLogOut.Text = "Log Out"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatus, Me.toolStripAddItem, Me.toolStripLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.buttonExport)
        Me.GroupBox1.Controls.Add(Me.dataFindResult)
        Me.GroupBox1.Controls.Add(Me.buttonSearch)
        Me.GroupBox1.Controls.Add(Me.searchStatusItem)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 465)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dataFindResult
        '
        Me.dataFindResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataFindResult.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataFindResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataFindResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UniqueCode, Me.PartNumber, Me.MaterialDescription, Me.Brand, Me.Stock, Me.UM, Me.Type, Me.Equipment, Me.Location, Me.Remark})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataFindResult.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataFindResult.EnableHeadersVisualStyles = False
        Me.dataFindResult.Location = New System.Drawing.Point(6, 65)
        Me.dataFindResult.Name = "dataFindResult"
        Me.dataFindResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dataFindResult.Size = New System.Drawing.Size(648, 353)
        Me.dataFindResult.TabIndex = 11
        '
        'UniqueCode
        '
        Me.UniqueCode.DataPropertyName = "llllalala"
        Me.UniqueCode.HeaderText = "Unique Code"
        Me.UniqueCode.Name = "UniqueCode"
        '
        'PartNumber
        '
        Me.PartNumber.HeaderText = "Part Number"
        Me.PartNumber.Name = "PartNumber"
        '
        'MaterialDescription
        '
        Me.MaterialDescription.HeaderText = "Material Description"
        Me.MaterialDescription.Name = "MaterialDescription"
        '
        'Brand
        '
        Me.Brand.HeaderText = "Brand"
        Me.Brand.Name = "Brand"
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'UM
        '
        Me.UM.FillWeight = 50.0!
        Me.UM.HeaderText = "UM"
        Me.UM.Name = "UM"
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        '
        'Equipment
        '
        Me.Equipment.HeaderText = "Equipment"
        Me.Equipment.Name = "Equipment"
        '
        'Location
        '
        Me.Location.HeaderText = "Location"
        Me.Location.Name = "Location"
        '
        'Remark
        '
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        '
        'buttonSearch
        '
        Me.buttonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSearch.Location = New System.Drawing.Point(329, 18)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(75, 29)
        Me.buttonSearch.TabIndex = 7
        Me.buttonSearch.Text = "Search"
        Me.buttonSearch.UseVisualStyleBackColor = True
        '
        'searchStatusItem
        '
        Me.searchStatusItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchStatusItem.Location = New System.Drawing.Point(6, 21)
        Me.searchStatusItem.Name = "searchStatusItem"
        Me.searchStatusItem.Size = New System.Drawing.Size(317, 26)
        Me.searchStatusItem.TabIndex = 6
        '
        'buttonExport
        '
        Me.buttonExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonExport.Location = New System.Drawing.Point(575, 428)
        Me.buttonExport.Name = "buttonExport"
        Me.buttonExport.Size = New System.Drawing.Size(75, 29)
        Me.buttonExport.TabIndex = 12
        Me.buttonExport.Text = "Export"
        Me.buttonExport.UseVisualStyleBackColor = True
        '
        'landingPageMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 525)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "landingPageMaterial"
        Me.Text = "GMF"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataFindResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolStripStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripAddItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents buttonSearch As System.Windows.Forms.Button
    Friend WithEvents searchStatusItem As System.Windows.Forms.TextBox
    Friend WithEvents dataFindResult As System.Windows.Forms.DataGridView
    Friend WithEvents MaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UniqueCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Equipment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Location As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buttonExport As System.Windows.Forms.Button

End Class
