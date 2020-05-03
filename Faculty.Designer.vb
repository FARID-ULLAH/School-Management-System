<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.teadelTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.listFG = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.idUTxtBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.femaleBox = New System.Windows.Forms.CheckBox()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.maleBox = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dataLab = New System.Windows.Forms.Label()
        Me.facCloseBtn = New System.Windows.Forms.Button()
        Me.facAddBtn = New System.Windows.Forms.Button()
        Me.datePic = New System.Windows.Forms.DateTimePicker()
        Me.desigTxtBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addressTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.contactTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.eduTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teafathTxtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.teaTxtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.listFG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faculty"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.teadelTxtBox)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.delBtn)
        Me.Panel3.Controls.Add(Me.listFG)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(24, 397)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(754, 275)
        Me.Panel3.TabIndex = 7
        '
        'teadelTxtBox
        '
        Me.teadelTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teadelTxtBox.Location = New System.Drawing.Point(560, 16)
        Me.teadelTxtBox.Name = "teadelTxtBox"
        Me.teadelTxtBox.Size = New System.Drawing.Size(59, 25)
        Me.teadelTxtBox.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(516, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ID : "
        '
        'delBtn
        '
        Me.delBtn.BackColor = System.Drawing.Color.White
        Me.delBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.delBtn.Location = New System.Drawing.Point(638, 11)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(96, 32)
        Me.delBtn.TabIndex = 14
        Me.delBtn.Text = "Delete"
        Me.delBtn.UseVisualStyleBackColor = False
        '
        'listFG
        '
        Me.listFG.AllowUserToOrderColumns = True
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
        Me.listFG.Location = New System.Drawing.Point(18, 53)
        Me.listFG.Name = "listFG"
        Me.listFG.Size = New System.Drawing.Size(716, 217)
        Me.listFG.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "View All Faculty : "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.idUTxtBox)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.femaleBox)
        Me.Panel2.Controls.Add(Me.updateBtn)
        Me.Panel2.Controls.Add(Me.maleBox)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.dataLab)
        Me.Panel2.Controls.Add(Me.facCloseBtn)
        Me.Panel2.Controls.Add(Me.facAddBtn)
        Me.Panel2.Controls.Add(Me.datePic)
        Me.Panel2.Controls.Add(Me.desigTxtBox)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.addressTxt)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.contactTxt)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.eduTxt)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.teafathTxtName)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.teaTxtName)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(24, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(753, 287)
        Me.Panel2.TabIndex = 9
        '
        'idUTxtBox
        '
        Me.idUTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idUTxtBox.Location = New System.Drawing.Point(695, 215)
        Me.idUTxtBox.Name = "idUTxtBox"
        Me.idUTxtBox.Size = New System.Drawing.Size(53, 25)
        Me.idUTxtBox.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(651, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 21)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "ID : "
        '
        'femaleBox
        '
        Me.femaleBox.AutoSize = True
        Me.femaleBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleBox.Location = New System.Drawing.Point(236, 164)
        Me.femaleBox.Name = "femaleBox"
        Me.femaleBox.Size = New System.Drawing.Size(70, 21)
        Me.femaleBox.TabIndex = 37
        Me.femaleBox.Text = "Female"
        Me.femaleBox.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.White
        Me.updateBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.updateBtn.Location = New System.Drawing.Point(652, 246)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(96, 32)
        Me.updateBtn.TabIndex = 19
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'maleBox
        '
        Me.maleBox.AutoSize = True
        Me.maleBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleBox.Location = New System.Drawing.Point(165, 164)
        Me.maleBox.Name = "maleBox"
        Me.maleBox.Size = New System.Drawing.Size(56, 21)
        Me.maleBox.TabIndex = 36
        Me.maleBox.Text = "Male"
        Me.maleBox.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 21)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Gender : "
        '
        'dataLab
        '
        Me.dataLab.AutoSize = True
        Me.dataLab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataLab.Location = New System.Drawing.Point(14, 12)
        Me.dataLab.Name = "dataLab"
        Me.dataLab.Size = New System.Drawing.Size(98, 21)
        Me.dataLab.TabIndex = 34
        Me.dataLab.Text = "Enter Data :"
        '
        'facCloseBtn
        '
        Me.facCloseBtn.BackColor = System.Drawing.Color.White
        Me.facCloseBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facCloseBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.facCloseBtn.Location = New System.Drawing.Point(648, 12)
        Me.facCloseBtn.Name = "facCloseBtn"
        Me.facCloseBtn.Size = New System.Drawing.Size(96, 32)
        Me.facCloseBtn.TabIndex = 33
        Me.facCloseBtn.Text = "Close"
        Me.facCloseBtn.UseVisualStyleBackColor = False
        '
        'facAddBtn
        '
        Me.facAddBtn.BackColor = System.Drawing.Color.White
        Me.facAddBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facAddBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.facAddBtn.Location = New System.Drawing.Point(546, 12)
        Me.facAddBtn.Name = "facAddBtn"
        Me.facAddBtn.Size = New System.Drawing.Size(96, 32)
        Me.facAddBtn.TabIndex = 32
        Me.facAddBtn.Text = "Add"
        Me.facAddBtn.UseVisualStyleBackColor = False
        '
        'datePic
        '
        Me.datePic.CustomFormat = "dd-MM-yyyy"
        Me.datePic.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePic.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datePic.Location = New System.Drawing.Point(480, 160)
        Me.datePic.Name = "datePic"
        Me.datePic.Size = New System.Drawing.Size(126, 29)
        Me.datePic.TabIndex = 31
        '
        'desigTxtBox
        '
        Me.desigTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desigTxtBox.Location = New System.Drawing.Point(480, 114)
        Me.desigTxtBox.Name = "desigTxtBox"
        Me.desigTxtBox.Size = New System.Drawing.Size(156, 25)
        Me.desigTxtBox.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(333, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 21)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Designation : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(359, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Hire Date : "
        '
        'addressTxt
        '
        Me.addressTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTxt.Location = New System.Drawing.Point(148, 232)
        Me.addressTxt.Multiline = True
        Me.addressTxt.Name = "addressTxt"
        Me.addressTxt.Size = New System.Drawing.Size(454, 33)
        Me.addressTxt.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Address : "
        '
        'contactTxt
        '
        Me.contactTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactTxt.Location = New System.Drawing.Point(148, 190)
        Me.contactTxt.Name = "contactTxt"
        Me.contactTxt.Size = New System.Drawing.Size(251, 25)
        Me.contactTxt.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Contact No : "
        '
        'eduTxt
        '
        Me.eduTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eduTxt.Location = New System.Drawing.Point(148, 114)
        Me.eduTxt.Name = "eduTxt"
        Me.eduTxt.Size = New System.Drawing.Size(176, 25)
        Me.eduTxt.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Education : "
        '
        'teafathTxtName
        '
        Me.teafathTxtName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teafathTxtName.Location = New System.Drawing.Point(504, 75)
        Me.teafathTxtName.Name = "teafathTxtName"
        Me.teafathTxtName.Size = New System.Drawing.Size(156, 25)
        Me.teafathTxtName.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Father Name : "
        '
        'teaTxtName
        '
        Me.teaTxtName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teaTxtName.Location = New System.Drawing.Point(148, 75)
        Me.teaTxtName.Name = "teaTxtName"
        Me.teaTxtName.Size = New System.Drawing.Size(176, 25)
        Me.teaTxtName.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Teacher Name : "
        '
        'Faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Faculty"
        Me.Size = New System.Drawing.Size(804, 688)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.listFG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents addressTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents contactTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents eduTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents teafathTxtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents teaTxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents desigTxtBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents listFG As DataGridView
    Friend WithEvents datePic As DateTimePicker
    Friend WithEvents delBtn As Button
    Friend WithEvents teadelTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents idUTxtBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents femaleBox As CheckBox
    Friend WithEvents maleBox As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dataLab As Label
    Friend WithEvents facCloseBtn As Button
    Friend WithEvents facAddBtn As Button
End Class
