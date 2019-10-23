Public Class Form1

    Dim vtxt_texto(6) As TextBox
    Dim vtxt_num(6) As TextBox
    Dim vbtn_num(3) As Button
    Dim vbtn_oper(3) As Button
    Dim contador As Integer

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        contador = 60
        txt_time.Text = contador
        Dim i As Integer
        Dim rnd As System.Random = New System.Random()
        Dim txt_texto As TextBox
        Dim txt_num As TextBox
        Dim btn_num As Button
        Dim btn_oper As Button

        For i = 0 To 6
            txt_texto = New TextBox
            txt_texto.Size = New Size(22, 20)
            txt_texto.Location = New Point(33 + (txt_texto.Width + 6) * i, 12)
            txt_texto.Enabled = False
            'txt_texto.Text = rnd.Next(1, 10)
            Controls.Add(txt_texto)
            vtxt_texto(i) = txt_texto

            txt_num = New TextBox
            txt_num.Size = New Size(22, 20)
            txt_num.Enabled = False
            txt_num.Location = New Point(33 + (txt_num.Width + 6) * i, 43)
            'txt_texto.Text = rnd.Next(1, 10)
            Controls.Add(txt_num)
            vtxt_num(i) = txt_num
        Next

        For i = 0 To 3
            btn_num = New Button
            btn_num.Size = New Size(22, 20)
            btn_num.Location = New Point(75 + (btn_num.Width + 6) * i, 74)
            btn_num.Tag = 0
            Controls.Add(btn_num)
            vbtn_num(i) = btn_num
            AddHandler btn_num.Click, AddressOf btn_name_click

            btn_oper = New Button
            btn_oper.Size = New Size(22, 20)
            btn_oper.Location = New Point(75 + (btn_oper.Width + 6) * i, 105)
            btn_oper.Tag = 0
            btn_oper.Enabled = False
            Controls.Add(btn_oper)
            vbtn_oper(i) = btn_oper
            AddHandler btn_oper.Click, AddressOf btn_oper_click
        Next

        txt_indice.Text = 0

    End Sub

    Dim valores(3) As Integer

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Public Sub btn_iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_iniciar.Click

        iniciar()

    End Sub

    Sub btn_name_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn_temp As Button
        btn_temp = CType(sender, Button)
        vtxt_num(txt_indice.Text).Text = btn_temp.Text
        If Val(txt_indice.Text) <= 6 Then
            vtxt_num(Val(txt_indice.Text)).Text = btn_temp.Text
            txt_indice.Text = Val(txt_indice.Text) + 1

        End If
        p_result.Text = realizar_operacion(vtxt_num)

        For i = 0 To 3
            If txt_indice.Text <= 6 Then
                vbtn_oper(i).Enabled = True
            End If

            If vbtn_num(i).Tag = 0 Then
                vbtn_num(i).Enabled = False
            End If
        Next

        ' btn_temp.Tag = 1

        ' Asignar al tag del vector numero la posicion actual
        btn_temp.Tag = Val(txt_indice.Text)

        'valido si es correcto el resultado y uso todos los numeros
        If Val(txt_indice.Text) = 7 And i_result.Text = p_result.Text Then
            time.Stop()
            MsgBox("lo lograste click en aceptar para  continuar")

            'aumento 40 segundos si completa la operacion
            contador = Val(txt_time.Text) + 40
            'txt_time.Text = Val(txt_time.Text) + 40

            For i = 0 To 6
                'limpio los campos de numeros
                vtxt_num(i).Text = ""
            Next
            p_result.Text = ""

            txt_indice.Text = 0

            For i = 0 To 3
                vbtn_num(i).Tag = 0
                vbtn_num(i).Enabled = True
            Next



            iniciar()


        End If

    End Sub

    Sub btn_oper_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn_temp As Button
        btn_temp = CType(sender, Button)
        vtxt_num(txt_indice.Text).Text = btn_temp.Text
        If Val(txt_indice.Text) <= 6 Then
            vtxt_num(Val(txt_indice.Text)).Text = btn_temp.Text
            txt_indice.Text = Val(txt_indice.Text) + 1

        End If
        p_result.Text = realizar_operacion(vtxt_num)

        For i = 0 To 3

            vbtn_oper(i).Enabled = False

            If vbtn_num(i).Tag = 0 Then
                vbtn_num(i).Enabled = True
            End If

        Next
    End Sub


    Public Function generar_operador()
        Dim operador(3) As String

        operador(0) = "+"
        operador(1) = "-"
        operador(2) = "*"
        operador(3) = "/"

        Return operador(CInt(Int((4 * Rnd()))))
    End Function

    Public Function realizar_operacion(ByVal data() As TextBox)

        'llamado a la clase
        Dim operacion As New Operacion()

        Dim i As Integer
        Dim resultado As Integer

        If Not String.IsNullOrEmpty(data(0).Text) Then
            resultado = CInt(data(i).Text)
        End If

        If Not String.IsNullOrEmpty(data(2).Text) Then
            resultado = operacion.generar_resultado(resultado, CInt(data(2).Text), data(1).Text)
        Else
            Return resultado
        End If

        If Not String.IsNullOrEmpty(data(4).Text) Then
            resultado = operacion.generar_resultado(resultado, CInt(data(4).Text), data(3).Text)
        Else
            Return resultado
        End If

        If Not String.IsNullOrEmpty(data(6).Text) Then
            resultado = operacion.generar_resultado(resultado, CInt(data(6).Text), data(5).Text)
        End If

        Return resultado

    End Function

    'resolver el problema
    Private Sub btn_resolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_resolver.Click


        time.Stop()
        txt_time.Text = 0
        For i = 0 To 6
            vtxt_num(i).Text = vtxt_texto(i).Text
        Next

        'calcular resultado
        p_result.Text = realizar_operacion(vtxt_num)


    End Sub

    Public Function iniciar()
        time.Start()
        btn_resolver.Enabled = True
        Dim rnd As System.Random = New System.Random()
        Dim i As Integer
        Dim temp
        Dim operador(3) As String
        operador(0) = "+"
        operador(1) = "-"
        operador(2) = "*"
        operador(3) = "/"

        ' generar numeros
        For i = 0 To 6
            vtxt_texto(i).Text = rnd.Next(1, 10)
            'asignar numeros de los botones
            vbtn_num(i / 2).Text = vtxt_texto(i).Text
            i = i + 1
        Next

        'desordenar numeros
        For i = 1 To 3
            temp = vbtn_num(0).Text
            vbtn_num(0).Text = vbtn_num(i).Text
            vbtn_num(i).Text = temp
        Next

        ' generar operadores
        For i = 1 To 5
            vtxt_texto(i).Text = generar_operador()
            i = i + 1
        Next

        For i = 0 To 3
            vbtn_oper(i).Text = operador(i)

        Next

        i_result.Text = realizar_operacion(vtxt_texto)
    End Function

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        Dim j As Integer
        Dim i As Integer

        If txt_indice.Text - 1 < 0 Then
            Return
        End If

        txt_indice.Text = txt_indice.Text - 1
        i = Val(txt_indice.Text)

        If i < 0 Then
            Return
        End If
        vtxt_num(i).Text = ""

        If (i Mod 2 = 0) Then
            For j = 0 To 3
                If (vbtn_num(j).Tag = i + 1) Then
                    vbtn_num(j).Tag = 0
                    vbtn_num(j).Enabled = True
                End If
            Next

        Else

            For i = 0 To 3
                vbtn_oper(i).Enabled = True
            Next

        End If

        'actulizar resultado en tiempo real
        p_result.Text = realizar_operacion(vtxt_num)

    End Sub

    Private Sub time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time.Tick
        contador = contador - 1
        txt_time.Text = contador
        If contador = 0 Then
            time.Stop()
            MsgBox("Perdiste se agoto el tiempo!")
        End If
    End Sub

End Class
