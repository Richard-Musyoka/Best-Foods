Public Class KITCHEN

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MessageBox.Show("Are you sure that you want to log out the Application?", "APPLICATION CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub FoodsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FoodsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FoodsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BestFoodsDataSet)

    End Sub

    Private Sub KITCHEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Foods' table. You can move, or remove it, as needed.
        Me.FoodsTableAdapter.Fill(Me.BestFoodsDataSet.Foods)

    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFoodCode.Text = "" Or txtFoodQuantity.Text = "" Or txtFoodNAme.Text = "" Or txtunitPrice.Text = "" Then
            MessageBox.Show("All fields are required", "NO EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf FoodsTableAdapter.FoodInsertQuery(txtFoodCode.Text, txtFoodNAme.Text, txtFoodQuantity.Text, txtunitPrice.Text) Then
            Me.FoodsTableAdapter.Fill(Me.BestFoodsDataSet.Foods)
            MessageBox.Show("Food has succesfully been Added", "FOOD ADDITION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFoodCode.Text = ""
            txtFoodQuantity.Text = ""
            txtunitPrice.Text = ""
            txtFoodNAme.Text = ""
        Else
            MessageBox.Show("FOOD ADDITION FAILED", "FAILED", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            txtFoodCode.Text = ""
            txtFoodQuantity.Text = ""
            txtunitPrice.Text = ""
            txtFoodNAme.Text = ""
        End If
    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try


            If txtcode.Text = "" Or txtquantity.Text = "" Then
                MessageBox.Show("All fields are required", "NO EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf FoodsTableAdapter.foodkitchenupdate(txtquantity.Text, txtcode.Text) Then
                Me.FoodsTableAdapter.Fill(Me.BestFoodsDataSet.Foods)
                MessageBox.Show("Food has succesfully been updated", "FOOD UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtcode.Text = ""
                txtquantity.Text = ""
            Else
                MessageBox.Show("FOOD ADDITION FAILED", "FAILED", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtcode.Text = ""
                txtquantity.Text = ""
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtDelFood_Id.Text = "" Then
            MessageBox.Show("All fields are required", "NO EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf FoodsTableAdapter.foodDeleteQuery(txtDelFood_Id.Text) Then
            Me.FoodsTableAdapter.Fill(Me.BestFoodsDataSet.Foods)
            MessageBox.Show("Food has succesfully been deleted", "RECORD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDelFood_Id.Text = ""

        Else
            MessageBox.Show("FOOD DELETION FAILED", "FAILED", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            txtDelFood_Id.Text = ""
        End If
    End Sub
End Class