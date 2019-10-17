Public Class Operacion

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

End Class
