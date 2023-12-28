Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Imports ClosedXML.Excel
Public Class Report_Module

    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Yves\source\repos\Inventory_Project_Final_Draft1\Inventory_Project_Final_Draft1\Inventory_Project_Database.accdb;"
    Dim connect As New OleDbConnection
    Dim comm As New OleDbCommand
    Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11 As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim isInventory = False, isArchInv = False, isCreds = False, isArchCreds = False, isPaidCreds = False, isMasterlist As Boolean = False
    Dim isUserCred = False, isArchUser = False, isLogin = False, isLogout = False, isTimeIn = False, isTimeOut As Boolean = False
    Dim dt, dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8, dt9, dt10, dt11 As New DataTable

    Private mRow As Integer = 0
    Private newPage As Boolean = True
    Dim pagecount As Integer = 1
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString("Report Form (Inventory)", New Font("Times New Roman", 20, FontStyle.Bold),
                              Brushes.Black, New PointF(400, 20), format)

        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        fmt.Alignment = StringAlignment.Center

        Dim y As Integer = 100
        Dim x As Integer = 50
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow

        'header print
        If pagecount = 1 Then
            row = InventoryDataGridView.Rows(mRow)
            x = 40
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)
                    e.Graphics.DrawString(InventoryDataGridView.Columns(cell.ColumnIndex).HeaderText, InventoryDataGridView.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h

            newPage = True
            Dim displayNow As Integer
            For displayNow = mRow To InventoryDataGridView.RowCount - 39
                row = InventoryDataGridView.Rows(displayNow)
                x = 40
                h = 0

                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.Black, rc)

                        fmt.Alignment = StringAlignment.Near
                        rc.Offset(10, 0)

                        e.Graphics.DrawString(cell.FormattedValue.ToString(), InventoryDataGridView.Font, Brushes.Black, rc, fmt)
                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    End If
                Next
                y += h

            Next

            'Empty cell
            For x = 0 To 1
                row = InventoryDataGridView.Rows(x)
                x = 40 ' margin
                h = 0
                If pagecount = 1 Then
                    h = 500
                End If

                e.HasMorePages = True
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then

                        rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.White, rc)

                        fmt.Alignment = StringAlignment.Near
                        rc.Offset(10, 0)

                        e.Graphics.DrawRectangle(Pens.White, rc)
                        'e.Graphics.DrawString(cell.FormattedValue.ToString(), InventoryDataGridView.Font, Brushes.Black, rc, fmt)
                        x += rc.Width
                        h = Math.Max(h, rc.Height)

                    End If
                Next

                y += h
            Next

            e.HasMorePages = True
        End If

        row = InventoryDataGridView.Rows(mRow)
        x = 40
        For Each cell As DataGridViewCell In row.Cells
            If cell.Visible Then
                rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                e.Graphics.FillRectangle(Brushes.LightGray, rc)
                e.Graphics.DrawRectangle(Pens.Black, rc)
                e.Graphics.DrawString(InventoryDataGridView.Columns(cell.ColumnIndex).HeaderText, InventoryDataGridView.Font, Brushes.Black, rc, fmt)
                x += rc.Width
                h = Math.Max(h, rc.Height)
            End If

        Next
        y += h

        For displayNow = 39 To InventoryDataGridView.RowCount - 1
            row = InventoryDataGridView.Rows(displayNow)
            x = 40 ' margin
            h = 0
            If pagecount = 1 Then
                h = 500
            End If

            e.HasMorePages = True
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then

                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)

                    e.Graphics.DrawString(cell.FormattedValue.ToString(), InventoryDataGridView.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)

                End If
            Next

            y += h
        Next
        pagecount += 1
        If pagecount = 3 Then
            e.HasMorePages = False
        End If
        'e.HasMorePages = False
        ' ito yung sa laman mismo

        'pagecount += 1
        'Dim displayNow1 As Integer


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub





    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If isInventory Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.Inventory.CopyToDataTable, "Inventory")

                            workbook.SaveAs(sfd.FileName)

                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If

        If isUserCred Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.UserCreds.CopyToDataTable, "UserCreds")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isArchInv Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.ArchInventory.CopyToDataTable, "ArchInventory")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isArchUser Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.ArchUserCreds.CopyToDataTable, "ArchUserCreds")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isCreds Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.Credits.CopyToDataTable, "Credits")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isLogin Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.TimeIn.CopyToDataTable, "TimeIn")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isArchCreds Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.CreditsArch.CopyToDataTable, "CreditsArch")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isLogout Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.TimeOut.CopyToDataTable, "TimeOut")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isPaidCreds Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.PaidCredits.CopyToDataTable, "PaidCredits")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isTimeIn Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.In_Time.CopyToDataTable, "In_Time")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isMasterlist Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.Masterlist.CopyToDataTable, "Masterlist")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If
        If isTimeOut Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook
                            workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.Out.CopyToDataTable, "Out")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If

    End Sub



    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook

                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.ArchInventory.CopyToDataTable, "ArchInventory")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.ArchUserCreds.CopyToDataTable, "ArchUserCreds")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.CreditsArch.CopyToDataTable, "CreditsArch")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.Credits.CopyToDataTable, "Credits")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.In_Time.CopyToDataTable, "In_Time")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.Inventory.CopyToDataTable, "Inventory")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.Masterlist.CopyToDataTable, "Masterlist")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.Out.CopyToDataTable, "Out")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.PaidCredits.CopyToDataTable, "PaidCredits")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.TimeIn.CopyToDataTable, "TimeIn")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.TimeOut.CopyToDataTable, "TimeOut")
                        workbook.Worksheets.Add(Me.Inventory_Project_DatabaseDataSet.UserCreds.CopyToDataTable, "UserCreds")

                        workbook.SaveAs(sfd.FileName)

                    End Using
                    MsgBox("Sucess!", MsgBoxStyle.Information, "Saved")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End Using
    End Sub

    Private Sub refreshDataView()

        dt.Clear()
        dt1.Clear()
        dt2.Clear()
        dt3.Clear()
        dt4.Clear()
        dt5.Clear()
        dt6.Clear()
        dt7.Clear()
        dt8.Clear()
        dt9.Clear()
        dt10.Clear()
        dt11.Clear()

        ArchInventoryDataGridView.DataSource = Nothing
        ArchUserCredsDataGridView.DataSource = Nothing
        CreditsArchDataGridView.DataSource = Nothing
        CreditsDataGridView.DataSource = Nothing
        In_TimeDataGridView.DataSource = Nothing
        InventoryDataGridView.DataSource = Nothing
        MasterlistDataGridView.DataSource = Nothing
        OutDataGridView.DataSource = Nothing
        PaidCreditsDataGridView.DataSource = Nothing
        TimeInDataGridView.DataSource = Nothing
        TimeOutDataGridView.DataSource = Nothing
        UserCredsDataGridView.DataSource = Nothing

        ArchInventoryDataGridView.Refresh()
        ArchUserCredsDataGridView.Refresh()
        CreditsArchDataGridView.Refresh()
        CreditsDataGridView.Refresh()
        In_TimeDataGridView.Refresh()
        InventoryDataGridView.Refresh()
        MasterlistDataGridView.Refresh()
        OutDataGridView.Refresh()
        PaidCreditsDataGridView.Refresh()
        TimeInDataGridView.Refresh()
        TimeOutDataGridView.Refresh()
        UserCredsDataGridView.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = dbProvider & dbSource
        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da = New OleDbDataAdapter("SELECT * FROM ArchInventory", connect)
        da1 = New OleDbDataAdapter("SELECT * FROM ArchUserCreds", connect)
        da2 = New OleDbDataAdapter("SELECT * FROM CreditsArch", connect)
        da3 = New OleDbDataAdapter("SELECT * FROM Credits", connect)
        da4 = New OleDbDataAdapter("SELECT * FROM In_Time", connect)
        da5 = New OleDbDataAdapter("SELECT * FROM Inventory", connect)
        da6 = New OleDbDataAdapter("SELECT * FROM Masterlist", connect)
        da7 = New OleDbDataAdapter("SELECT * FROM Out", connect)
        da8 = New OleDbDataAdapter("SELECT * FROM PaidCredits", connect)
        da9 = New OleDbDataAdapter("SELECT * FROM TimeIn", connect)
        da10 = New OleDbDataAdapter("SELECT * FROM TimeOut", connect)
        da11 = New OleDbDataAdapter("SELECT * FROM UserCreds", connect)


        da.Fill(dt)
        da1.Fill(dt1)
        da2.Fill(dt2)
        da3.Fill(dt3)
        da4.Fill(dt4)
        da5.Fill(dt5)
        da6.Fill(dt6)
        da7.Fill(dt7)
        da8.Fill(dt8)
        da9.Fill(dt9)
        da10.Fill(dt10)
        da11.Fill(dt11)

        ArchInventoryDataGridView.DataSource = dt
        ArchUserCredsDataGridView.DataSource = dt1
        CreditsArchDataGridView.DataSource = dt2
        CreditsDataGridView.DataSource = dt3
        In_TimeDataGridView.DataSource = dt4
        InventoryDataGridView.DataSource = dt5
        MasterlistDataGridView.DataSource = dt6
        OutDataGridView.DataSource = dt7
        PaidCreditsDataGridView.DataSource = dt8
        TimeInDataGridView.DataSource = dt9
        TimeOutDataGridView.DataSource = dt10
        UserCredsDataGridView.DataSource = dt11

        connect.Close()
    End Sub

    Private Sub ArchInventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ArchInventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Inventory_Project_DatabaseDataSet)

    End Sub

    Private Sub Report_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInventory = True
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Masterlist' table. You can move, or remove it, as needed.
        Me.MasterlistTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Masterlist)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Masterlist' table. You can move, or remove it, as needed.
        Me.MasterlistTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Masterlist)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.UserCreds' table. You can move, or remove it, as needed.
        Me.UserCredsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.UserCreds)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeIn' table. You can move, or remove it, as needed.
        Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.PaidCredits' table. You can move, or remove it, as needed.
        Me.PaidCreditsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.PaidCredits)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Out' table. You can move, or remove it, as needed.
        Me.OutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Out)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Inventory)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.In_Time' table. You can move, or remove it, as needed.
        Me.In_TimeTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.In_Time)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.CreditsArch' table. You can move, or remove it, as needed.
        Me.CreditsArchTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.CreditsArch)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Credits' table. You can move, or remove it, as needed.
        Me.CreditsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Credits)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.ArchUserCreds' table. You can move, or remove it, as needed.
        Me.ArchUserCredsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.ArchUserCreds)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.ArchUserCreds' table. You can move, or remove it, as needed.
        Me.ArchUserCredsTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.ArchUserCreds)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.ArchInventory' table. You can move, or remove it, as needed.
        Me.ArchInventoryTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.ArchInventory)
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Show()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        connect.ConnectionString = dbProvider & dbSource

        refreshDataView()
    End Sub

    Private Sub btnArchUser_Click(sender As Object, e As EventArgs) Handles btnArchUser.Click
        refreshDataView()
        ArchInventoryDataGridView.Show()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = True
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False

    End Sub

    Private Sub btnPaidShow_Click(sender As Object, e As EventArgs) Handles btnPaidShow.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Show()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = True
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
    End Sub

    Private Sub btnArchCreditShow_Click(sender As Object, e As EventArgs) Handles btnArchCreditShow.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Show()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = True
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
    End Sub

    Private Sub btnCreditShow_Click(sender As Object, e As EventArgs) Handles btnCreditShow.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Show()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = True
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
    End Sub

    Private Sub btnArchInventoryShow_Click(sender As Object, e As EventArgs) Handles btnArchInventoryShow.Click
        refreshDataView()
        ArchInventoryDataGridView.Show()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = True
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
    End Sub

    Private Sub btnInventoryShow_Click(sender As Object, e As EventArgs) Handles btnInventoryShow.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Show()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = True
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
    End Sub

    Private Sub btnTimeOutHistory_Click(sender As Object, e As EventArgs) Handles btnTimeOutHistory.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Show()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = True
    End Sub

    Private Sub btnTimeInHistory_Click(sender As Object, e As EventArgs) Handles btnTimeInHistory.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Show()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = True
        isMasterlist = False
        isTimeOut = False
    End Sub

    Private Sub btnLogoutHistory_Click(sender As Object, e As EventArgs) Handles btnLogoutHistory.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Show()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = True
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
    End Sub

    Private Sub btnLoginHistory_Click(sender As Object, e As EventArgs) Handles btnLoginHistory.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Show()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = True
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
    End Sub

    Private Sub btnMasterlistShow_Click(sender As Object, e As EventArgs) Handles btnMasterlistShow.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Show()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Hide()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = False
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = True
        isTimeOut = False
    End Sub

    Private Sub btnUserDetails_Click(sender As Object, e As EventArgs) Handles btnUserDetails.Click
        refreshDataView()
        ArchInventoryDataGridView.Hide()
        ArchUserCredsDataGridView.Hide()
        CreditsArchDataGridView.Hide()
        CreditsDataGridView.Hide()
        In_TimeDataGridView.Hide()
        InventoryDataGridView.Hide()
        MasterlistDataGridView.Hide()
        OutDataGridView.Hide()
        PaidCreditsDataGridView.Hide()
        TimeInDataGridView.Hide()
        TimeOutDataGridView.Hide()
        UserCredsDataGridView.Show()

        'TO EXPORT ONE BY ONE
        isInventory = False
        isUserCred = True
        isArchInv = False
        isArchUser = False
        isCreds = False
        isLogin = False
        isArchCreds = False
        isLogout = False
        isPaidCreds = False
        isTimeIn = False
        isMasterlist = False
        isTimeOut = False
    End Sub
End Class