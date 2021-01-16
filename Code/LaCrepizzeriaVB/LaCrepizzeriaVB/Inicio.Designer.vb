<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.insertarempleado = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.insertarcompra = New System.Windows.Forms.Button()
        Me.insertaringrediente = New System.Windows.Forms.Button()
        Me.insertarprodhech = New System.Windows.Forms.Button()
        Me.insertarprodproc = New System.Windows.Forms.Button()
        Me.insertarventa = New System.Windows.Forms.Button()
        Me.modificarempleado = New System.Windows.Forms.Button()
        Me.modificarcompra = New System.Windows.Forms.Button()
        Me.modificaringrediente = New System.Windows.Forms.Button()
        Me.modificarprodhech = New System.Windows.Forms.Button()
        Me.modificarprodproc = New System.Windows.Forms.Button()
        Me.modificarventa = New System.Windows.Forms.Button()
        Me.eliminarempleado = New System.Windows.Forms.Button()
        Me.eliminarcompra = New System.Windows.Forms.Button()
        Me.eliminaringrediente = New System.Windows.Forms.Button()
        Me.eliminarprodhech = New System.Windows.Forms.Button()
        Me.eliminarprodproc = New System.Windows.Forms.Button()
        Me.eliminarventa = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'insertarempleado
        '
        Me.insertarempleado.Location = New System.Drawing.Point(153, 58)
        Me.insertarempleado.Name = "insertarempleado"
        Me.insertarempleado.Size = New System.Drawing.Size(128, 32)
        Me.insertarempleado.TabIndex = 0
        Me.insertarempleado.Text = "Insertar"
        Me.insertarempleado.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 58)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 32)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Empleados"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(13, 119)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(117, 32)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "Compras"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(13, 179)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(117, 32)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "Ingredientes"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(13, 229)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(117, 53)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Text = "Productos Hechos"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(13, 288)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(117, 50)
        Me.TextBox5.TabIndex = 6
        Me.TextBox5.Text = "Productos Procesados"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(13, 353)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(117, 32)
        Me.TextBox6.TabIndex = 7
        Me.TextBox6.Text = "Ventas"
        '
        'insertarcompra
        '
        Me.insertarcompra.Location = New System.Drawing.Point(153, 117)
        Me.insertarcompra.Name = "insertarcompra"
        Me.insertarcompra.Size = New System.Drawing.Size(128, 32)
        Me.insertarcompra.TabIndex = 8
        Me.insertarcompra.Text = "Insertar"
        Me.insertarcompra.UseVisualStyleBackColor = True
        '
        'insertaringrediente
        '
        Me.insertaringrediente.Location = New System.Drawing.Point(153, 179)
        Me.insertaringrediente.Name = "insertaringrediente"
        Me.insertaringrediente.Size = New System.Drawing.Size(128, 32)
        Me.insertaringrediente.TabIndex = 9
        Me.insertaringrediente.Text = "Insertar"
        Me.insertaringrediente.UseVisualStyleBackColor = True
        '
        'insertarprodhech
        '
        Me.insertarprodhech.Location = New System.Drawing.Point(153, 238)
        Me.insertarprodhech.Name = "insertarprodhech"
        Me.insertarprodhech.Size = New System.Drawing.Size(128, 32)
        Me.insertarprodhech.TabIndex = 10
        Me.insertarprodhech.Text = "Insertar"
        Me.insertarprodhech.UseVisualStyleBackColor = True
        '
        'insertarprodproc
        '
        Me.insertarprodproc.Location = New System.Drawing.Point(153, 297)
        Me.insertarprodproc.Name = "insertarprodproc"
        Me.insertarprodproc.Size = New System.Drawing.Size(128, 32)
        Me.insertarprodproc.TabIndex = 11
        Me.insertarprodproc.Text = "Insertar"
        Me.insertarprodproc.UseVisualStyleBackColor = True
        '
        'insertarventa
        '
        Me.insertarventa.Location = New System.Drawing.Point(153, 353)
        Me.insertarventa.Name = "insertarventa"
        Me.insertarventa.Size = New System.Drawing.Size(128, 32)
        Me.insertarventa.TabIndex = 12
        Me.insertarventa.Text = "Insertar"
        Me.insertarventa.UseVisualStyleBackColor = True
        '
        'modificarempleado
        '
        Me.modificarempleado.Location = New System.Drawing.Point(301, 58)
        Me.modificarempleado.Name = "modificarempleado"
        Me.modificarempleado.Size = New System.Drawing.Size(128, 32)
        Me.modificarempleado.TabIndex = 13
        Me.modificarempleado.Text = "Modificar"
        Me.modificarempleado.UseVisualStyleBackColor = True
        '
        'modificarcompra
        '
        Me.modificarcompra.Location = New System.Drawing.Point(301, 117)
        Me.modificarcompra.Name = "modificarcompra"
        Me.modificarcompra.Size = New System.Drawing.Size(128, 32)
        Me.modificarcompra.TabIndex = 14
        Me.modificarcompra.Text = "Modificar"
        Me.modificarcompra.UseVisualStyleBackColor = True
        '
        'modificaringrediente
        '
        Me.modificaringrediente.Location = New System.Drawing.Point(301, 177)
        Me.modificaringrediente.Name = "modificaringrediente"
        Me.modificaringrediente.Size = New System.Drawing.Size(128, 32)
        Me.modificaringrediente.TabIndex = 15
        Me.modificaringrediente.Text = "Modificar"
        Me.modificaringrediente.UseVisualStyleBackColor = True
        '
        'modificarprodhech
        '
        Me.modificarprodhech.Location = New System.Drawing.Point(301, 238)
        Me.modificarprodhech.Name = "modificarprodhech"
        Me.modificarprodhech.Size = New System.Drawing.Size(128, 32)
        Me.modificarprodhech.TabIndex = 16
        Me.modificarprodhech.Text = "Modificar"
        Me.modificarprodhech.UseVisualStyleBackColor = True
        '
        'modificarprodproc
        '
        Me.modificarprodproc.Location = New System.Drawing.Point(301, 297)
        Me.modificarprodproc.Name = "modificarprodproc"
        Me.modificarprodproc.Size = New System.Drawing.Size(128, 32)
        Me.modificarprodproc.TabIndex = 17
        Me.modificarprodproc.Text = "Modificar"
        Me.modificarprodproc.UseVisualStyleBackColor = True
        '
        'modificarventa
        '
        Me.modificarventa.Location = New System.Drawing.Point(301, 351)
        Me.modificarventa.Name = "modificarventa"
        Me.modificarventa.Size = New System.Drawing.Size(128, 32)
        Me.modificarventa.TabIndex = 18
        Me.modificarventa.Text = "Modificar"
        Me.modificarventa.UseVisualStyleBackColor = True
        '
        'eliminarempleado
        '
        Me.eliminarempleado.Location = New System.Drawing.Point(446, 58)
        Me.eliminarempleado.Name = "eliminarempleado"
        Me.eliminarempleado.Size = New System.Drawing.Size(128, 32)
        Me.eliminarempleado.TabIndex = 19
        Me.eliminarempleado.Text = "Eliminar"
        Me.eliminarempleado.UseVisualStyleBackColor = True
        '
        'eliminarcompra
        '
        Me.eliminarcompra.Location = New System.Drawing.Point(446, 117)
        Me.eliminarcompra.Name = "eliminarcompra"
        Me.eliminarcompra.Size = New System.Drawing.Size(128, 32)
        Me.eliminarcompra.TabIndex = 20
        Me.eliminarcompra.Text = "Eliminar"
        Me.eliminarcompra.UseVisualStyleBackColor = True
        '
        'eliminaringrediente
        '
        Me.eliminaringrediente.Location = New System.Drawing.Point(446, 177)
        Me.eliminaringrediente.Name = "eliminaringrediente"
        Me.eliminaringrediente.Size = New System.Drawing.Size(128, 32)
        Me.eliminaringrediente.TabIndex = 21
        Me.eliminaringrediente.Text = "Eliminar"
        Me.eliminaringrediente.UseVisualStyleBackColor = True
        '
        'eliminarprodhech
        '
        Me.eliminarprodhech.Location = New System.Drawing.Point(446, 238)
        Me.eliminarprodhech.Name = "eliminarprodhech"
        Me.eliminarprodhech.Size = New System.Drawing.Size(128, 32)
        Me.eliminarprodhech.TabIndex = 22
        Me.eliminarprodhech.Text = "Eliminar"
        Me.eliminarprodhech.UseVisualStyleBackColor = True
        '
        'eliminarprodproc
        '
        Me.eliminarprodproc.Location = New System.Drawing.Point(446, 297)
        Me.eliminarprodproc.Name = "eliminarprodproc"
        Me.eliminarprodproc.Size = New System.Drawing.Size(128, 32)
        Me.eliminarprodproc.TabIndex = 23
        Me.eliminarprodproc.Text = "Eliminar"
        Me.eliminarprodproc.UseVisualStyleBackColor = True
        '
        'eliminarventa
        '
        Me.eliminarventa.Location = New System.Drawing.Point(446, 351)
        Me.eliminarventa.Name = "eliminarventa"
        Me.eliminarventa.Size = New System.Drawing.Size(128, 32)
        Me.eliminarventa.TabIndex = 24
        Me.eliminarventa.Text = "Eliminar"
        Me.eliminarventa.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.Location = New System.Drawing.Point(514, 426)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(172, 43)
        Me.salir.TabIndex = 26
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(141, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 43)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LaCrepizzeriaVB.My.Resources.Resources.pizza1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(715, 481)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 481)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.eliminarventa)
        Me.Controls.Add(Me.eliminarprodproc)
        Me.Controls.Add(Me.eliminarprodhech)
        Me.Controls.Add(Me.eliminaringrediente)
        Me.Controls.Add(Me.eliminarcompra)
        Me.Controls.Add(Me.eliminarempleado)
        Me.Controls.Add(Me.modificarventa)
        Me.Controls.Add(Me.modificarprodproc)
        Me.Controls.Add(Me.modificarprodhech)
        Me.Controls.Add(Me.modificaringrediente)
        Me.Controls.Add(Me.modificarcompra)
        Me.Controls.Add(Me.modificarempleado)
        Me.Controls.Add(Me.insertarventa)
        Me.Controls.Add(Me.insertarprodproc)
        Me.Controls.Add(Me.insertarprodhech)
        Me.Controls.Add(Me.insertaringrediente)
        Me.Controls.Add(Me.insertarcompra)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.insertarempleado)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents insertarempleado As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents insertarcompra As Button
    Friend WithEvents insertaringrediente As Button
    Friend WithEvents insertarprodhech As Button
    Friend WithEvents insertarprodproc As Button
    Friend WithEvents insertarventa As Button
    Friend WithEvents modificarempleado As Button
    Friend WithEvents modificarcompra As Button
    Friend WithEvents modificaringrediente As Button
    Friend WithEvents modificarprodhech As Button
    Friend WithEvents modificarprodproc As Button
    Friend WithEvents modificarventa As Button
    Friend WithEvents eliminarempleado As Button
    Friend WithEvents eliminarcompra As Button
    Friend WithEvents eliminaringrediente As Button
    Friend WithEvents eliminarprodhech As Button
    Friend WithEvents eliminarprodproc As Button
    Friend WithEvents eliminarventa As Button
    Friend WithEvents salir As Button
    Friend WithEvents Button1 As Button
End Class
