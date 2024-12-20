Public Class NewPass

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If txtNationalId.Text = "" Or txtConfirmNewPassword.Text = "" Or txtNewPassword.Text = "" Then
                MessageBox.Show("All fields are required", "NO EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf txtConfirmNewPassword.Text <> txtNewPassword.Text Then
                MessageBox.Show("Passwords dont match ", "FAILED LOGIN ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf AdminsTableAdapter.AdminUpdateQuery(txtConfirmNewPassword.Text, txtNationalId.Text) Then
                Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)
                MessageBox.Show("Password has succesfully been updated", "PASSWORD UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtConfirmNewPassword.Text = ""
                txtNationalId.Text = ""
                txtNewPassword.Text = ""
                Me.Hide()
                Form1.Show()
            ElseIf CashiersTableAdapter.CashierUpdateQuery(txtConfirmNewPassword.Text, txtNationalId.Text) Then
                Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
                MessageBox.Show("Password has succesfully been updated", "PASSWORD UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtConfirmNewPassword.Text = ""
                txtNationalId.Text = ""
                txtNewPassword.Text = ""
                Me.Hide()
                Form1.Show()
            ElseIf Kitchen_StaffTableAdapter.UpdateKitchenkitchenquery(txtConfirmNewPassword.Text, txtNationalId.Text) Then
                Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
                MessageBox.Show("Password has succesfully been updated", "PASSWORD UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtConfirmNewPassword.Text = ""
                txtNationalId.Text = ""
                txtNewPassword.Text = ""
                Me.Hide()
                Form1.Show()
            ElseIf WaitersTableAdapter.WaitersUpdateQuery(txtConfirmNewPassword.Text, txtNationalId.Text) Then
                Me.WaitersTableAdapter.Fill(Me.BestFoodsDataSet.Waiters)
                MessageBox.Show("Password has succesfully been updated", "PASSWORD UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtConfirmNewPassword.Text = ""
                txtNationalId.Text = ""
                txtNewPassword.Text = ""
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Failed", "UPDATE FAILED", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtConfirmNewPassword.Text = ""
                txtNationalId.Text = ""
                txtNewPassword.Text = ""
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub AdminsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdminsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BestFoodsDataSet)

    End Sub

    Private Sub NewPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Cashiers' table. You can move, or remove it, as needed.
        Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Waiters' table. You can move, or remove it, as needed.
        Me.WaitersTableAdapter.Fill(Me.BestFoodsDataSet.Waiters)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Kitchen_Staff' table. You can move, or remove it, as needed.
        Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)

    End Sub
End Class