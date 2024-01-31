Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class DataJurusan
    Dim _id, _nama As String
    Sub formKosong()
        TbIdJurusan.Clear()
        TbNamaJurusan.Clear()
    End Sub
    Private Sub PnDashboard_Click(sender As Object, e As EventArgs) Handles PnDashboard.Click
        Dashboard.Show()
    End Sub

    Private Sub PnKelas_Click(sender As Object, e As EventArgs) Handles PnKelas.Click
        DataKelas.Show()
    End Sub

    Private Sub PnSiswa_Click(sender As Object, e As EventArgs) Handles PnSiswa.Click
        DataPetugas.Show()
    End Sub

    Private Sub PnPetugas_Click(sender As Object, e As EventArgs) Handles PnPetugas.Click
        DataPetugas.Show()
    End Sub

    Private Sub PnTransaksi_Click(sender As Object, e As EventArgs) Handles PnTransaksi.Click

    End Sub

    Private Sub PnLaporan_Click(sender As Object, e As EventArgs) Handles PnLaporan.Click

    End Sub

    Private Sub DataJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbIdJurusan.Enabled = False
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False

        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM jurusan ORDER BY id_jurusan ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "jurusan")
            DataGridJurusan.DataSource = DS.Tables("jurusan")
            DataGridJurusan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
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
        Try
            openConn()
            SQLInsert = "INSERT INTO jurusan(nama_jurusan) VALUES (?)"
            CMD = New OdbcCommand(SQLInsert, Conn)
            With CMD
                .Parameters.AddWithValue("@nama_jurusan", TbNamaJurusan.Text)
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

    Private Sub DataGridJurusan_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridJurusan.SelectionChanged
        Dim i As Integer = DataGridJurusan.CurrentRow.Index
        _id = Convert.ToString(DataGridJurusan.Item(0, i).Value)
        _nama = Convert.ToString(DataGridJurusan.Item(1, i).Value)
    End Sub

    Private Sub DataGridJurusan_DoubleClick(sender As Object, e As EventArgs) Handles DataGridJurusan.DoubleClick
        TbIdJurusan.Text = _id
        TbNamaJurusan.Text = _nama
        BtnTambah.Enabled = False
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
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
                SQLDelete = "DELETE FROM jurusan WHERE id_kelas ='" & TbIdJurusan.Text & "'"
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
            TbNamaJurusan.Focus()
        End If
    End Sub
End Class