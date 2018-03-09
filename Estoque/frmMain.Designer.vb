<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.gridProdutos = New System.Windows.Forms.DataGridView()
        Me.ckbDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblCategoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPreco)
        Me.GroupBox1.Controls.Add(Me.cmbCategoria)
        Me.GroupBox1.Controls.Add(Me.txtProduto)
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categorias"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(475, 40)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(72, 23)
        Me.btnLimpar.TabIndex = 8
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Preço:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(177, 26)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblCategoria.TabIndex = 6
        Me.lblCategoria.Text = "Categoria:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Produto:"
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(307, 42)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(81, 20)
        Me.txtPreco.TabIndex = 4
        Me.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(180, 42)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoria.TabIndex = 3
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(15, 43)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(159, 20)
        Me.txtProduto.TabIndex = 2
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(394, 40)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'gridProdutos
        '
        Me.gridProdutos.AllowUserToAddRows = False
        Me.gridProdutos.AllowUserToDeleteRows = False
        Me.gridProdutos.AllowUserToResizeRows = False
        Me.gridProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ckbDelete})
        Me.gridProdutos.Location = New System.Drawing.Point(12, 103)
        Me.gridProdutos.MultiSelect = False
        Me.gridProdutos.Name = "gridProdutos"
        Me.gridProdutos.RowHeadersVisible = False
        Me.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridProdutos.Size = New System.Drawing.Size(553, 150)
        Me.gridProdutos.TabIndex = 3
        '
        'ckbDelete
        '
        Me.ckbDelete.HeaderText = ""
        Me.ckbDelete.Name = "ckbDelete"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(261, 259)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Excluir"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 300)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.gridProdutos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Formulario Principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gridProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents gridProdutos As DataGridView
    Friend WithEvents btnLimpar As Button
    Friend WithEvents ckbDelete As DataGridViewCheckBoxColumn
    Friend WithEvents btnDelete As Button
End Class
