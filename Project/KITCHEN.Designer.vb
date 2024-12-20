<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KITCHEN
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KITCHEN))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FoodsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FoodsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.FoodsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtquantity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DELETE = New System.Windows.Forms.TabPage()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtDelFood_Id = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txtFoodCode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtFoodQuantity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtFoodNAme = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtunitPrice = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BestFoodsDataSet = New BestFoods.BestFoodsDataSet()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodsTableAdapter = New BestFoods.BestFoodsDataSetTableAdapters.FoodsTableAdapter()
        Me.TableAdapterManager = New BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FoodIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.FoodsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FoodsBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.FoodsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DELETE.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BestFoodsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 35
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.BunifuTransition1.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0.0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0.0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0.0!
        Animation4.RotateLimit = 0.0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0.0!
        Animation4.TransparencyCoeff = 1.0!
        Me.BunifuTransition1.DefaultAnimation = Animation4
        Me.BunifuTransition1.Interval = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1005, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "X"
        '
        'FoodsBindingNavigator
        '
        Me.FoodsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FoodsBindingNavigator.BindingSource = Me.FoodsBindingSource
        Me.FoodsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BunifuTransition1.SetDecoration(Me.FoodsBindingNavigator, BunifuAnimatorNS.DecorationType.None)
        Me.FoodsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FoodsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FoodsBindingNavigatorSaveItem})
        Me.FoodsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FoodsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FoodsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FoodsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FoodsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FoodsBindingNavigator.Name = "FoodsBindingNavigator"
        Me.FoodsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FoodsBindingNavigator.Size = New System.Drawing.Size(713, 25)
        Me.FoodsBindingNavigator.TabIndex = 5
        Me.FoodsBindingNavigator.Text = "BindingNavigator1"
        Me.FoodsBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FoodsBindingNavigatorSaveItem
        '
        Me.FoodsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FoodsBindingNavigatorSaveItem.Image = CType(resources.GetObject("FoodsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FoodsBindingNavigatorSaveItem.Name = "FoodsBindingNavigatorSaveItem"
        Me.FoodsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FoodsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.DELETE)
        Me.BunifuTransition1.SetDecoration(Me.TabControl1, BunifuAnimatorNS.DecorationType.None)
        Me.TabControl1.Location = New System.Drawing.Point(12, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1004, 433)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.txtunitPrice)
        Me.TabPage1.Controls.Add(Me.txtFoodNAme)
        Me.TabPage1.Controls.Add(Me.txtFoodQuantity)
        Me.TabPage1.Controls.Add(Me.txtFoodCode)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.FoodsDataGridView)
        Me.BunifuTransition1.SetDecoration(Me.TabPage1, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(996, 407)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ADD NEW"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Footlight MT Light", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(389, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 34)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "FOOD DATA "
        '
        'btnAdd
        '
        Me.btnAdd.ActiveBorderThickness = 1
        Me.btnAdd.ActiveCornerRadius = 20
        Me.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.ActiveForecolor = System.Drawing.Color.White
        Me.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.BackColor = System.Drawing.Color.LightGray
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.ButtonText = "ADD"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnAdd, BunifuAnimatorNS.DecorationType.None)
        Me.btnAdd.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.IdleBorderThickness = 1
        Me.btnAdd.IdleCornerRadius = 20
        Me.btnAdd.IdleFillColor = System.Drawing.Color.Lime
        Me.btnAdd.IdleForecolor = System.Drawing.Color.Black
        Me.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.Location = New System.Drawing.Point(353, 303)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(370, 39)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FoodsDataGridView
        '
        Me.FoodsDataGridView.AutoGenerateColumns = False
        Me.FoodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FoodsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.FoodsDataGridView.DataSource = Me.FoodsBindingSource
        Me.BunifuTransition1.SetDecoration(Me.FoodsDataGridView, BunifuAnimatorNS.DecorationType.None)
        Me.FoodsDataGridView.Location = New System.Drawing.Point(418, 312)
        Me.FoodsDataGridView.Name = "FoodsDataGridView"
        Me.FoodsDataGridView.Size = New System.Drawing.Size(47, 30)
        Me.FoodsDataGridView.TabIndex = 15
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.txtquantity)
        Me.TabPage2.Controls.Add(Me.txtcode)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnUpdate)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.BunifuTransition1.SetDecoration(Me.TabPage2, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(996, 407)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "UPDATE"
        '
        'txtquantity
        '
        Me.txtquantity.BackColor = System.Drawing.Color.White
        Me.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtquantity, BunifuAnimatorNS.DecorationType.None)
        Me.txtquantity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtquantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtquantity.HintForeColor = System.Drawing.Color.Empty
        Me.txtquantity.HintText = ""
        Me.txtquantity.isPassword = False
        Me.txtquantity.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtquantity.LineIdleColor = System.Drawing.Color.Black
        Me.txtquantity.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtquantity.LineThickness = 1
        Me.txtquantity.Location = New System.Drawing.Point(204, 222)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(506, 33)
        Me.txtquantity.TabIndex = 13
        Me.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.Color.White
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtcode, BunifuAnimatorNS.DecorationType.None)
        Me.txtcode.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcode.HintForeColor = System.Drawing.Color.Empty
        Me.txtcode.HintText = ""
        Me.txtcode.isPassword = False
        Me.txtcode.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtcode.LineIdleColor = System.Drawing.Color.Black
        Me.txtcode.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txtcode.LineThickness = 1
        Me.txtcode.Location = New System.Drawing.Point(204, 112)
        Me.txtcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(506, 33)
        Me.txtcode.TabIndex = 14
        Me.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(418, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "QUANTITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Footlight MT Light", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 34)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "UPDATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(410, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "FOOD CODE"
        '
        'btnUpdate
        '
        Me.btnUpdate.ActiveBorderThickness = 1
        Me.btnUpdate.ActiveCornerRadius = 20
        Me.btnUpdate.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.ActiveForecolor = System.Drawing.Color.White
        Me.btnUpdate.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.BackColor = System.Drawing.Color.LightGray
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.ButtonText = "UPDATE"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnUpdate, BunifuAnimatorNS.DecorationType.None)
        Me.btnUpdate.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.IdleBorderThickness = 1
        Me.btnUpdate.IdleCornerRadius = 20
        Me.btnUpdate.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.IdleForecolor = System.Drawing.Color.Black
        Me.btnUpdate.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.Location = New System.Drawing.Point(332, 327)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(309, 39)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.DataSource = Me.FoodsBindingSource
        Me.BunifuTransition1.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView1.Location = New System.Drawing.Point(428, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(47, 30)
        Me.DataGridView1.TabIndex = 15
        '
        'DELETE
        '
        Me.DELETE.BackColor = System.Drawing.Color.LightGray
        Me.DELETE.Controls.Add(Me.btnDelete)
        Me.DELETE.Controls.Add(Me.txtDelFood_Id)
        Me.DELETE.Controls.Add(Me.DataGridView2)
        Me.BunifuTransition1.SetDecoration(Me.DELETE, BunifuAnimatorNS.DecorationType.None)
        Me.DELETE.Location = New System.Drawing.Point(4, 22)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Padding = New System.Windows.Forms.Padding(3)
        Me.DELETE.Size = New System.Drawing.Size(996, 407)
        Me.DELETE.TabIndex = 2
        Me.DELETE.Text = "DELETE"
        '
        'btnDelete
        '
        Me.btnDelete.ActiveBorderThickness = 1
        Me.btnDelete.ActiveCornerRadius = 20
        Me.btnDelete.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.ActiveForecolor = System.Drawing.Color.White
        Me.btnDelete.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.BackColor = System.Drawing.Color.LightGray
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.ButtonText = "Delete"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnDelete, BunifuAnimatorNS.DecorationType.None)
        Me.btnDelete.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.IdleBorderThickness = 1
        Me.btnDelete.IdleCornerRadius = 20
        Me.btnDelete.IdleFillColor = System.Drawing.Color.Red
        Me.btnDelete.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.Location = New System.Drawing.Point(623, 123)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(311, 39)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDelFood_Id
        '
        Me.txtDelFood_Id.BackColor = System.Drawing.Color.White
        Me.txtDelFood_Id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtDelFood_Id, BunifuAnimatorNS.DecorationType.None)
        Me.txtDelFood_Id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDelFood_Id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDelFood_Id.HintForeColor = System.Drawing.Color.Gray
        Me.txtDelFood_Id.HintText = "Delete Food Id"
        Me.txtDelFood_Id.isPassword = False
        Me.txtDelFood_Id.LineFocusedColor = System.Drawing.Color.Lime
        Me.txtDelFood_Id.LineIdleColor = System.Drawing.Color.Black
        Me.txtDelFood_Id.LineMouseHoverColor = System.Drawing.Color.Red
        Me.txtDelFood_Id.LineThickness = 1
        Me.txtDelFood_Id.Location = New System.Drawing.Point(562, 55)
        Me.txtDelFood_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDelFood_Id.Name = "txtDelFood_Id"
        Me.txtDelFood_Id.Size = New System.Drawing.Size(413, 33)
        Me.txtDelFood_Id.TabIndex = 1
        Me.txtDelFood_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dim kITCHEN As KITCHEN = Me
        kITCHEN.DataGridView2.Columns.AddRange((New System.Windows.Forms.DataGridViewColumn() {Me.FoodIdDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn}))
        Me.DataGridView2.DataSource = Me.FoodsBindingSource
        Me.BunifuTransition1.SetDecoration(Me.DataGridView2, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(447, 395)
        Me.DataGridView2.TabIndex = 0
        '
        'txtFoodCode
        '
        Me.txtFoodCode.BackColor = System.Drawing.Color.White
        Me.txtFoodCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtFoodCode, BunifuAnimatorNS.DecorationType.None)
        Me.txtFoodCode.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFoodCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFoodCode.HintForeColor = System.Drawing.Color.Gray
        Me.txtFoodCode.HintText = "Food Id"
        Me.txtFoodCode.isPassword = False
        Me.txtFoodCode.LineFocusedColor = System.Drawing.Color.Lime
        Me.txtFoodCode.LineIdleColor = System.Drawing.Color.Black
        Me.txtFoodCode.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke
        Me.txtFoodCode.LineThickness = 1
        Me.txtFoodCode.Location = New System.Drawing.Point(193, 91)
        Me.txtFoodCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFoodCode.Name = "txtFoodCode"
        Me.txtFoodCode.Size = New System.Drawing.Size(284, 33)
        Me.txtFoodCode.TabIndex = 16
        Me.txtFoodCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtFoodQuantity
        '
        Me.txtFoodQuantity.BackColor = System.Drawing.Color.White
        Me.txtFoodQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtFoodQuantity, BunifuAnimatorNS.DecorationType.None)
        Me.txtFoodQuantity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFoodQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFoodQuantity.HintForeColor = System.Drawing.Color.Gray
        Me.txtFoodQuantity.HintText = "Food Quantity"
        Me.txtFoodQuantity.isPassword = False
        Me.txtFoodQuantity.LineFocusedColor = System.Drawing.Color.Lime
        Me.txtFoodQuantity.LineIdleColor = System.Drawing.Color.Black
        Me.txtFoodQuantity.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke
        Me.txtFoodQuantity.LineThickness = 1
        Me.txtFoodQuantity.Location = New System.Drawing.Point(567, 91)
        Me.txtFoodQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFoodQuantity.Name = "txtFoodQuantity"
        Me.txtFoodQuantity.Size = New System.Drawing.Size(294, 33)
        Me.txtFoodQuantity.TabIndex = 16
        Me.txtFoodQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtFoodNAme
        '
        Me.txtFoodNAme.BackColor = System.Drawing.Color.White
        Me.txtFoodNAme.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtFoodNAme, BunifuAnimatorNS.DecorationType.None)
        Me.txtFoodNAme.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFoodNAme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFoodNAme.HintForeColor = System.Drawing.Color.Gray
        Me.txtFoodNAme.HintText = "Food Name"
        Me.txtFoodNAme.isPassword = False
        Me.txtFoodNAme.LineFocusedColor = System.Drawing.Color.Lime
        Me.txtFoodNAme.LineIdleColor = System.Drawing.Color.Black
        Me.txtFoodNAme.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke
        Me.txtFoodNAme.LineThickness = 1
        Me.txtFoodNAme.Location = New System.Drawing.Point(193, 214)
        Me.txtFoodNAme.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFoodNAme.Name = "txtFoodNAme"
        Me.txtFoodNAme.Size = New System.Drawing.Size(284, 33)
        Me.txtFoodNAme.TabIndex = 16
        Me.txtFoodNAme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtunitPrice
        '
        Me.txtunitPrice.BackColor = System.Drawing.Color.White
        Me.txtunitPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtunitPrice, BunifuAnimatorNS.DecorationType.None)
        Me.txtunitPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtunitPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtunitPrice.HintForeColor = System.Drawing.Color.Gray
        Me.txtunitPrice.HintText = "Unit Price"
        Me.txtunitPrice.isPassword = False
        Me.txtunitPrice.LineFocusedColor = System.Drawing.Color.Lime
        Me.txtunitPrice.LineIdleColor = System.Drawing.Color.Black
        Me.txtunitPrice.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke
        Me.txtunitPrice.LineThickness = 1
        Me.txtunitPrice.Location = New System.Drawing.Point(567, 214)
        Me.txtunitPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtunitPrice.Name = "txtunitPrice"
        Me.txtunitPrice.Size = New System.Drawing.Size(294, 33)
        Me.txtunitPrice.TabIndex = 16
        Me.txtunitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Food_Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Food_Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Food_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Food_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Unit_Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unit_Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Food_Id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Food_Id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Food_Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Food_Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Unit_Price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unit_Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'FoodsTableAdapter
        '
        Me.FoodsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminsTableAdapter = Nothing
        Me.TableAdapterManager.Attendent_OrdersTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashiersTableAdapter = Nothing
        Me.TableAdapterManager.Daily_EarningsTableAdapter = Nothing
        Me.TableAdapterManager.FoodsTableAdapter = Me.FoodsTableAdapter
        Me.TableAdapterManager.Kitchen_StaffTableAdapter = Nothing
        Me.TableAdapterManager.Pending_OrdersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WaitersTableAdapter = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 34)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BEST FOODS KITCHEN DEPARTMENT"
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
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 50
        Me.BunifuElipse2.TargetControl = Me
        '
        'KITCHEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.FoodsBindingNavigator)
        Me.Controls.Add(Me.Label4)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KITCHEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KITCHEN"
        CType(Me.FoodsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FoodsBindingNavigator.ResumeLayout(False)
        Me.FoodsBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.FoodsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DELETE.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BestFoodsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FoodsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FoodsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BestFoodsDataSet As BestFoods.BestFoodsDataSet
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FoodsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FoodsTableAdapter As BestFoods.BestFoodsDataSetTableAdapters.FoodsTableAdapter
    Friend WithEvents TableAdapterManager As BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents FoodsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtquantity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DELETE As System.Windows.Forms.TabPage
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtDelFood_Id As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtunitPrice As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtFoodNAme As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtFoodQuantity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtFoodCode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FoodIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
End Class
