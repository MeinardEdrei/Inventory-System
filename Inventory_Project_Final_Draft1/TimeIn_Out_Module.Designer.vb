<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeIn_Out_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimeIn_Out_Module))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.In_TimeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.In_TimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Project_DatabaseDataSet = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSet()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnTimeOut = New System.Windows.Forms.Button()
        Me.OutDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnTimeIn = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStaffs = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTimeInOut = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TimeInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OutTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.OutTableAdapter()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.In_TimeTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.In_TimeTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.In_TimeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.In_TimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.In_TimeDataGridView)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.btnTimeOut)
        Me.Panel2.Controls.Add(Me.OutDataGridView)
        Me.Panel2.Controls.Add(Me.btnTimeIn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(251, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 586)
        Me.Panel2.TabIndex = 7
        '
        'In_TimeDataGridView
        '
        Me.In_TimeDataGridView.AutoGenerateColumns = False
        Me.In_TimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.In_TimeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.In_TimeDataGridView.DataSource = Me.In_TimeBindingSource
        Me.In_TimeDataGridView.Location = New System.Drawing.Point(27, 82)
        Me.In_TimeDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.In_TimeDataGridView.Name = "In_TimeDataGridView"
        Me.In_TimeDataGridView.RowHeadersWidth = 51
        Me.In_TimeDataGridView.RowTemplate.Height = 24
        Me.In_TimeDataGridView.Size = New System.Drawing.Size(704, 179)
        Me.In_TimeDataGridView.TabIndex = 11
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Staff_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Staff's Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Time_In"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Time In"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date_In"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date In"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'In_TimeBindingSource
        '
        Me.In_TimeBindingSource.DataMember = "In_Time"
        Me.In_TimeBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'Inventory_Project_DatabaseDataSet
        '
        Me.Inventory_Project_DatabaseDataSet.DataSetName = "Inventory_Project_DatabaseDataSet"
        Me.Inventory_Project_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(568, 27)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 26)
        Me.lblTime.TabIndex = 11
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(23, 27)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 26)
        Me.lblDate.TabIndex = 10
        '
        'btnTimeOut
        '
        Me.btnTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeOut.BackgroundImage = CType(resources.GetObject("btnTimeOut.BackgroundImage"), System.Drawing.Image)
        Me.btnTimeOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimeOut.FlatAppearance.BorderSize = 0
        Me.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.Location = New System.Drawing.Point(323, 525)
        Me.btnTimeOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(113, 41)
        Me.btnTimeOut.TabIndex = 9
        Me.btnTimeOut.Text = "Time OUT"
        Me.btnTimeOut.UseVisualStyleBackColor = False
        '
        'OutDataGridView
        '
        Me.OutDataGridView.AutoGenerateColumns = False
        Me.OutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.OutDataGridView.DataSource = Me.OutBindingSource
        Me.OutDataGridView.Location = New System.Drawing.Point(27, 341)
        Me.OutDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OutDataGridView.Name = "OutDataGridView"
        Me.OutDataGridView.RowHeadersWidth = 51
        Me.OutDataGridView.RowTemplate.Height = 24
        Me.OutDataGridView.Size = New System.Drawing.Size(705, 179)
        Me.OutDataGridView.TabIndex = 8
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Staff_Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Staff's Name"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Time_Out"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time Out"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Date_Out"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Date Out"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'OutBindingSource
        '
        Me.OutBindingSource.DataMember = "Out"
        Me.OutBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'btnTimeIn
        '
        Me.btnTimeIn.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeIn.BackgroundImage = CType(resources.GetObject("btnTimeIn.BackgroundImage"), System.Drawing.Image)
        Me.btnTimeIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimeIn.FlatAppearance.BorderSize = 0
        Me.btnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIn.Location = New System.Drawing.Point(323, 266)
        Me.btnTimeIn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(113, 41)
        Me.btnTimeIn.TabIndex = 8
        Me.btnTimeIn.Text = "Time IN"
        Me.btnTimeIn.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 6
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
        Me.btnTimeInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTimeInOut.UseVisualStyleBackColor = False
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
        'TimeInBindingSource
        '
        Me.TimeInBindingSource.DataMember = "TimeIn"
        Me.TimeInBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'OutTableAdapter
        '
        Me.OutTableAdapter.ClearBeforeFill = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'In_TimeTableAdapter
        '
        Me.In_TimeTableAdapter.ClearBeforeFill = True
        '
        'TimeIn_Out_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 586)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TimeIn_Out_Module"
        Me.Text = "TimeIn_Out_Module"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.In_TimeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.In_TimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Inventory_Project_DatabaseDataSet As Inventory_Project_DatabaseDataSet
    Friend WithEvents TableAdapterManager As Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TimeInBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnStaffs As Button
    Friend WithEvents btnCredits As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTimeInOut As Button
    Friend WithEvents btnTimeIn As Button
    Friend WithEvents OutBindingSource As BindingSource
    Friend WithEvents OutTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.OutTableAdapter
    Friend WithEvents btnTimeOut As Button
    Friend WithEvents OutDataGridView As DataGridView
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents In_TimeBindingSource As BindingSource
    Friend WithEvents In_TimeTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.In_TimeTableAdapter
    Friend WithEvents In_TimeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
