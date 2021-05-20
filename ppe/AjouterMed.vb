Public Class AjouterMed

    Dim MyConn As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim med_id_ajout As String
    Dim med_nom_ajout As String
    Dim sSql As String = "INSERT INTO MEDICAMENT (CODE_MED,NOM_MED) VALUES (@code_med, @nom_med)"

    Private Sub AjouterMed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AjouterMedData.MEDICAMENT' table. You can move, or remove it, as needed.
        Me.MEDICAMENTTableAdapter.Fill(Me.AjouterMedData.MEDICAMENT)

        '------------------CONNEXION---------------------'
        connString = "DSN=CNXORA07;Uid=SC_GSB;Pwd=estran;"
        MyConn.ConnectionString = connString             '
        'Try                                             '
        'MyConn.Open()                                   '
        ' MessageBox.Show("Connexion Oracle OK")         '
        'Catch ex As Odbc.OdbcException                  '
        ' MessageBox.Show(ex.Message)                    '
        ' End Try                                        '
        '------------------------------------------------'

        myCommand.Connection = MyConn
        myCommand.CommandText = "INSERT INTO MEDICAMENT(CODE_MED,NOM_MED) VALUES ([med_id_ajout],[med_nom_ajout]);"
    End Sub

   
    Private Sub AnnulerMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnulerMed.Click
        If MessageBox.Show("Souhaitez vous vraiment annuler l'ajout de votre médicament ?", "Annuler", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private Sub AjoutMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjoutMed.Click
        ' med_id_ajout = DataGridView1.CurrentRow.Cells(0).Value
        'med_nom_ajout = DataGridView1.CurrentRow.Cells(1).Value
        'MsgBox(DataGridView1.CurrentRow.Cells(1).Value.ToString)
        med_id_ajout = textcodemed.Text
        med_nom_ajout = textnommed.Text

        If MessageBox.Show("Souhaitez vous vraiment confirmer l'ajout de votre médicament ?", "Annuler", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Médicament ajouté")
        End If
    End Sub

    Private Sub textcodemed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textcodemed.TextChanged

    End Sub


    Private Sub textcodemed_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles textcodemed.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textnommed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textnommed.TextChanged
        
    End Sub

    Private Sub textnommed_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles textnommed.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'curRow = DataGridView1.CurrentRow.Index
        ' col1 = DataGridView1.Item(0, curRow).Value
        'col2 = DataGridView1.Item(1, curRow).Value
        ' col3 = DataGridView1.Item(2, curRow).Value
        'col4 = DataGridView1.Item(3, curRow).Value
        'col5 = DataGridView1.Item(4, curRow).Value
        'col6 = DataGridView1.Item(5, curRow).Value
        ' col7 = DataGridView1.Item(6, curRow).Value
        ' col8 = DataGridView1.Item(7, curRow).Value
    End Sub
End Class