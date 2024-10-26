<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BadutCinemaDataSet = New Sistem_Bioskop_Net.BadutCinemaDataSet()
        Me.TUserTableAdapter = New Sistem_Bioskop_Net.BadutCinemaDataSetTableAdapters.TUserTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TUserBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadutCinemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUserBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(73, 373)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(470, 22)
        Me.TextBox2.TabIndex = 43
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 542)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(617, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Email Address"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 281)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(470, 22)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(59, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 49)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "BADUT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(398, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 49)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "CINEMA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(332, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "REGISTER NOW!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(149, 473)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 16)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Don't have an account yet?"
        '
        'TUserBindingSource
        '
        Me.TUserBindingSource.DataMember = "TUser"
        Me.TUserBindingSource.DataSource = Me.BadutCinemaDataSet
        '
        'BadutCinemaDataSet
        '
        Me.BadutCinemaDataSet.DataSetName = "BadutCinemaDataSet"
        Me.BadutCinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TUserTableAdapter
        '
        Me.TUserTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmailDataGridViewTextBoxColumn, Me.PassDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TUserBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(595, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 75
        Me.DataGridView1.Visible = False
        '
        'TUserBindingSource1
        '
        Me.TUserBindingSource1.DataMember = "TUser"
        Me.TUserBindingSource1.DataSource = Me.BadutCinemaDataSet
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'PassDataGridViewTextBoxColumn
        '
        Me.PassDataGridViewTextBoxColumn.DataPropertyName = "Pass"
        Me.PassDataGridViewTextBoxColumn.HeaderText = "Pass"
        Me.PassDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PassDataGridViewTextBoxColumn.Name = "PassDataGridViewTextBoxColumn"
        Me.PassDataGridViewTextBoxColumn.Width = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistem_Bioskop_Net.My.Resources.Resources.Badut_cinema__3_
        Me.PictureBox1.Location = New System.Drawing.Point(214, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(617, 565)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadutCinemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUserBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BadutCinemaDataSet As BadutCinemaDataSet
    Friend WithEvents TUserBindingSource As BindingSource
    Friend WithEvents TUserTableAdapter As BadutCinemaDataSetTableAdapters.TUserTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TUserBindingSource1 As BindingSource
End Class
