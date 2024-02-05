Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class Dashboard
    Dim rowCount As Integer

    Private Sub PnJurusan_Click(sender As Object, e As EventArgs) Handles PnJurusan.Click
        DataJurusan.Show()
        Me.Hide()
    End Sub

    Private Sub PnKelas_Click(sender As Object, e As EventArgs) Handles PnKelas.Click
        DataKelas.Show()
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
        Me.Hide()
        DataTransaksi.Show()
    End Sub

    Private Sub PnLaporan_Click(sender As Object, e As EventArgs) Handles PnLaporan.Click

    End Sub


    Private Sub DataGridAngkatan_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridAngkatan.SelectionChanged
        Try
            Dim i As Integer = DataGridAngkatan.CurrentRow.Index
            Dim selectedYear As String = Convert.ToString(DataGridAngkatan.Item(0, i).Value)

            ' Call the count_TTahunTransaksi function with the selected year
            count_TTahunTransaksi(selectedYear)
            sum_TTahunTerima(selectedYear)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count_siswa()
        count_petugas()
        count_jurusan()
        count_kelas()
        count_angkatan()
        load_angkatan()

        count_TTransaksi()
        count_TBulanTransaksi()

        sum_TTerima()
        sum_TBulanTerima()

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim FT As DateTime = New DateTime()
        LbNow.Text = FT.Now.ToString("F")
    End Sub

End Class
