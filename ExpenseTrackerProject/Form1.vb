Public Class Main_Page
    Private Sub Btn_Income_Click(sender As Object, e As EventArgs) Handles Btn_Income.Click
        Dim GoIncomeForm As New Form_Income2()
        GoIncomeForm.Show()
        Me.Hide()
    End Sub
End Class
