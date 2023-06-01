Public Class TheForm
    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        input.Text = ""
        negoutput.Text = ""
        posoutput.Text = ""
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Close()
    End Sub

    Private Sub calcbtn_Click(sender As Object, e As EventArgs) Handles calcbtn.Click
        Dim arr(), a, pos, neg, i As Integer
        a = CInt(input.Text)
        ReDim arr(a)
        For i = 0 To a - 1 Step 1
            arr(i) = CInt(InputBox("Enter the element: "))
            If arr(i) > 0 Then
                pos = pos + arr(i)
            ElseIf arr(i) < 0 Then
                neg = neg + arr(i)
            End If
        Next
        negoutput.Text = neg
        posoutput.Text = pos
    End Sub
End Class
