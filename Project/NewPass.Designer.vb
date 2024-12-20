<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewPass))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtConfirmNewPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNewPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNationalId = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BestFoodsDataSet = New BestFoods.BestFoodsDataSet()
        Me.AdminsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminsTableAdapter = New BestFoods.BestFoodsDataSetTableAdapters.AdminsTableAdapter()
        Me.TableAdapterManager = New BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager()
        Me.CashiersTableAdapter = New BestFoods.BestFoodsDataSetTableAdapters.CashiersTableAdapter()
        Me.Kitchen_StaffTableAdapter = New BestFoods.BestFoodsDataSetTableAdapters.Kitchen_StaffTableAdapter()
        Me.WaitersTableAdapter = New BestFoods.BestFoodsDataSetTableAdapters.WaitersTableAdapter()
        Me.AdminsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AdminsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AdminsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kitchen_StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kitchen_StaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WaitersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashiersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CashiersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BestFoodsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminsBindingNavigator.SuspendLayout()
        CType(Me.AdminsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kitchen_StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kitchen_StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaitersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaitersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashiersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashiersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(417, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "X"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 35
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtConfirmNewPassword
        '
        Me.txtConfirmNewPassword.BackColor = System.Drawing.Color.White
        Me.txtConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmNewPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtConfirmNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtConfirmNewPassword.HintForeColor = System.Drawing.Color.Gray
        Me.txtConfirmNewPassword.HintText = "Confirm New password"
        Me.txtConfirmNewPassword.isPassword = False
        Me.txtConfirmNewPassword.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtConfirmNewPassword.LineIdleColor = System.Drawing.Color.Black
        Me.txtConfirmNewPassword.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtConfirmNewPassword.LineThickness = 1
        Me.txtConfirmNewPassword.Location = New System.Drawing.Point(39, 173)
        Me.txtConfirmNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        Me.txtConfirmNewPassword.Size = New System.Drawing.Size(379, 33)
        Me.txtConfirmNewPassword.TabIndex = 5
        Me.txtConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.White
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNewPassword.HintForeColor = System.Drawing.Color.Gray
        Me.txtNewPassword.HintText = " New password"
        Me.txtNewPassword.isPassword = False
        Me.txtNewPassword.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtNewPassword.LineIdleColor = System.Drawing.Color.Black
        Me.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtNewPassword.LineThickness = 1
        Me.txtNewPassword.Location = New System.Drawing.Point(39, 110)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(379, 33)
        Me.txtNewPassword.TabIndex = 5
        Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNationalId
        '
        Me.txtNationalId.BackColor = System.Drawing.Color.White
        Me.txtNationalId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNationalId.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNationalId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNationalId.HintForeColor = System.Drawing.Color.Gray
        Me.txtNationalId.HintText = "National Id"
        Me.txtNationalId.isPassword = False
        Me.txtNationalId.LineFocusedColor = System.Drawing.Color.Aqua
        Me.txtNationalId.LineIdleColor = System.Drawing.Color.Black
        Me.txtNationalId.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtNationalId.LineThickness = 1
        Me.txtNationalId.Location = New System.Drawing.Point(39, 47)
        Me.txtNationalId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNationalId.Name = "txtNationalId"
        Me.txtNationalId.Size = New System.Drawing.Size(379, 33)
        Me.txtNationalId.TabIndex = 5
        Me.txtNationalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "WELCOME,LETS RESET YOUR PASSWORD"
        '
        'btnSubmit
        '
        Me.btnSubmit.ActiveBorderThickness = 1
        Me.btnSubmit.ActiveCornerRadius = 20
        Me.btnSubmit.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.ActiveForecolor = System.Drawing.Color.White
        Me.btnSubmit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubmit.BackgroundImage = CType(resources.GetObject("btnSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmit.ButtonText = "SUBMIT"
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.IdleBorderThickness = 1
        Me.btnSubmit.IdleCornerRadius = 20
        Me.btnSubmit.IdleFillColor = System.Drawing.Color.Lime
        Me.btnSubmit.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.Location = New System.Drawing.Point(39, 227)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(379, 39)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BestFoodsDataSet
        '
        Me.BestFoodsDataSet.DataSetName = "BestFoodsDataSet"
        Me.BestFoodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminsBindingSource
        '
        Me.AdminsBindingSource.DataMember = "Admins"
        Me.AdminsBindingSource.DataSource = Me.BestFoodsDataSet
        '
        'AdminsTableAdapter
        '
        Me.AdminsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminsTableAdapter = Me.AdminsTableAdapter
        Me.TableAdapterManager.Attendent_OrdersTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashiersTableAdapter = Me.CashiersTableAdapter
        Me.TableAdapterManager.Daily_EarningsTableAdapter = Nothing
        Me.TableAdapterManager.FoodsTableAdapter = Nothing
        Me.TableAdapterManager.Kitchen_StaffTableAdapter = Me.Kitchen_StaffTableAdapter
        Me.TableAdapterManager.Pending_OrdersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WaitersTableAdapter = Me.WaitersTableAdapter
        '
        'CashiersTableAdapter
        '
        Me.CashiersTableAdapter.ClearBeforeFill = True
        '
        'Kitchen_StaffTableAdapter
        '
        Me.Kitchen_StaffTableAdapter.ClearBeforeFill = True
        '
        'WaitersTableAdapter
        '
        Me.WaitersTableAdapter.ClearBeforeFill = True
        '
        'AdminsBindingNavigator
        '
        Me.AdminsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdminsBindingNavigator.BindingSource = Me.AdminsBindingSource
        Me.AdminsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdminsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdminsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdminsBindingNavigatorSaveItem})
        Me.AdminsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdminsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdminsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdminsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdminsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdminsBindingNavigator.Name = "AdminsBindingNavigator"
        Me.AdminsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdminsBindingNavigator.Size = New System.Drawing.Size(622, 25)
        Me.AdminsBindingNavigator.TabIndex = 8
        Me.AdminsBindingNavigator.Text = "BindingNavigator1"
        Me.AdminsBindingNavigator.Visible = False
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
        'AdminsBindingNavigatorSaveItem
        '
        Me.AdminsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdminsBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdminsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdminsBindingNavigatorSaveItem.Name = "AdminsBindingNavigatorSaveItem"
        Me.AdminsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AdminsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AdminsDataGridView
        '
        Me.AdminsDataGridView.AutoGenerateColumns = False
        Me.AdminsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.AdminsDataGridView.DataSource = Me.AdminsBindingSource
        Me.AdminsDataGridView.Location = New System.Drawing.Point(80, 231)
        Me.AdminsDataGridView.Name = "AdminsDataGridView"
        Me.AdminsDataGridView.Size = New System.Drawing.Size(35, 29)
        Me.AdminsDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Work_Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Work_Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Second_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Second_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "National_Id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "National_Id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Phone_Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Phone_Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Kitchen_StaffBindingSource
        '
        Me.Kitchen_StaffBindingSource.DataMember = "Kitchen_Staff"
        Me.Kitchen_StaffBindingSource.DataSource = Me.BestFoodsDataSet
        '
        'Kitchen_StaffDataGridView
        '
        Me.Kitchen_StaffDataGridView.AutoGenerateColumns = False
        Me.Kitchen_StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Kitchen_StaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.Kitchen_StaffDataGridView.DataSource = Me.Kitchen_StaffBindingSource
        Me.Kitchen_StaffDataGridView.Location = New System.Drawing.Point(147, 231)
        Me.Kitchen_StaffDataGridView.Name = "Kitchen_StaffDataGridView"
        Me.Kitchen_StaffDataGridView.Size = New System.Drawing.Size(45, 29)
        Me.Kitchen_StaffDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Work_Id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Work_Id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Second_Name"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Second_Name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "National_Id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "National_Id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Phone_Number"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Phone_Number"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'WaitersBindingSource
        '
        Me.WaitersBindingSource.DataMember = "Waiters"
        Me.WaitersBindingSource.DataSource = Me.BestFoodsDataSet
        '
        'WaitersDataGridView
        '
        Me.WaitersDataGridView.AutoGenerateColumns = False
        Me.WaitersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WaitersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.WaitersDataGridView.DataSource = Me.WaitersBindingSource
        Me.WaitersDataGridView.Location = New System.Drawing.Point(222, 231)
        Me.WaitersDataGridView.Name = "WaitersDataGridView"
        Me.WaitersDataGridView.Size = New System.Drawing.Size(39, 29)
        Me.WaitersDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Work_Id"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Work_Id"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn20.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Second_Name"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Second_Name"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "National_Id"
        Me.DataGridViewTextBoxColumn22.HeaderText = "National_Id"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Phone_Number"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Phone_Number"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'CashiersBindingSource
        '
        Me.CashiersBindingSource.DataMember = "Cashiers"
        Me.CashiersBindingSource.DataSource = Me.BestFoodsDataSet
        '
        'CashiersDataGridView
        '
        Me.CashiersDataGridView.AutoGenerateColumns = False
        Me.CashiersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CashiersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36})
        Me.CashiersDataGridView.DataSource = Me.CashiersBindingSource
        Me.CashiersDataGridView.Location = New System.Drawing.Point(288, 229)
        Me.CashiersDataGridView.Name = "CashiersDataGridView"
        Me.CashiersDataGridView.Size = New System.Drawing.Size(34, 31)
        Me.CashiersDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Work_Id"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Work_Id"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn29.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Second_Name"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Second_Name"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "National_Id"
        Me.DataGridViewTextBoxColumn31.HeaderText = "National_Id"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Phone_Number"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Phone_Number"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'NewPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNationalId)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtConfirmNewPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CashiersDataGridView)
        Me.Controls.Add(Me.WaitersDataGridView)
        Me.Controls.Add(Me.Kitchen_StaffDataGridView)
        Me.Controls.Add(Me.AdminsDataGridView)
        Me.Controls.Add(Me.AdminsBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPass"
        CType(Me.BestFoodsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminsBindingNavigator.ResumeLayout(False)
        Me.AdminsBindingNavigator.PerformLayout()
        CType(Me.AdminsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kitchen_StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kitchen_StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaitersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaitersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashiersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashiersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtNationalId As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNewPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtConfirmNewPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AdminsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AdminsBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents AdminsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AdminsTableAdapter As BestFoods.BestFoodsDataSetTableAdapters.AdminsTableAdapter
    Friend WithEvents TableAdapterManager As BestFoods.BestFoodsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdminsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kitchen_StaffTableAdapter As BestFoods.BestFoodsDataSetTableAdapters.Kitchen_StaffTableAdapter
    Friend WithEvents Kitchen_StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Kitchen_StaffDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitersTableAdapter As BestFoods.BestFoodsDataSetTableAdapters.WaitersTableAdapter
    Friend WithEvents WaitersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WaitersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashiersTableAdapter As BestFoods.BestFoodsDataSetTableAdapters.CashiersTableAdapter
    Friend WithEvents CashiersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CashiersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
