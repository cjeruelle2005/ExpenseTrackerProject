<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Btn_Income = New Button()
        Btn_Expense = New Button()
        Btn_Statistic = New Button()
        Btn_Wallet = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1168, 163)
        Label1.TabIndex = 0
        Label1.Text = "Hello, User"
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonHighlight
        Btn_Income.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Income.Location = New Point(33, 123)
        Btn_Income.Name = "Btn_Income"
        Btn_Income.Size = New Size(271, 40)
        Btn_Income.TabIndex = 1
        Btn_Income.Text = "INCOME"
        Btn_Income.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonHighlight
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Expense.Location = New Point(310, 123)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(271, 40)
        Btn_Expense.TabIndex = 2
        Btn_Expense.Text = "EXPENSE"
        Btn_Expense.UseVisualStyleBackColor = False
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonHighlight
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Statistic.Location = New Point(587, 123)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(271, 40)
        Btn_Statistic.TabIndex = 3
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Btn_Wallet
        ' 
        Btn_Wallet.BackColor = SystemColors.ButtonHighlight
        Btn_Wallet.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Wallet.Location = New Point(864, 123)
        Btn_Wallet.Name = "Btn_Wallet"
        Btn_Wallet.Size = New Size(271, 40)
        Btn_Wallet.TabIndex = 4
        Btn_Wallet.Text = "WALLET"
        Btn_Wallet.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 31)
        Label2.TabIndex = 5
        Label2.Text = "Balance"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(33, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 35)
        Label3.TabIndex = 6
        Label3.Text = "₱"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(67, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(215, 35)
        Label4.TabIndex = 7
        Label4.Text = "0.00"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(33, 313)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1102, 337)
        TextBox1.TabIndex = 8
        ' 
        ' Main_Page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(1168, 662)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Btn_Wallet)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Label1)
        Name = "Main_Page"
        Text = "Main Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Btn_Wallet As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox

End Class
