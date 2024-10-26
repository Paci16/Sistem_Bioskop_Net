<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barcode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BadutCinemaDataSet3 = New Sistem_Bioskop_Net.BadutCinemaDataSet3()
        Me.TPemesananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPemesananTableAdapter = New Sistem_Bioskop_Net.BadutCinemaDataSet3TableAdapters.TPemesananTableAdapter()
        Me.KODEpemesananDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadutCinemaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPemesananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistem_Bioskop_Net.My.Resources.Resources.barcode
        Me.PictureBox1.Location = New System.Drawing.Point(46, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(404, 378)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(213, 474)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(41, 474)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Kode Tiket :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODEpemesananDataGridViewTextBoxColumn, Me.FEmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TPemesananBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(479, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 17
        Me.DataGridView1.Visible = False
        '
        'BadutCinemaDataSet3
        '
        Me.BadutCinemaDataSet3.DataSetName = "BadutCinemaDataSet3"
        Me.BadutCinemaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TPemesananBindingSource
        '
        Me.TPemesananBindingSource.DataMember = "TPemesanan"
        Me.TPemesananBindingSource.DataSource = Me.BadutCinemaDataSet3
        '
        'TPemesananTableAdapter
        '
        Me.TPemesananTableAdapter.ClearBeforeFill = True
        '
        'KODEpemesananDataGridViewTextBoxColumn
        '
        Me.KODEpemesananDataGridViewTextBoxColumn.DataPropertyName = "KODEpemesanan"
        Me.KODEpemesananDataGridViewTextBoxColumn.HeaderText = "KODEpemesanan"
        Me.KODEpemesananDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KODEpemesananDataGridViewTextBoxColumn.Name = "KODEpemesananDataGridViewTextBoxColumn"
        Me.KODEpemesananDataGridViewTextBoxColumn.Width = 125
        '
        'FEmailDataGridViewTextBoxColumn
        '
        Me.FEmailDataGridViewTextBoxColumn.DataPropertyName = "FEmail"
        Me.FEmailDataGridViewTextBoxColumn.HeaderText = "FEmail"
        Me.FEmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FEmailDataGridViewTextBoxColumn.Name = "FEmailDataGridViewTextBoxColumn"
        Me.FEmailDataGridViewTextBoxColumn.Width = 125
        '
        'barcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 553)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "barcode"
        Me.Text = "barcode"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadutCinemaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPemesananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BadutCinemaDataSet3 As BadutCinemaDataSet3
    Friend WithEvents TPemesananBindingSource As BindingSource
    Friend WithEvents TPemesananTableAdapter As BadutCinemaDataSet3TableAdapters.TPemesananTableAdapter
    Friend WithEvents KODEpemesananDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
