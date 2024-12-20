Public Class resetpasswordvb

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtFirstName.Text = "" Or txtWorkId.Text = "" Then
            MessageBox.Show("All fields are required")
        ElseIf AdminsTableAdapter.AdminResetLog(txtWorkId.Text) Then
            NewPass.Show()
            Me.Hide()
            txtFirstName.Text = ""
            txtWorkId.Text = ""
        ElseIf CashiersTableAdapter.CashierResetLog(txtWorkId.Text) Then
            NewPass.Show()
            Me.Hide()
            txtFirstName.Text = ""
            txtWorkId.Text = ""
        ElseIf Kitchen_StaffTableAdapter.KitchenResetLog(txtWorkId.Text) Then
            NewPass.Show()
            Me.Hide()
            txtFirstName.Text = ""
            txtWorkId.Text = ""
        ElseIf WaitersTableAdapter.WaiterResetLog(txtWorkId.Text) Then
            NewPass.Show()
            Me.Hide()
            txtFirstName.Text = ""
            txtWorkId.Text = ""
        Else
            MessageBox.Show("Intruder are not allowed in the system", "INTRUDER ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Text = ""
            txtWorkId.Text = ""
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub AdminsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdminsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BestFoodsDataSet)

    End Sub

    Private Sub resetpasswordvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Waiters' table. You can move, or remove it, as needed.
        Me.WaitersTableAdapter.Fill(Me.BestFoodsDataSet.Waiters)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Kitchen_Staff' table. You can move, or remove it, as needed.
        Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Cashiers' table. You can move, or remove it, as needed.
        Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class