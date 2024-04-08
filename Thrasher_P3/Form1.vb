'Olivia Thrasher
'Assignment P3
'GUI Development Class
Public Class Form1
    'Clears everything
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextPointsBox.Clear()
        TextBoxOutput.Clear()
        RadioGourmet.Select()
        RadioPrePay.Select()
        TextPointsBox.Focus()

    End Sub

    Private Sub TextPointsBox_TextChanged(sender As Object, e As EventArgs) Handles TextPointsBox.TextChanged

    End Sub
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click

        Dim strPoints As String = TextPointsBox.Text
        Dim PlatChoice As Double

        'This is to check which radio button is selected
        Select Case True
            Case RadioGourmet.Checked, RadioSausage.Checked
                PlatChoice = 49.99
            Case RadioVeggie.Checked, RadioFruit.Checked
                PlatChoice = 29.99
            Case RadioWraps.Checked
                PlatChoice = 59.99
        End Select

        'This is the input validation and (string to double) conversion
        If Not String.IsNullOrWhiteSpace(TextPointsBox.Text) Then
            If IsNumeric(strPoints) Then
                Dim numPoints = Convert.ToDouble(strPoints)

                'Input validation so program won't allow negatives
                If numPoints < 0 Then
                    MsgBox("You cannot input points below zero.", MsgBoxStyle.Information, "Negative Loyalty Points")
                    TextPointsBox.Clear()
                    TextBoxOutput.Clear()
                    TextPointsBox.Focus()

                Else

                    'This is the math calculation
                    Dim XPoints As Double = Math.Floor(numPoints / 10)
                    Dim YPoints As Double = XPoints * 5 / 100
                    Dim numDiscount As Double = PlatChoice * YPoints
                    Dim numAmount As Double = PlatChoice - numDiscount


                    'More input validations
                    If numDiscount >= PlatChoice Then
                        MsgBox("You cannot use that many points.", MsgBoxStyle.Information, "Too Many Loyalty Points")
                        TextBoxOutput.Clear()
                        TextBoxOutput.Hide()
                        TextPointsBox.Clear()
                        TextPointsBox.Focus()

                    Else
                        'This is to make sure the numbers are formatted correctly
                        Dim strAmount = numAmount.ToString("C2")
                        Dim textstrPoints = numPoints.ToString("G")
                        TextBoxOutput.Show()
                        'This checks what platter and payment method is selected
                        If RadioGourmet.Checked Then
                            If RadioPrePay.Checked Then
                                TextBoxOutput.Text = "Your order Gourmet Cheese costs " + strAmount + " using Pre-Pay after discount of " + textstrPoints + " loyalty points."

                            ElseIf RadioPickupPay.Checked Then
                                TextBoxOutput.Text = "Your order Gourmet Cheese costs " + strAmount + " using Pay upon Pickup after discount of " + textstrPoints + " loyalty points."

                            Else
                            End If

                        ElseIf RadioWraps.Checked Then
                            If RadioPrePay.Checked Then
                                TextBoxOutput.Text = "Your order Pinwheel Wraps costs " + strAmount + " using Pre-Pay after discount of " + textstrPoints + " loyalty points."

                            ElseIf RadioPickupPay.Checked Then
                                TextBoxOutput.Text = "Your order Pinwheel Wraps costs " + strAmount + " using Pay upon Pickup after discount of " + textstrPoints + " loyalty points."

                            Else
                            End If
                        ElseIf RadioVeggie.Checked Then
                            If RadioPrePay.Checked Then
                                TextBoxOutput.Text = "Your order Veggie Plater costs " + strAmount + " using Pre-Pay after discount of " + textstrPoints + " loyalty points."

                            ElseIf RadioPickupPay.Checked Then
                                TextBoxOutput.Text = "Your order Veggie Plater costs " + strAmount + " using Pay upon Pickup after discount of " + textstrPoints + " loyalty points."

                            Else
                            End If
                        ElseIf RadioSausage.Checked Then
                            If RadioPrePay.Checked Then
                                TextBoxOutput.Text = "Your order Veggie Plater costs " + strAmount + " using Pre-Pay after discount of " + textstrPoints + " loyalty points."

                            ElseIf RadioPickupPay.Checked Then
                                TextBoxOutput.Text = "Your order Veggie Plater costs " + strAmount + " using Pay upon Pickup after discount of " + textstrPoints + " loyalty points."

                            Else
                            End If
                        ElseIf RadioFruit.Checked Then
                            If RadioPrePay.Checked Then
                                TextBoxOutput.Text = "Your order Fruit Plater costs " + strAmount + " using Pre-Pay after discount of " + textstrPoints + " loyalty points."

                            ElseIf RadioPickupPay.Checked Then
                                TextBoxOutput.Text = "Your order Fruit Plater costs " + strAmount + " using Pay upon Pickup after discount of " + textstrPoints + " loyalty points."

                            Else
                            End If
                        Else



                        End If
                    End If

                End If
            Else
                'Error Message Box
                MsgBox("Please enter a valid number.", MsgBoxStyle.DefaultButton1, "Invalid Input")
                TextPointsBox.Clear()
                TextBoxOutput.Clear()
                TextPointsBox.Focus()

            End If
        End If


    End Sub

    'Clear everything
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextPointsBox.Clear()
        TextBoxOutput.Clear()
        RadioGourmet.Select()
        RadioPrePay.Select()
        TextPointsBox.Focus()

    End Sub

End Class
