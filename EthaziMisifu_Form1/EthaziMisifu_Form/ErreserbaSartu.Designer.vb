<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErreserbaSartu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErreserbaSartu))
        Me.mCIrte = New System.Windows.Forms.MonthCalendar()
        Me.mCSart = New System.Windows.Forms.MonthCalendar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.btnSartu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmBErab = New System.Windows.Forms.ComboBox()
        Me.cmBOst = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'mCIrte
        '
        Me.mCIrte.Location = New System.Drawing.Point(560, 268)
        Me.mCIrte.MaxSelectionCount = 1
        Me.mCIrte.Name = "mCIrte"
        Me.mCIrte.TabIndex = 2
        '
        'mCSart
        '
        Me.mCSart.Location = New System.Drawing.Point(232, 268)
        Me.mCSart.MaxSelectionCount = 1
        Me.mCSart.Name = "mCSart"
        Me.mCSart.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(596, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Irtetze Data:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Sartze Data:"
        '
        'btnAtzera
        '
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(283, 493)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(88, 85)
        Me.btnAtzera.TabIndex = 4
        Me.btnAtzera.UseVisualStyleBackColor = True
        '
        'btnSartu
        '
        Me.btnSartu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.gorde
        Me.btnSartu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSartu.Location = New System.Drawing.Point(625, 493)
        Me.btnSartu.Name = "btnSartu"
        Me.btnSartu.Size = New System.Drawing.Size(88, 85)
        Me.btnSartu.TabIndex = 3
        Me.btnSartu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ostatua:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Erabiltzailea:"
        '
        'cmBErab
        '
        Me.cmBErab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmBErab.FormattingEnabled = True
        Me.cmBErab.Location = New System.Drawing.Point(404, 83)
        Me.cmBErab.Name = "cmBErab"
        Me.cmBErab.Size = New System.Drawing.Size(237, 21)
        Me.cmBErab.TabIndex = 45
        '
        'cmBOst
        '
        Me.cmBOst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmBOst.FormattingEnabled = True
        Me.cmBOst.Location = New System.Drawing.Point(404, 154)
        Me.cmBOst.Name = "cmBOst"
        Me.cmBOst.Size = New System.Drawing.Size(237, 21)
        Me.cmBOst.TabIndex = 34
        '
        'ErreserbaSartu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.cmBOst)
        Me.Controls.Add(Me.cmBErab)
        Me.Controls.Add(Me.mCIrte)
        Me.Controls.Add(Me.mCSart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnSartu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ErreserbaSartu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ErreserbaSartu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mCIrte As MonthCalendar
    Friend WithEvents mCSart As MonthCalendar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAtzera As Button
    Friend WithEvents btnSartu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmBErab As ComboBox
    Friend WithEvents cmBOst As ComboBox
End Class
