<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fee
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dataLab = New System.Windows.Forms.Label()
        Me.listFG = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.feeCloseBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.addFeeBtn = New System.Windows.Forms.Button()
        Me.stuSeaTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.feeSlipTxtBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.remFeeTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.admitFeeTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.feeUPTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.datePic = New System.Windows.Forms.DateTimePicker()
        Me.feeTxtBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.listFG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 60)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fee Information"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.feeTxtBox)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.delBtn)
        Me.Panel3.Controls.Add(Me.listFG)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(35, 314)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(751, 270)
        Me.Panel3.TabIndex = 3
        '
        'dataLab
        '
        Me.dataLab.AutoSize = True
        Me.dataLab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataLab.Location = New System.Drawing.Point(34, 112)
        Me.dataLab.Name = "dataLab"
        Me.dataLab.Size = New System.Drawing.Size(98, 21)
        Me.dataLab.TabIndex = 23
        Me.dataLab.Text = "Enter Data :"
        '
        'listFG
        '
        Me.listFG.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listFG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.listFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listFG.DefaultCellStyle = DataGridViewCellStyle2
        Me.listFG.Location = New System.Drawing.Point(3, 52)
        Me.listFG.Name = "listFG"
        Me.listFG.Size = New System.Drawing.Size(727, 213)
        Me.listFG.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "View Students Fee Status : "
        '
        'feeCloseBtn
        '
        Me.feeCloseBtn.BackColor = System.Drawing.Color.White
        Me.feeCloseBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feeCloseBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.feeCloseBtn.Location = New System.Drawing.Point(691, 73)
        Me.feeCloseBtn.Name = "feeCloseBtn"
        Me.feeCloseBtn.Size = New System.Drawing.Size(96, 32)
        Me.feeCloseBtn.TabIndex = 9
        Me.feeCloseBtn.Text = "Close"
        Me.feeCloseBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(394, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'addFeeBtn
        '
        Me.addFeeBtn.BackColor = System.Drawing.Color.White
        Me.addFeeBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addFeeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.addFeeBtn.Location = New System.Drawing.Point(230, 107)
        Me.addFeeBtn.Name = "addFeeBtn"
        Me.addFeeBtn.Size = New System.Drawing.Size(96, 32)
        Me.addFeeBtn.TabIndex = 7
        Me.addFeeBtn.Text = "Add"
        Me.addFeeBtn.UseVisualStyleBackColor = False
        '
        'stuSeaTxtBox
        '
        Me.stuSeaTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stuSeaTxtBox.Location = New System.Drawing.Point(134, 71)
        Me.stuSeaTxtBox.Name = "stuSeaTxtBox"
        Me.stuSeaTxtBox.Size = New System.Drawing.Size(87, 23)
        Me.stuSeaTxtBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Roll No : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datePic)
        Me.GroupBox1.Controls.Add(Me.feeSlipTxtBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.remFeeTxtBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.admitFeeTxtBox)
        Me.GroupBox1.Controls.Add(Me.addFeeBtn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 145)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Record"
        '
        'feeSlipTxtBox
        '
        Me.feeSlipTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feeSlipTxtBox.Location = New System.Drawing.Point(133, 77)
        Me.feeSlipTxtBox.Name = "feeSlipTxtBox"
        Me.feeSlipTxtBox.Size = New System.Drawing.Size(87, 23)
        Me.feeSlipTxtBox.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 21)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Fee Slip No : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(293, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Date : "
        '
        'remFeeTxtBox
        '
        Me.remFeeTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remFeeTxtBox.Location = New System.Drawing.Point(357, 37)
        Me.remFeeTxtBox.Name = "remFeeTxtBox"
        Me.remFeeTxtBox.Size = New System.Drawing.Size(87, 23)
        Me.remFeeTxtBox.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 21)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Fee Remainig : "
        '
        'admitFeeTxtBox
        '
        Me.admitFeeTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admitFeeTxtBox.Location = New System.Drawing.Point(133, 39)
        Me.admitFeeTxtBox.Name = "admitFeeTxtBox"
        Me.admitFeeTxtBox.Size = New System.Drawing.Size(87, 23)
        Me.admitFeeTxtBox.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Amount : "
        '
        'feeUPTxtBox
        '
        Me.feeUPTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feeUPTxtBox.Location = New System.Drawing.Point(734, 203)
        Me.feeUPTxtBox.Name = "feeUPTxtBox"
        Me.feeUPTxtBox.Size = New System.Drawing.Size(53, 25)
        Me.feeUPTxtBox.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(687, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "ID : "
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.White
        Me.updateBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.updateBtn.Location = New System.Drawing.Point(691, 234)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(96, 32)
        Me.updateBtn.TabIndex = 39
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'datePic
        '
        Me.datePic.CustomFormat = "dd-MM-yyyy"
        Me.datePic.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePic.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datePic.Location = New System.Drawing.Point(357, 67)
        Me.datePic.Name = "datePic"
        Me.datePic.Size = New System.Drawing.Size(132, 29)
        Me.datePic.TabIndex = 33
        '
        'feeTxtBox
        '
        Me.feeTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feeTxtBox.Location = New System.Drawing.Point(548, 21)
        Me.feeTxtBox.Name = "feeTxtBox"
        Me.feeTxtBox.Size = New System.Drawing.Size(59, 25)
        Me.feeTxtBox.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(489, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 21)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "ID : "
        '
        'delBtn
        '
        Me.delBtn.BackColor = System.Drawing.Color.White
        Me.delBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.delBtn.Location = New System.Drawing.Point(626, 16)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(96, 32)
        Me.delBtn.TabIndex = 24
        Me.delBtn.Text = "Delete"
        Me.delBtn.UseVisualStyleBackColor = False
        '
        'Fee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.feeUPTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.dataLab)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.stuSeaTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.feeCloseBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Fee"
        Me.Size = New System.Drawing.Size(804, 599)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.listFG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents feeCloseBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents addFeeBtn As Button
    Friend WithEvents stuSeaTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents listFG As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents feeSlipTxtBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents remFeeTxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents admitFeeTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dataLab As Label
    Friend WithEvents feeUPTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents datePic As DateTimePicker
    Friend WithEvents feeTxtBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents delBtn As Button
End Class
