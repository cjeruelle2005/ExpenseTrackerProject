<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Expense
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
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
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
        Btn_Statistic.BackColor = SystemColors.ButtonHighlight
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
        Btn_Expense.BackColor = SystemColors.ButtonShadow
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
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 31)
        Label2.TabIndex = 11
        Label2.Text = "Date"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(33, 468)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(404, 41)
        TextBox2.TabIndex = 20
        TextBox2.Text = "0.00"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(33, 434)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 31)
        Label5.TabIndex = 19
        Label5.Text = "Amount"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(33, 339)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(404, 41)
        TextBox1.TabIndex = 18
        TextBox1.Text = "Short Description"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(228, 35)
        Label4.TabIndex = 17
        Label4.Text = "YYYY-MM-DD"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(33, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 31)
        Label3.TabIndex = 22
        Label3.Text = "Description"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(587, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 31)
        Label6.TabIndex = 23
        Label6.Text = "Category"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Bills", "Clothing", "Education", "Entertainment", "Fitness", "Food", "Gifts", "Health", "Furniture", "Pet", "Shopping", "Transportation", "Travel", "Others"})
        ComboBox1.Location = New Point(587, 224)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(287, 37)
        ComboBox1.TabIndex = 24
        ComboBox1.Text = "Select Category"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(33, 259)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(474, 41)
        DateTimePicker1.TabIndex = 25
        ' 
        ' Form_Expense
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(1168, 662)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Btn_Wallet)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Label1)
        Name = "Form_Expense"
        Text = "Form_Expense"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_Wallet As Button
    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
