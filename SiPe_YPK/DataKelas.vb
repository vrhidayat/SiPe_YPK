Imports System.Data.Odbc

Public Class DataKelas
    Dim _id, _nama, _jurusan As String
    Sub formKosong()
        TbIdKelas.Clear()
        TbNamaKelas.Clear()
        CbJurusan.DataSource = Nothing
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
        Me.Hide()
    End Sub
    Private Sub PnSiswa_Click(sender As Object, e As EventArgs) Handles PnSiswa.Click
        DataSiswa.Show()
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

    Private Sub DataKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbIdKelas.Enabled = False
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        getJurusan()

        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM kelas ORDER BY id_kelas ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "kelas")
            DataGridKelas.DataSource = DS.Tables("kelas")
            DataGridKelas.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
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
        Catch ex As Exception
            MessageBox.Show("error : " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub DataGridKelas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridKelas.SelectionChanged
        Dim i As Integer = DataGridKelas.CurrentRow.Index
        _id = Convert.ToString(DataGridKelas.Item(0, i).Value)
        _nama = Convert.ToString(DataGridKelas.Item(1, i).Value)
        _jurusan = DataGridKelas.Item(2, i).Value
    End Sub

    Private Sub DataGridKelas_DoubleClick(sender As Object, e As EventArgs) Handles DataGridKelas.DoubleClick
        TbIdKelas.Text = _id
        TbNamaKelas.Text = _nama
        CbJurusan.SelectedValue = _jurusan
        BtnTambah.Enabled = False
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
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
                SQLDelete = "DELETE FROM kelas WHERE id_kelas ='" & TbIdKelas.Text & "'"
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
            TbNamaKelas.Focus()
        End If
    End Sub
End Class