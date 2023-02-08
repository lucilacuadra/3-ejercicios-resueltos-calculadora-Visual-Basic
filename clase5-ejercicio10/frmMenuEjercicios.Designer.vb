<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuEjercicios
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
        Me.btnform2 = New System.Windows.Forms.Button()
        Me.btnform1 = New System.Windows.Forms.Button()
        Me.btnform3 = New System.Windows.Forms.Button()
        Me.btnform4 = New System.Windows.Forms.Button()
        Me.btnform5 = New System.Windows.Forms.Button()
        Me.lblejerciciosrealizados = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnform2
        '
        Me.btnform2.Location = New System.Drawing.Point(175, 230)
        Me.btnform2.Name = "btnform2"
        Me.btnform2.Size = New System.Drawing.Size(175, 43)
        Me.btnform2.TabIndex = 4
        Me.btnform2.Text = "Formulario 2"
        Me.btnform2.UseVisualStyleBackColor = True
        '
        'btnform1
        '
        Me.btnform1.Location = New System.Drawing.Point(175, 130)
        Me.btnform1.Name = "btnform1"
        Me.btnform1.Size = New System.Drawing.Size(175, 43)
        Me.btnform1.TabIndex = 3
        Me.btnform1.Text = "Formulario 1"
        Me.btnform1.UseVisualStyleBackColor = True
        '
        'btnform3
        '
        Me.btnform3.Location = New System.Drawing.Point(444, 130)
        Me.btnform3.Name = "btnform3"
        Me.btnform3.Size = New System.Drawing.Size(175, 42)
        Me.btnform3.TabIndex = 8
        Me.btnform3.Text = "Formulario 3"
        Me.btnform3.UseVisualStyleBackColor = True
        '
        'btnform4
        '
        Me.btnform4.Location = New System.Drawing.Point(444, 230)
        Me.btnform4.Name = "btnform4"
        Me.btnform4.Size = New System.Drawing.Size(175, 43)
        Me.btnform4.TabIndex = 7
        Me.btnform4.Text = "Formulario 4"
        Me.btnform4.UseVisualStyleBackColor = True
        '
        'btnform5
        '
        Me.btnform5.Location = New System.Drawing.Point(317, 325)
        Me.btnform5.Name = "btnform5"
        Me.btnform5.Size = New System.Drawing.Size(175, 43)
        Me.btnform5.TabIndex = 6
        Me.btnform5.Text = "Formulario 5"
        Me.btnform5.UseVisualStyleBackColor = True
        '
        'lblejerciciosrealizados
        '
        Me.lblejerciciosrealizados.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblejerciciosrealizados.Location = New System.Drawing.Point(326, 40)
        Me.lblejerciciosrealizados.Name = "lblejerciciosrealizados"
        Me.lblejerciciosrealizados.Size = New System.Drawing.Size(157, 43)
        Me.lblejerciciosrealizados.TabIndex = 9
        Me.lblejerciciosrealizados.Text = "Ejercicios realizados"
        Me.lblejerciciosrealizados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMenuEjercicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblejerciciosrealizados)
        Me.Controls.Add(Me.btnform3)
        Me.Controls.Add(Me.btnform4)
        Me.Controls.Add(Me.btnform5)
        Me.Controls.Add(Me.btnform2)
        Me.Controls.Add(Me.btnform1)
        Me.Name = "frmMenuEjercicios"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnform2 As Button
    Friend WithEvents btnform1 As Button
    Friend WithEvents btnform3 As Button
    Friend WithEvents btnform4 As Button
    Friend WithEvents btnform5 As Button
    Friend WithEvents lblejerciciosrealizados As Label
End Class
