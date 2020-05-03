<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Class_Rec
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dataLab = New System.Windows.Forms.Label()
        Me.listSCG = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.classCloseBtn = New System.Windows.Forms.Button()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.classSeaTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.listCG = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.claHeadTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.claStreTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.claUPTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.listSCG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.listCG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 60)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dataLab)
        Me.Panel3.Controls.Add(Me.listSCG)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(51, 185)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(799, 201)
        Me.Panel3.TabIndex = 15
        '
        'dataLab
        '
        Me.dataLab.AutoSize = True
        Me.dataLab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataLab.Location = New System.Drawing.Point(8, 11)
        Me.dataLab.Name = "dataLab"
        Me.dataLab.Size = New System.Drawing.Size(83, 21)
        Me.dataLab.TabIndex = 39
        Me.dataLab.Text = "Default  : "
        '
        'listSCG
        '
        Me.listSCG.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listSCG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.listSCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listSCG.DefaultCellStyle = DataGridViewCellStyle2
        Me.listSCG.Location = New System.Drawing.Point(12, 66)
        Me.listSCG.Name = "listSCG"
        Me.listSCG.Size = New System.Drawing.Size(772, 112)
        Me.listSCG.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "View All Students In Specific Classes : "
        '
        'classCloseBtn
        '
        Me.classCloseBtn.BackColor = System.Drawing.Color.White
        Me.classCloseBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classCloseBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.classCloseBtn.Location = New System.Drawing.Point(754, 67)
        Me.classCloseBtn.Name = "classCloseBtn"
        Me.classCloseBtn.Size = New System.Drawing.Size(96, 32)
        Me.classCloseBtn.TabIndex = 14
        Me.classCloseBtn.Text = "Close"
        Me.classCloseBtn.UseVisualStyleBackColor = False
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.White
        Me.searchBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.searchBtn.Location = New System.Drawing.Point(342, 63)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(96, 32)
        Me.searchBtn.TabIndex = 12
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'classSeaTxtBox
        '
        Me.classSeaTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classSeaTxtBox.Location = New System.Drawing.Point(168, 67)
        Me.classSeaTxtBox.Name = "classSeaTxtBox"
        Me.classSeaTxtBox.Size = New System.Drawing.Size(146, 25)
        Me.classSeaTxtBox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Class ID : "
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.listCG)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(51, 392)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(799, 296)
        Me.Panel4.TabIndex = 16
        '
        'listCG
        '
        Me.listCG.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listCG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.listCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listCG.DefaultCellStyle = DataGridViewCellStyle4
        Me.listCG.Location = New System.Drawing.Point(12, 46)
        Me.listCG.Name = "listCG"
        Me.listCG.Size = New System.Drawing.Size(772, 235)
        Me.listCG.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "See All Classes : "
        '
        'claHeadTxtBox
        '
        Me.claHeadTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.claHeadTxtBox.Location = New System.Drawing.Point(204, 141)
        Me.claHeadTxtBox.Name = "claHeadTxtBox"
        Me.claHeadTxtBox.Size = New System.Drawing.Size(146, 29)
        Me.claHeadTxtBox.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Class Head : "
        '
        'claStreTxtBox
        '
        Me.claStreTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.claStreTxtBox.Location = New System.Drawing.Point(205, 108)
        Me.claStreTxtBox.Name = "claStreTxtBox"
        Me.claStreTxtBox.Size = New System.Drawing.Size(146, 29)
        Me.claStreTxtBox.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Class Strength : "
        '
        'claUPTxtBox
        '
        Me.claUPTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.claUPTxtBox.Location = New System.Drawing.Point(797, 111)
        Me.claUPTxtBox.Name = "claUPTxtBox"
        Me.claUPTxtBox.Size = New System.Drawing.Size(53, 25)
        Me.claUPTxtBox.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(750, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "ID : "
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.White
        Me.updateBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.updateBtn.Location = New System.Drawing.Point(754, 142)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(96, 32)
        Me.updateBtn.TabIndex = 36
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'Class_Rec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.claUPTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.claStreTxtBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.claHeadTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.classCloseBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.classSeaTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Class_Rec"
        Me.Size = New System.Drawing.Size(880, 706)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.listSCG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.listCG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents classCloseBtn As Button
    Friend WithEvents searchBtn As Button
    Friend WithEvents classSeaTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents listCG As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents listSCG As DataGridView
    Friend WithEvents claHeadTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents claStreTxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents claUPTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents dataLab As Label
End Class
