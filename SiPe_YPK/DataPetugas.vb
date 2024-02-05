Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class DataPetugas
    Dim _id, _username, _password, _nama, _level As String
    Sub formKosong()
        TbIdPetugas.Text = "auto"
        TbUsername.Clear()
        TbPassword.Clear()
        TbNamaPetugas.Clear()
        CbLevel.SelectedIndex = -1
    End Sub
    Sub formNormal()
        TbIdPetugas.Enabled = False
        TbUsername.Enabled = False
        TbPassword.Enabled = False
        TbNamaPetugas.Enabled = False
        CbLevel.Enabled = False
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
    Private Sub PnSiswa_Click(sender As Object, e As EventArgs) Handles PnSiswa.Click
        DataSiswa.Show()
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
    Private Sub DataPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnBatal.Visible = False

        formNormal()
        load_petugas()
    End Sub

    Private Sub TbCariData_TextChanged(sender As Object, e As EventArgs) Handles TbCariData.TextChanged
        Try
            openConn()
            DA = New OdbcDataAdapter("SELECT * FROM petugas WHERE username like '%" & TbCariData.Text & "%' OR nama_petugas like '%" & TbCariData.Text & "%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridPetugas.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "Tambah" Then
            TbUsername.Enabled = True
            TbPassword.Enabled = True
            TbNamaPetugas.Enabled = True
            CbLevel.Enabled = True
            BtnBatal.Visible = True
            DataGridPetugas.Enabled = False
            TbCariData.Enabled = False
            BtnTambah.Text = "Simpan"
        ElseIf BtnTambah.Text = "Simpan" Then
            Try
                openConn()
                SQLInsert = "INSERT INTO petugas(username, password, nama_petugas, level) VALUES (?,?,?,?)"
                CMD = New OdbcCommand(SQLInsert, Conn)
                With CMD
                    '.Parameters.AddWithValue("@id_kelas", tbi.Text)
                    .Parameters.AddWithValue("@username", TbUsername.Text)
                    .Parameters.AddWithValue("@password", TbPassword.Text)
                    .Parameters.AddWithValue("@nama_petugas", TbNamaPetugas.Text)
                    .Parameters.AddWithValue("@level", CbLevel.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Tersimpan❤️")
                formKosong()
                load_petugas()
            Catch ex As Exception
                MessageBox.Show("error : " + ex.Message)
            Finally
                closeConn()
                BtnTambah.Text = "Tambah"
                BtnBatal.Visible = False
                DataGridPetugas.Enabled = True
                TbCariData.Enabled = True
            End Try
        End If
    End Sub

    Private Sub DataGridPetugas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridPetugas.SelectionChanged
        Dim i As Integer = DataGridPetugas.CurrentRow.Index
        _id = Convert.ToString(DataGridPetugas.Item(0, i).Value)
        _username = Convert.ToString(DataGridPetugas.Item(1, i).Value)
        _password = Convert.ToString(DataGridPetugas.Item(2, i).Value)
        _nama = Convert.ToString(DataGridPetugas.Item(3, i).Value)
        _level = DataGridPetugas.Item(4, i).Value
    End Sub

    Private Sub DataGridPetugas_DoubleClick(sender As Object, e As EventArgs) Handles DataGridPetugas.DoubleClick
        TbIdPetugas.Text = _id
        TbUsername.Text = _username
        TbPassword.Text = _password
        TbNamaPetugas.Text = _nama
        CbLevel.SelectedText = _level
        DataGridPetugas.Enabled = False
        TbCariData.Enabled = False
        BtnTambah.Visible = False
        BtnEdit.Visible = True
        BtnHapus.Visible = True
        BtnBatal.Visible = True
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            openConn()
            If MsgBox("Are you sure you want to update the data?", vbYesNo + vbQuestion) = vbYes Then
                SQLUpdate = "UPDATE petugas set username= ?, password= ?, nama_petugas=?, level=? WHERE id_petugas like '" & TbIdPetugas.Text & "'"
                CMD = New OdbcCommand(SQLUpdate, Conn)
                With CMD
                    .Parameters.AddWithValue("@id_petugas", TbIdPetugas.Text)
                    .Parameters.AddWithValue("@username", TbUsername.Text)
                    .Parameters.AddWithValue("@password", TbPassword.Text)
                    .Parameters.AddWithValue("@nama_petugas", TbNamaPetugas.Text)
                    .Parameters.AddWithValue("@level", CbLevel.SelectedText)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Updated")
                formKosong()
                load_petugas()
                BtnEdit.Visible = False
                BtnHapus.Visible = False
                BtnTambah.Visible = True
                BtnBatal.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
            DataGridPetugas.Enabled = True
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
                SQLDelete = "DELETE FROM petugas WHERE id_petugas ='" & TbIdPetugas.Text & "'"
                CMD = New OdbcCommand(SQLDelete, Conn)

                CMD.ExecuteNonQuery()

                MsgBox("Data Deleted.")
                Call formKosong()
                load_petugas()
                BtnTambah.Visible = True
                BtnEdit.Visible = False
                BtnHapus.Visible = False
                BtnBatal.Visible = False
            Catch ex As Exception
                MsgBox("err:" + ex.Message)
            Finally
                closeConn()
            End Try
        Else
            TbUsername.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        formKosong()
        formNormal()
        BtnTambah.Visible = True
        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnBatal.Visible = False
        DataGridPetugas.Enabled = True
        TbCariData.Enabled = True
    End Sub
End Class