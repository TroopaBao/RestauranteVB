<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Me.textboxnombre = New System.Windows.Forms.TextBox()
        Me.textboxcargo = New System.Windows.Forms.TextBox()
        Me.textboxcontra = New System.Windows.Forms.TextBox()
        Me.Labelnombre = New System.Windows.Forms.Label()
        Me.Labelcargo = New System.Windows.Forms.Label()
        Me.Labelcontra = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Labelclave = New System.Windows.Forms.Label()
        Me.textboxid = New System.Windows.Forms.TextBox()
        Me.RadioButtonid = New System.Windows.Forms.RadioButton()
        Me.RadioButtonnombre = New System.Windows.Forms.RadioButton()
        Me.Labelbusqueda = New System.Windows.Forms.Label()
        Me.labelsaldo = New System.Windows.Forms.Label()
        Me.textboxcaja = New System.Windows.Forms.TextBox()
        Me.labelestado = New System.Windows.Forms.Label()
        Me.radiobuttonalta = New System.Windows.Forms.RadioButton()
        Me.radiobuttonbaja = New System.Windows.Forms.RadioButton()
        Me.buscar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LaCrepizzeriaVB.My.Resources.Resources.empleados
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(654, 491)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'textboxnombre
        '
        Me.textboxnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxnombre.Location = New System.Drawing.Point(153, 67)
        Me.textboxnombre.Multiline = True
        Me.textboxnombre.Name = "textboxnombre"
        Me.textboxnombre.Size = New System.Drawing.Size(211, 33)
        Me.textboxnombre.TabIndex = 1
        '
        'textboxcargo
        '
        Me.textboxcargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxcargo.Location = New System.Drawing.Point(153, 130)
        Me.textboxcargo.Multiline = True
        Me.textboxcargo.Name = "textboxcargo"
        Me.textboxcargo.Size = New System.Drawing.Size(211, 33)
        Me.textboxcargo.TabIndex = 2
        '
        'textboxcontra
        '
        Me.textboxcontra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxcontra.Location = New System.Drawing.Point(153, 191)
        Me.textboxcontra.Multiline = True
        Me.textboxcontra.Name = "textboxcontra"
        Me.textboxcontra.Size = New System.Drawing.Size(211, 35)
        Me.textboxcontra.TabIndex = 3
        '
        'Labelnombre
        '
        Me.Labelnombre.AutoSize = True
        Me.Labelnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnombre.Location = New System.Drawing.Point(12, 69)
        Me.Labelnombre.Name = "Labelnombre"
        Me.Labelnombre.Size = New System.Drawing.Size(99, 25)
        Me.Labelnombre.TabIndex = 4
        Me.Labelnombre.Text = "Nombre: "
        '
        'Labelcargo
        '
        Me.Labelcargo.AutoSize = True
        Me.Labelcargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcargo.Location = New System.Drawing.Point(12, 132)
        Me.Labelcargo.Name = "Labelcargo"
        Me.Labelcargo.Size = New System.Drawing.Size(82, 25)
        Me.Labelcargo.TabIndex = 5
        Me.Labelcargo.Text = "Cargo: "
        '
        'Labelcontra
        '
        Me.Labelcontra.AutoSize = True
        Me.Labelcontra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcontra.Location = New System.Drawing.Point(12, 193)
        Me.Labelcontra.Name = "Labelcontra"
        Me.Labelcontra.Size = New System.Drawing.Size(129, 25)
        Me.Labelcontra.TabIndex = 6
        Me.Labelcontra.Text = "Contraseña:"
        '
        'insertar
        '
        Me.insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(507, 390)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(126, 77)
        Me.insertar.TabIndex = 7
        Me.insertar.Text = "Insertar"
        Me.insertar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Location = New System.Drawing.Point(360, 390)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(126, 77)
        Me.cancelar.TabIndex = 8
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'Labelclave
        '
        Me.Labelclave.AutoSize = True
        Me.Labelclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelclave.Location = New System.Drawing.Point(12, 28)
        Me.Labelclave.Name = "Labelclave"
        Me.Labelclave.Size = New System.Drawing.Size(79, 25)
        Me.Labelclave.TabIndex = 9
        Me.Labelclave.Text = "Clave: "
        '
        'textboxid
        '
        Me.textboxid.Location = New System.Drawing.Point(153, 28)
        Me.textboxid.Multiline = True
        Me.textboxid.Name = "textboxid"
        Me.textboxid.Size = New System.Drawing.Size(65, 33)
        Me.textboxid.TabIndex = 10
        '
        'RadioButtonid
        '
        Me.RadioButtonid.AutoSize = True
        Me.RadioButtonid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonid.Location = New System.Drawing.Point(417, 112)
        Me.RadioButtonid.Name = "RadioButtonid"
        Me.RadioButtonid.Size = New System.Drawing.Size(91, 22)
        Me.RadioButtonid.TabIndex = 11
        Me.RadioButtonid.TabStop = True
        Me.RadioButtonid.Text = "Id o Clave"
        Me.RadioButtonid.UseVisualStyleBackColor = True
        '
        'RadioButtonnombre
        '
        Me.RadioButtonnombre.AutoSize = True
        Me.RadioButtonnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonnombre.Location = New System.Drawing.Point(539, 112)
        Me.RadioButtonnombre.Name = "RadioButtonnombre"
        Me.RadioButtonnombre.Size = New System.Drawing.Size(80, 22)
        Me.RadioButtonnombre.TabIndex = 12
        Me.RadioButtonnombre.TabStop = True
        Me.RadioButtonnombre.Text = "Nombre"
        Me.RadioButtonnombre.UseVisualStyleBackColor = True
        '
        'Labelbusqueda
        '
        Me.Labelbusqueda.AutoSize = True
        Me.Labelbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbusqueda.Location = New System.Drawing.Point(474, 67)
        Me.Labelbusqueda.Name = "Labelbusqueda"
        Me.Labelbusqueda.Size = New System.Drawing.Size(114, 20)
        Me.Labelbusqueda.TabIndex = 13
        Me.Labelbusqueda.Text = "Búsqueda Por:"
        '
        'labelsaldo
        '
        Me.labelsaldo.AutoSize = True
        Me.labelsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelsaldo.Location = New System.Drawing.Point(15, 252)
        Me.labelsaldo.Name = "labelsaldo"
        Me.labelsaldo.Size = New System.Drawing.Size(79, 25)
        Me.labelsaldo.TabIndex = 14
        Me.labelsaldo.Text = "Saldo: "
        '
        'textboxcaja
        '
        Me.textboxcaja.Location = New System.Drawing.Point(153, 244)
        Me.textboxcaja.Multiline = True
        Me.textboxcaja.Name = "textboxcaja"
        Me.textboxcaja.Size = New System.Drawing.Size(128, 33)
        Me.textboxcaja.TabIndex = 15
        '
        'labelestado
        '
        Me.labelestado.AutoSize = True
        Me.labelestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelestado.Location = New System.Drawing.Point(17, 306)
        Me.labelestado.Name = "labelestado"
        Me.labelestado.Size = New System.Drawing.Size(91, 25)
        Me.labelestado.TabIndex = 16
        Me.labelestado.Text = "Estado: "
        '
        'radiobuttonalta
        '
        Me.radiobuttonalta.AutoSize = True
        Me.radiobuttonalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonalta.Location = New System.Drawing.Point(140, 302)
        Me.radiobuttonalta.Name = "radiobuttonalta"
        Me.radiobuttonalta.Size = New System.Drawing.Size(67, 29)
        Me.radiobuttonalta.TabIndex = 17
        Me.radiobuttonalta.TabStop = True
        Me.radiobuttonalta.Text = "Alta"
        Me.radiobuttonalta.UseVisualStyleBackColor = True
        '
        'radiobuttonbaja
        '
        Me.radiobuttonbaja.AutoSize = True
        Me.radiobuttonbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonbaja.Location = New System.Drawing.Point(232, 302)
        Me.radiobuttonbaja.Name = "radiobuttonbaja"
        Me.radiobuttonbaja.Size = New System.Drawing.Size(73, 29)
        Me.radiobuttonbaja.TabIndex = 18
        Me.radiobuttonbaja.TabStop = True
        Me.radiobuttonbaja.Text = "Baja"
        Me.radiobuttonbaja.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(447, 150)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(141, 46)
        Me.buscar.TabIndex = 19
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(507, 306)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(126, 77)
        Me.modificar.TabIndex = 20
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 491)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.radiobuttonbaja)
        Me.Controls.Add(Me.radiobuttonalta)
        Me.Controls.Add(Me.labelestado)
        Me.Controls.Add(Me.textboxcaja)
        Me.Controls.Add(Me.labelsaldo)
        Me.Controls.Add(Me.Labelbusqueda)
        Me.Controls.Add(Me.RadioButtonnombre)
        Me.Controls.Add(Me.RadioButtonid)
        Me.Controls.Add(Me.textboxid)
        Me.Controls.Add(Me.Labelclave)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.Labelcontra)
        Me.Controls.Add(Me.Labelcargo)
        Me.Controls.Add(Me.Labelnombre)
        Me.Controls.Add(Me.textboxcontra)
        Me.Controls.Add(Me.textboxcargo)
        Me.Controls.Add(Me.textboxnombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Empleado"
        Me.Text = "Empleados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textboxnombre As TextBox
    Friend WithEvents textboxcargo As TextBox
    Friend WithEvents textboxcontra As TextBox
    Friend WithEvents Labelnombre As Label
    Friend WithEvents Labelcargo As Label
    Friend WithEvents Labelcontra As Label
    Friend WithEvents insertar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents Labelclave As Label
    Friend WithEvents textboxid As TextBox
    Friend WithEvents RadioButtonid As RadioButton
    Friend WithEvents RadioButtonnombre As RadioButton
    Friend WithEvents Labelbusqueda As Label
    Friend WithEvents labelsaldo As Label
    Friend WithEvents textboxcaja As TextBox
    Friend WithEvents labelestado As Label
    Friend WithEvents radiobuttonalta As RadioButton
    Friend WithEvents radiobuttonbaja As RadioButton
    Friend WithEvents buscar As Button
    Friend WithEvents modificar As Button
End Class
