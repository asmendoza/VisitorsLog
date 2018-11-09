Imports MySql.Data.MySqlClient

Module General
    Public conn As MySqlConnection

    'Private Const SVR As String = "localhost"
    'Private Const PORT As String = "3306"
    'Private Const DB As String = "visitors"
    'Private Const UNAME As String = "visitor"
    'Private Const PWD As String = "visitors"

    Private SVR As String
    Private PORT As String
    Private DB As String
    Private UNAME As String
    Private PWD As String

    Private server As String

    Public u As String
    Public fname As String
    Public isAdmin As Boolean
    Public gate As Integer
    Public mode As String
    Public auto As Boolean

    Public initialFont As New Font(FontFamily.GenericSansSerif, 12, FontStyle.Italic)
    Public inputFont As New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)

    Public txtEdit As Boolean
    Private Sub RefreshSettings()
        SVR = My.Settings.dbaseServer
        PORT = My.Settings.dbasePort
        DB = My.Settings.dbaseSchema
        UNAME = My.Settings.dbaseUser
        PWD = My.Settings.dbasePwd
        mode = My.Settings.computerMode
        auto = My.Settings.AUTO_IN_OUT
    End Sub
    'Public Function ManageSettings(key As String, val As String) As Boolean
    '    Dim isManaged As Boolean = False
    '    Try
    '        settings.Item(key) = val
    '        settings.Save()
    '
    '        isManaged = True
    '    Catch ex As Exception
    '        Console.WriteLine(ex.Message)
    '    End Try
    '
    '        ManageSettings = isManaged
    '    End Function
    Public Function connect2() As MySqlConnection
        Dim p As MySqlConnection

        Call RefreshSettings()

        p = New MySqlConnection
        p.ConnectionString = String.Format("server={0}; 
            user id={1}; password={2}; database={3}; pooling=false" _
            , SVR, UNAME, PWD, DB)

        Try
            p.Open()
        Catch ex As Exception
            Console.WriteLine("Cannot connect to database." & vbCrLf &
                  ex.ToString)
        End Try

        connect2 = p
    End Function

    Public Function connect() As Boolean
        Dim isConnected As Boolean

        Call RefreshSettings()

        conn = New MySqlConnection()
        conn.ConnectionString = String.Format("server={0}; 
            user id={1}; password={2}; database={3}; pooling=false" _
            , SVR, UNAME, PWD, DB)
        'MsgBox(conn.ConnectionString, vbInformation + vbOKOnly)
        Try
            conn.Open()
            isConnected = True
        Catch ex As Exception
            MsgBox("Cannot connect to database." & vbCrLf &
                   ex.ToString, vbOKOnly + vbExclamation)
            isConnected = False
        End Try
        connect = isConnected
    End Function

    Public Sub disconnect()
        If conn.State = 1 Then
            conn.Close()
            conn = Nothing
        End If
    End Sub

    Public Sub TextBoxKeyPress(txtBox As TextBox, defaultCaption As String, isPassword As Boolean, e As KeyPressEventArgs)
        If UCase(Trim(txtBox.Text)) = Trim(UCase(defaultCaption)) _
            And (
                (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) _
                Or (Asc(e.KeyChar) >= 45 And Asc(e.KeyChar) <= 46) _
                Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) _
                Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) _
                Or (Asc(e.KeyChar) = 95)
            ) Then
            txtEdit = True
            txtBox.Text = ""
            txtBox.ForeColor = Color.Black
            txtBox.Font = inputFont
            If isPassword Then
                txtBox.PasswordChar = "*"
            End If
        End If
        txtEdit = False
    End Sub

    Public Sub TextBoxTextChange(txtBox As TextBox, defaultCaption As String, Optional isPassword As Boolean = False)
        If UCase(Trim(txtBox.Text)) = "" And txtEdit = False Then
            txtBox.Text = defaultCaption
            txtBox.ForeColor = Color.Silver
            txtBox.Font = initialFont
            If isPassword Then
                txtBox.PasswordChar = ""
            End If
        End If
    End Sub

    Public Sub ComboBoxKeyPress(cboBox As ComboBox, defaultCaption As String, e As KeyPressEventArgs)
        If UCase(Trim(cboBox.Text)) = Trim(UCase(defaultCaption)) _
            And (
                (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) _
                Or (Asc(e.KeyChar) >= 45 And Asc(e.KeyChar) <= 46) _
                Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) _
                Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) _
                Or (Asc(e.KeyChar) = 95)
            ) Then
            txtEdit = True
            cboBox.Text = ""
            cboBox.ForeColor = Color.Black
            cboBox.Font = inputFont
        End If
        txtEdit = False
    End Sub

    Public Sub ComboBoxClick(cboBox As ComboBox, defaultCaption As String, e As EventArgs)
        If UCase(Trim(cboBox.Text)) = Trim(UCase(defaultCaption)) Then
            txtEdit = True
            cboBox.Text = ""
            cboBox.ForeColor = Color.Black
            cboBox.Font = inputFont
        End If
        txtEdit = False
    End Sub

    Public Sub ComboBoxTextChange(cboBox As ComboBox, defaultCaption As String)
        If UCase(Trim(cboBox.Text)) = "" And txtEdit = False Then
            cboBox.Text = defaultCaption
            cboBox.ForeColor = Color.Silver
            cboBox.Font = initialFont
        End If
    End Sub

    Public Function ImageToByte(img As Image) As Byte()
        Dim mstream As New IO.MemoryStream
        Dim arrImage() As Byte
        Dim FileSize As UInt32

        img.Save(mstream, Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer
        FileSize = mstream.Length

        ImageToByte = arrImage
    End Function

    Public Function ByteToImage(img As Byte()) As Image
        Dim mstream As IO.MemoryStream
        Dim i As Image

        mstream = New IO.MemoryStream(img)
        i = Image.FromStream(mstream)

        ByteToImage = i
    End Function

    Public Function RFIDInUse(rfid_sn As String) As Boolean
        Dim inUse As Boolean = False
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader

        If connect() Then
            Try
                sql = New MySqlCommand
                sql.Connection = conn
                sql.CommandText = String.Format("SELECT in_use FROM rfid WHERE rfid_sn='{0}' OR rfid_no={1}", rfid_sn, Val(rfid_sn))
                r = sql.ExecuteReader

                While r.Read()
                    inUse = r.GetInt16("in_use")
                End While
            Catch ex As Exception
                Console.WriteLine("Something is wrong with the connection." & ex.Message)
            Finally
                If Not r Is Nothing Then
                    r.Close()
                    r = Nothing
                End If
                sql = Nothing
                disconnect()
            End Try
        Else
            Console.WriteLine("Cannot connect to the database server.")
        End If

        RFIDInUse = inUse
    End Function

    Public Sub UseRFID(rfid_sn As String, Optional toUse As Boolean = True)
        Dim sql As MySqlCommand

        If connect() Then
            Try
                sql = New MySqlCommand
                sql.Connection = conn
                sql.CommandText = String.Format("UPDATE rfid set in_use={0} WHERE rfid_sn='{1}'", toUse, rfid_sn)
                sql.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine("Something is wrong with the connection." & ex.Message)
            Finally
                sql = Nothing
                disconnect()
            End Try
        Else
            Console.WriteLine("Cannot connect to the database server.")
        End If
    End Sub
End Module
