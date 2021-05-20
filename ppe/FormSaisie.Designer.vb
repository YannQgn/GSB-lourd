<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSaisie
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
        Me.components = New System.ComponentModel.Container()
        Me.datevisite = New System.Windows.Forms.Label()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.Enregistrer = New System.Windows.Forms.Button()
        Me.datevisite1 = New System.Windows.Forms.DateTimePicker()
        Me.motifvisite = New System.Windows.Forms.Label()
        Me.motifvisite1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.med_presente = New System.Windows.Forms.Label()
        Me.med_presente1 = New System.Windows.Forms.CheckedListBox()
        Me.ech_offert = New System.Windows.Forms.Label()
        Me.nompraticien = New System.Windows.Forms.Label()
        Me.prenompraticien = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ech_offert1 = New System.Windows.Forms.NumericUpDown()
        Me.heurevisite = New System.Windows.Forms.Label()
        Me.heurevisite1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labelheure = New System.Windows.Forms.Label()
        CType(Me.ech_offert1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datevisite
        '
        Me.datevisite.AutoSize = True
        Me.datevisite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datevisite.Location = New System.Drawing.Point(13, 18)
        Me.datevisite.Name = "datevisite"
        Me.datevisite.Size = New System.Drawing.Size(96, 16)
        Me.datevisite.TabIndex = 0
        Me.datevisite.Text = "Date de visite :"
        '
        'Annuler
        '
        Me.Annuler.BackColor = System.Drawing.SystemColors.Info
        Me.Annuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info
        Me.Annuler.FlatAppearance.BorderSize = 10
        Me.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Annuler.Location = New System.Drawing.Point(283, 548)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(75, 23)
        Me.Annuler.TabIndex = 1
        Me.Annuler.Text = "Annuler"
        Me.Annuler.UseVisualStyleBackColor = False
        '
        'Enregistrer
        '
        Me.Enregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Enregistrer.FlatAppearance.BorderSize = 10
        Me.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enregistrer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Enregistrer.Location = New System.Drawing.Point(16, 534)
        Me.Enregistrer.Name = "Enregistrer"
        Me.Enregistrer.Size = New System.Drawing.Size(261, 37)
        Me.Enregistrer.TabIndex = 2
        Me.Enregistrer.Text = "Enregistrer le compte-rendu"
        Me.Enregistrer.UseVisualStyleBackColor = False
        '
        'datevisite1
        '
        Me.datevisite1.Location = New System.Drawing.Point(115, 18)
        Me.datevisite1.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.datevisite1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.datevisite1.Name = "datevisite1"
        Me.datevisite1.Size = New System.Drawing.Size(220, 20)
        Me.datevisite1.TabIndex = 3
        '
        'motifvisite
        '
        Me.motifvisite.AutoSize = True
        Me.motifvisite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motifvisite.Location = New System.Drawing.Point(12, 118)
        Me.motifvisite.Name = "motifvisite"
        Me.motifvisite.Size = New System.Drawing.Size(95, 16)
        Me.motifvisite.TabIndex = 4
        Me.motifvisite.Text = "Motif de visite :"
        '
        'motifvisite1
        '
        Me.motifvisite1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.motifvisite1.Location = New System.Drawing.Point(113, 117)
        Me.motifvisite1.MaxLength = 252
        Me.motifvisite1.Multiline = True
        Me.motifvisite1.Name = "motifvisite1"
        Me.motifvisite1.Size = New System.Drawing.Size(220, 96)
        Me.motifvisite1.TabIndex = 5
        '
        'med_presente
        '
        Me.med_presente.AutoSize = True
        Me.med_presente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.med_presente.Location = New System.Drawing.Point(12, 242)
        Me.med_presente.Name = "med_presente"
        Me.med_presente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.med_presente.Size = New System.Drawing.Size(144, 32)
        Me.med_presente.TabIndex = 6
        Me.med_presente.Text = "Médicament présenté  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(à cocher)  :"
        '
        'med_presente1
        '
        Me.med_presente1.FormattingEnabled = True
        Me.med_presente1.Location = New System.Drawing.Point(164, 242)
        Me.med_presente1.MultiColumn = True
        Me.med_presente1.Name = "med_presente1"
        Me.med_presente1.Size = New System.Drawing.Size(171, 79)
        Me.med_presente1.TabIndex = 7
        '
        'ech_offert
        '
        Me.ech_offert.AutoSize = True
        Me.ech_offert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ech_offert.Location = New System.Drawing.Point(12, 349)
        Me.ech_offert.Name = "ech_offert"
        Me.ech_offert.Size = New System.Drawing.Size(187, 16)
        Me.ech_offert.TabIndex = 8
        Me.ech_offert.Text = "Nombre d'échantillons offerts :"
        '
        'nompraticien
        '
        Me.nompraticien.AutoSize = True
        Me.nompraticien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nompraticien.Location = New System.Drawing.Point(12, 406)
        Me.nompraticien.Name = "nompraticien"
        Me.nompraticien.Size = New System.Drawing.Size(97, 16)
        Me.nompraticien.TabIndex = 10
        Me.nompraticien.Text = "Nom praticien :"
        '
        'prenompraticien
        '
        Me.prenompraticien.AutoSize = True
        Me.prenompraticien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenompraticien.Location = New System.Drawing.Point(12, 453)
        Me.prenompraticien.Name = "prenompraticien"
        Me.prenompraticien.Size = New System.Drawing.Size(115, 16)
        Me.prenompraticien.TabIndex = 11
        Me.prenompraticien.Text = "Prénom praticien :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(133, 453)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(202, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(115, 405)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 20)
        Me.TextBox3.TabIndex = 14
        '
        'ech_offert1
        '
        Me.ech_offert1.Location = New System.Drawing.Point(205, 349)
        Me.ech_offert1.Name = "ech_offert1"
        Me.ech_offert1.Size = New System.Drawing.Size(130, 20)
        Me.ech_offert1.TabIndex = 15
        Me.ech_offert1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'heurevisite
        '
        Me.heurevisite.AutoSize = True
        Me.heurevisite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heurevisite.Location = New System.Drawing.Point(12, 61)
        Me.heurevisite.Name = "heurevisite"
        Me.heurevisite.Size = New System.Drawing.Size(104, 16)
        Me.heurevisite.TabIndex = 16
        Me.heurevisite.Text = "Heure de visite :"
        '
        'heurevisite1
        '
        Me.heurevisite1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.heurevisite1.Location = New System.Drawing.Point(113, 91)
        Me.heurevisite1.Name = "heurevisite1"
        Me.heurevisite1.Size = New System.Drawing.Size(200, 20)
        Me.heurevisite1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labelheure
        '
        Me.labelheure.AutoSize = True
        Me.labelheure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelheure.Location = New System.Drawing.Point(122, 61)
        Me.labelheure.Name = "labelheure"
        Me.labelheure.Size = New System.Drawing.Size(12, 16)
        Me.labelheure.TabIndex = 19
        Me.labelheure.Text = "-"
        '
        'FormSaisie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(370, 583)
        Me.Controls.Add(Me.labelheure)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.heurevisite1)
        Me.Controls.Add(Me.heurevisite)
        Me.Controls.Add(Me.ech_offert1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.prenompraticien)
        Me.Controls.Add(Me.nompraticien)
        Me.Controls.Add(Me.ech_offert)
        Me.Controls.Add(Me.med_presente1)
        Me.Controls.Add(Me.med_presente)
        Me.Controls.Add(Me.motifvisite1)
        Me.Controls.Add(Me.motifvisite)
        Me.Controls.Add(Me.datevisite1)
        Me.Controls.Add(Me.Enregistrer)
        Me.Controls.Add(Me.Annuler)
        Me.Controls.Add(Me.datevisite)
        Me.Name = "FormSaisie"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saisir un formulaire"
        CType(Me.ech_offert1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datevisite As System.Windows.Forms.Label
    Friend WithEvents Annuler As System.Windows.Forms.Button
    Friend WithEvents Enregistrer As System.Windows.Forms.Button
    Friend WithEvents datevisite1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents motifvisite As System.Windows.Forms.Label
    Friend WithEvents motifvisite1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents med_presente As System.Windows.Forms.Label
    Friend WithEvents med_presente1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents ech_offert As System.Windows.Forms.Label
    Friend WithEvents nompraticien As System.Windows.Forms.Label
    Friend WithEvents prenompraticien As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ech_offert1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents heurevisite As System.Windows.Forms.Label
    Friend WithEvents heurevisite1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents labelheure As System.Windows.Forms.Label
End Class
