<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OstatuLeiho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OstatuLeiho))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.btnAldatu = New System.Windows.Forms.Button()
        Me.btnKendu = New System.Windows.Forms.Button()
        Me.btnSartu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbDatua = New System.Windows.Forms.TextBox()
        Me.cmBKolumna = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(43, 108)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(890, 413)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnAtzera
        '
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(162, 558)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(101, 60)
        Me.btnAtzera.TabIndex = 3
        Me.btnAtzera.UseVisualStyleBackColor = True
        '
        'btnAldatu
        '
        Me.btnAldatu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.aldatu
        Me.btnAldatu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAldatu.Enabled = False
        Me.btnAldatu.Location = New System.Drawing.Point(547, 558)
        Me.btnAldatu.Name = "btnAldatu"
        Me.btnAldatu.Size = New System.Drawing.Size(102, 60)
        Me.btnAldatu.TabIndex = 5
        Me.btnAldatu.UseVisualStyleBackColor = True
        '
        'btnKendu
        '
        Me.btnKendu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.basura
        Me.btnKendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKendu.Enabled = False
        Me.btnKendu.Location = New System.Drawing.Point(725, 558)
        Me.btnKendu.Name = "btnKendu"
        Me.btnKendu.Size = New System.Drawing.Size(102, 60)
        Me.btnKendu.TabIndex = 6
        Me.btnKendu.UseVisualStyleBackColor = True
        '
        'btnSartu
        '
        Me.btnSartu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.upload1
        Me.btnSartu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSartu.Location = New System.Drawing.Point(356, 558)
        Me.btnSartu.Name = "btnSartu"
        Me.btnSartu.Size = New System.Drawing.Size(101, 60)
        Me.btnSartu.TabIndex = 4
        Me.btnSartu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(580, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Datua:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Kolumna:"
        '
        'txbDatua
        '
        Me.txbDatua.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDatua.Location = New System.Drawing.Point(667, 41)
        Me.txbDatua.Name = "txbDatua"
        Me.txbDatua.Size = New System.Drawing.Size(206, 33)
        Me.txbDatua.TabIndex = 2
        '
        'cmBKolumna
        '
        Me.cmBKolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmBKolumna.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmBKolumna.IntegralHeight = False
        Me.cmBKolumna.Location = New System.Drawing.Point(253, 41)
        Me.cmBKolumna.Name = "cmBKolumna"
        Me.cmBKolumna.Size = New System.Drawing.Size(204, 37)
        Me.cmBKolumna.TabIndex = 45
        '
        'OstatuLeiho
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
        Me.Name = "OstatuLeiho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAldatu As Button
    Friend WithEvents btnAtzera As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnKendu As Button
    Friend WithEvents btnSartu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txbDatua As TextBox
    Friend WithEvents cmBKolumna As ComboBox
End Class
