Public Class Form_Income2
    Private Sub Form_Income_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Expense2_Click(sender As Object, e As EventArgs) Handles Btn_Expense2.Click
        Dim GoExpenseForm As New Form_Expense()
        GoExpenseForm.Show()
        Me.Hide()

    End Sub
End Class