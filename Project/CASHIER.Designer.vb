<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CASHIER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CASHIER))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FoodIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BestFoodsDataSet = New BestFoods.BestFoodsDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFoodCode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtFoodQuantity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtTotalAmount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtAmountpaid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPhoneNumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtMpesaCode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtTotalAmountPaid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FoodcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PricePerQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendingorders2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bestfoods2DataSet = New BestFoods.bestfoods2DataSet()
        Me.Pending_OrdersTableAdapter = New BestFoods.BestFoodsDataSetTableAdapters.Pending_OrdersTableAdapter()
        Me.FoodsTableAdapter = New BestFoods.BestFoodsDataSetTableAdapters.FoodsTableAdapter()
        Me.Pendingorders2TableAdapter = New BestFoods.bestfoods2DataSetTableAdapters.pendingorders2TableAdapter()
        Me.TableAdapterManager1 = New BestFoods.bestfoods2DataSetTableAdapters.TableAdapterManager()
        Me.TransactionsTableAdapter = New BestFoods.BestFoodsDataSetTableAdapters.TransactionsTableAdapter()
        Me.TransactionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrint = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.rtbreceipt = New System.Windows.Forms.RichTextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.TableAdapterManager = New BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager()
        Me.Food_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Food_IdToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Food_IdToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Pending_OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BestFoodsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pendingorders2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bestfoods2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.Pending_OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1146, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "X"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodIdDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FoodsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(749, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 628)
        Me.DataGridView1.TabIndex = 8
        '
        'FoodIdDataGridViewTextBoxColumn
        '
        Me.FoodIdDataGridViewTextBoxColumn.DataPropertyName = "Food_Id"
        Me.FoodIdDataGridViewTextBoxColumn.HeaderText = "Food_Id"
        Me.FoodIdDataGridViewTextBoxColumn.Name = "FoodIdDataGridViewTextBoxColumn"
        '
        'FoodNameDataGridViewTextBoxColumn
        '
        Me.FoodNameDataGridViewTextBoxColumn.DataPropertyName = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn.HeaderText = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn.Name = "FoodNameDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'FoodsBindingSource
        '
        Me.FoodsBindingSource.DataMember = "Foods"
        Me.FoodsBindingSource.DataSource = Me.BestFoodsDataSet
        '
        'BestFoodsDataSet
        '
        Me.BestFoodsDataSet.DataSetName = "BestFoodsDataSet"
        Me.BestFoodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Location = New System.Drawing.Point(931, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Available Foods"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(31, 546)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CASH"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(26, 628)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "MPESA"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtdate)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1169, 66)
        Me.Panel1.TabIndex = 12
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(82, 43)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(218, 20)
        Me.txtdate.TabIndex = 68
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 60)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(445, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 22)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "CASHIER'S DESK"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Footlight MT Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(283, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(506, 34)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "BEST FOODS RESTAURANT AND SPA "
        '
        'txtFoodCode
        '
        Me.txtFoodCode.BackColor = System.Drawing.Color.White
        Me.txtFoodCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFoodCode.Font = New System.Drawing.Font("Footlight MT Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFoodCode.HintForeColor = System.Drawing.Color.Silver
        Me.txtFoodCode.HintText = "FOOD CODE"
        Me.txtFoodCode.isPassword = False
        Me.txtFoodCode.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtFoodCode.LineIdleColor = System.Drawing.Color.Black
        Me.txtFoodCode.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtFoodCode.LineThickness = 1
        Me.txtFoodCode.Location = New System.Drawing.Point(31, 100)
        Me.txtFoodCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFoodCode.Name = "txtFoodCode"
        Me.txtFoodCode.Size = New System.Drawing.Size(282, 29)
        Me.txtFoodCode.TabIndex = 62
        Me.txtFoodCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtFoodQuantity
        '
        Me.txtFoodQuantity.BackColor = System.Drawing.Color.White
        Me.txtFoodQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFoodQuantity.Font = New System.Drawing.Font("Footlight MT Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFoodQuantity.HintForeColor = System.Drawing.Color.Silver
        Me.txtFoodQuantity.HintText = "FOOD QUANTITY"
        Me.txtFoodQuantity.isPassword = False
        Me.txtFoodQuantity.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtFoodQuantity.LineIdleColor = System.Drawing.Color.Black
        Me.txtFoodQuantity.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtFoodQuantity.LineThickness = 1
        Me.txtFoodQuantity.Location = New System.Drawing.Point(345, 100)
        Me.txtFoodQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFoodQuantity.Name = "txtFoodQuantity"
        Me.txtFoodQuantity.Size = New System.Drawing.Size(231, 29)
        Me.txtFoodQuantity.TabIndex = 62
        Me.txtFoodQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Footlight MT Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalAmount.HintForeColor = System.Drawing.Color.Silver
        Me.txtTotalAmount.HintText = "TOTAL AMOUNT"
        Me.txtTotalAmount.isPassword = False
        Me.txtTotalAmount.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtTotalAmount.LineIdleColor = System.Drawing.Color.Black
        Me.txtTotalAmount.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtTotalAmount.LineThickness = 1
        Me.txtTotalAmount.Location = New System.Drawing.Point(31, 497)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(159, 29)
        Me.txtTotalAmount.TabIndex = 62
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtAmountpaid
        '
        Me.txtAmountpaid.BackColor = System.Drawing.Color.White
        Me.txtAmountpaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmountpaid.Enabled = False
        Me.txtAmountpaid.Font = New System.Drawing.Font("Footlight MT Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountpaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmountpaid.HintForeColor = System.Drawing.Color.Silver
        Me.txtAmountpaid.HintText = "AMOUNT PAID"
        Me.txtAmountpaid.isPassword = False
        Me.txtAmountpaid.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtAmountpaid.LineIdleColor = System.Drawing.Color.Black
        Me.txtAmountpaid.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtAmountpaid.LineThickness = 1
        Me.txtAmountpaid.Location = New System.Drawing.Point(31, 583)
        Me.txtAmountpaid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountpaid.Name = "txtAmountpaid"
        Me.txtAmountpaid.Size = New System.Drawing.Size(159, 29)
        Me.txtAmountpaid.TabIndex = 62
        Me.txtAmountpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.Color.White
        Me.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNumber.Enabled = False
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Footlight MT Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPhoneNumber.HintForeColor = System.Drawing.Color.Silver
        Me.txtPhoneNumber.HintText = "PHONE NUMBER"
        Me.txtPhoneNumber.isPassword = False
        Me.txtPhoneNumber.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtPhoneNumber.LineIdleColor = System.Drawing.Color.Black
        Me.txtPhoneNumber.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtPhoneNumber.LineThickness = 1
        Me.txtPhoneNumber.Location = New System.Drawing.Point(31, 663)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(159, 29)
        Me.txtPhoneNumber.TabIndex = 62
        Me.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtMpesaCode
        '
        Me.txtMpesaCode.BackColor = System.Drawing.Color.White
        Me.txtMpesaCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMpesaCode.Enabled = False
        Me.txtMpesaCode.Font = New System.Drawing.Font("Footlight MT Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMpesaCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMpesaCode.HintForeColor = System.Drawing.Color.Silver
        Me.txtMpesaCode.HintText = "MPESA CODE"
        Me.txtMpesaCode.isPassword = False
        Me.txtMpesaCode.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtMpesaCode.LineIdleColor = System.Drawing.Color.Black
        Me.txtMpesaCode.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtMpesaCode.LineThickness = 1
        Me.txtMpesaCode.Location = New System.Drawing.Point(260, 663)
        Me.txtMpesaCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMpesaCode.Name = "txtMpesaCode"
        Me.txtMpesaCode.Size = New System.Drawing.Size(159, 29)
        Me.txtMpesaCode.TabIndex = 62
        Me.txtMpesaCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTotalAmountPaid
        '
        Me.txtTotalAmountPaid.BackColor = System.Drawing.Color.White
        Me.txtTotalAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalAmountPaid.Enabled = False
        Me.txtTotalAmountPaid.Font = New System.Drawing.Font("Footlight MT Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmountPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalAmountPaid.HintForeColor = System.Drawing.Color.Silver
        Me.txtTotalAmountPaid.HintText = "TOTAL AMOUNT PAID"
        Me.txtTotalAmountPaid.isPassword = False
        Me.txtTotalAmountPaid.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtTotalAmountPaid.LineIdleColor = System.Drawing.Color.Black
        Me.txtTotalAmountPaid.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtTotalAmountPaid.LineThickness = 1
        Me.txtTotalAmountPaid.Location = New System.Drawing.Point(493, 663)
        Me.txtTotalAmountPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmountPaid.Name = "txtTotalAmountPaid"
        Me.txtTotalAmountPaid.Size = New System.Drawing.Size(159, 29)
        Me.txtTotalAmountPaid.TabIndex = 62
        Me.txtTotalAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodcodeDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn1, Me.FoodQuantityDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn1, Me.PricePerQuantityDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.Pendingorders2BindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(59, 178)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(545, 312)
        Me.DataGridView2.TabIndex = 67
        '
        'FoodcodeDataGridViewTextBoxColumn
        '
        Me.FoodcodeDataGridViewTextBoxColumn.DataPropertyName = "Food_code"
        Me.FoodcodeDataGridViewTextBoxColumn.HeaderText = "Food_code"
        Me.FoodcodeDataGridViewTextBoxColumn.Name = "FoodcodeDataGridViewTextBoxColumn"
        '
        'FoodNameDataGridViewTextBoxColumn1
        '
        Me.FoodNameDataGridViewTextBoxColumn1.DataPropertyName = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn1.HeaderText = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn1.Name = "FoodNameDataGridViewTextBoxColumn1"
        '
        'FoodQuantityDataGridViewTextBoxColumn
        '
        Me.FoodQuantityDataGridViewTextBoxColumn.DataPropertyName = "Food_Quantity"
        Me.FoodQuantityDataGridViewTextBoxColumn.HeaderText = "Food_Quantity"
        Me.FoodQuantityDataGridViewTextBoxColumn.Name = "FoodQuantityDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn1
        '
        Me.UnitPriceDataGridViewTextBoxColumn1.DataPropertyName = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn1.HeaderText = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn1.Name = "UnitPriceDataGridViewTextBoxColumn1"
        '
        'PricePerQuantityDataGridViewTextBoxColumn
        '
        Me.PricePerQuantityDataGridViewTextBoxColumn.DataPropertyName = "Price_Per_Quantity"
        Me.PricePerQuantityDataGridViewTextBoxColumn.HeaderText = "Price_Per_Quantity"
        Me.PricePerQuantityDataGridViewTextBoxColumn.Name = "PricePerQuantityDataGridViewTextBoxColumn"
        '
        'Pendingorders2BindingSource
        '
        Me.Pendingorders2BindingSource.DataMember = "pendingorders2"
        Me.Pendingorders2BindingSource.DataSource = Me.Bestfoods2DataSet
        '
        'Bestfoods2DataSet
        '
        Me.Bestfoods2DataSet.DataSetName = "bestfoods2DataSet"
        Me.Bestfoods2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pending_OrdersTableAdapter
        '
        Me.Pending_OrdersTableAdapter.ClearBeforeFill = True
        '
        'FoodsTableAdapter
        '
        Me.FoodsTableAdapter.ClearBeforeFill = True
        '
        'Pendingorders2TableAdapter
        '
        Me.Pendingorders2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.pendingorders2TableAdapter = Me.Pendingorders2TableAdapter
        Me.TableAdapterManager1.UpdateOrder = BestFoods.bestfoods2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'TransactionsDataGridView
        '
        Me.TransactionsDataGridView.AutoGenerateColumns = False
        Me.TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TransactionsDataGridView.DataSource = Me.TransactionsBindingSource
        Me.TransactionsDataGridView.Location = New System.Drawing.Point(692, 144)
        Me.TransactionsDataGridView.Name = "TransactionsDataGridView"
        Me.TransactionsDataGridView.Size = New System.Drawing.Size(24, 31)
        Me.TransactionsDataGridView.TabIndex = 67
        Me.TransactionsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Receipt_Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Receipt_Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.BestFoodsDataSet
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.BestFoods.My.Resources.Resources.icons8_cheap_2_64px
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(539, 496)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 51)
        Me.Button2.TabIndex = 64
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.BestFoods.My.Resources.Resources.icons8_shopping_cart_48px
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(641, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 37)
        Me.Button1.TabIndex = 63
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.ActiveBorderThickness = 1
        Me.btnPrint.ActiveCornerRadius = 20
        Me.btnPrint.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnPrint.ActiveForecolor = System.Drawing.Color.White
        Me.btnPrint.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.ButtonText = "PRINT"
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnPrint.IdleBorderThickness = 1
        Me.btnPrint.IdleCornerRadius = 20
        Me.btnPrint.IdleFillColor = System.Drawing.Color.Black
        Me.btnPrint.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnPrint.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnPrint.Location = New System.Drawing.Point(514, 573)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(189, 39)
        Me.btnPrint.TabIndex = 68
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDocument1
        '
        '
        'rtbreceipt
        '
        Me.rtbreceipt.Font = New System.Drawing.Font("Footlight MT Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbreceipt.Location = New System.Drawing.Point(752, 102)
        Me.rtbreceipt.Margin = New System.Windows.Forms.Padding(5)
        Me.rtbreceipt.Name = "rtbreceipt"
        Me.rtbreceipt.Size = New System.Drawing.Size(404, 619)
        Me.rtbreceipt.TabIndex = 70
        Me.rtbreceipt.Text = resources.GetString("rtbreceipt.Text")
        Me.rtbreceipt.Visible = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminsTableAdapter = Nothing
        Me.TableAdapterManager.Attendent_OrdersTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashiersTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Daily_EarningsTableAdapter = Nothing
        Me.TableAdapterManager.FoodsTableAdapter = Nothing
        Me.TableAdapterManager.Kitchen_StaffTableAdapter = Nothing
        Me.TableAdapterManager.Pending_OrdersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WaitersTableAdapter = Nothing
        '
        'Food_NameTextBox
        '
        Me.Food_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodsBindingSource, "Food_Name", True))
        Me.Food_NameTextBox.Location = New System.Drawing.Point(767, 306)
        Me.Food_NameTextBox.Name = "Food_NameTextBox"
        Me.Food_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Food_NameTextBox.TabIndex = 73
        '
        'Unit_PriceTextBox
        '
        Me.Unit_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodsBindingSource, "Unit_Price", True))
        Me.Unit_PriceTextBox.Location = New System.Drawing.Point(767, 358)
        Me.Unit_PriceTextBox.Name = "Unit_PriceTextBox"
        Me.Unit_PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_PriceTextBox.TabIndex = 77
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Food_IdToolStripLabel, Me.Food_IdToolStripTextBox, Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(1213, 25)
        Me.FillBy1ToolStrip.TabIndex = 78
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Visible = False
        '
        'Food_IdToolStripLabel
        '
        Me.Food_IdToolStripLabel.Name = "Food_IdToolStripLabel"
        Me.Food_IdToolStripLabel.Size = New System.Drawing.Size(52, 22)
        Me.Food_IdToolStripLabel.Text = "Food_Id:"
        '
        'Food_IdToolStripTextBox
        '
        Me.Food_IdToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Food_IdToolStripTextBox.Name = "Food_IdToolStripTextBox"
        Me.Food_IdToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'Pending_OrdersBindingSource
        '
        Me.Pending_OrdersBindingSource.DataMember = "Pending_Orders"
        Me.Pending_OrdersBindingSource.DataSource = Me.BestFoodsDataSet
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(770, 280)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 79
        '
        'CASHIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1213, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTotalAmountPaid)
        Me.Controls.Add(Me.txtMpesaCode)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtAmountpaid)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.txtFoodQuantity)
        Me.Controls.Add(Me.txtFoodCode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TransactionsDataGridView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.rtbreceipt)
        Me.Controls.Add(Me.Food_NameTextBox)
        Me.Controls.Add(Me.Unit_PriceTextBox)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CASHIER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CASHIER"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BestFoodsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pendingorders2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bestfoods2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        CType(Me.Pending_OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFoodCode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtFoodQuantity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtTotalAmount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtAmountpaid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPhoneNumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtMpesaCode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtTotalAmountPaid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BestFoodsDataSet As BestFoods.BestFoodsDataSet
    Friend WithEvents Pending_OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pending_OrdersTableAdapter As BestFoods.BestFoodsDataSetTableAdapters.Pending_OrdersTableAdapter
    Friend WithEvents TableAdapterManager As BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FoodsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FoodsTableAdapter As BestFoods.BestFoodsDataSetTableAdapters.FoodsTableAdapter
    Friend WithEvents FoodIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Bestfoods2DataSet As BestFoods.bestfoods2DataSet
    Friend WithEvents Pendingorders2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pendingorders2TableAdapter As BestFoods.bestfoods2DataSetTableAdapters.pendingorders2TableAdapter
    Friend WithEvents TableAdapterManager1 As BestFoods.bestfoods2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As BestFoods.BestFoodsDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TransactionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PricePerQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents rtbreceipt As System.Windows.Forms.RichTextBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents FillBy1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Food_IdToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Food_IdToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Food_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
End Class
