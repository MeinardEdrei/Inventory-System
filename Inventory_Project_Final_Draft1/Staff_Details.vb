Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Public Class Staff_Details

    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Yves\source\repos\Inventory_Project_Final_Draft1\Inventory_Project_Final_Draft1\Inventory_Project_Database.accdb;"
    Dim connect As New OleDbConnection
    Dim comm As New OleDbCommand
    Dim da, da1, da2 As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim cntAdd As Integer = 0
    Dim dt, dt1, dt2 As New DataTable
    Dim isArchive As Boolean = False
    Dim userID, fName, email, pass, acctLev, acctStat As String

    Private Sub refreshDataView()

        dt2.Clear()
        TimeOutDataGridView.DataSource = Nothing
        TimeOutDataGridView.Refresh()
        da2 = New OleDbDataAdapter("SELECT * FROM TimeOut", connect)
        TimeOutDataGridView.DataSource = dt2

        dt.Clear()
        dt1.Clear()

        UserCredsDataGridView.DataSource = Nothing
        ArchUserCredsDataGridView.DataSource = Nothing
        'ArchInventoryDataGridView.DataSource = Nothing

        UserCredsDataGridView.Refresh()
        ArchUserCredsDataGridView.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = dbProvider & dbSource
        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text
        da = New OleDbDataAdapter("SELECT * FROM UserCreds", connect)
        da1 = New OleDbDataAdapter("SELECT * FROM ArchUserCreds", connect)
        da1.Fill(dt1)
        da.Fill(dt)
        UserCredsDataGridView.DataSource = dt
        ArchUserCredsDataGridView.DataSource = dt1
        connect.Close()
    End Sub


    Public Sub clearText()
        txtUserID.Clear()
        txtPass.Clear()
        txtName.Clear()
        txtEmail.Clear()
        cboAcctStat.Text = ""
    End Sub
    Function populate() 'FOR MODIFY
        da = New OleDbDataAdapter("Select * from UserCreds", connect)
        dset = New DataSet
        da.Fill(dset, "UserCreds")
        UserCredsDataGridView.DataSource = dset.Tables("UserCreds").DefaultView
        Return True
    End Function

    Private Sub Staff_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.ArchUserCreds' table. You can move, or remove it, as needed.
        Me.ArchUserCredsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.ArchUserCreds)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.UserCreds' table. You can move, or remove it, as needed.
        Me.UserCredsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.UserCreds)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.UserCreds' table. You can move, or remove it, as needed.
        Me.UserCredsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.UserCreds)
        connect.ConnectionString = dbProvider & dbSource
        Dim checkboxcol As New DataGridViewCheckBoxColumn

        checkboxcol.Width = 35

        checkboxcol.Name = "checkboxcol"

        checkboxcol.HeaderText = ""

        picDownReset.Hide()
        picUpReset.Hide()
        pnlReset.Height = 0
        pnlItems.Height = 0
        UserCredsDataGridView.Columns.Insert(0, checkboxcol)

        refreshDataView()

    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        Me.Hide()
        Credit_Module.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Me.Hide()
        Inventory_Module.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Homepage_Module.Show()
    End Sub

    Private Sub UserCredsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserCredsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Inventory_Project_DatabaseDataSet)

    End Sub

    Private Sub UserCredsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UserCredsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserCredsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Inventory_Project_DatabaseDataSet)

    End Sub

    Private Sub picUp_Click(sender As Object, e As EventArgs) Handles picUp.Click
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pnlItems.Height = 120 Then
            Timer1.Stop()
        Else
            pnlItems.Height = pnlItems.Height + 20
            picUp.Top() = picUp.Top() - 20
            picDown.Top() = picDown.Top() - 20
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            Using create As New OleDbCommand("INSERT INTO UserCreds([UserID],[Fname],[Email],[Password],[Account_Level],[Account_Status])VALUES(@UserID,@Fname,@Email,@Password,@Account_Level,@Account_Status)", connect)
                create.Parameters.AddWithValue("@UserID", OleDbType.VarChar).Value = txtUserID.Text.Trim
                create.Parameters.AddWithValue("@Fname", OleDbType.VarChar).Value = txtName.Text.Trim
                create.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = txtEmail.Text.Trim
                create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPass.Text.Trim
                create.Parameters.AddWithValue("@Account_Level", OleDbType.VarChar).Value = cboAcctStat.SelectedItem.ToString.Trim
                create.Parameters.AddWithValue("@Account_Status", OleDbType.VarChar).Value = "OK"

                Me.UserCredsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.UserCreds)
                If create.ExecuteNonQuery Then
                    MsgBox("Staff Added Succesfully!", vbOKOnly, "Addition Success")
                    Me.UserCredsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.UserCreds)
                    clearText()
                End If
            End Using
            refreshDataView()

            If pnlReset.Height = 120 Then
                Timer4.Start()
            End If

            If pnlItems.Height = 120 Then
                'pnlItems.Hide()
                Timer2.Start()
            End If

            picUp.Show()
            picDown.Hide()
            picDownReset.Hide()
            picUpReset.Hide()
        Catch ex As Exception
            MsgBox("Error Saving. Make Sure all fields are NOT Empty.", vbCritical, "Error Saving")
        End Try



    End Sub

    Private Sub UserCredsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserCredsDataGridView.CellClick

        If pnlItems.Height = 120 Or pnlItems.Height = 0 And pnlReset.Height = 0 Then
            userID = UserCredsDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            fName = UserCredsDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
            email = UserCredsDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
            pass = UserCredsDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
            acctLev = UserCredsDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
            acctStat = UserCredsDataGridView.Rows(e.RowIndex).Cells(6).Value.ToString

            txtUserID.Text = UserCredsDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            txtName.Text = UserCredsDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
            txtEmail.Text = UserCredsDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
            txtPass.Text = UserCredsDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
            cboAcctStat.Text = UserCredsDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
            lblStatus.Text = UserCredsDataGridView.Rows(e.RowIndex).Cells(6).Value.ToString

            If lblStatus.Text = "OK" Then
                lblStatus.ForeColor = Color.Lime

            ElseIf lblStatus.Text = "P.R" Then
                lblStatus.ForeColor = Color.Red

            End If

            If pnlReset.Height = 120 Then
                Timer4.Start()
            End If


            If pnlItems.Height = 0 Then
                'pnlItems.Hide()
                Timer1.Start()
            End If
            picUp.Hide()
            picDown.Show()

        ElseIf pnlReset.Height = 120 Then
            txtUserIDReset.Text = UserCredsDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
        End If


    End Sub



    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If pnlReset.Height = 120 Then
            Timer4.Start()
        End If

        If pnlItems.Height = 120 Then
            Try
                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If

                Dim sql As String = "INSERT INTO ArchUserCreds([UserID],[Fname],[Email],[Password],[Account_Level],[Account_Status],[Time_Date])VALUES(@UserID,@Fname,@Email,@Password,@Account_Level,@Account_Status,@Time_Date)"

                Dim cmd1 As New OleDbCommand(sql, connect)

                cmd1.Parameters.AddWithValue("@UserID", OleDbType.VarChar).Value = userID

                cmd1.Parameters.AddWithValue("@Fname", OleDbType.VarChar).Value = fName

                cmd1.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = email

                cmd1.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = pass

                cmd1.Parameters.AddWithValue("@Account_Level", OleDbType.VarChar).Value = acctLev

                cmd1.Parameters.AddWithValue("@Account_Status", OleDbType.VarChar).Value = acctStat

                cmd1.Parameters.AddWithValue("@Time_Date", OleDbType.VarChar).Value = Format(Now, "f")
                cmd1.ExecuteNonQuery()

                connect.Close()

                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If
                comm = New OleDbCommand
                comm.Connection = connect
                comm.CommandText = "Update [UserCreds] Set [Fname]='" & Convert.ToString(txtName.Text) & "', [Email]= '" & txtEmail.Text & "', [Password]= '" & txtPass.Text & "', [Account_Level]= '" & cboAcctStat.SelectedItem.ToString & "' where [UserID]= '" & txtUserID.Text & "'"

                comm.ExecuteNonQuery()
                populate()
            Catch ex As Exception
                MsgBox("Enter Valid Details!", MsgBoxStyle.Critical, "Error")
            End Try
        Else
            Timer1.Start()
            picUp.Hide()
            picDown.Show()
            picDownReset.Hide()
            picUpReset.Hide()
        End If
        picDownReset.Hide()
        picUpReset.Hide()
        refreshDataView()
        clearText()
        'populate
    End Sub

    Private Sub btnResetPass_Click(sender As Object, e As EventArgs) Handles btnResetPass.Click

        If pnlReset.Height = 120 Then
            Try

                For Each row As DataGridViewRow In UserCredsDataGridView.Rows

                    Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)

                    If select1 Then

                        If connect.State = ConnectionState.Closed Then
                            connect.Open()
                        End If

                        txtUserIDReset.Text = row.Cells("DataGridViewTextBoxColumn1").Value

                        Dim sql As String = "INSERT INTO ArchUserCreds([UserID],[Fname],[Email],[Password],[Account_Level],[Account_Status],[Time_Date])VALUES(@UserID,@Fname,@Email,@Password,@Account_Level,@Account_Status,@Time_Date)"

                        Dim cmd1 As New OleDbCommand(sql, connect)

                        cmd1.Parameters.AddWithValue("@UserID", row.Cells("DataGridViewTextBoxColumn1").Value)

                        cmd1.Parameters.AddWithValue("@Fname", row.Cells("DataGridViewTextBoxColumn2").Value)

                        cmd1.Parameters.AddWithValue("@Email", row.Cells("DataGridViewTextBoxColumn3").Value)

                        cmd1.Parameters.AddWithValue("@Password", row.Cells("DataGridViewTextBoxColumn4").Value)

                        cmd1.Parameters.AddWithValue("@Account_Level", row.Cells("DataGridViewTextBoxColumn5").Value)

                        cmd1.Parameters.AddWithValue("@Account_Status", row.Cells("DataGridViewTextBoxColumn6").Value)

                        cmd1.Parameters.AddWithValue("@Time_Date", OleDbType.VarChar).Value = Format(Now, "f")

                        cmd1.ExecuteNonQuery()


                        connect.Close()

                    End If

                Next


                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If

                comm = New OleDbCommand
                comm.Connection = connect
                comm.CommandText = "Update [UserCreds] Set [Password]='" & Convert.ToString(txtPassReset.Text) & "', [Account_Status] = '" & "OK" & "' where [UserID]= '" & txtUserIDReset.Text & "'"

                comm.ExecuteNonQuery()
                populate()
            Catch ex As Exception
                MsgBox("Enter Valid Details!", MsgBoxStyle.Critical, "Error")
            End Try

        End If
        Label11.Text = "Reset Successful"

        Threading.Thread.Sleep(1000)
        refreshDataView()

        If Label11.Text = "Reset Successful" Then
            clearText()
            'populate
            Timer4.Start()
            picDownReset.Hide()
            picUpReset.Show()
            picUp.Hide()
            picDown.Hide()

        End If

    End Sub

    Private Sub btnStaffs_Click(sender As Object, e As EventArgs) Handles btnStaffs.Click
        Me.Show()
    End Sub

    Private Sub picDownReset_Click(sender As Object, e As EventArgs) Handles picDownReset.Click
        Timer4.Start()
        picUpReset.Show()
        picUp.Hide()
        picDownReset.Hide()
        picDown.Hide()
    End Sub

    Private Sub picUpReset_Click(sender As Object, e As EventArgs) Handles picUpReset.Click
        Timer3.Start()
        picUpReset.Hide()
        picUp.Hide()
        picDownReset.Show()
        picDown.Hide()
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
            Login_Module.Show()
        End If
    End Sub

    Private Sub Staff_Details_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If pnlItems.Height = 120 Then
            Timer2.Start()
        End If

        Timer3.Start()
        picDownReset.Show()
        picUpReset.Hide()
        picUp.Hide()
        picDown.Hide()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If pnlReset.Height = 120 Then
            Timer3.Stop()

        Else
            pnlReset.Height = pnlReset.Height + 20
            picUpReset.Top() = picUpReset.Top() - 20
            picDownReset.Top() = picDownReset.Top() - 20
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If pnlReset.Height = 0 Then
            Timer4.Stop()
            If pnlItems.Height = 120 Then
                picDownReset.Hide()
                picUpReset.Hide()
            End If

        Else
            pnlReset.Height = pnlReset.Height - 20
            picUpReset.Top() = picUpReset.Top() + 20
            picDownReset.Top() = picDownReset.Top() + 20
        End If
    End Sub

    Private Sub btnUserShow_Click(sender As Object, e As EventArgs) Handles btnUserShow.Click
        isArchive = False
        UserCredsDataGridView.Show()
        ArchUserCredsDataGridView.Hide()
    End Sub

    Private Sub btnArchiveShow_Click(sender As Object, e As EventArgs) Handles btnArchiveShow.Click
        isArchive = True
        UserCredsDataGridView.Hide()
        ArchUserCredsDataGridView.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If pnlItems.Height = 0 Then
            Timer2.Stop()

            If pnlReset.Height = 120 Then
                picUp.Hide()
                picDown.Hide()
            End If
        Else
            pnlItems.Height = pnlItems.Height - 20
            picUp.Top() = picUp.Top() + 20
            picDown.Top() = picDown.Top() + 20
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If cntAdd = 0 Then
            Me.UserCredsBindingSource.AddNew()
            cntAdd += 1
        End If

        If pnlReset.Height = 120 Then
            Timer4.Start()
        End If

        If pnlItems.Height = 0 Then
            Timer1.Start()
        End If

        picUp.Hide()
        picDown.Show()
        picUpReset.Hide()
        picDownReset.Hide()

        clearText()
    End Sub
End Class