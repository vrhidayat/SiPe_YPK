﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Panel1 = New Panel()
        Panel3 = New Panel()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        TabControl1 = New TabControl()
        TpLogin = New TabPage()
        BtnLoginAdmin = New Button()
        TbPassword = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        TbUsername = New TextBox()
        TabPage2 = New TabPage()
        BtnLoginSiswa = New Button()
        TbNisn = New TextBox()
        Label8 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TabControl1.SuspendLayout()
        TpLogin.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(278, 450)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(120), CByte(166), CByte(200))
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(19, 386)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(242, 36)
        Panel3.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(4, 7)
        Label9.Name = "Label9"
        Label9.Size = New Size(233, 23)
        Label9.TabIndex = 0
        Label9.Text = "SMKS YPK PURWAKARTA"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(60, 221)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(153, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(115, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 25)
        Label4.TabIndex = 3
        Label4.Text = "SPP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(24, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(230, 25)
        Label3.TabIndex = 2
        Label3.Text = "SISTEM PEMBAYARAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(126, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 23)
        Label2.TabIndex = 1
        Label2.Text = "DI"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(55, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 23)
        Label1.TabIndex = 0
        Label1.Text = "SELAMAT DATANG"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(120), CByte(166), CByte(200))
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(278, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(441, 100)
        Panel2.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(187, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 25)
        Label5.TabIndex = 0
        Label5.Text = "LOGIN"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TpLogin)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("SF Pro Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(338, 148)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(333, 258)
        TabControl1.TabIndex = 2
        ' 
        ' TpLogin
        ' 
        TpLogin.BackColor = Color.FromArgb(CByte(120), CByte(166), CByte(200))
        TpLogin.Controls.Add(BtnLoginAdmin)
        TpLogin.Controls.Add(TbPassword)
        TpLogin.Controls.Add(Label7)
        TpLogin.Controls.Add(Label6)
        TpLogin.Controls.Add(TbUsername)
        TpLogin.Font = New Font("SF Pro Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TpLogin.ForeColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        TpLogin.Location = New Point(4, 25)
        TpLogin.Name = "TpLogin"
        TpLogin.Padding = New Padding(3)
        TpLogin.Size = New Size(325, 229)
        TpLogin.TabIndex = 0
        TpLogin.Text = "Admin"
        ' 
        ' BtnLoginAdmin
        ' 
        BtnLoginAdmin.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        BtnLoginAdmin.Font = New Font("SF Pro Rounded", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLoginAdmin.ForeColor = Color.White
        BtnLoginAdmin.Location = New Point(116, 153)
        BtnLoginAdmin.Name = "BtnLoginAdmin"
        BtnLoginAdmin.Size = New Size(92, 35)
        BtnLoginAdmin.TabIndex = 4
        BtnLoginAdmin.Text = "Login"
        BtnLoginAdmin.UseVisualStyleBackColor = False
        ' 
        ' TbPassword
        ' 
        TbPassword.BackColor = SystemColors.Control
        TbPassword.Location = New Point(32, 106)
        TbPassword.Name = "TbPassword"
        TbPassword.Size = New Size(257, 23)
        TbPassword.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("SF Pro Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(32, 90)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 13)
        Label7.TabIndex = 2
        Label7.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("SF Pro Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(32, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 13)
        Label6.TabIndex = 1
        Label6.Text = "Username"
        ' 
        ' TbUsername
        ' 
        TbUsername.BackColor = SystemColors.Control
        TbUsername.Location = New Point(32, 49)
        TbUsername.Name = "TbUsername"
        TbUsername.Size = New Size(257, 23)
        TbUsername.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(120), CByte(166), CByte(200))
        TabPage2.Controls.Add(BtnLoginSiswa)
        TabPage2.Controls.Add(TbNisn)
        TabPage2.Controls.Add(Label8)
        TabPage2.Font = New Font("SF Pro Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage2.ForeColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        TabPage2.Location = New Point(4, 25)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(325, 229)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Siswa"
        ' 
        ' BtnLoginSiswa
        ' 
        BtnLoginSiswa.BackColor = Color.FromArgb(CByte(230), CByte(92), CByte(79))
        BtnLoginSiswa.ForeColor = Color.White
        BtnLoginSiswa.Location = New Point(112, 128)
        BtnLoginSiswa.Name = "BtnLoginSiswa"
        BtnLoginSiswa.Size = New Size(92, 35)
        BtnLoginSiswa.TabIndex = 2
        BtnLoginSiswa.Text = "Login"
        BtnLoginSiswa.UseVisualStyleBackColor = False
        ' 
        ' TbNisn
        ' 
        TbNisn.BackColor = SystemColors.Control
        TbNisn.Location = New Point(39, 72)
        TbNisn.Name = "TbNisn"
        TbNisn.Size = New Size(250, 23)
        TbNisn.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("SF Pro Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(39, 56)
        Label8.Name = "Label8"
        Label8.Size = New Size(34, 13)
        Label8.TabIndex = 0
        Label8.Text = "NISN"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(719, 450)
        Controls.Add(TabControl1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        Text = " "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TabControl1.ResumeLayout(False)
        TpLogin.ResumeLayout(False)
        TpLogin.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpLogin As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents BtnLoginAdmin As Button
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnLoginSiswa As Button
    Friend WithEvents TbNisn As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
