Public Class Main_Page

    Private Sub Btn_Income_Click(sender As Object, e As EventArgs) Handles Btn_Income.Click
        Dim GoIncomeForm As New Form_Income2()
        GoIncomeForm.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Expense_Click(sender As Object, e As EventArgs) Handles Btn_Expense.Click
        Dim GoExpenseForm As New Form_Expense()
        GoExpenseForm.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
