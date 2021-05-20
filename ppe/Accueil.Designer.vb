<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.GoFormulaire = New System.Windows.Forms.Button()
        Me.GoAfficher = New System.Windows.Forms.Button()
        Me.GoAjouter = New System.Windows.Forms.Button()
        Me.GoQuitter = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GoRDV = New System.Windows.Forms.Button()
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'GoFormulaire
        '
        Me.GoFormulaire.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoFormulaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoFormulaire.Location = New System.Drawing.Point(36, 52)
        Me.GoFormulaire.Name = "GoFormulaire"
        Me.GoFormulaire.Size = New System.Drawing.Size(171, 109)
        Me.GoFormulaire.TabIndex = 0
        Me.GoFormulaire.Text = "Formulaire"
        Me.GoFormulaire.UseVisualStyleBackColor = False
        '
        'GoAfficher
        '
        Me.GoAfficher.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoAfficher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoAfficher.Location = New System.Drawing.Point(245, 52)
        Me.GoAfficher.Name = "GoAfficher"
        Me.GoAfficher.Size = New System.Drawing.Size(171, 109)
        Me.GoAfficher.TabIndex = 1
        Me.GoAfficher.Text = "Afficher"
        Me.GoAfficher.UseVisualStyleBackColor = False
        '
        'GoAjouter
        '
        Me.GoAjouter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoAjouter.Location = New System.Drawing.Point(459, 52)
        Me.GoAjouter.Name = "GoAjouter"
        Me.GoAjouter.Size = New System.Drawing.Size(171, 109)
        Me.GoAjouter.TabIndex = 2
        Me.GoAjouter.Text = "Ajouter"
        Me.GoAjouter.UseVisualStyleBackColor = False
        '
        'GoQuitter
        '
        Me.GoQuitter.Location = New System.Drawing.Point(752, 176)
        Me.GoQuitter.Name = "GoQuitter"
        Me.GoQuitter.Size = New System.Drawing.Size(75, 23)
        Me.GoQuitter.TabIndex = 3
        Me.GoQuitter.Text = "Quitter"
        Me.GoQuitter.UseVisualStyleBackColor = True
        '
        'GoRDV
        '
        Me.GoRDV.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GoRDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoRDV.Location = New System.Drawing.Point(656, 52)
        Me.GoRDV.Name = "GoRDV"
        Me.GoRDV.Size = New System.Drawing.Size(171, 109)
        Me.GoRDV.TabIndex = 4
        Me.GoRDV.Text = "Prendre RDV"
        Me.GoRDV.UseVisualStyleBackColor = False
        '
        'ToolTip4
        '
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(839, 211)
        Me.Controls.Add(Me.GoRDV)
        Me.Controls.Add(Me.GoQuitter)
        Me.Controls.Add(Me.GoAjouter)
        Me.Controls.Add(Me.GoAfficher)
        Me.Controls.Add(Me.GoFormulaire)
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GoFormulaire As System.Windows.Forms.Button
    Friend WithEvents GoAfficher As System.Windows.Forms.Button
    Friend WithEvents GoAjouter As System.Windows.Forms.Button
    Friend WithEvents GoQuitter As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents GoRDV As System.Windows.Forms.Button
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip

End Class
