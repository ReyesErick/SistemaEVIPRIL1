Public Class RptVoucherTemporal
    Public Sub New(idp As Integer, Optional numid As String = "")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        If numid = "" Then
            VoucherTemporalTableAdapter1.FillByIdPlanilla(DsPagos1.VoucherTemporal, idp)
        Else
            VoucherTemporalTableAdapter1.FillByIdPlanillaIdentidad(DsPagos1.VoucherTemporal, idp, numid)
        End If


    End Sub
End Class