<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.feebtn = New System.Windows.Forms.Button()
        Me.classBtn = New System.Windows.Forms.Button()
        Me.stuBtn = New System.Windows.Forms.Button()
        Me.facBtn = New System.Windows.Forms.Button()
        Me.examBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.feebtn)
        Me.Panel1.Controls.Add(Me.classBtn)
        Me.Panel1.Controls.Add(Me.stuBtn)
        Me.Panel1.Controls.Add(Me.facBtn)
        Me.Panel1.Controls.Add(Me.examBtn)
        Me.Panel1.Controls.Add(Me.exitBtn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 741)
        Me.Panel1.TabIndex = 0
        '
        'feebtn
        '
        Me.feebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.feebtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feebtn.ForeColor = System.Drawing.Color.White
        Me.feebtn.Image = CType(resources.GetObject("feebtn.Image"), System.Drawing.Image)
        Me.feebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.feebtn.Location = New System.Drawing.Point(4, 434)
        Me.feebtn.Margin = New System.Windows.Forms.Padding(5)
        Me.feebtn.Name = "feebtn"
        Me.feebtn.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.feebtn.Size = New System.Drawing.Size(262, 45)
        Me.feebtn.TabIndex = 10
        Me.feebtn.Text = "Fee"
        Me.feebtn.UseVisualStyleBackColor = False
        '
        'classBtn
        '
        Me.classBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.classBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classBtn.ForeColor = System.Drawing.Color.White
        Me.classBtn.Image = CType(resources.GetObject("classBtn.Image"), System.Drawing.Image)
        Me.classBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.classBtn.Location = New System.Drawing.Point(4, 337)
        Me.classBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.classBtn.Name = "classBtn"
        Me.classBtn.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.classBtn.Size = New System.Drawing.Size(262, 45)
        Me.classBtn.TabIndex = 9
        Me.classBtn.Text = "Classes"
        Me.classBtn.UseVisualStyleBackColor = False
        '
        'stuBtn
        '
        Me.stuBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.stuBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stuBtn.ForeColor = System.Drawing.Color.White
        Me.stuBtn.Image = CType(resources.GetObject("stuBtn.Image"), System.Drawing.Image)
        Me.stuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stuBtn.Location = New System.Drawing.Point(4, 240)
        Me.stuBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.stuBtn.Name = "stuBtn"
        Me.stuBtn.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.stuBtn.Size = New System.Drawing.Size(262, 45)
        Me.stuBtn.TabIndex = 8
        Me.stuBtn.Text = "Student"
        Me.stuBtn.UseVisualStyleBackColor = False
        '
        'facBtn
        '
        Me.facBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.facBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facBtn.ForeColor = System.Drawing.Color.White
        Me.facBtn.Image = CType(resources.GetObject("facBtn.Image"), System.Drawing.Image)
        Me.facBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.facBtn.Location = New System.Drawing.Point(4, 143)
        Me.facBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.facBtn.Name = "facBtn"
        Me.facBtn.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.facBtn.Size = New System.Drawing.Size(262, 45)
        Me.facBtn.TabIndex = 7
        Me.facBtn.Text = "Faculty"
        Me.facBtn.UseVisualStyleBackColor = False
        '
        'examBtn
        '
        Me.examBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.examBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examBtn.ForeColor = System.Drawing.Color.White
        Me.examBtn.Image = CType(resources.GetObject("examBtn.Image"), System.Drawing.Image)
        Me.examBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.examBtn.Location = New System.Drawing.Point(4, 531)
        Me.examBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.examBtn.Name = "examBtn"
        Me.examBtn.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.examBtn.Size = New System.Drawing.Size(262, 45)
        Me.examBtn.TabIndex = 6
        Me.examBtn.Text = "Examination"
        Me.examBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.exitBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.White
        Me.exitBtn.Image = CType(resources.GetObject("exitBtn.Image"), System.Drawing.Image)
        Me.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exitBtn.Location = New System.Drawing.Point(4, 628)
        Me.exitBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.exitBtn.Size = New System.Drawing.Size(262, 45)
        Me.exitBtn.TabIndex = 5
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(271, 110)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(65, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 45)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "AWKUM"
        '
        'mainPanel
        '
        Me.mainPanel.Controls.Add(Me.Panel3)
        Me.mainPanel.Location = New System.Drawing.Point(277, 12)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(885, 710)
        Me.mainPanel.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.Location = New System.Drawing.Point(240, 187)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(356, 237)
        Me.Panel3.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(98, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HomePage"
        Me.Text = "School Management System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.mainPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents feebtn As Button
    Friend WithEvents classBtn As Button
    Friend WithEvents stuBtn As Button
    Friend WithEvents facBtn As Button
    Friend WithEvents examBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mainPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
