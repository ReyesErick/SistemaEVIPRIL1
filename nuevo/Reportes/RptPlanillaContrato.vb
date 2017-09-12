Public Class RptPlanillaContrato
    Public Sub New(idp As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        VoucherContratoTableAdapter1.FillByIdPlanilla(DsPagos1.VoucherContrato, idp)
    End Sub

End Class