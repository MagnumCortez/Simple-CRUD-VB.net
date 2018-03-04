Public Class frmMain

    Public Conexao As New SQLConnMgr

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If (Not validarDados()) Then
            Return
        End If

        If (Conexao.Con.State = ConnectionState.Open) Then
            Dim sql As String

            If txtProduto.Tag = 0 Then
                sql = "INSERT INTO produtos (Nome, id_categoria, Preco) "
                sql = sql & "VALUES (@Name, @ID_Categoria, @Preco);"
            Else
                sql = "UPDATE produtos SET "
                sql = sql & "Nome = @Name, id_categoria = @ID_Categoria, Preco = @Preco "
                sql = sql & "WHERE id_produto = @ID_Produto;"
            End If

            Dim cmd As New SqlClient.SqlCommand(sql, Conexao.Con)
            cmd.Parameters.AddWithValue("@Name", txtProduto.Text)
            cmd.Parameters.AddWithValue("@ID_Categoria", cmbCategoria.SelectedItem("id_categoria"))
            cmd.Parameters.AddWithValue("@Preco", txtPreco.Text.Replace(".", "").Replace(",", "."))

            If txtProduto.Tag <> 0 Then
                cmd.Parameters.AddWithValue("@ID_Produto", txtProduto.Tag)
            End If

            If (cmd.ExecuteNonQuery()) Then
                MsgBox("Categoria salvo com sucesso!", MsgBoxStyle.Information, "Cadastro")
                clearProdutos()
                atualizarProdutos()
            End If

            Else
                MsgBox("Não foi possível conectar ao banco de dados!", MsgBoxStyle.Critical, "Erro de Conexão")
        End If
    End Sub

    Private Sub clearProdutos()
        txtProduto.Clear()
        txtProduto.Tag = 0
        cmbCategoria.SelectedIndex = -1
        lblCategoria.Text = "Categoria (0):"
        txtPreco.Clear()
        txtProduto.Focus()
    End Sub

    Private Function validarDados() As Boolean
        If (txtProduto.Text = "") Then
            MsgBox("Produto é de preenchimento obrigatorio", MsgBoxStyle.Information, "Validação")
            txtProduto.Focus()
            Return False
        End If

        If (cmbCategoria.SelectedIndex = -1) Then
            MsgBox("Categoria é de preenchimento obrigatorio", MsgBoxStyle.Information, "Validação")
            cmbCategoria.Focus()
            Return False
        End If

        If (txtPreco.Text = "") Then
            MsgBox("Preço é de preenchimento obrigatorio", MsgBoxStyle.Information, "Validação")
            txtPreco.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizarCategoria()
        atualizarProdutos()
        clearProdutos()

    End Sub

    Private Sub atualizarCategoria()
        Dim sql As String

        sql = "SELECT * FROM categorias ORDER BY nome"

        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(sql, Conexao.Con)
        da.Fill(ds, "categorias")

        With cmbCategoria
            .DataSource = ds.Tables("categorias")
            .DisplayMember = "Nome"
            .ValueMember = "Id_categoria"
        End With

    End Sub

    Private Sub atualizarProdutos()
        Dim sql As String

        sql = "SELECT "
        sql = sql & "   prod.id_produto, "
        sql = sql & "   prod.nome, "
        sql = sql & "   cat.nome AS categoria, "
        sql = sql & "   prod.preco "
        sql = sql & "FROM produtos AS prod "
        sql = sql & "INNER JOIN categorias AS cat ON "
        sql = sql & "   prod.id_categoria = cat.id_categoria "
        sql = sql & "ORDER BY prod.nome"

        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(sql, Conexao.Con)
        da.Fill(ds, "produtos")

        gridProdutos.DataSource = ds.Tables("produtos")

    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        If cmbCategoria.SelectedIndex > 0 Then
            lblCategoria.Text = "Categoria (" & cmbCategoria.SelectedItem(0) & "):"
            'Para pegar pode ser pelo index ou pelo nome da coluna. Ex:
            'txtNameCategory.Text = cmbCategoria.SelectedItem(1).ToString
            'txtNameCategory.Text = cmbCategoria.SelectedItem("Nome").ToString
        End If
    End Sub

    Private Sub gridProdutos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridProdutos.CellDoubleClick
        Dim index As Integer = e.RowIndex
        If (index >= 0) Then
            txtProduto.Tag = gridProdutos.Rows(index).Cells(0).Value
            txtProduto.Text = gridProdutos.Rows(index).Cells(1).Value
            cmbCategoria.Text = gridProdutos.Rows(index).Cells(2).Value
            txtPreco.Text = gridProdutos.Rows(index).Cells(3).Value
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        clearProdutos()
    End Sub

    Private Sub txtPreco_Leave(sender As Object, e As EventArgs) Handles txtPreco.Leave
        If txtPreco.Text = String.Empty Then
            txtPreco.Text = 0
        End If
        txtPreco.Text = FormatCurrency(txtPreco.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "").Trim
    End Sub
End Class
