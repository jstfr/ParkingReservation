Public Class frmRegister

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If (cmbUserType.SelectedItem.ToString = "Admin") Then
        ElseIf (cmbUserType.SelectedItem.ToString = "Receptionist") Then
        ElseIf (cmbUserType.SelectedItem.ToString = "Customer") Then
            Dim Customer As New clsCustomer
            If txtPassword.Text = txtConfirmPassword.Text Then
                Try
                    If (rbtMale.Checked = True) Then
                        Customer.Gender = "Male"
                    Else
                        Customer.Gender = "Female"
                    End If
                    Customer.Name = txtName.Text.Trim
                    Customer.Age = CInt(txtAge.Text.Trim)
                    Customer.Address = txtAddress.Text.Trim
                    Customer.Password = txtPassword.Text.Trim
                    Customer.Username = txtUsername.Text.Trim

                    Customer.RegisterNewUser()
                    MessageBox.Show("Register complete, You can now login.", "Parking Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmLogin.Show()
                    Me.Close()
                Catch ex As ArgumentException
                    MessageBox.Show(ex.Message, "Parking Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Confirm password not matched", "Parking Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
          
        End If
    End Sub
End Class