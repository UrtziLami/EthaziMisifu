<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KudeaketaLeihoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KudeaketaLeihoa))
        Me.btnAlojamendu = New System.Windows.Forms.Button()
        Me.btnErabiltzaile = New System.Windows.Forms.Button()
        Me.btnErreserba = New System.Windows.Forms.Button()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAlojamendu
        '
        Me.btnAlojamendu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.casa
        Me.btnAlojamendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAlojamendu.Location = New System.Drawing.Point(261, 53)
        Me.btnAlojamendu.Name = "btnAlojamendu"
        Me.btnAlojamendu.Size = New System.Drawing.Size(496, 93)
        Me.btnAlojamendu.TabIndex = 1
        Me.btnAlojamendu.UseVisualStyleBackColor = True
        '
        'btnErabiltzaile
        '
        Me.btnErabiltzaile.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.icono_persona1
        Me.btnErabiltzaile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnErabiltzaile.Location = New System.Drawing.Point(261, 213)
        Me.btnErabiltzaile.Name = "btnErabiltzaile"
        Me.btnErabiltzaile.Size = New System.Drawing.Size(496, 97)
        Me.btnErabiltzaile.TabIndex = 2
        Me.btnErabiltzaile.UseVisualStyleBackColor = True
        '
        'btnErreserba
        '
        Me.btnErreserba.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.reservas
        Me.btnErreserba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnErreserba.Location = New System.Drawing.Point(261, 384)
        Me.btnErreserba.Name = "btnErreserba"
        Me.btnErreserba.Size = New System.Drawing.Size(496, 98)
        Me.btnErreserba.TabIndex = 3
        Me.btnErreserba.UseVisualStyleBackColor = True
        '
        'btnAtzera
        '
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(449, 536)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(108, 66)
        Me.btnAtzera.TabIndex = 4
        Me.btnAtzera.UseVisualStyleBackColor = True
        '
        'KudeaketaLeihoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnErreserba)
        Me.Controls.Add(Me.btnErabiltzaile)
        Me.Controls.Add(Me.btnAlojamendu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KudeaketaLeihoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kudeaketak"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAlojamendu As Button
    Friend WithEvents btnErabiltzaile As Button
    Friend WithEvents btnErreserba As Button
    Friend WithEvents btnAtzera As Button
End Class
