Public Class AjouterRDV

    Dim MyConn As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String



    Private Sub AjouterRDV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' connection
        connString = "DSN=CNXORA07;Uid=sc_gsb;Pwd=estran;"
        MyConn.ConnectionString = connString
        Try
            MyConn.Open()
            'MessageBox.Show("Connexion Oracle OK")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        'selection des praticiens
        Dim select_pra As String = "SELECT RPPS, PRENOMPRATICIEN, NOMPRATICIEN FROM PRATICIEN"

        myCommand.Connection = MyConn
        myCommand.CommandText = select_pra
        myReader = myCommand.ExecuteReader
        While myReader.Read
            ComboBoxPra.Items.Add(myReader.GetString(1) & " " & myReader.GetString(2))
        End While
        myReader.Close()


    End Sub

    Private Sub ButtonRDV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRDV.Click

    End Sub

    Private Sub AnnulerMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnulerMed.Click
        If MessageBox.Show("Souhaitez vous vraiment annuler la prise de votre Rendez-Vous ?", "Annuler", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub
End Class
