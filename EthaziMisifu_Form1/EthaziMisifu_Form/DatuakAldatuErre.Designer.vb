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
        Me.txtBErab = New System.Windows.Forms.TextBox()
        Me.txtBOsta = New System.Windows.Forms.TextBox()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 148)
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
        Me.Label2.Location = New System.Drawing.Point(294, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ostatua:"
        '
        'btnGorde
        '
        Me.btnGorde.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.gorde
        Me.btnGorde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGorde.Location = New System.Drawing.Point(619, 433)
        Me.btnGorde.Name = "btnGorde"
        Me.btnGorde.Size = New System.Drawing.Size(88, 85)
        Me.btnGorde.TabIndex = 2
        Me.btnGorde.UseVisualStyleBackColor = True
        '
        'txtBErab
        '
        Me.txtBErab.Location = New System.Drawing.Point(423, 153)
        Me.txtBErab.Name = "txtBErab"
        Me.txtBErab.Size = New System.Drawing.Size(284, 20)
        Me.txtBErab.TabIndex = 3
        '
        'txtBOsta
        '
        Me.txtBOsta.Location = New System.Drawing.Point(423, 273)
        Me.txtBOsta.Name = "txtBOsta"
        Me.txtBOsta.Size = New System.Drawing.Size(284, 20)
        Me.txtBOsta.TabIndex = 4
        '
        'btnAtzera
        '
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(251, 433)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(88, 85)
        Me.btnAtzera.TabIndex = 5
        Me.btnAtzera.UseVisualStyleBackColor = True
        '
        'DatuakAldatuErre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.txtBOsta)
        Me.Controls.Add(Me.txtBErab)
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
    Friend WithEvents txtBErab As TextBox
    Friend WithEvents txtBOsta As TextBox
    Friend WithEvents btnAtzera As Button
End Class
