<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingredientes
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
        Me.labeltipoingrediente = New System.Windows.Forms.Label()
        Me.labelprecio = New System.Windows.Forms.Label()
        Me.labelcantidad = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.labelexistencias = New System.Windows.Forms.Label()
        Me.labelestado = New System.Windows.Forms.Label()
        Me.modificar = New System.Windows.Forms.Button()
        Me.textboxnombre = New System.Windows.Forms.TextBox()
        Me.textboxtipoingrediente = New System.Windows.Forms.TextBox()
        Me.textboxprecio = New System.Windows.Forms.TextBox()
        Me.textboxcantidad = New System.Windows.Forms.TextBox()
        Me.textboxexistencias = New System.Windows.Forms.TextBox()
        Me.radiobuttonalta = New System.Windows.Forms.RadioButton()
        Me.radiobuttonbaja = New System.Windows.Forms.RadioButton()
        Me.labelclave = New System.Windows.Forms.Label()
        Me.textboxclave = New System.Windows.Forms.TextBox()
        Me.radiobuttonclave = New System.Windows.Forms.RadioButton()
        Me.radiobuttonombre = New System.Windows.Forms.RadioButton()
        Me.labelbusqueda = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LaCrepizzeriaVB.My.Resources.Resources.ingredientes1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(737, 523)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'labelnombre
        '
        Me.labelnombre.AutoSize = True
        Me.labelnombre.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnombre.Location = New System.Drawing.Point(12, 70)
        Me.labelnombre.Name = "labelnombre"
        Me.labelnombre.Size = New System.Drawing.Size(99, 25)
        Me.labelnombre.TabIndex = 1
        Me.labelnombre.Text = "Nombre: "
        '
        'labeltipoingrediente
        '
        Me.labeltipoingrediente.AutoSize = True
        Me.labeltipoingrediente.Cursor = System.Windows.Forms.Cursors.Default
        Me.labeltipoingrediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltipoingrediente.Location = New System.Drawing.Point(12, 113)
        Me.labeltipoingrediente.Name = "labeltipoingrediente"
        Me.labeltipoingrediente.Size = New System.Drawing.Size(203, 25)
        Me.labeltipoingrediente.TabIndex = 2
        Me.labeltipoingrediente.Text = "Tipo de Ingrediente:"
        '
        'labelprecio
        '
        Me.labelprecio.AutoSize = True
        Me.labelprecio.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelprecio.Location = New System.Drawing.Point(12, 162)
        Me.labelprecio.Name = "labelprecio"
        Me.labelprecio.Size = New System.Drawing.Size(85, 25)
        Me.labelprecio.TabIndex = 3
        Me.labelprecio.Text = "Precio: "
        '
        'labelcantidad
        '
        Me.labelcantidad.AutoSize = True
        Me.labelcantidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcantidad.Location = New System.Drawing.Point(12, 220)
        Me.labelcantidad.Name = "labelcantidad"
        Me.labelcantidad.Size = New System.Drawing.Size(110, 25)
        Me.labelcantidad.TabIndex = 4
        Me.labelcantidad.Text = "Cantidad: "
        '
        'insertar
        '
        Me.insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(576, 434)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(149, 68)
        Me.insertar.TabIndex = 5
        Me.insertar.Text = "Insertar"
        Me.insertar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Location = New System.Drawing.Point(408, 434)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(149, 68)
        Me.cancelar.TabIndex = 6
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'labelexistencias
        '
        Me.labelexistencias.AutoSize = True
        Me.labelexistencias.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelexistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelexistencias.Location = New System.Drawing.Point(12, 267)
        Me.labelexistencias.Name = "labelexistencias"
        Me.labelexistencias.Size = New System.Drawing.Size(128, 25)
        Me.labelexistencias.TabIndex = 7
        Me.labelexistencias.Text = "Existencias:"
        '
        'labelestado
        '
        Me.labelestado.AutoSize = True
        Me.labelestado.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelestado.Location = New System.Drawing.Point(12, 315)
        Me.labelestado.Name = "labelestado"
        Me.labelestado.Size = New System.Drawing.Size(91, 25)
        Me.labelestado.TabIndex = 8
        Me.labelestado.Text = "Estado: "
        '
        'modificar
        '
        Me.modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(576, 360)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(149, 68)
        Me.modificar.TabIndex = 9
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'textboxnombre
        '
        Me.textboxnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxnombre.Location = New System.Drawing.Point(130, 58)
        Me.textboxnombre.Multiline = True
        Me.textboxnombre.Name = "textboxnombre"
        Me.textboxnombre.Size = New System.Drawing.Size(281, 37)
        Me.textboxnombre.TabIndex = 10
        '
        'textboxtipoingrediente
        '
        Me.textboxtipoingrediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxtipoingrediente.Location = New System.Drawing.Point(221, 101)
        Me.textboxtipoingrediente.Multiline = True
        Me.textboxtipoingrediente.Name = "textboxtipoingrediente"
        Me.textboxtipoingrediente.Size = New System.Drawing.Size(142, 37)
        Me.textboxtipoingrediente.TabIndex = 11
        '
        'textboxprecio
        '
        Me.textboxprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxprecio.Location = New System.Drawing.Point(115, 150)
        Me.textboxprecio.Multiline = True
        Me.textboxprecio.Name = "textboxprecio"
        Me.textboxprecio.Size = New System.Drawing.Size(142, 37)
        Me.textboxprecio.TabIndex = 12
        '
        'textboxcantidad
        '
        Me.textboxcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxcantidad.Location = New System.Drawing.Point(139, 208)
        Me.textboxcantidad.Multiline = True
        Me.textboxcantidad.Name = "textboxcantidad"
        Me.textboxcantidad.Size = New System.Drawing.Size(142, 37)
        Me.textboxcantidad.TabIndex = 13
        '
        'textboxexistencias
        '
        Me.textboxexistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxexistencias.Location = New System.Drawing.Point(146, 255)
        Me.textboxexistencias.Multiline = True
        Me.textboxexistencias.Name = "textboxexistencias"
        Me.textboxexistencias.Size = New System.Drawing.Size(142, 37)
        Me.textboxexistencias.TabIndex = 14
        '
        'radiobuttonalta
        '
        Me.radiobuttonalta.AutoSize = True
        Me.radiobuttonalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonalta.Location = New System.Drawing.Point(130, 312)
        Me.radiobuttonalta.Name = "radiobuttonalta"
        Me.radiobuttonalta.Size = New System.Drawing.Size(59, 28)
        Me.radiobuttonalta.TabIndex = 15
        Me.radiobuttonalta.TabStop = True
        Me.radiobuttonalta.Text = "Alta"
        Me.radiobuttonalta.UseVisualStyleBackColor = True
        '
        'radiobuttonbaja
        '
        Me.radiobuttonbaja.AutoSize = True
        Me.radiobuttonbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonbaja.Location = New System.Drawing.Point(222, 312)
        Me.radiobuttonbaja.Name = "radiobuttonbaja"
        Me.radiobuttonbaja.Size = New System.Drawing.Size(64, 28)
        Me.radiobuttonbaja.TabIndex = 16
        Me.radiobuttonbaja.TabStop = True
        Me.radiobuttonbaja.Text = "Baja"
        Me.radiobuttonbaja.UseVisualStyleBackColor = True
        '
        'labelclave
        '
        Me.labelclave.AutoSize = True
        Me.labelclave.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelclave.Location = New System.Drawing.Point(12, 19)
        Me.labelclave.Name = "labelclave"
        Me.labelclave.Size = New System.Drawing.Size(73, 25)
        Me.labelclave.TabIndex = 17
        Me.labelclave.Text = "Clave:"
        '
        'textboxclave
        '
        Me.textboxclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxclave.Location = New System.Drawing.Point(103, 7)
        Me.textboxclave.Multiline = True
        Me.textboxclave.Name = "textboxclave"
        Me.textboxclave.Size = New System.Drawing.Size(86, 37)
        Me.textboxclave.TabIndex = 18
        '
        'radiobuttonclave
        '
        Me.radiobuttonclave.AutoSize = True
        Me.radiobuttonclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonclave.Location = New System.Drawing.Point(469, 102)
        Me.radiobuttonclave.Name = "radiobuttonclave"
        Me.radiobuttonclave.Size = New System.Drawing.Size(108, 28)
        Me.radiobuttonclave.TabIndex = 19
        Me.radiobuttonclave.TabStop = True
        Me.radiobuttonclave.Text = "Id o clave"
        Me.radiobuttonclave.UseVisualStyleBackColor = True
        '
        'radiobuttonombre
        '
        Me.radiobuttonombre.AutoSize = True
        Me.radiobuttonombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonombre.Location = New System.Drawing.Point(598, 102)
        Me.radiobuttonombre.Name = "radiobuttonombre"
        Me.radiobuttonombre.Size = New System.Drawing.Size(97, 28)
        Me.radiobuttonombre.TabIndex = 20
        Me.radiobuttonombre.TabStop = True
        Me.radiobuttonombre.Text = "Nombre"
        Me.radiobuttonombre.UseVisualStyleBackColor = True
        '
        'labelbusqueda
        '
        Me.labelbusqueda.AutoSize = True
        Me.labelbusqueda.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbusqueda.Location = New System.Drawing.Point(508, 58)
        Me.labelbusqueda.Name = "labelbusqueda"
        Me.labelbusqueda.Size = New System.Drawing.Size(152, 25)
        Me.labelbusqueda.TabIndex = 21
        Me.labelbusqueda.Text = "Búsqueda por:"
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(501, 150)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(168, 49)
        Me.buscar.TabIndex = 22
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'Ingredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 523)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.labelbusqueda)
        Me.Controls.Add(Me.radiobuttonombre)
        Me.Controls.Add(Me.radiobuttonclave)
        Me.Controls.Add(Me.textboxclave)
        Me.Controls.Add(Me.labelclave)
        Me.Controls.Add(Me.radiobuttonbaja)
        Me.Controls.Add(Me.radiobuttonalta)
        Me.Controls.Add(Me.textboxexistencias)
        Me.Controls.Add(Me.textboxcantidad)
        Me.Controls.Add(Me.textboxprecio)
        Me.Controls.Add(Me.textboxtipoingrediente)
        Me.Controls.Add(Me.textboxnombre)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.labelestado)
        Me.Controls.Add(Me.labelexistencias)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.labelcantidad)
        Me.Controls.Add(Me.labelprecio)
        Me.Controls.Add(Me.labeltipoingrediente)
        Me.Controls.Add(Me.labelnombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Ingredientes"
        Me.Text = "Ingredientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelnombre As Label
    Friend WithEvents labeltipoingrediente As Label
    Friend WithEvents labelprecio As Label
    Friend WithEvents labelcantidad As Label
    Friend WithEvents insertar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents labelexistencias As Label
    Friend WithEvents labelestado As Label
    Friend WithEvents modificar As Button
    Friend WithEvents textboxnombre As TextBox
    Friend WithEvents textboxtipoingrediente As TextBox
    Friend WithEvents textboxprecio As TextBox
    Friend WithEvents textboxcantidad As TextBox
    Friend WithEvents textboxexistencias As TextBox
    Friend WithEvents radiobuttonalta As RadioButton
    Friend WithEvents radiobuttonbaja As RadioButton
    Friend WithEvents labelclave As Label
    Friend WithEvents textboxclave As TextBox
    Friend WithEvents radiobuttonclave As RadioButton
    Friend WithEvents radiobuttonombre As RadioButton
    Friend WithEvents labelbusqueda As Label
    Friend WithEvents buscar As Button
End Class
