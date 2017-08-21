Public Class RptPlanillas
    Public Sub New(idp As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DetallePlanillaTableAdapter1.FillByIdPlanilla(Planillas1.DetallePlanilla, idp)
    End Sub
End Class