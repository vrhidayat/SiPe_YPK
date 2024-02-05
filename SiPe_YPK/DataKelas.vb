Imports System.Data.Odbc

Public Class DataKelas
    Dim _id, _nama, _jurusan As String
    Sub formKosong()
        TbIdKelas.Text = "auto"
        TbNamaKelas.Clear()
        CbJurusan.DataSource = Nothing
    End Sub

    Sub formNormal()
        TbIdKelas.Enabled = False
        TbNamaKelas.Enabled = False
        CbJurusan.Enabled = False
    End Sub
    Sub getJurusan()
        Try
            DA = New OdbcDataAdapter("SELECT * FROM jurusan", Conn)
            DS = New DataSet
            DA.Fill(DS, "jurusan")
            CbJurusan.DataSource = DS.Tables("jurusan")
            CbJurusan.DisplayMember = "nama_jurusan"
            CbJurusan.ValueMember = "id_jurusan"
            CbJurusan.SelectedIndex = -1
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
        Me.Close()
    End Sub
    Private Sub PnSiswa_Click(sender As Object, e As EventArgs) Handles PnSiswa.Click
        DataSiswa.Show()
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

    Private Sub DataKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnBatal.Visible = False

        formNormal()
        load_kelas()
    End Sub

    Private Sub TbCariData_TextChanged(sender As Object, e As EventArgs) Handles TbCariData.TextChanged
        Try
            openConn()
            DA = New OdbcDataAdapter("SELECT * FROM kelas WHERE nama_kelas like '%" & TbCariData.Text & "%' OR kompetensi_keahlian like '%" & TbCariData.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridKelas.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "Tambah" Then
            TbNamaKelas.Enabled = True
            CbJurusan.Enabled = True
            BtnBatal.Visible = True
            DataGridKelas.Enabled = False
            TbCariData.Enabled = False
            getJurusan()
            BtnTambah.Text = "Simpan"
        ElseIf BtnTambah.Text = "Simpan" Then
            Try
                openConn()
                SQLInsert = "INSERT INTO kelas(nama_kelas, id_jurusan) VALUES (?,?)"
                CMD = New OdbcCommand(SQLInsert, Conn)
                With CMD
                    '.Parameters.AddWithValue("@id_kelas", tbi.Text)
                    .Parameters.AddWithValue("@nama_kelas", TbNamaKelas.Text)
                    .Parameters.AddWithValue("@id_jurusan", CbJurusan.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Tersimpan❤️")
                formKosong()
                load_kelas()
            Catch ex As Exception
                MessageBox.Show("error : " + ex.Message)
            Finally
                closeConn()
                BtnTambah.Text = "Tambah"
                BtnBatal.Visible = False
                DataGridKelas.Enabled = True
                TbCariData.Enabled = True
            End Try
        End If
    End Sub

    Private Sub DataGridKelas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridKelas.SelectionChanged
        Dim i As Integer = DataGridKelas.CurrentRow.Index
        _id = Convert.ToString(DataGridKelas.Item(0, i).Value)
        _nama = Convert.ToString(DataGridKelas.Item(1, i).Value)
        _jurusan = DataGridKelas.Item(2, i).Value
    End Sub

    Private Sub DataGridKelas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKelas.CellDoubleClick
        TbIdKelas.Text = _id
        TbNamaKelas.Text = _nama
        CbJurusan.SelectedValue = _jurusan

        TbIdKelas.Enabled = True
        TbNamaKelas.Enabled = True
        CbJurusan.Enabled = True

        DataGridKelas.Enabled = False
        TbCariData.Enabled = False
        BtnTambah.Visible = False
        BtnEdit.Visible = True
        BtnHapus.Visible = True
        BtnBatal.Visible = True
        getJurusan()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            openConn()

            If MsgBox("Are you sure you want to update the data?", vbYesNo + vbQuestion) = vbYes Then
                SQLUpdate = "UPDATE kelas set nama_kelas= ?, id_jurusan= ? WHERE id_kelas like '" & TbIdKelas.Text & "'"
                CMD = New OdbcCommand(SQLUpdate, Conn)
                With CMD
                    .Parameters.AddWithValue("@nama_kelas", TbNamaKelas.Text)
                    .Parameters.AddWithValue("@id_jurusan", CbJurusan.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Updated")
                formKosong()
                load_kelas()
                BtnEdit.Visible = False
                BtnHapus.Visible = False
                BtnTambah.Visible = True
                BtnBatal.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
            DataGridKelas.Enabled = True
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
                SQLDelete = "DELETE FROM kelas WHERE id_kelas ='" & TbIdKelas.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)

                CMD.ExecuteNonQuery()

                MsgBox("Data Deleted.")
                formKosong()
                load_kelas()
                BtnTambah.Visible = True
                BtnEdit.Visible = False
                BtnHapus.Visible = False
                BtnBatal.Visible = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
                DataGridKelas.Enabled = True
                TbCariData.Enabled = True
            End Try
        Else
            TbNamaKelas.Focus()
        End If

    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        formKosong()
        formNormal()
        BtnTambah.Visible = True
        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnBatal.Visible = False
        DataGridKelas.Enabled = True
        TbCariData.Enabled = True
    End Sub
End Class