Imports System.Data.DataTable
Public Class CASHIER
    Dim balance As Integer
    Dim table As New DataTable("table")
    Dim totalSum As Decimal = 0

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MessageBox.Show("Are you sure that you want to close the Application?", "APPLICATION CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub CASHIER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.BestFoodsDataSet.Transactions)
        'TODO: This line of code loads data into the 'Bestfoods2DataSet.pendingorders2' table. You can move, or remove it, as needed.
        Me.Pendingorders2TableAdapter.Fill(Me.Bestfoods2DataSet.pendingorders2)


        table.Columns.Add("Food_Code", Type.GetType("System.Int32"))
        table.Columns.Add("Food_Name", Type.GetType("System.String"))
        table.Columns.Add("Food_Quantity", Type.GetType("System.String"))
        table.Columns.Add("Unit_Price", Type.GetType("System.String"))
        table.Columns.Add("Price_Per_Quantity", Type.GetType("System.String"))
        DataGridView2.DataSource = table


        'TODO: This line of code loads data into the 'BestFoodsDataSet.Foods' table. You can move, or remove it, as needed.
        Me.FoodsTableAdapter.Fill(Me.BestFoodsDataSet.Foods)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Pending_Orders' table. You can move, or remove it, as needed.
        Me.Pending_OrdersTableAdapter.Fill(Me.BestFoodsDataSet.Pending_Orders)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FoodsTableAdapter.FillBy1(Me.BestFoodsDataSet.Foods, txtFoodCode.Text)
        If QuantityTextBox.Text = "0" Then
            MessageBox.Show("The food is out of stock", "OUT OF STOCK", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim foodName As String = Food_NameTextBox.Text
            Dim unitPrice As String = Unit_PriceTextBox.Text

            If Val(txtFoodQuantity.Text) > Val(QuantityTextBox.Text) Then
                MessageBox.Show("Food Quantity error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else


                Dim totalprice As String
                totalprice = Val(txtFoodQuantity.Text) * Val(unitPrice)


                table.Rows.Add(txtFoodCode.Text, foodName, txtFoodQuantity.Text, unitPrice, totalprice)
                DataGridView2.DataSource = table
                totalSum += totalprice
                txtTotalAmount.Text = totalSum
                FoodsTableAdapter.UpdateQuantity(Val(txtFoodQuantity.Text), txtFoodCode.Text)
                Me.FoodsTableAdapter.Fill(Me.BestFoodsDataSet.Foods)

                'receipt
                rtbreceipt.AppendText(vbCrLf + vbTab + "" & foodName & " " + vbTab + vbTab + "" & txtFoodQuantity.Text & "" + vbTab + vbTab + " " & unitPrice & "" + vbTab + vbTab + " " & totalprice & "")
                'rtbreceipt.AppendText(txtTotalAmount.Text)
                ' rtbreceipt.AppendText(balance)

                txtFoodCode.Text = ""
                txtFoodQuantity.Text = ""
                totalprice = ""
            End If
        End If



    End Sub

    Private Sub txtFoodName_OnValueChanged(sender As Object, e As EventArgs)
        FoodsTableAdapter.FillBy(Me.BestFoodsDataSet.Foods, txtFoodCode.Text)
        Me.FoodsTableAdapter.Fill(Me.BestFoodsDataSet.Foods)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtAmountpaid.Enabled = True
        Else
            txtAmountpaid.Enabled = False
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtMpesaCode.Enabled = True
            txtTotalAmountPaid.Enabled = True
            txtPhoneNumber.Enabled = True
        Else
            txtMpesaCode.Enabled = False
            txtTotalAmountPaid.Enabled = False
            txtPhoneNumber.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amount As String = 0

        If RadioButton1.Checked = True Then
            If txtAmountpaid.Text = "" Then
                MessageBox.Show("Empty field")
            Else
                If Val(txtAmountpaid.Text) >= Val(txtTotalAmount.Text) Then
                    Dim balance As String = Val(txtAmountpaid.Text) - Val(txtTotalAmount.Text)
                    MessageBox.Show("Balance is: " + balance, "BALANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If balance = "0" Then
                        amount = txtAmountpaid.Text
                    Else
                        amount = txtTotalAmount.Text
                    End If
                    Dim transaction_Date As String = Date.Now
                    TransactionsTableAdapter.Insert(amount, transaction_Date)
                    MessageBox.Show(" Transaction committed Successfully", "SUCCESSFUL TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAmountpaid.Text = ""
                    txtTotalAmount.Text = ""
                Else
                    MessageBox.Show("Less amount")
                End If
            End If
        ElseIf RadioButton2.Checked = True Then
            If txtTotalAmountPaid.Text = "" Or txtMpesaCode.Text = "" Or txtPhoneNumber.Text = "" Then
                MessageBox.Show(" No Empty field", "EMPTY FIELDS", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Else
                If Val(txtTotalAmountPaid.Text) >= Val(txtTotalAmount.Text) Then
                    Dim balance As String = Val(txtTotalAmountPaid.Text) - Val(txtTotalAmount.Text)
                    MessageBox.Show("Balance is: " + balance, "BALANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If balance = "0" Then
                        amount = txtAmountpaid.Text
                    Else
                        amount = txtTotalAmount.Text
                    End If
                    Dim transaction_Date As String = Date.Now
                    TransactionsTableAdapter.Insert(amount, transaction_Date)
                    MessageBox.Show(" Transaction committed Successfully", "SUCCESSFUL TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtTotalAmountPaid.Text = ""
                    txtPhoneNumber.Text = ""
                    txtMpesaCode.Text = ""
                    txtTotalAmount.Text = ""
                Else
                    MessageBox.Show("Less amount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("No selection", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        'stockUpdate

        '  If DataGridView1.RowCount > 1 Then
        '  Dim newquantity As Integer
        ' For index As Integer = 0 To DataGridView1.RowCount - 1
        '       newquantity = Val(DataGridView1.Rows(index).Cells(2).Value) - Val(txtFoodQuantity.Text)
        '   Next

        '    Me.FoodsTableAdapter.Fill(Me.BestFoodsDataSet.Foods)
        ' End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 17, FontStyle.Regular)
        e.Graphics.DrawString(rtbreceipt.Text, font, Brushes.Black, 20, 20)
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.FoodsTableAdapter.FillBy1(Me.BestFoodsDataSet.Foods, Food_IdToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        DataGridView2.ClearSelection()
        txtTotalAmount.Text = ""
    End Sub
End Class