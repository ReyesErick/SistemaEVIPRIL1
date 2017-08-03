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
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.WinControlContainer6 = New DevExpress.XtraReports.UI.WinControlContainer()
        Me.TotalDeducciones = New System.Windows.Forms.TextBox()
        Me.WinControlContainer5 = New DevExpress.XtraReports.UI.WinControlContainer()
        Me.SubTotal = New System.Windows.Forms.TextBox()
        Me.WinControlContainer4 = New DevExpress.XtraReports.UI.WinControlContainer()
        Me.SalarioDiario = New System.Windows.Forms.TextBox()
        Me.WinControlContainer3 = New DevExpress.XtraReports.UI.WinControlContainer()
        Me.SalarioMensual = New System.Windows.Forms.TextBox()
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer()
        Me.NumIdentidadEmpleado = New System.Windows.Forms.TextBox()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel11, Me.WinControlContainer6, Me.WinControlContainer5, Me.WinControlContainer4, Me.WinControlContainer3, Me.WinControlContainer2, Me.WinControlContainer1, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLine1})
        Me.Detail.HeightF = 804.2468!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(275.1937!, 758.2466!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(212.5!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Nelson Humberto Paz Muñoz"
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(257.2045!, 781.2468!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(245.821!, 22.99994!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "Gerente Propietario de EVIPRIL"
        '
        'WinControlContainer6
        '
        Me.WinControlContainer6.LocationFloat = New DevExpress.Utils.PointFloat(611.0282!, 48.91667!)
        Me.WinControlContainer6.Name = "WinControlContainer6"
        Me.WinControlContainer6.SizeF = New System.Drawing.SizeF(104.3468!, 23.0!)
        Me.WinControlContainer6.WinControl = Me.TotalDeducciones
        '
        'TotalDeducciones
        '
        Me.TotalDeducciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TotalDeducciones.Enabled = False
        Me.TotalDeducciones.Location = New System.Drawing.Point(81, 34)
        Me.TotalDeducciones.Multiline = True
        Me.TotalDeducciones.Name = "TotalDeducciones"
        Me.TotalDeducciones.Size = New System.Drawing.Size(100, 22)
        Me.TotalDeducciones.TabIndex = 0
        '
        'WinControlContainer5
        '
        Me.WinControlContainer5.LocationFloat = New DevExpress.Utils.PointFloat(524.1531!, 48.91667!)
        Me.WinControlContainer5.Name = "WinControlContainer5"
        Me.WinControlContainer5.SizeF = New System.Drawing.SizeF(72.45197!, 23.0!)
        Me.WinControlContainer5.WinControl = Me.SubTotal
        '
        'SubTotal
        '
        Me.SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubTotal.Enabled = False
        Me.SubTotal.Location = New System.Drawing.Point(81, 34)
        Me.SubTotal.Multiline = True
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Size = New System.Drawing.Size(70, 22)
        Me.SubTotal.TabIndex = 0
        '
        'WinControlContainer4
        '
        Me.WinControlContainer4.LocationFloat = New DevExpress.Utils.PointFloat(380.8972!, 48.91667!)
        Me.WinControlContainer4.Name = "WinControlContainer4"
        Me.WinControlContainer4.SizeF = New System.Drawing.SizeF(132.4386!, 23.0!)
        Me.WinControlContainer4.WinControl = Me.SalarioDiario
        '
        'SalarioDiario
        '
        Me.SalarioDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalarioDiario.Enabled = False
        Me.SalarioDiario.Location = New System.Drawing.Point(81, 34)
        Me.SalarioDiario.Multiline = True
        Me.SalarioDiario.Name = "SalarioDiario"
        Me.SalarioDiario.Size = New System.Drawing.Size(127, 22)
        Me.SalarioDiario.TabIndex = 0
        '
        'WinControlContainer3
        '
        Me.WinControlContainer3.LocationFloat = New DevExpress.Utils.PointFloat(229.6949!, 48.91667!)
        Me.WinControlContainer3.Name = "WinControlContainer3"
        Me.WinControlContainer3.SizeF = New System.Drawing.SizeF(139.183!, 23.0!)
        Me.WinControlContainer3.WinControl = Me.SalarioMensual
        '
        'SalarioMensual
        '
        Me.SalarioMensual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalarioMensual.Enabled = False
        Me.SalarioMensual.Location = New System.Drawing.Point(81, 34)
        Me.SalarioMensual.Multiline = True
        Me.SalarioMensual.Name = "SalarioMensual"
        Me.SalarioMensual.Size = New System.Drawing.Size(134, 22)
        Me.SalarioMensual.TabIndex = 0
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.LocationFloat = New DevExpress.Utils.PointFloat(131.5795!, 48.91667!)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.SizeF = New System.Drawing.SizeF(86.09618!, 23.0!)
        Me.WinControlContainer2.WinControl = Me.Nombre
        '
        'Nombre
        '
        Me.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(81, 34)
        Me.Nombre.Multiline = True
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(83, 22)
        Me.Nombre.TabIndex = 0
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.LocationFloat = New DevExpress.Utils.PointFloat(27.70835!, 48.91667!)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.SizeF = New System.Drawing.SizeF(103.8711!, 23.0!)
        Me.WinControlContainer1.WinControl = Me.NumIdentidadEmpleado
        '
        'NumIdentidadEmpleado
        '
        Me.NumIdentidadEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumIdentidadEmpleado.Enabled = False
        Me.NumIdentidadEmpleado.Location = New System.Drawing.Point(81, 34)
        Me.NumIdentidadEmpleado.Multiline = True
        Me.NumIdentidadEmpleado.Name = "NumIdentidadEmpleado"
        Me.NumIdentidadEmpleado.Size = New System.Drawing.Size(100, 22)
        Me.NumIdentidadEmpleado.TabIndex = 0
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Silver
        Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(596.6051!, 10.00001!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(118.77!, 23.0!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.Text = "Total Prestaciones"
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Silver
        Me.XrLabel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(513.3358!, 10.00001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(83.26929!, 23.0!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.Text = "SubTotal"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Silver
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(368.8779!, 10.00005!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(144.4579!, 22.99998!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.Text = "Salario Ordinario Diario"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Silver
        Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(217.6757!, 10.00001!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(151.2023!, 22.99998!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.Text = "Salario ordinario Mensual"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Silver
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(131.5795!, 10.00001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(86.09618!, 23.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.Text = "Nombre"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Silver
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(27.70835!, 10.00001!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(103.8711!, 23.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.Text = "Codigo"
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(27.70835!, 32.99999!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(687.6667!, 12.58331!)
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
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1, Me.XrLabel8, Me.XrLabel9})
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
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(43.33334!, 68.04167!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(158.2034!, 23.0!)
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
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.XrPictureBox1, Me.XrLabel1, Me.XrLabel35, Me.XrLabel34})
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
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(27.70834!, 54.87502!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(115.693!, 77.41665!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
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
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents WinControlContainer6 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents TotalDeducciones As TextBox
    Friend WithEvents WinControlContainer5 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents SubTotal As TextBox
    Friend WithEvents WinControlContainer4 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents SalarioDiario As TextBox
    Friend WithEvents WinControlContainer3 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents SalarioMensual As TextBox
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents Nombre As TextBox
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents NumIdentidadEmpleado As TextBox
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
End Class
