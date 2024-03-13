Public Class CSWETestComponent

    Implements ISWETestComponent

    Private Property answer As String

    Public Function PubFunc(str1 As String, str2 As String, bFlag As Integer) As String _
         Implements ISWETestComponent.PubFunc

        If bFlag = True Then
            Sub1(str1)
        Else
            Sub2(str1, str2)
        End If

        Return answer

    End Function

    Private Sub Sub1(str1 As String)
        answer = "<<<" + str1 + ">>>"
    End Sub

    Private Sub Sub2(str1 As String, str2 As String)

        Dim str1Len As Integer = Len(str1)
        Dim str2Len As Integer = Len(str2)

        If str1Len = str2Len Or String.IsNullOrEmpty(str1) Or String.IsNullOrEmpty(str2) Then
            answer = "VIGA"

        ElseIf str1Len < str2Len Then
            answer = str1 + " (" + CStr(str1Len) + ") " + "< " + str2 + " (" + CStr(str2Len) + ")"

        ElseIf str1Len > str2Len Then
            answer = str1 + " (" + CStr(str1Len) + ") " + "> " + str2 + " (" + CStr(str2Len) + ")"
        End If


    End Sub

End Class
