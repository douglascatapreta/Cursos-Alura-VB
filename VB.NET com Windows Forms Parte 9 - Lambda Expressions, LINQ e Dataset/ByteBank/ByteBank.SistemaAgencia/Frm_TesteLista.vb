Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.Bibliotecas.Classes.Criterios

Public Class Frm_TesteLista
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Lista As New List(Of Integer)
        Lista.Add(10)
        Lista.Add(12)
        Lista.Add(8)
        Lista.Add(2)

        MsgBox(Lista.Contains(8))

        Lista.Sort()

        MsgBox(Lista(0))
        MsgBox(Lista(1))
        MsgBox(Lista(2))
        MsgBox(Lista(3))

        Dim ListaS As New List(Of String)
        ListaS.Add("João")
        ListaS.Add("Pedro")
        ListaS.Add("Antonio")
        ListaS.Add("Beatriz")

        MsgBox(ListaS.Contains("Pedro"))

        ListaS.Sort()

        MsgBox(ListaS(0))
        MsgBox(ListaS(1))
        MsgBox(ListaS(2))
        MsgBox(ListaS(3))


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Lista As List(Of Integer)
        Lista = New List(Of Integer)

        Dim Conjunto As ISet(Of Integer)
        Conjunto = New HashSet(Of Integer)

        Lista.Add(25)
        Lista.Add(12)
        Lista.Add(8)

        Conjunto.Add(25)
        Conjunto.Add(12)
        Conjunto.Add(8)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Remove(12)
        Lista.Add(2)

        Conjunto.Remove(12)
        Conjunto.Add(2)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Add(2)
        Conjunto.Add(2)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Sort()

        Dim ListaTemporaria As New List(Of Integer)(Conjunto)
        ListaTemporaria.Sort()

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", ListaTemporaria))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim ag As New Agencia(277)

        ag.AbrirContaCorrente(17777, "Marília")
        ag.AbrirContaCorrente(22222, "Márcia")
        ag.AbrirContaCorrente(3333, "Victor")

        MsgBox("Contas correntes da agencia: " +
               ag.agencia.ToString + " Contas: " + String.Join(" | ", ag.ContasCorrentes))

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Dim ListaDias As New List(Of String)
        'ListaDias.Add("Segunda")
        'ListaDias.Add("Terça")
        'ListaDias.Add("Quinta")
        'ListaDias.Add("Sexta")
        'ListaDias.Add("Sábado")

        'MsgBox(String.Join(" , ", ListaDias))

        'ListaDias.Add("Quarta")

        'MsgBox(String.Join(" , ", ListaDias))


        Dim ListaDiasLink As New LinkedList(Of String)

        Dim D4 As LinkedListNode(Of String) = ListaDiasLink.AddFirst("Quarta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D2 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D4, "Segunda")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D3 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D4, "Terça")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D6 As LinkedListNode(Of String) = ListaDiasLink.AddAfter(D4, "Sexta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D7 As LinkedListNode(Of String) = ListaDiasLink.AddAfter(D6, "Sábado")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D5 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D6, "Quinta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D1 As LinkedListNode(Of String) = ListaDiasLink.AddFirst("Domingo")
        MsgBox(String.Join(" , ", ListaDiasLink))

        MsgBox("A lista linked possui " + ListaDiasLink.Count.ToString + " elementos.")

        For i As Integer = 0 To ListaDiasLink.Count - 1
            MsgBox(ListaDiasLink(i))
        Next

        MsgBox(String.Join(" , ", ListaDiasLink))
        ListaDiasLink.Remove(D1)
        MsgBox(String.Join(" , ", ListaDiasLink))
        ListaDiasLink.Remove("Quarta")
        MsgBox(String.Join(" , ", ListaDiasLink))

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim Paginas As New Stack(Of String)
        Paginas.Push("Página 1")
        Paginas.Push("Página 2")
        Paginas.Push("Página 3")
        Paginas.Push("Página 4")
        Paginas.Push("Página 5")
        MsgBox(String.Join(" , ", Paginas))
        Dim X As String = Paginas.Pop()
        MsgBox(String.Join(" , ", Paginas))
        Dim Y As String = Paginas.Peek()
        MsgBox(String.Join(" , ", Paginas))
        MsgBox(X + " - " + Y)

        Dim PaginasRevertidas = Paginas.Reverse
        MsgBox(String.Join(" , ", Paginas))
        MsgBox(String.Join(" , ", PaginasRevertidas))

        For I As Integer = 0 To Paginas.Count - 1
            MsgBox(Paginas(I))
        Next

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim Conta1 As New ContaCorrente(277, 123444, "João")
        Conta1.Depositar(10000)

        Dim Conta2 As New ContaCorrente(277, 155645, "Pedro")
        Conta2.Depositar(5000)

        Dim Conta3 As New ContaCorrente(500, 166323, "Alberto")
        Conta3.Depositar(7000)

        Dim Conta4 As New ContaCorrente(123, 199477, "Zeus")
        Conta4.Depositar(1000)

        Dim ListaContasCorrentes As New List(Of ContaCorrente)
        ListaContasCorrentes.Add(Conta1)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta2)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta3)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta4)

        MsgBox($"Lista de contas original:{vbCrLf}{String.Join($"{vbCrLf}", ListaContasCorrentes)}")

        'Dim ListaAuxiliar As New List(Of ContaCorrente)
        'For i As Integer = 0 To ListaContasCorrentes.Count - 1
        '    If Not ListaContasCorrentes(i) Is Nothing Then
        '        ListaAuxiliar.Add(ListaContasCorrentes(i))
        '    End If
        'Next

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContasCorrentes.Where(Function(conta As ContaCorrente) Not conta Is Nothing)

        'ListaContasCorrentes.Sort(New CriterioContaCorrenteNome())
        'MsgBox($"Lista de contas ordenada por nome:{vbCrLf}{String.Join($"{vbCrLf}", ListaContasCorrentes)}")
        Dim x As IEnumerable(Of ContaCorrente) = ListaAuxiliar.OrderBy(Function(conta As ContaCorrente) conta.titular.nome)
        MsgBox($"Lista de contas ordenada por nome:{vbCrLf}{String.Join($"{vbCrLf}", x)}")

        'ListaContasCorrentes.Sort(New CriterioContaCorrenteSaldo())
        'MsgBox($"Lista de contas ordenada por saldo:{vbCrLf}{String.Join($"{vbCrLf}", ListaContasCorrentes)}")
        Dim y As IEnumerable(Of ContaCorrente) = ListaAuxiliar.OrderBy(Function(conta As ContaCorrente) conta.saldo)
        MsgBox($"Lista de contas ordenada por saldo:{vbCrLf}{String.Join($"{vbCrLf}", y)}")

        'ListaContasCorrentes.Sort(New CriterioContaCorrenteAgenciaNumero())
        'MsgBox($"Lista de contas ordenada por agencia/numero:{vbCrLf}{String.Join($"{vbCrLf}", ListaContasCorrentes)}")
        Dim z As IEnumerable(Of ContaCorrente) = ListaAuxiliar.OrderBy(Function(conta As ContaCorrente) conta.agencia).OrderBy(Function(conta As ContaCorrente) conta.numero)
        MsgBox($"Lista de contas ordenada por agencia/numero:{vbCrLf}{String.Join($"{vbCrLf}", z)}")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim Conta1 As New ContaCorrente(277, 123444, "João")
        Conta1.Depositar(10000)

        Dim Conta2 As New ContaCorrente(277, 155645, "Pedro")
        Conta2.Depositar(5000)

        Dim Conta3 As New ContaCorrente(500, 166323, "Alberto")
        Conta3.Depositar(7000)

        Dim Conta4 As New ContaCorrente(123, 199477, "Zeus")
        Conta4.Depositar(1000)

        Dim ListaContasCorrentes As New List(Of ContaCorrente)
        ListaContasCorrentes.Add(Conta1)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta2)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta3)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta4)

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
        .Where(Function(conta As ContaCorrente) Not conta Is Nothing) _
        .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        MsgBox($"Lista de contas ordenada por nome:{vbCrLf}{String.Join($"{vbCrLf}", ListaAuxiliar)}")

        Dim MenorSaldo As Double = ListaAuxiliar.Min(Function(conta As ContaCorrente) conta.saldo)

        MsgBox($"O MENOR saldo é de: {MenorSaldo}")

        Dim MaiorSaldo As Double = ListaAuxiliar.Max(Function(conta As ContaCorrente) conta.saldo)

        MsgBox($"O MAIOR saldo é de: {MaiorSaldo}")

        Dim MaiorSaldo2 As Double = ListaContasCorrentes _
        .Where(Function(conta As ContaCorrente) Not conta Is Nothing) _
        .OrderBy(Function(conta As ContaCorrente) conta.titular.nome) _
        .Max(Function(conta As ContaCorrente) conta.saldo)

        Dim ListaContasCorrentes2 As New List(Of ContaCorrente)
        ListaContasCorrentes2.Add(Conta1)
        ListaContasCorrentes2.Add(Conta2)
        ListaContasCorrentes2.Add(Conta3)
        ListaContasCorrentes2.Add(Conta4)

        Dim ListaAuxiliarConcatenada As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
            .Where(Function(conta As ContaCorrente) Not conta Is Nothing) _
            .Concat(ListaContasCorrentes2) _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        MsgBox($"Lista de contas concatenadas:{vbCrLf}{String.Join($"{vbCrLf}", ListaAuxiliarConcatenada)}")

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        ' ##################################################### '
        ' ## Criando uma lista de Cliente e de ContaCorrente ## '
        ' ##################################################### '

        Dim Clientes As New List(Of Cliente)
        Clientes.Add(CriarCliente("11111111111", "João da Silva", "Engenheiro"))
        Clientes.Add(CriarCliente("22222222222", "Alberto Navarro", "Programador"))
        Clientes.Add(CriarCliente("33333333333", "Zoraide Margrelha", "Médica"))
        Clientes.Add(CriarCliente("44444444444", "Verônica Mars", "Agente Secreta"))
        Clientes.Add(CriarCliente("55555555555", "Coulson Springs", "Lixeiro"))
        Clientes.Add(CriarCliente("66666666666", "Maricota Miranda", "Dona de Casa"))

        Dim Contas As New List(Of ContaCorrente)
        Contas.Add(New ContaCorrente(277, 123221))
        Contas(0).titular = Clientes(0)
        Contas.Add(New ContaCorrente(277, 344789))
        Contas(1).titular = Clientes(0)
        Contas.Add(New ContaCorrente(277, 556441))
        Contas(2).titular = Clientes(2)
        Contas.Add(New ContaCorrente(277, 113499))
        Contas(3).titular = Clientes(1)
        Contas.Add(New ContaCorrente(277, 456477))
        Contas(4).titular = Clientes(1)
        Contas.Add(New ContaCorrente(277, 123697))
        Contas(5).titular = Clientes(3)
        Contas.Add(New ContaCorrente(277, 661377))
        Contas(6).titular = Clientes(4)
        Contas.Add(New ContaCorrente(277, 999447))
        Contas(7).titular = Clientes(5)

        ' ####################################### '
        ' ## Criando a tabela Contas Correntes ## '
        ' ####################################### '

        Dim Dt As New DataTable
        Dt.TableName = "Contas Correntes"
        Dt.Columns.Add(CriarColuna("Agência", "System.Int32"))
        Dt.Columns.Add(CriarColuna("Conta", "System.Int32"))
        Dt.Columns.Add(CriarColuna("CPF", "System.String"))
        Dt.Columns.Add(CriarColuna("Saldo", "System.Double"))

        ' Criando chave primária para tabela contas correntes
        Dim vArrayChavesConta(1) As DataColumn
        Dt.Columns("Agência").AllowDBNull = False
        Dt.Columns("Conta").AllowDBNull = False
        vArrayChavesConta(0) = Dt.Columns("Agência")
        vArrayChavesConta(1) = Dt.Columns("Conta")
        Dt.PrimaryKey = vArrayChavesConta

        ' ############################### '
        ' ## Criando a tabela Clientes ## '
        ' ############################### '

        Dim Dt2 As New DataTable
        Dt2.TableName = "Clientes"
        Dt2.Columns.Add(CriarColuna("CPF", "System.String"))
        Dt2.Columns.Add(CriarColuna("Nome", "System.String"))
        Dt2.Columns.Add(CriarColuna("Profissão", "System.String"))

        ' Criando chave primária para cliente
        Dim vArrayChavesCliente(0) As DataColumn
        Dt2.Columns("CPF").AllowDBNull = False
        vArrayChavesCliente(0) = Dt2.Columns("CPF")
        Dt2.PrimaryKey = vArrayChavesCliente

        ' ####################### '
        ' ## Criando o DataSet ## '
        ' ####################### '

        Dim Ds As New DataSet()
        Ds.Tables.Add(Dt)
        Ds.Tables.Add(Dt2)

        ' ############################### '
        ' ## Criando chave estrangeira ## '
        ' ############################### '

        Dim FKClientesCC As New ForeignKeyConstraint("FKClientesCC", Ds.Tables("Clientes").Columns("CPF"), Ds.Tables("Contas Correntes").Columns("CPF"))
        FKClientesCC.DeleteRule = Rule.None
        Ds.Tables("Contas Correntes").Constraints.Add(FKClientesCC)

        ' ############################################### '
        ' ## Populando a tabela de Clientes do DataSet ## '
        ' ############################################### '

        For i As Integer = 0 To Clientes.Count - 1
            Dim Dr As DataRow = Ds.Tables("Clientes").NewRow
            Dr(0) = Clientes(i).cpf
            Dr(1) = Clientes(i).nome
            Dr(2) = Clientes(i).profissao
            Ds.Tables("Clientes").Rows.Add(Dr)
        Next

        ' #################################################### '
        ' ## Populando a tabela Contas Correntes do DataSet ## '
        ' #################################################### '

        For i As Integer = 0 To Contas.Count - 1
            Dim Dr As DataRow = Ds.Tables("Contas Correntes").NewRow
            Dr(0) = Contas(i).agencia
            Dr(1) = Contas(i).numero
            Dr(2) = Contas(i).titular.cpf
            Dr(3) = Contas(i).saldo
            Ds.Tables("Contas Correntes").Rows.Add(Dr)
        Next

        ' ############################### '
        ' ## Exibindo dados do DataSet ## '
        ' ############################### '

        For i As Integer = 0 To Ds.Tables.Count - 1
            For j As Integer = 0 To Ds.Tables(i).Rows.Count - 1
                Dim vSaida As String = ""
                For k As Integer = 0 To Ds.Tables(i).Columns.Count - 1
                    vSaida += $"Tabela {Ds.Tables(i).TableName} => {Ds.Tables(i).Columns(k).ColumnName} => {Ds.Tables(i).Rows(j)(k)}{vbCrLf}"
                Next
                'MsgBox(vSaida)
            Next
        Next

        ' ################################################################## '
        ' ## Criando filtro para obter contas correntes de um correntista ## '
        ' ################################################################## '

        Dim vCriterio As String = "CPF = '11111111111'"
        Dim DtFiltro As DataTable = Ds.Tables("Contas Correntes").Clone()
        Dim DrLinhas As DataRow() = Ds.Tables("Contas Correntes").Select(vCriterio)
        For Each row As DataRow In DrLinhas
            DtFiltro.ImportRow(row)
        Next

        For i As Integer = 0 To DtFiltro.Rows.Count - 1
            Dim vSaida As String = ""
            For j As Integer = 0 To DtFiltro.Columns.Count - 1
                vSaida += $"{DtFiltro.Columns(j).ColumnName} => {DtFiltro.Rows(i)(j)}{vbCrLf}"
            Next
            'MsgBox(vSaida)
        Next

        ' ############################################# '
        ' ## Ordenando a tabela de clientes por nome ## '
        ' ############################################# '

        Dim DtView As DataView
        DtView = Ds.Tables("Clientes").DefaultView
        Dim vCriterioOrdenacao As String = "Nome"
        'Dim vCriterioOrdenacao As String = "Profissao, Nome DESC"
        DtView.Sort = vCriterioOrdenacao
        Dim DtOrdenado As New DataTable
        DtOrdenado = DtView.ToTable

        ' ########################################## '
        ' ## Filtrando e ordenando ao mesmo tempo ## '
        ' ########################################## '

        Dim DtView2 As New DataView(Ds.Tables("Contas Correntes"), "CPF = 11111111111", "Conta", DataViewRowState.OriginalRows)

        ' ################################ '
        ' ## Excluindo linhas da tabela ## '
        ' ################################ '

        Ds.Tables("Clientes").Rows(0).Delete()
        Ds.Tables("Contas Correntes").Rows(0).Delete()

        Dim vCriterio2 As String = "CPF = '33333333333'"
        Dim DrLinhas2 As DataRow() = Ds.Tables("Contas Correntes").Select(vCriterio2)
        For Each row As DataRow In DrLinhas2
            Ds.Tables("Contas Correntes").Rows.Remove(row)
        Next

    End Sub

    Function CriarColuna(NomeColuna As String, TipoColuna As String) As DataColumn
        Dim Dc As New DataColumn()
        Dc.ColumnName = NomeColuna
        Dc.DataType = Type.GetType(TipoColuna)
        Return Dc
    End Function

    Function CriarCliente(cpf As String, nome As String, profissao As String) As Cliente
        Dim c As New Cliente()
        c.cpf = cpf
        c.nome = nome
        c.profissao = profissao
        Return c
    End Function
End Class