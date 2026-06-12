Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Module DBConnection
    Public con As New MySqlConnection("server=localhost;user id=root;password=;database=boarding_system")
    Public currentUser As DataTable = Nothing
    Public isDarkMode As Boolean = False

    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For i = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Public Sub OpenConnection()
        Try
            If con.State = ConnectionState.Closed Then con.Open()
        Catch ex As Exception
            MessageBox.Show("Database connection failed! Make sure XAMPP MySQL is running.",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CloseConnection()
        If con.State = ConnectionState.Open Then con.Close()
    End Sub

    Public Function ExecuteQuery(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(query, con)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
        Return dt
    End Function

    Public Function ExecuteNonQuery(query As String) As Integer
        Dim rows As Integer = 0
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(query, con)
                rows = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
        Return rows
    End Function

    ' Improved parameterized methods
    Public Function ExecuteParamQuery(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(query, con)
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return dt
    End Function

    Public Function ExecuteNonQueryParam(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Dim rows As Integer = 0
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(query, con)
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                rows = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return rows
    End Function

    Public Sub LogActivity(userId As Integer, action As String, details As String)
        Try
            Dim query As String = "INSERT INTO activity_logs (user_id, action, details) VALUES (@uid, @act, @det)"
            Dim params As New Dictionary(Of String, Object) From {
                {"@uid", userId}, {"@act", action}, {"@det", details}
            }
            ExecuteNonQueryParam(query, params)
        Catch
        End Try
    End Sub
End Module