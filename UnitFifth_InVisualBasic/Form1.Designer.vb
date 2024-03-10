<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.page2 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.chSequential = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.chDirect = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabPage4 = New System.Windows.Forms.TabPage()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.page2.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        CType(Me.chSequential, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage3.SuspendLayout()
        CType(Me.chDirect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage4.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'page2
        '
        Me.page2.Controls.Add(Me.tabPage1)
        Me.page2.Controls.Add(Me.tabPage2)
        Me.page2.Controls.Add(Me.tabPage3)
        Me.page2.Controls.Add(Me.tabPage4)
        Me.page2.Location = New System.Drawing.Point(4, 2)
        Me.page2.Name = "page2"
        Me.page2.SelectedIndex = 0
        Me.page2.Size = New System.Drawing.Size(1491, 700)
        Me.page2.TabIndex = 20
        '
        'tabPage1
        '
        Me.tabPage1.BackColor = System.Drawing.Color.Gray
        Me.tabPage1.Controls.Add(Me.dgvTable)
        Me.tabPage1.Controls.Add(Me.label3)
        Me.tabPage1.Controls.Add(Me.btnUpdate)
        Me.tabPage1.Location = New System.Drawing.Point(4, 25)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(1483, 671)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Beggining"
        '
        'dgvTable
        '
        Me.dgvTable.AllowUserToAddRows = False
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvTable.Location = New System.Drawing.Point(466, 133)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.RowHeadersVisible = False
        Me.dgvTable.RowHeadersWidth = 51
        Me.dgvTable.RowTemplate.Height = 24
        Me.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTable.Size = New System.Drawing.Size(637, 283)
        Me.dgvTable.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "File Organization"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Initial Cost"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Operating Cost"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Security Level"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Ease of Access"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(582, 91)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(380, 38)
        Me.label3.TabIndex = 2
        Me.label3.Text = "COST BENEFIT CHART"
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(646, 422)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(258, 43)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "GRAPH"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.chSequential)
        Me.tabPage2.Location = New System.Drawing.Point(4, 25)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(1483, 671)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Sequential"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'chSequential
        '
        ChartArea6.Name = "ChartArea1"
        Me.chSequential.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.chSequential.Legends.Add(Legend6)
        Me.chSequential.Location = New System.Drawing.Point(0, 6)
        Me.chSequential.Name = "chSequential"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.chSequential.Series.Add(Series6)
        Me.chSequential.Size = New System.Drawing.Size(1477, 654)
        Me.chSequential.TabIndex = 0
        Me.chSequential.Text = "Chart1"
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.chDirect)
        Me.tabPage3.Location = New System.Drawing.Point(4, 25)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(1483, 671)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Direct"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'chDirect
        '
        ChartArea4.Name = "ChartArea1"
        Me.chDirect.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chDirect.Legends.Add(Legend4)
        Me.chDirect.Location = New System.Drawing.Point(3, 8)
        Me.chDirect.Name = "chDirect"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.chDirect.Series.Add(Series4)
        Me.chDirect.Size = New System.Drawing.Size(1477, 654)
        Me.chDirect.TabIndex = 1
        Me.chDirect.Text = "Chart2"
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.Chart3)
        Me.tabPage4.Location = New System.Drawing.Point(4, 25)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Size = New System.Drawing.Size(1483, 671)
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "Indexed"
        Me.tabPage4.UseVisualStyleBackColor = True
        '
        'Chart3
        '
        ChartArea5.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend5)
        Me.Chart3.Location = New System.Drawing.Point(3, 8)
        Me.Chart3.Name = "Chart3"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.Chart3.Series.Add(Series5)
        Me.Chart3.Size = New System.Drawing.Size(1477, 654)
        Me.Chart3.TabIndex = 1
        Me.Chart3.Text = "Chart3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1499, 699)
        Me.Controls.Add(Me.page2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.page2.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        CType(Me.chSequential, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage3.ResumeLayout(False)
        CType(Me.chDirect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage4.ResumeLayout(False)
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents page2 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents dgvTable As DataGridView
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents label3 As Label
    Private WithEvents btnUpdate As Button
    Private WithEvents tabPage2 As TabPage
    Private WithEvents tabPage3 As TabPage
    Private WithEvents tabPage4 As TabPage
    Friend WithEvents chSequential As DataVisualization.Charting.Chart
    Friend WithEvents chDirect As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
End Class
