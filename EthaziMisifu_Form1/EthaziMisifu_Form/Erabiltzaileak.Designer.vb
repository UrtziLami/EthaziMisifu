<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErabiltzaileLeihoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErabiltzaileLeihoa))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.btnAldatu = New System.Windows.Forms.Button()
        Me.btnKendu = New System.Windows.Forms.Button()
        Me.btnSartu = New System.Windows.Forms.Button()
        Me.cmBKolumna = New System.Windows.Forms.ComboBox()
        Me.txbDatua = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(61, 99)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(840, 426)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnAtzera
        '
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(107, 556)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(92, 57)
        Me.btnAtzera.TabIndex = 2
        Me.btnAtzera.UseVisualStyleBackColor = True
        '
        'btnAldatu
        '
        Me.btnAldatu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.aldatu
        Me.btnAldatu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAldatu.Enabled = False
        Me.btnAldatu.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAldatu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAldatu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAldatu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAldatu.Location = New System.Drawing.Point(546, 556)
        Me.btnAldatu.Name = "btnAldatu"
        Me.btnAldatu.Size = New System.Drawing.Size(103, 57)
        Me.btnAldatu.TabIndex = 4
        Me.btnAldatu.UseVisualStyleBackColor = True
        '
        'btnKendu
        '
        Me.btnKendu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.basura
        Me.btnKendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKendu.Enabled = False
        Me.btnKendu.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnKendu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnKendu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnKendu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnKendu.Location = New System.Drawing.Point(750, 556)
        Me.btnKendu.Name = "btnKendu"
        Me.btnKendu.Size = New System.Drawing.Size(103, 57)
        Me.btnKendu.TabIndex = 5
        Me.btnKendu.UseVisualStyleBackColor = True
        '
        'btnSartu
        '
        Me.btnSartu.BackColor = System.Drawing.Color.Transparent
        Me.btnSartu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.upload1
        Me.btnSartu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSartu.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSartu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSartu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSartu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSartu.Location = New System.Drawing.Point(323, 556)
        Me.btnSartu.Name = "btnSartu"
        Me.btnSartu.Size = New System.Drawing.Size(103, 57)
        Me.btnSartu.TabIndex = 3
        Me.btnSartu.UseVisualStyleBackColor = False
        '
        'cmBKolumna
        '
        Me.cmBKolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmBKolumna.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmBKolumna.FormattingEnabled = True
        Me.cmBKolumna.Location = New System.Drawing.Point(222, 29)
        Me.cmBKolumna.Name = "cmBKolumna"
        Me.cmBKolumna.Size = New System.Drawing.Size(204, 37)
        Me.cmBKolumna.TabIndex = 1
        '
        'txbDatua
        '
        Me.txbDatua.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDatua.Location = New System.Drawing.Point(664, 33)
        Me.txbDatua.Name = "txbDatua"
        Me.txbDatua.Size = New System.Drawing.Size(189, 33)
        Me.txbDatua.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kolumna:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(568, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Datua:"
        '
        'ErabiltzaileLeihoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbDatua)
        Me.Controls.Add(Me.cmBKolumna)
        Me.Controls.Add(Me.btnSartu)
        Me.Controls.Add(Me.btnKendu)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnAldatu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ErabiltzaileLeihoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Erabiltzaileak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAldatu As Button
    Friend WithEvents btnAtzera As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnKendu As Button
    Friend WithEvents btnSartu As Button
    Friend WithEvents cmBKolumna As ComboBox
    Friend WithEvents txbDatua As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
