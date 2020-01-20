<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HasiSaioaLeihoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HasiSaioaLeihoa))
        Me.txtBxErabiltzailea = New System.Windows.Forms.TextBox()
        Me.txBPasahitza = New System.Windows.Forms.TextBox()
        Me.chbErabGog = New System.Windows.Forms.CheckBox()
        Me.btnHasiSaioa = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBxErabiltzailea
        '
        Me.txtBxErabiltzailea.Location = New System.Drawing.Point(368, 205)
        Me.txtBxErabiltzailea.Name = "txtBxErabiltzailea"
        Me.txtBxErabiltzailea.Size = New System.Drawing.Size(369, 20)
        Me.txtBxErabiltzailea.TabIndex = 2
        '
        'txBPasahitza
        '
        Me.txBPasahitza.Location = New System.Drawing.Point(368, 315)
        Me.txBPasahitza.Name = "txBPasahitza"
        Me.txBPasahitza.Size = New System.Drawing.Size(369, 20)
        Me.txBPasahitza.TabIndex = 3
        Me.txBPasahitza.UseSystemPasswordChar = True
        '
        'chbErabGog
        '
        Me.chbErabGog.AutoSize = True
        Me.chbErabGog.BackColor = System.Drawing.Color.Transparent
        Me.chbErabGog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbErabGog.Location = New System.Drawing.Point(368, 370)
        Me.chbErabGog.Name = "chbErabGog"
        Me.chbErabGog.Size = New System.Drawing.Size(218, 29)
        Me.chbErabGog.TabIndex = 5
        Me.chbErabGog.Text = "Erabiltzailea gogoratu"
        Me.chbErabGog.UseVisualStyleBackColor = False
        '
        'btnHasiSaioa
        '
        Me.btnHasiSaioa.BackColor = System.Drawing.Color.Transparent
        Me.btnHasiSaioa.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.flecha
        Me.btnHasiSaioa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHasiSaioa.Location = New System.Drawing.Point(450, 496)
        Me.btnHasiSaioa.Name = "btnHasiSaioa"
        Me.btnHasiSaioa.Size = New System.Drawing.Size(117, 83)
        Me.btnHasiSaioa.TabIndex = 4
        Me.btnHasiSaioa.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1._26ed4bf470ad0a2fa80c1b6258e9f5a1_icono_de_llave_b__sica_by_vexels
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(276, 288)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.icono_persona
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(276, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rage Italic", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 101)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HasiSaioaLeihoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.chbErabGog)
        Me.Controls.Add(Me.btnHasiSaioa)
        Me.Controls.Add(Me.txBPasahitza)
        Me.Controls.Add(Me.txtBxErabiltzailea)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HasiSaioaLeihoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HasiSaioa"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtBxErabiltzailea As TextBox
    Friend WithEvents txBPasahitza As TextBox
    Friend WithEvents btnHasiSaioa As Button
    Friend WithEvents chbErabGog As CheckBox
    Friend WithEvents Label1 As Label
End Class
