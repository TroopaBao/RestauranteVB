<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosHechos
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
        Me.labelnombre = New System.Windows.Forms.Label()
        Me.labelprecio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelexistencias = New System.Windows.Forms.Label()
        Me.labelestado = New System.Windows.Forms.Label()
        Me.textboxnombre = New System.Windows.Forms.TextBox()
        Me.textboxprecio = New System.Windows.Forms.TextBox()
        Me.textboxexistencias = New System.Windows.Forms.TextBox()
        Me.radiobuttonalta = New System.Windows.Forms.RadioButton()
        Me.radiobuttonbaja = New System.Windows.Forms.RadioButton()
        Me.insertar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.textboxclave = New System.Windows.Forms.TextBox()
        Me.labelclave = New System.Windows.Forms.Label()
        Me.labelbusqueda = New System.Windows.Forms.Label()
        Me.radiobuttonclave = New System.Windows.Forms.RadioButton()
        Me.radiobuttonombre = New System.Windows.Forms.RadioButton()
        Me.buscar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelnombre
        '
        Me.labelnombre.AutoSize = True
        Me.labelnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnombre.Location = New System.Drawing.Point(12, 63)
        Me.labelnombre.Name = "labelnombre"
        Me.labelnombre.Size = New System.Drawing.Size(99, 25)
        Me.labelnombre.TabIndex = 1
        Me.labelnombre.Text = "Nombre: "
        '
        'labelprecio
        '
        Me.labelprecio.AutoSize = True
        Me.labelprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelprecio.Location = New System.Drawing.Point(12, 118)
        Me.labelprecio.Name = "labelprecio"
        Me.labelprecio.Size = New System.Drawing.Size(85, 25)
        Me.labelprecio.TabIndex = 2
        Me.labelprecio.Text = "Precio: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LaCrepizzeriaVB.My.Resources.Resources.productoshechos1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(759, 523)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'labelexistencias
        '
        Me.labelexistencias.AutoSize = True
        Me.labelexistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelexistencias.Location = New System.Drawing.Point(12, 169)
        Me.labelexistencias.Name = "labelexistencias"
        Me.labelexistencias.Size = New System.Drawing.Size(134, 25)
        Me.labelexistencias.TabIndex = 3
        Me.labelexistencias.Text = "Existencias: "
        '
        'labelestado
        '
        Me.labelestado.AutoSize = True
        Me.labelestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelestado.Location = New System.Drawing.Point(12, 224)
        Me.labelestado.Name = "labelestado"
        Me.labelestado.Size = New System.Drawing.Size(91, 25)
        Me.labelestado.TabIndex = 4
        Me.labelestado.Text = "Estado: "
        '
        'textboxnombre
        '
        Me.textboxnombre.Location = New System.Drawing.Point(135, 60)
        Me.textboxnombre.Multiline = True
        Me.textboxnombre.Name = "textboxnombre"
        Me.textboxnombre.Size = New System.Drawing.Size(215, 28)
        Me.textboxnombre.TabIndex = 5
        '
        'textboxprecio
        '
        Me.textboxprecio.Location = New System.Drawing.Point(123, 115)
        Me.textboxprecio.Multiline = True
        Me.textboxprecio.Name = "textboxprecio"
        Me.textboxprecio.Size = New System.Drawing.Size(107, 28)
        Me.textboxprecio.TabIndex = 6
        '
        'textboxexistencias
        '
        Me.textboxexistencias.Location = New System.Drawing.Point(162, 166)
        Me.textboxexistencias.Multiline = True
        Me.textboxexistencias.Name = "textboxexistencias"
        Me.textboxexistencias.Size = New System.Drawing.Size(107, 28)
        Me.textboxexistencias.TabIndex = 7
        '
        'radiobuttonalta
        '
        Me.radiobuttonalta.AutoSize = True
        Me.radiobuttonalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonalta.Location = New System.Drawing.Point(135, 220)
        Me.radiobuttonalta.Name = "radiobuttonalta"
        Me.radiobuttonalta.Size = New System.Drawing.Size(67, 29)
        Me.radiobuttonalta.TabIndex = 8
        Me.radiobuttonalta.TabStop = True
        Me.radiobuttonalta.Text = "Alta"
        Me.radiobuttonalta.UseVisualStyleBackColor = True
        '
        'radiobuttonbaja
        '
        Me.radiobuttonbaja.AutoSize = True
        Me.radiobuttonbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonbaja.Location = New System.Drawing.Point(229, 220)
        Me.radiobuttonbaja.Name = "radiobuttonbaja"
        Me.radiobuttonbaja.Size = New System.Drawing.Size(73, 29)
        Me.radiobuttonbaja.TabIndex = 9
        Me.radiobuttonbaja.TabStop = True
        Me.radiobuttonbaja.Text = "Baja"
        Me.radiobuttonbaja.UseVisualStyleBackColor = True
        '
        'insertar
        '
        Me.insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(567, 442)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(168, 69)
        Me.insertar.TabIndex = 10
        Me.insertar.Text = "Insertar"
        Me.insertar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Location = New System.Drawing.Point(380, 442)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(168, 69)
        Me.cancelar.TabIndex = 11
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'textboxclave
        '
        Me.textboxclave.Location = New System.Drawing.Point(106, 15)
        Me.textboxclave.Multiline = True
        Me.textboxclave.Name = "textboxclave"
        Me.textboxclave.Size = New System.Drawing.Size(107, 28)
        Me.textboxclave.TabIndex = 12
        '
        'labelclave
        '
        Me.labelclave.AutoSize = True
        Me.labelclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelclave.Location = New System.Drawing.Point(12, 15)
        Me.labelclave.Name = "labelclave"
        Me.labelclave.Size = New System.Drawing.Size(73, 25)
        Me.labelclave.TabIndex = 13
        Me.labelclave.Text = "Clave:"
        '
        'labelbusqueda
        '
        Me.labelbusqueda.AutoSize = True
        Me.labelbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbusqueda.Location = New System.Drawing.Point(530, 37)
        Me.labelbusqueda.Name = "labelbusqueda"
        Me.labelbusqueda.Size = New System.Drawing.Size(158, 25)
        Me.labelbusqueda.TabIndex = 14
        Me.labelbusqueda.Text = "Búsqueda por: "
        '
        'radiobuttonclave
        '
        Me.radiobuttonclave.AutoSize = True
        Me.radiobuttonclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonclave.Location = New System.Drawing.Point(472, 91)
        Me.radiobuttonclave.Name = "radiobuttonclave"
        Me.radiobuttonclave.Size = New System.Drawing.Size(126, 29)
        Me.radiobuttonclave.TabIndex = 15
        Me.radiobuttonclave.TabStop = True
        Me.radiobuttonclave.Text = "Id o Clave"
        Me.radiobuttonclave.UseVisualStyleBackColor = True
        '
        'radiobuttonombre
        '
        Me.radiobuttonombre.AutoSize = True
        Me.radiobuttonombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonombre.Location = New System.Drawing.Point(630, 91)
        Me.radiobuttonombre.Name = "radiobuttonombre"
        Me.radiobuttonombre.Size = New System.Drawing.Size(105, 29)
        Me.radiobuttonombre.TabIndex = 16
        Me.radiobuttonombre.TabStop = True
        Me.radiobuttonombre.Text = "Nombre"
        Me.radiobuttonombre.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(535, 146)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(153, 48)
        Me.buscar.TabIndex = 17
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(567, 357)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(168, 69)
        Me.modificar.TabIndex = 18
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'ProductosHechos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 523)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.radiobuttonombre)
        Me.Controls.Add(Me.radiobuttonclave)
        Me.Controls.Add(Me.labelbusqueda)
        Me.Controls.Add(Me.labelclave)
        Me.Controls.Add(Me.textboxclave)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.radiobuttonbaja)
        Me.Controls.Add(Me.radiobuttonalta)
        Me.Controls.Add(Me.textboxexistencias)
        Me.Controls.Add(Me.textboxprecio)
        Me.Controls.Add(Me.textboxnombre)
        Me.Controls.Add(Me.labelestado)
        Me.Controls.Add(Me.labelexistencias)
        Me.Controls.Add(Me.labelprecio)
        Me.Controls.Add(Me.labelnombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProductosHechos"
        Me.Text = "ProductosHechos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelnombre As Label
    Friend WithEvents labelprecio As Label
    Friend WithEvents labelexistencias As Label
    Friend WithEvents labelestado As Label
    Friend WithEvents textboxnombre As TextBox
    Friend WithEvents textboxprecio As TextBox
    Friend WithEvents textboxexistencias As TextBox
    Friend WithEvents radiobuttonalta As RadioButton
    Friend WithEvents radiobuttonbaja As RadioButton
    Friend WithEvents insertar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents textboxclave As TextBox
    Friend WithEvents labelclave As Label
    Friend WithEvents labelbusqueda As Label
    Friend WithEvents radiobuttonclave As RadioButton
    Friend WithEvents radiobuttonombre As RadioButton
    Friend WithEvents buscar As Button
    Friend WithEvents modificar As Button
End Class
