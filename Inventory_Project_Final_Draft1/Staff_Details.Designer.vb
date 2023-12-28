<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Details))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTimeInOut = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStaffs = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.TimeOutDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Project_DatabaseDataSet = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picDown = New System.Windows.Forms.PictureBox()
        Me.picUp = New System.Windows.Forms.PictureBox()
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAcctStat = New System.Windows.Forms.ComboBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.UserCredsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UserCredsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.UserCredsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserCredsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtItemSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlReset = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnResetPass = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPassReset = New System.Windows.Forms.TextBox()
        Me.txtUserIDReset = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.picUpReset = New System.Windows.Forms.PictureBox()
        Me.picDownReset = New System.Windows.Forms.PictureBox()
        Me.ArchUserCredsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ArchUserCredsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnArchiveShow = New System.Windows.Forms.Button()
        Me.btnUserShow = New System.Windows.Forms.Button()
        Me.UserCredsTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.UserCredsTableAdapter()
        Me.TableAdapterManager = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ArchUserCredsTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.ArchUserCredsTableAdapter()
        Me.TimeOutTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItems.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.UserCredsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserCredsBindingNavigator.SuspendLayout()
        CType(Me.UserCredsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCredsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReset.SuspendLayout()
        CType(Me.picUpReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDownReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchUserCredsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchUserCredsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 6
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
        Me.btnTimeInOut.TabIndex = 30
        Me.btnTimeInOut.Text = "  Time In / Out"
        Me.btnTimeInOut.UseVisualStyleBackColor = False
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
        'TimeOutDataGridView
        '
        Me.TimeOutDataGridView.AutoGenerateColumns = False
        Me.TimeOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeOutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.TimeOutDataGridView.DataSource = Me.TimeOutBindingSource
        Me.TimeOutDataGridView.Location = New System.Drawing.Point(268, 673)
        Me.TimeOutDataGridView.Name = "TimeOutDataGridView"
        Me.TimeOutDataGridView.RowHeadersWidth = 51
        Me.TimeOutDataGridView.RowTemplate.Height = 24
        Me.TimeOutDataGridView.Size = New System.Drawing.Size(28, 22)
        Me.TimeOutDataGridView.TabIndex = 29
        Me.TimeOutDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Name_Staff"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Time_out_Date"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Time_out_Date"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Time_out_Time"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Time_out_Time"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
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
        'Timer1
        '
        '
        'picDown
        '
        Me.picDown.BackColor = System.Drawing.Color.Transparent
        Me.picDown.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.DOWN
        Me.picDown.Location = New System.Drawing.Point(821, 573)
        Me.picDown.Name = "picDown"
        Me.picDown.Size = New System.Drawing.Size(36, 40)
        Me.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDown.TabIndex = 18
        Me.picDown.TabStop = False
        '
        'picUp
        '
        Me.picUp.BackColor = System.Drawing.Color.Transparent
        Me.picUp.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.Untitled_design__2_
        Me.picUp.Location = New System.Drawing.Point(821, 573)
        Me.picUp.Name = "picUp"
        Me.picUp.Size = New System.Drawing.Size(36, 40)
        Me.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUp.TabIndex = 17
        Me.picUp.TabStop = False
        '
        'pnlItems
        '
        Me.pnlItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlItems.Controls.Add(Me.lblStatus)
        Me.pnlItems.Controls.Add(Me.Label6)
        Me.pnlItems.Controls.Add(Me.Label5)
        Me.pnlItems.Controls.Add(Me.Label4)
        Me.pnlItems.Controls.Add(Me.Label3)
        Me.pnlItems.Controls.Add(Me.Label2)
        Me.pnlItems.Controls.Add(Me.Label1)
        Me.pnlItems.Controls.Add(Me.cboAcctStat)
        Me.pnlItems.Controls.Add(Me.txtPass)
        Me.pnlItems.Controls.Add(Me.txtEmail)
        Me.pnlItems.Controls.Add(Me.txtName)
        Me.pnlItems.Controls.Add(Me.txtUserID)
        Me.pnlItems.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlItems.Location = New System.Drawing.Point(335, 595)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(1013, 0)
        Me.pnlItems.TabIndex = 16
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(932, 61)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 29)
        Me.lblStatus.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(923, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(748, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Account Level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(570, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(373, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(177, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Employee's Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "User ID"
        '
        'cboAcctStat
        '
        Me.cboAcctStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAcctStat.FormattingEnabled = True
        Me.cboAcctStat.Items.AddRange(New Object() {"Superadmin", "Employee / Staff"})
        Me.cboAcctStat.Location = New System.Drawing.Point(739, 61)
        Me.cboAcctStat.Name = "cboAcctStat"
        Me.cboAcctStat.Size = New System.Drawing.Size(166, 37)
        Me.cboAcctStat.TabIndex = 17
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(560, 61)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(158, 37)
        Me.txtPass.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(378, 61)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(162, 37)
        Me.txtEmail.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(167, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 37)
        Me.txtName.TabIndex = 14
        '
        'txtUserID
        '
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserID.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(15, 61)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(130, 37)
        Me.txtUserID.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnReset)
        Me.Panel4.Controls.Add(Me.btnModify)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnAdd)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(335, 595)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1013, 126)
        Me.Panel4.TabIndex = 15
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(774, 48)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(151, 50)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
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
        'UserCredsBindingNavigator
        '
        Me.UserCredsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserCredsBindingNavigator.BindingSource = Me.UserCredsBindingSource
        Me.UserCredsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserCredsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserCredsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UserCredsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserCredsBindingNavigatorSaveItem})
        Me.UserCredsBindingNavigator.Location = New System.Drawing.Point(335, 0)
        Me.UserCredsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserCredsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserCredsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserCredsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserCredsBindingNavigator.Name = "UserCredsBindingNavigator"
        Me.UserCredsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserCredsBindingNavigator.Size = New System.Drawing.Size(1013, 31)
        Me.UserCredsBindingNavigator.TabIndex = 17
        Me.UserCredsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'UserCredsBindingSource
        '
        Me.UserCredsBindingSource.DataMember = "UserCreds"
        Me.UserCredsBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'UserCredsBindingNavigatorSaveItem
        '
        Me.UserCredsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserCredsBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserCredsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserCredsBindingNavigatorSaveItem.Name = "UserCredsBindingNavigatorSaveItem"
        Me.UserCredsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.UserCredsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserCredsDataGridView
        '
        Me.UserCredsDataGridView.AutoGenerateColumns = False
        Me.UserCredsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserCredsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UserCredsDataGridView.DataSource = Me.UserCredsBindingSource
        Me.UserCredsDataGridView.Location = New System.Drawing.Point(364, 156)
        Me.UserCredsDataGridView.Name = "UserCredsDataGridView"
        Me.UserCredsDataGridView.RowHeadersWidth = 51
        Me.UserCredsDataGridView.RowTemplate.Height = 24
        Me.UserCredsDataGridView.Size = New System.Drawing.Size(953, 244)
        Me.UserCredsDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee's Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Account_Level"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Account Level"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Account_Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Account Status"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Timer2
        '
        '
        'txtItemSearch
        '
        Me.txtItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemSearch.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSearch.Location = New System.Drawing.Point(415, 63)
        Me.txtItemSearch.Name = "txtItemSearch"
        Me.txtItemSearch.Size = New System.Drawing.Size(323, 37)
        Me.txtItemSearch.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.Untitled_design___Copy
        Me.PictureBox2.Location = New System.Drawing.Point(366, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(386, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(366, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(951, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "OK Status means no Error                   P.R Status means Password Reset" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlReset
        '
        Me.pnlReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlReset.Controls.Add(Me.Label11)
        Me.pnlReset.Controls.Add(Me.Label10)
        Me.pnlReset.Controls.Add(Me.btnResetPass)
        Me.pnlReset.Controls.Add(Me.Label9)
        Me.pnlReset.Controls.Add(Me.txtPassReset)
        Me.pnlReset.Controls.Add(Me.txtUserIDReset)
        Me.pnlReset.Controls.Add(Me.Label8)
        Me.pnlReset.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlReset.Location = New System.Drawing.Point(335, 595)
        Me.pnlReset.Name = "pnlReset"
        Me.pnlReset.Size = New System.Drawing.Size(1013, 0)
        Me.pnlReset.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(769, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 25)
        Me.Label11.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(816, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 25)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Status"
        '
        'btnResetPass
        '
        Me.btnResetPass.BackgroundImage = CType(resources.GetObject("btnResetPass.BackgroundImage"), System.Drawing.Image)
        Me.btnResetPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnResetPass.FlatAppearance.BorderSize = 0
        Me.btnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPass.Location = New System.Drawing.Point(545, 50)
        Me.btnResetPass.Name = "btnResetPass"
        Me.btnResetPass.Size = New System.Drawing.Size(151, 50)
        Me.btnResetPass.TabIndex = 28
        Me.btnResetPass.Text = "RESET"
        Me.btnResetPass.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(290, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "New Password"
        '
        'txtPassReset
        '
        Me.txtPassReset.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassReset.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassReset.Location = New System.Drawing.Point(258, 57)
        Me.txtPassReset.Name = "txtPassReset"
        Me.txtPassReset.Size = New System.Drawing.Size(198, 37)
        Me.txtPassReset.TabIndex = 26
        '
        'txtUserIDReset
        '
        Me.txtUserIDReset.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserIDReset.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserIDReset.Location = New System.Drawing.Point(15, 57)
        Me.txtUserIDReset.Name = "txtUserIDReset"
        Me.txtUserIDReset.Size = New System.Drawing.Size(191, 37)
        Me.txtUserIDReset.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(71, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "User ID"
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'picUpReset
        '
        Me.picUpReset.BackColor = System.Drawing.Color.Transparent
        Me.picUpReset.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.Untitled_design__2_
        Me.picUpReset.Location = New System.Drawing.Point(821, 573)
        Me.picUpReset.Name = "picUpReset"
        Me.picUpReset.Size = New System.Drawing.Size(36, 40)
        Me.picUpReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUpReset.TabIndex = 26
        Me.picUpReset.TabStop = False
        '
        'picDownReset
        '
        Me.picDownReset.BackColor = System.Drawing.Color.Transparent
        Me.picDownReset.Image = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.DOWN
        Me.picDownReset.Location = New System.Drawing.Point(821, 573)
        Me.picDownReset.Name = "picDownReset"
        Me.picDownReset.Size = New System.Drawing.Size(36, 40)
        Me.picDownReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDownReset.TabIndex = 27
        Me.picDownReset.TabStop = False
        '
        'ArchUserCredsDataGridView
        '
        Me.ArchUserCredsDataGridView.AutoGenerateColumns = False
        Me.ArchUserCredsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArchUserCredsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.Time_Date})
        Me.ArchUserCredsDataGridView.DataSource = Me.ArchUserCredsBindingSource
        Me.ArchUserCredsDataGridView.Location = New System.Drawing.Point(364, 156)
        Me.ArchUserCredsDataGridView.Name = "ArchUserCredsDataGridView"
        Me.ArchUserCredsDataGridView.RowHeadersWidth = 51
        Me.ArchUserCredsDataGridView.RowTemplate.Height = 24
        Me.ArchUserCredsDataGridView.Size = New System.Drawing.Size(953, 244)
        Me.ArchUserCredsDataGridView.TabIndex = 27
        '
        'ArchUserCredsBindingSource
        '
        Me.ArchUserCredsBindingSource.DataMember = "ArchUserCreds"
        Me.ArchUserCredsBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'btnArchiveShow
        '
        Me.btnArchiveShow.FlatAppearance.BorderSize = 0
        Me.btnArchiveShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArchiveShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchiveShow.Location = New System.Drawing.Point(488, 119)
        Me.btnArchiveShow.Name = "btnArchiveShow"
        Me.btnArchiveShow.Size = New System.Drawing.Size(175, 35)
        Me.btnArchiveShow.TabIndex = 29
        Me.btnArchiveShow.Text = "Archived Details"
        Me.btnArchiveShow.UseVisualStyleBackColor = True
        '
        'btnUserShow
        '
        Me.btnUserShow.FlatAppearance.BorderSize = 0
        Me.btnUserShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUserShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserShow.Location = New System.Drawing.Point(364, 119)
        Me.btnUserShow.Name = "btnUserShow"
        Me.btnUserShow.Size = New System.Drawing.Size(125, 35)
        Me.btnUserShow.TabIndex = 28
        Me.btnUserShow.Text = "User Details"
        Me.btnUserShow.UseVisualStyleBackColor = True
        '
        'UserCredsTableAdapter
        '
        Me.UserCredsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArchInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ArchUserCredsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CreditsArchTableAdapter = Nothing
        Me.TableAdapterManager.CreditsTableAdapter = Nothing
        Me.TableAdapterManager.In_TimeTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.OutTableAdapter = Nothing
        Me.TableAdapterManager.PaidCreditsTableAdapter = Nothing

        Me.TableAdapterManager.TimeInTableAdapter = Nothing
        Me.TableAdapterManager.TimeOutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserCredsTableAdapter = Me.UserCredsTableAdapter
        '
        'ArchUserCredsTableAdapter
        '
        Me.ArchUserCredsTableAdapter.ClearBeforeFill = True
        '
        'TimeOutTableAdapter
        '
        Me.TimeOutTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Employee's Name"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 137
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Account_Level"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Account Level"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Account_Status"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Account Status"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 121
        '
        'Time_Date
        '
        Me.Time_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Time_Date.DataPropertyName = "Time_Date"
        Me.Time_Date.HeaderText = "Time and Date Archived"
        Me.Time_Date.MinimumWidth = 6
        Me.Time_Date.Name = "Time_Date"
        '
        'Staff_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.MODULE_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.btnArchiveShow)
        Me.Controls.Add(Me.btnUserShow)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.picDownReset)
        Me.Controls.Add(Me.picUpReset)
        Me.Controls.Add(Me.txtItemSearch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.UserCredsDataGridView)
        Me.Controls.Add(Me.ArchUserCredsDataGridView)
        Me.Controls.Add(Me.picUp)
        Me.Controls.Add(Me.picDown)
        Me.Controls.Add(Me.UserCredsBindingNavigator)
        Me.Controls.Add(Me.pnlReset)
        Me.Controls.Add(Me.pnlItems)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Staff_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User_Account"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UserCredsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserCredsBindingNavigator.ResumeLayout(False)
        Me.UserCredsBindingNavigator.PerformLayout()
        CType(Me.UserCredsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCredsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReset.ResumeLayout(False)
        Me.pnlReset.PerformLayout()
        CType(Me.picUpReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDownReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchUserCredsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchUserCredsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnStaffs As Button
    Friend WithEvents btnCredits As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picDown As PictureBox
    Friend WithEvents picUp As PictureBox
    Friend WithEvents pnlItems As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboAcctStat As ComboBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Inventory_Project_DatabaseDataSet As Inventory_Project_DatabaseDataSet
    Friend WithEvents UserCredsBindingSource As BindingSource
    Friend WithEvents UserCredsTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.UserCredsTableAdapter
    Friend WithEvents TableAdapterManager As Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserCredsBindingNavigator As BindingNavigator
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
    Friend WithEvents UserCredsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UserCredsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtItemSearch As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlReset As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnResetPass As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPassReset As TextBox
    Friend WithEvents txtUserIDReset As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents picDownReset As PictureBox
    Friend WithEvents picUpReset As PictureBox
    Friend WithEvents ArchUserCredsBindingSource As BindingSource
    Friend WithEvents ArchUserCredsTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.ArchUserCredsTableAdapter
    Friend WithEvents ArchUserCredsDataGridView As DataGridView
    Friend WithEvents btnArchiveShow As Button
    Friend WithEvents btnUserShow As Button
    Friend WithEvents TimeOutBindingSource As BindingSource
    Friend WithEvents TimeOutTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter
    Friend WithEvents TimeOutDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents btnTimeInOut As Button
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents Time_Date As DataGridViewTextBoxColumn
End Class
