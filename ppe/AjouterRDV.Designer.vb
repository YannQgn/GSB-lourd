<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterRDV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ComboBoxPra = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerRDV = New System.Windows.Forms.DateTimePicker()
        Me.ButtonRDV = New System.Windows.Forms.Button()
        Me.AnnulerMed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Location = New System.Drawing.Point(12, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(91, 13)
        Me.LabelTitre.TabIndex = 2
        Me.LabelTitre.Text = "Prendre un RDV :"
        '
        'ComboBoxPra
        '
        Me.ComboBoxPra.FormattingEnabled = True
        Me.ComboBoxPra.Location = New System.Drawing.Point(52, 60)
        Me.ComboBoxPra.Name = "ComboBoxPra"
        Me.ComboBoxPra.Size = New System.Drawing.Size(172, 21)
        Me.ComboBoxPra.TabIndex = 3
        Me.ComboBoxPra.Text = "Selectionner un praticien"
        '
        'DateTimePickerRDV
        '
        Me.DateTimePickerRDV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerRDV.Location = New System.Drawing.Point(52, 110)
        Me.DateTimePickerRDV.Name = "DateTimePickerRDV"
        Me.DateTimePickerRDV.Size = New System.Drawing.Size(172, 20)
        Me.DateTimePickerRDV.TabIndex = 8
        '
        'ButtonRDV
        '
        Me.ButtonRDV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ButtonRDV.Location = New System.Drawing.Point(31, 169)
        Me.ButtonRDV.Name = "ButtonRDV"
        Me.ButtonRDV.Size = New System.Drawing.Size(116, 41)
        Me.ButtonRDV.TabIndex = 9
        Me.ButtonRDV.Text = "Valider"
        Me.ButtonRDV.UseVisualStyleBackColor = False
        '
        'AnnulerMed
        '
        Me.AnnulerMed.Location = New System.Drawing.Point(174, 169)
        Me.AnnulerMed.Name = "AnnulerMed"
        Me.AnnulerMed.Size = New System.Drawing.Size(111, 41)
        Me.AnnulerMed.TabIndex = 10
        Me.AnnulerMed.Text = "Annuler"
        Me.AnnulerMed.UseVisualStyleBackColor = True
        '
        'AjouterRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 250)
        Me.Controls.Add(Me.AnnulerMed)
        Me.Controls.Add(Me.ButtonRDV)
        Me.Controls.Add(Me.DateTimePickerRDV)
        Me.Controls.Add(Me.ComboBoxPra)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "AjouterRDV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AjouterRDV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPra As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerRDV As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonRDV As System.Windows.Forms.Button
    Friend WithEvents AnnulerMed As System.Windows.Forms.Button
End Class
