<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Statistic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Btn_Wallet = New Button()
        Btn_Statistic = New Button()
        Btn_Expense = New Button()
        Btn_Income = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Btn_Wallet
        ' 
        Btn_Wallet.BackColor = SystemColors.ButtonHighlight
        Btn_Wallet.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Wallet.Location = New Point(864, 123)
        Btn_Wallet.Name = "Btn_Wallet"
        Btn_Wallet.Size = New Size(271, 40)
        Btn_Wallet.TabIndex = 9
        Btn_Wallet.Text = "WALLET"
        Btn_Wallet.UseVisualStyleBackColor = False
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonShadow
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Statistic.Location = New Point(587, 123)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(271, 40)
        Btn_Statistic.TabIndex = 8
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonHighlight
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Expense.Location = New Point(310, 123)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(271, 40)
        Btn_Expense.TabIndex = 7
        Btn_Expense.Text = "EXPENSE"
        Btn_Expense.UseVisualStyleBackColor = False
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonHighlight
        Btn_Income.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Income.Location = New Point(33, 123)
        Btn_Income.Name = "Btn_Income"
        Btn_Income.Size = New Size(271, 40)
        Btn_Income.TabIndex = 6
        Btn_Income.Text = "INCOME"
        Btn_Income.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1168, 163)
        Label1.TabIndex = 5
        Label1.Text = "Hello, User"
        ' 
        ' Form_Statistic
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(1168, 662)
        Controls.Add(Btn_Wallet)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Label1)
        Name = "Form_Statistic"
        Text = "Form_Statistic"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_Wallet As Button
    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Label1 As Label
End Class
