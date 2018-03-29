<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnpesquisaPRO = New System.Windows.Forms.Button()
        Me.btnnovaPRO = New System.Windows.Forms.Button()
        Me.labelNmrPRO = New System.Windows.Forms.Label()
        Me.TextnroPRO = New System.Windows.Forms.TextBox()
        Me.LabelNomeCliente = New System.Windows.Forms.Label()
        Me.TextNomeCliente = New System.Windows.Forms.TextBox()
        Me.frmEsquadrias = New System.Windows.Forms.GroupBox()
        Me.LabelMarkup = New System.Windows.Forms.Label()
        Me.TextVlMarkup = New System.Windows.Forms.TextBox()
        Me.btnAlterarCusto = New System.Windows.Forms.Button()
        Me.LabelDescEsqCompra = New System.Windows.Forms.Label()
        Me.TextDescEsqCompra = New System.Windows.Forms.TextBox()
        Me.TextNumPRO_semVidro = New System.Windows.Forms.TextBox()
        Me.LabelPROsemVidro = New System.Windows.Forms.Label()
        Me.TextCustoEsq = New System.Windows.Forms.TextBox()
        Me.LabelCustoEsq = New System.Windows.Forms.Label()
        Me.TextVendaEsq = New System.Windows.Forms.TextBox()
        Me.LabelVendaEsq = New System.Windows.Forms.Label()
        Me.frmInstalação = New System.Windows.Forms.GroupBox()
        Me.txtDescInstal = New System.Windows.Forms.TextBox()
        Me.LabelDescInstal = New System.Windows.Forms.Label()
        Me.txtinstalFora = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbInst = New System.Windows.Forms.ComboBox()
        Me.txtMetInst = New System.Windows.Forms.TextBox()
        Me.LabelInstalFora = New System.Windows.Forms.Label()
        Me.LabelTipoVidro = New System.Windows.Forms.Label()
        Me.LabelMetragemVidros = New System.Windows.Forms.Label()
        Me.TextMetVidros = New System.Windows.Forms.TextBox()
        Me.cmbListaVidros = New System.Windows.Forms.ComboBox()
        Me.btnAdiconarVidros = New System.Windows.Forms.Button()
        Me.btnRemoverVidros = New System.Windows.Forms.Button()
        Me.LabelMetragemTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextMetVidroTotal = New System.Windows.Forms.TextBox()
        Me.LabelDescVidro = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextDescVidro = New System.Windows.Forms.TextBox()
        Me.frmVidros = New System.Windows.Forms.GroupBox()
        Me.txtObsservacoes = New System.Windows.Forms.RichTextBox()
        Me.labelValorCliente = New System.Windows.Forms.Label()
        Me.txtValorInicial = New System.Windows.Forms.TextBox()
        Me.LabelNota = New System.Windows.Forms.Label()
        Me.LabelVendedor = New System.Windows.Forms.Label()
        Me.txtDescProCliente = New System.Windows.Forms.TextBox()
        Me.LabelDescProCliente = New System.Windows.Forms.Label()
        Me.txtValorFechado = New System.Windows.Forms.TextBox()
        Me.LabelValorFechado = New System.Windows.Forms.Label()
        Me.optDescPerc = New System.Windows.Forms.RadioButton()
        Me.optDescValor = New System.Windows.Forms.RadioButton()
        Me.cbmNota = New System.Windows.Forms.ComboBox()
        Me.cbmVendedor = New System.Windows.Forms.ComboBox()
        Me.LabelEspecificador = New System.Windows.Forms.Label()
        Me.cbmEspecificador = New System.Windows.Forms.ComboBox()
        Me.cmbFPagto = New System.Windows.Forms.ComboBox()
        Me.LabelFPagto = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.LabelEntrada = New System.Windows.Forms.Label()
        Me.LabelParcelas = New System.Windows.Forms.Label()
        Me.cbmQParcelas = New System.Windows.Forms.ComboBox()
        Me.frmResumo = New System.Windows.Forms.GroupBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelInstalacao = New System.Windows.Forms.Label()
        Me.LabelVidros = New System.Windows.Forms.Label()
        Me.LabelEsquadrias = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.LabelDataDaCriacao = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnAdicionarNegocio = New System.Windows.Forms.Button()
        Me.btnRemoverNegocio = New System.Windows.Forms.Button()
        Me.optCusto = New System.Windows.Forms.RadioButton()
        Me.optMkup = New System.Windows.Forms.RadioButton()
        Me.LabelResEsq = New System.Windows.Forms.Label()
        Me.LabelResVidro = New System.Windows.Forms.Label()
        Me.LabelVLResutlInstal = New System.Windows.Forms.Label()
        Me.LabelTotalGeral = New System.Windows.Forms.Label()
        Me.LabelMkpTotal = New System.Windows.Forms.Label()
        Me.LabelMkpInst = New System.Windows.Forms.Label()
        Me.LabelMkpVidro = New System.Windows.Forms.Label()
        Me.LabelMkpEsq = New System.Windows.Forms.Label()
        Me.LabelMkpInstCliente = New System.Windows.Forms.Label()
        Me.LabelMkpVidroCli = New System.Windows.Forms.Label()
        Me.LabelEsqCliente = New System.Windows.Forms.Label()
        Me.LabelMkpCliente = New System.Windows.Forms.Label()
        Me.LabelDescTotal = New System.Windows.Forms.Label()
        Me.LabelFinalCliente = New System.Windows.Forms.Label()
        Me.LabelMetroQuad = New System.Windows.Forms.Label()
        Me.LabelDataCriacao = New System.Windows.Forms.Label()
        Me.LabelDescFabrica = New System.Windows.Forms.Label()
        Me.LabelDtAlteracao = New System.Windows.Forms.Label()
        Me.frmEsquadrias.SuspendLayout()
        Me.frmInstalação.SuspendLayout()
        Me.frmVidros.SuspendLayout()
        Me.frmResumo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnpesquisaPRO
        '
        Me.btnpesquisaPRO.Location = New System.Drawing.Point(13, 13)
        Me.btnpesquisaPRO.Name = "btnpesquisaPRO"
        Me.btnpesquisaPRO.Size = New System.Drawing.Size(90, 33)
        Me.btnpesquisaPRO.TabIndex = 0
        Me.btnpesquisaPRO.Text = "Pesquisa PRO"
        Me.btnpesquisaPRO.UseVisualStyleBackColor = True
        '
        'btnnovaPRO
        '
        Me.btnnovaPRO.Location = New System.Drawing.Point(109, 13)
        Me.btnnovaPRO.Name = "btnnovaPRO"
        Me.btnnovaPRO.Size = New System.Drawing.Size(90, 33)
        Me.btnnovaPRO.TabIndex = 1
        Me.btnnovaPRO.Text = "Nova Proposta"
        Me.btnnovaPRO.UseVisualStyleBackColor = True
        '
        'labelNmrPRO
        '
        Me.labelNmrPRO.AutoSize = True
        Me.labelNmrPRO.Location = New System.Drawing.Point(13, 53)
        Me.labelNmrPRO.Name = "labelNmrPRO"
        Me.labelNmrPRO.Size = New System.Drawing.Size(51, 13)
        Me.labelNmrPRO.TabIndex = 2
        Me.labelNmrPRO.Text = "PRO 823"
        '
        'TextnroPRO
        '
        Me.TextnroPRO.Location = New System.Drawing.Point(71, 53)
        Me.TextnroPRO.Name = "TextnroPRO"
        Me.TextnroPRO.Size = New System.Drawing.Size(128, 20)
        Me.TextnroPRO.TabIndex = 3
        '
        'LabelNomeCliente
        '
        Me.LabelNomeCliente.AutoSize = True
        Me.LabelNomeCliente.Location = New System.Drawing.Point(205, 56)
        Me.LabelNomeCliente.Name = "LabelNomeCliente"
        Me.LabelNomeCliente.Size = New System.Drawing.Size(85, 13)
        Me.LabelNomeCliente.TabIndex = 4
        Me.LabelNomeCliente.Text = "Nome do Cliente"
        '
        'TextNomeCliente
        '
        Me.TextNomeCliente.Location = New System.Drawing.Point(296, 53)
        Me.TextNomeCliente.Name = "TextNomeCliente"
        Me.TextNomeCliente.Size = New System.Drawing.Size(170, 20)
        Me.TextNomeCliente.TabIndex = 5
        '
        'frmEsquadrias
        '
        Me.frmEsquadrias.Controls.Add(Me.optCusto)
        Me.frmEsquadrias.Controls.Add(Me.optMkup)
        Me.frmEsquadrias.Controls.Add(Me.LabelMarkup)
        Me.frmEsquadrias.Controls.Add(Me.TextVlMarkup)
        Me.frmEsquadrias.Controls.Add(Me.btnAlterarCusto)
        Me.frmEsquadrias.Controls.Add(Me.LabelDescEsqCompra)
        Me.frmEsquadrias.Controls.Add(Me.TextDescEsqCompra)
        Me.frmEsquadrias.Controls.Add(Me.TextNumPRO_semVidro)
        Me.frmEsquadrias.Controls.Add(Me.LabelPROsemVidro)
        Me.frmEsquadrias.Controls.Add(Me.TextCustoEsq)
        Me.frmEsquadrias.Controls.Add(Me.LabelCustoEsq)
        Me.frmEsquadrias.Controls.Add(Me.TextVendaEsq)
        Me.frmEsquadrias.Controls.Add(Me.LabelVendaEsq)
        Me.frmEsquadrias.Location = New System.Drawing.Point(13, 105)
        Me.frmEsquadrias.Name = "frmEsquadrias"
        Me.frmEsquadrias.Size = New System.Drawing.Size(453, 132)
        Me.frmEsquadrias.TabIndex = 6
        Me.frmEsquadrias.TabStop = False
        Me.frmEsquadrias.Text = "Esquadrias"
        '
        'LabelMarkup
        '
        Me.LabelMarkup.AutoSize = True
        Me.LabelMarkup.Location = New System.Drawing.Point(289, 101)
        Me.LabelMarkup.Name = "LabelMarkup"
        Me.LabelMarkup.Size = New System.Drawing.Size(40, 13)
        Me.LabelMarkup.TabIndex = 13
        Me.LabelMarkup.Text = "Makup"
        '
        'TextVlMarkup
        '
        Me.TextVlMarkup.Location = New System.Drawing.Point(335, 98)
        Me.TextVlMarkup.Name = "TextVlMarkup"
        Me.TextVlMarkup.Size = New System.Drawing.Size(97, 20)
        Me.TextVlMarkup.TabIndex = 14
        '
        'btnAlterarCusto
        '
        Me.btnAlterarCusto.Location = New System.Drawing.Point(19, 88)
        Me.btnAlterarCusto.Name = "btnAlterarCusto"
        Me.btnAlterarCusto.Size = New System.Drawing.Size(90, 33)
        Me.btnAlterarCusto.TabIndex = 12
        Me.btnAlterarCusto.Text = "Alterar Custo"
        Me.btnAlterarCusto.UseVisualStyleBackColor = True
        '
        'LabelDescEsqCompra
        '
        Me.LabelDescEsqCompra.AutoSize = True
        Me.LabelDescEsqCompra.Location = New System.Drawing.Point(200, 58)
        Me.LabelDescEsqCompra.Name = "LabelDescEsqCompra"
        Me.LabelDescEsqCompra.Size = New System.Drawing.Size(77, 13)
        Me.LabelDescEsqCompra.TabIndex = 9
        Me.LabelDescEsqCompra.Text = "DESC. Fábrica"
        '
        'TextDescEsqCompra
        '
        Me.TextDescEsqCompra.Location = New System.Drawing.Point(292, 51)
        Me.TextDescEsqCompra.Name = "TextDescEsqCompra"
        Me.TextDescEsqCompra.Size = New System.Drawing.Size(97, 20)
        Me.TextDescEsqCompra.TabIndex = 10
        '
        'TextNumPRO_semVidro
        '
        Me.TextNumPRO_semVidro.Location = New System.Drawing.Point(292, 14)
        Me.TextNumPRO_semVidro.Name = "TextNumPRO_semVidro"
        Me.TextNumPRO_semVidro.Size = New System.Drawing.Size(140, 20)
        Me.TextNumPRO_semVidro.TabIndex = 8
        '
        'LabelPROsemVidro
        '
        Me.LabelPROsemVidro.AutoSize = True
        Me.LabelPROsemVidro.Location = New System.Drawing.Point(205, 17)
        Me.LabelPROsemVidro.Name = "LabelPROsemVidro"
        Me.LabelPROsemVidro.Size = New System.Drawing.Size(81, 26)
        Me.LabelPROsemVidro.TabIndex = 7
        Me.LabelPROsemVidro.Text = "PRO sem vidro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRO823"
        '
        'TextCustoEsq
        '
        Me.TextCustoEsq.Location = New System.Drawing.Point(89, 55)
        Me.TextCustoEsq.Name = "TextCustoEsq"
        Me.TextCustoEsq.Size = New System.Drawing.Size(97, 20)
        Me.TextCustoEsq.TabIndex = 6
        '
        'LabelCustoEsq
        '
        Me.LabelCustoEsq.AutoSize = True
        Me.LabelCustoEsq.Location = New System.Drawing.Point(7, 58)
        Me.LabelCustoEsq.Name = "LabelCustoEsq"
        Me.LabelCustoEsq.Size = New System.Drawing.Size(70, 13)
        Me.LabelCustoEsq.TabIndex = 5
        Me.LabelCustoEsq.Text = "Custo e-claris"
        '
        'TextVendaEsq
        '
        Me.TextVendaEsq.Location = New System.Drawing.Point(89, 17)
        Me.TextVendaEsq.Name = "TextVendaEsq"
        Me.TextVendaEsq.Size = New System.Drawing.Size(97, 20)
        Me.TextVendaEsq.TabIndex = 4
        '
        'LabelVendaEsq
        '
        Me.LabelVendaEsq.AutoSize = True
        Me.LabelVendaEsq.Location = New System.Drawing.Point(7, 20)
        Me.LabelVendaEsq.Name = "LabelVendaEsq"
        Me.LabelVendaEsq.Size = New System.Drawing.Size(76, 13)
        Me.LabelVendaEsq.TabIndex = 0
        Me.LabelVendaEsq.Text = "R$ Sem vidros"
        '
        'frmInstalação
        '
        Me.frmInstalação.Controls.Add(Me.txtDescInstal)
        Me.frmInstalação.Controls.Add(Me.LabelDescInstal)
        Me.frmInstalação.Controls.Add(Me.txtinstalFora)
        Me.frmInstalação.Controls.Add(Me.Label14)
        Me.frmInstalação.Controls.Add(Me.Label15)
        Me.frmInstalação.Controls.Add(Me.TextBox12)
        Me.frmInstalação.Controls.Add(Me.Label16)
        Me.frmInstalação.Controls.Add(Me.Label17)
        Me.frmInstalação.Controls.Add(Me.cmbInst)
        Me.frmInstalação.Controls.Add(Me.txtMetInst)
        Me.frmInstalação.Controls.Add(Me.LabelInstalFora)
        Me.frmInstalação.Location = New System.Drawing.Point(12, 479)
        Me.frmInstalação.Name = "frmInstalação"
        Me.frmInstalação.Size = New System.Drawing.Size(454, 74)
        Me.frmInstalação.TabIndex = 8
        Me.frmInstalação.TabStop = False
        Me.frmInstalação.Text = "Instalação "
        '
        'txtDescInstal
        '
        Me.txtDescInstal.Location = New System.Drawing.Point(378, 20)
        Me.txtDescInstal.Name = "txtDescInstal"
        Me.txtDescInstal.Size = New System.Drawing.Size(55, 20)
        Me.txtDescInstal.TabIndex = 24
        '
        'LabelDescInstal
        '
        Me.LabelDescInstal.AutoSize = True
        Me.LabelDescInstal.Location = New System.Drawing.Point(278, 22)
        Me.LabelDescInstal.Name = "LabelDescInstal"
        Me.LabelDescInstal.Size = New System.Drawing.Size(87, 13)
        Me.LabelDescInstal.TabIndex = 23
        Me.LabelDescInstal.Text = "Desc. Instalação"
        '
        'txtinstalFora
        '
        Me.txtinstalFora.Location = New System.Drawing.Point(196, 45)
        Me.txtinstalFora.Name = "txtinstalFora"
        Me.txtinstalFora.Size = New System.Drawing.Size(55, 20)
        Me.txtinstalFora.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(305, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(218, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Desconto Compra"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(97, 198)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(98, 201)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 201)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Metragem Total"
        '
        'cmbInst
        '
        Me.cmbInst.FormattingEnabled = True
        Me.cmbInst.Location = New System.Drawing.Point(14, 19)
        Me.cmbInst.Name = "cmbInst"
        Me.cmbInst.Size = New System.Drawing.Size(165, 21)
        Me.cmbInst.TabIndex = 8
        '
        'txtMetInst
        '
        Me.txtMetInst.Location = New System.Drawing.Point(196, 19)
        Me.txtMetInst.Name = "txtMetInst"
        Me.txtMetInst.Size = New System.Drawing.Size(55, 20)
        Me.txtMetInst.TabIndex = 8
        '
        'LabelInstalFora
        '
        Me.LabelInstalFora.AutoSize = True
        Me.LabelInstalFora.Location = New System.Drawing.Point(113, 45)
        Me.LabelInstalFora.Name = "LabelInstalFora"
        Me.LabelInstalFora.Size = New System.Drawing.Size(77, 13)
        Me.LabelInstalFora.TabIndex = 7
        Me.LabelInstalFora.Text = "Instalação fora"
        '
        'LabelTipoVidro
        '
        Me.LabelTipoVidro.AutoSize = True
        Me.LabelTipoVidro.Location = New System.Drawing.Point(16, 17)
        Me.LabelTipoVidro.Name = "LabelTipoVidro"
        Me.LabelTipoVidro.Size = New System.Drawing.Size(75, 13)
        Me.LabelTipoVidro.TabIndex = 0
        Me.LabelTipoVidro.Text = "Tipo de Vidros"
        '
        'LabelMetragemVidros
        '
        Me.LabelMetragemVidros.AutoSize = True
        Me.LabelMetragemVidros.Location = New System.Drawing.Point(223, 17)
        Me.LabelMetragemVidros.Name = "LabelMetragemVidros"
        Me.LabelMetragemVidros.Size = New System.Drawing.Size(54, 13)
        Me.LabelMetragemVidros.TabIndex = 7
        Me.LabelMetragemVidros.Text = "Metragem"
        '
        'TextMetVidros
        '
        Me.TextMetVidros.Location = New System.Drawing.Point(222, 33)
        Me.TextMetVidros.Name = "TextMetVidros"
        Me.TextMetVidros.Size = New System.Drawing.Size(55, 20)
        Me.TextMetVidros.TabIndex = 8
        '
        'cmbListaVidros
        '
        Me.cmbListaVidros.FormattingEnabled = True
        Me.cmbListaVidros.Location = New System.Drawing.Point(10, 33)
        Me.cmbListaVidros.Name = "cmbListaVidros"
        Me.cmbListaVidros.Size = New System.Drawing.Size(206, 21)
        Me.cmbListaVidros.TabIndex = 8
        '
        'btnAdiconarVidros
        '
        Me.btnAdiconarVidros.Location = New System.Drawing.Point(304, 33)
        Me.btnAdiconarVidros.Name = "btnAdiconarVidros"
        Me.btnAdiconarVidros.Size = New System.Drawing.Size(61, 23)
        Me.btnAdiconarVidros.TabIndex = 15
        Me.btnAdiconarVidros.Text = "Adicionar"
        Me.btnAdiconarVidros.UseVisualStyleBackColor = True
        '
        'btnRemoverVidros
        '
        Me.btnRemoverVidros.Location = New System.Drawing.Point(371, 33)
        Me.btnRemoverVidros.Name = "btnRemoverVidros"
        Me.btnRemoverVidros.Size = New System.Drawing.Size(61, 23)
        Me.btnRemoverVidros.TabIndex = 16
        Me.btnRemoverVidros.Text = "Remover"
        Me.btnRemoverVidros.UseVisualStyleBackColor = True
        '
        'LabelMetragemTotal
        '
        Me.LabelMetragemTotal.AutoSize = True
        Me.LabelMetragemTotal.Location = New System.Drawing.Point(11, 201)
        Me.LabelMetragemTotal.Name = "LabelMetragemTotal"
        Me.LabelMetragemTotal.Size = New System.Drawing.Size(81, 13)
        Me.LabelMetragemTotal.TabIndex = 17
        Me.LabelMetragemTotal.Text = "Metragem Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 18
        '
        'TextMetVidroTotal
        '
        Me.TextMetVidroTotal.Location = New System.Drawing.Point(97, 198)
        Me.TextMetVidroTotal.Name = "TextMetVidroTotal"
        Me.TextMetVidroTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextMetVidroTotal.TabIndex = 19
        '
        'LabelDescVidro
        '
        Me.LabelDescVidro.AutoSize = True
        Me.LabelDescVidro.Location = New System.Drawing.Point(218, 201)
        Me.LabelDescVidro.Name = "LabelDescVidro"
        Me.LabelDescVidro.Size = New System.Drawing.Size(92, 13)
        Me.LabelDescVidro.TabIndex = 20
        Me.LabelDescVidro.Text = "Desconto Compra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(305, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 21
        '
        'TextDescVidro
        '
        Me.TextDescVidro.Location = New System.Drawing.Point(316, 201)
        Me.TextDescVidro.Name = "TextDescVidro"
        Me.TextDescVidro.Size = New System.Drawing.Size(100, 20)
        Me.TextDescVidro.TabIndex = 22
        '
        'frmVidros
        '
        Me.frmVidros.Controls.Add(Me.TextDescVidro)
        Me.frmVidros.Controls.Add(Me.Label11)
        Me.frmVidros.Controls.Add(Me.LabelDescVidro)
        Me.frmVidros.Controls.Add(Me.TextMetVidroTotal)
        Me.frmVidros.Controls.Add(Me.Label9)
        Me.frmVidros.Controls.Add(Me.LabelMetragemTotal)
        Me.frmVidros.Controls.Add(Me.btnRemoverVidros)
        Me.frmVidros.Controls.Add(Me.btnAdiconarVidros)
        Me.frmVidros.Controls.Add(Me.cmbListaVidros)
        Me.frmVidros.Controls.Add(Me.TextMetVidros)
        Me.frmVidros.Controls.Add(Me.LabelMetragemVidros)
        Me.frmVidros.Controls.Add(Me.LabelTipoVidro)
        Me.frmVidros.Location = New System.Drawing.Point(13, 243)
        Me.frmVidros.Name = "frmVidros"
        Me.frmVidros.Size = New System.Drawing.Size(454, 234)
        Me.frmVidros.TabIndex = 7
        Me.frmVidros.TabStop = False
        Me.frmVidros.Text = "Vidros"
        '
        'txtObsservacoes
        '
        Me.txtObsservacoes.Location = New System.Drawing.Point(13, 559)
        Me.txtObsservacoes.Name = "txtObsservacoes"
        Me.txtObsservacoes.Size = New System.Drawing.Size(453, 96)
        Me.txtObsservacoes.TabIndex = 10
        Me.txtObsservacoes.Text = "OBSERVAÇÕES:"
        '
        'labelValorCliente
        '
        Me.labelValorCliente.AutoSize = True
        Me.labelValorCliente.Location = New System.Drawing.Point(496, 13)
        Me.labelValorCliente.Name = "labelValorCliente"
        Me.labelValorCliente.Size = New System.Drawing.Size(99, 13)
        Me.labelValorCliente.TabIndex = 11
        Me.labelValorCliente.Text = "Valor para o Cliente"
        '
        'txtValorInicial
        '
        Me.txtValorInicial.Location = New System.Drawing.Point(607, 6)
        Me.txtValorInicial.Name = "txtValorInicial"
        Me.txtValorInicial.Size = New System.Drawing.Size(125, 20)
        Me.txtValorInicial.TabIndex = 12
        '
        'LabelNota
        '
        Me.LabelNota.AutoSize = True
        Me.LabelNota.Location = New System.Drawing.Point(782, 88)
        Me.LabelNota.Name = "LabelNota"
        Me.LabelNota.Size = New System.Drawing.Size(30, 13)
        Me.LabelNota.TabIndex = 13
        Me.LabelNota.Text = "Nota"
        '
        'LabelVendedor
        '
        Me.LabelVendedor.AutoSize = True
        Me.LabelVendedor.Location = New System.Drawing.Point(496, 131)
        Me.LabelVendedor.Name = "LabelVendedor"
        Me.LabelVendedor.Size = New System.Drawing.Size(53, 13)
        Me.LabelVendedor.TabIndex = 15
        Me.LabelVendedor.Text = "Vendedor"
        '
        'txtDescProCliente
        '
        Me.txtDescProCliente.Location = New System.Drawing.Point(607, 37)
        Me.txtDescProCliente.Name = "txtDescProCliente"
        Me.txtDescProCliente.Size = New System.Drawing.Size(125, 20)
        Me.txtDescProCliente.TabIndex = 18
        '
        'LabelDescProCliente
        '
        Me.LabelDescProCliente.AutoSize = True
        Me.LabelDescProCliente.Location = New System.Drawing.Point(496, 40)
        Me.LabelDescProCliente.Name = "LabelDescProCliente"
        Me.LabelDescProCliente.Size = New System.Drawing.Size(48, 13)
        Me.LabelDescProCliente.TabIndex = 17
        Me.LabelDescProCliente.Text = "Deconto"
        '
        'txtValorFechado
        '
        Me.txtValorFechado.Location = New System.Drawing.Point(607, 85)
        Me.txtValorFechado.Name = "txtValorFechado"
        Me.txtValorFechado.Size = New System.Drawing.Size(125, 20)
        Me.txtValorFechado.TabIndex = 20
        '
        'LabelValorFechado
        '
        Me.LabelValorFechado.AutoSize = True
        Me.LabelValorFechado.Location = New System.Drawing.Point(496, 92)
        Me.LabelValorFechado.Name = "LabelValorFechado"
        Me.LabelValorFechado.Size = New System.Drawing.Size(64, 13)
        Me.LabelValorFechado.TabIndex = 19
        Me.LabelValorFechado.Text = "Valor liquido"
        '
        'optDescPerc
        '
        Me.optDescPerc.AutoSize = True
        Me.optDescPerc.Location = New System.Drawing.Point(757, 29)
        Me.optDescPerc.Name = "optDescPerc"
        Me.optDescPerc.Size = New System.Drawing.Size(93, 17)
        Me.optDescPerc.TabIndex = 21
        Me.optDescPerc.TabStop = True
        Me.optDescPerc.Text = "Em percentual"
        Me.optDescPerc.UseVisualStyleBackColor = True
        '
        'optDescValor
        '
        Me.optDescValor.AutoSize = True
        Me.optDescValor.Location = New System.Drawing.Point(757, 53)
        Me.optDescValor.Name = "optDescValor"
        Me.optDescValor.Size = New System.Drawing.Size(66, 17)
        Me.optDescValor.TabIndex = 22
        Me.optDescValor.TabStop = True
        Me.optDescValor.Text = "Em valor"
        Me.optDescValor.UseVisualStyleBackColor = True
        '
        'cbmNota
        '
        Me.cbmNota.FormattingEnabled = True
        Me.cbmNota.Location = New System.Drawing.Point(829, 84)
        Me.cbmNota.Name = "cbmNota"
        Me.cbmNota.Size = New System.Drawing.Size(79, 21)
        Me.cbmNota.TabIndex = 23
        '
        'cbmVendedor
        '
        Me.cbmVendedor.FormattingEnabled = True
        Me.cbmVendedor.Location = New System.Drawing.Point(607, 128)
        Me.cbmVendedor.Name = "cbmVendedor"
        Me.cbmVendedor.Size = New System.Drawing.Size(301, 21)
        Me.cbmVendedor.TabIndex = 24
        '
        'LabelEspecificador
        '
        Me.LabelEspecificador.AutoSize = True
        Me.LabelEspecificador.Location = New System.Drawing.Point(496, 160)
        Me.LabelEspecificador.Name = "LabelEspecificador"
        Me.LabelEspecificador.Size = New System.Drawing.Size(71, 13)
        Me.LabelEspecificador.TabIndex = 25
        Me.LabelEspecificador.Text = "Especificador"
        '
        'cbmEspecificador
        '
        Me.cbmEspecificador.FormattingEnabled = True
        Me.cbmEspecificador.Location = New System.Drawing.Point(607, 156)
        Me.cbmEspecificador.Name = "cbmEspecificador"
        Me.cbmEspecificador.Size = New System.Drawing.Size(301, 21)
        Me.cbmEspecificador.TabIndex = 26
        '
        'cmbFPagto
        '
        Me.cmbFPagto.FormattingEnabled = True
        Me.cmbFPagto.Location = New System.Drawing.Point(607, 186)
        Me.cmbFPagto.Name = "cmbFPagto"
        Me.cmbFPagto.Size = New System.Drawing.Size(301, 21)
        Me.cmbFPagto.TabIndex = 28
        '
        'LabelFPagto
        '
        Me.LabelFPagto.AutoSize = True
        Me.LabelFPagto.Location = New System.Drawing.Point(496, 189)
        Me.LabelFPagto.Name = "LabelFPagto"
        Me.LabelFPagto.Size = New System.Drawing.Size(108, 13)
        Me.LabelFPagto.TabIndex = 27
        Me.LabelFPagto.Text = "Forma de Pagamento"
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(607, 217)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(91, 20)
        Me.txtEntrada.TabIndex = 30
        '
        'LabelEntrada
        '
        Me.LabelEntrada.AutoSize = True
        Me.LabelEntrada.Location = New System.Drawing.Point(496, 220)
        Me.LabelEntrada.Name = "LabelEntrada"
        Me.LabelEntrada.Size = New System.Drawing.Size(71, 13)
        Me.LabelEntrada.TabIndex = 29
        Me.LabelEntrada.Text = "Valor Entrada"
        '
        'LabelParcelas
        '
        Me.LabelParcelas.AutoSize = True
        Me.LabelParcelas.Location = New System.Drawing.Point(714, 219)
        Me.LabelParcelas.Name = "LabelParcelas"
        Me.LabelParcelas.Size = New System.Drawing.Size(65, 13)
        Me.LabelParcelas.TabIndex = 31
        Me.LabelParcelas.Text = "Qt. Parcelas"
        '
        'cbmQParcelas
        '
        Me.cbmQParcelas.FormattingEnabled = True
        Me.cbmQParcelas.Location = New System.Drawing.Point(795, 216)
        Me.cbmQParcelas.Name = "cbmQParcelas"
        Me.cbmQParcelas.Size = New System.Drawing.Size(113, 21)
        Me.cbmQParcelas.TabIndex = 32
        '
        'frmResumo
        '
        Me.frmResumo.Controls.Add(Me.LabelMkpCliente)
        Me.frmResumo.Controls.Add(Me.LabelDescTotal)
        Me.frmResumo.Controls.Add(Me.LabelFinalCliente)
        Me.frmResumo.Controls.Add(Me.LabelMkpInstCliente)
        Me.frmResumo.Controls.Add(Me.LabelMkpVidroCli)
        Me.frmResumo.Controls.Add(Me.LabelEsqCliente)
        Me.frmResumo.Controls.Add(Me.LabelMkpTotal)
        Me.frmResumo.Controls.Add(Me.LabelMkpInst)
        Me.frmResumo.Controls.Add(Me.LabelMkpVidro)
        Me.frmResumo.Controls.Add(Me.LabelMkpEsq)
        Me.frmResumo.Controls.Add(Me.LabelTotalGeral)
        Me.frmResumo.Controls.Add(Me.LabelVLResutlInstal)
        Me.frmResumo.Controls.Add(Me.LabelResVidro)
        Me.frmResumo.Controls.Add(Me.LabelResEsq)
        Me.frmResumo.Controls.Add(Me.LabelTotal)
        Me.frmResumo.Controls.Add(Me.LabelInstalacao)
        Me.frmResumo.Controls.Add(Me.LabelVidros)
        Me.frmResumo.Controls.Add(Me.LabelEsquadrias)
        Me.frmResumo.Location = New System.Drawing.Point(499, 260)
        Me.frmResumo.Name = "frmResumo"
        Me.frmResumo.Size = New System.Drawing.Size(409, 217)
        Me.frmResumo.TabIndex = 33
        Me.frmResumo.TabStop = False
        Me.frmResumo.Text = "Resumo"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(16, 116)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(54, 13)
        Me.LabelTotal.TabIndex = 3
        Me.LabelTotal.Text = "Valor total"
        '
        'LabelInstalacao
        '
        Me.LabelInstalacao.AutoSize = True
        Me.LabelInstalacao.Location = New System.Drawing.Point(16, 85)
        Me.LabelInstalacao.Name = "LabelInstalacao"
        Me.LabelInstalacao.Size = New System.Drawing.Size(86, 13)
        Me.LabelInstalacao.TabIndex = 2
        Me.LabelInstalacao.Text = "Valor. Instalação"
        '
        'LabelVidros
        '
        Me.LabelVidros.AutoSize = True
        Me.LabelVidros.Location = New System.Drawing.Point(16, 55)
        Me.LabelVidros.Name = "LabelVidros"
        Me.LabelVidros.Size = New System.Drawing.Size(83, 13)
        Me.LabelVidros.TabIndex = 1
        Me.LabelVidros.Text = "Valor dos Vidros"
        '
        'LabelEsquadrias
        '
        Me.LabelEsquadrias.AutoSize = True
        Me.LabelEsquadrias.Location = New System.Drawing.Point(16, 25)
        Me.LabelEsquadrias.Name = "LabelEsquadrias"
        Me.LabelEsquadrias.Size = New System.Drawing.Size(106, 13)
        Me.LabelEsquadrias.TabIndex = 0
        Me.LabelEsquadrias.Text = "Valor das Esquadrias"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(502, 492)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(90, 33)
        Me.btnCalcular.TabIndex = 34
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(598, 492)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(90, 33)
        Me.btnGravar.TabIndex = 35
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(821, 492)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 33)
        Me.btnCancelar.TabIndex = 36
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'LabelDataDaCriacao
        '
        Me.LabelDataDaCriacao.AutoSize = True
        Me.LabelDataDaCriacao.Location = New System.Drawing.Point(547, 550)
        Me.LabelDataDaCriacao.Name = "LabelDataDaCriacao"
        Me.LabelDataDaCriacao.Size = New System.Drawing.Size(69, 13)
        Me.LabelDataDaCriacao.TabIndex = 38
        Me.LabelDataDaCriacao.Text = "Data Criação"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(728, 551)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(84, 13)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "Ultima Alteração"
        '
        'btnAdicionarNegocio
        '
        Me.btnAdicionarNegocio.Location = New System.Drawing.Point(802, 611)
        Me.btnAdicionarNegocio.Name = "btnAdicionarNegocio"
        Me.btnAdicionarNegocio.Size = New System.Drawing.Size(109, 32)
        Me.btnAdicionarNegocio.TabIndex = 43
        Me.btnAdicionarNegocio.Text = "Adicionar Negócio"
        Me.btnAdicionarNegocio.UseVisualStyleBackColor = True
        '
        'btnRemoverNegocio
        '
        Me.btnRemoverNegocio.Location = New System.Drawing.Point(802, 650)
        Me.btnRemoverNegocio.Name = "btnRemoverNegocio"
        Me.btnRemoverNegocio.Size = New System.Drawing.Size(109, 32)
        Me.btnRemoverNegocio.TabIndex = 44
        Me.btnRemoverNegocio.Text = "Remover Negócio"
        Me.btnRemoverNegocio.UseVisualStyleBackColor = True
        '
        'optCusto
        '
        Me.optCusto.AutoSize = True
        Me.optCusto.Location = New System.Drawing.Point(131, 98)
        Me.optCusto.Name = "optCusto"
        Me.optCusto.Size = New System.Drawing.Size(52, 17)
        Me.optCusto.TabIndex = 24
        Me.optCusto.TabStop = True
        Me.optCusto.Text = "Custo"
        Me.optCusto.UseVisualStyleBackColor = True
        '
        'optMkup
        '
        Me.optMkup.AutoSize = True
        Me.optMkup.Location = New System.Drawing.Point(189, 98)
        Me.optMkup.Name = "optMkup"
        Me.optMkup.Size = New System.Drawing.Size(61, 17)
        Me.optMkup.TabIndex = 23
        Me.optMkup.TabStop = True
        Me.optMkup.Text = "Markup"
        Me.optMkup.UseVisualStyleBackColor = True
        '
        'LabelResEsq
        '
        Me.LabelResEsq.AutoSize = True
        Me.LabelResEsq.Location = New System.Drawing.Point(150, 24)
        Me.LabelResEsq.Name = "LabelResEsq"
        Me.LabelResEsq.Size = New System.Drawing.Size(39, 13)
        Me.LabelResEsq.TabIndex = 4
        Me.LabelResEsq.Text = "Label1"
        '
        'LabelResVidro
        '
        Me.LabelResVidro.AutoSize = True
        Me.LabelResVidro.Location = New System.Drawing.Point(150, 55)
        Me.LabelResVidro.Name = "LabelResVidro"
        Me.LabelResVidro.Size = New System.Drawing.Size(39, 13)
        Me.LabelResVidro.TabIndex = 5
        Me.LabelResVidro.Text = "Label2"
        '
        'LabelVLResutlInstal
        '
        Me.LabelVLResutlInstal.AutoSize = True
        Me.LabelVLResutlInstal.Location = New System.Drawing.Point(150, 85)
        Me.LabelVLResutlInstal.Name = "LabelVLResutlInstal"
        Me.LabelVLResutlInstal.Size = New System.Drawing.Size(39, 13)
        Me.LabelVLResutlInstal.TabIndex = 6
        Me.LabelVLResutlInstal.Text = "Label3"
        '
        'LabelTotalGeral
        '
        Me.LabelTotalGeral.AutoSize = True
        Me.LabelTotalGeral.Location = New System.Drawing.Point(150, 116)
        Me.LabelTotalGeral.Name = "LabelTotalGeral"
        Me.LabelTotalGeral.Size = New System.Drawing.Size(39, 13)
        Me.LabelTotalGeral.TabIndex = 7
        Me.LabelTotalGeral.Text = "Label4"
        '
        'LabelMkpTotal
        '
        Me.LabelMkpTotal.AutoSize = True
        Me.LabelMkpTotal.Location = New System.Drawing.Point(293, 118)
        Me.LabelMkpTotal.Name = "LabelMkpTotal"
        Me.LabelMkpTotal.Size = New System.Drawing.Size(39, 13)
        Me.LabelMkpTotal.TabIndex = 11
        Me.LabelMkpTotal.Text = "Label5"
        '
        'LabelMkpInst
        '
        Me.LabelMkpInst.AutoSize = True
        Me.LabelMkpInst.Location = New System.Drawing.Point(293, 87)
        Me.LabelMkpInst.Name = "LabelMkpInst"
        Me.LabelMkpInst.Size = New System.Drawing.Size(39, 13)
        Me.LabelMkpInst.TabIndex = 10
        Me.LabelMkpInst.Text = "Label6"
        '
        'LabelMkpVidro
        '
        Me.LabelMkpVidro.AutoSize = True
        Me.LabelMkpVidro.Location = New System.Drawing.Point(293, 57)
        Me.LabelMkpVidro.Name = "LabelMkpVidro"
        Me.LabelMkpVidro.Size = New System.Drawing.Size(39, 13)
        Me.LabelMkpVidro.TabIndex = 9
        Me.LabelMkpVidro.Text = "Label7"
        '
        'LabelMkpEsq
        '
        Me.LabelMkpEsq.AutoSize = True
        Me.LabelMkpEsq.Location = New System.Drawing.Point(293, 26)
        Me.LabelMkpEsq.Name = "LabelMkpEsq"
        Me.LabelMkpEsq.Size = New System.Drawing.Size(39, 13)
        Me.LabelMkpEsq.TabIndex = 8
        Me.LabelMkpEsq.Text = "Label8"
        '
        'LabelMkpInstCliente
        '
        Me.LabelMkpInstCliente.AutoSize = True
        Me.LabelMkpInstCliente.Location = New System.Drawing.Point(348, 86)
        Me.LabelMkpInstCliente.Name = "LabelMkpInstCliente"
        Me.LabelMkpInstCliente.Size = New System.Drawing.Size(45, 13)
        Me.LabelMkpInstCliente.TabIndex = 14
        Me.LabelMkpInstCliente.Text = "Label12"
        '
        'LabelMkpVidroCli
        '
        Me.LabelMkpVidroCli.AutoSize = True
        Me.LabelMkpVidroCli.Location = New System.Drawing.Point(348, 56)
        Me.LabelMkpVidroCli.Name = "LabelMkpVidroCli"
        Me.LabelMkpVidroCli.Size = New System.Drawing.Size(45, 13)
        Me.LabelMkpVidroCli.TabIndex = 13
        Me.LabelMkpVidroCli.Text = "Label13"
        '
        'LabelEsqCliente
        '
        Me.LabelEsqCliente.AutoSize = True
        Me.LabelEsqCliente.Location = New System.Drawing.Point(348, 25)
        Me.LabelEsqCliente.Name = "LabelEsqCliente"
        Me.LabelEsqCliente.Size = New System.Drawing.Size(45, 13)
        Me.LabelEsqCliente.TabIndex = 12
        Me.LabelEsqCliente.Text = "Label18"
        '
        'LabelMkpCliente
        '
        Me.LabelMkpCliente.AutoSize = True
        Me.LabelMkpCliente.Location = New System.Drawing.Point(319, 172)
        Me.LabelMkpCliente.Name = "LabelMkpCliente"
        Me.LabelMkpCliente.Size = New System.Drawing.Size(45, 13)
        Me.LabelMkpCliente.TabIndex = 18
        Me.LabelMkpCliente.Text = "Label19"
        '
        'LabelDescTotal
        '
        Me.LabelDescTotal.AutoSize = True
        Me.LabelDescTotal.Location = New System.Drawing.Point(179, 172)
        Me.LabelDescTotal.Name = "LabelDescTotal"
        Me.LabelDescTotal.Size = New System.Drawing.Size(45, 13)
        Me.LabelDescTotal.TabIndex = 17
        Me.LabelDescTotal.Text = "Label20"
        '
        'LabelFinalCliente
        '
        Me.LabelFinalCliente.AutoSize = True
        Me.LabelFinalCliente.Location = New System.Drawing.Point(34, 172)
        Me.LabelFinalCliente.Name = "LabelFinalCliente"
        Me.LabelFinalCliente.Size = New System.Drawing.Size(45, 13)
        Me.LabelFinalCliente.TabIndex = 16
        Me.LabelFinalCliente.Text = "Label21"
        '
        'LabelMetroQuad
        '
        Me.LabelMetroQuad.AutoSize = True
        Me.LabelMetroQuad.Location = New System.Drawing.Point(728, 502)
        Me.LabelMetroQuad.Name = "LabelMetroQuad"
        Me.LabelMetroQuad.Size = New System.Drawing.Size(45, 13)
        Me.LabelMetroQuad.TabIndex = 45
        Me.LabelMetroQuad.Text = "Label20"
        '
        'LabelDataCriacao
        '
        Me.LabelDataCriacao.AutoSize = True
        Me.LabelDataCriacao.Location = New System.Drawing.Point(643, 551)
        Me.LabelDataCriacao.Name = "LabelDataCriacao"
        Me.LabelDataCriacao.Size = New System.Drawing.Size(45, 13)
        Me.LabelDataCriacao.TabIndex = 46
        Me.LabelDataCriacao.Text = "Label20"
        '
        'LabelDescFabrica
        '
        Me.LabelDescFabrica.AutoSize = True
        Me.LabelDescFabrica.Location = New System.Drawing.Point(847, 579)
        Me.LabelDescFabrica.Name = "LabelDescFabrica"
        Me.LabelDescFabrica.Size = New System.Drawing.Size(45, 13)
        Me.LabelDescFabrica.TabIndex = 47
        Me.LabelDescFabrica.Text = "Label20"
        '
        'LabelDtAlteracao
        '
        Me.LabelDtAlteracao.AutoSize = True
        Me.LabelDtAlteracao.Location = New System.Drawing.Point(847, 550)
        Me.LabelDtAlteracao.Name = "LabelDtAlteracao"
        Me.LabelDtAlteracao.Size = New System.Drawing.Size(45, 13)
        Me.LabelDtAlteracao.TabIndex = 48
        Me.LabelDtAlteracao.Text = "Label20"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(947, 725)
        Me.Controls.Add(Me.LabelDtAlteracao)
        Me.Controls.Add(Me.LabelDescFabrica)
        Me.Controls.Add(Me.LabelDataCriacao)
        Me.Controls.Add(Me.LabelMetroQuad)
        Me.Controls.Add(Me.btnRemoverNegocio)
        Me.Controls.Add(Me.btnAdicionarNegocio)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.LabelDataDaCriacao)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.frmResumo)
        Me.Controls.Add(Me.cbmQParcelas)
        Me.Controls.Add(Me.LabelParcelas)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.LabelEntrada)
        Me.Controls.Add(Me.cmbFPagto)
        Me.Controls.Add(Me.LabelFPagto)
        Me.Controls.Add(Me.cbmEspecificador)
        Me.Controls.Add(Me.LabelEspecificador)
        Me.Controls.Add(Me.cbmVendedor)
        Me.Controls.Add(Me.cbmNota)
        Me.Controls.Add(Me.optDescValor)
        Me.Controls.Add(Me.optDescPerc)
        Me.Controls.Add(Me.txtValorFechado)
        Me.Controls.Add(Me.LabelValorFechado)
        Me.Controls.Add(Me.txtDescProCliente)
        Me.Controls.Add(Me.LabelDescProCliente)
        Me.Controls.Add(Me.LabelVendedor)
        Me.Controls.Add(Me.LabelNota)
        Me.Controls.Add(Me.txtValorInicial)
        Me.Controls.Add(Me.labelValorCliente)
        Me.Controls.Add(Me.txtObsservacoes)
        Me.Controls.Add(Me.frmInstalação)
        Me.Controls.Add(Me.frmVidros)
        Me.Controls.Add(Me.frmEsquadrias)
        Me.Controls.Add(Me.TextNomeCliente)
        Me.Controls.Add(Me.LabelNomeCliente)
        Me.Controls.Add(Me.TextnroPRO)
        Me.Controls.Add(Me.labelNmrPRO)
        Me.Controls.Add(Me.btnnovaPRO)
        Me.Controls.Add(Me.btnpesquisaPRO)
        Me.MaximumSize = New System.Drawing.Size(983, 763)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.frmEsquadrias.ResumeLayout(False)
        Me.frmEsquadrias.PerformLayout()
        Me.frmInstalação.ResumeLayout(False)
        Me.frmInstalação.PerformLayout()
        Me.frmVidros.ResumeLayout(False)
        Me.frmVidros.PerformLayout()
        Me.frmResumo.ResumeLayout(False)
        Me.frmResumo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnpesquisaPRO As Button
    Friend WithEvents btnnovaPRO As Button
    Friend WithEvents labelNmrPRO As Label
    Friend WithEvents TextnroPRO As TextBox
    Friend WithEvents LabelNomeCliente As Label
    Friend WithEvents TextNomeCliente As TextBox
    Friend WithEvents frmEsquadrias As GroupBox
    Friend WithEvents LabelMarkup As Label
    Friend WithEvents TextVlMarkup As TextBox
    Friend WithEvents btnAlterarCusto As Button
    Friend WithEvents LabelDescEsqCompra As Label
    Friend WithEvents TextDescEsqCompra As TextBox
    Friend WithEvents TextNumPRO_semVidro As TextBox
    Friend WithEvents LabelPROsemVidro As Label
    Friend WithEvents TextCustoEsq As TextBox
    Friend WithEvents LabelCustoEsq As Label
    Friend WithEvents TextVendaEsq As TextBox
    Friend WithEvents LabelVendaEsq As Label
    Friend WithEvents frmInstalação As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbInst As ComboBox
    Friend WithEvents txtMetInst As TextBox
    Friend WithEvents LabelInstalFora As Label
    Friend WithEvents txtDescInstal As TextBox
    Friend WithEvents LabelDescInstal As Label
    Friend WithEvents txtinstalFora As TextBox
    Friend WithEvents LabelTipoVidro As Label
    Friend WithEvents LabelMetragemVidros As Label
    Friend WithEvents TextMetVidros As TextBox
    Friend WithEvents cmbListaVidros As ComboBox
    Friend WithEvents btnAdiconarVidros As Button
    Friend WithEvents btnRemoverVidros As Button
    Friend WithEvents LabelMetragemTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextMetVidroTotal As TextBox
    Friend WithEvents LabelDescVidro As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextDescVidro As TextBox
    Friend WithEvents frmVidros As GroupBox
    Friend WithEvents txtObsservacoes As RichTextBox
    Friend WithEvents labelValorCliente As Label
    Friend WithEvents txtValorInicial As TextBox
    Friend WithEvents LabelNota As Label
    Friend WithEvents LabelVendedor As Label
    Friend WithEvents txtDescProCliente As TextBox
    Friend WithEvents LabelDescProCliente As Label
    Friend WithEvents txtValorFechado As TextBox
    Friend WithEvents LabelValorFechado As Label
    Friend WithEvents optDescPerc As RadioButton
    Friend WithEvents optDescValor As RadioButton
    Friend WithEvents cbmNota As ComboBox
    Friend WithEvents cbmVendedor As ComboBox
    Friend WithEvents LabelEspecificador As Label
    Friend WithEvents cbmEspecificador As ComboBox
    Friend WithEvents cmbFPagto As ComboBox
    Friend WithEvents LabelFPagto As Label
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents LabelEntrada As Label
    Friend WithEvents LabelParcelas As Label
    Friend WithEvents cbmQParcelas As ComboBox
    Friend WithEvents frmResumo As GroupBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelInstalacao As Label
    Friend WithEvents LabelVidros As Label
    Friend WithEvents LabelEsquadrias As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents LabelDataDaCriacao As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents btnAdicionarNegocio As Button
    Friend WithEvents btnRemoverNegocio As Button
    Friend WithEvents optCusto As RadioButton
    Friend WithEvents optMkup As RadioButton
    Friend WithEvents LabelMkpCliente As Label
    Friend WithEvents LabelDescTotal As Label
    Friend WithEvents LabelFinalCliente As Label
    Friend WithEvents LabelMkpInstCliente As Label
    Friend WithEvents LabelMkpVidroCli As Label
    Friend WithEvents LabelEsqCliente As Label
    Friend WithEvents LabelMkpTotal As Label
    Friend WithEvents LabelMkpInst As Label
    Friend WithEvents LabelMkpVidro As Label
    Friend WithEvents LabelMkpEsq As Label
    Friend WithEvents LabelTotalGeral As Label
    Friend WithEvents LabelVLResutlInstal As Label
    Friend WithEvents LabelResVidro As Label
    Friend WithEvents LabelResEsq As Label
    Friend WithEvents LabelMetroQuad As Label
    Friend WithEvents LabelDataCriacao As Label
    Friend WithEvents LabelDescFabrica As Label
    Friend WithEvents LabelDtAlteracao As Label
End Class
