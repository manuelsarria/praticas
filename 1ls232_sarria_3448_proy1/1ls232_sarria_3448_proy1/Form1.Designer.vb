<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.i_result = New System.Windows.Forms.TextBox()
        Me.p_result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.txt_tiempo = New System.Windows.Forms.TextBox()
        Me.btn_resolver = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.result_parcial = New System.Windows.Forms.TextBox()
        Me.txt_indice = New System.Windows.Forms.TextBox()
        Me.Txtpb = New System.Windows.Forms.TextBox()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'i_result
        '
        Me.i_result.Location = New System.Drawing.Point(248, 10)
        Me.i_result.Name = "i_result"
        Me.i_result.Size = New System.Drawing.Size(48, 20)
        Me.i_result.TabIndex = 1
        '
        'p_result
        '
        Me.p_result.Location = New System.Drawing.Point(252, 50)
        Me.p_result.Name = "p_result"
        Me.p_result.Size = New System.Drawing.Size(44, 20)
        Me.p_result.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "="
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Location = New System.Drawing.Point(302, 17)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_iniciar.TabIndex = 27
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'txt_tiempo
        '
        Me.txt_tiempo.Location = New System.Drawing.Point(440, 19)
        Me.txt_tiempo.Name = "txt_tiempo"
        Me.txt_tiempo.Size = New System.Drawing.Size(40, 20)
        Me.txt_tiempo.TabIndex = 28
        '
        'btn_resolver
        '
        Me.btn_resolver.Location = New System.Drawing.Point(303, 50)
        Me.btn_resolver.Name = "btn_resolver"
        Me.btn_resolver.Size = New System.Drawing.Size(75, 23)
        Me.btn_resolver.TabIndex = 29
        Me.btn_resolver.Text = "Resolver"
        Me.btn_resolver.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Tiempo ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 32
        '
        'result_parcial
        '
        Me.result_parcial.Location = New System.Drawing.Point(252, 93)
        Me.result_parcial.Name = "result_parcial"
        Me.result_parcial.Size = New System.Drawing.Size(43, 20)
        Me.result_parcial.TabIndex = 33
        '
        'txt_indice
        '
        Me.txt_indice.Location = New System.Drawing.Point(512, 19)
        Me.txt_indice.Name = "txt_indice"
        Me.txt_indice.Size = New System.Drawing.Size(27, 20)
        Me.txt_indice.TabIndex = 34
        '
        'Txtpb
        '
        Me.Txtpb.Location = New System.Drawing.Point(527, 110)
        Me.Txtpb.Name = "Txtpb"
        Me.Txtpb.Size = New System.Drawing.Size(91, 20)
        Me.Txtpb.TabIndex = 35
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(302, 80)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(76, 33)
        Me.btn_borrar.TabIndex = 36
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 248)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.Txtpb)
        Me.Controls.Add(Me.txt_indice)
        Me.Controls.Add(Me.result_parcial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_resolver)
        Me.Controls.Add(Me.txt_tiempo)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.p_result)
        Me.Controls.Add(Me.i_result)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents i_result As System.Windows.Forms.TextBox
    Friend WithEvents p_result As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_iniciar As System.Windows.Forms.Button
    Friend WithEvents txt_tiempo As System.Windows.Forms.TextBox
    Friend WithEvents btn_resolver As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents result_parcial As System.Windows.Forms.TextBox
    Friend WithEvents txt_indice As System.Windows.Forms.TextBox
    Friend WithEvents Txtpb As System.Windows.Forms.TextBox
    Friend WithEvents btn_borrar As System.Windows.Forms.Button

End Class
