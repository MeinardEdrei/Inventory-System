Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Public Class TimeIn_Out_Module
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Yves\source\repos\Inventory_Project_Final_Draft1\Inventory_Project_Final_Draft1\Inventory_Project_Database.accdb;"
    Dim connect As New OleDbConnection
    Dim comm As New OleDbCommand
    Dim da, da1 As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim cntClose As Integer = 1
    Dim dt, dt1 As New DataTable
    Dim isArchive As Boolean = False

    Private Sub TimeIn_Out_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.In_Time' table. You can move, or remove it, as needed.
        Me.In_TimeTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.In_Time)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.In_Time' table. You can move, or remove it, as needed.
        Me.In_TimeTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.In_Time)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Out' table. You can move, or remove it, as needed.
        Me.OutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Out)
        connect.ConnectionString = dbProvider & dbSource
        Timer3.Start()
        lblDate.Text = Format(Now, "To\da\y i\s MMMM d, yyyy.")
        lblTime.Text = FormatDateTime(TimeOfDay)
        btnTimeOut.Enabled = False
        btnTimeIn.Enabled = True
        refreshDataView()
        In_TimeDataGridView.Sort(In_TimeDataGridView.Columns(3), System.ComponentModel.ListSortDirection.Descending)
        OutDataGridView.Sort(OutDataGridView.Columns(3), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Private Sub refreshDataView()

        dt.Clear()
        dt1.Clear()

        In_TimeDataGridView.DataSource = Nothing
        OutDataGridView.DataSource = Nothing

        In_TimeDataGridView.Refresh()
        OutDataGridView.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = dbProvider & dbSource
        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da = New OleDbDataAdapter("SELECT * FROM In_Time", connect)
        da1 = New OleDbDataAdapter("SELECT * FROM Out", connect)

        da1.Fill(dt1)
        da.Fill(dt)
        In_TimeDataGridView.DataSource = dt
        OutDataGridView.DataSource = dt1
        connect.Close()
    End Sub

    Private Sub btnTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click
        Me.OutBindingSource.AddNew()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Using create As New OleDbCommand("INSERT INTO Out([Staff_Name],[Time_Out],[Date_Out])VALUES(@Staff_Name,@Time_Out,@Date_Out)", connect)
            create.Parameters.AddWithValue("@Staff_Name", OleDbType.VarChar).Value = "Lnsloth Deocares" 'Login_Module.name_Employee
            create.Parameters.AddWithValue("@Time_Out", OleDbType.VarChar).Value = FormatDateTime(Now, DateFormat.ShortDate)
            create.Parameters.AddWithValue("@Date_Out", OleDbType.VarChar).Value = FormatDateTime(TimeOfDay)

            Me.OutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Out)
            If create.ExecuteNonQuery Then
                ''MsgBox("Time recorded Succesfully!", vbOKOnly, "Time Out Success")
                Me.OutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Out)
            End If
        End Using
        refreshDataView()
        ' Threading.Thread.Sleep(1000)
        btnTimeOut.Enabled = False
        btnTimeIn.Enabled = False
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lblTime.Text = FormatDateTime(TimeOfDay)
    End Sub

    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click

        Me.In_TimeBindingSource.AddNew()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Using create As New OleDbCommand("INSERT INTO In_Time([Staff_Name],[Time_In],[Date_In])VALUES(@Staff_Name,@Time_In,@Date_In)", connect)
            create.Parameters.AddWithValue("@Staff_Name", OleDbType.VarChar).Value = "Lnsloth Deocares" 'Login_Module.name_Employee
            create.Parameters.AddWithValue("@Time_In", OleDbType.VarChar).Value = FormatDateTime(Now, DateFormat.ShortDate)
            create.Parameters.AddWithValue("@Date_In", OleDbType.VarChar).Value = FormatDateTime(TimeOfDay)

            Me.In_TimeTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.In_Time)
            If create.ExecuteNonQuery Then
                ''MsgBox("Time recorded Succesfully!", vbOKOnly, "Time Out Success")
                Me.In_TimeTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.In_Time)
            End If
        End Using
        refreshDataView()
        ' Threading.Thread.Sleep(1000)
        btnTimeOut.Enabled = True
        btnTimeIn.Enabled = False
    End Sub
End Class