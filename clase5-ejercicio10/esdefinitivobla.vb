<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmhagamoscalculos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl1numero = New System.Windows.Forms.Label()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.txt2numero = New System.Windows.Forms.TextBox()
        Me.txt1numero = New System.Windows.Forms.TextBox()
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.btnresta = New System.Windows.Forms.Button()
        Me.lblresta = New System.Windows.Forms.Label()
        Me.btnmultiplicar = New System.Windows.Forms.Button()
        Me.lblmultiplicar = New System.Windows.Forms.Label()
        Me.btndivision = New System.Windows.Forms.Button()
        Me.lbldivision = New System.Windows.Forms.Label()
        Me.lbl2numero = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl1numero
        '
        Me.lbl1numero.BackColor = System.Drawing.Color.BlueViolet
        Me.lbl1numero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1numero.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl1numero.Location = New System.Drawing.Point(109, 134)
        Me.lbl1numero.Name = "lbl1numero"
        Me.lbl1numero.Size = New System.Drawing.Size(237, 23)
        Me.lbl1numero.TabIndex = 4
        Me.lbl1numero.Text = "Ingrese primer número"
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnborrar.Image = Global.quizasesteseadefinitivo.My.Resources.Resources._1589408
        Me.btnborrar.Location = New System.Drawing.Point(572, 118)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(123, 111)
        Me.btnborrar.TabIndex = 10
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'txt2numero
        '
        Me.txt2numero.Location = New System.Drawing.Point(356, 194)
        Me.txt2numero.Name = "txt2numero"
        Me.txt2numero.Size = New System.Drawing.Size(195, 20)
        Me.txt2numero.TabIndex = 11
        '
        'txt1numero
        '
        Me.txt1numero.Location = New System.Drawing.Point(356, 134)
        Me.txt1numero.Name = "txt1numero"
        Me.txt1numero.Size = New System.Drawing.Size(195, 20)
        Me.txt1numero.TabIndex = 12
        '
        'btnsuma
        '
        Me.btnsuma.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnsuma.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsuma.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsuma.Location = New System.Drawing.Point(126, 330)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(75, 62)
        Me.btnsuma.TabIndex = 14
        Me.btnsuma.Text = "+"
        Me.btnsuma.UseVisualStyleBackColor = False
        '
        'lblsuma
        '
        Me.lblsuma.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblsuma.Location = New System.Drawing.Point(123, 428)
        Me.lblsuma.Name = "lblsuma"
        Me.lblsuma.Size = New System.Drawing.Size(78, 23)
        Me.lblsuma.TabIndex = 13
        '
        'btnresta
        '
        Me.btnresta.BackColor = System.Drawing.Color.Red
        Me.btnresta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnresta.Location = New System.Drawing.Point(285, 330)
        Me.btnresta.Name = "btnresta"
        Me.btnresta.Size = New System.Drawing.Size(75, 62)
        Me.btnresta.TabIndex = 16
        Me.btnresta.Text = "-"
        Me.btnresta.UseVisualStyleBackColor = False
        '
        'lblresta
        '
        Me.lblresta.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblresta.Location = New System.Drawing.Point(282, 428)
        Me.lblresta.Name = "lblresta"
        Me.lblresta.Size = New System.Drawing.Size(78, 23)
        Me.lblresta.TabIndex = 15
        '
        'btnmultiplicar
        '
        Me.btnmultiplicar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnmultiplicar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmultiplicar.Location = New System.Drawing.Point(440, 330)
        Me.btnmultiplicar.Name = "btnmultiplicar"
        Me.btnmultiplicar.Size = New System.Drawing.Size(75, 62)
        Me.btnmultiplicar.TabIndex = 18
        Me.btnmultiplicar.Text = "x"
        Me.btnmultiplicar.UseVisualStyleBackColor = False
        '
        'lblmultiplicar
        '
        Me.lblmultiplicar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblmultiplicar.Location = New System.Drawing.Point(437, 428)
        Me.lblmultiplicar.Name = "lblmultiplicar"
        Me.lblmultiplicar.Size = New System.Drawing.Size(78, 23)
        Me.lblmultiplicar.TabIndex = 17
        '
        'btndivision
        '
        Me.btndivision.BackColor = System.Drawing.Color.Gold
        Me.btndivision.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndivision.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndivision.Location = New System.Drawing.Point(598, 330)
        Me.btndivision.Name = "btndivision"
        Me.btndivision.Size = New System.Drawing.Size(75, 62)
        Me.btndivision.TabIndex = 20
        Me.btndivision.Text = "%"
        Me.btndivision.UseVisualStyleBackColor = False
        '
        'lbldivision
        '
        Me.lbldivision.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldivision.Location = New System.Drawing.Point(595, 428)
        Me.lbldivision.Name = "lbldivision"
        Me.lbldivision.Size = New System.Drawing.Size(78, 23)
        Me.lbldivision.TabIndex = 19
        '
        'lbl2numero
        '
        Me.lbl2numero.BackColor = System.Drawing.Color.BlueViolet
        Me.lbl2numero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2numero.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl2numero.Location = New System.Drawing.Point(109, 191)
        Me.lbl2numero.Name = "lbl2numero"
        Me.lbl2numero.Size = New System.Drawing.Size(237, 23)
        Me.lbl2numero.TabIndex = 21
        Me.lbl2numero.Text = "Ingrese segundo número"
        '
        'frmhagamoscalculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 606)
        Me.Controls.Add(Me.lbl2numero)
        Me.Controls.Add(Me.btndivision)
        Me.Controls.Add(Me.lbldivision)
        Me.Controls.Add(Me.btnmultiplicar)
        Me.Controls.Add(Me.lblmultiplicar)
        Me.Controls.Add(Me.btnresta)
        Me.Controls.Add(Me.lblresta)
        Me.Controls.Add(Me.btnsuma)
        Me.Controls.Add(Me.lblsuma)
        Me.Controls.Add(Me.txt1numero)
        Me.Controls.Add(Me.txt2numero)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.lbl1numero)
        Me.Name = "frmhagamoscalculos"
        Me.Text = "Hagamos calculos!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1numero As Label
    Friend WithEvents btnborrar As Button
    Friend WithEvents txt2numero As TextBox
    Friend WithEvents txt1numero As TextBox
    Friend WithEvents btnsuma As Button
    Friend WithEvents lblsuma As Label
    Friend WithEvents btnresta As Button
    Friend WithEvents lblresta As Label
    Friend WithEvents btnmultiplicar As Button
    Friend WithEvents lblmultiplicar As Label
    Friend WithEvents btndivision As Button
    Friend WithEvents lbldivision As Label
    Friend WithEvents lbl2numero As Label

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click

        lblsuma.Text = Val(Me.txt1numero.Text) + Val(Me.txt2numero.Text)

        txt1numero.Focus()
        txt2numero.Focus()
    End Sub
    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click

        lblresta.Text = Val(Me.txt1numero.Text) - Val(Me.txt2numero.Text)

        txt1numero.Focus()
        txt2numero.Focus()
    End Sub

    Private Sub btnmultiplicar_Click(sender As Object, e As EventArgs) Handles btnmultiplicar.Click

        lblmultiplicar.Text = Val(Me.txt1numero.Text) * Val(Me.txt2numero.Text)

        txt1numero.Focus()
        txt2numero.Focus()
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click

        lbldivision.Text = Val(Me.txt1numero.Text) / Val(Me.txt2numero.Text)

        txt1numero.Focus()
        txt2numero.Focus()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        lblsuma.Text = ""
        lblresta.Text = ""
        lblmultiplicar.Text = ""
        lbldivision.Text = ""
        txt1numero.Text = ""
        txt2numero.Text = ""
    End Sub
End Class
