<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesaPlantaAlta
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
        Me.btn1a = New System.Windows.Forms.Button()
        Me.btn2a = New System.Windows.Forms.Button()
        Me.btn3a = New System.Windows.Forms.Button()
        Me.btnper1 = New System.Windows.Forms.Button()
        Me.btnper2 = New System.Windows.Forms.Button()
        Me.btn1b = New System.Windows.Forms.Button()
        Me.btn2b = New System.Windows.Forms.Button()
        Me.btnplantabaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1a
        '
        Me.btn1a.Location = New System.Drawing.Point(326, 39)
        Me.btn1a.Name = "btn1a"
        Me.btn1a.Size = New System.Drawing.Size(71, 68)
        Me.btn1a.TabIndex = 0
        Me.btn1a.Text = "Mesa 1A"
        Me.btn1a.UseVisualStyleBackColor = True
        '
        'btn2a
        '
        Me.btn2a.Location = New System.Drawing.Point(190, 39)
        Me.btn2a.Name = "btn2a"
        Me.btn2a.Size = New System.Drawing.Size(75, 68)
        Me.btn2a.TabIndex = 1
        Me.btn2a.Text = "Mesa 2A"
        Me.btn2a.UseVisualStyleBackColor = True
        '
        'btn3a
        '
        Me.btn3a.Location = New System.Drawing.Point(65, 39)
        Me.btn3a.Name = "btn3a"
        Me.btn3a.Size = New System.Drawing.Size(75, 68)
        Me.btn3a.TabIndex = 2
        Me.btn3a.Text = "Mesa 3A"
        Me.btn3a.UseVisualStyleBackColor = True
        '
        'btnper1
        '
        Me.btnper1.Location = New System.Drawing.Point(326, 184)
        Me.btnper1.Name = "btnper1"
        Me.btnper1.Size = New System.Drawing.Size(75, 66)
        Me.btnper1.TabIndex = 3
        Me.btnper1.Text = "Periquera 1"
        Me.btnper1.UseVisualStyleBackColor = True
        '
        'btnper2
        '
        Me.btnper2.Location = New System.Drawing.Point(326, 315)
        Me.btnper2.Name = "btnper2"
        Me.btnper2.Size = New System.Drawing.Size(75, 72)
        Me.btnper2.TabIndex = 4
        Me.btnper2.Text = "Periquera 2"
        Me.btnper2.UseVisualStyleBackColor = True
        '
        'btn1b
        '
        Me.btn1b.Location = New System.Drawing.Point(190, 222)
        Me.btn1b.Name = "btn1b"
        Me.btn1b.Size = New System.Drawing.Size(75, 66)
        Me.btn1b.TabIndex = 5
        Me.btn1b.Text = "Mesa 1B"
        Me.btn1b.UseVisualStyleBackColor = True
        '
        'btn2b
        '
        Me.btn2b.Location = New System.Drawing.Point(190, 329)
        Me.btn2b.Name = "btn2b"
        Me.btn2b.Size = New System.Drawing.Size(75, 75)
        Me.btn2b.TabIndex = 6
        Me.btn2b.Text = "Mesa 2B"
        Me.btn2b.UseVisualStyleBackColor = True
        '
        'btnplantabaja
        '
        Me.btnplantabaja.Location = New System.Drawing.Point(53, 293)
        Me.btnplantabaja.Name = "btnplantabaja"
        Me.btnplantabaja.Size = New System.Drawing.Size(75, 94)
        Me.btnplantabaja.TabIndex = 7
        Me.btnplantabaja.Text = "Planta Baja"
        Me.btnplantabaja.UseVisualStyleBackColor = True
        '
        'MesaPlantaAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.btnplantabaja)
        Me.Controls.Add(Me.btn2b)
        Me.Controls.Add(Me.btn1b)
        Me.Controls.Add(Me.btnper2)
        Me.Controls.Add(Me.btnper1)
        Me.Controls.Add(Me.btn3a)
        Me.Controls.Add(Me.btn2a)
        Me.Controls.Add(Me.btn1a)
        Me.Name = "MesaPlantaAlta"
        Me.Text = "MesaPlantaAlta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1a As Button
    Friend WithEvents btn2a As Button
    Friend WithEvents btn3a As Button
    Friend WithEvents btnper1 As Button
    Friend WithEvents btnper2 As Button
    Friend WithEvents btn1b As Button
    Friend WithEvents btn2b As Button
    Friend WithEvents btnplantabaja As Button
End Class
