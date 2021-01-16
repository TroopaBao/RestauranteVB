<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nombreproducto = New System.Windows.Forms.Label()
        Me.detallespedido = New System.Windows.Forms.TextBox()
        Me.cantidadpedido = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LaCrepizzeriaVB.My.Resources.Resources.crepas2
        Me.PictureBox1.Location = New System.Drawing.Point(119, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'nombreproducto
        '
        Me.nombreproducto.AutoSize = True
        Me.nombreproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreproducto.Location = New System.Drawing.Point(113, 238)
        Me.nombreproducto.Name = "nombreproducto"
        Me.nombreproducto.Size = New System.Drawing.Size(216, 31)
        Me.nombreproducto.TabIndex = 1
        Me.nombreproducto.Text = "Crepa de Fresas"
        '
        'detallespedido
        '
        Me.detallespedido.Location = New System.Drawing.Point(119, 281)
        Me.detallespedido.Multiline = True
        Me.detallespedido.Name = "detallespedido"
        Me.detallespedido.Size = New System.Drawing.Size(226, 106)
        Me.detallespedido.TabIndex = 3
        '
        'cantidadpedido
        '
        Me.cantidadpedido.AutoSize = True
        Me.cantidadpedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidadpedido.Location = New System.Drawing.Point(146, 404)
        Me.cantidadpedido.Name = "cantidadpedido"
        Me.cantidadpedido.Size = New System.Drawing.Size(134, 29)
        Me.cantidadpedido.TabIndex = 4
        Me.cantidadpedido.Text = "Cantidad: 1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(410, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 58)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "→"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(13, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 58)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "← "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cantidadpedido)
        Me.Controls.Add(Me.detallespedido)
        Me.Controls.Add(Me.nombreproducto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nombreproducto As Label
    Friend WithEvents detallespedido As TextBox
    Friend WithEvents cantidadpedido As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
