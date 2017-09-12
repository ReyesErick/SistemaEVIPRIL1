Public Class RptPlanillas
    Public Sub New(idp As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        VoucherPermanenteTableAdapter1.FillByIdPlanilla(DsPagos1.VoucherPermanente, idp)
    End Sub
End Class