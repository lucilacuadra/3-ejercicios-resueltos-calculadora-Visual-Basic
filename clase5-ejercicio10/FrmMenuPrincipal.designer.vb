<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrincipal
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
        Me.btnform1 = New System.Windows.Forms.Button()
        Me.btnform2 = New System.Windows.Forms.Button()
        Me.btnform3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnform1
        '
        Me.btnform1.Location = New System.Drawing.Point(244, 90)
        Me.btnform1.Name = "btnform1"
        Me.btnform1.Size = New System.Drawing.Size(175, 43)
        Me.btnform1.TabIndex = 0
        Me.btnform1.Text = "Formulario 1"
        Me.btnform1.UseVisualStyleBackColor = True
        '
        'btnform2
        '
        Me.btnform2.Location = New System.Drawing.Point(244, 190)
        Me.btnform2.Name = "btnform2"
        Me.btnform2.Size = New System.Drawing.Size(175, 43)
        Me.btnform2.TabIndex = 1
        Me.btnform2.Text = "Formulario 2"
        Me.btnform2.UseVisualStyleBackColor = True
        '
        'btnform3
        '
        Me.btnform3.Location = New System.Drawing.Point(244, 291)
        Me.btnform3.Name = "btnform3"
        Me.btnform3.Size = New System.Drawing.Size(175, 42)
        Me.btnform3.TabIndex = 2
        Me.btnform3.Text = "Formulario 3"
        Me.btnform3.UseVisualStyleBackColor = True
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 460)
        Me.Controls.Add(Me.btnform3)
        Me.Controls.Add(Me.btnform2)
        Me.Controls.Add(Me.btnform1)
        Me.Name = "FrmMenuPrincipal"
        Me.Text = "Formularios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnform1 As Button
    Friend WithEvents btnform2 As Button
    Friend WithEvents btnform3 As Button
End Class
