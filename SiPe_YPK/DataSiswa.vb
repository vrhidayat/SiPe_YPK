Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class DataSiswa
    Dim _nisn, _nis, _nama, _id_kelas, _alamat, _no_telp, _id_spp As String

    Sub formKosong()
        'Membuat Sub Prosedure untuk Mengosongkan Object
        TbNisn.Clear()
        TbNis.Clear()
        TbNamaSiswa.Clear()
        CbKelas.DataSource = Nothing
        cbSPP.DataSource = Nothing
        TbAlamat.Clear()
        TbNoTelp.Clear()
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
            cbSPP.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub PnDashboard_Click(sender As Object, e As EventArgs) Handles PnDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub PnJurusan_Click(sender As Object, e As EventArgs) Handles PnJurusan.Click
        DataJurusan.Show()
        Me.Hide()
    End Sub
    Private Sub PnKelas_Click(sender As Object, e As EventArgs) Handles PnKelas.Click
        DataKelas.Show()
        Me.Hide()
    End Sub

    Private Sub PnPetugas_Click(sender As Object, e As EventArgs) Handles PnPetugas.Click
        DataPetugas.Show()
        Me.Hide()
    End Sub

    Private Sub PnTransaksi_Click(sender As Object, e As EventArgs) Handles PnTransaksi.Click

    End Sub

    Private Sub PnLaporan_Click(sender As Object, e As EventArgs) Handles PnLaporan.Click

    End Sub
    Private Sub LbLogout_Click(sender As Object, e As EventArgs) Handles LbLogout.Click

    End Sub

    Private Sub DataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        tbNisnOld.Visible = False
        getKelas()
        getSPP()

        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM siswa ORDER BY nisn ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")
            DataGridSiswa.DataSource = DS.Tables("siswa")
            DataGridSiswa.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try
            openConn()
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
        Catch ex As Exception
            MessageBox.Show("error : " + ex.Message)
        Finally
            closeConn()
        End Try
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

    Private Sub DataGridSiswa_DoubleClick(sender As Object, e As EventArgs) Handles DataGridSiswa.DoubleClick
        TbNisn.Text = _nisn
        tbNisnOld.Text = _nisn
        TbNis.Text = _nis
        TbNamaSiswa.Text = _nama
        CbKelas.SelectedValue = _id_kelas
        TbAlamat.Text = _alamat
        TbNoTelp.Text = _no_telp
        cbSPP.SelectedValue = _id_spp
        BtnTambah.Enabled = False
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
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
                BtnEdit.Enabled = False
                BtnHapus.Enabled = False
                BtnTambah.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
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

                Call formKosong()
                MsgBox("Data Deleted.")
                BtnTambah.Enabled = True
                BtnEdit.Enabled = False
                BtnHapus.Enabled = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
            End Try
        Else
            TbNisn.Focus()
        End If
    End Sub
End Class