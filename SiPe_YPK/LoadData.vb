Imports System.Data.Odbc

Module LoadData
    Dim rowCount As Integer
    Public disable As Color = Color.FromArgb(0, 0, 4)
    Public add As Color = Color.FromArgb(0, 123, 255)
    Public edit As Color = Color.FromArgb(40, 167, 69)
    Public delete As Color = Color.FromArgb(220, 53, 69)
    Public Function load_petugas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM petugas ORDER BY id_petugas ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "petugas")
            DataPetugas.DataGridPetugas.DataSource = DS.Tables("petugas")
            DataPetugas.DataGridPetugas.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_jurusan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM jurusan ORDER BY id_jurusan ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "jurusan")
            DataJurusan.DataGridJurusan.DataSource = DS.Tables("jurusan")
            DataJurusan.DataGridJurusan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_kelas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM kelas ORDER BY id_kelas ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "kelas")
            DataKelas.DataGridKelas.DataSource = DS.Tables("kelas")
            DataKelas.DataGridKelas.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_siswa()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT * FROM siswa ORDER BY nisn ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")
            DataSiswa.DataGridSiswa.DataSource = DS.Tables("siswa")
            DataSiswa.DataGridSiswa.ReadOnly = True

            'DataTransaksi.DataGridSiswa.DataSource = DS.Tables("siswa")
            'DataTransaksi.DataGridSiswa.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_trSiswa()
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT siswa.nisn, siswa.nis, siswa.nama,
                siswa.id_kelas, kelas.nama_kelas, siswa.alamat, siswa.no_telp, siswa.id_spp, spp.tahun 
                FROM siswa INNER JOIN kelas ON siswa.id_kelas = kelas.id_kelas INNER JOIN spp
                ON siswa.id_spp = spp.id_spp ORDER BY siswa.nisn ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")
            DataTransaksi.DataGridSiswa.DataSource = DS.Tables("siswa")
            DataTransaksi.DataGridSiswa.ReadOnly = True
            DataTransaksi.DataGridSiswa.Columns("id_kelas").Visible = False
            DataTransaksi.DataGridSiswa.Columns("id_spp").Visible = False
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function load_angkatan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT tahun FROM spp ORDER BY tahun ASC", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "spp")
            Dashboard.DataGridAngkatan.DataSource = DS.Tables("spp")
            Dashboard.DataGridAngkatan.ReadOnly = True
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_siswa()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(nisn) FROM siswa", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "siswa")

            rowCount = Convert.ToInt32(DS.Tables("siswa").Rows(0)(0))

            Dashboard.LbJumlahSiswa.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_petugas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(id_petugas) FROM petugas", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "petugas")

            rowCount = Convert.ToInt32(DS.Tables("petugas").Rows(0)(0))

            Dashboard.LbJumlahPetugas.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_jurusan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(id_jurusan) FROM jurusan", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "jurusan")

            rowCount = Convert.ToInt32(DS.Tables("jurusan").Rows(0)(0))

            Dashboard.LbJumlahJurusan.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_kelas()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(id_kelas) FROM kelas", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "kelas")

            rowCount = Convert.ToInt32(DS.Tables("kelas").Rows(0)(0))

            Dashboard.LbJumlahKelas.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_angkatan()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(id_spp) FROM spp", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "spp")

            rowCount = Convert.ToInt32(DS.Tables("spp").Rows(0)(0))

            Dashboard.LbJumlahAngkatan.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_TTransaksi()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(*) FROM pembayaran", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")

            rowCount = Convert.ToInt32(DS.Tables("pembayaran").Rows(0)(0))

            Dashboard.LbTotalTransaksi.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_TBulanTransaksi()
        Try
            Call openConn()
            DA = New OdbcDataAdapter("SELECT COUNT(*) FROM pembayaran WHERE MONTH(tgl_bayar) = MONTH(NOW())", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")

            rowCount = Convert.ToInt32(DS.Tables("pembayaran").Rows(0)(0))

            Dashboard.LbTotalBulanTransaksi.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function count_TTahunTransaksi(year As String)
        Try
            Call openConn()
            DA = New OdbcDataAdapter($"SELECT COUNT(*) FROM pembayaran WHERE YEAR(tgl_bayar) = {year}", Conn)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "pembayaran")

            rowCount = Convert.ToInt32(DS.Tables("pembayaran").Rows(0)(0))

            Dashboard.LbTotalTahunTransaksi.Text = rowCount.ToString
            Call closeConn()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call closeConn()
        End Try
    End Function

    Public Function sum_TTerima()
        Try
            openConn()
            Dim query As String = "SELECT SUM(jumlah_bayar) FROM pembayaran"
            Using command As New OdbcCommand(query, Conn)
                Dim totalPenerimaan As Object = command.ExecuteScalar()
                Dim idr As New System.Globalization.CultureInfo("id-ID")

                If totalPenerimaan IsNot DBNull.Value Then
                    Dashboard.LbTotalPenerimaan.Text = Convert.ToDecimal(totalPenerimaan).ToString("C0", idr)
                Else
                    Dashboard.LbTotalPenerimaan.Text = "0" ' or any default value if the sum is null
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Call closeConn()
        End Try
    End Function

    Public Function sum_TBulanTerima()
        Try
            openConn()
            Dim query As String = "SELECT SUM(jumlah_bayar) FROM pembayaran WHERE MONTH(tgl_bayar) = MONTH(NOW())"
            Using command As New OdbcCommand(query, Conn)
                Dim totalPenerimaan As Object = command.ExecuteScalar()
                Dim idr As New System.Globalization.CultureInfo("id-ID")

                If totalPenerimaan IsNot DBNull.Value Then
                    Dashboard.LbTotalBulanPenerimaan.Text = Convert.ToDecimal(totalPenerimaan).ToString("C0", idr)
                Else
                    Dashboard.LbTotalBulanPenerimaan.Text = "0" ' or any default value if the sum is null
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Call closeConn()
        End Try
    End Function

    Public Function sum_TTahunTerima(year As String)
        Try
            openConn()
            Dim query As String = $"SELECT SUM(jumlah_bayar) FROM pembayaran WHERE YEAR(tgl_bayar) = {year}"
            Using command As New OdbcCommand(query, Conn)
                Dim totalPenerimaan As Object = command.ExecuteScalar()
                Dim idr As New System.Globalization.CultureInfo("id-ID")

                If totalPenerimaan IsNot DBNull.Value Then
                    Dashboard.LbTotalTahunPenerimaan.Text = Convert.ToDecimal(totalPenerimaan).ToString("C0", idr)
                Else
                    Dashboard.LbTotalTahunPenerimaan.Text = "0" ' or any default value if the sum is null
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Call closeConn()
        End Try
    End Function

    Public Function getKelas(id As String)
        Try
            openConn()
            Dim query As String = $"SELECT * FROM kelas WHERE id_kelas = {id}"
            Dim command As OdbcCommand = New OdbcCommand(query, Conn)

            DA = New OdbcDataAdapter(command)
            DS = New DataSet
            DA.Fill(DS, "kelas")

            If DS.Tables("kelas").Rows.Count > 0 Then
                DataTransaksi.LbNamaKelas.Text = DS.Tables("kelas").Rows(0)("nama_kelas").ToString()
            Else
                MessageBox.Show("No data found for the specified id.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            closeConn()
        End Try
    End Function

    Public Function getAngkatan(id As String)
        Try
            openConn()
            Dim query As String = $"SELECT * FROM spp WHERE id_spp= {id}"
            Dim command As OdbcCommand = New OdbcCommand(query, Conn)

            DA = New OdbcDataAdapter(command)
            DS = New DataSet
            DA.Fill(DS, "spp")

            If DS.Tables("spp").Rows.Count > 0 Then
                DataTransaksi.LbTahunAngkatan.Text = DS.Tables("spp").Rows(0)("tahun").ToString()
            Else
                MessageBox.Show("No data found for the specified id.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
            closeConn()
        End Try
    End Function
End Module
