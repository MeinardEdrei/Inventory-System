<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory_Module))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStaffs = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTimeInOut = New System.Windows.Forms.Button()
        Me.TimeOutDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Project_DatabaseDataSet = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSet()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtItemSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.InventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.InventoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtProdQty = New System.Windows.Forms.TextBox()
        Me.txtProdPrice = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProdId = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.picUp = New System.Windows.Forms.PictureBox()
        Me.picDown = New System.Windows.Forms.PictureBox()
        Me.btnInventoryShow = New System.Windows.Forms.Button()
        Me.btnArchiveShow = New System.Windows.Forms.Button()
        Me.InventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArchInventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.ArchInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.InventoryTableAdapter()
        Me.TableAdapterManager = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ArchInventoryTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.ArchInventoryTableAdapter()
        Me.TimeInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeInTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeInTableAdapter()
        Me.TimeOutTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventoryBindingNavigator.SuspendLayout()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItems.SuspendLayout()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchInventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Montserrat", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources._6
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 636)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(8, 0, 10, 0)
        Me.btnLogout.Size = New System.Drawing.Size(335, 85)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "   Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnStaffs
        '
        Me.btnStaffs.BackColor = System.Drawing.Color.Transparent
        Me.btnStaffs.FlatAppearance.BorderSize = 0
        Me.btnStaffs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffs.Font = New System.Drawing.Font("Montserrat", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffs.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources._5
        Me.btnStaffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaffs.Location = New System.Drawing.Point(0, 459)
        Me.btnStaffs.Name = "btnStaffs"
        Me.btnStaffs.Padding = New System.Windows.Forms.Padding(8, 0, 10, 0)
        Me.btnStaffs.Size = New System.Drawing.Size(335, 85)
        Me.btnStaffs.TabIndex = 4
        Me.btnStaffs.Text = "   Staff Details"
        Me.btnStaffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStaffs.UseVisualStyleBackColor = False
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.Transparent
        Me.btnCredits.FlatAppearance.BorderSize = 0
        Me.btnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredits.Font = New System.Drawing.Font("Montserrat", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources._7
        Me.btnCredits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCredits.Location = New System.Drawing.Point(-3, 368)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Padding = New System.Windows.Forms.Padding(8, 0, 10, 0)
        Me.btnCredits.Size = New System.Drawing.Size(335, 85)
        Me.btnCredits.TabIndex = 3
        Me.btnCredits.Text = "   Credits"
        Me.btnCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCredits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Montserrat", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources._4
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(-3, 277)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(8, 0, 10, 0)
        Me.btnInventory.Size = New System.Drawing.Size(335, 85)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "   Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Montserrat", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources._3
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 186)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(8, 0, 10, 0)
        Me.btnHome.Size = New System.Drawing.Size(335, 85)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "  Homepage"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnTimeInOut)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnStaffs)
        Me.Panel1.Controls.Add(Me.btnCredits)
        Me.Panel1.Controls.Add(Me.btnInventory)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.TimeOutDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 721)
        Me.Panel1.TabIndex = 3
        '
        'btnTimeInOut
        '
        Me.btnTimeInOut.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeInOut.FlatAppearance.BorderSize = 0
        Me.btnTimeInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnTimeInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeInOut.Font = New System.Drawing.Font("Montserrat", 15.0!)
        Me.btnTimeInOut.Image = CType(resources.GetObject("btnTimeInOut.Image"), System.Drawing.Image)
        Me.btnTimeInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimeInOut.Location = New System.Drawing.Point(3, 3)
        Me.btnTimeInOut.Name = "btnTimeInOut"
        Me.btnTimeInOut.Size = New System.Drawing.Size(332, 85)
        Me.btnTimeInOut.TabIndex = 17
        Me.btnTimeInOut.Text = "  Time In / Out"
        Me.btnTimeInOut.UseVisualStyleBackColor = False
        '
        'TimeOutDataGridView
        '
        Me.TimeOutDataGridView.AutoGenerateColumns = False
        Me.TimeOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeOutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.TimeOutDataGridView.DataSource = Me.TimeOutBindingSource
        Me.TimeOutDataGridView.Location = New System.Drawing.Point(12, 14)
        Me.TimeOutDataGridView.Name = "TimeOutDataGridView"
        Me.TimeOutDataGridView.RowHeadersWidth = 51
        Me.TimeOutDataGridView.RowTemplate.Height = 24
        Me.TimeOutDataGridView.Size = New System.Drawing.Size(51, 43)
        Me.TimeOutDataGridView.TabIndex = 16
        Me.TimeOutDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Name_Staff"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Time_out_Date"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Time_out_Date"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Time_out_Time"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Time_out_Time"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'TimeOutBindingSource
        '
        Me.TimeOutBindingSource.DataMember = "TimeOut"
        Me.TimeOutBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'Inventory_Project_DatabaseDataSet
        '
        Me.Inventory_Project_DatabaseDataSet.DataSetName = "Inventory_Project_DatabaseDataSet"
        Me.Inventory_Project_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnArchive)
        Me.Panel4.Controls.Add(Me.btnModify)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnAdd)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(335, 595)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1013, 126)
        Me.Panel4.TabIndex = 4
        '
        'btnArchive
        '
        Me.btnArchive.BackgroundImage = CType(resources.GetObject("btnArchive.BackgroundImage"), System.Drawing.Image)
        Me.btnArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArchive.FlatAppearance.BorderSize = 0
        Me.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchive.Location = New System.Drawing.Point(774, 48)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(151, 50)
        Me.btnArchive.TabIndex = 3
        Me.btnArchive.Text = "ARCHIVE"
        Me.btnArchive.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.BackgroundImage = CType(resources.GetObject("btnModify.BackgroundImage"), System.Drawing.Image)
        Me.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModify.FlatAppearance.BorderSize = 0
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(545, 48)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(151, 50)
        Me.btnModify.TabIndex = 2
        Me.btnModify.Text = "MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(316, 48)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(151, 50)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.Untitled_design__1_
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(87, 48)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(151, 50)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtItemSearch
        '
        Me.txtItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemSearch.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSearch.Location = New System.Drawing.Point(404, 60)
        Me.txtItemSearch.Name = "txtItemSearch"
        Me.txtItemSearch.Size = New System.Drawing.Size(323, 37)
        Me.txtItemSearch.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.Untitled_design___Copy
        Me.PictureBox2.Location = New System.Drawing.Point(355, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(386, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'InventoryBindingNavigator
        '
        Me.InventoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InventoryBindingNavigator.BindingSource = Me.InventoryBindingSource
        Me.InventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InventoryBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.InventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InventoryBindingNavigatorSaveItem})
        Me.InventoryBindingNavigator.Location = New System.Drawing.Point(335, 0)
        Me.InventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventoryBindingNavigator.Name = "InventoryBindingNavigator"
        Me.InventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventoryBindingNavigator.Size = New System.Drawing.Size(1013, 27)
        Me.InventoryBindingNavigator.TabIndex = 10
        Me.InventoryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'InventoryBindingNavigatorSaveItem
        '
        Me.InventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventoryBindingNavigatorSaveItem.Name = "InventoryBindingNavigatorSaveItem"
        Me.InventoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.InventoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'cboSearchBy
        '
        Me.cboSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Product ID", "Product Name", "Product Price", "Product Quantity", "Product Category"})
        Me.cboSearchBy.Location = New System.Drawing.Point(1105, 62)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(222, 37)
        Me.cboSearchBy.TabIndex = 11
        '
        'pnlItems
        '
        Me.pnlItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlItems.Controls.Add(Me.Label5)
        Me.pnlItems.Controls.Add(Me.Label4)
        Me.pnlItems.Controls.Add(Me.Label3)
        Me.pnlItems.Controls.Add(Me.Label2)
        Me.pnlItems.Controls.Add(Me.Label1)
        Me.pnlItems.Controls.Add(Me.cboCategory)
        Me.pnlItems.Controls.Add(Me.txtProdQty)
        Me.pnlItems.Controls.Add(Me.txtProdPrice)
        Me.pnlItems.Controls.Add(Me.txtProdName)
        Me.pnlItems.Controls.Add(Me.txtProdId)
        Me.pnlItems.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlItems.Location = New System.Drawing.Point(335, 595)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(1013, 0)
        Me.pnlItems.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(875, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(657, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Product Qty."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(470, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Product Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(256, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Product ID"
        '
        'cboCategory
        '
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Accessories", "Art Material", "Board", "Book", "Clearbook", "Crayon", "Document", "Envelope", "Filler", "Folder", "Instructional", "Marker", "Notebook", "Paper", "Pen", "Pencil"})
        Me.cboCategory.Location = New System.Drawing.Point(836, 61)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(166, 37)
        Me.cboCategory.TabIndex = 17
        '
        'txtProdQty
        '
        Me.txtProdQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProdQty.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdQty.Location = New System.Drawing.Point(651, 61)
        Me.txtProdQty.Name = "txtProdQty"
        Me.txtProdQty.Size = New System.Drawing.Size(136, 37)
        Me.txtProdQty.TabIndex = 16
        '
        'txtProdPrice
        '
        Me.txtProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProdPrice.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdPrice.Location = New System.Drawing.Point(466, 61)
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.Size = New System.Drawing.Size(136, 37)
        Me.txtProdPrice.TabIndex = 15
        '
        'txtProdName
        '
        Me.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProdName.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdName.Location = New System.Drawing.Point(225, 61)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(191, 37)
        Me.txtProdName.TabIndex = 14
        '
        'txtProdId
        '
        Me.txtProdId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProdId.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdId.Location = New System.Drawing.Point(15, 61)
        Me.txtProdId.Name = "txtProdId"
        Me.txtProdId.Size = New System.Drawing.Size(162, 37)
        Me.txtProdId.TabIndex = 13
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'picUp
        '
        Me.picUp.BackColor = System.Drawing.Color.Transparent
        Me.picUp.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.Untitled_design__2_
        Me.picUp.Location = New System.Drawing.Point(821, 573)
        Me.picUp.Name = "picUp"
        Me.picUp.Size = New System.Drawing.Size(36, 40)
        Me.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUp.TabIndex = 13
        Me.picUp.TabStop = False
        '
        'picDown
        '
        Me.picDown.BackColor = System.Drawing.Color.Transparent
        Me.picDown.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.DOWN
        Me.picDown.Location = New System.Drawing.Point(821, 573)
        Me.picDown.Name = "picDown"
        Me.picDown.Size = New System.Drawing.Size(36, 40)
        Me.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDown.TabIndex = 14
        Me.picDown.TabStop = False
        '
        'btnInventoryShow
        '
        Me.btnInventoryShow.FlatAppearance.BorderSize = 0
        Me.btnInventoryShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventoryShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryShow.Location = New System.Drawing.Point(357, 116)
        Me.btnInventoryShow.Name = "btnInventoryShow"
        Me.btnInventoryShow.Size = New System.Drawing.Size(125, 35)
        Me.btnInventoryShow.TabIndex = 15
        Me.btnInventoryShow.Text = "Inventory"
        Me.btnInventoryShow.UseVisualStyleBackColor = True
        '
        'btnArchiveShow
        '
        Me.btnArchiveShow.FlatAppearance.BorderSize = 0
        Me.btnArchiveShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArchiveShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchiveShow.Location = New System.Drawing.Point(481, 116)
        Me.btnArchiveShow.Name = "btnArchiveShow"
        Me.btnArchiveShow.Size = New System.Drawing.Size(145, 35)
        Me.btnArchiveShow.TabIndex = 16
        Me.btnArchiveShow.Text = "Archived Items"
        Me.btnArchiveShow.UseVisualStyleBackColor = True
        '
        'InventoryDataGridView
        '
        Me.InventoryDataGridView.AutoGenerateColumns = False
        Me.InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.InventoryDataGridView.DataSource = Me.InventoryBindingSource
        Me.InventoryDataGridView.Location = New System.Drawing.Point(357, 160)
        Me.InventoryDataGridView.Name = "InventoryDataGridView"
        Me.InventoryDataGridView.RowHeadersWidth = 51
        Me.InventoryDataGridView.RowTemplate.Height = 24
        Me.InventoryDataGridView.Size = New System.Drawing.Size(970, 265)
        Me.InventoryDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProdID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProdName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 117
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProdPrice"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product Price"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProdQuantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product Quantity"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProdCategory"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Product Category"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ArchInventoryDataGridView
        '
        Me.ArchInventoryDataGridView.AutoGenerateColumns = False
        Me.ArchInventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArchInventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.Time_Date})
        Me.ArchInventoryDataGridView.DataSource = Me.ArchInventoryBindingSource
        Me.ArchInventoryDataGridView.Location = New System.Drawing.Point(357, 160)
        Me.ArchInventoryDataGridView.Name = "ArchInventoryDataGridView"
        Me.ArchInventoryDataGridView.RowHeadersWidth = 51
        Me.ArchInventoryDataGridView.RowTemplate.Height = 24
        Me.ArchInventoryDataGridView.Size = New System.Drawing.Size(970, 265)
        Me.ArchInventoryDataGridView.TabIndex = 16
        '
        'ArchInventoryBindingSource
        '
        Me.ArchInventoryBindingSource.DataMember = "ArchInventory"
        Me.ArchInventoryBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArchInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ArchUserCredsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CreditsArchTableAdapter = Nothing
        Me.TableAdapterManager.CreditsTableAdapter = Nothing
        Me.TableAdapterManager.In_TimeTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.OutTableAdapter = Nothing
        Me.TableAdapterManager.PaidCreditsTableAdapter = Nothing

        Me.TableAdapterManager.TimeInTableAdapter = Nothing
        Me.TableAdapterManager.TimeOutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserCredsTableAdapter = Nothing
        '
        'ArchInventoryTableAdapter
        '
        Me.ArchInventoryTableAdapter.ClearBeforeFill = True
        '
        'TimeInBindingSource
        '
        Me.TimeInBindingSource.DataMember = "TimeIn"
        Me.TimeInBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'TimeInTableAdapter
        '
        Me.TimeInTableAdapter.ClearBeforeFill = True
        '
        'TimeOutTableAdapter
        '
        Me.TimeOutTableAdapter.ClearBeforeFill = True
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ProdID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Product ID"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ProdName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn7.Width = 127
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ProdPrice"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Product Price"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ProdQuantity"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Product Quantity"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ProdCategory"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Product Category"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Time_Date
        '
        Me.Time_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Time_Date.DataPropertyName = "Time_Date"
        Me.Time_Date.HeaderText = "Time and Date Archived"
        Me.Time_Date.MinimumWidth = 6
        Me.Time_Date.Name = "Time_Date"
        '
        'Inventory_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.MODULE_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.picUp)
        Me.Controls.Add(Me.picDown)
        Me.Controls.Add(Me.pnlItems)
        Me.Controls.Add(Me.ArchInventoryDataGridView)
        Me.Controls.Add(Me.InventoryDataGridView)
        Me.Controls.Add(Me.btnArchiveShow)
        Me.Controls.Add(Me.btnInventoryShow)
        Me.Controls.Add(Me.cboSearchBy)
        Me.Controls.Add(Me.InventoryBindingNavigator)
        Me.Controls.Add(Me.txtItemSearch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Inventory_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventoryBindingNavigator.ResumeLayout(False)
        Me.InventoryBindingNavigator.PerformLayout()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchInventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents btnStaffs As Button
    Friend WithEvents btnCredits As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnArchive As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtItemSearch As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Inventory_Project_DatabaseDataSet As Inventory_Project_DatabaseDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents TableAdapterManager As Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventoryBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents InventoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents pnlItems As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents txtProdQty As TextBox
    Friend WithEvents txtProdPrice As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtProdId As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents picUp As PictureBox
    Friend WithEvents picDown As PictureBox
    Friend WithEvents ArchInventoryBindingSource As BindingSource
    Friend WithEvents ArchInventoryTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.ArchInventoryTableAdapter
    Friend WithEvents btnInventoryShow As Button
    Friend WithEvents btnArchiveShow As Button
    Friend WithEvents InventoryDataGridView As DataGridView
    Friend WithEvents ArchInventoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents TimeInBindingSource As BindingSource
    Friend WithEvents TimeInTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeInTableAdapter
    Friend WithEvents TimeOutBindingSource As BindingSource
    Friend WithEvents TimeOutTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter
    Friend WithEvents TimeOutDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents btnTimeInOut As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Time_Date As DataGridViewTextBoxColumn
End Class
