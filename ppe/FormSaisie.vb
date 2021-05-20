Public Class FormSaisie

    Dim MyConn As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '------------------CONNEXION---------------------'
        connString = "DSN=CNXORA07;Uid=sc_gsb;Pwd=estran;"  '
        MyConn.ConnectionString = connString             '
        Try                                              '
            MyConn.Open()                                '
            'MessageBox.Show("Connexion Oracle OK")       '
        Catch ex As Odbc.OdbcException                   '
            MessageBox.Show(ex.Message)                  '
        End Try                                          '
        '------------------------------------------------'

        ' requête
        Dim select_med As String = "SELECT ID_MED  , PRENOM_MED , NOM_MED FROM MEDECIN"

        ' requête selection des médicaments
        'Dim select_medicament As String = "SELECT LIB_MEDIC FROM MEDICAMENT"

        ' exécution de la requête pour les sélection des médecins
        'myCommand.Connection = MyConn
        'myCommand.CommandText = select_med
        'myReader = myCommand.ExecuteReader
        'While myReader.Read
        '   Scrollbar.ValueMember = myReader.GetString(0)
        'End While
        'myReader.Close()

        med_presente1.MultiColumn = True
        labelheure.Text = TimeOfDay
    End Sub

    Private Sub Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Annuler.Click
        If MessageBox.Show("Souhaitez vous vraiment annuler la saisie du formulaire ?", "Annuler", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub



    Private Sub CheckedListBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.med_presente1.Items.Add("Médicament")
  
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        motifvisite1.Text = heurevisite1.Text
    End Sub
End Class