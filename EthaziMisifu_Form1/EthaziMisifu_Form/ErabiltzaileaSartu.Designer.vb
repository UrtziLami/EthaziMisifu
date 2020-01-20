<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErabiltzaileaSartu
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
        Me.txtBErabIzena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.btnSartu = New System.Windows.Forms.Button()
        Me.txtBPas1 = New System.Windows.Forms.TextBox()
        Me.lblPasahitza = New System.Windows.Forms.Label()
        Me.txtBIzenAbi = New System.Windows.Forms.TextBox()
        Me.lblIzenAb = New System.Windows.Forms.Label()
        Me.picBIzAb = New System.Windows.Forms.PictureBox()
        Me.picBErabIzn = New System.Windows.Forms.PictureBox()
        Me.picBPas = New System.Windows.Forms.PictureBox()
        CType(Me.picBIzAb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBErabIzn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBPas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBErabIzena
        '
        Me.txtBErabIzena.Location = New System.Drawing.Point(430, 313)
        Me.txtBErabIzena.Name = "txtBErabIzena"
        Me.txtBErabIzena.Size = New System.Drawing.Size(289, 20)
        Me.txtBErabIzena.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Erabiltzaile Izena:"
        '
        'btnAtzera
        '
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(283, 465)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(87, 77)
        Me.btnAtzera.TabIndex = 15
        Me.btnAtzera.UseVisualStyleBackColor = True
        '
        'btnSartu
        '
        Me.btnSartu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.gorde
        Me.btnSartu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSartu.Location = New System.Drawing.Point(604, 465)
        Me.btnSartu.Name = "btnSartu"
        Me.btnSartu.Size = New System.Drawing.Size(87, 77)
        Me.btnSartu.TabIndex = 14
        Me.btnSartu.UseVisualStyleBackColor = True
        '
        'txtBPas1
        '
        Me.txtBPas1.Location = New System.Drawing.Point(430, 216)
        Me.txtBPas1.Name = "txtBPas1"
        Me.txtBPas1.Size = New System.Drawing.Size(289, 20)
        Me.txtBPas1.TabIndex = 13
        '
        'lblPasahitza
        '
        Me.lblPasahitza.AutoSize = True
        Me.lblPasahitza.BackColor = System.Drawing.Color.Transparent
        Me.lblPasahitza.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasahitza.Location = New System.Drawing.Point(266, 211)
        Me.lblPasahitza.Name = "lblPasahitza"
        Me.lblPasahitza.Size = New System.Drawing.Size(104, 25)
        Me.lblPasahitza.TabIndex = 12
        Me.lblPasahitza.Text = "Pasahitza:"
        '
        'txtBIzenAbi
        '
        Me.txtBIzenAbi.Location = New System.Drawing.Point(430, 124)
        Me.txtBIzenAbi.Name = "txtBIzenAbi"
        Me.txtBIzenAbi.Size = New System.Drawing.Size(289, 20)
        Me.txtBIzenAbi.TabIndex = 11
        '
        'lblIzenAb
        '
        Me.lblIzenAb.AutoSize = True
        Me.lblIzenAb.BackColor = System.Drawing.Color.Transparent
        Me.lblIzenAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIzenAb.Location = New System.Drawing.Point(266, 119)
        Me.lblIzenAb.Name = "lblIzenAb"
        Me.lblIzenAb.Size = New System.Drawing.Size(132, 25)
        Me.lblIzenAb.TabIndex = 10
        Me.lblIzenAb.Text = "Izen Abizena:"
        '
        'picBIzAb
        '
        Me.picBIzAb.BackColor = System.Drawing.Color.Transparent
        Me.picBIzAb.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.alert
        Me.picBIzAb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBIzAb.Location = New System.Drawing.Point(725, 124)
        Me.picBIzAb.Name = "picBIzAb"
        Me.picBIzAb.Size = New System.Drawing.Size(23, 20)
        Me.picBIzAb.TabIndex = 44
        Me.picBIzAb.TabStop = False
        Me.picBIzAb.Visible = False
        '
        'picBErabIzn
        '
        Me.picBErabIzn.BackColor = System.Drawing.Color.Transparent
        Me.picBErabIzn.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.alert
        Me.picBErabIzn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBErabIzn.Location = New System.Drawing.Point(725, 313)
        Me.picBErabIzn.Name = "picBErabIzn"
        Me.picBErabIzn.Size = New System.Drawing.Size(23, 20)
        Me.picBErabIzn.TabIndex = 45
        Me.picBErabIzn.TabStop = False
        Me.picBErabIzn.Visible = False
        '
        'picBPas
        '
        Me.picBPas.BackColor = System.Drawing.Color.Transparent
        Me.picBPas.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.alert
        Me.picBPas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBPas.Location = New System.Drawing.Point(725, 216)
        Me.picBPas.Name = "picBPas"
        Me.picBPas.Size = New System.Drawing.Size(23, 20)
        Me.picBPas.TabIndex = 45
        Me.picBPas.TabStop = False
        Me.picBPas.Visible = False
        '
        'ErabiltzaileaSartu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.picBPas)
        Me.Controls.Add(Me.picBErabIzn)
        Me.Controls.Add(Me.picBIzAb)
        Me.Controls.Add(Me.txtBErabIzena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnSartu)
        Me.Controls.Add(Me.txtBPas1)
        Me.Controls.Add(Me.lblPasahitza)
        Me.Controls.Add(Me.txtBIzenAbi)
        Me.Controls.Add(Me.lblIzenAb)
        Me.Name = "ErabiltzaileaSartu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ErabiltzaileaSartu"
        CType(Me.picBIzAb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBErabIzn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBPas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBErabIzena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAtzera As Button
    Friend WithEvents btnSartu As Button
    Friend WithEvents txtBPas1 As TextBox
    Friend WithEvents lblPasahitza As Label
    Friend WithEvents txtBIzenAbi As TextBox
    Friend WithEvents lblIzenAb As Label
    Friend WithEvents picBIzAb As PictureBox
    Friend WithEvents picBErabIzn As PictureBox
    Friend WithEvents picBPas As PictureBox
End Class
