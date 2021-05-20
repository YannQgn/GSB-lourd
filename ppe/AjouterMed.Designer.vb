<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterMed
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
        Me.AnnulerMed = New System.Windows.Forms.Button()
        Me.AjoutMed = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.updatetab = New System.Windows.Forms.Button()
        Me.labelcodemed = New System.Windows.Forms.Label()
        Me.labelnommed = New System.Windows.Forms.Label()
        Me.textcodemed = New System.Windows.Forms.TextBox()
        Me.textnommed = New System.Windows.Forms.TextBox()
        Me.CODEMED_TextColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMMEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDICAMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AjouterMedData = New ppe.AjouterMedData()
        Me.MEDICAMENTTableAdapter = New ppe.AjouterMedDataTableAdapters.MEDICAMENTTableAdapter()
        Me.AjouterMedData1 = New ppe.AjouterMedData()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AjouterMedData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AjouterMedData1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnnulerMed
        '
        Me.AnnulerMed.Location = New System.Drawing.Point(207, 233)
        Me.AnnulerMed.Name = "AnnulerMed"
        Me.AnnulerMed.Size = New System.Drawing.Size(101, 47)
        Me.AnnulerMed.TabIndex = 0
        Me.AnnulerMed.Text = "Annuler"
        Me.AnnulerMed.UseVisualStyleBackColor = True
        '
        'AjoutMed
        '
        Me.AjoutMed.Location = New System.Drawing.Point(261, 196)
        Me.AjoutMed.Name = "AjoutMed"
        Me.AjoutMed.Size = New System.Drawing.Size(227, 31)
        Me.AjoutMed.TabIndex = 1
        Me.AjoutMed.Text = "Ajouter un médicament"
        Me.AjoutMed.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODEMED_TextColumn, Me.NOMMEDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MEDICAMENTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(243, 178)
        Me.DataGridView1.TabIndex = 2
        '
        'updatetab
        '
        Me.updatetab.Location = New System.Drawing.Point(12, 196)
        Me.updatetab.Name = "updatetab"
        Me.updatetab.Size = New System.Drawing.Size(243, 31)
        Me.updatetab.TabIndex = 3
        Me.updatetab.Text = "Mettre à jour le tableau"
        Me.updatetab.UseVisualStyleBackColor = True
        '
        'labelcodemed
        '
        Me.labelcodemed.AutoSize = True
        Me.labelcodemed.Location = New System.Drawing.Point(269, 43)
        Me.labelcodemed.Name = "labelcodemed"
        Me.labelcodemed.Size = New System.Drawing.Size(113, 13)
        Me.labelcodemed.TabIndex = 4
        Me.labelcodemed.Text = "Code du médicament :"
        '
        'labelnommed
        '
        Me.labelnommed.AutoSize = True
        Me.labelnommed.Location = New System.Drawing.Point(269, 117)
        Me.labelnommed.Name = "labelnommed"
        Me.labelnommed.Size = New System.Drawing.Size(110, 13)
        Me.labelnommed.TabIndex = 5
        Me.labelnommed.Text = "Nom du médicament :"
        '
        'textcodemed
        '
        Me.textcodemed.Location = New System.Drawing.Point(388, 40)
        Me.textcodemed.Name = "textcodemed"
        Me.textcodemed.Size = New System.Drawing.Size(100, 20)
        Me.textcodemed.TabIndex = 6
        '
        'textnommed
        '
        Me.textnommed.Location = New System.Drawing.Point(388, 114)
        Me.textnommed.Name = "textnommed"
        Me.textnommed.Size = New System.Drawing.Size(100, 20)
        Me.textnommed.TabIndex = 7
        '
        'CODEMED_TextColumn
        '
        Me.CODEMED_TextColumn.DataPropertyName = "CODE_MED"
        Me.CODEMED_TextColumn.HeaderText = "CODE_MED"
        Me.CODEMED_TextColumn.MaxInputLength = 4
        Me.CODEMED_TextColumn.Name = "CODEMED_TextColumn"
        Me.CODEMED_TextColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'NOMMEDDataGridViewTextBoxColumn
        '
        Me.NOMMEDDataGridViewTextBoxColumn.DataPropertyName = "NOM_MED"
        Me.NOMMEDDataGridViewTextBoxColumn.HeaderText = "NOM_MED"
        Me.NOMMEDDataGridViewTextBoxColumn.Name = "NOMMEDDataGridViewTextBoxColumn"
        '
        'MEDICAMENTBindingSource
        '
        Me.MEDICAMENTBindingSource.DataMember = "MEDICAMENT"
        Me.MEDICAMENTBindingSource.DataSource = Me.AjouterMedData
        '
        'AjouterMedData
        '
        Me.AjouterMedData.DataSetName = "AjouterMedData"
        Me.AjouterMedData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICAMENTTableAdapter
        '
        Me.MEDICAMENTTableAdapter.ClearBeforeFill = True
        '
        'AjouterMedData1
        '
        Me.AjouterMedData1.DataSetName = "AjouterMedData"
        Me.AjouterMedData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AjouterMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(500, 307)
        Me.Controls.Add(Me.textnommed)
        Me.Controls.Add(Me.textcodemed)
        Me.Controls.Add(Me.labelnommed)
        Me.Controls.Add(Me.labelcodemed)
        Me.Controls.Add(Me.updatetab)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AjoutMed)
        Me.Controls.Add(Me.AnnulerMed)
        Me.Name = "AjouterMed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout d'un médicament"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AjouterMedData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AjouterMedData1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AnnulerMed As System.Windows.Forms.Button
    Friend WithEvents AjoutMed As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AjouterMedData As ppe.AjouterMedData
    Friend WithEvents MEDICAMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICAMENTTableAdapter As ppe.AjouterMedDataTableAdapters.MEDICAMENTTableAdapter
    Friend WithEvents CODEMED_TextColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMMEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents updatetab As System.Windows.Forms.Button
    Friend WithEvents AjouterMedData1 As ppe.AjouterMedData
    Friend WithEvents labelcodemed As System.Windows.Forms.Label
    Friend WithEvents labelnommed As System.Windows.Forms.Label
    Friend WithEvents textcodemed As System.Windows.Forms.TextBox
    Friend WithEvents textnommed As System.Windows.Forms.TextBox
End Class
