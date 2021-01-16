<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosProcesados
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelnombre = New System.Windows.Forms.Label()
        Me.labelprecio = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.textboxnombre = New System.Windows.Forms.TextBox()
        Me.textboxprecio = New System.Windows.Forms.TextBox()
        Me.labelclave = New System.Windows.Forms.Label()
        Me.textboxclave = New System.Windows.Forms.TextBox()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.agregar = New System.Windows.Forms.Button()
        Me.quitar = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        Me.radiobuttonclave = New System.Windows.Forms.RadioButton()
        Me.radiobuttonombre = New System.Windows.Forms.RadioButton()
        Me.labelestado = New System.Windows.Forms.Label()
        Me.radiobuttonalta = New System.Windows.Forms.RadioButton()
        Me.radiobuttonbaja = New System.Windows.Forms.RadioButton()
        Me.busqueda = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LaCrepizzeriaVB.My.Resources.Resources.crepas4
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(739, 545)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'labelnombre
        '
        Me.labelnombre.AutoSize = True
        Me.labelnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnombre.Location = New System.Drawing.Point(12, 64)
        Me.labelnombre.Name = "labelnombre"
        Me.labelnombre.Size = New System.Drawing.Size(93, 25)
        Me.labelnombre.TabIndex = 2
        Me.labelnombre.Text = "Nombre:"
        '
        'labelprecio
        '
        Me.labelprecio.AutoSize = True
        Me.labelprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelprecio.Location = New System.Drawing.Point(12, 115)
        Me.labelprecio.Name = "labelprecio"
        Me.labelprecio.Size = New System.Drawing.Size(85, 25)
        Me.labelprecio.TabIndex = 3
        Me.labelprecio.Text = "Precio: "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(662, 194)
        Me.DataGridView1.TabIndex = 4
        '
        'textboxnombre
        '
        Me.textboxnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxnombre.Location = New System.Drawing.Point(132, 56)
        Me.textboxnombre.Multiline = True
        Me.textboxnombre.Name = "textboxnombre"
        Me.textboxnombre.Size = New System.Drawing.Size(312, 33)
        Me.textboxnombre.TabIndex = 5
        '
        'textboxprecio
        '
        Me.textboxprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxprecio.Location = New System.Drawing.Point(132, 107)
        Me.textboxprecio.Multiline = True
        Me.textboxprecio.Name = "textboxprecio"
        Me.textboxprecio.Size = New System.Drawing.Size(102, 33)
        Me.textboxprecio.TabIndex = 7
        '
        'labelclave
        '
        Me.labelclave.AutoSize = True
        Me.labelclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelclave.Location = New System.Drawing.Point(12, 22)
        Me.labelclave.Name = "labelclave"
        Me.labelclave.Size = New System.Drawing.Size(106, 25)
        Me.labelclave.TabIndex = 1
        Me.labelclave.Text = "Clave No."
        '
        'textboxclave
        '
        Me.textboxclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxclave.Location = New System.Drawing.Point(132, 17)
        Me.textboxclave.Multiline = True
        Me.textboxclave.Name = "textboxclave"
        Me.textboxclave.Size = New System.Drawing.Size(75, 33)
        Me.textboxclave.TabIndex = 6
        '
        'aceptar
        '
        Me.aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.Location = New System.Drawing.Point(530, 469)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(197, 64)
        Me.aceptar.TabIndex = 8
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Location = New System.Drawing.Point(327, 469)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(197, 64)
        Me.cancelar.TabIndex = 9
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'agregar
        '
        Me.agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.Location = New System.Drawing.Point(162, 411)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(144, 41)
        Me.agregar.TabIndex = 10
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'quitar
        '
        Me.quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitar.Location = New System.Drawing.Point(12, 411)
        Me.quitar.Name = "quitar"
        Me.quitar.Size = New System.Drawing.Size(144, 41)
        Me.quitar.TabIndex = 11
        Me.quitar.Text = "Quitar"
        Me.quitar.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(544, 151)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(144, 41)
        Me.buscar.TabIndex = 12
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'radiobuttonclave
        '
        Me.radiobuttonclave.AutoSize = True
        Me.radiobuttonclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonclave.Location = New System.Drawing.Point(500, 107)
        Me.radiobuttonclave.Name = "radiobuttonclave"
        Me.radiobuttonclave.Size = New System.Drawing.Size(111, 28)
        Me.radiobuttonclave.TabIndex = 13
        Me.radiobuttonclave.TabStop = True
        Me.radiobuttonclave.Text = "Id o Clave"
        Me.radiobuttonclave.UseVisualStyleBackColor = True
        '
        'radiobuttonombre
        '
        Me.radiobuttonombre.AutoSize = True
        Me.radiobuttonombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonombre.Location = New System.Drawing.Point(630, 107)
        Me.radiobuttonombre.Name = "radiobuttonombre"
        Me.radiobuttonombre.Size = New System.Drawing.Size(97, 28)
        Me.radiobuttonombre.TabIndex = 14
        Me.radiobuttonombre.TabStop = True
        Me.radiobuttonombre.Text = "Nombre"
        Me.radiobuttonombre.UseVisualStyleBackColor = True
        '
        'labelestado
        '
        Me.labelestado.AutoSize = True
        Me.labelestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelestado.Location = New System.Drawing.Point(12, 167)
        Me.labelestado.Name = "labelestado"
        Me.labelestado.Size = New System.Drawing.Size(91, 25)
        Me.labelestado.TabIndex = 15
        Me.labelestado.Text = "Estado: "
        '
        'radiobuttonalta
        '
        Me.radiobuttonalta.AutoSize = True
        Me.radiobuttonalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonalta.Location = New System.Drawing.Point(132, 164)
        Me.radiobuttonalta.Name = "radiobuttonalta"
        Me.radiobuttonalta.Size = New System.Drawing.Size(59, 28)
        Me.radiobuttonalta.TabIndex = 16
        Me.radiobuttonalta.TabStop = True
        Me.radiobuttonalta.Text = "Alta"
        Me.radiobuttonalta.UseVisualStyleBackColor = True
        '
        'radiobuttonbaja
        '
        Me.radiobuttonbaja.AutoSize = True
        Me.radiobuttonbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonbaja.Location = New System.Drawing.Point(213, 164)
        Me.radiobuttonbaja.Name = "radiobuttonbaja"
        Me.radiobuttonbaja.Size = New System.Drawing.Size(64, 28)
        Me.radiobuttonbaja.TabIndex = 17
        Me.radiobuttonbaja.TabStop = True
        Me.radiobuttonbaja.Text = "Baja"
        Me.radiobuttonbaja.UseVisualStyleBackColor = True
        '
        'busqueda
        '
        Me.busqueda.AutoSize = True
        Me.busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busqueda.Location = New System.Drawing.Point(539, 64)
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(152, 25)
        Me.busqueda.TabIndex = 18
        Me.busqueda.Text = "Búsqueda por:"
        '
        'ProductosProcesados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 545)
        Me.Controls.Add(Me.busqueda)
        Me.Controls.Add(Me.radiobuttonbaja)
        Me.Controls.Add(Me.radiobuttonalta)
        Me.Controls.Add(Me.labelestado)
        Me.Controls.Add(Me.radiobuttonombre)
        Me.Controls.Add(Me.radiobuttonclave)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.quitar)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.textboxprecio)
        Me.Controls.Add(Me.textboxclave)
        Me.Controls.Add(Me.textboxnombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.labelprecio)
        Me.Controls.Add(Me.labelnombre)
        Me.Controls.Add(Me.labelclave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProductosProcesados"
        Me.Text = "ProductosProcesados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelnombre As Label
    Friend WithEvents labelprecio As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents textboxnombre As TextBox
    Friend WithEvents textboxprecio As TextBox
    Friend WithEvents labelclave As Label
    Friend WithEvents textboxclave As TextBox
    Friend WithEvents aceptar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents agregar As Button
    Friend WithEvents quitar As Button
    Friend WithEvents buscar As Button
    Friend WithEvents radiobuttonclave As RadioButton
    Friend WithEvents radiobuttonombre As RadioButton
    Friend WithEvents labelestado As Label
    Friend WithEvents radiobuttonalta As RadioButton
    Friend WithEvents radiobuttonbaja As RadioButton
    Friend WithEvents busqueda As Label
End Class
