<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class ReportePrestaciones
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportePrestaciones))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Codigo = New DevExpress.XtraReports.UI.XRRichText()
        Me.Nombre = New DevExpress.XtraReports.UI.XRRichText()
        Me.SalarioMensual = New DevExpress.XtraReports.UI.XRRichText()
        Me.SalarioDiario = New DevExpress.XtraReports.UI.XRRichText()
        Me.SubTotal = New DevExpress.XtraReports.UI.XRRichText()
        Me.TotalPrestaciones = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalarioMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalarioDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPrestaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.TotalPrestaciones, Me.SubTotal, Me.SalarioDiario, Me.SalarioMensual, Me.Nombre, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.Codigo})
        Me.Detail.HeightF = 169.7917!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1, Me.XrLabel8, Me.XrLabel9})
        Me.BottomMargin.HeightF = 101.0417!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrLabel1, Me.XrLabel35, Me.XrLabel34})
        Me.PageHeader.HeightF = 132.2917!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(518.5441!, 54.87502!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(127.5!, 77.41664!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(211.666!, 62.99998!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(306.8781!, 38.99998!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Reporte de Prestaciones"
        '
        'XrLabel35
        '
        Me.XrLabel35.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(296.0414!, 38.58334!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(108.0834!, 24.41667!)
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.Text = """EVIPRIL"""
        '
        'XrLabel34
        '
        Me.XrLabel34.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(90.62497!, 13.12501!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(555.3075!, 25.45834!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.Text = "EMPRESA DE VIGILANCIA PRIVADA LEON S. DE R. L."
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Silver
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(43.33334!, 10.00001!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(65.62497!, 23.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.Text = "Codigo"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Silver
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(108.9583!, 10.00001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(71.8751!, 23.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.Text = "Nombre"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Silver
        Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(180.8334!, 10.00001!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(180.833!, 22.99998!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.Text = "Salario ordinario Mensual"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Silver
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(361.6664!, 10.00004!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(167.2944!, 22.99998!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.Text = "Salario Ordinario Diario"
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Silver
        Me.XrLabel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(528.9608!, 10.00001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(71.25006!, 23.0!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.Text = "SubTotal"
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Silver
        Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(600.2108!, 10.00001!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(111.4583!, 23.0!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.Text = "Total Prestaciones"
        '
        'Codigo
        '
        Me.Codigo.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Codigo.LocationFloat = New DevExpress.Utils.PointFloat(43.33334!, 48.91666!)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.SerializableRtfString = resources.GetString("Codigo.SerializableRtfString")
        Me.Codigo.SizeF = New System.Drawing.SizeF(65.62497!, 23.0!)
        '
        'Nombre
        '
        Me.Nombre.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(108.9583!, 48.91666!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.SerializableRtfString = resources.GetString("Nombre.SerializableRtfString")
        Me.Nombre.SizeF = New System.Drawing.SizeF(71.8751!, 23.0!)
        '
        'SalarioMensual
        '
        Me.SalarioMensual.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.SalarioMensual.LocationFloat = New DevExpress.Utils.PointFloat(180.8334!, 48.91666!)
        Me.SalarioMensual.Name = "SalarioMensual"
        Me.SalarioMensual.SerializableRtfString = resources.GetString("SalarioMensual.SerializableRtfString")
        Me.SalarioMensual.SizeF = New System.Drawing.SizeF(180.833!, 23.0!)
        '
        'SalarioDiario
        '
        Me.SalarioDiario.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.SalarioDiario.LocationFloat = New DevExpress.Utils.PointFloat(361.6664!, 48.91666!)
        Me.SalarioDiario.Name = "SalarioDiario"
        Me.SalarioDiario.SerializableRtfString = resources.GetString("SalarioDiario.SerializableRtfString")
        Me.SalarioDiario.SizeF = New System.Drawing.SizeF(167.2943!, 23.0!)
        '
        'SubTotal
        '
        Me.SubTotal.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.SubTotal.LocationFloat = New DevExpress.Utils.PointFloat(528.9608!, 48.91666!)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.SerializableRtfString = resources.GetString("SubTotal.SerializableRtfString")
        Me.SubTotal.SizeF = New System.Drawing.SizeF(71.25006!, 23.0!)
        '
        'TotalPrestaciones
        '
        Me.TotalPrestaciones.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.TotalPrestaciones.LocationFloat = New DevExpress.Utils.PointFloat(600.2108!, 48.91666!)
        Me.TotalPrestaciones.Name = "TotalPrestaciones"
        Me.TotalPrestaciones.SerializableRtfString = resources.GetString("TotalPrestaciones.SerializableRtfString")
        Me.TotalPrestaciones.SizeF = New System.Drawing.SizeF(111.3467!, 23.0!)
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Silver
        Me.XrLabel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(257.2045!, 49.99999!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(245.821!, 22.99999!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Tel. 2782-6490 Choluteca, Honduras C.A."
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Silver
        Me.XrLabel9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(147.2045!, 27.00002!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(446.591!, 23.0!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "Barrio La Libertad, 1½  al Norte de Survivienda de Asociación San José Obrero  "
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Página {0} de {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(641.0922!, 68.04167!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(89.90796!, 23.0!)
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(43.33334!, 68.04167!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(158.2034!, 23.0!)
        '
        'ReportePrestaciones
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 49, 100, 101)
        Me.Version = "17.1"
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalarioMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalarioDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPrestaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalPrestaciones As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents SubTotal As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents SalarioDiario As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents SalarioMensual As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Codigo As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
End Class
