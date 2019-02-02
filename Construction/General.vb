Imports System.Data.SqlClient
Module General
    Public sqlconn, sqldb, sqluser, sqlpass, connetionString, qry, uname, utype, eid, rtype, custname, u_type, bid As String
    Public cnn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr, dr1 As SqlDataReader
    Public attr, prid, prjid As String
    Public editrec As Boolean
    Public cid, pid, tid, taxid, taxinid, custpid, u_id As Integer
    Public ds As New DataSet
    Public adapter As New SqlDataAdapter
    Public i, mid, rid, gid As Integer

    Public Sub dbconf()
        sqlconn = "(local)"
        sqldb = "Construction_philo"
        sqluser = "sa"
        sqlpass = "mangalore123"
    End Sub

    Public Sub open_db()
        dbconf()
        connetionString = "Data Source=" & sqlconn & ";Initial Catalog=" & sqldb & ";User ID=" & sqluser & ";Password=" & sqlpass & ""
        cnn = New SqlConnection(connetionString)
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Database not connected! Check for connections ", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub close_db()
        cnn.Close()
    End Sub
End Module
