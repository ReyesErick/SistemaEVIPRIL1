Public Class RptVoucher
    Public Sub New(idp As Integer, Optional numid As String = "")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        If numid = "" Then
            VoucherTableAdapter1.FillByIdPlanilla(Planillas1.Voucher, idp)
        Else
            VoucherTableAdapter1.FillByIdPlanillaIdentidad(Planillas1.Voucher, idp, numid)
        End If


    End Sub
End Class