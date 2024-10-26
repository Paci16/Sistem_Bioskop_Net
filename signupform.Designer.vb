<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signupform
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BadutCinemaDataSet = New Sistem_Bioskop_Net.BadutCinemaDataSet()
        Me.BadutCinemaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TUserTableAdapter = New Sistem_Bioskop_Net.BadutCinemaDataSetTableAdapters.TUserTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadutCinemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadutCinemaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(346, 484)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "CONTINUE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(155, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(155, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 18)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 16)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "to enjoy all the benefits of your membership!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "SIGN UP"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(156, 335)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(470, 22)
        Me.TextBox1.TabIndex = 63
        Me.TextBox1.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(501, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 49)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "CINEMA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(122, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 49)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "BADUT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(155, 412)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(470, 22)
        Me.TextBox2.TabIndex = 71
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistem_Bioskop_Net.My.Resources.Resources.Badut_cinema__3_
        Me.PictureBox1.Location = New System.Drawing.Point(303, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmailDataGridViewTextBoxColumn, Me.PassDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TUserBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(778, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 72
        Me.DataGridView1.Visible = False
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
        'BadutCinemaDataSetBindingSource
        '
        Me.BadutCinemaDataSetBindingSource.DataSource = Me.BadutCinemaDataSet
        Me.BadutCinemaDataSetBindingSource.Position = 0
        '
        'TUserTableAdapter
        '
        Me.TUserTableAdapter.ClearBeforeFill = True
        '
        'signupform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 536)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "signupform"
        Me.Text = "signupform"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadutCinemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadutCinemaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BadutCinemaDataSetBindingSource As BindingSource
    Friend WithEvents BadutCinemaDataSet As BadutCinemaDataSet
    Friend WithEvents TUserBindingSource As BindingSource
    Friend WithEvents TUserTableAdapter As BadutCinemaDataSetTableAdapters.TUserTableAdapter
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
