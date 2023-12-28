Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Public Class Login_Module
    Public Shared vars As Integer
    Dim otp As Double = random.Next(100000, 999999)
    Dim comm As New OleDbCommand
    Dim opin As String = Convert.ToString(otp)
    Shared random As New Random()
    Dim connect As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Yves\source\repos\Inventory_Project_Final_Draft1\Inventory_Project_Final_Draft1\Inventory_Project_Database.accdb;"
    Public Shared name_Employee As String = ""
    Dim da, da1, da2 As New OleDbDataAdapter
    Dim dt, dt1, dt2 As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeIn' table. You can move, or remove it, as needed.
        Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
        connect.ConnectionString = dbProvider & dbSource
        txtPassLogin.UseSystemPasswordChar = True
        txtNewPassword.UseSystemPasswordChar = True
        pnlReset.Width = 0
        name_Employee = ""
    End Sub

    Private Sub refreshDataView()
        dt2.Clear()
        TimeOutDataGridView.DataSource = Nothing
        TimeOutDataGridView.Refresh()
        da2 = New OleDbDataAdapter("SELECT * FROM TimeOut", connect)
        TimeOutDataGridView.DataSource = dt2

        dt.Clear()
        dt1.Clear()

        TimeInDataGridView.DataSource = Nothing


        TimeInDataGridView.Refresh()


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

        TimeInDataGridView.DataSource = dt
        connect.Close()
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassLogin.UseSystemPasswordChar = False
        Else
            txtPassLogin.UseSystemPasswordChar = True
        End If


    End Sub


    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Homepage_Module.Close()
        name_Employee = Label9.Text
        btnSignIn.Text = "Sign In"
        If btnSignIn.Text = "Sign In" Then
            If txtPassLogin.Text = Nothing Or txtEmailLogin.Text = Nothing Then
                MsgBox("Please Enter your Credentials", vbOKOnly, "Login Error")
            Else

                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If

                Using login As New OleDbCommand("SELECT COUNT(*) FROM UserCreds WHERE [Email] = @Email AND [Password] = @Password", connect)
                    login.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = txtEmailLogin.Text.Trim
                    login.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassLogin.Text.Trim

                    Dim logincount = Convert.ToInt32(login.ExecuteScalar())
                    If logincount > 0 Then
                        Me.TimeInBindingSource.AddNew()
                        If connect.State = ConnectionState.Closed Then
                            connect.Open()
                        End If
                        Using create As New OleDbCommand("INSERT INTO TimeIn([Name_Staff],[Time_in_Date],[Time_in_Time])VALUES(@Name_Staff,@Time_in_Date,@Time_in_Time)", connect)
                            create.Parameters.AddWithValue("@Name_Staff", OleDbType.VarChar).Value = Login_Module.name_Employee
                            create.Parameters.AddWithValue("@Time_in_Date", OleDbType.VarChar).Value = FormatDateTime(Now, DateFormat.ShortDate)
                            create.Parameters.AddWithValue("@Time_in_Time", OleDbType.VarChar).Value = FormatDateTime(TimeOfDay)

                            Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
                            If create.ExecuteNonQuery Then
                                'MsgBox("Time recorded Succesfully!" & name_Employee, vbOKOnly, "Time In Success")
                                Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
                            End If
                        End Using
                        refreshDataView()
                        Threading.Thread.Sleep(1000)
                        Me.Hide()
                        refreshDataView()
                        Homepage_Module.Show()
                    Else
                        MsgBox("Incorrect credentials", vbOKOnly, "Login Error")
                        txtEmailLogin.Clear()
                        txtPassLogin.Clear()
                        btnSignIn.Text = "Verify"
                    End If
                End Using

            End If


        Else
            MsgBox("Wrong Password", vbOKOnly, "Incorrect Password")
        End If


        refreshDataView()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgot.LinkClicked
        'Timer2.Start()
        Timer1.Start()
    End Sub

    Private Sub chkShowPassReset_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassReset.CheckedChanged
        If chkShowPassReset.Checked = True Then
            txtNewPassword.UseSystemPasswordChar = False
        Else
            txtNewPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnSendOTP_Click(sender As Object, e As EventArgs) Handles btnSendOTP.Click
        'For Login
        If btnSendOTP.Text = "Send OTP" Then
            Try
                Dim email_add As String = "marts.donotreply@gmail.com"
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = True
                Smtp_Server.EnableSsl = True
                Smtp_Server.Credentials = New Net.NetworkCredential(email_add, "zpvqxowwslxctkey")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                e_mail = New MailMessage()
                e_mail.From = New MailAddress(email_add)
                e_mail.To.Add(txtEmailReset.Text)
                e_mail.Subject = "One Time Pin"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Your Code (OTP) is: " & otp
                Smtp_Server.Send(e_mail)
                MsgBox("Mail Sent", , "Code Sent")
                btnSendOTP.Text = "Reset Password"
            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try

        ElseIf btnSendOTP.Text = "Reset Password" Then
            If txtEmailReset.Text = Nothing Or txtNewPassword.Text = Nothing Then
                MsgBox("Please Enter your Credentials", vbOKOnly, "Login Error")
            ElseIf txtCodeReset.Text = opin Then

                Try
                    If connect.State = ConnectionState.Closed Then
                        connect.Open()
                    End If

                    comm = New OleDbCommand
                    comm.Connection = connect
                    comm.CommandText = "Update [UserCreds] Set [Password]='" & Convert.ToString(txtNewPassword.Text) & "' where [Email]= '" & txtEmailReset.Text & "'"
                    comm.ExecuteNonQuery()
                    MsgBox("Password Reset Successfully!",, "Success")
                    Timer2.Start()
                Catch ex As Exception
                    MsgBox("Enter Valid Details!", MsgBoxStyle.Critical, "Error")
                End Try

                'Using login As New OleDbCommand("SELECT COUNT(*) FROM UserCreds WHERE [Email] = @Email AND [Password] = @Password", connect)
                '    login.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = txtEmailLogin.Text.Trim
                '    login.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassLogin.Text.Trim

                '    Dim logincount = Convert.ToInt32(login.ExecuteScalar())
                '    If logincount > 0 Then
                '        Me.Hide()
                '        Homepage_Module.Show()
                '    Else
                '        MsgBox("Incorrect credentials", vbOKOnly, "Login Error")
                '        txtEmailLogin.Clear()
                '        txtPassLogin.Clear()
                '        btnSignIn.Text = "Verify"
                '    End If
                'End Using
            Else
                MsgBox("Wrong Code", vbOKOnly, "Incorrect Code")
            End If

        Else
            MsgBox("Wrong Password", vbOKOnly, "Incorrect Password")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pnlReset.Width = 375 Then
            Timer1.Stop()
        Else
            pnlLogin.Width = pnlLogin.Width - 75
            pnlReset.Width = pnlReset.Width + 75
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If pnlLogin.Width = 375 Then
            Timer2.Stop()
        Else
            pnlLogin.Width = pnlLogin.Width + 75
            pnlReset.Width = pnlReset.Width - 75
        End If
    End Sub

    Private Sub Login_Module_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        name_Employee = Nothing
        name_Employee = Label9.Text
    End Sub

    Private Sub lblGoBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblGoBack.LinkClicked
        Timer2.Start()
    End Sub

    Private Sub lblNoAccess_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblNoAccess.LinkClicked

        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            comm = New OleDbCommand
            comm.Connection = connect
            comm.CommandText = "Update [UserCreds] Set [Account_Status]='" & "P.R" & "' where [Email]= '" & txtEmailReset.Text & "'"
            comm.ExecuteNonQuery()
            MsgBox("Your concern has been received by the Admin! Kindly wait for your password to be reset.",, "Password Reset")
            Timer2.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtEmailLogin_TextChanged(sender As Object, e As EventArgs) Handles txtEmailLogin.TextChanged
        name_Employee = Nothing
        Label9.Text = Nothing
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        Using search As New OleDbCommand("SELECT * FROM UserCreds WHERE Email='" & txtEmailLogin.Text & "'", connect)
            search.Parameters.AddWithValue("@PatientID", txtEmailLogin.Text)
            Dim reader As OleDbDataReader = search.ExecuteReader()

            While reader.Read()
                Label9.Text += reader("Fname").ToString()

            End While
        End Using

    End Sub

    Private Sub TimeInBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TimeInBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Inventory_Project_DatabaseDataSet)

    End Sub
End Class
