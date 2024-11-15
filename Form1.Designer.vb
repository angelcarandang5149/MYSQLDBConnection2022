<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnTest = New Button()
        Username = New Label()
        TextBox_Un = New TextBox()
        Password = New Label()
        TextBox_Pass = New TextBox()
        Login = New Button()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.BackColor = SystemColors.ControlLight
        btnTest.Location = New Point(9, 9)
        btnTest.Margin = New Padding(0)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(600, 40)
        btnTest.TabIndex = 0
        btnTest.Text = "CHECK CONNECTION"
        btnTest.UseVisualStyleBackColor = False
        ' 
        ' Username
        ' 
        Username.Font = New Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Username.Location = New Point(115, 90)
        Username.Name = "Username"
        Username.Size = New Size(165, 28)
        Username.TabIndex = 1
        Username.Text = "Username"
        ' 
        ' TextBox_Un
        ' 
        TextBox_Un.Location = New Point(246, 87)
        TextBox_Un.Multiline = True
        TextBox_Un.Name = "TextBox_Un"
        TextBox_Un.Size = New Size(244, 31)
        TextBox_Un.TabIndex = 2
        ' 
        ' Password
        ' 
        Password.Font = New Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Password.Location = New Point(115, 127)
        Password.Name = "Password"
        Password.Size = New Size(145, 33)
        Password.TabIndex = 3
        Password.Text = "Password"
        ' 
        ' TextBox_Pass
        ' 
        TextBox_Pass.Location = New Point(246, 124)
        TextBox_Pass.Multiline = True
        TextBox_Pass.Name = "TextBox_Pass"
        TextBox_Pass.PasswordChar = "*"c
        TextBox_Pass.Size = New Size(244, 31)
        TextBox_Pass.TabIndex = 4
        ' 
        ' Login
        ' 
        Login.Location = New Point(284, 173)
        Login.Name = "Login"
        Login.Size = New Size(112, 37)
        Login.TabIndex = 5
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(618, 284)
        Controls.Add(Login)
        Controls.Add(TextBox_Pass)
        Controls.Add(Password)
        Controls.Add(TextBox_Un)
        Controls.Add(Username)
        Controls.Add(btnTest)
        Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
        Text = "MYSQL DATABASE CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents Username As Label
    Friend WithEvents TextBox_Un As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents TextBox_Pass As TextBox
    Friend WithEvents Login As Button

End Class
