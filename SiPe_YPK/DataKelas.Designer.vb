﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataKelas
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
        GroupBox1 = New GroupBox()
        CbJurusan = New ComboBox()
        Label6 = New Label()
        BtnTambah = New Button()
        BtnEdit = New Button()
        BtnHapus = New Button()
        TbNamaKelas = New TextBox()
        TbIdKelas = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TbCariData = New TextBox()
        Label2 = New Label()
        DataGridKelas = New DataGridView()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        LbLogout = New Label()
        Header = New Panel()
        PnJurusan = New Panel()
        PictureBox2 = New PictureBox()
        Label14 = New Label()
        PnKelas = New Panel()
        PictureBox3 = New PictureBox()
        Label15 = New Label()
        PnSiswa = New Panel()
        PictureBox4 = New PictureBox()
        Label16 = New Label()
        PnPetugas = New Panel()
        Label13 = New Label()
        PictureBox5 = New PictureBox()
        PnTransaksi = New Panel()
        Label17 = New Label()
        PictureBox6 = New PictureBox()
        PnLaporan = New Panel()
        Label18 = New Label()
        PictureBox7 = New PictureBox()
        Panel11 = New Panel()
        PictureBox9 = New PictureBox()
        LbRole = New Label()
        LbAdmin = New Label()
        PnDashboard = New Panel()
        PictureBox8 = New PictureBox()
        Label20 = New Label()
        Sidebar = New Panel()
        GroupBox1.SuspendLayout()
        CType(DataGridKelas, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Header.SuspendLayout()
        PnJurusan.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PnKelas.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        PnSiswa.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PnPetugas.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        PnTransaksi.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        PnLaporan.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel11.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        PnDashboard.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Sidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CbJurusan)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(BtnTambah)
        GroupBox1.Controls.Add(BtnEdit)
        GroupBox1.Controls.Add(BtnHapus)
        GroupBox1.Controls.Add(TbNamaKelas)
        GroupBox1.Controls.Add(TbIdKelas)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(319, 57)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(445, 221)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Data Kelas"
        ' 
        ' CbJurusan
        ' 
        CbJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        CbJurusan.FormattingEnabled = True
        CbJurusan.Location = New Point(117, 131)
        CbJurusan.Name = "CbJurusan"
        CbJurusan.Size = New Size(209, 24)
        CbJurusan.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(20, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 16)
        Label6.TabIndex = 9
        Label6.Text = "Jurusan"
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        BtnTambah.ForeColor = Color.White
        BtnTambah.Location = New Point(348, 61)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(75, 28)
        BtnTambah.TabIndex = 8
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        BtnEdit.ForeColor = Color.White
        BtnEdit.Location = New Point(348, 95)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(75, 28)
        BtnEdit.TabIndex = 7
        BtnEdit.Text = "Edit"
        BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        BtnHapus.ForeColor = Color.White
        BtnHapus.Location = New Point(348, 129)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(75, 28)
        BtnHapus.TabIndex = 6
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' TbNamaKelas
        ' 
        TbNamaKelas.Location = New Point(117, 98)
        TbNamaKelas.Name = "TbNamaKelas"
        TbNamaKelas.Size = New Size(209, 22)
        TbNamaKelas.TabIndex = 4
        ' 
        ' TbIdKelas
        ' 
        TbIdKelas.Location = New Point(117, 64)
        TbIdKelas.Name = "TbIdKelas"
        TbIdKelas.Size = New Size(84, 22)
        TbIdKelas.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 16)
        Label5.TabIndex = 1
        Label5.Text = "Nama Kelas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 16)
        Label4.TabIndex = 0
        Label4.Text = "ID Kelas"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(582, 300)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 16)
        Label3.TabIndex = 22
        Label3.Text = "Cari Data"
        ' 
        ' TbCariData
        ' 
        TbCariData.Location = New Point(657, 297)
        TbCariData.Name = "TbCariData"
        TbCariData.Size = New Size(242, 23)
        TbCariData.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(183, 297)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 24)
        Label2.TabIndex = 20
        Label2.Text = "Data Kelas"
        ' 
        ' DataGridKelas
        ' 
        DataGridKelas.BackgroundColor = Color.FromArgb(CByte(120), CByte(166), CByte(200))
        DataGridKelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridKelas.Location = New Point(183, 326)
        DataGridKelas.Name = "DataGridKelas"
        DataGridKelas.Size = New Size(716, 207)
        DataGridKelas.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(59, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(546, 29)
        Label1.TabIndex = 0
        Label1.Text = "SMKS YPK PURWAKARTA | SPP PAYMENTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LogoYPK
        PictureBox1.Location = New Point(15, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' LbLogout
        ' 
        LbLogout.AutoSize = True
        LbLogout.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LbLogout.ForeColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        LbLogout.Location = New Point(683, 17)
        LbLogout.Name = "LbLogout"
        LbLogout.Size = New Size(54, 16)
        LbLogout.TabIndex = 2
        LbLogout.Text = "Logout"
        ' 
        ' Header
        ' 
        Header.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Header.Controls.Add(LbLogout)
        Header.Controls.Add(PictureBox1)
        Header.Controls.Add(Label1)
        Header.Dock = DockStyle.Top
        Header.Location = New Point(168, 0)
        Header.Name = "Header"
        Header.Size = New Size(743, 51)
        Header.TabIndex = 5
        ' 
        ' PnJurusan
        ' 
        PnJurusan.Controls.Add(PictureBox2)
        PnJurusan.Controls.Add(Label14)
        PnJurusan.Location = New Point(0, 200)
        PnJurusan.Name = "PnJurusan"
        PnJurusan.Size = New Size(168, 36)
        PnJurusan.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icon_jurusan1
        PictureBox2.Location = New Point(8, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 28)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.White
        Label14.Location = New Point(45, 9)
        Label14.Name = "Label14"
        Label14.Size = New Size(61, 16)
        Label14.TabIndex = 0
        Label14.Text = "Jurusan"
        ' 
        ' PnKelas
        ' 
        PnKelas.Controls.Add(PictureBox3)
        PnKelas.Controls.Add(Label15)
        PnKelas.Location = New Point(0, 242)
        PnKelas.Name = "PnKelas"
        PnKelas.Size = New Size(168, 36)
        PnKelas.TabIndex = 3
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icon_kelas
        PictureBox3.Location = New Point(8, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 28)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = Color.White
        Label15.Location = New Point(45, 9)
        Label15.Name = "Label15"
        Label15.Size = New Size(46, 16)
        Label15.TabIndex = 0
        Label15.Text = "Kelas"
        ' 
        ' PnSiswa
        ' 
        PnSiswa.Controls.Add(PictureBox4)
        PnSiswa.Controls.Add(Label16)
        PnSiswa.Location = New Point(0, 284)
        PnSiswa.Name = "PnSiswa"
        PnSiswa.Size = New Size(168, 36)
        PnSiswa.TabIndex = 4
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icon_siswa
        PictureBox4.Location = New Point(8, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 28)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = Color.White
        Label16.Location = New Point(45, 10)
        Label16.Name = "Label16"
        Label16.Size = New Size(48, 16)
        Label16.TabIndex = 0
        Label16.Text = "Siswa"
        ' 
        ' PnPetugas
        ' 
        PnPetugas.Controls.Add(Label13)
        PnPetugas.Controls.Add(PictureBox5)
        PnPetugas.Location = New Point(0, 326)
        PnPetugas.Name = "PnPetugas"
        PnPetugas.Size = New Size(168, 36)
        PnPetugas.TabIndex = 5
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(45, 10)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 16)
        Label13.TabIndex = 1
        Label13.Text = "Petugas"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.icon_petugas1
        PictureBox5.Location = New Point(8, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(28, 28)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' PnTransaksi
        ' 
        PnTransaksi.Controls.Add(Label17)
        PnTransaksi.Controls.Add(PictureBox6)
        PnTransaksi.Location = New Point(0, 368)
        PnTransaksi.Name = "PnTransaksi"
        PnTransaksi.Size = New Size(168, 36)
        PnTransaksi.TabIndex = 6
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = Color.White
        Label17.Location = New Point(45, 10)
        Label17.Name = "Label17"
        Label17.Size = New Size(76, 16)
        Label17.TabIndex = 1
        Label17.Text = "Transaksi"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.icon_transaction
        PictureBox6.Location = New Point(8, 4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(28, 28)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 0
        PictureBox6.TabStop = False
        ' 
        ' PnLaporan
        ' 
        PnLaporan.Controls.Add(Label18)
        PnLaporan.Controls.Add(PictureBox7)
        PnLaporan.Location = New Point(0, 410)
        PnLaporan.Name = "PnLaporan"
        PnLaporan.Size = New Size(168, 36)
        PnLaporan.TabIndex = 7
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = Color.White
        Label18.Location = New Point(45, 10)
        Label18.Name = "Label18"
        Label18.Size = New Size(62, 16)
        Label18.TabIndex = 1
        Label18.Text = "Riwayat"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.icon_report
        PictureBox7.Location = New Point(8, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(28, 28)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(120), CByte(166), CByte(200))
        Panel11.Controls.Add(PictureBox9)
        Panel11.Controls.Add(LbRole)
        Panel11.Controls.Add(LbAdmin)
        Panel11.Location = New Point(34, 31)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(100, 100)
        Panel11.TabIndex = 8
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = My.Resources.Resources.icon_user
        PictureBox9.Location = New Point(25, 10)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(50, 50)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 2
        PictureBox9.TabStop = False
        ' 
        ' LbRole
        ' 
        LbRole.AutoSize = True
        LbRole.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        LbRole.ForeColor = Color.White
        LbRole.Location = New Point(30, 82)
        LbRole.Name = "LbRole"
        LbRole.Size = New Size(36, 13)
        LbRole.TabIndex = 1
        LbRole.Text = "Admin"
        ' 
        ' LbAdmin
        ' 
        LbAdmin.AutoSize = True
        LbAdmin.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LbAdmin.ForeColor = Color.White
        LbAdmin.Location = New Point(5, 63)
        LbAdmin.Name = "LbAdmin"
        LbAdmin.Size = New Size(94, 16)
        LbAdmin.TabIndex = 0
        LbAdmin.Text = "Hidayatulloh"
        ' 
        ' PnDashboard
        ' 
        PnDashboard.Controls.Add(PictureBox8)
        PnDashboard.Controls.Add(Label20)
        PnDashboard.Location = New Point(0, 158)
        PnDashboard.Name = "PnDashboard"
        PnDashboard.Size = New Size(168, 36)
        PnDashboard.TabIndex = 9
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.icon_dashboard1
        PictureBox8.Location = New Point(8, 4)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(28, 28)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 1
        PictureBox8.TabStop = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.ForeColor = Color.White
        Label20.Location = New Point(45, 10)
        Label20.Name = "Label20"
        Label20.Size = New Size(84, 16)
        Label20.TabIndex = 0
        Label20.Text = "Dashboard"
        ' 
        ' Sidebar
        ' 
        Sidebar.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Sidebar.Controls.Add(PnDashboard)
        Sidebar.Controls.Add(Panel11)
        Sidebar.Controls.Add(PnLaporan)
        Sidebar.Controls.Add(PnTransaksi)
        Sidebar.Controls.Add(PnPetugas)
        Sidebar.Controls.Add(PnSiswa)
        Sidebar.Controls.Add(PnKelas)
        Sidebar.Controls.Add(PnJurusan)
        Sidebar.Dock = DockStyle.Left
        Sidebar.Location = New Point(0, 0)
        Sidebar.Name = "Sidebar"
        Sidebar.Size = New Size(168, 540)
        Sidebar.TabIndex = 4
        ' 
        ' DataKelas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(911, 540)
        Controls.Add(DataGridKelas)
        Controls.Add(Label3)
        Controls.Add(TbCariData)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(Header)
        Controls.Add(Sidebar)
        Name = "DataKelas"
        Text = "DataKelas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridKelas, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Header.ResumeLayout(False)
        Header.PerformLayout()
        PnJurusan.ResumeLayout(False)
        PnJurusan.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PnKelas.ResumeLayout(False)
        PnKelas.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        PnSiswa.ResumeLayout(False)
        PnSiswa.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PnPetugas.ResumeLayout(False)
        PnPetugas.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        PnTransaksi.ResumeLayout(False)
        PnTransaksi.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        PnLaporan.ResumeLayout(False)
        PnLaporan.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        PnDashboard.ResumeLayout(False)
        PnDashboard.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Sidebar.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents TbNamaKelas As TextBox
    Friend WithEvents TbIdKelas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbCariData As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridKelas As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents CbJurusan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LbLogout As Label
    Friend WithEvents Header As Panel
    Friend WithEvents PnJurusan As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PnKelas As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PnSiswa As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PnPetugas As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PnTransaksi As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PnLaporan As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents LbRole As Label
    Friend WithEvents LbAdmin As Label
    Friend WithEvents PnDashboard As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Sidebar As Panel
End Class
