Imports System.Threading
Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.SistemaAgencia.classes

Public Class Frm_Simulacao

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Simulação"
        Lbl_Tempo.Text = "TEMPO DA SIMULAÇÃO: "
        Lbl_TamanhoFila.Text = "TAMANHO DA FILA: "
        Lbl_TempoMedia.Text = "TEMPO MÉDIO DE ESPERA: "
        Grp_Estatisticas.Text = "Estatísticas"
        Btn_FazSimulacao.Text = "Simulação"
        Grp_Parametros.Text = "Parâmetros"
        Lbl_TempoMenorServico.Text = "Tempo Menor Serviço (Segundos)"
        Lbl_TempoMaiorServico.Text = "Tempo Maior Serviço (Segundos)"
        Lbl_NumClientesMinimo.Text = "Num Clientes Mínimo (Minuto)"
        Lbl_NumClientesMaximo.Text = "Num Clientes Máximo (Minuto)"
        Lbl_NumCaixas.Text = "Número Caixas"
        Lbl_TempoSimulacao.Text = "Tempo Date Simulação (Em Segundos)"
        Lbl_TempoPasso.Text = "Tempo Passo (Em Milisegundos)"

        Txt_TempoMenorServico.Text = "40"
        Txt_TempoMaiorServico.Text = "240"
        Txt_NumeroClientesMaximo.Text = "3"
        Txt_NumeroClientesMinimo.Text = "1"
        Txt_TempoPasso.Text = "50"
        Txt_TempoSimulacao.Text = "1200"
        Txt_NumCaixas.Text = "4"

    End Sub

    Private Sub Btn_FazSimulacao_Click(sender As Object, e As EventArgs) Handles Btn_FazSimulacao.Click

        Dim TempoMenorServico As Integer = Txt_TempoMenorServico.Text
        Dim TempoMaiorServico As Integer = Txt_TempoMaiorServico.Text
        Dim NumCliChegamMinutoMinimo As Integer = Txt_NumeroClientesMinimo.Text
        Dim NumCliChegamMinutoMaximo As Integer = Txt_NumeroClientesMaximo.Text
        Dim NumeroCaixas As Integer = Txt_NumCaixas.Text
        Dim TempoPasso As Integer = Txt_TempoPasso.Text
        Dim TempoMaximoSimulacao As Integer = Txt_TempoSimulacao.Text
        Dim vHora As New TimeSpan(10, 0, 0)

        Dim AgenciaBancaria As New Agencia(277)
        For i As Integer = 1 To NumeroCaixas
            AgenciaBancaria.Caixas.Add(New Caixa($"CAIXA {i}"))
        Next

        Dim SerieHistoricaServico As New Aleatorio(TempoMenorServico, TempoMaiorServico + 1)
        Dim SerieHistoricaNumClientes As New Aleatorio(NumCliChegamMinutoMinimo, NumCliChegamMinutoMaximo + 1)

        Dim vContadorMinuto As Integer = 1
        For i As Integer = 1 To TempoMaximoSimulacao
            If vContadorMinuto = 1 Then
                Dim vNumClientes As Integer = SerieHistoricaNumClientes.GetNumeroAleatorio()
                For j As Integer = 0 To vNumClientes
                    Dim vTempoServico As Integer = SerieHistoricaServico.GetNumeroAleatorio()
                    AgenciaBancaria.EntrarNaFila(vTempoServico)
                    Thread.Sleep(100)
                Next
            End If

            vContadorMinuto += 1
            If vContadorMinuto = 60 Then
                vContadorMinuto = 1
            End If

            AgenciaBancaria.ExercutarAtendimento(1)

            AgenciaBancaria.SairDaFila()

            EscreverAgencia(AgenciaBancaria)

            Lbl_Tempo.Text = "TEMPO DA SIMULAÇÃO: " + ConverterSegundosEmHoras(i)
            Lbl_TamanhoFila.Text = "TAMANHO DA FILA: " + AgenciaBancaria.Fila.Count.ToString
            Lbl_TempoMedia.Text = "TEMPO MÉDIO DE ESPERA: " + ConverterSegundosEmHoras(Agencia.TempoTotalFila / Agencia.NumeroClienteFila)

            Me.Refresh()
            Thread.Sleep(TempoPasso)
        Next

    End Sub

    Sub EscreverAgencia(_AgenciaBancaria As Agencia)
        Txt_Caixas.Text = ""
        Txt_Fila.Text = ""

        For i As Integer = 0 To _AgenciaBancaria.Caixas.Count - 1
            Txt_Caixas.Text += _AgenciaBancaria.Caixas(i).MostrarStatus + vbCrLf
        Next

        For i As Integer = 0 To _AgenciaBancaria.Fila.Count - 1
            Txt_Fila.Text += _AgenciaBancaria.Fila(i).Nome + vbCrLf
        Next
    End Sub

    Function ConverterSegundosEmHoras(Segundos As Integer) As String
        Dim iSecond As Double = Segundos
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)
        Return iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c)
    End Function
End Class
