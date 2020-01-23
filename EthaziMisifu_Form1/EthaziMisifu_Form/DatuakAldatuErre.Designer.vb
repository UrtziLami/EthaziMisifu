<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatuakAldatuErre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatuakAldatuErre))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGorde = New System.Windows.Forms.Button()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mCSart = New System.Windows.Forms.MonthCalendar()
        Me.mCIrte = New System.Windows.Forms.MonthCalendar()
        Me.cmbBerab = New System.Windows.Forms.ComboBox()
        Me.cmbBOsta = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Erabiltzailea:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ostatua:"
        '
        'btnGorde
        '
        Me.btnGorde.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.gorde
        Me.btnGorde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGorde.Location = New System.Drawing.Point(658, 470)
        Me.btnGorde.Name = "btnGorde"
        Me.btnGorde.Size = New System.Drawing.Size(88, 85)
        Me.btnGorde.TabIndex = 3
        Me.btnGorde.UseVisualStyleBackColor = True
        '
        'btnAtzera
        '
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(316, 470)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(88, 85)
        Me.btnAtzera.TabIndex = 4
        Me.btnAtzera.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sartze Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(629, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Irtetze Data:"
        '
        'mCSart
        '
        Me.mCSart.Location = New System.Drawing.Point(265, 245)
        Me.mCSart.MaxSelectionCount = 1
        Me.mCSart.Name = "mCSart"
        Me.mCSart.TabIndex = 1
        '
        'mCIrte
        '
        Me.mCIrte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mCIrte.Location = New System.Drawing.Point(593, 245)
        Me.mCIrte.MaxSelectionCount = 1
        Me.mCIrte.Name = "mCIrte"
        Me.mCIrte.TabIndex = 2
        '
        'cmbBerab
        '
        Me.cmbBerab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBerab.FormattingEnabled = True
        Me.cmbBerab.Location = New System.Drawing.Point(453, 63)
        Me.cmbBerab.Name = "cmbBerab"
        Me.cmbBerab.Size = New System.Drawing.Size(255, 21)
        Me.cmbBerab.TabIndex = 1
        '
        'cmbBOsta
        '
        Me.cmbBOsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBOsta.FormattingEnabled = True
        Me.cmbBOsta.Location = New System.Drawing.Point(453, 137)
        Me.cmbBOsta.Name = "cmbBOsta"
        Me.cmbBOsta.Size = New System.Drawing.Size(255, 21)
        Me.cmbBOsta.TabIndex = 2
        '
        'DatuakAldatuErre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.cmbBOsta)
        Me.Controls.Add(Me.cmbBerab)
        Me.Controls.Add(Me.mCIrte)
        Me.Controls.Add(Me.mCSart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnGorde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatuakAldatuErre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatuakAldatuErre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGorde As Button
    Friend WithEvents btnAtzera As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mCSart As MonthCalendar
    Friend WithEvents mCIrte As MonthCalendar
    Friend WithEvents cmbBerab As ComboBox
    Friend WithEvents cmbBOsta As ComboBox
End Class
