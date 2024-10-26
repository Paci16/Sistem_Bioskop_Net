<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LokasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamafilmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TJadwalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BadutCinemaDataSet1 = New Sistem_Bioskop_Net.BadutCinemaDataSet1()
        Me.BadutCinemaDataSet = New Sistem_Bioskop_Net.BadutCinemaDataSet()
        Me.BadutCinemaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TJadwalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TJadwalTableAdapter = New Sistem_Bioskop_Net.BadutCinemaDataSet1TableAdapters.TJadwalTableAdapter()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TJadwalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadutCinemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadutCinemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadutCinemaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TJadwalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Jakarta", "Bandung", "Semarang", "Tangerang", "Bekasi", "Surabaya"})
        Me.ComboBox1.Location = New System.Drawing.Point(423, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(220, 24)
        Me.ComboBox1.TabIndex = 37
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(26, 449)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(247, 22)
        Me.DateTimePicker1.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 500)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 34)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Jadwal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 34)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Memilih tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(773, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 29)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "The Nun 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 29)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Fast and Furious"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(554, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 29)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Tegar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(303, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 29)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Suzume"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(311, 541)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 29)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "20.25"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(214, 541)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 29)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "18.05"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(121, 541)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 29)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "15.45"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 541)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 29)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "13.25"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(292, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Snow
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(692, 541)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 31)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Pilih Tempat Duduk"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(270, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 34)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Location"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LokasiDataGridViewTextBoxColumn, Me.NamafilmDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn, Me.JamDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TJadwalBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 58
        Me.DataGridView1.Visible = False
        '
        'LokasiDataGridViewTextBoxColumn
        '
        Me.LokasiDataGridViewTextBoxColumn.DataPropertyName = "lokasi"
        Me.LokasiDataGridViewTextBoxColumn.HeaderText = "lokasi"
        Me.LokasiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LokasiDataGridViewTextBoxColumn.Name = "LokasiDataGridViewTextBoxColumn"
        Me.LokasiDataGridViewTextBoxColumn.Width = 125
        '
        'NamafilmDataGridViewTextBoxColumn
        '
        Me.NamafilmDataGridViewTextBoxColumn.DataPropertyName = "namafilm"
        Me.NamafilmDataGridViewTextBoxColumn.HeaderText = "namafilm"
        Me.NamafilmDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamafilmDataGridViewTextBoxColumn.Name = "NamafilmDataGridViewTextBoxColumn"
        Me.NamafilmDataGridViewTextBoxColumn.Width = 125
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        Me.TanggalDataGridViewTextBoxColumn.Width = 125
        '
        'JamDataGridViewTextBoxColumn
        '
        Me.JamDataGridViewTextBoxColumn.DataPropertyName = "jam"
        Me.JamDataGridViewTextBoxColumn.HeaderText = "jam"
        Me.JamDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JamDataGridViewTextBoxColumn.Name = "JamDataGridViewTextBoxColumn"
        Me.JamDataGridViewTextBoxColumn.Width = 125
        '
        'TJadwalBindingSource1
        '
        Me.TJadwalBindingSource1.DataMember = "TJadwal"
        Me.TJadwalBindingSource1.DataSource = Me.BadutCinemaDataSet1
        '
        'BadutCinemaDataSet1
        '
        Me.BadutCinemaDataSet1.DataSetName = "BadutCinemaDataSet1"
        Me.BadutCinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BadutCinemaDataSet
        '
        Me.BadutCinemaDataSet.DataSetName = "BadutCinemaDataSet"
        Me.BadutCinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BadutCinemaDataSetBindingSource
        '
        Me.BadutCinemaDataSetBindingSource.DataSource = Me.BadutCinemaDataSet
        Me.BadutCinemaDataSetBindingSource.Position = 0
        '
        'TJadwalBindingSource
        '
        Me.TJadwalBindingSource.DataMember = "TJadwal"
        Me.TJadwalBindingSource.DataSource = Me.BadutCinemaDataSet1
        '
        'TJadwalTableAdapter
        '
        Me.TJadwalTableAdapter.ClearBeforeFill = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Sistem_Bioskop_Net.My.Resources.Resources.Badut_cinema__4_
        Me.PictureBox5.Location = New System.Drawing.Point(250, 27)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 34)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 57
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Sistem_Bioskop_Net.My.Resources.Resources.The_Nun_II__2023_
        Me.PictureBox4.Location = New System.Drawing.Point(750, 132)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(168, 260)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 56
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sistem_Bioskop_Net.My.Resources.Resources.Film_Tegar
        Me.PictureBox3.Location = New System.Drawing.Point(510, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(168, 260)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistem_Bioskop_Net.My.Resources.Resources.Suzume_no_Tojimari_poster
        Me.PictureBox2.Location = New System.Drawing.Point(266, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 253)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistem_Bioskop_Net.My.Resources.Resources.FFX
        Me.PictureBox1.Location = New System.Drawing.Point(26, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 259)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "LOGOUT"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(944, 601)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TJadwalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadutCinemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadutCinemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadutCinemaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TJadwalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BadutCinemaDataSet As BadutCinemaDataSet
    Friend WithEvents BadutCinemaDataSetBindingSource As BindingSource
    Friend WithEvents BadutCinemaDataSet1 As BadutCinemaDataSet1
    Friend WithEvents TJadwalBindingSource As BindingSource
    Friend WithEvents TJadwalTableAdapter As BadutCinemaDataSet1TableAdapters.TJadwalTableAdapter
    Friend WithEvents LokasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamafilmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TJadwalBindingSource1 As BindingSource
    Friend WithEvents Label13 As Label
End Class
