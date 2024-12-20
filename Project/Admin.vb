Public Class Admin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblclose.Click
        MessageBox.Show("Are you sure that you want to close the Application?", "APPLICATION CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Kitchen_Staff' table. You can move, or remove it, as needed.
        Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Waiters' table. You can move, or remove it, as needed.
        Me.WaitersTableAdapter.Fill(Me.BestFoodsDataSet.Waiters)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Cashiers' table. You can move, or remove it, as needed.
        Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)
        'TODO: This line of code loads data into the 'BestFoodsDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.BestFoodsDataSet.Transactions)
    End Sub

    Private Sub btnAdminAddNew_Click(sender As Object, e As EventArgs) Handles btnAdminAddNew.Click
        If txtAdminWorkId.Text = "" Or txtAdminFirstname.Text = "" Or txtAdminSecondName.Text = "" Or txtAdminNationalid.Text = "" Or txtAdminPhoneNumber.Text = "" Or txtAdminEmail.Text = "" Or txtAdminAdress.Text = "" Or txtAdminUsername.Text = "" Or txtAdminPassword.Text = "" Then

            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else

            If AdminsTableAdapter.Insert(txtAdminWorkId.Text, txtAdminFirstname.Text, txtAdminSecondName.Text, txtAdminNationalid.Text, txtAdminPhoneNumber.Text, txtAdminEmail.Text, txtAdminAdress.Text, txtAdminUsername.Text, txtAdminPassword.Text) Then
                Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)
                MessageBox.Show("New Admin added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAdminWorkId.Text = ""
                txtAdminFirstname.Text = ""
                txtAdminSecondName.Text = ""
                txtAdminNationalid.Text = ""
                txtAdminPhoneNumber.Text = ""
                txtAdminEmail.Text = ""
                txtAdminAdress.Text = ""
                txtAdminUsername.Text = ""
                txtAdminPassword.Text = ""
            Else
                MessageBox.Show("Insertion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAdminWorkId.Text = ""
                txtAdminFirstname.Text = ""
                txtAdminSecondName.Text = ""
                txtAdminNationalid.Text = ""
                txtAdminPhoneNumber.Text = ""
                txtAdminEmail.Text = ""
                txtAdminAdress.Text = ""
                txtAdminUsername.Text = ""
                txtAdminPassword.Text = ""
            End If
        End If

    End Sub

    Private Sub btnAdminupdate_Click(sender As Object, e As EventArgs) Handles btnAdminupdate.Click
        If txtupdadmFirstName.Text = "" Or txtupadmtSecondname.Text = "" Or txtuptadmNationalid.Text = "" Or txtuptadmPhoneNumber.Text = "" Or txtuptadmEmail.Text = "" Or txtUptadmAddress.Text = "" Or txtuptadmUsername.Text = "" Or txtuptadmPassword.Text = "" Or txtuptadmWorkid.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            If AdminsTableAdapter.updateAdmin(txtupdadmFirstName.Text, txtupadmtSecondname.Text, txtuptadmNationalid.Text, txtuptadmPhoneNumber.Text, txtuptadmEmail.Text, txtUptadmAddress.Text, txtuptadmUsername.Text, txtuptadmPassword.Text, txtuptadmWorkid.Text) Then
                Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)
                MessageBox.Show("Data updated  succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtupdadmFirstName.Text = ""
                txtupadmtSecondname.Text = ""
                txtuptadmNationalid.Text = ""
                txtuptadmPhoneNumber.Text = ""
                txtuptadmEmail.Text = ""
                txtUptadmAddress.Text = ""
                txtuptadmUsername.Text = ""
                txtuptadmPassword.Text = ""
                txtuptadmWorkid.Text = ""

            Else
                MessageBox.Show("Update Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtupdadmFirstName.Text = ""
                txtupadmtSecondname.Text = ""
                txtuptadmNationalid.Text = ""
                txtuptadmPhoneNumber.Text = ""
                txtuptadmEmail.Text = ""
                txtUptadmAddress.Text = ""
                txtuptadmUsername.Text = ""
                txtuptadmPassword.Text = ""
                txtuptadmWorkid.Text = ""
            End If
        End If
    End Sub

    Private Sub btnAdminDelete_Click(sender As Object, e As EventArgs) Handles btnAdminDelete.Click

        If txtAdminSearch.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        If AdminsTableAdapter.deleteAdmin(txtAdminSearch.Text) Then
            Me.AdminsTableAdapter.Fill(Me.BestFoodsDataSet.Admins)
            MessageBox.Show("Data Deleted  succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAdminSearch.Text = ""
        End If
    End Sub

    Private Sub btnCashierAddNew_Click(sender As Object, e As EventArgs) Handles btnCashierAddNew.Click
        If txtCashierAddress.Text = "" Or txtCashierEmail.Text = "" Or txtCashierFirstName.Text = "" Or txtCashierNationalId.Text = "" Or txtCashierPassword.Text = "" Or txtcashierPhoneNumber.Text = "" Or txtCashierUsername.Text = "" Or txtCashierWorkId.Text = "" Or txtCashierSecondName.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            If CashiersTableAdapter.CashierInsertQuery(txtCashierWorkId.Text, txtCashierFirstName.Text, txtCashierSecondName.Text, txtCashierNationalId.Text, txtcashierPhoneNumber.Text, txtCashierEmail.Text, txtCashierAddress.Text, txtCashierUsername.Text, txtCashierPassword.Text) Then
                Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
                MessageBox.Show("New Cashier added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCashierAddress.Text = ""
                txtCashierEmail.Text = ""
                txtCashierFirstName.Text = ""
                txtCashierNationalId.Text = ""
                txtCashierPassword.Text = ""
                txtcashierPhoneNumber.Text = ""
                txtCashierUsername.Text = ""
                txtCashierWorkId.Text = ""
                txtCashierSecondName.Text = ""
            Else
                MessageBox.Show("Insertion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCashierAddress.Text = ""
                txtCashierEmail.Text = ""
                txtCashierFirstName.Text = ""
                txtCashierNationalId.Text = ""
                txtCashierPassword.Text = ""
                txtcashierPhoneNumber.Text = ""
                txtCashierUsername.Text = ""
                txtCashierWorkId.Text = ""
                txtCashierSecondName.Text = ""
            End If

            End If
    End Sub

    Private Sub btnCashierUpdate_Click(sender As Object, e As EventArgs) Handles btnCashierUpdate.Click
        If txtuptCashierAddress.Text = "" Or txtuptcashierEmail.Text = "" Or txtuptCashierFirstName.Text = "" Or txtuptcashierpassword.Text = "" Or txtuptCashierphonenumber.Text = "" Or txtuptCashierSecondName.Text = "" Or txtuptCashierusername.Text = "" Or txtuptCashierWorkId.Text = "" Or txtuptCAshierNationalId.text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            If CashiersTableAdapter.CashUPtQuery(txtuptCashierWorkId.Text, txtuptCashierFirstName.Text, txtuptCashierSecondName.Text, txtuptCashierNationalId.Text, txtuptCashierphonenumber.Text, txtuptcashierEmail.Text, txtuptCashierAddress.Text, txtuptCashierusername.Text, txtuptcashierpassword.Text, txtuptCashierWorkId.Text) Then
                Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
                MessageBox.Show("Data updated  succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtuptCashierFirstName.Text = ""
                txtuptcashierpassword.Text = ""
                txtuptCashierphonenumber.Text = ""
                txtuptCashierSecondName.Text = ""
                txtuptCashierusername.Text = ""
                txtuptCashierWorkId.Text = ""
                txtuptCashierNationalId.Text = ""
                txtuptCashierAddress.Text = ""
                txtuptcashierEmail.Text = ""
            Else
                MessageBox.Show("Update Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtuptCashierAddress.Text = ""
                txtuptcashierEmail.Text = ""
                txtuptCashierFirstName.Text = ""
                txtuptcashierpassword.Text = ""
                txtuptCashierphonenumber.Text = ""
                txtuptCashierSecondName.Text = ""
                txtuptCashierusername.Text = ""
                txtuptCashierWorkId.Text = ""
                txtuptCashierNationalId.Text = ""
            End If
        End If

    End Sub

    Private Sub brnCashierDelete_Click(sender As Object, e As EventArgs) Handles brnCashierDelete.Click
        If txtCAshierSearch.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        If CashiersTableAdapter.DeleteCashier(txtCAshierSearch.Text) Then
            Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
            MessageBox.Show("Data Deleted  succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCAshierSearch.Text = ""
        End If
    End Sub

    Private Sub btnWaiterAddNew_Click(sender As Object, e As EventArgs) Handles btnWaiterAddNew.Click
        If txtWaiterAddress.Text = "" Or txtWaiterEmail.Text = "" Or txtWaiterFirstName.Text = "" Or txtWaiterNationalId.Text = "" Or txtWaiterpassword.Text = "" Or txtWaiterPhoneNumber.Text = "" Or txtWaiterSecondName.Text = "" Or txtWaiterUSername.Text = "" Or txtWaiterWorkid.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            If WaitersTableAdapter.Insert(txtWaiterWorkid.Text, txtAdminFirstname.Text, txtWaiterSecondName.Text, txtWaiterNationalId.Text, txtWaiterPhoneNumber.Text, txtWaiterEmail.Text, txtWaiterAddress.Text, txtWaiterEmail.Text, txtWaiterpassword.Text) Then
                Me.WaitersTableAdapter.Fill(Me.BestFoodsDataSet.Waiters)
                MessageBox.Show("New Waiter added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtWaiterAddress.Text = ""
                txtWaiterEmail.Text = ""
                txtWaiterFirstName.Text = ""
                txtWaiterNationalId.Text = ""
                txtWaiterpassword.Text = ""
                txtWaiterPhoneNumber.Text = ""
                txtWaiterSecondName.Text = ""
                txtWaiterUSername.Text = ""
                txtWaiterWorkid.Text = ""
            Else
                MessageBox.Show("Insertion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWaiterAddress.Text = ""
                txtWaiterEmail.Text = ""
                txtWaiterFirstName.Text = ""
                txtWaiterNationalId.Text = ""
                txtWaiterpassword.Text = ""
                txtWaiterPhoneNumber.Text = ""
                txtWaiterSecondName.Text = ""
                txtWaiterUSername.Text = ""
                txtWaiterWorkid.Text = ""

            End If

        End If
    End Sub

    Private Sub btnwaitersupdate_Click(sender As Object, e As EventArgs) Handles btnwaitersupdate.Click
        If txtuptwaiteraddress.Text = "" Or txtuptwaiteremail.Text = "" Or txtuptwaiterfirstname.Text = "" Or txtuptwaiternationalid.Text = "" Or txtuptwaiterpassword.Text = "" Or txtuptwaiterphonenumber.Text = "" Or txtuptwaitersecondname.Text = "" Or txtuptwaiterusername.Text = "" Or txtuptwaiterworkid.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            If WaitersTableAdapter.WaiterUpt(txtuptwaiterworkid.Text, txtuptwaiterfirstname.Text, txtuptwaitersecondname.Text, txtuptwaiternationalid.Text, txtuptwaiterphonenumber.Text, txtuptwaiteremail.Text, txtuptwaiteraddress.Text, txtuptwaiterusername.Text, txtuptwaiterpassword.Text, txtuptwaiterworkid.Text) Then
                Me.WaitersTableAdapter.Fill(Me.BestFoodsDataSet.Waiters)
                MessageBox.Show("Data updated  succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtuptwaiteraddress.Text = ""
                txtuptwaiteremail.Text = ""
                txtuptwaiterfirstname.Text = ""
                txtuptwaiternationalid.Text = ""
                txtuptwaiterpassword.Text = ""
                txtuptwaiterphonenumber.Text = ""
                txtuptwaitersecondname.Text = ""
                txtuptwaiterusername.Text = ""
                txtuptwaiterworkid.Text = ""
            Else
                MessageBox.Show("Update Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtuptwaiteraddress.Text = ""
                txtuptwaiteremail.Text = ""
                txtuptwaiterfirstname.Text = ""
                txtuptwaiternationalid.Text = ""
                txtuptwaiterpassword.Text = ""
                txtuptwaiterphonenumber.Text = ""
                txtuptwaitersecondname.Text = ""
                txtuptwaiterusername.Text = ""
                txtuptwaiterworkid.Text = ""

            End If
        End If
    End Sub

    Private Sub btnWaiterdelete_Click(sender As Object, e As EventArgs) Handles btnWaiterdelete.Click
        If txtwaitersearch.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        If WaitersTableAdapter.Deletewaiter(txtwaitersearch.Text) Then
            Me.CashiersTableAdapter.Fill(Me.BestFoodsDataSet.Cashiers)
            MessageBox.Show("Data Deleted  succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtwaitersearch.Text = ""
        End If
    End Sub

    Private Sub btnkitAddNew_Click(sender As Object, e As EventArgs) Handles btnkitAddNew.Click
        If txtkitAddress.Text = "" Or txtkitEmail.Text = "" Or txtkitFirstName.Text = "" Or txtkitnationalid.Text = "" Or txtkitPassword.Text = "" Or txtkitPhonenumber.Text = "" Or txtkitSecondName.Text = "" Or txtkitusername.Text = "" Or txtkitWorkId.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            If Kitchen_StaffTableAdapter.Insert(txtkitWorkId.Text, txtkitFirstName.Text, txtkitSecondName.Text, txtkitnationalid.Text, txtkitPhonenumber.Text, txtkitEmail.Text, txtkitAddress.Text, txtkitusername.Text, txtkitPassword.Text) Then
                Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
                MessageBox.Show("New Chef added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtkitAddress.Text = ""
                txtkitEmail.Text = ""
                txtkitFirstName.Text = ""
                txtkitnationalid.Text = ""
                txtkitPassword.Text = ""
                txtkitPhonenumber.Text = ""
                txtkitSecondName.Text = ""
                txtkitusername.Text = ""
                txtkitWorkId.Text = ""

            Else
                MessageBox.Show("Insertion Failed,please try again ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtkitAddress.Text = ""
                txtkitEmail.Text = ""
                txtkitFirstName.Text = ""
                txtkitnationalid.Text = ""
                txtkitPassword.Text = ""
                txtkitPhonenumber.Text = ""
                txtkitSecondName.Text = ""
                txtkitusername.Text = ""
                txtkitWorkId.Text = ""

            End If
        End If
    End Sub

    Private Sub btnupdateKitchenStaff_Click(sender As Object, e As EventArgs) Handles btnupdateKitchenStaff.Click
        If txtuptstaffaddress.Text = "" Or txtuptstaffemail.Text = "" Or txtuptstafffirstname.Text = "" Or txtuptstaffnationalid.Text = "" Or txtuptstaffpassword.Text = "" Or txtuptstaffphonenumber.Text = "" Or txtuptstaffsecondname.Text = "" Or txtuptstaffusername.Text = "" Or txtuptstaffWorkid.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            If Kitchen_StaffTableAdapter.UptKitstaff(txtuptstaffWorkid.Text, txtuptstafffirstname.Text, txtuptCashierSecondName.Text, txtuptstaffnationalid.Text, txtuptstaffphonenumber.Text, txtuptstaffemail.Text, txtuptstaffaddress.Text, txtuptstaffusername.Text, txtuptstaffpassword.Text, txtuptstaffWorkid.Text) Then
                Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
                MessageBox.Show("Data Updated added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtuptstaffaddress.Text = ""
                txtuptstaffemail.Text = ""
                txtuptstafffirstname.Text = ""
                txtuptstaffnationalid.Text = ""
                txtuptstaffpassword.Text = ""
                txtuptstaffphonenumber.Text = ""
                txtuptstaffsecondname.Text = ""
                txtuptstaffusername.Text = ""
                txtuptstaffWorkid.Text = ""
            Else
                MessageBox.Show("Update Failed,please try again ", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtuptstaffaddress.Text = ""
                txtuptstaffemail.Text = ""
                txtuptstafffirstname.Text = ""
                txtuptstaffnationalid.Text = ""
                txtuptstaffpassword.Text = ""
                txtuptstaffphonenumber.Text = ""
                txtuptstaffsecondname.Text = ""
                txtuptstaffusername.Text = ""
                txtuptstaffWorkid.Text = ""
            End If
        End If
    End Sub

    Private Sub btndeletewaiter_Click(sender As Object, e As EventArgs) Handles btndeletewaiter.Click
        If txtdelsearch.Text = "" Then
            MessageBox.Show("All  Fields are required", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        If Kitchen_StaffTableAdapter.DeleteChef(txtdelsearch.Text) Then
            Me.Kitchen_StaffTableAdapter.Fill(Me.BestFoodsDataSet.Kitchen_Staff)
            MessageBox.Show("Data Deleted  succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtdelsearch.Text = ""
        End If
    End Sub


End Class
