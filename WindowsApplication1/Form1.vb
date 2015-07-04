Public Class Form1
    Dim fcnRpt, gearRatio, resolution, cnvCnt, mchSpd, rRPM, rolDia, compLen, spnRPS, spnRPM, rolRPS, rolRPM, spnDia As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        fcnRpt = Double.Parse(txtFcnRpt.Text)
        gearRatio = Double.Parse(txtGR.Text)
        resolution = Double.Parse(txtRes.Text)
        mchSpd = Double.Parse(txtMchSpd.Text)
        cnvCnt = resolution * gearRatio / fcnRpt
        rRPM = mchSpd / fcnRpt
        txtCC.Text = cnvCnt.ToString
        txtRolRRPM.Text = rRPM.ToString
    End Sub

    Private Sub AboutGPMDriveToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutGPMDriveToolsToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnCalc2_Click(sender As Object, e As EventArgs) Handles btnCalc2.Click
        fcnRpt = Double.Parse(txtRolDia.Text)
        gearRatio = Double.Parse(txtGR2.Text)
        resolution = Double.Parse(txtRes2.Text)
        mchSpd = Double.Parse(txtMchSpd2.Text)
        rolDia = Double.Parse(txtRolDia.Text)
        compLen = Double.Parse(txtCompLen.Text)
        cnvCnt = resolution * gearRatio * compLen / rolDia / Math.PI
        rRPM = mchSpd * compLen / rolDia / Math.PI
        cnvCnt = Math.Ceiling(cnvCnt)
        txtCC2.Text = cnvCnt.ToString
        txtRolRPM2.Text = rRPM.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        gearRatio = Double.Parse(txtGR3.Text)
        resolution = Double.Parse(txtRes3.Text)
        mchSpd = Double.Parse(txtMchSpd3.Text)
        spnDia = Double.Parse(txtSpnDia.Text)
        rolDia = Double.Parse(txtFulRolDia.Text)
        compLen = Double.Parse(txtComLen2.Text)
        spnRPM = System.Math.Round(mchSpd * compLen / spnDia / Math.PI, 2)
        spnRPS = System.Math.Round(spnRPM / 60, 2)
        rolRPM = System.Math.Round(spnDia / rolDia * spnRPM, 2)
        rolRPS = System.Math.Round(rolRPM / 60, 2)
        txtSpnRPS.Text = spnRPS.ToString()
        txtSpnRPM.Text = spnRPM.ToString()
        txtFulRolRPS.Text = rolRPS.ToString()
        txtFulRolRPM.Text = rolRPM.ToString()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub
End Class
