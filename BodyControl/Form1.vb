Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim BMI As Single
            Dim IdHight As Single
            Dim IdWeight As Single
            Dim BEnergy As Single
            Dim IhBEd As Single
            Dim IwBEd As Single
            Dim st1 As Single
            Dim st2 As Single
            Dim st3 As Single
            Dim st4 As Single
            Dim Age As Single = Single.Parse(AgeInput.Text)
            Dim Hight As Single = Single.Parse(HightInput.Text)
            Dim Weight As Single = Single.Parse(WeightInput.Text)

            BMI = 10000 * Weight / Hight ^ 2

            State1.BackColor = Color.Empty
            State2.BackColor = Color.Empty
            State3.BackColor = Color.Empty
            State4.BackColor = Color.Empty
            State5.BackColor = Color.Empty

            IdHight = Math.Floor(100 * Math.Sqrt(10000 * Weight / 22.2) + 0.5) / 100
            IdealHight.Text = IdHight

            IdWeight = Math.Floor(22.2 * Hight ^ 2 / 100 + 0.5) / 100
            IdealWeight.Text = IdWeight

            st1 = Math.Floor(18 * Hight ^ 2 / 100 + 0.5) / 100
            st2 = Math.Floor(20 * Hight ^ 2 / 100 + 0.5) / 100
            st3 = Math.Floor(24 * Hight ^ 2 / 100 + 0.5) / 100
            st4 = Math.Floor(26 * Hight ^ 2 / 100 + 0.5) / 100

            Select Case BMI
                Case Is <= 18
                    State1.BackColor = Color.Red
                Case Is <= 20
                    State2.BackColor = Color.Pink
                Case Is <= 24
                    State3.BackColor = Color.Yellow
                Case Is <= 26
                    State4.BackColor = Color.Pink
                Case Else
                    State5.BackColor = Color.Red
            End Select

            If rbMale.Checked = True Then
                BEnergy = 66.5 + Weight * 13.75 + Hight * 5.003 - Age * 6.775
                IhBEd = 66.5 + Weight * 13.75 + IdHight * 5.003 - Age * 6.775
                IwBEd = 66.5 + IdWeight * 13.75 + Hight * 5.003 - Age * 6.775
            ElseIf rbFemale.Checked = True Then
                BEnergy = 655.1 + Weight * 9.563 + Hight * 1.85 - Age * 4.676
                IhBEd = 655.1 + Weight * 9.563 + IdHight * 1.85 - Age * 4.676
                IwBEd = 655.1 + IdWeight * 9.563 + Hight * 1.85 - Age * 4.676
            End If

            Up1.Text = st1
            Low2.Text = st1
            Up2.Text = st2
            Low3.Text = st2
            Up3.Text = st3
            Low4.Text = st3
            Up4.Text = st4
            Low5.Text = st4

            Index.Text = Math.Floor(BMI * 100 + 0.5) / 100
            BaseEnergy.Text = Math.Floor(BEnergy * 100 + 0.5) / 100
            IHBE.Text = Math.Floor(IhBEd * 100 + 0.5) / 100
            IWBE.Text = Math.Floor(IwBEd * 100 + 0.5) / 100

            Panel1.Visible = True

        Catch ex As Exception
            MsgBox("‚È‚ñ‚Æ‚©‚µ‚Ä‚­‚¾‚³‚¢I", MsgBoxStyle.Exclamation)

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        State1.BackColor = Color.Empty
        State2.BackColor = Color.Empty
        State3.BackColor = Color.Empty
        State4.BackColor = Color.Empty
        State5.BackColor = Color.Empty

        Panel1.Visible = False

        Index.Text = "?????"
        IdealHight.Text = "?????"
        IdealWeight.Text = "?????"
        BaseEnergy.Text = "?????"
        IHBE.Text = "?????"
        IWBE.Text = "?????"

        AgeInput.Text = ""
        HightInput.Text = ""
        WeightInput.Text = ""
        rbMale.Checked = False
        rbFemale.Checked = False

    End Sub

End Class
