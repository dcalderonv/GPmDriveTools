Public Class Form2
    Dim GR As Double
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtP1.Text.Length <> 0 And txtP2.Text.Length <> 0 And txtGB.Text.Length <> 0 Then
            GR = Double.Parse(txtGB.Text) * Double.Parse(txtP2.Text) / Double.Parse(txtP1.Text)
            Form1.txtGR.Text = GR.ToString
            Form1.txtGR2.Text = GR.ToString
            Form1.txtGR3.Text = GR.ToString
            Me.Close()
        Else
            Dialog1.ShowDialog()
        End If

       
    End Sub
End Class