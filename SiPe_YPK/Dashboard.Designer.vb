<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Sidebar = New Panel()
        PnDashboard = New Panel()
        PictureBox8 = New PictureBox()
        Label20 = New Label()
        Panel11 = New Panel()
        PictureBox9 = New PictureBox()
        LbRole = New Label()
        LbAdmin = New Label()
        PnLaporan = New Panel()
        Label18 = New Label()
        PictureBox7 = New PictureBox()
        PnTransaksi = New Panel()
        Label17 = New Label()
        PictureBox6 = New PictureBox()
        PnPetugas = New Panel()
        Label13 = New Label()
        PictureBox5 = New PictureBox()
        PnSiswa = New Panel()
        PictureBox4 = New PictureBox()
        Label16 = New Label()
        PnKelas = New Panel()
        PictureBox3 = New PictureBox()
        Label15 = New Label()
        PnJurusan = New Panel()
        PictureBox2 = New PictureBox()
        Label14 = New Label()
        Label7 = New Label()
        Label10 = New Label()
        DataGridAngkatan = New DataGridView()
        Panel4 = New Panel()
        Panel2 = New Panel()
        Label8 = New Label()
        Label11 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Panel7 = New Panel()
        LbJumlahKelas = New Label()
        Label6 = New Label()
        Panel6 = New Panel()
        LbJumlahPetugas = New Label()
        Label5 = New Label()
        Panel5 = New Panel()
        LbJumlahSiswa = New Label()
        Label4 = New Label()
        Header = New Panel()
        LbLogout = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label9 = New Label()
        Label12 = New Label()
        Panel3 = New Panel()
        Label22 = New Label()
        Label21 = New Label()
        Label19 = New Label()
        Panel8 = New Panel()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Panel9 = New Panel()
        Label26 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Panel10 = New Panel()
        LbTotalTahunTransaksi = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Panel12 = New Panel()
        LbTotalBulanTransaksi = New Label()
        Label33 = New Label()
        Label34 = New Label()
        Panel13 = New Panel()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        Sidebar.SuspendLayout()
        PnDashboard.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel11.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        PnLaporan.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        PnTransaksi.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        PnPetugas.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        PnSiswa.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PnKelas.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        PnJurusan.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridAngkatan, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Header.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        SuspendLayout()
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
        Sidebar.TabIndex = 2
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
        Label20.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.White
        Label20.Location = New Point(45, 10)
        Label20.Name = "Label20"
        Label20.Size = New Size(84, 16)
        Label20.TabIndex = 0
        Label20.Text = "Dashboard"
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
        LbRole.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        LbAdmin.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbAdmin.ForeColor = Color.White
        LbAdmin.Location = New Point(5, 63)
        LbAdmin.Name = "LbAdmin"
        LbAdmin.Size = New Size(94, 16)
        LbAdmin.TabIndex = 0
        LbAdmin.Text = "Hidayatulloh"
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
        Label18.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label17.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label16.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.White
        Label16.Location = New Point(45, 10)
        Label16.Name = "Label16"
        Label16.Size = New Size(48, 16)
        Label16.TabIndex = 0
        Label16.Text = "Siswa"
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
        Label15.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.White
        Label15.Location = New Point(45, 9)
        Label15.Name = "Label15"
        Label15.Size = New Size(46, 16)
        Label15.TabIndex = 0
        Label15.Text = "Kelas"
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
        Label14.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(45, 9)
        Label14.Name = "Label14"
        Label14.Size = New Size(61, 16)
        Label14.TabIndex = 0
        Label14.Text = "Jurusan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(43, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(130, 20)
        Label7.TabIndex = 3
        Label7.Text = "Data Angkatan"
        ' 
        ' Label10
        ' 
        Label10.BackColor = SystemColors.ControlDark
        Label10.Location = New Point(409, 110)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 0)
        Label10.TabIndex = 6
        ' 
        ' DataGridAngkatan
        ' 
        DataGridAngkatan.BackgroundColor = Color.White
        DataGridAngkatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridAngkatan.Location = New Point(10, 266)
        DataGridAngkatan.Name = "DataGridAngkatan"
        DataGridAngkatan.Size = New Size(180, 180)
        DataGridAngkatan.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(120), CByte(166), CByte(200))
        Panel4.Controls.Add(Panel2)
        Panel4.Controls.Add(Panel1)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(DataGridAngkatan)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(188, 71)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 457)
        Panel4.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(10, 149)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(180, 40)
        Panel2.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(13, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(15, 16)
        Label8.TabIndex = 1
        Label8.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(126, 12)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 16)
        Label11.TabIndex = 0
        Label11.Text = "Kelas"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(10, 195)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(180, 40)
        Panel1.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 16)
        Label2.TabIndex = 1
        Label2.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(126, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 16)
        Label3.TabIndex = 0
        Label3.Text = "Kelas"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Panel7.Controls.Add(LbJumlahKelas)
        Panel7.Controls.Add(Label6)
        Panel7.Location = New Point(10, 103)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(180, 40)
        Panel7.TabIndex = 11
        ' 
        ' LbJumlahKelas
        ' 
        LbJumlahKelas.AutoSize = True
        LbJumlahKelas.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbJumlahKelas.ForeColor = Color.White
        LbJumlahKelas.Location = New Point(13, 12)
        LbJumlahKelas.Name = "LbJumlahKelas"
        LbJumlahKelas.Size = New Size(15, 16)
        LbJumlahKelas.TabIndex = 1
        LbJumlahKelas.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(126, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 16)
        Label6.TabIndex = 0
        Label6.Text = "Kelas"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Panel6.Controls.Add(LbJumlahPetugas)
        Panel6.Controls.Add(Label5)
        Panel6.Location = New Point(10, 57)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(180, 40)
        Panel6.TabIndex = 10
        ' 
        ' LbJumlahPetugas
        ' 
        LbJumlahPetugas.AutoSize = True
        LbJumlahPetugas.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbJumlahPetugas.ForeColor = Color.White
        LbJumlahPetugas.Location = New Point(13, 12)
        LbJumlahPetugas.Name = "LbJumlahPetugas"
        LbJumlahPetugas.Size = New Size(15, 16)
        LbJumlahPetugas.TabIndex = 1
        LbJumlahPetugas.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(108, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 16)
        Label5.TabIndex = 0
        Label5.Text = "Petugas"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Panel5.Controls.Add(LbJumlahSiswa)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(10, 11)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(180, 40)
        Panel5.TabIndex = 9
        ' 
        ' LbJumlahSiswa
        ' 
        LbJumlahSiswa.AutoSize = True
        LbJumlahSiswa.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbJumlahSiswa.ForeColor = Color.White
        LbJumlahSiswa.Location = New Point(13, 12)
        LbJumlahSiswa.Name = "LbJumlahSiswa"
        LbJumlahSiswa.Size = New Size(15, 16)
        LbJumlahSiswa.TabIndex = 1
        LbJumlahSiswa.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(122, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 16)
        Label4.TabIndex = 0
        Label4.Text = "Siswa"
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
        Header.TabIndex = 11
        ' 
        ' LbLogout
        ' 
        LbLogout.AutoSize = True
        LbLogout.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbLogout.ForeColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        LbLogout.Location = New Point(683, 17)
        LbLogout.Name = "LbLogout"
        LbLogout.Size = New Size(54, 16)
        LbLogout.TabIndex = 2
        LbLogout.Text = "Logout"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(59, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(546, 29)
        Label1.TabIndex = 0
        Label1.Text = "SMKS YPK PURWAKARTA | SPP PAYMENTS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Label9.Location = New Point(409, 71)
        Label9.Name = "Label9"
        Label9.Size = New Size(161, 24)
        Label9.TabIndex = 12
        Label9.Text = "Selamat Datang!"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(50), CByte(88), CByte(137))
        Label12.Location = New Point(687, 78)
        Label12.Name = "Label12"
        Label12.Size = New Size(201, 15)
        Label12.TabIndex = 13
        Label12.Text = "Saturday, 27 Januari 2024 23:01:24"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Aquamarine
        Panel3.Controls.Add(Label22)
        Panel3.Controls.Add(Label21)
        Panel3.Controls.Add(Label19)
        Panel3.Location = New Point(409, 125)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 77)
        Panel3.TabIndex = 14
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(97, 53)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 16)
        Label22.TabIndex = 2
        Label22.Text = "Rp. 2.300.000"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(9, 28)
        Label21.Name = "Label21"
        Label21.Size = New Size(104, 20)
        Label21.TabIndex = 1
        Label21.Text = "Penerimaan"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(9, 8)
        Label19.Name = "Label19"
        Label19.Size = New Size(32, 15)
        Label19.TabIndex = 0
        Label19.Text = "Total"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Panel8.Controls.Add(Label23)
        Panel8.Controls.Add(Label24)
        Panel8.Controls.Add(Label25)
        Panel8.Location = New Point(409, 220)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(200, 77)
        Panel8.TabIndex = 15
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(97, 53)
        Label23.Name = "Label23"
        Label23.Size = New Size(99, 16)
        Label23.TabIndex = 2
        Label23.Text = "Rp. 2.300.000"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(9, 28)
        Label24.Name = "Label24"
        Label24.Size = New Size(104, 20)
        Label24.TabIndex = 1
        Label24.Text = "Penerimaan"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(9, 8)
        Label25.Name = "Label25"
        Label25.Size = New Size(78, 15)
        Label25.TabIndex = 0
        Label25.Text = "Total Bulanan"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel9.Controls.Add(Label26)
        Panel9.Controls.Add(Label27)
        Panel9.Controls.Add(Label28)
        Panel9.Location = New Point(409, 317)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(200, 77)
        Panel9.TabIndex = 16
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(97, 53)
        Label26.Name = "Label26"
        Label26.Size = New Size(99, 16)
        Label26.TabIndex = 2
        Label26.Text = "Rp. 2.300.000"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(9, 28)
        Label27.Name = "Label27"
        Label27.Size = New Size(104, 20)
        Label27.TabIndex = 1
        Label27.Text = "Penerimaan"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(9, 8)
        Label28.Name = "Label28"
        Label28.Size = New Size(80, 15)
        Label28.TabIndex = 0
        Label28.Text = "Total Tahunan"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel10.Controls.Add(LbTotalTahunTransaksi)
        Panel10.Controls.Add(Label30)
        Panel10.Controls.Add(Label31)
        Panel10.Location = New Point(652, 125)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(200, 77)
        Panel10.TabIndex = 17
        ' 
        ' LbTotalTahunTransaksi
        ' 
        LbTotalTahunTransaksi.AutoSize = True
        LbTotalTahunTransaksi.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbTotalTahunTransaksi.Location = New Point(171, 53)
        LbTotalTahunTransaksi.Name = "LbTotalTahunTransaksi"
        LbTotalTahunTransaksi.Size = New Size(23, 16)
        LbTotalTahunTransaksi.TabIndex = 2
        LbTotalTahunTransaksi.Text = "12"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(9, 28)
        Label30.Name = "Label30"
        Label30.Size = New Size(86, 20)
        Label30.TabIndex = 1
        Label30.Text = "Transaksi"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(9, 8)
        Label31.Name = "Label31"
        Label31.Size = New Size(32, 15)
        Label31.TabIndex = 0
        Label31.Text = "Total"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel12.Controls.Add(LbTotalBulanTransaksi)
        Panel12.Controls.Add(Label33)
        Panel12.Controls.Add(Label34)
        Panel12.Location = New Point(652, 220)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(200, 77)
        Panel12.TabIndex = 18
        ' 
        ' LbTotalBulanTransaksi
        ' 
        LbTotalBulanTransaksi.AutoSize = True
        LbTotalBulanTransaksi.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbTotalBulanTransaksi.Location = New Point(177, 53)
        LbTotalBulanTransaksi.Name = "LbTotalBulanTransaksi"
        LbTotalBulanTransaksi.Size = New Size(15, 16)
        LbTotalBulanTransaksi.TabIndex = 2
        LbTotalBulanTransaksi.Text = "2"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.Location = New Point(9, 28)
        Label33.Name = "Label33"
        Label33.Size = New Size(86, 20)
        Label33.TabIndex = 1
        Label33.Text = "Transaksi"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(9, 8)
        Label34.Name = "Label34"
        Label34.Size = New Size(78, 15)
        Label34.TabIndex = 0
        Label34.Text = "Total Bulanan"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel13.Controls.Add(Label35)
        Panel13.Controls.Add(Label36)
        Panel13.Controls.Add(Label37)
        Panel13.Location = New Point(652, 317)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(200, 77)
        Panel13.TabIndex = 19
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label35.Location = New Point(177, 53)
        Label35.Name = "Label35"
        Label35.Size = New Size(15, 16)
        Label35.TabIndex = 2
        Label35.Text = "4"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label36.Location = New Point(9, 28)
        Label36.Name = "Label36"
        Label36.Size = New Size(86, 20)
        Label36.TabIndex = 1
        Label36.Text = "Transaksi"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(9, 8)
        Label37.Name = "Label37"
        Label37.Size = New Size(80, 15)
        Label37.TabIndex = 0
        Label37.Text = "Total Tahunan"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(911, 540)
        Controls.Add(Panel13)
        Controls.Add(Panel12)
        Controls.Add(Panel10)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel3)
        Controls.Add(Label12)
        Controls.Add(Label9)
        Controls.Add(Header)
        Controls.Add(Panel4)
        Controls.Add(Label10)
        Controls.Add(Sidebar)
        Name = "Main"
        Text = "Sistem Informasi SPP YPK"
        Sidebar.ResumeLayout(False)
        PnDashboard.ResumeLayout(False)
        PnDashboard.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        PnLaporan.ResumeLayout(False)
        PnLaporan.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        PnTransaksi.ResumeLayout(False)
        PnTransaksi.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        PnPetugas.ResumeLayout(False)
        PnPetugas.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        PnSiswa.ResumeLayout(False)
        PnSiswa.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PnKelas.ResumeLayout(False)
        PnKelas.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        PnJurusan.ResumeLayout(False)
        PnJurusan.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridAngkatan, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Header.ResumeLayout(False)
        Header.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Sidebar As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PnJurusan As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents PnSiswa As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents PnKelas As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridAngkatan As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbJumlahKelas As Label
    Friend WithEvents LbJumlahPetugas As Label
    Friend WithEvents LbJumlahSiswa As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PnTransaksi As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PnPetugas As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PnLaporan As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents LbAdmin As Label
    Friend WithEvents LbRole As Label
    Friend WithEvents PnDashboard As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Header As Panel
    Friend WithEvents LbLogout As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents LbTotalTahunTransaksi As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents LbTotalBulanTransaksi As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label

End Class
