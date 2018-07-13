<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addItemMaterial
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addItemMaterial))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolStripStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripAddItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbUniqueCode = New System.Windows.Forms.TextBox()
        Me.buttonUniqueCode = New System.Windows.Forms.Button()
        Me.buttonAddPN = New System.Windows.Forms.Button()
        Me.buttonClearPN = New System.Windows.Forms.Button()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.buttonDeleteAlternative = New System.Windows.Forms.Button()
        Me.buttonEditAlternatif = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comboBoxUM = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbRemarksMaterial = New System.Windows.Forms.RichTextBox()
        Me.comboBoxMaterialType = New System.Windows.Forms.ComboBox()
        Me.comboBoxEquipment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.tbBrand = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttonSearchPN = New System.Windows.Forms.Button()
        Me.tbMaterialDesc = New System.Windows.Forms.TextBox()
        Me.buttonAddEquipment = New System.Windows.Forms.Button()
        Me.tbPartNumber = New System.Windows.Forms.TextBox()
        Me.dataGridViewEquipment = New System.Windows.Forms.DataGridView()
        Me.Equipment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonDeleteEquipment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.buttonEditMaterial = New System.Windows.Forms.Button()
        Me.dataGridViewMaterial = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.daraGridViewAlernative = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBoxMaterial = New System.Windows.Forms.GroupBox()
        Me.groupBoxAlternatif = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridViewEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.daraGridViewAlernative, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxMaterial.SuspendLayout()
        Me.groupBoxAlternatif.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatus, Me.toolStripAddItem, Me.toolStripLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolStripStatus
        '
        Me.toolStripStatus.Name = "toolStripStatus"
        Me.toolStripStatus.Size = New System.Drawing.Size(87, 20)
        Me.toolStripStatus.Text = "Status Check"
        '
        'toolStripAddItem
        '
        Me.toolStripAddItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaterialToolStripMenuItem, Me.EquipmentToolStripMenuItem})
        Me.toolStripAddItem.Name = "toolStripAddItem"
        Me.toolStripAddItem.Size = New System.Drawing.Size(68, 20)
        Me.toolStripAddItem.Text = "Add Item"
        '
        'MaterialToolStripMenuItem
        '
        Me.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem"
        Me.MaterialToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.MaterialToolStripMenuItem.Text = "Material"
        '
        'EquipmentToolStripMenuItem
        '
        Me.EquipmentToolStripMenuItem.Name = "EquipmentToolStripMenuItem"
        Me.EquipmentToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EquipmentToolStripMenuItem.Text = "Equipment"
        '
        'toolStripLogOut
        '
        Me.toolStripLogOut.Name = "toolStripLogOut"
        Me.toolStripLogOut.Size = New System.Drawing.Size(62, 20)
        Me.toolStripLogOut.Text = "Log Out"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Unique Code"
        '
        'tbUniqueCode
        '
        Me.tbUniqueCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUniqueCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUniqueCode.Location = New System.Drawing.Point(189, 19)
        Me.tbUniqueCode.Name = "tbUniqueCode"
        Me.tbUniqueCode.Size = New System.Drawing.Size(305, 26)
        Me.tbUniqueCode.TabIndex = 11
        '
        'buttonUniqueCode
        '
        Me.buttonUniqueCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonUniqueCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonUniqueCode.Location = New System.Drawing.Point(509, 18)
        Me.buttonUniqueCode.Name = "buttonUniqueCode"
        Me.buttonUniqueCode.Size = New System.Drawing.Size(77, 27)
        Me.buttonUniqueCode.TabIndex = 13
        Me.buttonUniqueCode.Text = "Find"
        Me.buttonUniqueCode.UseVisualStyleBackColor = True
        '
        'buttonAddPN
        '
        Me.buttonAddPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAddPN.Location = New System.Drawing.Point(252, 498)
        Me.buttonAddPN.Name = "buttonAddPN"
        Me.buttonAddPN.Size = New System.Drawing.Size(129, 27)
        Me.buttonAddPN.TabIndex = 24
        Me.buttonAddPN.Text = "Add Alternative"
        Me.buttonAddPN.UseVisualStyleBackColor = True
        '
        'buttonClearPN
        '
        Me.buttonClearPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClearPN.Location = New System.Drawing.Point(388, 498)
        Me.buttonClearPN.Name = "buttonClearPN"
        Me.buttonClearPN.Size = New System.Drawing.Size(90, 27)
        Me.buttonClearPN.TabIndex = 25
        Me.buttonClearPN.Text = "Clear"
        Me.buttonClearPN.UseVisualStyleBackColor = True
        '
        'buttonSave
        '
        Me.buttonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSave.Location = New System.Drawing.Point(484, 498)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(90, 27)
        Me.buttonSave.TabIndex = 26
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'buttonDeleteAlternative
        '
        Me.buttonDeleteAlternative.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonDeleteAlternative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDeleteAlternative.Location = New System.Drawing.Point(574, 463)
        Me.buttonDeleteAlternative.Name = "buttonDeleteAlternative"
        Me.buttonDeleteAlternative.Size = New System.Drawing.Size(90, 27)
        Me.buttonDeleteAlternative.TabIndex = 31
        Me.buttonDeleteAlternative.Text = "Delete"
        Me.buttonDeleteAlternative.UseVisualStyleBackColor = True
        '
        'buttonEditAlternatif
        '
        Me.buttonEditAlternatif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonEditAlternatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonEditAlternatif.Location = New System.Drawing.Point(478, 463)
        Me.buttonEditAlternatif.Name = "buttonEditAlternatif"
        Me.buttonEditAlternatif.Size = New System.Drawing.Size(90, 27)
        Me.buttonEditAlternatif.TabIndex = 30
        Me.buttonEditAlternatif.Text = "Edit"
        Me.buttonEditAlternatif.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.tbUniqueCode)
        Me.GroupBox1.Controls.Add(Me.buttonUniqueCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 83)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "UM"
        '
        'comboBoxUM
        '
        Me.comboBoxUM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.comboBoxUM.FormattingEnabled = True
        Me.comboBoxUM.Location = New System.Drawing.Point(189, 147)
        Me.comboBoxUM.Name = "comboBoxUM"
        Me.comboBoxUM.Size = New System.Drawing.Size(95, 28)
        Me.comboBoxUM.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Remarks"
        '
        'tbStock
        '
        Me.tbStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStock.Location = New System.Drawing.Point(189, 111)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(95, 26)
        Me.tbStock.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Equipment"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Brand"
        '
        'tbRemarksMaterial
        '
        Me.tbRemarksMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRemarksMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRemarksMaterial.Location = New System.Drawing.Point(189, 391)
        Me.tbRemarksMaterial.Name = "tbRemarksMaterial"
        Me.tbRemarksMaterial.Size = New System.Drawing.Size(395, 70)
        Me.tbRemarksMaterial.TabIndex = 8
        Me.tbRemarksMaterial.Text = ""
        '
        'comboBoxMaterialType
        '
        Me.comboBoxMaterialType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxMaterialType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxMaterialType.FormattingEnabled = True
        Me.comboBoxMaterialType.Location = New System.Drawing.Point(189, 182)
        Me.comboBoxMaterialType.Name = "comboBoxMaterialType"
        Me.comboBoxMaterialType.Size = New System.Drawing.Size(395, 28)
        Me.comboBoxMaterialType.TabIndex = 10
        Me.comboBoxMaterialType.Text = "Choose One"
        '
        'comboBoxEquipment
        '
        Me.comboBoxEquipment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.comboBoxEquipment.FormattingEnabled = True
        Me.comboBoxEquipment.Location = New System.Drawing.Point(189, 218)
        Me.comboBoxEquipment.Name = "comboBoxEquipment"
        Me.comboBoxEquipment.Size = New System.Drawing.Size(314, 28)
        Me.comboBoxEquipment.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Material Type"
        '
        'tbLocation
        '
        Me.tbLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLocation.Location = New System.Drawing.Point(189, 347)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(395, 26)
        Me.tbLocation.TabIndex = 22
        '
        'tbBrand
        '
        Me.tbBrand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBrand.Location = New System.Drawing.Point(189, 78)
        Me.tbBrand.Name = "tbBrand"
        Me.tbBrand.Size = New System.Drawing.Size(395, 26)
        Me.tbBrand.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Location"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Material Description"
        '
        'buttonSearchPN
        '
        Me.buttonSearchPN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSearchPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSearchPN.Location = New System.Drawing.Point(509, 13)
        Me.buttonSearchPN.Name = "buttonSearchPN"
        Me.buttonSearchPN.Size = New System.Drawing.Size(75, 27)
        Me.buttonSearchPN.TabIndex = 24
        Me.buttonSearchPN.Text = "Find"
        Me.buttonSearchPN.UseVisualStyleBackColor = True
        '
        'tbMaterialDesc
        '
        Me.tbMaterialDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMaterialDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaterialDesc.Location = New System.Drawing.Point(189, 45)
        Me.tbMaterialDesc.Name = "tbMaterialDesc"
        Me.tbMaterialDesc.Size = New System.Drawing.Size(395, 26)
        Me.tbMaterialDesc.TabIndex = 4
        '
        'buttonAddEquipment
        '
        Me.buttonAddEquipment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAddEquipment.Location = New System.Drawing.Point(509, 218)
        Me.buttonAddEquipment.Name = "buttonAddEquipment"
        Me.buttonAddEquipment.Size = New System.Drawing.Size(75, 27)
        Me.buttonAddEquipment.TabIndex = 25
        Me.buttonAddEquipment.Text = "Add"
        Me.buttonAddEquipment.UseVisualStyleBackColor = True
        '
        'tbPartNumber
        '
        Me.tbPartNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPartNumber.Location = New System.Drawing.Point(189, 13)
        Me.tbPartNumber.Name = "tbPartNumber"
        Me.tbPartNumber.Size = New System.Drawing.Size(304, 26)
        Me.tbPartNumber.TabIndex = 0
        '
        'dataGridViewEquipment
        '
        Me.dataGridViewEquipment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewEquipment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewEquipment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Equipment})
        Me.dataGridViewEquipment.Location = New System.Drawing.Point(189, 253)
        Me.dataGridViewEquipment.Name = "dataGridViewEquipment"
        Me.dataGridViewEquipment.Size = New System.Drawing.Size(296, 81)
        Me.dataGridViewEquipment.TabIndex = 26
        '
        'Equipment
        '
        Me.Equipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Equipment.HeaderText = "Equipment"
        Me.Equipment.Name = "Equipment"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Part Number"
        '
        'buttonDeleteEquipment
        '
        Me.buttonDeleteEquipment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonDeleteEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDeleteEquipment.Location = New System.Drawing.Point(509, 253)
        Me.buttonDeleteEquipment.Name = "buttonDeleteEquipment"
        Me.buttonDeleteEquipment.Size = New System.Drawing.Size(75, 27)
        Me.buttonDeleteEquipment.TabIndex = 27
        Me.buttonDeleteEquipment.Text = "Delete"
        Me.buttonDeleteEquipment.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(573, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 27)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'buttonEditMaterial
        '
        Me.buttonEditMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonEditMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonEditMaterial.Location = New System.Drawing.Point(477, 187)
        Me.buttonEditMaterial.Name = "buttonEditMaterial"
        Me.buttonEditMaterial.Size = New System.Drawing.Size(90, 27)
        Me.buttonEditMaterial.TabIndex = 34
        Me.buttonEditMaterial.Text = "Edit"
        Me.buttonEditMaterial.UseVisualStyleBackColor = True
        '
        'dataGridViewMaterial
        '
        Me.dataGridViewMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewMaterial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewMaterial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dataGridViewMaterial.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dataGridViewMaterial.Location = New System.Drawing.Point(7, 19)
        Me.dataGridViewMaterial.Name = "dataGridViewMaterial"
        Me.dataGridViewMaterial.Size = New System.Drawing.Size(663, 160)
        Me.dataGridViewMaterial.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Unique Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 96
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Part Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 94
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Material Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 132
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 65
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "UM"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 51
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "EquipmentNeed"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 121
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 81
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn10.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 75
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.buttonDeleteEquipment)
        Me.GroupBox2.Controls.Add(Me.buttonAddPN)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dataGridViewEquipment)
        Me.GroupBox2.Controls.Add(Me.buttonClearPN)
        Me.GroupBox2.Controls.Add(Me.tbPartNumber)
        Me.GroupBox2.Controls.Add(Me.buttonSave)
        Me.GroupBox2.Controls.Add(Me.buttonAddEquipment)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbMaterialDesc)
        Me.GroupBox2.Controls.Add(Me.comboBoxUM)
        Me.GroupBox2.Controls.Add(Me.buttonSearchPN)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbStock)
        Me.GroupBox2.Controls.Add(Me.tbBrand)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbLocation)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbRemarksMaterial)
        Me.GroupBox2.Controls.Add(Me.comboBoxEquipment)
        Me.GroupBox2.Controls.Add(Me.comboBoxMaterialType)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 645)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'daraGridViewAlernative
        '
        Me.daraGridViewAlernative.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.daraGridViewAlernative.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.daraGridViewAlernative.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.daraGridViewAlernative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.daraGridViewAlernative.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.daraGridViewAlernative.Location = New System.Drawing.Point(11, 27)
        Me.daraGridViewAlernative.Name = "daraGridViewAlernative"
        Me.daraGridViewAlernative.Size = New System.Drawing.Size(656, 428)
        Me.daraGridViewAlernative.TabIndex = 37
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.HeaderText = "Unique Code"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 96
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.HeaderText = "Part Number"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 94
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.HeaderText = "Material Description"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 132
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 65
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 65
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.HeaderText = "UM"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 51
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.HeaderText = "EquipmentNeed"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 121
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 81
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 75
        '
        'groupBoxMaterial
        '
        Me.groupBoxMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxMaterial.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.groupBoxMaterial.Controls.Add(Me.Button1)
        Me.groupBoxMaterial.Controls.Add(Me.buttonEditMaterial)
        Me.groupBoxMaterial.Controls.Add(Me.dataGridViewMaterial)
        Me.groupBoxMaterial.Location = New System.Drawing.Point(605, 27)
        Me.groupBoxMaterial.Name = "groupBoxMaterial"
        Me.groupBoxMaterial.Size = New System.Drawing.Size(679, 224)
        Me.groupBoxMaterial.TabIndex = 38
        Me.groupBoxMaterial.TabStop = False
        Me.groupBoxMaterial.Text = "Material"
        '
        'groupBoxAlternatif
        '
        Me.groupBoxAlternatif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxAlternatif.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.groupBoxAlternatif.Controls.Add(Me.daraGridViewAlernative)
        Me.groupBoxAlternatif.Controls.Add(Me.buttonDeleteAlternative)
        Me.groupBoxAlternatif.Controls.Add(Me.buttonEditAlternatif)
        Me.groupBoxAlternatif.Location = New System.Drawing.Point(605, 247)
        Me.groupBoxAlternatif.Name = "groupBoxAlternatif"
        Me.groupBoxAlternatif.Size = New System.Drawing.Size(679, 504)
        Me.groupBoxAlternatif.TabIndex = 39
        Me.groupBoxAlternatif.TabStop = False
        Me.groupBoxAlternatif.Text = "Alternative"
        '
        'addItemMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.groupBoxAlternatif)
        Me.Controls.Add(Me.groupBoxMaterial)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "addItemMaterial"
        Me.Text = "Add Item"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataGridViewEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridViewMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.daraGridViewAlernative, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxMaterial.ResumeLayout(False)
        Me.groupBoxAlternatif.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents toolStripStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripAddItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquipmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buttonUniqueCode As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbUniqueCode As System.Windows.Forms.TextBox
    Friend WithEvents buttonAddPN As System.Windows.Forms.Button
    Friend WithEvents buttonClearPN As System.Windows.Forms.Button
    Friend WithEvents buttonSave As System.Windows.Forms.Button
    Friend WithEvents buttonDeleteAlternative As System.Windows.Forms.Button
    Friend WithEvents buttonEditAlternatif As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboBoxUM As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbStock As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbRemarksMaterial As System.Windows.Forms.RichTextBox
    Friend WithEvents comboBoxMaterialType As System.Windows.Forms.ComboBox
    Friend WithEvents comboBoxEquipment As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbLocation As System.Windows.Forms.TextBox
    Friend WithEvents tbBrand As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents buttonSearchPN As System.Windows.Forms.Button
    Friend WithEvents tbMaterialDesc As System.Windows.Forms.TextBox
    Friend WithEvents buttonAddEquipment As System.Windows.Forms.Button
    Friend WithEvents tbPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents dataGridViewEquipment As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttonDeleteEquipment As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents buttonEditMaterial As System.Windows.Forms.Button
    Friend WithEvents dataGridViewMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents daraGridViewAlernative As System.Windows.Forms.DataGridView
    Friend WithEvents groupBoxMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxAlternatif As System.Windows.Forms.GroupBox
    Friend WithEvents Equipment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
