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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
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
        ListBox1 = New ListBox()
        LoadTable = New Button()
        DataList = New DataGridView()
        Search_txt = New TextBox()
        Chart1 = New DataVisualization.Charting.Chart()
        Load_Chart = New Button()
        CType(DataList, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SignOut
        ' 
        SignOut.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignOut.Location = New Point(12, 12)
        SignOut.Name = "SignOut"
        SignOut.Size = New Size(133, 44)
        SignOut.TabIndex = 0
        SignOut.Text = "SignOut"
        SignOut.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 29)
        Label1.TabIndex = 1
        Label1.Text = "Eid"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 29)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(9, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 29)
        Label3.TabIndex = 3
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 29)
        Label4.TabIndex = 4
        Label4.Text = "Age"
        ' 
        ' TextBox_Eid
        ' 
        TextBox_Eid.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Eid.Location = New Point(142, 86)
        TextBox_Eid.Multiline = True
        TextBox_Eid.Name = "TextBox_Eid"
        TextBox_Eid.Size = New Size(232, 32)
        TextBox_Eid.TabIndex = 5
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Name.Location = New Point(142, 124)
        TextBox_Name.Multiline = True
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.Size = New Size(232, 32)
        TextBox_Name.TabIndex = 6
        ' 
        ' TextBox_SurNm
        ' 
        TextBox_SurNm.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_SurNm.Location = New Point(142, 162)
        TextBox_SurNm.Multiline = True
        TextBox_SurNm.Name = "TextBox_SurNm"
        TextBox_SurNm.Size = New Size(232, 32)
        TextBox_SurNm.TabIndex = 7
        ' 
        ' TextBox_Age
        ' 
        TextBox_Age.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Age.Location = New Point(142, 200)
        TextBox_Age.Multiline = True
        TextBox_Age.Name = "TextBox_Age"
        TextBox_Age.Size = New Size(232, 32)
        TextBox_Age.TabIndex = 8
        ' 
        ' Save
        ' 
        Save.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Save.Location = New Point(12, 256)
        Save.Name = "Save"
        Save.Size = New Size(124, 43)
        Save.TabIndex = 9
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Update
        ' 
        Update.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Update.Location = New Point(12, 305)
        Update.Name = "Update"
        Update.Size = New Size(124, 43)
        Update.TabIndex = 10
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = True
        ' 
        ' Delete
        ' 
        Delete.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Delete.Location = New Point(12, 354)
        Delete.Name = "Delete"
        Delete.Size = New Size(124, 43)
        Delete.TabIndex = 11
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = True
        ' 
        ' List
        ' 
        List.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        List.FormattingEnabled = True
        List.Location = New Point(151, 22)
        List.Name = "List"
        List.Size = New Size(281, 34)
        List.TabIndex = 12
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 26
        ListBox1.Location = New Point(438, 22)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(288, 56)
        ListBox1.TabIndex = 13
        ' 
        ' LoadTable
        ' 
        LoadTable.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoadTable.Location = New Point(815, 22)
        LoadTable.Name = "LoadTable"
        LoadTable.Size = New Size(169, 43)
        LoadTable.TabIndex = 14
        LoadTable.Text = "Load Table"
        LoadTable.UseVisualStyleBackColor = True
        ' 
        ' DataList
        ' 
        DataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataList.Location = New Point(380, 84)
        DataList.Name = "DataList"
        DataList.RowHeadersWidth = 51
        DataList.Size = New Size(429, 148)
        DataList.TabIndex = 15
        ' 
        ' Search_txt
        ' 
        Search_txt.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Search_txt.Location = New Point(815, 86)
        Search_txt.Multiline = True
        Search_txt.Name = "Search_txt"
        Search_txt.Size = New Size(226, 32)
        Search_txt.TabIndex = 16
        ' 
        ' Chart1
        ' 
        ChartArea3.AxisX.Interval = 1R
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Angle = -90
        ChartArea3.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Chart1.Legends.Add(Legend3)
        Chart1.Location = New Point(196, 256)
        Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Name_vs_Age"
        Chart1.Series.Add(Series3)
        Chart1.Size = New Size(826, 308)
        Chart1.TabIndex = 17
        Chart1.Text = "Chart1"
        ' 
        ' Load_Chart
        ' 
        Load_Chart.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Load_Chart.Location = New Point(833, 189)
        Load_Chart.Name = "Load_Chart"
        Load_Chart.Size = New Size(169, 43)
        Load_Chart.TabIndex = 18
        Load_Chart.Text = "Load Chart"
        Load_Chart.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1053, 576)
        Controls.Add(Load_Chart)
        Controls.Add(Chart1)
        Controls.Add(Search_txt)
        Controls.Add(DataList)
        Controls.Add(LoadTable)
        Controls.Add(ListBox1)
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
        CType(DataList, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LoadTable As Button
    Friend WithEvents DataList As DataGridView
    Friend WithEvents Search_txt As TextBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Load_Chart As Button
End Class
