Public Class frmLogin
    Dim accessLogin As New clsAccessSystem()
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        frmRegister.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            accessLogin.Username = txtUsername.Text.Trim
            accessLogin.Password = txtPassword.Text.Trim
            accessLogin.Access = cmbUserType.SelectedItem.ToString()
            If accessLogin.UserLogin() Then
                MessageBox.Show("Welcome " + logLevel + " " + txtUsername.Text.Trim, "Parking Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Parking Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            txtpassword.Focus()
        End If
    End Sub
    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                accessLogin.Username = txtUsername.Text.Trim
                accessLogin.Password = txtpassword.Text.Trim
                If accessLogin.UserLogin() Then
                      MessageBox.Show("Welcome " + logLevel + " " + txtUsername.Text.Trim, "Parking Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                End If
            Catch ex As ArgumentException
                MessageBox.Show(ex.Message, "SPECSNTREND INC.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
