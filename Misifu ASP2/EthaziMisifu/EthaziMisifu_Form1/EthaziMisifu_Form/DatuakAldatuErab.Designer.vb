<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatuakAldatuErab
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatuakAldatuErab))
        Me.lblIzenAb = New System.Windows.Forms.Label()
        Me.txtBIzenAbi = New System.Windows.Forms.TextBox()
        Me.lblPasahitza = New System.Windows.Forms.Label()
        Me.txtBPas1 = New System.Windows.Forms.TextBox()
        Me.btnGorde = New System.Windows.Forms.Button()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.txtBErabIzena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIzenAb
        '
        Me.lblIzenAb.AutoSize = True
        Me.lblIzenAb.BackColor = System.Drawing.Color.Transparent
        Me.lblIzenAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIzenAb.Location = New System.Drawing.Point(263, 128)
        Me.lblIzenAb.Name = "lblIzenAb"
        Me.lblIzenAb.Size = New System.Drawing.Size(132, 25)
        Me.lblIzenAb.TabIndex = 0
        Me.lblIzenAb.Text = "Izen Abizena:"
        '
        'txtBIzenAbi
        '
        Me.txtBIzenAbi.Location = New System.Drawing.Point(427, 133)
        Me.txtBIzenAbi.Name = "txtBIzenAbi"
        Me.txtBIzenAbi.Size = New System.Drawing.Size(289, 20)
        Me.txtBIzenAbi.TabIndex = 1
        '
        'lblPasahitza
        '
        Me.lblPasahitza.AutoSize = True
        Me.lblPasahitza.BackColor = System.Drawing.Color.Transparent
        Me.lblPasahitza.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasahitza.Location = New System.Drawing.Point(263, 220)
        Me.lblPasahitza.Name = "lblPasahitza"
        Me.lblPasahitza.Size = New System.Drawing.Size(104, 25)
        Me.lblPasahitza.TabIndex = 2
        Me.lblPasahitza.Text = "Pasahitza:"
        '
        'txtBPas1
        '
        Me.txtBPas1.Location = New System.Drawing.Point(427, 225)
        Me.txtBPas1.Name = "txtBPas1"
        Me.txtBPas1.Size = New System.Drawing.Size(289, 20)
        Me.txtBPas1.TabIndex = 3
        '
        'btnGorde
        '
        Me.btnGorde.BackgroundImage = CType(resources.GetObject("btnGorde.BackgroundImage"), System.Drawing.Image)
        Me.btnGorde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGorde.Location = New System.Drawing.Point(581, 474)
        Me.btnGorde.Name = "btnGorde"
        Me.btnGorde.Size = New System.Drawing.Size(87, 77)
        Me.btnGorde.TabIndex = 6
        Me.btnGorde.UseVisualStyleBackColor = True
        '
        'btnAtzera
        '
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(268, 474)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(87, 77)
        Me.btnAtzera.TabIndex = 7
        Me.btnAtzera.UseVisualStyleBackColor = True
        '
        'txtBErabIzena
        '
        Me.txtBErabIzena.Location = New System.Drawing.Point(427, 322)
        Me.txtBErabIzena.Name = "txtBErabIzena"
        Me.txtBErabIzena.Size = New System.Drawing.Size(289, 20)
        Me.txtBErabIzena.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Erabiltzaile Izena:"
        '
        'DatuakAldatuErab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.txtBErabIzena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnGorde)
        Me.Controls.Add(Me.txtBPas1)
        Me.Controls.Add(Me.lblPasahitza)
        Me.Controls.Add(Me.txtBIzenAbi)
        Me.Controls.Add(Me.lblIzenAb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatuakAldatuErab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatuakAldatuErab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIzenAb As Label
    Friend WithEvents txtBIzenAbi As TextBox
    Friend WithEvents lblPasahitza As Label
    Friend WithEvents txtBPas1 As TextBox
    Friend WithEvents btnGorde As Button
    Friend WithEvents btnAtzera As Button
    Friend WithEvents txtBErabIzena As TextBox
    Friend WithEvents Label1 As Label
End Class
