﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class R0_ReportePedidosCosto
    Inherits Modelo.ModeloR01

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim tbEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R0_ReportePedidosCosto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbEstado = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.tbVendedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CheckTodosAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckTodosVendedor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.checkUnaVendedor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.tbCodigoVendedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbvendedor = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.tbFechaF = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.tbFechaI = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MGpFiltro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnSuperior.Style.GradientAngle = 90
        '
        'MPnInferior
        '
        Me.MPnInferior.Location = New System.Drawing.Point(300, 525)
        Me.MPnInferior.Margin = New System.Windows.Forms.Padding(2)
        Me.MPnInferior.Size = New System.Drawing.Size(684, 36)
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
        '
        'MPanelToolBarUsuario
        '
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(484, 0)
        Me.MPanelToolBarUsuario.Margin = New System.Windows.Forms.Padding(2)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Size = New System.Drawing.Size(135, 23)
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MBtSalir
        '
        '
        'MBtGenerar
        '
        '
        'MBubbleBarUsuario
        '
        '
        '
        '
        Me.MBubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.MBubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.MBubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'MGpFiltro
        '
        Me.MGpFiltro.Controls.Add(Me.GroupBox1)
        Me.MGpFiltro.Margin = New System.Windows.Forms.Padding(2)
        Me.MGpFiltro.Size = New System.Drawing.Size(300, 491)
        '
        '
        '
        Me.MGpFiltro.Style.BackColor = System.Drawing.SystemColors.Control
        Me.MGpFiltro.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MGpFiltro.Style.BackColorGradientAngle = 90
        Me.MGpFiltro.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderBottomWidth = 1
        Me.MGpFiltro.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MGpFiltro.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderLeftWidth = 1
        Me.MGpFiltro.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderRightWidth = 1
        Me.MGpFiltro.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderTopWidth = 1
        Me.MGpFiltro.Style.CornerDiameter = 4
        Me.MGpFiltro.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.MGpFiltro.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.MGpFiltro.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MGpFiltro.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.MGpFiltro.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MGpFiltro.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MGpFiltro.Controls.SetChildIndex(Me.GroupBox1, 0)
        '
        'MCrReporte
        '
        Me.MCrReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.MCrReporte.Size = New System.Drawing.Size(684, 561)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tbEstado)
        Me.GroupBox1.Controls.Add(Me.LabelX15)
        Me.GroupBox1.Controls.Add(Me.tbVendedor)
        Me.GroupBox1.Controls.Add(Me.CheckTodosAlmacen)
        Me.GroupBox1.Controls.Add(Me.CheckTodosVendedor)
        Me.GroupBox1.Controls.Add(Me.checkUnaVendedor)
        Me.GroupBox1.Controls.Add(Me.tbCodigoVendedor)
        Me.GroupBox1.Controls.Add(Me.lbvendedor)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.tbFechaF)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.tbFechaI)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 399)
        Me.GroupBox1.TabIndex = 236
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'tbEstado
        '
        Me.tbEstado.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        tbEstado_DesignTimeLayout.LayoutString = resources.GetString("tbEstado_DesignTimeLayout.LayoutString")
        Me.tbEstado.DesignTimeLayout = tbEstado_DesignTimeLayout
        Me.tbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEstado.Location = New System.Drawing.Point(108, 182)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.tbEstado.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.tbEstado.SelectedIndex = -1
        Me.tbEstado.SelectedItem = Nothing
        Me.tbEstado.Size = New System.Drawing.Size(155, 21)
        Me.tbEstado.TabIndex = 247
        Me.tbEstado.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LabelX15.Location = New System.Drawing.Point(6, 181)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(94, 23)
        Me.LabelX15.TabIndex = 246
        Me.LabelX15.Text = "Estado Pedido:"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbVendedor
        '
        Me.tbVendedor.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.tbVendedor.Border.Class = "TextBoxBorder"
        Me.tbVendedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbVendedor.Location = New System.Drawing.Point(9, 115)
        Me.tbVendedor.Name = "tbVendedor"
        Me.tbVendedor.PreventEnterBeep = True
        Me.tbVendedor.Size = New System.Drawing.Size(167, 22)
        Me.tbVendedor.TabIndex = 245
        '
        'CheckTodosAlmacen
        '
        '
        '
        '
        Me.CheckTodosAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckTodosAlmacen.Location = New System.Drawing.Point(294, 166)
        Me.CheckTodosAlmacen.Name = "CheckTodosAlmacen"
        Me.CheckTodosAlmacen.Size = New System.Drawing.Size(55, 23)
        Me.CheckTodosAlmacen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckTodosAlmacen.TabIndex = 244
        Me.CheckTodosAlmacen.Text = "Todos"
        '
        'CheckTodosVendedor
        '
        '
        '
        '
        Me.CheckTodosVendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckTodosVendedor.Location = New System.Drawing.Point(232, 114)
        Me.CheckTodosVendedor.Name = "CheckTodosVendedor"
        Me.CheckTodosVendedor.Size = New System.Drawing.Size(57, 23)
        Me.CheckTodosVendedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckTodosVendedor.TabIndex = 239
        Me.CheckTodosVendedor.Text = "Todos"
        '
        'checkUnaVendedor
        '
        '
        '
        '
        Me.checkUnaVendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkUnaVendedor.Location = New System.Drawing.Point(185, 114)
        Me.checkUnaVendedor.Name = "checkUnaVendedor"
        Me.checkUnaVendedor.Size = New System.Drawing.Size(44, 23)
        Me.checkUnaVendedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkUnaVendedor.TabIndex = 1
        Me.checkUnaVendedor.Text = "Una"
        '
        'tbCodigoVendedor
        '
        '
        '
        '
        Me.tbCodigoVendedor.Border.Class = "TextBoxBorder"
        Me.tbCodigoVendedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigoVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigoVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodigoVendedor.Location = New System.Drawing.Point(6, 153)
        Me.tbCodigoVendedor.Name = "tbCodigoVendedor"
        Me.tbCodigoVendedor.PreventEnterBeep = True
        Me.tbCodigoVendedor.Size = New System.Drawing.Size(22, 22)
        Me.tbCodigoVendedor.TabIndex = 238
        Me.tbCodigoVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbCodigoVendedor.Visible = False
        '
        'lbvendedor
        '
        Me.lbvendedor.AutoSize = True
        Me.lbvendedor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbvendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbvendedor.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbvendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbvendedor.Location = New System.Drawing.Point(9, 88)
        Me.lbvendedor.Name = "lbvendedor"
        Me.lbvendedor.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbvendedor.Size = New System.Drawing.Size(92, 16)
        Me.lbvendedor.TabIndex = 236
        Me.lbvendedor.Text = "Pre Vendedor:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(69, 49)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(52, 23)
        Me.LabelX2.TabIndex = 235
        Me.LabelX2.Text = "Al:"
        '
        'tbFechaF
        '
        '
        '
        '
        Me.tbFechaF.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaF.ButtonDropDown.Visible = True
        Me.tbFechaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaF.IsPopupCalendarOpen = False
        Me.tbFechaF.Location = New System.Drawing.Point(145, 49)
        '
        '
        '
        '
        '
        '
        Me.tbFechaF.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaF.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaF.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaF.Name = "tbFechaF"
        Me.tbFechaF.Size = New System.Drawing.Size(120, 22)
        Me.tbFechaF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaF.TabIndex = 234
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(66, 17)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX3.Size = New System.Drawing.Size(74, 23)
        Me.LabelX3.TabIndex = 233
        Me.LabelX3.Text = "Fecha Del:"
        '
        'tbFechaI
        '
        '
        '
        '
        Me.tbFechaI.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaI.ButtonDropDown.Visible = True
        Me.tbFechaI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaI.IsPopupCalendarOpen = False
        Me.tbFechaI.Location = New System.Drawing.Point(145, 18)
        '
        '
        '
        '
        '
        '
        Me.tbFechaI.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaI.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaI.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaI.Name = "tbFechaI"
        Me.tbFechaI.Size = New System.Drawing.Size(120, 22)
        Me.tbFechaI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaI.TabIndex = 232
        '
        'R0_ReportePedidosCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "R0_ReportePedidosCosto"
        Me.Text = "R0_ReportePedidosCosto"
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MPnSuperior.ResumeLayout(False)
        Me.MPnInferior.ResumeLayout(False)
        Me.MPanelToolBarUsuario.ResumeLayout(False)
        Me.MPanelToolBarUsuario.PerformLayout()
        Me.MPanelToolBarAccion.ResumeLayout(False)
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPnUsuario.ResumeLayout(False)
        Me.MPnUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MGpFiltro.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbVendedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CheckTodosAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckTodosVendedor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checkUnaVendedor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tbCodigoVendedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbvendedor As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFechaF As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFechaI As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbEstado As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
End Class
