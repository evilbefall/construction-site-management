Imports System.Text.RegularExpressions
Public Class Form1

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        Dim emailaddress = txtEmail.Text
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            'emailaddresscheck = True
            MsgBox("Correct email ID", MsgBoxStyle.Information)
        Else
            'emailaddresscheck = False
            MsgBox("Incorrect email ID", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
