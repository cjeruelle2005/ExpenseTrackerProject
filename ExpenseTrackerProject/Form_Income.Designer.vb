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
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
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
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 31)
        Label2.TabIndex = 10
        Label2.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(228, 35)
        Label4.TabIndex = 11
        Label4.Text = "YYYY-MM-DD"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(33, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 31)
        Label3.TabIndex = 12
        Label3.Text = "Description"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(33, 339)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(404, 41)
        TextBox1.TabIndex = 13
        TextBox1.Text = "Short Description"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(33, 434)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 31)
        Label5.TabIndex = 14
        Label5.Text = "Amount"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(33, 468)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(404, 41)
        TextBox2.TabIndex = 15
        TextBox2.Text = "0.00"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(304, 220)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 36)
        Button1.TabIndex = 16
        Button1.Text = "CHANGE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(587, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 31)
        Label6.TabIndex = 24
        Label6.Text = "Category"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"--Select--", "Food", "Transport"})
        ComboBox1.Location = New Point(587, 224)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(287, 37)
        ComboBox1.TabIndex = 25
        ' 
        ' Form_Income2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(1168, 662)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Btn_Wallet2)
        Controls.Add(Btn_Statistic2)
        Controls.Add(Btn_Expense2)
        Controls.Add(Btn_Income)
        Controls.Add(Label1)
        Name = "Form_Income2"
        Text = "                                                                       "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_Wallet2 As Button
    Friend WithEvents Btn_Statistic2 As Button
    Friend WithEvents Btn_Expense2 As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
