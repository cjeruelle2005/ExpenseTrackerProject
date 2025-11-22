<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Income2
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
        Btn_Wallet2 = New Button()
        Btn_Statistic2 = New Button()
        Btn_Expense2 = New Button()
        Btn_Income = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Btn_Wallet2
        ' 
        Btn_Wallet2.BackColor = SystemColors.ButtonHighlight
        Btn_Wallet2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Wallet2.Location = New Point(864, 123)
        Btn_Wallet2.Name = "Btn_Wallet2"
        Btn_Wallet2.Size = New Size(271, 40)
        Btn_Wallet2.TabIndex = 9
        Btn_Wallet2.Text = "WALLET"
        Btn_Wallet2.UseVisualStyleBackColor = False
        ' 
        ' Btn_Statistic2
        ' 
        Btn_Statistic2.BackColor = SystemColors.ButtonHighlight
        Btn_Statistic2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Statistic2.Location = New Point(587, 123)
        Btn_Statistic2.Name = "Btn_Statistic2"
        Btn_Statistic2.Size = New Size(271, 40)
        Btn_Statistic2.TabIndex = 8
        Btn_Statistic2.Text = "STATISTIC"
        Btn_Statistic2.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense2
        ' 
        Btn_Expense2.BackColor = SystemColors.ButtonHighlight
        Btn_Expense2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Expense2.Location = New Point(310, 123)
        Btn_Expense2.Name = "Btn_Expense2"
        Btn_Expense2.Size = New Size(271, 40)
        Btn_Expense2.TabIndex = 7
        Btn_Expense2.Text = "EXPENSE"
        Btn_Expense2.UseVisualStyleBackColor = False
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonShadow
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
        ' Form_Income2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(1168, 662)
        Controls.Add(Btn_Wallet2)
        Controls.Add(Btn_Statistic2)
        Controls.Add(Btn_Expense2)
        Controls.Add(Btn_Income)
        Controls.Add(Label1)
        Name = "Form_Income2"
        Text = "Form_Income"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_Wallet2 As Button
    Friend WithEvents Btn_Statistic2 As Button
    Friend WithEvents Btn_Expense2 As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Label1 As Label
End Class
