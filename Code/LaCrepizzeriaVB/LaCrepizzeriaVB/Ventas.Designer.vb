<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.labelclave = New System.Windows.Forms.Label()
        Me.labelventa = New System.Windows.Forms.Label()
        Me.fechaventa = New System.Windows.Forms.DateTimePicker()
        Me.nombremesa = New System.Windows.Forms.Label()
        Me.textboxnombremesa = New System.Windows.Forms.TextBox()
        Me.textboxclave = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.buscar = New System.Windows.Forms.Button()
        Me.agregar = New System.Windows.Forms.Button()
        Me.quitar = New System.Windows.Forms.Button()
        Me.labeltotal = New System.Windows.Forms.Label()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LaCrepizzeriaVB.My.Resources.Resources.ventas1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(771, 550)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'labelclave
        '
        Me.labelclave.AutoSize = True
        Me.labelclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelclave.Location = New System.Drawing.Point(486, 35)
        Me.labelclave.Name = "labelclave"
        Me.labelclave.Size = New System.Drawing.Size(107, 25)
        Me.labelclave.TabIndex = 1
        Me.labelclave.Text = "Venta No."
        '
        'labelventa
        '
        Me.labelventa.AutoSize = True
        Me.labelventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelventa.Location = New System.Drawing.Point(12, 35)
        Me.labelventa.Name = "labelventa"
        Me.labelventa.Size = New System.Drawing.Size(170, 25)
        Me.labelventa.TabIndex = 2
        Me.labelventa.Text = "Fecha de Venta:"
        '
        'fechaventa
        '
        Me.fechaventa.Location = New System.Drawing.Point(203, 40)
        Me.fechaventa.Name = "fechaventa"
        Me.fechaventa.Size = New System.Drawing.Size(200, 20)
        Me.fechaventa.TabIndex = 3
        '
        'nombremesa
        '
        Me.nombremesa.AutoSize = True
        Me.nombremesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombremesa.Location = New System.Drawing.Point(12, 88)
        Me.nombremesa.Name = "nombremesa"
        Me.nombremesa.Size = New System.Drawing.Size(188, 25)
        Me.nombremesa.TabIndex = 4
        Me.nombremesa.Text = "Nombre de Mesa: "
        '
        'textboxnombremesa
        '
        Me.textboxnombremesa.Location = New System.Drawing.Point(217, 80)
        Me.textboxnombremesa.Multiline = True
        Me.textboxnombremesa.Name = "textboxnombremesa"
        Me.textboxnombremesa.Size = New System.Drawing.Size(236, 33)
        Me.textboxnombremesa.TabIndex = 5
        '
        'textboxclave
        '
        Me.textboxclave.Location = New System.Drawing.Point(599, 27)
        Me.textboxclave.Multiline = True
        Me.textboxclave.Name = "textboxclave"
        Me.textboxclave.Size = New System.Drawing.Size(115, 33)
        Me.textboxclave.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(677, 247)
        Me.DataGridView1.TabIndex = 7
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(599, 72)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(115, 41)
        Me.buscar.TabIndex = 8
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'agregar
        '
        Me.agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.Location = New System.Drawing.Point(571, 397)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(143, 40)
        Me.agregar.TabIndex = 9
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'quitar
        '
        Me.quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitar.Location = New System.Drawing.Point(422, 397)
        Me.quitar.Name = "quitar"
        Me.quitar.Size = New System.Drawing.Size(143, 40)
        Me.quitar.TabIndex = 10
        Me.quitar.Text = "Quitar"
        Me.quitar.UseVisualStyleBackColor = True
        '
        'labeltotal
        '
        Me.labeltotal.AutoSize = True
        Me.labeltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotal.Location = New System.Drawing.Point(42, 394)
        Me.labeltotal.Name = "labeltotal"
        Me.labeltotal.Size = New System.Drawing.Size(199, 39)
        Me.labeltotal.TabIndex = 11
        Me.labeltotal.Text = "Total: $0.00"
        '
        'aceptar
        '
        Me.aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.Location = New System.Drawing.Point(571, 483)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(178, 55)
        Me.aceptar.TabIndex = 12
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Location = New System.Drawing.Point(387, 483)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(178, 55)
        Me.cancelar.TabIndex = 13
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 550)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.labeltotal)
        Me.Controls.Add(Me.quitar)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.textboxclave)
        Me.Controls.Add(Me.textboxnombremesa)
        Me.Controls.Add(Me.nombremesa)
        Me.Controls.Add(Me.fechaventa)
        Me.Controls.Add(Me.labelventa)
        Me.Controls.Add(Me.labelclave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelclave As Label
    Friend WithEvents labelventa As Label
    Friend WithEvents fechaventa As DateTimePicker
    Friend WithEvents nombremesa As Label
    Friend WithEvents textboxnombremesa As TextBox
    Friend WithEvents textboxclave As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents buscar As Button
    Friend WithEvents agregar As Button
    Friend WithEvents quitar As Button
    Friend WithEvents labeltotal As Label
    Friend WithEvents aceptar As Button
    Friend WithEvents cancelar As Button
End Class
