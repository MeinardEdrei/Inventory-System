<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage_Module))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStaffs = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnTimeInOut = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Project_DatabaseDataSet = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSet()
        Me.TimeInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TimeInTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeInTableAdapter()
        Me.TimeOutTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReportForm = New System.Windows.Forms.Button()
        Me.TimeOutDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimeInDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblWelcomeRemarks = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeInDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnStaffs)
        Me.Panel1.Controls.Add(Me.btnCredits)
        Me.Panel1.Controls.Add(Me.btnInventory)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnTimeInOut)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 586)
        Me.Panel1.TabIndex = 4
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 517)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(6, 0, 8, 0)
        Me.btnLogout.Size = New System.Drawing.Size(251, 69)
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
        Me.btnStaffs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffs.Image = CType(resources.GetObject("btnStaffs.Image"), System.Drawing.Image)
        Me.btnStaffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaffs.Location = New System.Drawing.Point(0, 373)
        Me.btnStaffs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStaffs.Name = "btnStaffs"
        Me.btnStaffs.Padding = New System.Windows.Forms.Padding(6, 0, 8, 0)
        Me.btnStaffs.Size = New System.Drawing.Size(251, 69)
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
        Me.btnCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.Image = CType(resources.GetObject("btnCredits.Image"), System.Drawing.Image)
        Me.btnCredits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCredits.Location = New System.Drawing.Point(-2, 299)
        Me.btnCredits.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Padding = New System.Windows.Forms.Padding(6, 0, 8, 0)
        Me.btnCredits.Size = New System.Drawing.Size(251, 69)
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
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(-2, 225)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(6, 0, 8, 0)
        Me.btnInventory.Size = New System.Drawing.Size(251, 69)
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
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 151)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(6, 0, 8, 0)
        Me.btnHome.Size = New System.Drawing.Size(251, 69)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "  Homepage"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnTimeInOut
        '
        Me.btnTimeInOut.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeInOut.FlatAppearance.BorderSize = 0
        Me.btnTimeInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnTimeInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnTimeInOut.Image = CType(resources.GetObject("btnTimeInOut.Image"), System.Drawing.Image)
        Me.btnTimeInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimeInOut.Location = New System.Drawing.Point(2, 2)
        Me.btnTimeInOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTimeInOut.Name = "btnTimeInOut"
        Me.btnTimeInOut.Size = New System.Drawing.Size(249, 69)
        Me.btnTimeInOut.TabIndex = 0
        Me.btnTimeInOut.Text = "  Time In / Out"
        Me.btnTimeInOut.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
        'TimeInBindingSource
        '
        Me.TimeInBindingSource.DataMember = "TimeIn"
        Me.TimeInBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArchInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ArchUserCredsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CreditsArchTableAdapter = Nothing
        Me.TableAdapterManager.CreditsTableAdapter = Nothing
        Me.TableAdapterManager.In_TimeTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.MasterlistTableAdapter = Nothing
        Me.TableAdapterManager.OutTableAdapter = Nothing
        Me.TableAdapterManager.PaidCreditsTableAdapter = Nothing
        Me.TableAdapterManager.TimeInTableAdapter = Nothing
        Me.TableAdapterManager.TimeOutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserCredsTableAdapter = Nothing
        '
        'TimeInTableAdapter
        '
        Me.TimeInTableAdapter.ClearBeforeFill = True
        '
        'TimeOutTableAdapter
        '
        Me.TimeOutTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.btnReportForm)
        Me.Panel2.Controls.Add(Me.TimeOutDataGridView)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TimeInDataGridView)
        Me.Panel2.Controls.Add(Me.lblWelcomeRemarks)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(251, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 586)
        Me.Panel2.TabIndex = 5
        '
        'btnReportForm
        '
        Me.btnReportForm.BackgroundImage = CType(resources.GetObject("btnReportForm.BackgroundImage"), System.Drawing.Image)
        Me.btnReportForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportForm.FlatAppearance.BorderSize = 0
        Me.btnReportForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportForm.Location = New System.Drawing.Point(280, 517)
        Me.btnReportForm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReportForm.Name = "btnReportForm"
        Me.btnReportForm.Size = New System.Drawing.Size(200, 50)
        Me.btnReportForm.TabIndex = 10
        Me.btnReportForm.Text = "REPORT FORM"
        Me.btnReportForm.UseVisualStyleBackColor = True
        '
        'TimeOutDataGridView
        '
        Me.TimeOutDataGridView.AutoGenerateColumns = False
        Me.TimeOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeOutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TimeOutDataGridView.DataSource = Me.TimeOutBindingSource
        Me.TimeOutDataGridView.Location = New System.Drawing.Point(68, 336)
        Me.TimeOutDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TimeOutDataGridView.Name = "TimeOutDataGridView"
        Me.TimeOutDataGridView.RowHeadersWidth = 51
        Me.TimeOutDataGridView.RowTemplate.Height = 24
        Me.TimeOutDataGridView.Size = New System.Drawing.Size(628, 150)
        Me.TimeOutDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Staff's Name"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Time_out_Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date of Logout"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Time_out_Time"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time of Logout"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(495, 299)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Logout History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Login History"
        '
        'TimeInDataGridView
        '
        Me.TimeInDataGridView.AutoGenerateColumns = False
        Me.TimeInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeInDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TimeInDataGridView.DataSource = Me.TimeInBindingSource
        Me.TimeInDataGridView.Location = New System.Drawing.Point(68, 150)
        Me.TimeInDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TimeInDataGridView.Name = "TimeInDataGridView"
        Me.TimeInDataGridView.RowHeadersWidth = 51
        Me.TimeInDataGridView.RowTemplate.Height = 24
        Me.TimeInDataGridView.Size = New System.Drawing.Size(628, 150)
        Me.TimeInDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Staff's Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Time_in_Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date of Login"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Time_in_Time"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Time of Login"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'lblWelcomeRemarks
        '
        Me.lblWelcomeRemarks.AutoSize = True
        Me.lblWelcomeRemarks.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcomeRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeRemarks.ForeColor = System.Drawing.Color.White
        Me.lblWelcomeRemarks.Location = New System.Drawing.Point(430, 15)
        Me.lblWelcomeRemarks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcomeRemarks.Name = "lblWelcomeRemarks"
        Me.lblWelcomeRemarks.Size = New System.Drawing.Size(0, 25)
        Me.lblWelcomeRemarks.TabIndex = 5
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(20, 79)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 22)
        Me.lblTime.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Galapon Store"
        '
        'Homepage_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 586)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Homepage_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeInDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnStaffs As Button
    Friend WithEvents btnCredits As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnTimeInOut As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblWelcomeRemarks As Label
    Friend WithEvents Inventory_Project_DatabaseDataSet As Inventory_Project_DatabaseDataSet
    Friend WithEvents TableAdapterManager As Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TimeInBindingSource As BindingSource
    Friend WithEvents TimeInTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeInTableAdapter
    Friend WithEvents TimeInDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TimeOutBindingSource As BindingSource
    Friend WithEvents TimeOutTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter
    Friend WithEvents TimeOutDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents btnReportForm As Button
End Class
