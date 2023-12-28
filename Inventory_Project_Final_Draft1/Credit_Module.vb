Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Public Class Credit_Module

    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Yves\source\repos\Inventory_Project_Final_Draft1\Inventory_Project_Final_Draft1\Inventory_Project_Database.accdb;"
    Dim connect As New OleDbConnection
    Dim comm As New OleDbCommand
    Dim da, da1, da2, da3 As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dt, dt1, dt2, dt3 As New DataTable
    Dim cntAdd As Integer = 0
    Dim isPaidCredits As Boolean = False
    Dim isArchiveCred As Boolean = False
    Dim credID, credName, credAmt, credDue, credStat As String

    Public Sub clearText()
        txtAmtDue.Clear()
        txtCreditID.Clear()
        txtCreditor.Clear()
        dtpDue.Text = ""
    End Sub
    Private Sub refreshDataView()
        dt3.Clear()
        dt.Clear()
        dt1.Clear()
        dt2.Clear()

        TimeOutDataGridView.DataSource = Nothing
        CreditsDataGridView.DataSource = Nothing
        PaidCreditsDataGridView.DataSource = Nothing
        CreditsArchDataGridView.DataSource = Nothing

        TimeOutDataGridView.Refresh()
        CreditsDataGridView.Refresh()
        PaidCreditsDataGridView.Refresh()
        CreditsArchDataGridView.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = dbProvider & dbSource
        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text


        da = New OleDbDataAdapter("SELECT * FROM Credits", connect)
        da1 = New OleDbDataAdapter("SELECT * FROM PaidCredits", connect)
        da2 = New OleDbDataAdapter("SELECT * FROM CreditsArch", connect)
        da3 = New OleDbDataAdapter("SELECT * FROM TimeOut", connect)

        da1.Fill(dt1)
        da.Fill(dt)
        da2.Fill(dt2)
        da3.Fill(dt3)

        TimeOutDataGridView.DataSource = dt3
        CreditsArchDataGridView.DataSource = dt2
        CreditsDataGridView.DataSource = dt
        PaidCreditsDataGridView.DataSource = dt1
        connect.Close()
    End Sub

    Function populate() 'FOR MODIFY
        da = New OleDbDataAdapter("Select * from Credits", connect)
        dset = New DataSet
        da.Fill(dset, "Credits")
        CreditsDataGridView.DataSource = dset.Tables("Credits").DefaultView
        Return True
    End Function
    Private Sub Credit_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.CreditsArch' table. You can move, or remove it, as needed.
        'Me.CreditsArchTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.CreditsArch)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.PaidCredits' table. You can move, or remove it, as needed.
        'Me.PaidCreditsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.PaidCredits)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Credits' table. You can move, or remove it, as needed.
        'Me.CreditsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Credits)
        pnlItems.Height = 0
        connect.ConnectionString = dbProvider & dbSource
        Dim checkboxcol As New DataGridViewCheckBoxColumn

        checkboxcol.Width = 35

        checkboxcol.Name = "checkboxcol"

        checkboxcol.HeaderText = ""

        CreditsDataGridView.Columns.Insert(0, checkboxcol)
        refreshDataView()
    End Sub

    Private Sub CreditsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CreditsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CreditsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Inventory_Project_DatabaseDataSet)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'pnlItems.Show()
        If cntAdd = 0 Then
            Me.CreditsBindingSource.AddNew()
            cntAdd += 1
        End If
        If pnlItems.Height = 120 Then
            'pnlItems.Hide()
            Timer2.Start()
        ElseIf pnlItems.Height = 0 Then
            Timer1.Start()
        End If
        picUp.Hide()
        picDown.Show()
        clearText()
        'Me.CreditsBindingSource.AddNew()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pnlItems.Height = 120 Then
            Timer1.Stop()
        Else
            pnlItems.Height = pnlItems.Height + 20
            picUp.Top() = picUp.Top() - 20
            picDown.Top() = picDown.Top() - 20
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If pnlItems.Height = 0 Then
            Timer2.Stop()
        Else
            pnlItems.Height = pnlItems.Height - 20
            picUp.Top() = picUp.Top() + 20
            picDown.Top() = picDown.Top() + 20
        End If
    End Sub

    Private Sub txtItemSearch_TextChanged(sender As Object, e As EventArgs) Handles txtItemSearch.TextChanged

        If isPaidCredits Then
            da = New OleDbDataAdapter("SELECT * FROM PaidCredits WHERE Name_Credit LIKE '" & txtItemSearch.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "PaidCredits")
            PaidCreditsDataGridView.DataSource = dset.Tables("PaidCredits").DefaultView
        ElseIf isArchiveCred Then
            da = New OleDbDataAdapter("SELECT * FROM CreditsArch WHERE Name_Credit LIKE '" & txtItemSearch.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "CreditsArch")
            CreditsDataGridView.DataSource = dset.Tables("CreditsArch").DefaultView
        Else

            da = New OleDbDataAdapter("SELECT * FROM Credits WHERE Name_Credit LIKE '" & txtItemSearch.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "Credits")
            CreditsDataGridView.DataSource = dset.Tables("Credits").DefaultView
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picUp.Click
        If pnlItems.Height = 120 Then
            'pnlItems.Hide()
            Timer2.Start()
        ElseIf pnlItems.Height = 0 Then
            Timer1.Start()
        End If
        picUp.Hide()
        picDown.Show()
    End Sub

    Private Sub picDown_Click(sender As Object, e As EventArgs) Handles picDown.Click
        If pnlItems.Height = 120 Then
            'pnlItems.Hide()
            Timer2.Start()
        ElseIf pnlItems.Height = 0 Then
            Timer1.Start()
        End If
        picUp.Show()
        picDown.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Homepage_Module.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Me.Hide()
        Inventory_Module.Show()
    End Sub

    Private Sub btnStaffs_Click(sender As Object, e As EventArgs) Handles btnStaffs.Click
        Me.Hide()
        Staff_Details.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
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
                    MsgBox("Time recorded Succesfully!", vbOKOnly, "Time Out Success")
                    Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
                End If
            End Using
            refreshDataView()
            Threading.Thread.Sleep(1000)
            Me.Close()
            Login_Module.Show()
        End If
    End Sub

    Private Sub Credit_Module_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
                    MsgBox("Time recorded Succesfully!", vbOKOnly, "Time Out Success")
                    Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
                End If
            End Using
            refreshDataView()
            Threading.Thread.Sleep(1000)
            Login_Module.Show()
        End If
    End Sub

    Private Sub btnUnpaidShow_Click(sender As Object, e As EventArgs) Handles btnUnpaidShow.Click
        isPaidCredits = False
        isArchiveCred = False

        PaidCreditsDataGridView.Hide()
        CreditsDataGridView.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        Using create As New OleDbCommand("INSERT INTO Credits([Credit_ID],[Name_Credit],[Amount],[Due_Date],[Status])VALUES(@Credit_ID,@Name_Credit,@Amount,@Due_Date,@Status)", connect)
            create.Parameters.AddWithValue("@Credit_ID", OleDbType.VarChar).Value = txtCreditID.Text.Trim
            create.Parameters.AddWithValue("@Name_Credit", OleDbType.VarChar).Value = txtCreditor.Text.Trim
            create.Parameters.AddWithValue("@Amount", OleDbType.VarChar).Value = txtAmtDue.Text.Trim
            create.Parameters.AddWithValue("@Due_Date", OleDbType.VarChar).Value = dtpDue.Text.Trim
            create.Parameters.AddWithValue("@Status", OleDbType.VarChar).Value = "Unpaid"

            Me.CreditsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Credits)
            If create.ExecuteNonQuery Then
                MsgBox("Creditor Added Succesfully!", vbOKOnly, "Addition Success")
                Me.CreditsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Credits)
                clearText()
            End If
        End Using
        refreshDataView()
        If pnlItems.Height = 120 Then
            'pnlItems.Hide()
            Timer2.Start()
        End If
        picUp.Show()
        picDown.Hide()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        If pnlItems.Height = 120 Then
            Try
                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If
                'transfers cell to archive

                Dim sql As String = "INSERT INTO CreditsArch([Credit_ID],[Name_Credit],[Amount],[Due_Date],[Status],[Time_Date])VALUES(@Credit_ID,@Name_Credit,@Amount,@Due_Date,@Status,@Time_Date)"

                Dim cmd1 As New OleDbCommand(sql, connect)

                cmd1.Parameters.AddWithValue("@Credit_ID", OleDbType.VarChar).Value = credID

                cmd1.Parameters.AddWithValue("@Name_Credit", OleDbType.VarChar).Value = credName

                cmd1.Parameters.AddWithValue("@Amount", OleDbType.VarChar).Value = credAmt

                cmd1.Parameters.AddWithValue("@Due_Date", OleDbType.VarChar).Value = credDue

                cmd1.Parameters.AddWithValue("@Status", OleDbType.VarChar).Value = credStat

                cmd1.Parameters.AddWithValue("@Time_Date", OleDbType.VarChar).Value = Format(Now, "f")
                cmd1.ExecuteNonQuery()

                connect.Close()

                'update cells

                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If
                comm = New OleDbCommand
                comm.Connection = connect
                comm.CommandText = "Update [Credits] set [Name_Credit]='" & Convert.ToString(txtCreditor.Text) & "', [Amount]= " & Convert.ToInt32(txtAmtDue.Text) & ", [Due_Date]= '" & dtpDue.Text & "', [Status]= '" & lblStatus.Text & "' where [Credit_ID]= '" & txtCreditID.Text & "'"

                comm.ExecuteNonQuery()
                populate()
            Catch ex As Exception
                'MsgBox("Enter Valid Details!", MsgBoxStyle.Critical, "Error")
                MsgBox(ex.ToString)
            End Try

        End If
        refreshDataView()
        clearText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnArchivetable.Click
        isArchiveCred = False
        isPaidCredits = False
        PaidCreditsDataGridView.Hide()
        CreditsDataGridView.Hide()
        CreditsArchDataGridView.Show()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub CreditsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CreditsDataGridView.CellClick
        credID = CreditsDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
        credName = CreditsDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
        credAmt = CreditsDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
        credDue = CreditsDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
        credStat = CreditsDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString

        txtCreditID.Text = CreditsDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
        txtCreditor.Text = CreditsDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
        txtAmtDue.Text = CreditsDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
        dtpDue.Text = CreditsDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
        lblStatus.Text = CreditsDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
        If pnlItems.Height = 0 Then
            'pnlItems.Hide()
            Timer1.Start()
        End If
        picUp.Hide()
        picDown.Show()
    End Sub

    Private Sub btnPaidShow_Click(sender As Object, e As EventArgs) Handles btnPaidShow.Click
        isPaidCredits = True
        isArchiveCred = False
        PaidCreditsDataGridView.Show()
        CreditsDataGridView.Hide()

    End Sub

    Private Sub btnPaid_Click(sender As Object, e As EventArgs) Handles btnPaid.Click
        For Each row As DataGridViewRow In CreditsDataGridView.Rows

            Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)

            If select1 Then
                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If

                Dim sql As String = "INSERT INTO PaidCredits([Credit_ID],[Name_Credit],[Amount_Due],[Due_Date],[Status],[Time_Date])VALUES(@Credit_ID,@Name_Credit,@Amount_Due,@Due_Date,@Status,@Time_Date)"

                Dim cmd1 As New OleDbCommand(sql, connect)

                cmd1.Parameters.AddWithValue("@Credit_ID", row.Cells("DataGridViewTextBoxColumn1").Value)

                cmd1.Parameters.AddWithValue("@Name_Credit", row.Cells("DataGridViewTextBoxColumn2").Value)

                cmd1.Parameters.AddWithValue("@Amount_Due", row.Cells("DataGridViewTextBoxColumn3").Value)

                cmd1.Parameters.AddWithValue("@Due_Date", row.Cells("DataGridViewTextBoxColumn5").Value)

                cmd1.Parameters.AddWithValue("@Status", OleDbType.VarChar).Value = "Paid"

                cmd1.Parameters.AddWithValue("@Time_Date", OleDbType.VarChar).Value = Format(Now, "f")

                cmd1.ExecuteNonQuery()

                connect.Close()
            End If

            If select1 Then

                Dim cmd As New OleDbCommand("DELETE FROM Credits WHERE Credit_ID = @Credit_ID", connect)
                cmd.Parameters.AddWithValue("@Credit_ID", row.Cells("DataGridViewTextBoxColumn1").Value)
                connect.Open()
                cmd.ExecuteNonQuery()
                connect.Close()

            End If
        Next
        MessageBox.Show("Records set as PAID")
        refreshDataView()
        clearText()
        refreshDataView()
        'If pnlItems.Height = 120 Then
        '    Try
        '        If connect.State = ConnectionState.Closed Then
        '            connect.Open()
        '        End If

        '        comm = New OleDbCommand
        '        comm.Connection = connect
        '        comm.CommandText = "Update Credits set Status ='" & "Paid" & "' where Credit_ID= '" & txtCreditID.Text & "'"

        '        comm.ExecuteNonQuery()
        '        populate()
        '    Catch ex As Exception
        '        MsgBox("Enter Valid Details!", MsgBoxStyle.Critical, "Error")
        '    End Try

        'End If

        clearText()
    End Sub
End Class