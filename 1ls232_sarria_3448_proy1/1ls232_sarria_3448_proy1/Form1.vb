Public Class Form1

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Public Sub btn_iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_iniciar.Click
        Dim rnd As System.Random = New System.Random()
        ' asignar numeros
        itxt0.Text = rnd.Next(1, 10)
        itxt2.Text = rnd.Next(1, 10)
        itxt4.Text = rnd.Next(1, 10)
        itxt6.Text = rnd.Next(1, 10)
        ' asignar operador


        itxt1.Text = generar_operador()
        itxt3.Text = generar_operador()
        itxt5.Text = generar_operador()

        Dim salida As Integer

        salida = generar_resultado(CInt(itxt0.Text), CInt(itxt2.Text), itxt1.Text)
        salida = generar_resultado(salida, CInt(itxt4.Text), itxt3.Text)
        salida = generar_resultado(salida, CInt(itxt6.Text), itxt5.Text)

        i_result.Text = salida

        ' MsgBox(salida)

    End Sub

    Public Function generar_operador()
        Dim operador(3) As String

        operador(0) = "+"
        operador(1) = "-"
        operador(2) = "*"
        operador(3) = "/"

        Return operador(CInt(Int((4 * Rnd()))))
    End Function

    Public Function generar_resultado(ByVal x As Integer,
                                      ByVal y As Integer,
                                      ByVal operador As String)
        Select Case operador
            Case "+"
                Return x + y
            Case "-"
                Return x - y
            Case "*"
                Return CInt(x * y)
            Case "/"
                Return CInt(x / y)
            Case Else
                Return "exit"
        End Select

    End Function

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
