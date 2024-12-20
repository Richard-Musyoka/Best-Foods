Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\haime\OneDrive\Documents\Visual Studio 2012\Projects\BestFoods\BestFoods\BestFoods.mdb")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Waiters' table. You can move, or remove it, as needed.
        Me.WaitersTableAdapter.Fill(Me.BestFoodsDataSet.Waiters)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Kitchen_Staff' table. You can move, or remove it, as needed.
        Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Cashiers' table. You can move, or remove it, as needed.
        Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)


    End Sub

    Private Sub lblclose_Click(sender As Object, e As EventArgs) Handles lblclose.Click
        MessageBox.Show("Are you sure that you want to close the Application?", "APPLICATION CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        resetpasswordvb.Show()
        Me.Hide()
    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Try

       
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username is required", "NO EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If AdminsTableAdapter.LogInQuery(txtUsername.Text, txtPassword.Text) Then
                Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)
                Admin.Show()
                Me.Hide()
            ElseIf CashiersTableAdapter.cashieloginquery(txtUsername.Text, txtPassword.Text) Then
                Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
                CASHIER.Show()
                Me.Hide()
            ElseIf Kitchen_StaffTableAdapter.kitchenloginquery(txtUsername.Text, txtPassword.Text) Then
                Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
                KITCHEN.Show()
                Me.Hide()
            ElseIf WaitersTableAdapter.waitersloginquery(txtUsername.Text, txtPassword.Text) Then
                Me.WaitersTableAdapter.Fill(Me.BestFoodsDataSet.Waiters)
                waiters.Show()
                Me.Hide()
            Else
                MessageBox.Show("Intruder are not allowed in the system", "INTRUDER ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
                 Catch ex As Exception

        End Try


    End Sub

    Private Sub AdminsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdminsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BestFoodsDataSet)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
