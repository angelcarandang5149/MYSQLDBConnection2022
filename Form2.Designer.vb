<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        SignOut = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox_Eid = New TextBox()
        TextBox_Name = New TextBox()
        TextBox_SurNm = New TextBox()
        TextBox_Age = New TextBox()
        Save = New Button()
        Update = New Button()
        Delete = New Button()
        List = New ComboBox()
        SuspendLayout()
        ' 
        ' SignOut
        ' 
        SignOut.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignOut.Location = New Point(12, 12)
        SignOut.Name = "SignOut"
        SignOut.Size = New Size(135, 42)
        SignOut.TabIndex = 0
        SignOut.Text = "SignOut"
        SignOut.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 29)
        Label1.TabIndex = 1
        Label1.Text = "Eid"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 29)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 29)
        Label3.TabIndex = 3
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 29)
        Label4.TabIndex = 4
        Label4.Text = "Age"
        ' 
        ' TextBox_Eid
        ' 
        TextBox_Eid.Location = New Point(154, 76)
        TextBox_Eid.Multiline = True
        TextBox_Eid.Name = "TextBox_Eid"
        TextBox_Eid.Size = New Size(232, 34)
        TextBox_Eid.TabIndex = 5
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Location = New Point(154, 116)
        TextBox_Name.Multiline = True
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.Size = New Size(232, 34)
        TextBox_Name.TabIndex = 6
        ' 
        ' TextBox_SurNm
        ' 
        TextBox_SurNm.Location = New Point(154, 156)
        TextBox_SurNm.Multiline = True
        TextBox_SurNm.Name = "TextBox_SurNm"
        TextBox_SurNm.Size = New Size(232, 34)
        TextBox_SurNm.TabIndex = 7
        ' 
        ' TextBox_Age
        ' 
        TextBox_Age.Location = New Point(154, 196)
        TextBox_Age.Multiline = True
        TextBox_Age.Name = "TextBox_Age"
        TextBox_Age.Size = New Size(232, 34)
        TextBox_Age.TabIndex = 8
        ' 
        ' Save
        ' 
        Save.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Save.Location = New Point(80, 254)
        Save.Name = "Save"
        Save.Size = New Size(135, 42)
        Save.TabIndex = 9
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Update
        ' 
        Update.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Update.Location = New Point(241, 254)
        Update.Name = "Update"
        Update.Size = New Size(135, 42)
        Update.TabIndex = 10
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = True
        ' 
        ' Delete
        ' 
        Delete.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Delete.Location = New Point(80, 314)
        Delete.Name = "Delete"
        Delete.Size = New Size(135, 42)
        Delete.TabIndex = 11
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = True
        ' 
        ' List
        ' 
        List.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        List.FormattingEnabled = True
        List.Location = New Point(405, 76)
        List.Name = "List"
        List.Size = New Size(281, 34)
        List.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(760, 396)
        Controls.Add(List)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(Save)
        Controls.Add(TextBox_Age)
        Controls.Add(TextBox_SurNm)
        Controls.Add(TextBox_Name)
        Controls.Add(TextBox_Eid)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SignOut)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SignOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Eid As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents TextBox_SurNm As TextBox
    Friend WithEvents TextBox_Age As TextBox
    Friend WithEvents Save As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents List As ComboBox
End Class
