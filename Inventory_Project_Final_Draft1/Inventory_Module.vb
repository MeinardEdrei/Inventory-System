Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Public Class Inventory_Module

    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Yves\source\repos\Inventory_Project_Final_Draft1\Inventory_Project_Final_Draft1\Inventory_Project_Database.accdb;"
    Dim connect As New OleDbConnection
    Dim comm As New OleDbCommand
    Dim da, da1, da2 As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim cntAdd As Integer = 0
    Dim dt, dt1, dt2 As New DataTable
    Dim isArchive As Boolean = False
    Dim prodId, prodName, prodPrice, prodQty, prodCat As String
    Public Sub clearText()
        txtProdId.Clear()
        txtProdName.Clear()
        txtProdPrice.Clear()
        txtProdQty.Clear()
        cboCategory.Text = ""
    End Sub
    Private Sub refreshDataView()
        dt2.Clear()
        dt.Clear()
        dt1.Clear()

        TimeOutDataGridView.DataSource = Nothing
        InventoryDataGridView.DataSource = Nothing
        ArchInventoryDataGridView.DataSource = Nothing

        TimeOutDataGridView.Refresh()
        InventoryDataGridView.Refresh()
        ArchInventoryDataGridView.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = dbProvider & dbSource
        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da2 = New OleDbDataAdapter("SELECT * FROM TimeOut", connect)
        da = New OleDbDataAdapter("SELECT * FROM Inventory", connect)
        da1 = New OleDbDataAdapter("SELECT * FROM ArchInventory", connect)

        da2.Fill(dt2)
        da1.Fill(dt1)
        da.Fill(dt)

        TimeOutDataGridView.DataSource = dt2
        InventoryDataGridView.DataSource = dt
        ArchInventoryDataGridView.DataSource = dt1

        connect.Close()
    End Sub

    Function populate() 'FOR MODIFY
        da = New OleDbDataAdapter("Select * from Inventory", connect)
        dset = New DataSet
        da.Fill(dset, "Inventory")
        InventoryDataGridView.DataSource = dset.Tables("Inventory").DefaultView
        Return True
    End Function

    Private Sub Inventory_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeOut' table. You can move, or remove it, as needed.
        Me.TimeOutTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeOut)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.TimeIn' table. You can move, or remove it, as needed.
        Me.TimeInTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.TimeIn)
        ArchInventoryDataGridView.Hide()
        InventoryDataGridView.Show()
        ' ArchInventoryDataGridView.Hide()
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.ArchInventory' table. You can move, or remove it, as needed.
        'Me.ArchInventoryTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.ArchInventory)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.ArchInventory' table. You can move, or remove it, as needed.
        'Me.ArchInventoryTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.ArchInventory)

        Dim checkboxcol1, checkboxcol As New DataGridViewCheckBoxColumn

        checkboxcol.Width = 35

        checkboxcol.Name = "checkboxcol"

        checkboxcol.HeaderText = ""

        checkboxcol1.Width = 35

        checkboxcol1.Name = "checkboxcol"

        checkboxcol1.HeaderText = ""

        InventoryDataGridView.Columns.Insert(0, checkboxcol)
        ArchInventoryDataGridView.Columns.Insert(0, checkboxcol1)

        refreshDataView()
        pnlItems.Height = 0
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Inventory)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Inventory)
        'TODO: This line of code loads data into the 'Inventory_Project_DatabaseDataSet.ProdInfo' table. You can move, or remove it, as needed.
        connect.ConnectionString = dbProvider & dbSource
        cboSearchBy.Text = "Search By:"
        picDown.Hide()


    End Sub

    Private Sub txtItemSearch_TextChanged(sender As Object, e As EventArgs) Handles txtItemSearch.TextChanged
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If isArchive Then
            If cboSearchBy.Text = "Search By:" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM ArchInventory WHERE ProdName LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "ArchInventory")
                    ArchInventoryDataGridView.DataSource = dset.Tables("ArchInventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try

            ElseIf cboSearchBy.SelectedItem.ToString = "Product ID" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM ArchInventory WHERE ProdID LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "ArchInventory")
                    ArchInventoryDataGridView.DataSource = dset.Tables("ArchInventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try
            ElseIf cboSearchBy.SelectedItem.ToString = "Product Name" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM ArchInventory WHERE ProdName LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "ArchInventory")
                    ArchInventoryDataGridView.DataSource = dset.Tables("ArchInventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try

            ElseIf cboSearchBy.SelectedItem.ToString = "Product Price" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM ArchInventory WHERE ProdPrice LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "ArchInventory")
                    ArchInventoryDataGridView.DataSource = dset.Tables("ArchInventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try
            ElseIf cboSearchBy.SelectedItem.ToString = "Product Quantity" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM ArchInventory WHERE ProdQuantity LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "ArchInventory")
                    ArchInventoryDataGridView.DataSource = dset.Tables("ArchInventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try
            ElseIf cboSearchBy.SelectedItem.ToString = "Product Category" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM ArchInventory WHERE ProdCategory LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "ArchInventory")
                    ArchInventoryDataGridView.DataSource = dset.Tables("ArchInventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try

            End If

        Else
            If cboSearchBy.Text = "Search By:" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM Inventory WHERE ProdName LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "Inventory")
                    InventoryDataGridView.DataSource = dset.Tables("Inventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try

            ElseIf cboSearchBy.SelectedItem.ToString = "Product ID" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM Inventory WHERE ProdID LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "Inventory")
                    InventoryDataGridView.DataSource = dset.Tables("Inventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try
            ElseIf cboSearchBy.SelectedItem.ToString = "Product Name" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM Inventory WHERE ProdName LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "Inventory")
                    InventoryDataGridView.DataSource = dset.Tables("Inventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try

            ElseIf cboSearchBy.SelectedItem.ToString = "Product Price" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM Inventory WHERE ProdPrice LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "Inventory")
                    InventoryDataGridView.DataSource = dset.Tables("Inventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try
            ElseIf cboSearchBy.SelectedItem.ToString = "Product Quantity" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM Inventory WHERE ProdQuantity LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "Inventory")
                    InventoryDataGridView.DataSource = dset.Tables("Inventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try
            ElseIf cboSearchBy.SelectedItem.ToString = "Product Category" Then
                Try
                    da = New OleDbDataAdapter("SELECT * FROM Inventory WHERE ProdCategory LIKE '" & txtItemSearch.Text & "%'", connect)
                    dset = New DataSet
                    da.Fill(dset, "Inventory")
                    InventoryDataGridView.DataSource = dset.Tables("Inventory").DefaultView
                    Exit Sub
                Catch ex As Exception
                    MsgBox("Invalid Search", MsgBoxStyle.Critical, "Invalid")
                End Try

            End If

        End If


    End Sub

    Private Sub InventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Inventory_Project_DatabaseDataSet)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'pnlItems.Show()

        If cntAdd = 0 Then
            Me.InventoryBindingSource.AddNew()
            cntAdd += 1
        End If
        If pnlItems.Height = 0 Then
            Timer1.Start()
        End If
        picUp.Hide()
        picDown.Show()
        clearText()
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Homepage_Module.Show()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        Me.Hide()
        Credit_Module.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim mess As DialogResult
        mess = MsgBox("Are you sure you want to Logout?", vbYesNo, "Logout")
        If mess = DialogResult.Yes Then
            Me.TimeInBindingSource.AddNew()
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        Using create As New OleDbCommand("INSERT INTO Inventory([ProdID],[ProdName],[ProdPrice],[ProdQuantity],[ProdCategory])VALUES(@ProdID,@ProdName,@ProdPrice,@ProdQuantity,@ProdCategory)", connect)
            create.Parameters.AddWithValue("@ProdID", OleDbType.VarChar).Value = txtProdId.Text.Trim
            create.Parameters.AddWithValue("@ProdName", OleDbType.VarChar).Value = txtProdName.Text.Trim
            create.Parameters.AddWithValue("@ProdPrice", OleDbType.VarChar).Value = txtProdPrice.Text.Trim
            create.Parameters.AddWithValue("@ProdQuantity", OleDbType.VarChar).Value = txtProdQty.Text.Trim
            create.Parameters.AddWithValue("@ProdCategory", OleDbType.VarChar).Value = cboCategory.SelectedItem.ToString.Trim

            Me.InventoryTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Inventory)
            If create.ExecuteNonQuery Then
                MsgBox("Product Added Succesfully!", vbOKOnly, "Addition Success")
                Me.InventoryTableAdapter.Fill(Me.Inventory_Project_DatabaseDataSet.Inventory)
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

                'FOR TRANSFERING TO ARCHIVE AUTO


                Dim sql As String = "INSERT INTO ArchInventory(ProdID,ProdName,ProdPrice,ProdQuantity,ProdCategory,Time_Date) VALUES(@ProdID,@ProdName,@ProdPrice,@ProdQuantity,@ProdCategory,@Time_Date)"

                Dim cmd1 As New OleDbCommand(sql, connect)

                cmd1.Parameters.AddWithValue("@ProdID", OleDbType.VarChar).Value = prodId

                cmd1.Parameters.AddWithValue("@ProdName", OleDbType.VarChar).Value = prodName

                cmd1.Parameters.AddWithValue("@ProdPrice", OleDbType.VarChar).Value = prodPrice

                cmd1.Parameters.AddWithValue("@ProdQuantity", OleDbType.VarChar).Value = prodQty

                cmd1.Parameters.AddWithValue("@ProdCategory", OleDbType.VarChar).Value = prodCat

                cmd1.Parameters.AddWithValue("@Time_Date", OleDbType.VarChar).Value = Format(Now, "f")
                cmd1.ExecuteNonQuery()

                connect.Close()

                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If
                comm = New OleDbCommand
                comm.Connection = connect
                comm.CommandText = "Update Inventory Set ProdName='" & Convert.ToString(txtProdName.Text) & "', ProdPrice= " & Convert.ToInt32(txtProdPrice.Text) & ", ProdQuantity= " & Convert.ToInt32(txtProdQty.Text) & ", ProdCategory= '" & cboCategory.SelectedItem.ToString & "' where ProdID= '" & txtProdId.Text & "'"

                comm.ExecuteNonQuery()
                populate()
            Catch ex As Exception
                MsgBox("Enter Valid Details!", MsgBoxStyle.Critical, "Error")
            End Try

        End If
        refreshDataView()
        clearText()
        'populate

    End Sub

    Private Sub InventoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InventoryDataGridView.CellClick
        prodId = InventoryDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
        prodName = InventoryDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
        prodPrice = InventoryDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
        prodQty = InventoryDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
        prodCat = InventoryDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString

        txtProdId.Text = InventoryDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
        txtProdName.Text = InventoryDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
        txtProdPrice.Text = InventoryDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
        txtProdQty.Text = InventoryDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
        cboCategory.Text = InventoryDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
        If pnlItems.Height = 0 Then
            'pnlItems.Hide()
            Timer1.Start()
        End If
        picUp.Hide()
        picDown.Show()
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

    Private Sub Inventory_Module_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click

        For Each row As DataGridViewRow In InventoryDataGridView.Rows

            Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)

            If select1 Then

                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If

                Dim sql As String = "INSERT INTO ArchInventory(ProdID,ProdName,ProdPrice,ProdQuantity,ProdCategory,Time_Date) VALUES(@ProdID,@ProdName,@ProdPrice,@ProdQuantity,@ProdCategory,@Time_Date)"

                Dim cmd1 As New OleDbCommand(sql, connect)

                cmd1.Parameters.AddWithValue("@ProdID", row.Cells("DataGridViewTextBoxColumn1").Value)

                cmd1.Parameters.AddWithValue("@ProdName", row.Cells("DataGridViewTextBoxColumn2").Value)

                cmd1.Parameters.AddWithValue("@ProdPrice", row.Cells("DataGridViewTextBoxColumn3").Value)

                cmd1.Parameters.AddWithValue("@ProdQuantity", row.Cells("DataGridViewTextBoxColumn4").Value)

                cmd1.Parameters.AddWithValue("@ProdCategory", row.Cells("DataGridViewTextBoxColumn5").Value)

                cmd1.Parameters.AddWithValue("@Time_Date", OleDbType.VarChar).Value = Format(Now, "f")

                cmd1.ExecuteNonQuery()

                connect.Close()

            End If

            If select1 Then

                Dim cmd As New OleDbCommand("DELETE FROM Inventory WHERE ProdID = @ProdID", connect)
                cmd.Parameters.AddWithValue("@ProdID", row.Cells("DataGridViewTextBoxColumn1").Value)
                connect.Open()
                cmd.ExecuteNonQuery()
                connect.Close()

            End If


        Next
        MessageBox.Show("Records moved to Archive")
        refreshDataView()
        clearText()
        refreshDataView()
    End Sub

    Private Sub btnStaffs_Click(sender As Object, e As EventArgs) Handles btnStaffs.Click
        Me.Hide()
        Staff_Details.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub btnInventoryShow_Click(sender As Object, e As EventArgs) Handles btnInventoryShow.Click
        ArchInventoryDataGridView.Hide()
        InventoryDataGridView.Show()
        isArchive = False
        'cntforarchive = 0
        refreshDataView()
    End Sub

    Private Sub btnArchiveShow_Click(sender As Object, e As EventArgs) Handles btnArchiveShow.Click
        InventoryDataGridView.Hide()
        ArchInventoryDataGridView.Show()
        isArchive = True
        'cntforarchive = 1
        refreshDataView()
    End Sub


End Class