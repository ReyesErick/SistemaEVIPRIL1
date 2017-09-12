Public Class RptVoucherContrato
    Public Sub New(idp As Integer, Optional numid As String = "")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        If numid = "" Then
            VoucherContratoTableAdapter1.FillByIdPlanilla(DsPagos1.VoucherContrato, idp)
        Else
            VoucherContratoTableAdapter1.FillByIdPlanillaIdentidad(DsPagos1.VoucherContrato, idp, numid)
        End If


    End Sub

End Class