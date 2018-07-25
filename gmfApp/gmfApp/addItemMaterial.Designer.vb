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
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonDeleteEquipment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.buttonEditMaterial = New System.Windows.Forms.Button()
        Me.dataGridViewMaterial = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dataGridViewAlernatif = New System.Windows.Forms.DataGridView()
        Me.groupBoxMaterial = New System.Windows.Forms.GroupBox()
        Me.groupBoxAlternatif = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridViewEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridViewAlernatif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxMaterial.SuspendLayout()
        Me.groupBoxAlternatif.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatus, Me.toolStripAddItem, Me.HistoryToolStripMenuItem, Me.toolStripLogOut})
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
        Me.toolStripAddItem.Size = New System.Drawing.Size(43, 20)
        Me.toolStripAddItem.Text = "Item"
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
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.HistoryToolStripMenuItem.Text = "History"
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
        Me.buttonAddPN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAddPN.Location = New System.Drawing.Point(372, 224)
        Me.buttonAddPN.Name = "buttonAddPN"
        Me.buttonAddPN.Size = New System.Drawing.Size(90, 27)
        Me.buttonAddPN.TabIndex = 24
        Me.buttonAddPN.Text = "Add More"
        Me.buttonAddPN.UseVisualStyleBackColor = True
        '
        'buttonClearPN
        '
        Me.buttonClearPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClearPN.Location = New System.Drawing.Point(388, 376)
        Me.buttonClearPN.Name = "buttonClearPN"
        Me.buttonClearPN.Size = New System.Drawing.Size(77, 27)
        Me.buttonClearPN.TabIndex = 25
        Me.buttonClearPN.Text = "Clear"
        Me.buttonClearPN.UseVisualStyleBackColor = True
        '
        'buttonSave
        '
        Me.buttonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSave.Location = New System.Drawing.Point(484, 376)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(77, 27)
        Me.buttonSave.TabIndex = 26
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'buttonDeleteAlternative
        '
        Me.buttonDeleteAlternative.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonDeleteAlternative.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDeleteAlternative.Location = New System.Drawing.Point(574, 224)
        Me.buttonDeleteAlternative.Name = "buttonDeleteAlternative"
        Me.buttonDeleteAlternative.Size = New System.Drawing.Size(77, 27)
        Me.buttonDeleteAlternative.TabIndex = 31
        Me.buttonDeleteAlternative.Text = "Delete"
        Me.buttonDeleteAlternative.UseVisualStyleBackColor = True
        '
        'buttonEditAlternatif
        '
        Me.buttonEditAlternatif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonEditAlternatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonEditAlternatif.Location = New System.Drawing.Point(478, 224)
        Me.buttonEditAlternatif.Name = "buttonEditAlternatif"
        Me.buttonEditAlternatif.Size = New System.Drawing.Size(77, 27)
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
        Me.comboBoxUM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboBoxUM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboBoxUM.DisplayMember = """ (Inch)"
        Me.comboBoxUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxUM.FormattingEnabled = True
        Me.comboBoxUM.Items.AddRange(New Object() {""" (Inch)", """2 (Square inch)", """3 (Cubic inch)", "% (Percentage)", "%O (Permile)", "000 (Meter/Minute)", "ACR (Acre)", "AU (Activity unit)", "BAG (Bag)", "BLD (Brake Landings)", "BOX (BOX)", "BT (Bottle)", "C3S (Cubic centimeter/second)", "CAN (Canister)", "CAR (Carton)", "CCM (Cubic centimeter)", "CD3 (Cubic decimeter)", "CL (Centiliter)", "CM (Centimeter)", "CM2 (Square centimeter)", "CMS (Centimeter/second)", "CRT (Crate)", "CV (Case)", "CYC (CYCLES)", "D (Days)", "DAY (Days)", "DB (Decibel)", "DEG (Degree)", "DM (Decimeter)", "DR (Drum)", "DZ (Dozen)", "CM2 (Square centimeter)", "CMS (Centimeter/second)", "CRT (Crate)", "CV (Case)", "CYC (CYCLES)", "EA (each)", "EML (Enzyme Units/Milliliter)", "EU (Enzyme Units)", "FOZ (Fluid Ounce US)", "FT (Foot)", "FT2 (Square foot)", "FT3 (Cubic foot)", "G (Gram)", "G/L (gram act.ingrd/liter)", "GAI (Gram act.ingrd.)", "GAL (US gallon)", "GAU (Gram Gold)", "GJ (Gigajoule)", "GLI (Gram/liter)", "GM (Gram/Mol)", "GM2 (Gram/square meter)", "GM3 (Gram/Cubic meter)", "GOH (Gigaohm)", "GPH (Gallons per hour {US})", "GPM (Gallons per mile {US})", "GRO (Gross)", "H (Hour)", "HA (Hectare)", "HL (Hectoliter)", "HR (Hours)", "HRS (Hours)", "IB (Pikofarad)", "JKG (Joule/Kilogram)", "JKK (Spec. Heat Capacity)", "JMO (Joule/Mol)", "KAI (Kilogram act.ingrd.)", "KD3 (Kilogram/cubic decimeter)", "KG (Kilogram)", "KGM (Kilogram/Mol)", "KGS (Kilogram/second)", "KGV (Kilogram/cubic meter)", "KIK (kg act.ingrd./kg)", "KIT (KIT)", "KJK (Kilojoule/kilogram)", "KJM (Kilojoule/Mol)", "KM (Kilometer)", "KM2 (Square kilometer)", "KMH (Kilometer/hour)", "KMN (Kelvin/Minute)", "KMS (Kelvin/Second)", "KPA (Kilopascal)", "KT (Kilotonne)", "KVA (Kilovoltampere)", "L (Liter)", "LB (US pound)", "LDG (LANDINGS)", "LHK (Liter per 100 km)", "LMI (Liter/Minute)", "LMS (Liter/Molsecond)", "LOT (lot)", "LPH (Liter per hour)", "M (Meter)", "M-2 (1/square meter)", "M/H (Meter/Hour)", "M/L (Mol per liter)", "M/M (Mol per cubic meter)", "M/S (Meter/second)", "M2 (Square meter)", "M2S (Square meter/second)", "M3 (Cubic meter)", "M3H (Cubic meter/Hour)", "M3S (Cubic meter/second)", "MEJ (Megajoule)", "MG (Milligram)", "MGL (Milligram/liter)", "MGO (Megohm)", "MGQ (Milligram/cubic meter)", "MHV (Megavolt)", "MI (Mile)", "MI2 (Square mile)", "MIN (Minute)", "MIS (Microsecond)", "ML (Milliliter)", "MLI (Milliliter act.ingr.)", "MM (Millimeter)", "MM2 (Square millimeter)", "MM3 (Cubic millimeter)", "MN (Meganewton)", "MNM (Milli newton/meter)", "MON (Months)", "MPG (Miles per gallon {US})", "MPL (Millimol per liter)", "MPS (Millipascal seconds)", "MS2 (Meter/second squared)", "MSC (Microsiemens per centim)", "MSE (Millisecond)", "MVA (Megavoltampere)", "MWH (Megawatt hour)", "NA (Nanoampere)", "NAM (Nanometer)", "NI (Kilonewton)", "NM (Newton/meter)", "NMM (Newton/Square millimeter)", "NS (Nanosecond)", "OCM (Spec. Elec. Resistance)", "OM (Spec. Elec. Resistance)", "OZ (Ounce)", "P (Points)", "PAA (Pair)", "PAC (Pack)", "PAL (Pallet)", "PAS (Pascal second)", "PL (PAIL)", "PMI (1/minute)", "PMR (Permeation Rate SI)", "PPB (Parts per billion)", "PPM (Parts per million)", "PPT (Parts per trillion)", "PRC (Group proportion)", "PRM (Permeation Rate)", "PRS (Number of Persons)", "PS (Picosecond)", "PT (Pint, US liquid)", "QML (Kilomol)", "QT (Quart, US liquid)", "R-U (Nanofarad)", "RF (Millifarad)", "RHO (Gram/cubic centimeter)", "RIM (rim)", "ROL (Role)", "S/M (Siemens per meter)", "SET (set)", "SH (SHEET)", "ST (items)", "TO (Tonne)", "TOM (Ton/Cubic meter)", "TON (USton)", "TS (Thousands)", "TUB ()", "VAL (Value-only material)", "VAM (Voltampere)", "WK (Weeks)", "WKY (Evaporation Rate)", "WMK (Heat Conductivity)", "YD (Yards)", "YD2 (Square Yard)", "YD3 (Cubic yard)", "YR (Years)", "μA (Microampere)", "μF (Microfarad)", "μGL (Microgram/liter)", "μGQ (Microgram/cubic meter)", "μL (Microliter)", "μM (Micrometer)", "Others"})
        Me.comboBoxUM.Location = New System.Drawing.Point(189, 147)
        Me.comboBoxUM.Name = "comboBoxUM"
        Me.comboBoxUM.Size = New System.Drawing.Size(395, 28)
        Me.comboBoxUM.TabIndex = 19
        Me.comboBoxUM.Text = "Choose One"
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
        Me.Label4.Location = New System.Drawing.Point(12, 272)
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
        Me.tbRemarksMaterial.Location = New System.Drawing.Point(189, 269)
        Me.tbRemarksMaterial.Name = "tbRemarksMaterial"
        Me.tbRemarksMaterial.Size = New System.Drawing.Size(395, 70)
        Me.tbRemarksMaterial.TabIndex = 8
        Me.tbRemarksMaterial.Text = ""
        '
        'comboBoxMaterialType
        '
        Me.comboBoxMaterialType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxMaterialType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboBoxMaterialType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboBoxMaterialType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxMaterialType.FormattingEnabled = True
        Me.comboBoxMaterialType.Items.AddRange(New Object() {"Common Material", "Office Assets ", "Facility Assets ", "Consumable", "Fastener", "Filter", "Fluid / Chemical", "General Spare Parts", "Main Spare Parts", "Tools", "Others"})
        Me.comboBoxMaterialType.Location = New System.Drawing.Point(189, 182)
        Me.comboBoxMaterialType.Name = "comboBoxMaterialType"
        Me.comboBoxMaterialType.Size = New System.Drawing.Size(395, 28)
        Me.comboBoxMaterialType.TabIndex = 10
        Me.comboBoxMaterialType.Text = "Choose One"
        '
        'comboBoxEquipment
        '
        Me.comboBoxEquipment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxEquipment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboBoxEquipment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboBoxEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxEquipment.FormattingEnabled = True
        Me.comboBoxEquipment.Location = New System.Drawing.Point(179, 242)
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
        Me.tbLocation.Location = New System.Drawing.Point(189, 225)
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
        Me.Label10.Location = New System.Drawing.Point(12, 228)
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
        Me.buttonAddEquipment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAddEquipment.Location = New System.Drawing.Point(499, 242)
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
        Me.dataGridViewEquipment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridViewEquipment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
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
        Me.dataGridViewEquipment.Location = New System.Drawing.Point(7, 33)
        Me.dataGridViewEquipment.Name = "dataGridViewEquipment"
        Me.dataGridViewEquipment.Size = New System.Drawing.Size(663, 186)
        Me.dataGridViewEquipment.TabIndex = 26
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
        Me.buttonDeleteEquipment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonDeleteEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDeleteEquipment.Location = New System.Drawing.Point(580, 242)
        Me.buttonDeleteEquipment.Name = "buttonDeleteEquipment"
        Me.buttonDeleteEquipment.Size = New System.Drawing.Size(77, 27)
        Me.buttonDeleteEquipment.TabIndex = 27
        Me.buttonDeleteEquipment.Text = "Delete"
        Me.buttonDeleteEquipment.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(573, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 27)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'buttonEditMaterial
        '
        Me.buttonEditMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonEditMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonEditMaterial.Location = New System.Drawing.Point(477, 156)
        Me.buttonEditMaterial.Name = "buttonEditMaterial"
        Me.buttonEditMaterial.Size = New System.Drawing.Size(77, 27)
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
        Me.dataGridViewMaterial.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dataGridViewMaterial.Location = New System.Drawing.Point(7, 19)
        Me.dataGridViewMaterial.Name = "dataGridViewMaterial"
        Me.dataGridViewMaterial.Size = New System.Drawing.Size(663, 129)
        Me.dataGridViewMaterial.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.buttonClearPN)
        Me.GroupBox2.Controls.Add(Me.tbPartNumber)
        Me.GroupBox2.Controls.Add(Me.buttonSave)
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
        Me.GroupBox2.Controls.Add(Me.tbLocation)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbRemarksMaterial)
        Me.GroupBox2.Controls.Add(Me.comboBoxMaterialType)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 631)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'dataGridViewAlernatif
        '
        Me.dataGridViewAlernatif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewAlernatif.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewAlernatif.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewAlernatif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewAlernatif.Location = New System.Drawing.Point(7, 29)
        Me.dataGridViewAlernatif.Name = "dataGridViewAlernatif"
        Me.dataGridViewAlernatif.Size = New System.Drawing.Size(663, 189)
        Me.dataGridViewAlernatif.TabIndex = 37
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
        Me.groupBoxMaterial.Size = New System.Drawing.Size(679, 193)
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
        Me.groupBoxAlternatif.Controls.Add(Me.buttonAddPN)
        Me.groupBoxAlternatif.Controls.Add(Me.dataGridViewAlernatif)
        Me.groupBoxAlternatif.Controls.Add(Me.buttonDeleteAlternative)
        Me.groupBoxAlternatif.Controls.Add(Me.buttonEditAlternatif)
        Me.groupBoxAlternatif.Location = New System.Drawing.Point(605, 474)
        Me.groupBoxAlternatif.Name = "groupBoxAlternatif"
        Me.groupBoxAlternatif.Size = New System.Drawing.Size(679, 265)
        Me.groupBoxAlternatif.TabIndex = 39
        Me.groupBoxAlternatif.TabStop = False
        Me.groupBoxAlternatif.Text = "Alternative"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.buttonDeleteEquipment)
        Me.GroupBox3.Controls.Add(Me.dataGridViewEquipment)
        Me.GroupBox3.Controls.Add(Me.buttonAddEquipment)
        Me.GroupBox3.Controls.Add(Me.comboBoxEquipment)
        Me.GroupBox3.Location = New System.Drawing.Point(605, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(679, 292)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Equipment"
        '
        'addItemMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.GroupBox3)
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
        CType(Me.dataGridViewAlernatif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxMaterial.ResumeLayout(False)
        Me.groupBoxAlternatif.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
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
    Friend WithEvents dataGridViewAlernatif As System.Windows.Forms.DataGridView
    Friend WithEvents groupBoxMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxAlternatif As System.Windows.Forms.GroupBox
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
