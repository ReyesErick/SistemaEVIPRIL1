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
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlNumIdentidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlNombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlFechaIngreso = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlFechaFinal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlSOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlSOD = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlTotalP = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlSubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlSOPM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlSOPD = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlAnio = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlMes = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlDia = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrlDeducciones = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrlDeducciones, Me.XrLabel15, Me.XrLine4, Me.XrLine3, Me.XrLine2, Me.XrlDia, Me.XrLabel18, Me.XrlMes, Me.XrLabel16, Me.XrLabel13, Me.XrlAnio, Me.XrLabel10, Me.XrlSOPD, Me.XrLabel12, Me.XrlSOPM, Me.XrLabel11, Me.XrlSubTotal, Me.XrlTotalP, Me.XrlSOD, Me.XrlSOM, Me.XrLabel9, Me.XrlFechaFinal, Me.XrLabel8, Me.XrlFechaIngreso, Me.XrlNombre, Me.XrlNumIdentidad, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLine1})
        Me.Detail.HeightF = 804.2468!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(502.7726!, 366.6251!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(118.77!, 23.0!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Total Prestaciones: "
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(12.02393!, 366.6251!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(65.56094!, 23.0!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "SubTotal: "
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(452.4626!, 206.5417!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(144.4579!, 22.99998!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Salario Ordinario Diario: "
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(92.84625!, 206.5418!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(151.2023!, 22.99998!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Salario ordinario Mensual: "
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(45.4833!, 65.58336!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(86.09618!, 23.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Nombre: "
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(45.4833!, 25.62501!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(88.24615!, 23.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Codigo: "
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 60.33654!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.BottomMargin.HeightF = 94.87189!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 68.04167!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(158.2034!, 23.0!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.XrLabel34, Me.XrLabel35, Me.XrLabel1})
        Me.PageHeader.HeightF = 132.2917!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(92.84625!, 47.1667!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(83.40136!, 63.41664!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel34
        '
        Me.XrLabel34.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(92.84626!, 21.70836!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(555.3075!, 25.45834!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.Text = "EMPRESA DE VIGILANCIA PRIVADA LEON S. DE R. L."
        '
        'XrLabel35
        '
        Me.XrLabel35.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(325.575!, 47.1667!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(108.0834!, 24.41667!)
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.Text = """EVIPRIL"""
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(275.1937!, 71.58337!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(203.7153!, 38.99997!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "PRESTACIONES"
        '
        'XrlNumIdentidad
        '
        Me.XrlNumIdentidad.BackColor = System.Drawing.Color.Transparent
        Me.XrlNumIdentidad.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlNumIdentidad.LocationFloat = New DevExpress.Utils.PointFloat(133.7295!, 25.62501!)
        Me.XrlNumIdentidad.Name = "XrlNumIdentidad"
        Me.XrlNumIdentidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlNumIdentidad.SizeF = New System.Drawing.SizeF(161.1628!, 23.0!)
        Me.XrlNumIdentidad.StylePriority.UseBackColor = False
        Me.XrlNumIdentidad.StylePriority.UseBorders = False
        Me.XrlNumIdentidad.StylePriority.UseTextAlignment = False
        Me.XrlNumIdentidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrlNombre
        '
        Me.XrlNombre.BackColor = System.Drawing.Color.Transparent
        Me.XrlNombre.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlNombre.LocationFloat = New DevExpress.Utils.PointFloat(131.5795!, 65.58336!)
        Me.XrlNombre.Name = "XrlNombre"
        Me.XrlNombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlNombre.SizeF = New System.Drawing.SizeF(203.8711!, 23.0!)
        Me.XrlNombre.StylePriority.UseBackColor = False
        Me.XrlNombre.StylePriority.UseBorders = False
        Me.XrlNombre.StylePriority.UseTextAlignment = False
        Me.XrlNombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(372.1338!, 25.62501!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(88.24615!, 23.0!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Fecha Ingreso: "
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlFechaIngreso
        '
        Me.XrlFechaIngreso.BackColor = System.Drawing.Color.Transparent
        Me.XrlFechaIngreso.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlFechaIngreso.LocationFloat = New DevExpress.Utils.PointFloat(460.3799!, 25.62501!)
        Me.XrlFechaIngreso.Name = "XrlFechaIngreso"
        Me.XrlFechaIngreso.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlFechaIngreso.SizeF = New System.Drawing.SizeF(161.1628!, 23.0!)
        Me.XrlFechaIngreso.StylePriority.UseBackColor = False
        Me.XrlFechaIngreso.StylePriority.UseBorders = False
        Me.XrlFechaIngreso.StylePriority.UseTextAlignment = False
        Me.XrlFechaIngreso.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(372.1338!, 65.58336!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(88.24615!, 23.0!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Fecha Final: "
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlFechaFinal
        '
        Me.XrlFechaFinal.BackColor = System.Drawing.Color.Transparent
        Me.XrlFechaFinal.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlFechaFinal.LocationFloat = New DevExpress.Utils.PointFloat(460.3799!, 65.58336!)
        Me.XrlFechaFinal.Name = "XrlFechaFinal"
        Me.XrlFechaFinal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlFechaFinal.SizeF = New System.Drawing.SizeF(161.1628!, 23.0!)
        Me.XrlFechaFinal.StylePriority.UseBackColor = False
        Me.XrlFechaFinal.StylePriority.UseBorders = False
        Me.XrlFechaFinal.StylePriority.UseTextAlignment = False
        Me.XrlFechaFinal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrlSOM
        '
        Me.XrlSOM.BackColor = System.Drawing.Color.Transparent
        Me.XrlSOM.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlSOM.LocationFloat = New DevExpress.Utils.PointFloat(244.0485!, 206.5418!)
        Me.XrlSOM.Name = "XrlSOM"
        Me.XrlSOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlSOM.SizeF = New System.Drawing.SizeF(98.66278!, 23.0!)
        Me.XrlSOM.StylePriority.UseBackColor = False
        Me.XrlSOM.StylePriority.UseBorders = False
        Me.XrlSOM.StylePriority.UseTextAlignment = False
        Me.XrlSOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlSOD
        '
        Me.XrlSOD.BackColor = System.Drawing.Color.Transparent
        Me.XrlSOD.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlSOD.LocationFloat = New DevExpress.Utils.PointFloat(596.9205!, 206.5417!)
        Me.XrlSOD.Name = "XrlSOD"
        Me.XrlSOD.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlSOD.SizeF = New System.Drawing.SizeF(98.66278!, 23.0!)
        Me.XrlSOD.StylePriority.UseBackColor = False
        Me.XrlSOD.StylePriority.UseBorders = False
        Me.XrlSOD.StylePriority.UseTextAlignment = False
        Me.XrlSOD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlTotalP
        '
        Me.XrlTotalP.BackColor = System.Drawing.Color.Transparent
        Me.XrlTotalP.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlTotalP.LocationFloat = New DevExpress.Utils.PointFloat(621.5426!, 366.6251!)
        Me.XrlTotalP.Name = "XrlTotalP"
        Me.XrlTotalP.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlTotalP.SizeF = New System.Drawing.SizeF(98.66278!, 23.0!)
        Me.XrlTotalP.StylePriority.UseBackColor = False
        Me.XrlTotalP.StylePriority.UseBorders = False
        Me.XrlTotalP.StylePriority.UseTextAlignment = False
        Me.XrlTotalP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlSubTotal
        '
        Me.XrlSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.XrlSubTotal.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlSubTotal.LocationFloat = New DevExpress.Utils.PointFloat(77.58484!, 366.6251!)
        Me.XrlSubTotal.Name = "XrlSubTotal"
        Me.XrlSubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlSubTotal.SizeF = New System.Drawing.SizeF(98.66278!, 23.0!)
        Me.XrlSubTotal.StylePriority.UseBackColor = False
        Me.XrlSubTotal.StylePriority.UseBorders = False
        Me.XrlSubTotal.StylePriority.UseTextAlignment = False
        Me.XrlSubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlSOPM
        '
        Me.XrlSOPM.BackColor = System.Drawing.Color.Transparent
        Me.XrlSOPM.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlSOPM.LocationFloat = New DevExpress.Utils.PointFloat(244.0485!, 246.8734!)
        Me.XrlSOPM.Name = "XrlSOPM"
        Me.XrlSOPM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlSOPM.SizeF = New System.Drawing.SizeF(98.66278!, 23.0!)
        Me.XrlSOPM.StylePriority.UseBackColor = False
        Me.XrlSOPM.StylePriority.UseBorders = False
        Me.XrlSOPM.StylePriority.UseTextAlignment = False
        Me.XrlSOPM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(29.30455!, 246.8734!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(214.744!, 22.99997!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Salario Ordinario Promedio Mensual: "
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlSOPD
        '
        Me.XrlSOPD.BackColor = System.Drawing.Color.Transparent
        Me.XrlSOPD.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlSOPD.LocationFloat = New DevExpress.Utils.PointFloat(596.9205!, 246.8734!)
        Me.XrlSOPD.Name = "XrlSOPD"
        Me.XrlSOPD.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlSOPD.SizeF = New System.Drawing.SizeF(98.66278!, 23.0!)
        Me.XrlSOPD.StylePriority.UseBackColor = False
        Me.XrlSOPD.StylePriority.UseBorders = False
        Me.XrlSOPD.StylePriority.UseTextAlignment = False
        Me.XrlSOPD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(382.1765!, 246.8734!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(214.744!, 22.99997!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Salario Ordinario Promedio Diario: "
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 88.58337!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(741.0!, 23.0!)
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(43.33334!, 125.1251!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(156.0535!, 23.0!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.Text = "Calculo Por: DESPIDO"
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(300.2562!, 125.1251!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(73.6734!, 23.0!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Años: "
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlAnio
        '
        Me.XrlAnio.BackColor = System.Drawing.Color.Transparent
        Me.XrlAnio.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlAnio.LocationFloat = New DevExpress.Utils.PointFloat(373.9296!, 125.1251!)
        Me.XrlAnio.Name = "XrlAnio"
        Me.XrlAnio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlAnio.SizeF = New System.Drawing.SizeF(45.00113!, 23.0!)
        Me.XrlAnio.StylePriority.UseBackColor = False
        Me.XrlAnio.StylePriority.UseBorders = False
        Me.XrlAnio.StylePriority.UseTextAlignment = False
        Me.XrlAnio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrlMes
        '
        Me.XrlMes.BackColor = System.Drawing.Color.Transparent
        Me.XrlMes.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlMes.LocationFloat = New DevExpress.Utils.PointFloat(516.8064!, 125.125!)
        Me.XrlMes.Name = "XrlMes"
        Me.XrlMes.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlMes.SizeF = New System.Drawing.SizeF(48.82233!, 23.00003!)
        Me.XrlMes.StylePriority.UseBackColor = False
        Me.XrlMes.StylePriority.UseBorders = False
        Me.XrlMes.StylePriority.UseTextAlignment = False
        Me.XrlMes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(439.3117!, 125.1251!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(77.4946!, 23.00003!)
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Meses: "
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrlDia
        '
        Me.XrlDia.BackColor = System.Drawing.Color.Transparent
        Me.XrlDia.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlDia.LocationFloat = New DevExpress.Utils.PointFloat(660.4702!, 125.1251!)
        Me.XrlDia.Name = "XrlDia"
        Me.XrlDia.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlDia.SizeF = New System.Drawing.SizeF(45.00113!, 23.0!)
        Me.XrlDia.StylePriority.UseBackColor = False
        Me.XrlDia.StylePriority.UseBorders = False
        Me.XrlDia.StylePriority.UseTextAlignment = False
        Me.XrlDia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(586.7968!, 125.1251!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(73.6734!, 23.0!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Dias: "
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 168.9584!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(741.0!, 23.0!)
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 308.3318!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(741.0!, 23.0!)
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 418.7484!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(741.0!, 23.0!)
        '
        'XrlDeducciones
        '
        Me.XrlDeducciones.BackColor = System.Drawing.Color.Transparent
        Me.XrlDeducciones.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrlDeducciones.LocationFloat = New DevExpress.Utils.PointFloat(349.5789!, 366.6251!)
        Me.XrlDeducciones.Name = "XrlDeducciones"
        Me.XrlDeducciones.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlDeducciones.SizeF = New System.Drawing.SizeF(98.66278!, 23.0!)
        Me.XrlDeducciones.StylePriority.UseBackColor = False
        Me.XrlDeducciones.StylePriority.UseBorders = False
        Me.XrlDeducciones.StylePriority.UseTextAlignment = False
        Me.XrlDeducciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(230.809!, 366.6251!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(118.77!, 23.0!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "OtrasDeducciones: "
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportePrestaciones
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 49, 60, 95)
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlFechaFinal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlFechaIngreso As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlNombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlNumIdentidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlSOPM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlSubTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlTotalP As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlSOD As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlSOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrlDia As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlMes As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlAnio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlSOPD As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrlDeducciones As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
End Class
