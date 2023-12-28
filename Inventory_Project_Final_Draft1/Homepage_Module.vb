Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Imports ClosedXML.Excel

Public Class Homepage_Module

    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Yves\source\repos\Inventory_Project_Final_Draft1\Inventory_Project_Final_Draft1\Inventory_Project_Database.accdb;"
    Dim connect As New OleDbConnection
    Dim comm As New OleDbCommand
    Dim da, da1 As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim cntClose As Integer = 1
    Dim dt, dt1 As New DataTable
    Dim isArchive As Boolean = False
    Dim userID, fName, email, pass, acctLev, acctStat As String

    Private Sub refreshDataView()

        dt.Clear()
        dt1.Clear()

        TimeInDataGridView.DataSource = Nothing
        TimeOutDataGridView.DataSource = Nothing

        TimeInDataGridView.Refresh()
        TimeOutDataGridView.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = dbProvider & dbSource
        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da = New OleDbDataAdapter("SELECT * FROM TimeIn", connect)
        da1 = New OleDbDataAdapter("SELECT * FROM TimeOut", connect)

        da1.Fill(dt1)
        da.Fill(dt)
        TimeOutDataGridView.DataSource = dt1
        TimeInDataGridView.DataSource = dt
        connect.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now, "f")

    End Sub

    'Private Sub Homepage_Module_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing



    'End Sub


    Private Sub Homepage_Module_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If cntClose = 1 Then
            lblWelcomeRemarks.Text = ""
            Dim mess As DialogResult
            mess = MsgBox("Are you sure you want to Logout?", vbYesNo, "Logout")
            If mess = DialogResult.Yes Then
                Me.TimeOutBindingSource.AddNew()
                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If
                Using create As New OleDbCommand("INSERT INTO TimeOut([Name_Staff],[Time_out_Date],[Time_out_Time])VALUES(@Name_Staff,@Time_out_Date,@Time_out_Time)", connect)
                    create.Parameters.AddWithValue("@Name_Staff", OleDbType.VarChar).Value = Login_Module.name_Employee
                    create.Parameters.AddWithValue("@Time_out_Date", OleDbType.VarChar).Value = FormatDateTime(Now, DateFormat.ShortDate)
                    create.Parameters.AddWithValue("@Time_out_Time", OleDbType.VarChar).Value = FormatDateTime(TimeOfDay)

                    Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
                    If create.ExecuteNonQuery Then
                        ''MsgBox("Time recorded Succesfully!", vbOKOnly, "Time Out Success")
                        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
                    End If
                End Using
                refreshDataView()
                Threading.Thread.Sleep(1000)
                Login_Module.Show()
            ElseIf mess = DialogResult.No Then
                Me.Show()
            End If
        End If


    End Sub

    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnReportForm.Click
        Me.Hide()
        Report_Module.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Homepage_Module_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeIn' table. You can move, or remove it, as needed.
        Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        TimeInDataGridView.Sort(TimeInDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        refreshDataView()
    End Sub



    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Me.Hide()
        Inventory_Module.Show()

    End Sub



    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        cntClose = 0
        lblWelcomeRemarks.Text = ""
        Dim mess As DialogResult
        mess = MsgBox("Are you sure you want to Logout?", vbYesNo, "Log out")
        If mess = DialogResult.Yes Then
            Me.TimeOutBindingSource.AddNew()
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
            Using create As New OleDbCommand("INSERT INTO TimeOut([Name_Staff],[Time_out_Date],[Time_out_Time])VALUES(@Name_Staff,@Time_out_Date,@Time_out_Time)", connect)
                create.Parameters.AddWithValue("@Name_Staff", OleDbType.VarChar).Value = Login_Module.name_Employee
                create.Parameters.AddWithValue("@Time_out_Date", OleDbType.VarChar).Value = FormatDateTime(Now, DateFormat.ShortDate)
                create.Parameters.AddWithValue("@Time_out_Time", OleDbType.VarChar).Value = FormatDateTime(TimeOfDay)

                Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
                If create.ExecuteNonQuery Then
                    ''MsgBox("Time recorded Succesfully!", vbOKOnly, "Time Out Success")
                    Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
                End If
            End Using
            refreshDataView()

            Threading.Thread.Sleep(1000)
            Me.Hide()
            Login_Module.Show()
        End If

    End Sub



    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        Me.Hide()
        Inventory_Module.Hide()
        'Form4.Show()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Show()

    End Sub

    Private Sub btnStaffs_Click(sender As Object, e As EventArgs) Handles btnStaffs.Click
        Me.Close()
        Staff_Details.Show()
    End Sub

    Private Sub Homepage_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeIn' table. You can move, or remove it, as needed.
        Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        lblWelcomeRemarks.Text = Nothing

        lblWelcomeRemarks.Text = "Welcome! " & Login_Module.name_Employee.Trim
        connect.ConnectionString = dbProvider & dbSource
        refreshDataView()
        TimeInDataGridView.Sort(TimeInDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        TimeOutDataGridView.Sort(TimeOutDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    'Private Sub btnRecordIN_Click(sender As Object, e As EventArgs) Handles btnRecordIN.Click
    '    Me.TimeInBindingSource.AddNew()
    '    If connect.State = ConnectionState.Closed Then
    '        connect.Open()
    '    End If
    '    Using create As New OleDbCommand("INSERT INTO TimeIn([Name_Staff],[Time_in_Date],[Time_in_Time])VALUES(@Name_Staff,@Time_in_Date,@Time_in_Time)", connect)
    '        create.Parameters.AddWithValue("@Name_Staff", OleDbType.VarChar).Value = Login_Module.name_Employee
    '        create.Parameters.AddWithValue("@Time_in_Date", OleDbType.VarChar).Value = FormatDateTime(Now, DateFormat.ShortDate)
    '        create.Parameters.AddWithValue("@Time_in_Time", OleDbType.VarChar).Value = FormatDateTime(TimeOfDay)

    '        Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
    '        If create.ExecuteNonQuery Then
    '            ''MsgBox("Time recorded Succesfully!", vbOKOnly, "Time Out Success")
    '            Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
    '        End If
    '    End Using
    '    refreshDataView()
    'End Sub


End Class