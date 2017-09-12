Public Class RptPlanillaTemporal
    Public Sub New(idp As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        VoucherTemporalTableAdapter1.FillByIdPlanilla(DsPagos1.VoucherTemporal, idp)
    End Sub
End Class