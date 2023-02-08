<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnombreapellidoedad
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
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnnombre = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnapellido = New System.Windows.Forms.Button()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.btnedad = New System.Windows.Forms.Button()
        Me.lbledad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblnombre
        '
        Me.lblnombre.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblnombre.Location = New System.Drawing.Point(265, 127)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(218, 23)
        Me.lblnombre.TabIndex = 0
        '
        'btnnombre
        '
        Me.btnnombre.Location = New System.Drawing.Point(145, 127)
        Me.btnnombre.Name = "btnnombre"
        Me.btnnombre.Size = New System.Drawing.Size(97, 23)
        Me.btnnombre.TabIndex = 1
        Me.btnnombre.Text = "Nombre"
        Me.btnnombre.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(565, 298)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 2
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnapellido
        '
        Me.btnapellido.Location = New System.Drawing.Point(145, 185)
        Me.btnapellido.Name = "btnapellido"
        Me.btnapellido.Size = New System.Drawing.Size(97, 23)
        Me.btnapellido.TabIndex = 4
        Me.btnapellido.Text = "Apellido"
        Me.btnapellido.UseVisualStyleBackColor = True
        '
        'lblapellido
        '
        Me.lblapellido.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblapellido.Location = New System.Drawing.Point(265, 185)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(218, 23)
        Me.lblapellido.TabIndex = 3
        '
        'btnedad
        '
        Me.btnedad.Location = New System.Drawing.Point(145, 244)
        Me.btnedad.Name = "btnedad"
        Me.btnedad.Size = New System.Drawing.Size(97, 23)
        Me.btnedad.TabIndex = 6
        Me.btnedad.Text = "Edad"
        Me.btnedad.UseVisualStyleBackColor = True
        '
        'lbledad
        '
        Me.lbledad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbledad.Location = New System.Drawing.Point(265, 244)
        Me.lbledad.Name = "lbledad"
        Me.lbledad.Size = New System.Drawing.Size(218, 23)
        Me.lbledad.TabIndex = 5
        '
        'frmnombreapellidoedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnedad)
        Me.Controls.Add(Me.lbledad)
        Me.Controls.Add(Me.btnapellido)
        Me.Controls.Add(Me.lblapellido)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnnombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Name = "frmnombreapellidoedad"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblnombre As Label
    Friend WithEvents btnnombre As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnapellido As Button
    Friend WithEvents lblapellido As Label
    Friend WithEvents btnedad As Button
    Friend WithEvents lbledad As Label
End Class
