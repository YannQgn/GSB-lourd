Imports System.Windows.Forms
Public Class Accueil

    Dim MyConn As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        ' connection
        connString = "DSN=CNXORA07;Uid=sc_gsb;Pwd=estran;"
        MyConn.ConnectionString = connString
        Try
            MyConn.Open()
            'MessageBox.Show("Connexion Oracle OK")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        ' requête
        ' Dim select_med As String = "SELECT ID_MED  , PRENOM_MED , NOM_MED FROM MEDECIN"

        ' requête selection des médicaments
        ' Dim select_medicament As String = "SELECT LIB_MEDIC FROM MEDICAMENT"
        ' exécution de la requête pour les sélection des médecins
        ' myCommand.Connection = MyConn
        'myCommand.CommandText = select_med
        'myReader = myCommand.ExecuteReader
        'While myReader.Read
        '   Scrollbar.ValueMember = myReader.GetString(0)
        'End While
        'myReader.Close()

        ToolTip1.SetToolTip(GoFormulaire, "Formulaire de saisie")
        ToolTip2.SetToolTip(GoAfficher, "Afficher un compte rendu")
        ToolTip3.SetToolTip(GoAjouter, "Ajouter un nouveau médicament")
        ToolTip4.SetToolTip(GoRDV, "Prise d'un RDV")

    End Sub

    Private Sub GoFormulaire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoFormulaire.Click
        If MessageBox.Show("Souhaitez vous vraiment saisir un formulaire ?", "Formulaire de saisie", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            FormSaisie.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub GoAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoAfficher.Click
        If MessageBox.Show("Souhaitez vous vraiment afficher un compte rendu ?", "Affiche compte rendu", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            AfficheCompteRendu.Show()
        End If
    End Sub

    Private Sub GoAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoAjouter.Click
        If MessageBox.Show("Souhaitez vous vraiment ajouter un médicament ?", "Ajout d'un médicament", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            AjouterMed.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub GoQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoQuitter.Click
        If MessageBox.Show("Souhaitez vous vraiment quitter l'application ?", "Quitter", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub GoRDV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoRDV.Click
        If MessageBox.Show("Souhaitez vous prendre un RDV ?", "Prise d'un RDV", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            AjouterRDV.Show()
            Me.Visible = False
        End If
    End Sub

End Class
