﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErreserbaLeihoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErreserbaLeihoa))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.btnAldatu = New System.Windows.Forms.Button()
        Me.btnKendu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(65, 63)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(846, 414)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnAtzera
        '
        Me.btnAtzera.BackColor = System.Drawing.Color.Transparent
        Me.btnAtzera.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.atras
        Me.btnAtzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtzera.Location = New System.Drawing.Point(179, 559)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(100, 58)
        Me.btnAtzera.TabIndex = 5
        Me.btnAtzera.UseVisualStyleBackColor = False
        '
        'btnAldatu
        '
        Me.btnAldatu.BackColor = System.Drawing.Color.Transparent
        Me.btnAldatu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.aldatu
        Me.btnAldatu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAldatu.Enabled = False
        Me.btnAldatu.Location = New System.Drawing.Point(476, 559)
        Me.btnAldatu.Name = "btnAldatu"
        Me.btnAldatu.Size = New System.Drawing.Size(98, 58)
        Me.btnAldatu.TabIndex = 2
        Me.btnAldatu.UseVisualStyleBackColor = False
        '
        'btnKendu
        '
        Me.btnKendu.BackColor = System.Drawing.Color.Transparent
        Me.btnKendu.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resource1.basura
        Me.btnKendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKendu.Enabled = False
        Me.btnKendu.Location = New System.Drawing.Point(748, 559)
        Me.btnKendu.Name = "btnKendu"
        Me.btnKendu.Size = New System.Drawing.Size(102, 58)
        Me.btnKendu.TabIndex = 7
        Me.btnKendu.UseVisualStyleBackColor = False
        '
        'ErreserbaLeihoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EthaziMisifu_Form.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btnKendu)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnAldatu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ErreserbaLeihoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Erreserbak"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAldatu As Button
    Friend WithEvents btnAtzera As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnKendu As Button
End Class