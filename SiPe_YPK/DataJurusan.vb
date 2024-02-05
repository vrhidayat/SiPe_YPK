Imports System.ComponentModel
Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class DataJurusan
    Dim _id, _nama As String
    Sub formKosong()
        TbIdJurusan.Text = "auto"
        TbNamaJurusan.Clear()
    End Sub

    Sub formNormal()
        TbIdJurusan.Enabled = False
        TbNamaJurusan.Enabled = False
    End Sub

    Private Sub PnDashboard_Click(sender As Object, e As EventArgs) Handles PnDashboard.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub PnKelas_Click(sender As Object, e As EventArgs) Handles PnKelas.Click
        DataKelas.Show()
        Me.Close()
    End Sub

    Private Sub PnSiswa_Click(sender As Object, e As EventArgs) Handles PnSiswa.Click
        DataPetugas.Show()
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

    Private Sub DataJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEdit.Visible = False
        BtnHapus.Visible = False
        btnBatal.Visible = False

        formNormal()
        load_jurusan()
    End Sub

    Private Sub TbCariData_TextChanged(sender As Object, e As EventArgs) Handles TbCariData.TextChanged
        Try
            openConn()
            DA = New OdbcDataAdapter("SELECT * FROM jurusan WHERE nama_jurusan like '%" & TbCariData.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridJurusan.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "Tambah" Then
            TbNamaJurusan.Enabled = True
            btnBatal.Visible = True
            DataGridJurusan.Enabled = False
            TbCariData.Enabled = False
            BtnTambah.Text = "Simpan"
        ElseIf BtnTambah.Text = "Simpan" Then
            Try
                openConn()
                SQLInsert = "INSERT INTO jurusan(nama_jurusan) VALUES (?)"
                CMD = New OdbcCommand(SQLInsert, Conn)
                With CMD
                    .Parameters.AddWithValue("@nama_jurusan", TbNamaJurusan.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Tersimpan")
                formKosong()
                formNormal()
                load_jurusan()
            Catch ex As Exception
                MessageBox.Show("error : " + ex.Message)
            Finally
                closeConn()
                BtnTambah.Text = "Tambah"
                btnBatal.Visible = False
                DataGridJurusan.Enabled = True
                TbCariData.Enabled = True
            End Try
        End If

    End Sub

    Private Sub DataGridJurusan_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridJurusan.SelectionChanged
        Dim i As Integer = DataGridJurusan.CurrentRow.Index
        _id = Convert.ToString(DataGridJurusan.Item(0, i).Value)
        _nama = Convert.ToString(DataGridJurusan.Item(1, i).Value)
    End Sub

    Private Sub DataGridJurusan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJurusan.CellDoubleClick
        TbIdJurusan.Text = _id
        TbNamaJurusan.Text = _nama

        TbNamaJurusan.Enabled = True

        DataGridJurusan.Enabled = False
        TbCariData.Enabled = False
        BtnTambah.Visible = False
        BtnEdit.Visible = True
        BtnHapus.Visible = True
        btnBatal.Visible = True
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            openConn()
            If MsgBox("Are you sure you want to update the data?", vbYesNo + vbQuestion) = vbYes Then
                SQLUpdate = "UPDATE jurusan set nama_jurusan= ? WHERE id_jurusan like '" & TbIdJurusan.Text & "'"
                CMD = New OdbcCommand(SQLUpdate, Conn)
                With CMD
                    .Parameters.AddWithValue("@nama_jurusan", TbNamaJurusan.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Updated")
                formKosong()
                load_jurusan()
                BtnEdit.Visible = False
                BtnHapus.Visible = False
                BtnTambah.Visible = True
                btnBatal.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
            DataGridJurusan.Enabled = True
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
                SQLDelete = "DELETE FROM jurusan WHERE id_kelas ='" & TbIdJurusan.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)

                CMD.ExecuteNonQuery()

                MsgBox("Data Deleted.")
                formKosong()
                formNormal()
                load_jurusan()
                BtnTambah.Visible = True
                BtnEdit.Visible = False
                BtnHapus.Visible = False
                btnBatal.Visible = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
                DataGridJurusan.Enabled = True
                TbCariData.Enabled = True
            End Try
        Else
            TbNamaJurusan.Focus()
        End If

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        formKosong()
        formNormal()
        BtnTambah.Visible = True
        BtnEdit.Visible = False
        BtnHapus.Visible = False
        btnBatal.Visible = False
        DataGridJurusan.Enabled = True
        TbCariData.Enabled = True
    End Sub


End Class