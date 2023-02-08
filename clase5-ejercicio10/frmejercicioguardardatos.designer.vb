<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmejercicioguardardatos
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
        Me.components = New System.ComponentModel.Container()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblultimo = New System.Windows.Forms.Label()
        Me.lblanteultimo = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.lblpenultimo = New System.Windows.Forms.Label()
        Me.lbltotalnumero = New System.Windows.Forms.Label()
        Me.lblpromedio = New System.Windows.Forms.Label()
        Me.lbltotalingresados = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(296, 61)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(187, 20)
        Me.txtnumero.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblultimo
        '
        Me.lblultimo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblultimo.Location = New System.Drawing.Point(214, 147)
        Me.lblultimo.Name = "lblultimo"
        Me.lblultimo.Size = New System.Drawing.Size(100, 23)
        Me.lblultimo.TabIndex = 2
        '
        'lblanteultimo
        '
        Me.lblanteultimo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblanteultimo.Location = New System.Drawing.Point(341, 147)
        Me.lblanteultimo.Name = "lblanteultimo"
        Me.lblanteultimo.Size = New System.Drawing.Size(100, 23)
        Me.lblanteultimo.TabIndex = 3
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(344, 102)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(92, 23)
        Me.btnsubmit.TabIndex = 4
        Me.btnsubmit.Text = "Subir"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'lblpenultimo
        '
        Me.lblpenultimo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblpenultimo.Location = New System.Drawing.Point(460, 147)
        Me.lblpenultimo.Name = "lblpenultimo"
        Me.lblpenultimo.Size = New System.Drawing.Size(100, 23)
        Me.lblpenultimo.TabIndex = 5
        '
        'lbltotalnumero
        '
        Me.lbltotalnumero.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltotalnumero.Location = New System.Drawing.Point(214, 229)
        Me.lbltotalnumero.Name = "lbltotalnumero"
        Me.lbltotalnumero.Size = New System.Drawing.Size(100, 60)
        Me.lbltotalnumero.TabIndex = 6
        '
        'lblpromedio
        '
        Me.lblpromedio.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpromedio.Location = New System.Drawing.Point(460, 266)
        Me.lblpromedio.Name = "lblpromedio"
        Me.lblpromedio.Size = New System.Drawing.Size(100, 23)
        Me.lblpromedio.TabIndex = 7
        '
        'lbltotalingresados
        '
        Me.lbltotalingresados.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltotalingresados.Location = New System.Drawing.Point(460, 229)
        Me.lbltotalingresados.Name = "lbltotalingresados"
        Me.lbltotalingresados.Size = New System.Drawing.Size(100, 23)
        Me.lbltotalingresados.TabIndex = 8
        '
        'frmejercicioguardardatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbltotalingresados)
        Me.Controls.Add(Me.lblpromedio)
        Me.Controls.Add(Me.lbltotalnumero)
        Me.Controls.Add(Me.lblpenultimo)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.lblanteultimo)
        Me.Controls.Add(Me.lblultimo)
        Me.Controls.Add(Me.txtnumero)
        Me.Name = "frmejercicioguardardatos"
        Me.Text = "ejercicio guardar datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnumero As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblultimo As Label
    Friend WithEvents lblanteultimo As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents lblpenultimo As Label
    Friend WithEvents lbltotalnumero As Label
    Friend WithEvents lblpromedio As Label
    Friend WithEvents lbltotalingresados As Label
End Class
