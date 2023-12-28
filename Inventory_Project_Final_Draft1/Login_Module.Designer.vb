<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Module))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmailLogin = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.txtPassLogin = New System.Windows.Forms.TextBox()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.lblForgot = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeInDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_Project_DatabaseDataSet = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSet()
        Me.pnlReset = New System.Windows.Forms.Panel()
        Me.lblNoAccess = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodeReset = New System.Windows.Forms.TextBox()
        Me.lblGoBack = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmailReset = New System.Windows.Forms.TextBox()
        Me.btnSendOTP = New System.Windows.Forms.Button()
        Me.chkShowPassReset = New System.Windows.Forms.CheckBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TimeInTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeInTableAdapter()
        Me.TableAdapterManager = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TimeOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeOutTableAdapter = New Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter()
        Me.TimeOutDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        CType(Me.TimeInDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReset.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(149, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Password:"
        '
        'txtEmailLogin
        '
        Me.txtEmailLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txtEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailLogin.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtEmailLogin.Location = New System.Drawing.Point(38, 267)
        Me.txtEmailLogin.Name = "txtEmailLogin"
        Me.txtEmailLogin.Size = New System.Drawing.Size(422, 44)
        Me.txtEmailLogin.TabIndex = 0
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnSignIn.Location = New System.Drawing.Point(157, 531)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(195, 64)
        Me.btnSignIn.TabIndex = 13
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPass.ForeColor = System.Drawing.Color.White
        Me.chkShowPass.Location = New System.Drawing.Point(38, 434)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(192, 28)
        Me.chkShowPass.TabIndex = 4
        Me.chkShowPass.Text = "Show Password"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'txtPassLogin
        '
        Me.txtPassLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txtPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassLogin.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtPassLogin.Location = New System.Drawing.Point(38, 385)
        Me.txtPassLogin.Name = "txtPassLogin"
        Me.txtPassLogin.Size = New System.Drawing.Size(422, 44)
        Me.txtPassLogin.TabIndex = 2
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnlLogin.Controls.Add(Me.lblForgot)
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Controls.Add(Me.PictureBox1)
        Me.pnlLogin.Controls.Add(Me.Label3)
        Me.pnlLogin.Controls.Add(Me.TimeOutDataGridView)
        Me.pnlLogin.Controls.Add(Me.Label4)
        Me.pnlLogin.Controls.Add(Me.txtEmailLogin)
        Me.pnlLogin.Controls.Add(Me.btnSignIn)
        Me.pnlLogin.Controls.Add(Me.chkShowPass)
        Me.pnlLogin.Controls.Add(Me.txtPassLogin)
        Me.pnlLogin.Controls.Add(Me.TimeInDataGridView)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlLogin.Location = New System.Drawing.Point(848, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(500, 721)
        Me.pnlLogin.TabIndex = 4
        '
        'lblForgot
        '
        Me.lblForgot.ActiveLinkColor = System.Drawing.Color.White
        Me.lblForgot.AutoSize = True
        Me.lblForgot.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgot.ForeColor = System.Drawing.Color.White
        Me.lblForgot.LinkColor = System.Drawing.Color.White
        Me.lblForgot.Location = New System.Drawing.Point(102, 648)
        Me.lblForgot.Name = "lblForgot"
        Me.lblForgot.Size = New System.Drawing.Size(304, 20)
        Me.lblForgot.TabIndex = 16
        Me.lblForgot.TabStop = True
        Me.lblForgot.Text = "Forgot your Password? Click Here"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(130, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 39)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Galapon Store"
        '
        'TimeInDataGridView
        '
        Me.TimeInDataGridView.AutoGenerateColumns = False
        Me.TimeInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeInDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TimeInDataGridView.DataSource = Me.TimeInBindingSource
        Me.TimeInDataGridView.Location = New System.Drawing.Point(184, 67)
        Me.TimeInDataGridView.Name = "TimeInDataGridView"
        Me.TimeInDataGridView.RowHeadersWidth = 51
        Me.TimeInDataGridView.RowTemplate.Height = 24
        Me.TimeInDataGridView.Size = New System.Drawing.Size(32, 43)
        Me.TimeInDataGridView.TabIndex = 18
        Me.TimeInDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name_Staff"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Time_in_Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Time_in_Date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Time_in_Time"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Time_in_Time"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'TimeInBindingSource
        '
        Me.TimeInBindingSource.DataMember = "TimeIn"
        Me.TimeInBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'Inventory_Project_DatabaseDataSet
        '
        Me.Inventory_Project_DatabaseDataSet.DataSetName = "Inventory_Project_DatabaseDataSet"
        Me.Inventory_Project_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlReset
        '
        Me.pnlReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnlReset.Controls.Add(Me.lblNoAccess)
        Me.pnlReset.Controls.Add(Me.Label7)
        Me.pnlReset.Controls.Add(Me.txtCodeReset)
        Me.pnlReset.Controls.Add(Me.lblGoBack)
        Me.pnlReset.Controls.Add(Me.Label2)
        Me.pnlReset.Controls.Add(Me.PictureBox2)
        Me.pnlReset.Controls.Add(Me.Label5)
        Me.pnlReset.Controls.Add(Me.Label6)
        Me.pnlReset.Controls.Add(Me.txtEmailReset)
        Me.pnlReset.Controls.Add(Me.btnSendOTP)
        Me.pnlReset.Controls.Add(Me.chkShowPassReset)
        Me.pnlReset.Controls.Add(Me.txtNewPassword)
        Me.pnlReset.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlReset.Location = New System.Drawing.Point(0, 0)
        Me.pnlReset.Name = "pnlReset"
        Me.pnlReset.Size = New System.Drawing.Size(500, 721)
        Me.pnlReset.TabIndex = 5
        '
        'lblNoAccess
        '
        Me.lblNoAccess.ActiveLinkColor = System.Drawing.Color.White
        Me.lblNoAccess.AutoSize = True
        Me.lblNoAccess.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoAccess.ForeColor = System.Drawing.Color.White
        Me.lblNoAccess.LinkColor = System.Drawing.Color.White
        Me.lblNoAccess.Location = New System.Drawing.Point(88, 682)
        Me.lblNoAccess.Name = "lblNoAccess"
        Me.lblNoAccess.Size = New System.Drawing.Size(325, 20)
        Me.lblNoAccess.TabIndex = 19
        Me.lblNoAccess.TabStop = True
        Me.lblNoAccess.Text = "No Access to your Email? Click Here"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(34, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Code:"
        '
        'txtCodeReset
        '
        Me.txtCodeReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txtCodeReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodeReset.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtCodeReset.Location = New System.Drawing.Point(38, 354)
        Me.txtCodeReset.Name = "txtCodeReset"
        Me.txtCodeReset.Size = New System.Drawing.Size(422, 44)
        Me.txtCodeReset.TabIndex = 17
        '
        'lblGoBack
        '
        Me.lblGoBack.ActiveLinkColor = System.Drawing.Color.White
        Me.lblGoBack.AutoSize = True
        Me.lblGoBack.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoBack.ForeColor = System.Drawing.Color.White
        Me.lblGoBack.LinkColor = System.Drawing.Color.White
        Me.lblGoBack.Location = New System.Drawing.Point(214, 648)
        Me.lblGoBack.Name = "lblGoBack"
        Me.lblGoBack.Size = New System.Drawing.Size(80, 20)
        Me.lblGoBack.TabIndex = 16
        Me.lblGoBack.TabStop = True
        Me.lblGoBack.Text = "Go Back"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(130, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 39)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Galapon Store"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(149, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(191, 144)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(34, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 418)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "New Password:"
        '
        'txtEmailReset
        '
        Me.txtEmailReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txtEmailReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailReset.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtEmailReset.Location = New System.Drawing.Point(38, 267)
        Me.txtEmailReset.Name = "txtEmailReset"
        Me.txtEmailReset.Size = New System.Drawing.Size(422, 44)
        Me.txtEmailReset.TabIndex = 0
        '
        'btnSendOTP
        '
        Me.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSendOTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendOTP.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOTP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnSendOTP.Location = New System.Drawing.Point(137, 556)
        Me.btnSendOTP.Name = "btnSendOTP"
        Me.btnSendOTP.Size = New System.Drawing.Size(229, 64)
        Me.btnSendOTP.TabIndex = 13
        Me.btnSendOTP.Text = "Send OTP"
        Me.btnSendOTP.UseVisualStyleBackColor = False
        '
        'chkShowPassReset
        '
        Me.chkShowPassReset.AutoSize = True
        Me.chkShowPassReset.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassReset.ForeColor = System.Drawing.Color.White
        Me.chkShowPassReset.Location = New System.Drawing.Point(38, 500)
        Me.chkShowPassReset.Name = "chkShowPassReset"
        Me.chkShowPassReset.Size = New System.Drawing.Size(192, 28)
        Me.chkShowPassReset.TabIndex = 4
        Me.chkShowPassReset.Text = "Show Password"
        Me.chkShowPassReset.UseVisualStyleBackColor = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassword.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(38, 451)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(422, 44)
        Me.txtNewPassword.TabIndex = 2
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(550, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(550, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 39)
        Me.Label9.TabIndex = 17
        Me.Label9.Visible = False
        '
        'TimeInTableAdapter
        '
        Me.TimeInTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArchInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ArchUserCredsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CreditsArchTableAdapter = Nothing
        Me.TableAdapterManager.CreditsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.PaidCreditsTableAdapter = Nothing
        Me.TableAdapterManager.TimeInTableAdapter = Me.TimeInTableAdapter
        Me.TableAdapterManager.TimeOutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Inventory_Project_Final_Draft1.Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserCredsTableAdapter = Nothing
        '
        'TimeOutBindingSource
        '
        Me.TimeOutBindingSource.DataMember = "TimeOut"
        Me.TimeOutBindingSource.DataSource = Me.Inventory_Project_DatabaseDataSet
        '
        'TimeOutTableAdapter
        '
        Me.TimeOutTableAdapter.ClearBeforeFill = True
        '
        'TimeOutDataGridView
        '
        Me.TimeOutDataGridView.AutoGenerateColumns = False
        Me.TimeOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeOutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TimeOutDataGridView.DataSource = Me.TimeOutBindingSource
        Me.TimeOutDataGridView.Location = New System.Drawing.Point(207, 53)
        Me.TimeOutDataGridView.Name = "TimeOutDataGridView"
        Me.TimeOutDataGridView.RowHeadersWidth = 51
        Me.TimeOutDataGridView.RowTemplate.Height = 24
        Me.TimeOutDataGridView.Size = New System.Drawing.Size(69, 74)
        Me.TimeOutDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Name_Staff"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Name_Staff"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Time_out_Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time_out_Date"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Time_out_Time"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time_out_Time"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'Login_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inventory_Project_Final_Draft1.My.Resources.Resources.CPG_MODULES
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pnlReset)
        Me.Controls.Add(Me.pnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.TimeInDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_Project_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReset.ResumeLayout(False)
        Me.pnlReset.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmailLogin As TextBox
    Friend WithEvents btnSignIn As Button
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents txtPassLogin As TextBox
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblForgot As LinkLabel
    Friend WithEvents pnlReset As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodeReset As TextBox
    Friend WithEvents lblGoBack As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmailReset As TextBox
    Friend WithEvents btnSendOTP As Button
    Friend WithEvents chkShowPassReset As CheckBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblNoAccess As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Inventory_Project_DatabaseDataSet As Inventory_Project_DatabaseDataSet
    Friend WithEvents TimeInBindingSource As BindingSource
    Friend WithEvents TimeInTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeInTableAdapter
    Friend WithEvents TableAdapterManager As Inventory_Project_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TimeInDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TimeOutBindingSource As BindingSource
    Friend WithEvents TimeOutTableAdapter As Inventory_Project_DatabaseDataSetTableAdapters.TimeOutTableAdapter
    Friend WithEvents TimeOutDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
