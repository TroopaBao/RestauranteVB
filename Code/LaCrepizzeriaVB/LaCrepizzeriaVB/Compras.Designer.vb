<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.textboxempleado = New System.Windows.Forms.TextBox()
        Me.labelempleado = New System.Windows.Forms.Label()
        Me.labelfecha = New System.Windows.Forms.Label()
        Me.fechacompra = New System.Windows.Forms.DateTimePicker()
        Me.datacompras = New System.Windows.Forms.DataGridView()
        Me.agregar = New System.Windows.Forms.Button()
        Me.quitar = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        Me.labelclave = New System.Windows.Forms.Label()
        Me.textboxidcompra = New System.Windows.Forms.TextBox()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.datacompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textboxempleado
        '
        Me.textboxempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxempleado.Location = New System.Drawing.Point(248, 37)
        Me.textboxempleado.Multiline = True
        Me.textboxempleado.Name = "textboxempleado"
        Me.textboxempleado.Size = New System.Drawing.Size(185, 28)
        Me.textboxempleado.TabIndex = 1
        '
        'labelempleado
        '
        Me.labelempleado.AutoSize = True
        Me.labelempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelempleado.Location = New System.Drawing.Point(12, 40)
        Me.labelempleado.Name = "labelempleado"
        Me.labelempleado.Size = New System.Drawing.Size(230, 25)
        Me.labelempleado.TabIndex = 2
        Me.labelempleado.Text = "Compra realizada por: "
        '
        'labelfecha
        '
        Me.labelfecha.AutoSize = True
        Me.labelfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelfecha.Location = New System.Drawing.Point(13, 79)
        Me.labelfecha.Name = "labelfecha"
        Me.labelfecha.Size = New System.Drawing.Size(195, 25)
        Me.labelfecha.TabIndex = 3
        Me.labelfecha.Text = "Fecha de Compra: "
        '
        'fechacompra
        '
        Me.fechacompra.Location = New System.Drawing.Point(223, 84)
        Me.fechacompra.Name = "fechacompra"
        Me.fechacompra.Size = New System.Drawing.Size(200, 20)
        Me.fechacompra.TabIndex = 4
        '
        'datacompras
        '
        Me.datacompras.AllowUserToAddRows = False
        Me.datacompras.AllowUserToDeleteRows = False
        Me.datacompras.AllowUserToOrderColumns = True
        Me.datacompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datacompras.Location = New System.Drawing.Point(43, 123)
        Me.datacompras.Name = "datacompras"
        Me.datacompras.ReadOnly = True
        Me.datacompras.Size = New System.Drawing.Size(552, 239)
        Me.datacompras.TabIndex = 5
        '
        'agregar
        '
        Me.agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.Location = New System.Drawing.Point(437, 368)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(158, 33)
        Me.agregar.TabIndex = 6
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'quitar
        '
        Me.quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitar.Location = New System.Drawing.Point(275, 368)
        Me.quitar.Name = "quitar"
        Me.quitar.Size = New System.Drawing.Size(158, 33)
        Me.quitar.TabIndex = 7
        Me.quitar.Text = "Quitar"
        Me.quitar.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(533, 74)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(108, 38)
        Me.buscar.TabIndex = 8
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'labelclave
        '
        Me.labelclave.AutoSize = True
        Me.labelclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelclave.Location = New System.Drawing.Point(449, 40)
        Me.labelclave.Name = "labelclave"
        Me.labelclave.Size = New System.Drawing.Size(126, 25)
        Me.labelclave.TabIndex = 9
        Me.labelclave.Text = "Compra No."
        '
        'textboxidcompra
        '
        Me.textboxidcompra.Location = New System.Drawing.Point(581, 37)
        Me.textboxidcompra.Multiline = True
        Me.textboxidcompra.Name = "textboxidcompra"
        Me.textboxidcompra.Size = New System.Drawing.Size(83, 28)
        Me.textboxidcompra.TabIndex = 10
        '
        'aceptar
        '
        Me.aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.Location = New System.Drawing.Point(512, 460)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(165, 66)
        Me.aceptar.TabIndex = 11
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Location = New System.Drawing.Point(334, 460)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(165, 66)
        Me.cancelar.TabIndex = 12
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LaCrepizzeriaVB.My.Resources.Resources.papasfrancesa1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(689, 538)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 538)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.textboxidcompra)
        Me.Controls.Add(Me.labelclave)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.quitar)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.datacompras)
        Me.Controls.Add(Me.fechacompra)
        Me.Controls.Add(Me.labelfecha)
        Me.Controls.Add(Me.labelempleado)
        Me.Controls.Add(Me.textboxempleado)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Compras"
        Me.Text = "Compras"
        CType(Me.datacompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textboxempleado As TextBox
    Friend WithEvents labelempleado As Label
    Friend WithEvents labelfecha As Label
    Friend WithEvents fechacompra As DateTimePicker
    Friend WithEvents datacompras As DataGridView
    Friend WithEvents agregar As Button
    Friend WithEvents quitar As Button
    Friend WithEvents buscar As Button
    Friend WithEvents labelclave As Label
    Friend WithEvents textboxidcompra As TextBox
    Friend WithEvents aceptar As Button
    Friend WithEvents cancelar As Button
End Class
