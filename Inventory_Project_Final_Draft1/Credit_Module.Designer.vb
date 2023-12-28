<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Credit_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Credit_Module))
        Me.txtItemSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStaffs = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPaid = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTimeInOut = New System.Windows.Forms.Button()
        Me.TimeOutDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Project_DatabaseDataSet = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSet()
        Me.CreditsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CreditsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CreditsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDue = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmtDue = New System.Windows.Forms.TextBox()
        Me.txtCreditor = New System.Windows.Forms.TextBox()
        Me.txtCreditID = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.picDown = New System.Windows.Forms.PictureBox()
        Me.picUp = New System.Windows.Forms.PictureBox()
        Me.btnPaidShow = New System.Windows.Forms.Button()
        Me.btnUnpaidShow = New System.Windows.Forms.Button()
        Me.CreditsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidCreditsDataGridView = New System.Windows.Forms.DataGridView()
        Me.PaidCreditsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnArchivetable = New System.Windows.Forms.Button()
        Me.CreditsArchDataGridView = New System.Windows.Forms.DataGridView()
        Me.CreditsArchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditsTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.CreditsTableAdapter()
        Me.TableAdapterManager = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PaidCreditsTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.PaidCreditsTableAdapter()
        Me.CreditsArchTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.CreditsArchTableAdapter()
        Me.TimeOutTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CreditsBindingNavigator.SuspendLayout()
        CType(Me.CreditsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItems.SuspendLayout()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaidCreditsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaidCreditsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditsArchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditsArchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtItemSearch
        '
        Me.txtItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemSearch.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSearch.Location = New System.Drawing.Point(404, 71)
        Me.txtItemSearch.Name = "txtItemSearch"
        Me.txtItemSearch.Size = New System.Drawing.Size(323, 37)
        Me.txtItemSearch.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.Untitled_design___Copy
        Me.PictureBox2.Location = New System.Drawing.Point(355, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(386, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnPaid)
        Me.Panel4.Controls.Add(Me.btnModify)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnAdd)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(335, 600)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1013, 121)
        Me.Panel4.TabIndex = 11
        '
        'btnPaid
        '
        Me.btnPaid.BackgroundImage = CType(resources.GetObject("btnPaid.BackgroundImage"), System.Drawing.Image)
        Me.btnPaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPaid.FlatAppearance.BorderSize = 0
        Me.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaid.Location = New System.Drawing.Point(756, 36)
        Me.btnPaid.Name = "btnPaid"
        Me.btnPaid.Size = New System.Drawing.Size(151, 50)
        Me.btnPaid.TabIndex = 3
        Me.btnPaid.Text = "PAID"
        Me.btnPaid.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.BackgroundImage = CType(resources.GetObject("btnModify.BackgroundImage"), System.Drawing.Image)
        Me.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModify.FlatAppearance.BorderSize = 0
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(539, 36)
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
        Me.btnSave.Location = New System.Drawing.Point(322, 36)
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
        Me.btnAdd.Location = New System.Drawing.Point(105, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(151, 50)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 10
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
        Me.btnTimeInOut.TabIndex = 27
        Me.btnTimeInOut.Text = "  Time In / Out"
        Me.btnTimeInOut.UseVisualStyleBackColor = False
        '
        'TimeOutDataGridView
        '
        Me.TimeOutDataGridView.AutoGenerateColumns = False
        Me.TimeOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeOutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.TimeOutDataGridView.DataSource = Me.TimeOutBindingSource
        Me.TimeOutDataGridView.Location = New System.Drawing.Point(225, 685)
        Me.TimeOutDataGridView.Name = "TimeOutDataGridView"
        Me.TimeOutDataGridView.RowHeadersWidth = 51
        Me.TimeOutDataGridView.RowTemplate.Height = 24
        Me.TimeOutDataGridView.Size = New System.Drawing.Size(65, 10)
        Me.TimeOutDataGridView.TabIndex = 26
        Me.TimeOutDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Name_Staff"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Time_out_Date"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Time_out_Date"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Time_out_Time"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Time_out_Time"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 125
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
        'CreditsBindingNavigator
        '
        Me.CreditsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CreditsBindingNavigator.BindingSource = Me.CreditsBindingSource
        Me.CreditsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CreditsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CreditsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CreditsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CreditsBindingNavigatorSaveItem})
        Me.CreditsBindingNavigator.Location = New System.Drawing.Point(335, 0)
        Me.CreditsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CreditsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CreditsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CreditsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CreditsBindingNavigator.Name = "CreditsBindingNavigator"
        Me.CreditsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CreditsBindingNavigator.Size = New System.Drawing.Size(1013, 27)
        Me.CreditsBindingNavigator.TabIndex = 16
        Me.CreditsBindingNavigator.Text = "BindingNavigator1"
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
        'CreditsBindingSource
        '
        Me.CreditsBindingSource.DataMember = "Credits"
        Me.CreditsBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
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
        'CreditsBindingNavigatorSaveItem
        '
        Me.CreditsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CreditsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CreditsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CreditsBindingNavigatorSaveItem.Name = "CreditsBindingNavigatorSaveItem"
        Me.CreditsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.CreditsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'pnlItems
        '
        Me.pnlItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlItems.Controls.Add(Me.lblStatus)
        Me.pnlItems.Controls.Add(Me.Label4)
        Me.pnlItems.Controls.Add(Me.dtpDue)
        Me.pnlItems.Controls.Add(Me.Label5)
        Me.pnlItems.Controls.Add(Me.Label3)
        Me.pnlItems.Controls.Add(Me.Label2)
        Me.pnlItems.Controls.Add(Me.Label1)
        Me.pnlItems.Controls.Add(Me.txtAmtDue)
        Me.pnlItems.Controls.Add(Me.txtCreditor)
        Me.pnlItems.Controls.Add(Me.txtCreditID)
        Me.pnlItems.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlItems.Location = New System.Drawing.Point(335, 600)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(1013, 0)
        Me.pnlItems.TabIndex = 18
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(904, 60)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 25)
        Me.lblStatus.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(910, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Status"
        '
        'dtpDue
        '
        Me.dtpDue.CalendarFont = New System.Drawing.Font("Montserrat", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(662, 59)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(199, 36)
        Me.dtpDue.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(710, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Due Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(477, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Amount Due"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Name of Creditor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Credit ID"
        '
        'txtAmtDue
        '
        Me.txtAmtDue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmtDue.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtDue.Location = New System.Drawing.Point(453, 60)
        Me.txtAmtDue.Name = "txtAmtDue"
        Me.txtAmtDue.Size = New System.Drawing.Size(171, 37)
        Me.txtAmtDue.TabIndex = 15
        '
        'txtCreditor
        '
        Me.txtCreditor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreditor.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditor.Location = New System.Drawing.Point(217, 60)
        Me.txtCreditor.Name = "txtCreditor"
        Me.txtCreditor.Size = New System.Drawing.Size(207, 37)
        Me.txtCreditor.TabIndex = 14
        '
        'txtCreditID
        '
        Me.txtCreditID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreditID.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditID.Location = New System.Drawing.Point(21, 60)
        Me.txtCreditID.Name = "txtCreditID"
        Me.txtCreditID.Size = New System.Drawing.Size(162, 37)
        Me.txtCreditID.TabIndex = 13
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'picDown
        '
        Me.picDown.BackColor = System.Drawing.Color.Transparent
        Me.picDown.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.DOWN
        Me.picDown.Location = New System.Drawing.Point(824, 578)
        Me.picDown.Name = "picDown"
        Me.picDown.Size = New System.Drawing.Size(36, 40)
        Me.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDown.TabIndex = 24
        Me.picDown.TabStop = False
        '
        'picUp
        '
        Me.picUp.BackColor = System.Drawing.Color.Transparent
        Me.picUp.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.Untitled_design__2_
        Me.picUp.Location = New System.Drawing.Point(824, 578)
        Me.picUp.Name = "picUp"
        Me.picUp.Size = New System.Drawing.Size(36, 40)
        Me.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUp.TabIndex = 25
        Me.picUp.TabStop = False
        '
        'btnPaidShow
        '
        Me.btnPaidShow.FlatAppearance.BorderSize = 0
        Me.btnPaidShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPaidShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaidShow.Location = New System.Drawing.Point(480, 127)
        Me.btnPaidShow.Name = "btnPaidShow"
        Me.btnPaidShow.Size = New System.Drawing.Size(145, 35)
        Me.btnPaidShow.TabIndex = 18
        Me.btnPaidShow.Text = "Paid"
        Me.btnPaidShow.UseVisualStyleBackColor = True
        '
        'btnUnpaidShow
        '
        Me.btnUnpaidShow.FlatAppearance.BorderSize = 0
        Me.btnUnpaidShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnpaidShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnpaidShow.Location = New System.Drawing.Point(356, 127)
        Me.btnUnpaidShow.Name = "btnUnpaidShow"
        Me.btnUnpaidShow.Size = New System.Drawing.Size(125, 35)
        Me.btnUnpaidShow.TabIndex = 17
        Me.btnUnpaidShow.Text = "Unpaid"
        Me.btnUnpaidShow.UseVisualStyleBackColor = True
        '
        'CreditsDataGridView
        '
        Me.CreditsDataGridView.AutoGenerateColumns = False
        Me.CreditsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreditsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CreditsDataGridView.DataSource = Me.CreditsBindingSource
        Me.CreditsDataGridView.Location = New System.Drawing.Point(356, 168)
        Me.CreditsDataGridView.Name = "CreditsDataGridView"
        Me.CreditsDataGridView.RowHeadersWidth = 51
        Me.CreditsDataGridView.RowTemplate.Height = 24
        Me.CreditsDataGridView.Size = New System.Drawing.Size(957, 224)
        Me.CreditsDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Credit_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Credit ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name_Credit"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name of Credit"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Due_Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Due Date"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'PaidCreditsDataGridView
        '
        Me.PaidCreditsDataGridView.AutoGenerateColumns = False
        Me.PaidCreditsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaidCreditsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.Time_Date})
        Me.PaidCreditsDataGridView.DataSource = Me.PaidCreditsBindingSource
        Me.PaidCreditsDataGridView.Location = New System.Drawing.Point(355, 168)
        Me.PaidCreditsDataGridView.Name = "PaidCreditsDataGridView"
        Me.PaidCreditsDataGridView.RowHeadersWidth = 51
        Me.PaidCreditsDataGridView.RowTemplate.Height = 24
        Me.PaidCreditsDataGridView.Size = New System.Drawing.Size(957, 220)
        Me.PaidCreditsDataGridView.TabIndex = 25
        '
        'PaidCreditsBindingSource
        '
        Me.PaidCreditsBindingSource.DataMember = "PaidCredits"
        Me.PaidCreditsBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'btnArchivetable
        '
        Me.btnArchivetable.FlatAppearance.BorderSize = 0
        Me.btnArchivetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArchivetable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchivetable.Location = New System.Drawing.Point(624, 127)
        Me.btnArchivetable.Name = "btnArchivetable"
        Me.btnArchivetable.Size = New System.Drawing.Size(145, 35)
        Me.btnArchivetable.TabIndex = 26
        Me.btnArchivetable.Text = "Archive"
        Me.btnArchivetable.UseVisualStyleBackColor = True
        '
        'CreditsArchDataGridView
        '
        Me.CreditsArchDataGridView.AutoGenerateColumns = False
        Me.CreditsArchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreditsArchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn21})
        Me.CreditsArchDataGridView.DataSource = Me.CreditsArchBindingSource
        Me.CreditsArchDataGridView.Location = New System.Drawing.Point(355, 172)
        Me.CreditsArchDataGridView.Name = "CreditsArchDataGridView"
        Me.CreditsArchDataGridView.RowHeadersWidth = 51
        Me.CreditsArchDataGridView.RowTemplate.Height = 24
        Me.CreditsArchDataGridView.Size = New System.Drawing.Size(958, 220)
        Me.CreditsArchDataGridView.TabIndex = 26
        '
        'CreditsArchBindingSource
        '
        Me.CreditsArchBindingSource.DataMember = "CreditsArch"
        Me.CreditsArchBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'CreditsTableAdapter
        '
        Me.CreditsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArchInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ArchUserCredsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CreditsArchTableAdapter = Nothing
        Me.TableAdapterManager.CreditsTableAdapter = Me.CreditsTableAdapter
        Me.TableAdapterManager.In_TimeTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.OutTableAdapter = Nothing
        Me.TableAdapterManager.PaidCreditsTableAdapter = Nothing
        Me.TableAdapterManager.TimeInTableAdapter = Nothing
        Me.TableAdapterManager.TimeOutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserCredsTableAdapter = Nothing
        '
        'PaidCreditsTableAdapter
        '
        Me.PaidCreditsTableAdapter.ClearBeforeFill = True
        '
        'CreditsArchTableAdapter
        '
        Me.CreditsArchTableAdapter.ClearBeforeFill = True
        '
        'TimeOutTableAdapter
        '
        Me.TimeOutTableAdapter.ClearBeforeFill = True
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Credit_ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Credit ID"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Name_Credit"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Name of Creditor"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 132
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Due_Date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Due Date"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Time_Date"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Time and Date Archived"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Credit_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Credit ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Name_Credit"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Name of Credit"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Amount_Due"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Amount Due"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Due_Date"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Due Date"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Time_Date
        '
        Me.Time_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Time_Date.DataPropertyName = "Time_Date"
        Me.Time_Date.HeaderText = "Time and Date Paid"
        Me.Time_Date.MinimumWidth = 6
        Me.Time_Date.Name = "Time_Date"
        '
        'Credit_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.CPG_MODULES
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.btnArchivetable)
        Me.Controls.Add(Me.CreditsDataGridView)
        Me.Controls.Add(Me.PaidCreditsDataGridView)
        Me.Controls.Add(Me.CreditsArchDataGridView)
        Me.Controls.Add(Me.btnPaidShow)
        Me.Controls.Add(Me.btnUnpaidShow)
        Me.Controls.Add(Me.picUp)
        Me.Controls.Add(Me.picDown)
        Me.Controls.Add(Me.pnlItems)
        Me.Controls.Add(Me.CreditsBindingNavigator)
        Me.Controls.Add(Me.txtItemSearch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Credit_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credit_Module"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CreditsBindingNavigator.ResumeLayout(False)
        Me.CreditsBindingNavigator.PerformLayout()
        CType(Me.CreditsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaidCreditsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaidCreditsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditsArchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditsArchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtItemSearch As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnStaffs As Button
    Friend WithEvents btnCredits As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPaid As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Inventory_Project_DatabaseDataSet As Inventory_Project_DatabaseDataSet
    Friend WithEvents CreditsBindingSource As BindingSource
    Friend WithEvents CreditsTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.CreditsTableAdapter
    Friend WithEvents TableAdapterManager As Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CreditsBindingNavigator As BindingNavigator
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
    Friend WithEvents CreditsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents pnlItems As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmtDue As TextBox
    Friend WithEvents txtCreditor As TextBox
    Friend WithEvents txtCreditID As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents picDown As PictureBox
    Friend WithEvents picUp As PictureBox
    Friend WithEvents btnPaidShow As Button
    Friend WithEvents btnUnpaidShow As Button
    Friend WithEvents PaidCreditsBindingSource As BindingSource
    Friend WithEvents PaidCreditsTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.PaidCreditsTableAdapter
    Friend WithEvents CreditsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents PaidCreditsDataGridView As DataGridView
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnArchivetable As Button
    Friend WithEvents CreditsArchBindingSource As BindingSource
    Friend WithEvents CreditsArchTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.CreditsArchTableAdapter
    Friend WithEvents CreditsArchDataGridView As DataGridView
    Friend WithEvents TimeOutBindingSource As BindingSource
    Friend WithEvents TimeOutTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter
    Friend WithEvents TimeOutDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents btnTimeInOut As Button
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Time_Date As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
End Class
