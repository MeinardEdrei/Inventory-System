<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report_Module))
        Me.ArchInventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.ArchUserCredsDataGridView = New System.Windows.Forms.DataGridView()
        Me.CreditsDataGridView = New System.Windows.Forms.DataGridView()
        Me.CreditsArchDataGridView = New System.Windows.Forms.DataGridView()
        Me.In_TimeDataGridView = New System.Windows.Forms.DataGridView()
        Me.InventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.OutDataGridView = New System.Windows.Forms.DataGridView()
        Me.PaidCreditsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TimeOutDataGridView = New System.Windows.Forms.DataGridView()
        Me.UserCredsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TimeInDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnInventoryShow = New System.Windows.Forms.Button()
        Me.btnArchInventoryShow = New System.Windows.Forms.Button()
        Me.btnCreditShow = New System.Windows.Forms.Button()
        Me.btnArchCreditShow = New System.Windows.Forms.Button()
        Me.btnMasterlistShow = New System.Windows.Forms.Button()
        Me.btnPaidShow = New System.Windows.Forms.Button()
        Me.btnTimeOutHistory = New System.Windows.Forms.Button()
        Me.btnTimeInHistory = New System.Windows.Forms.Button()
        Me.btnLogoutHistory = New System.Windows.Forms.Button()
        Me.btnLoginHistory = New System.Windows.Forms.Button()
        Me.btnArchUser = New System.Windows.Forms.Button()
        Me.btnUserDetails = New System.Windows.Forms.Button()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnHomepage = New System.Windows.Forms.Button()
        Me.MasterlistDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Project_DatabaseDataSet = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSet()
        Me.MasterlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserCredsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidCreditsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.In_TimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditsArchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArchUserCredsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArchInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArchInventoryTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.ArchInventoryTableAdapter()
        Me.TableAdapterManager = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ArchUserCredsTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.ArchUserCredsTableAdapter()
        Me.CreditsArchTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.CreditsArchTableAdapter()
        Me.CreditsTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.CreditsTableAdapter()
        Me.In_TimeTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.In_TimeTableAdapter()
        Me.InventoryTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.InventoryTableAdapter()
        Me.OutTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.OutTableAdapter()
        Me.PaidCreditsTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.PaidCreditsTableAdapter()
        Me.TimeInTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeInTableAdapter()
        Me.TimeOutTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter()
        Me.UserCredsTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.UserCredsTableAdapter()
        Me.MasterlistTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.MasterlistTableAdapter()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ArchInventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchUserCredsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditsArchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.In_TimeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaidCreditsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCredsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeInDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterlistDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCredsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaidCreditsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.In_TimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditsArchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchUserCredsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArchInventoryDataGridView
        '
        Me.ArchInventoryDataGridView.AutoGenerateColumns = False
        Me.ArchInventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArchInventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.ArchInventoryDataGridView.DataSource = Me.ArchInventoryBindingSource
        Me.ArchInventoryDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.ArchInventoryDataGridView.Name = "ArchInventoryDataGridView"
        Me.ArchInventoryDataGridView.RowHeadersWidth = 51
        Me.ArchInventoryDataGridView.RowTemplate.Height = 24
        Me.ArchInventoryDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.ArchInventoryDataGridView.TabIndex = 1
        '
        'ArchUserCredsDataGridView
        '
        Me.ArchUserCredsDataGridView.AutoGenerateColumns = False
        Me.ArchUserCredsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArchUserCredsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.ArchUserCredsDataGridView.DataSource = Me.ArchUserCredsBindingSource
        Me.ArchUserCredsDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.ArchUserCredsDataGridView.Name = "ArchUserCredsDataGridView"
        Me.ArchUserCredsDataGridView.RowHeadersWidth = 51
        Me.ArchUserCredsDataGridView.RowTemplate.Height = 24
        Me.ArchUserCredsDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.ArchUserCredsDataGridView.TabIndex = 2
        '
        'CreditsDataGridView
        '
        Me.CreditsDataGridView.AutoGenerateColumns = False
        Me.CreditsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreditsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn20})
        Me.CreditsDataGridView.DataSource = Me.CreditsBindingSource
        Me.CreditsDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.CreditsDataGridView.Name = "CreditsDataGridView"
        Me.CreditsDataGridView.RowHeadersWidth = 51
        Me.CreditsDataGridView.RowTemplate.Height = 24
        Me.CreditsDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.CreditsDataGridView.TabIndex = 3
        '
        'CreditsArchDataGridView
        '
        Me.CreditsArchDataGridView.AutoGenerateColumns = False
        Me.CreditsArchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreditsArchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn27})
        Me.CreditsArchDataGridView.DataSource = Me.CreditsArchBindingSource
        Me.CreditsArchDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.CreditsArchDataGridView.Name = "CreditsArchDataGridView"
        Me.CreditsArchDataGridView.RowHeadersWidth = 51
        Me.CreditsArchDataGridView.RowTemplate.Height = 24
        Me.CreditsArchDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.CreditsArchDataGridView.TabIndex = 4
        '
        'In_TimeDataGridView
        '
        Me.In_TimeDataGridView.AutoGenerateColumns = False
        Me.In_TimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.In_TimeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.In_TimeDataGridView.DataSource = Me.In_TimeBindingSource
        Me.In_TimeDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.In_TimeDataGridView.Name = "In_TimeDataGridView"
        Me.In_TimeDataGridView.RowHeadersWidth = 51
        Me.In_TimeDataGridView.RowTemplate.Height = 24
        Me.In_TimeDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.In_TimeDataGridView.TabIndex = 5
        '
        'InventoryDataGridView
        '
        Me.InventoryDataGridView.AutoGenerateColumns = False
        Me.InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36})
        Me.InventoryDataGridView.DataSource = Me.InventoryBindingSource
        Me.InventoryDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.InventoryDataGridView.Name = "InventoryDataGridView"
        Me.InventoryDataGridView.RowHeadersWidth = 51
        Me.InventoryDataGridView.RowTemplate.Height = 24
        Me.InventoryDataGridView.Size = New System.Drawing.Size(1104, 290)
        Me.InventoryDataGridView.TabIndex = 6
        '
        'OutDataGridView
        '
        Me.OutDataGridView.AutoGenerateColumns = False
        Me.OutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40})
        Me.OutDataGridView.DataSource = Me.OutBindingSource
        Me.OutDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.OutDataGridView.Name = "OutDataGridView"
        Me.OutDataGridView.RowHeadersWidth = 51
        Me.OutDataGridView.RowTemplate.Height = 24
        Me.OutDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.OutDataGridView.TabIndex = 7
        '
        'PaidCreditsDataGridView
        '
        Me.PaidCreditsDataGridView.AutoGenerateColumns = False
        Me.PaidCreditsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaidCreditsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46})
        Me.PaidCreditsDataGridView.DataSource = Me.PaidCreditsBindingSource
        Me.PaidCreditsDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.PaidCreditsDataGridView.Name = "PaidCreditsDataGridView"
        Me.PaidCreditsDataGridView.RowHeadersWidth = 51
        Me.PaidCreditsDataGridView.RowTemplate.Height = 24
        Me.PaidCreditsDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.PaidCreditsDataGridView.TabIndex = 8
        '
        'TimeOutDataGridView
        '
        Me.TimeOutDataGridView.AutoGenerateColumns = False
        Me.TimeOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeOutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58})
        Me.TimeOutDataGridView.DataSource = Me.TimeOutBindingSource
        Me.TimeOutDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.TimeOutDataGridView.Name = "TimeOutDataGridView"
        Me.TimeOutDataGridView.RowHeadersWidth = 51
        Me.TimeOutDataGridView.RowTemplate.Height = 24
        Me.TimeOutDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.TimeOutDataGridView.TabIndex = 11
        '
        'UserCredsDataGridView
        '
        Me.UserCredsDataGridView.AutoGenerateColumns = False
        Me.UserCredsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserCredsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63})
        Me.UserCredsDataGridView.DataSource = Me.UserCredsBindingSource
        Me.UserCredsDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.UserCredsDataGridView.Name = "UserCredsDataGridView"
        Me.UserCredsDataGridView.RowHeadersWidth = 51
        Me.UserCredsDataGridView.RowTemplate.Height = 24
        Me.UserCredsDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.UserCredsDataGridView.TabIndex = 12
        '
        'TimeInDataGridView
        '
        Me.TimeInDataGridView.AutoGenerateColumns = False
        Me.TimeInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeInDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54})
        Me.TimeInDataGridView.DataSource = Me.TimeInBindingSource
        Me.TimeInDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.TimeInDataGridView.Name = "TimeInDataGridView"
        Me.TimeInDataGridView.RowHeadersWidth = 51
        Me.TimeInDataGridView.RowTemplate.Height = 24
        Me.TimeInDataGridView.Size = New System.Drawing.Size(1105, 290)
        Me.TimeInDataGridView.TabIndex = 10
        '
        'btnInventoryShow
        '
        Me.btnInventoryShow.FlatAppearance.BorderSize = 0
        Me.btnInventoryShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventoryShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryShow.Location = New System.Drawing.Point(122, 80)
        Me.btnInventoryShow.Name = "btnInventoryShow"
        Me.btnInventoryShow.Size = New System.Drawing.Size(184, 35)
        Me.btnInventoryShow.TabIndex = 16
        Me.btnInventoryShow.Text = "Inventory"
        Me.btnInventoryShow.UseVisualStyleBackColor = True
        '
        'btnArchInventoryShow
        '
        Me.btnArchInventoryShow.FlatAppearance.BorderSize = 0
        Me.btnArchInventoryShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArchInventoryShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchInventoryShow.Location = New System.Drawing.Point(306, 80)
        Me.btnArchInventoryShow.Name = "btnArchInventoryShow"
        Me.btnArchInventoryShow.Size = New System.Drawing.Size(184, 35)
        Me.btnArchInventoryShow.TabIndex = 17
        Me.btnArchInventoryShow.Text = "Archived Inventory"
        Me.btnArchInventoryShow.UseVisualStyleBackColor = True
        '
        'btnCreditShow
        '
        Me.btnCreditShow.FlatAppearance.BorderSize = 0
        Me.btnCreditShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreditShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditShow.Location = New System.Drawing.Point(490, 80)
        Me.btnCreditShow.Name = "btnCreditShow"
        Me.btnCreditShow.Size = New System.Drawing.Size(184, 35)
        Me.btnCreditShow.TabIndex = 18
        Me.btnCreditShow.Text = "Credit"
        Me.btnCreditShow.UseVisualStyleBackColor = True
        '
        'btnArchCreditShow
        '
        Me.btnArchCreditShow.FlatAppearance.BorderSize = 0
        Me.btnArchCreditShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArchCreditShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchCreditShow.Location = New System.Drawing.Point(674, 80)
        Me.btnArchCreditShow.Name = "btnArchCreditShow"
        Me.btnArchCreditShow.Size = New System.Drawing.Size(184, 35)
        Me.btnArchCreditShow.TabIndex = 19
        Me.btnArchCreditShow.Text = "Archived Credits"
        Me.btnArchCreditShow.UseVisualStyleBackColor = True
        '
        'btnMasterlistShow
        '
        Me.btnMasterlistShow.FlatAppearance.BorderSize = 0
        Me.btnMasterlistShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasterlistShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasterlistShow.Location = New System.Drawing.Point(1042, 80)
        Me.btnMasterlistShow.Name = "btnMasterlistShow"
        Me.btnMasterlistShow.Size = New System.Drawing.Size(184, 35)
        Me.btnMasterlistShow.TabIndex = 21
        Me.btnMasterlistShow.Text = "Masterlist"
        Me.btnMasterlistShow.UseVisualStyleBackColor = True
        '
        'btnPaidShow
        '
        Me.btnPaidShow.FlatAppearance.BorderSize = 0
        Me.btnPaidShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPaidShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaidShow.Location = New System.Drawing.Point(858, 80)
        Me.btnPaidShow.Name = "btnPaidShow"
        Me.btnPaidShow.Size = New System.Drawing.Size(184, 35)
        Me.btnPaidShow.TabIndex = 20
        Me.btnPaidShow.Text = "Paid Credits"
        Me.btnPaidShow.UseVisualStyleBackColor = True
        '
        'btnTimeOutHistory
        '
        Me.btnTimeOutHistory.FlatAppearance.BorderSize = 0
        Me.btnTimeOutHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTimeOutHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOutHistory.Location = New System.Drawing.Point(1042, 416)
        Me.btnTimeOutHistory.Name = "btnTimeOutHistory"
        Me.btnTimeOutHistory.Size = New System.Drawing.Size(184, 35)
        Me.btnTimeOutHistory.TabIndex = 27
        Me.btnTimeOutHistory.Text = "Time Out History"
        Me.btnTimeOutHistory.UseVisualStyleBackColor = True
        '
        'btnTimeInHistory
        '
        Me.btnTimeInHistory.FlatAppearance.BorderSize = 0
        Me.btnTimeInHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTimeInHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeInHistory.Location = New System.Drawing.Point(858, 416)
        Me.btnTimeInHistory.Name = "btnTimeInHistory"
        Me.btnTimeInHistory.Size = New System.Drawing.Size(184, 35)
        Me.btnTimeInHistory.TabIndex = 26
        Me.btnTimeInHistory.Text = "Time In History"
        Me.btnTimeInHistory.UseVisualStyleBackColor = True
        '
        'btnLogoutHistory
        '
        Me.btnLogoutHistory.FlatAppearance.BorderSize = 0
        Me.btnLogoutHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogoutHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoutHistory.Location = New System.Drawing.Point(674, 416)
        Me.btnLogoutHistory.Name = "btnLogoutHistory"
        Me.btnLogoutHistory.Size = New System.Drawing.Size(184, 35)
        Me.btnLogoutHistory.TabIndex = 25
        Me.btnLogoutHistory.Text = "Logout History"
        Me.btnLogoutHistory.UseVisualStyleBackColor = True
        '
        'btnLoginHistory
        '
        Me.btnLoginHistory.FlatAppearance.BorderSize = 0
        Me.btnLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoginHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginHistory.Location = New System.Drawing.Point(490, 416)
        Me.btnLoginHistory.Name = "btnLoginHistory"
        Me.btnLoginHistory.Size = New System.Drawing.Size(184, 35)
        Me.btnLoginHistory.TabIndex = 24
        Me.btnLoginHistory.Text = "Login History"
        Me.btnLoginHistory.UseVisualStyleBackColor = True
        '
        'btnArchUser
        '
        Me.btnArchUser.FlatAppearance.BorderSize = 0
        Me.btnArchUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArchUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchUser.Location = New System.Drawing.Point(306, 416)
        Me.btnArchUser.Name = "btnArchUser"
        Me.btnArchUser.Size = New System.Drawing.Size(184, 35)
        Me.btnArchUser.TabIndex = 23
        Me.btnArchUser.Text = "Archived User Details"
        Me.btnArchUser.UseVisualStyleBackColor = True
        '
        'btnUserDetails
        '
        Me.btnUserDetails.FlatAppearance.BorderSize = 0
        Me.btnUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUserDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserDetails.Location = New System.Drawing.Point(122, 416)
        Me.btnUserDetails.Name = "btnUserDetails"
        Me.btnUserDetails.Size = New System.Drawing.Size(184, 35)
        Me.btnUserDetails.TabIndex = 22
        Me.btnUserDetails.Text = "User Details"
        Me.btnUserDetails.UseVisualStyleBackColor = True
        '
        'btnPrintReport
        '
        Me.btnPrintReport.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintReport.BackgroundImage = CType(resources.GetObject("btnPrintReport.BackgroundImage"), System.Drawing.Image)
        Me.btnPrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintReport.FlatAppearance.BorderSize = 0
        Me.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReport.Location = New System.Drawing.Point(411, 577)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(230, 61)
        Me.btnPrintReport.TabIndex = 28
        Me.btnPrintReport.Text = "EXPORT ALL"
        Me.btnPrintReport.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(708, 577)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(230, 61)
        Me.btnPrint.TabIndex = 29
        Me.btnPrint.Text = "PRINT FORM"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnHomepage
        '
        Me.btnHomepage.BackColor = System.Drawing.Color.Transparent
        Me.btnHomepage.BackgroundImage = CType(resources.GetObject("btnHomepage.BackgroundImage"), System.Drawing.Image)
        Me.btnHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHomepage.FlatAppearance.BorderSize = 0
        Me.btnHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomepage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomepage.Location = New System.Drawing.Point(1005, 577)
        Me.btnHomepage.Name = "btnHomepage"
        Me.btnHomepage.Size = New System.Drawing.Size(230, 61)
        Me.btnHomepage.TabIndex = 30
        Me.btnHomepage.Text = "HOMEPAGE"
        Me.btnHomepage.UseVisualStyleBackColor = False
        '
        'MasterlistDataGridView
        '
        Me.MasterlistDataGridView.AutoGenerateColumns = False
        Me.MasterlistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MasterlistDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.ProdCategory})
        Me.MasterlistDataGridView.DataSource = Me.MasterlistBindingSource
        Me.MasterlistDataGridView.Location = New System.Drawing.Point(122, 120)
        Me.MasterlistDataGridView.Name = "MasterlistDataGridView"
        Me.MasterlistDataGridView.RowHeadersWidth = 51
        Me.MasterlistDataGridView.RowTemplate.Height = 24
        Me.MasterlistDataGridView.Size = New System.Drawing.Size(1104, 290)
        Me.MasterlistDataGridView.TabIndex = 30
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(114, 577)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(230, 61)
        Me.btnExport.TabIndex = 31
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "ProdID"
        Me.DataGridViewTextBoxColumn32.HeaderText = "ProdID"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 80
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "ProdName"
        Me.DataGridViewTextBoxColumn33.HeaderText = "ProdName"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "ProdPrice"
        Me.DataGridViewTextBoxColumn34.HeaderText = "ProdPrice"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 99
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "ProdQuantity"
        Me.DataGridViewTextBoxColumn35.HeaderText = "ProdQuantity"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 120
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "ProdCategory"
        Me.DataGridViewTextBoxColumn36.HeaderText = "ProdCategory"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 124
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'Inventory_Project_DatabaseDataSet
        '
        Me.Inventory_Project_DatabaseDataSet.DataSetName = "Inventory_Project_DatabaseDataSet"
        Me.Inventory_Project_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterlistBindingSource
        '
        Me.MasterlistBindingSource.DataMember = "Masterlist"
        Me.MasterlistBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn64.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn64.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Fname"
        Me.DataGridViewTextBoxColumn59.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn60.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn60.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn61.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn61.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "Account_Level"
        Me.DataGridViewTextBoxColumn62.HeaderText = "Account_Level"
        Me.DataGridViewTextBoxColumn62.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "Account_Status"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Account_Status"
        Me.DataGridViewTextBoxColumn63.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'UserCredsBindingSource
        '
        Me.UserCredsBindingSource.DataMember = "UserCreds"
        Me.UserCredsBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn55.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn55.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn56.HeaderText = "Name_Staff"
        Me.DataGridViewTextBoxColumn56.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "Time_out_Date"
        Me.DataGridViewTextBoxColumn57.HeaderText = "Time_out_Date"
        Me.DataGridViewTextBoxColumn57.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Time_out_Time"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Time_out_Time"
        Me.DataGridViewTextBoxColumn58.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'TimeOutBindingSource
        '
        Me.TimeOutBindingSource.DataMember = "TimeOut"
        Me.TimeOutBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn51.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn51.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Name_Staff"
        Me.DataGridViewTextBoxColumn52.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "Time_in_Date"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Time_in_Date"
        Me.DataGridViewTextBoxColumn53.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Time_in_Time"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Time_in_Time"
        Me.DataGridViewTextBoxColumn54.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'TimeInBindingSource
        '
        Me.TimeInBindingSource.DataMember = "TimeIn"
        Me.TimeInBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Credit_ID"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Credit_ID"
        Me.DataGridViewTextBoxColumn41.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 95
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Name_Credit"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Name_Credit"
        Me.DataGridViewTextBoxColumn42.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "Amount_Due"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Amount_Due"
        Me.DataGridViewTextBoxColumn43.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "Due_Date"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Due_Date"
        Me.DataGridViewTextBoxColumn44.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn45.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "Time_Date"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Time_Date"
        Me.DataGridViewTextBoxColumn46.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'PaidCreditsBindingSource
        '
        Me.PaidCreditsBindingSource.DataMember = "PaidCredits"
        Me.PaidCreditsBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn37.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Staff_Name"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Staff_Name"
        Me.DataGridViewTextBoxColumn38.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Time_Out"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Time_Out"
        Me.DataGridViewTextBoxColumn39.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Date_Out"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Date_Out"
        Me.DataGridViewTextBoxColumn40.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'OutBindingSource
        '
        Me.OutBindingSource.DataMember = "Out"
        Me.OutBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn28.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Staff_Name"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Staff_Name"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Time_In"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Time_In"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Date_In"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Date_In"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'In_TimeBindingSource
        '
        Me.In_TimeBindingSource.DataMember = "In_Time"
        Me.In_TimeBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn26.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Credit_ID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Credit_ID"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Name_Credit"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Name_Credit"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Due_Date"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Due_Date"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Time_Date"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Time_Date"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'CreditsArchBindingSource
        '
        Me.CreditsArchBindingSource.DataMember = "CreditsArch"
        Me.CreditsArchBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Credit_ID"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Credit_ID"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Name_Credit"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Name_Credit"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Due_Date"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Due_Date"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'CreditsBindingSource
        '
        Me.CreditsBindingSource.DataMember = "Credits"
        Me.CreditsBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fname"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Account_Level"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Account_Level"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Account_Status"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Account_Status"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Time_Date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Time_Date"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'ArchUserCredsBindingSource
        '
        Me.ArchUserCredsBindingSource.DataMember = "ArchUserCreds"
        Me.ArchUserCredsBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProdID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProdID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProdName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProdName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProdPrice"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProdPrice"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProdQuantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProdQuantity"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProdCategory"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ProdCategory"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Time_Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time_Date"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ArchInventoryBindingSource
        '
        Me.ArchInventoryBindingSource.DataMember = "ArchInventory"
        Me.ArchInventoryBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'ArchInventoryTableAdapter
        '
        Me.ArchInventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArchInventoryTableAdapter = Me.ArchInventoryTableAdapter
        Me.TableAdapterManager.ArchUserCredsTableAdapter = Me.ArchUserCredsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CreditsArchTableAdapter = Me.CreditsArchTableAdapter
        Me.TableAdapterManager.CreditsTableAdapter = Me.CreditsTableAdapter
        Me.TableAdapterManager.In_TimeTableAdapter = Me.In_TimeTableAdapter
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.MasterlistTableAdapter = Nothing
        Me.TableAdapterManager.OutTableAdapter = Me.OutTableAdapter
        Me.TableAdapterManager.PaidCreditsTableAdapter = Me.PaidCreditsTableAdapter
        Me.TableAdapterManager.TimeInTableAdapter = Me.TimeInTableAdapter
        Me.TableAdapterManager.TimeOutTableAdapter = Me.TimeOutTableAdapter
        Me.TableAdapterManager.UpdateOrder = Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserCredsTableAdapter = Me.UserCredsTableAdapter
        '
        'ArchUserCredsTableAdapter
        '
        Me.ArchUserCredsTableAdapter.ClearBeforeFill = True
        '
        'CreditsArchTableAdapter
        '
        Me.CreditsArchTableAdapter.ClearBeforeFill = True
        '
        'CreditsTableAdapter
        '
        Me.CreditsTableAdapter.ClearBeforeFill = True
        '
        'In_TimeTableAdapter
        '
        Me.In_TimeTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'OutTableAdapter
        '
        Me.OutTableAdapter.ClearBeforeFill = True
        '
        'PaidCreditsTableAdapter
        '
        Me.PaidCreditsTableAdapter.ClearBeforeFill = True
        '
        'TimeInTableAdapter
        '
        Me.TimeInTableAdapter.ClearBeforeFill = True
        '
        'TimeOutTableAdapter
        '
        Me.TimeOutTableAdapter.ClearBeforeFill = True
        '
        'UserCredsTableAdapter
        '
        Me.UserCredsTableAdapter.ClearBeforeFill = True
        '
        'MasterlistTableAdapter
        '
        Me.MasterlistTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "ProdID"
        Me.DataGridViewTextBoxColumn47.HeaderText = "ProdID"
        Me.DataGridViewTextBoxColumn47.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "ProdName"
        Me.DataGridViewTextBoxColumn48.HeaderText = "ProdName"
        Me.DataGridViewTextBoxColumn48.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'ProdCategory
        '
        Me.ProdCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdCategory.DataPropertyName = "ProdCategory"
        Me.ProdCategory.HeaderText = "ProdCategory"
        Me.ProdCategory.MinimumWidth = 6
        Me.ProdCategory.Name = "ProdCategory"
        '
        'Report_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.CPG_MODULES
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 742)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.InventoryDataGridView)
        Me.Controls.Add(Me.MasterlistDataGridView)
        Me.Controls.Add(Me.btnHomepage)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.btnTimeOutHistory)
        Me.Controls.Add(Me.btnTimeInHistory)
        Me.Controls.Add(Me.btnLogoutHistory)
        Me.Controls.Add(Me.btnLoginHistory)
        Me.Controls.Add(Me.btnArchUser)
        Me.Controls.Add(Me.btnUserDetails)
        Me.Controls.Add(Me.btnMasterlistShow)
        Me.Controls.Add(Me.btnPaidShow)
        Me.Controls.Add(Me.btnArchCreditShow)
        Me.Controls.Add(Me.btnCreditShow)
        Me.Controls.Add(Me.btnArchInventoryShow)
        Me.Controls.Add(Me.btnInventoryShow)
        Me.Controls.Add(Me.UserCredsDataGridView)
        Me.Controls.Add(Me.TimeOutDataGridView)
        Me.Controls.Add(Me.TimeInDataGridView)
        Me.Controls.Add(Me.PaidCreditsDataGridView)
        Me.Controls.Add(Me.OutDataGridView)
        Me.Controls.Add(Me.In_TimeDataGridView)
        Me.Controls.Add(Me.CreditsArchDataGridView)
        Me.Controls.Add(Me.CreditsDataGridView)
        Me.Controls.Add(Me.ArchUserCredsDataGridView)
        Me.Controls.Add(Me.ArchInventoryDataGridView)
        Me.Name = "Report_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.ArchInventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchUserCredsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditsArchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.In_TimeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaidCreditsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCredsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeInDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterlistDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCredsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaidCreditsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.In_TimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditsArchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchUserCredsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Inventory_Project_DatabaseDataSet As Inventory_Project_DatabaseDataSet
    Friend WithEvents ArchInventoryBindingSource As BindingSource
    Friend WithEvents ArchInventoryTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.ArchInventoryTableAdapter
    Friend WithEvents TableAdapterManager As Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArchInventoryDataGridView As DataGridView
    Friend WithEvents ArchUserCredsTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.ArchUserCredsTableAdapter
    Friend WithEvents ArchUserCredsBindingSource As BindingSource
    Friend WithEvents CreditsTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.CreditsTableAdapter
    Friend WithEvents ArchUserCredsDataGridView As DataGridView
    Friend WithEvents CreditsBindingSource As BindingSource
    Friend WithEvents CreditsArchTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.CreditsArchTableAdapter
    Friend WithEvents CreditsDataGridView As DataGridView
    Friend WithEvents CreditsArchBindingSource As BindingSource
    Friend WithEvents In_TimeTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.In_TimeTableAdapter
    Friend WithEvents CreditsArchDataGridView As DataGridView
    Friend WithEvents In_TimeBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents In_TimeDataGridView As DataGridView
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents OutTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.OutTableAdapter
    Friend WithEvents InventoryDataGridView As DataGridView
    Friend WithEvents OutBindingSource As BindingSource
    Friend WithEvents PaidCreditsTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.PaidCreditsTableAdapter
    Friend WithEvents OutDataGridView As DataGridView
    Friend WithEvents PaidCreditsBindingSource As BindingSource
    Friend WithEvents PaidCreditsDataGridView As DataGridView
    Friend WithEvents TimeInTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeInTableAdapter
    Friend WithEvents TimeInBindingSource As BindingSource
    Friend WithEvents TimeOutTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter
    Friend WithEvents TimeOutBindingSource As BindingSource
    Friend WithEvents UserCredsTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.UserCredsTableAdapter
    Friend WithEvents TimeOutDataGridView As DataGridView
    Friend WithEvents UserCredsBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents UserCredsDataGridView As DataGridView
    Friend WithEvents TimeInDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents btnInventoryShow As Button
    Friend WithEvents btnArchInventoryShow As Button
    Friend WithEvents btnCreditShow As Button
    Friend WithEvents btnArchCreditShow As Button
    Friend WithEvents btnMasterlistShow As Button
    Friend WithEvents btnPaidShow As Button
    Friend WithEvents btnTimeOutHistory As Button
    Friend WithEvents btnTimeInHistory As Button
    Friend WithEvents btnLogoutHistory As Button
    Friend WithEvents btnLoginHistory As Button
    Friend WithEvents btnArchUser As Button
    Friend WithEvents btnUserDetails As Button
    Friend WithEvents btnPrintReport As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnHomepage As Button
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents MasterlistBindingSource As BindingSource
    Friend WithEvents MasterlistTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.MasterlistTableAdapter
    Friend WithEvents MasterlistDataGridView As DataGridView
    Friend WithEvents btnExport As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents ProdCategory As DataGridViewTextBoxColumn
End Class
