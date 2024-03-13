Public Class SWETestForm
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Try
            Dim SWEngineeringTest As PrjSWEngineeringTest.ISWETestComponent
            SWEngineeringTest = New PrjSWEngineeringTest.CSWETestComponent
            txtAns.Text = SWEngineeringTest.PubFunc(txtInput1.Text, txtInput2.Text, chkCheck.Checked)
        Catch ex As Exception
            txtAns.Text = "Component threw an error!" + vbCrLf + vbCrLf + ex.ToString
        End Try
    End Sub

End Class
