Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class DataSiswa
    Dim _nisn, _nis, _nama, _id_kelas, _alamat, _no_telp, _id_spp As String

    Sub formKosong()
        'Membuat Sub Prosedure untuk Mengosongkan Object
        tbNisnOld.Clear()
        TbNisn.Clear()
        TbNis.Clear()
        TbNamaSiswa.Clear()
        CbKelas.DataSource = Nothing
        cbSPP.DataSource = Nothing
        TbAlamat.Clear()
        TbNoTelp.Clear()
    End Sub

    Sub formNormal()
        TbNisn.Enabled = False
        TbNis.Enabled = False
        TbNamaSiswa.Enabled = False
        CbKelas.Enabled = False
        cbSPP.Enabled = False
        TbAlamat.Enabled = False
        TbNoTelp.Enabled = False
    End Sub
    Sub formOpen()
        TbNisn.Enabled = True
        TbNis.Enabled = True
        TbNamaSiswa.Enabled = True
        CbKelas.Enabled = True
        cbSPP.Enabled = True
        TbAlamat.Enabled = True
        TbNoTelp.Enabled = True
    End Sub
    Sub getKelas()
        Try
            DA = New OdbcDataAdapter("SELECT * FROM kelas", Conn)
            DS = New DataSet
            DA.Fill(DS, "kelas")
            CbKelas.DataSource = DS.Tables("kelas")
            CbKelas.DisplayMember = "nama_kelas"
            CbKelas.ValueMember = "id_kelas"
            CbKelas.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Sub getSPP()
        Try
            DA = New OdbcDataAdapter("SELECT * FROM spp", Conn)
            DS = New DataSet
            DA.Fill(DS, "spp")
            cbSPP.DataSource = DS.Tables("spp")
            cbSPP.DisplayMember = "tahun"
            cbSPP.ValueMember = "id_spp"
            CbKelas.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub PnDashboard_Click(sender As Object, e As EventArgs) Handles PnDashboard.Click
        Dashboard.Show()
        Me.Close()
    End Sub
    Private Sub PnJurusan_Click(sender As Object, e As EventArgs) Handles PnJurusan.Click
        DataJurusan.Show()
        Me.Close()
    End Sub
    Private Sub PnKelas_Click(sender As Object, e As EventArgs) Handles PnKelas.Click
        DataKelas.Show()
        Me.Close()
    End Sub

    Private Sub PnPetugas_Click(sender As Object, e As EventArgs) Handles PnPetugas.Click
        DataPetugas.Show()
        Me.Close()
    End Sub

    Private Sub PnTransaksi_Click(sender As Object, e As EventArgs) Handles PnTransaksi.Click
        DataTransaksi.Show()
        Me.Close()
    End Sub

    Private Sub PnLaporan_Click(sender As Object, e As EventArgs) Handles PnLaporan.Click
        Riwayat.Show()
        Me.Close()
    End Sub

    Private Sub DataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnBatal.Visible = False

        tbNisnOld.Visible = False

        formNormal()
        load_siswa()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "Tambah" Then
            formOpen()
            BtnBatal.Visible = True
            DataGridSiswa.Enabled = False
            TbCariData.Enabled = False
            BtnTambah.Text = "Simpan"
            openConn()
            getKelas()
            getSPP()
        ElseIf BtnTambah.Text = "Simpan" Then
            Try
                SQLInsert = "INSERT INTO siswa VALUES (?,?,?,?,?,?,?)"
                CMD = New OdbcCommand(SQLInsert, Conn)
                With CMD
                    .Parameters.AddWithValue("@nisn", TbNisn.Text)
                    .Parameters.AddWithValue("@nis", TbNis.Text)
                    .Parameters.AddWithValue("@nama", TbNamaSiswa.Text)
                    .Parameters.AddWithValue("@id_kelas", CbKelas.SelectedItem)
                    .Parameters.AddWithValue("@no_telp", TbNoTelp.Text)
                    .Parameters.AddWithValue("@id_spp", cbSPP.SelectedItem)
                    .Parameters.AddWithValue("@alamat", TbAlamat.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Tersimpan❤️")
                formKosong()
                formNormal()
                load_siswa()
            Catch ex As Exception
                MessageBox.Show("error : " + ex.Message)
            Finally
                closeConn()
                BtnTambah.Text = "Tambah"
                BtnBatal.Visible = False
                DataGridSiswa.Enabled = True
                TbCariData.Enabled = True
            End Try
        End If
    End Sub

    Private Sub TbCariData_TextChanged(sender As Object, e As EventArgs) Handles TbCariData.TextChanged
        Try
            openConn()
            DA = New OdbcDataAdapter("SELECT * FROM siswa WHERE nisn like '%" & TbCariData.Text & "%' OR nis like '%" & TbCariData.Text & "%' OR nama like '%" & TbCariData.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridSiswa.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub DataGridSiswa_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridSiswa.SelectionChanged
        Dim i As Integer = DataGridSiswa.CurrentRow.Index
        _nisn = Convert.ToString(DataGridSiswa.Item(0, i).Value)
        _nis = Convert.ToString(DataGridSiswa.Item(1, i).Value)
        _nama = Convert.ToString(DataGridSiswa.Item(2, i).Value)
        _id_kelas = DataGridSiswa.Item(3, i).Value
        _alamat = Convert.ToString(DataGridSiswa.Item(4, i).Value)
        _no_telp = Convert.ToString(DataGridSiswa.Item(5, i).Value)
        _id_spp = DataGridSiswa.Item(6, i).Value
    End Sub

    Private Sub DataGridSiswa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSiswa.CellDoubleClick
        getSPP()
        getKelas()
        TbNisn.Text = _nisn
        tbNisnOld.Text = _nisn
        TbNis.Text = _nis
        TbNamaSiswa.Text = _nama
        CbKelas.SelectedValue = _id_kelas
        TbAlamat.Text = _alamat
        TbNoTelp.Text = _no_telp
        cbSPP.SelectedValue = _id_spp

        formOpen()

        DataGridSiswa.Enabled = False
        TbCariData.Enabled = False
        BtnTambah.Visible = False
        BtnEdit.Visible = True
        BtnHapus.Visible = True
        BtnBatal.Visible = True
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            openConn()
            If MsgBox("Are you sure you want to update this data?", vbYesNo + vbQuestion) = vbYes Then
                SQLUpdate = "UPDATE siswa set nisn= ?, nis= ?, nama=?, id_kelas=?, alamat=?, no_telp=?, id_spp=? WHERE nisn like '" & tbNisnOld.Text & "'"
                CMD = New OdbcCommand(SQLUpdate, Conn)
                With CMD
                    .Parameters.AddWithValue("@nisn", TbNisn.Text)
                    .Parameters.AddWithValue("@nis", TbNis.Text)
                    .Parameters.AddWithValue("@nama", TbNamaSiswa.Text)
                    .Parameters.AddWithValue("@id_kelas", CbKelas.SelectedValue)
                    .Parameters.AddWithValue("@alamat", TbAlamat.Text)
                    .Parameters.AddWithValue("@no_telp", TbNoTelp.Text)
                    .Parameters.AddWithValue("@id_spp", cbSPP.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Updated")
                formKosong()
                load_siswa()
                formNormal()
                BtnEdit.Visible = False
                BtnHapus.Visible = False
                BtnTambah.Visible = True
                BtnBatal.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
            DataGridSiswa.Enabled = True
            TbCariData.Enabled = True
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim Konfirmasi As String

        Konfirmasi = MsgBox("Anda yakin akan menghapus data ini?", vbYesNo + vbQuestion,
       "Informasi")
        If Konfirmasi = vbYes Then
            Try
                Call openConn()
                SQLDelete = "DELETE FROM siswa WHERE nisn ='" & tbNisnOld.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)

                CMD.ExecuteNonQuery()

                MsgBox("Data Deleted.")
                formKosong()
                formNormal()
                load_siswa()
                BtnTambah.Visible = True
                BtnEdit.Visible = False
                BtnHapus.Visible = False
                BtnBatal.Visible = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
                DataGridSiswa.Enabled = True
                TbCariData.Enabled = True
            End Try
        Else
            TbNisn.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        formKosong()
        formNormal()
        BtnTambah.Visible = True
        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnBatal.Visible = False
        DataGridSiswa.Enabled = True
        TbCariData.Enabled = True
    End Sub

End Class