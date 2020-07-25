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
        Me.components = New System.ComponentModel.Container
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnModifica = New System.Windows.Forms.Button
        Me.btnSalva = New System.Windows.Forms.Button
        Me.btnConsulta = New System.Windows.Forms.Button
        Me.MSK_FORNECEDORDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MSK_FORNECEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MascaraTeste = New GridFullEdit.WSGrid.MascaraTeste
        Me.Panel1.SuspendLayout()
        CType(Me.MSK_FORNECEDORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSK_FORNECEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MascaraTeste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(33, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(396, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(312, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(271, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "MD5"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnModifica)
        Me.Panel1.Controls.Add(Me.btnSalva)
        Me.Panel1.Controls.Add(Me.btnConsulta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 477)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 100)
        Me.Panel1.TabIndex = 5
        '
        'btnModifica
        '
        Me.btnModifica.Location = New System.Drawing.Point(378, 37)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(75, 23)
        Me.btnModifica.TabIndex = 2
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'btnSalva
        '
        Me.btnSalva.Location = New System.Drawing.Point(182, 44)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnSalva.TabIndex = 1
        Me.btnSalva.Text = "Salva"
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(64, 44)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnConsulta.TabIndex = 0
        Me.btnConsulta.Text = "Consulta"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'MSK_FORNECEDORDataGridView
        '
        Me.MSK_FORNECEDORDataGridView.AutoGenerateColumns = False
        Me.MSK_FORNECEDORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MSK_FORNECEDORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.MSK_FORNECEDORDataGridView.DataSource = Me.MSK_FORNECEDORBindingSource
        Me.MSK_FORNECEDORDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MSK_FORNECEDORDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MSK_FORNECEDORDataGridView.Name = "MSK_FORNECEDORDataGridView"
        Me.MSK_FORNECEDORDataGridView.Size = New System.Drawing.Size(839, 477)
        Me.MSK_FORNECEDORDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CD_FORNECEDOR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CD_FORNECEDOR"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NM_PESSOA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NM_PESSOA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NM_CONTATO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NM_CONTATO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TE_CONTATO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TE_CONTATO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TE_CORPORATIVO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TE_CORPORATIVO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TE_FAX"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TE_FAX"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'MSK_FORNECEDORBindingSource
        '
        Me.MSK_FORNECEDORBindingSource.DataMember = "MSK_FORNECEDOR"
        Me.MSK_FORNECEDORBindingSource.DataSource = Me.MascaraTeste
        '
        'MascaraTeste
        '
        Me.MascaraTeste.DataSetName = "MascaraTeste"
        Me.MascaraTeste.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 577)
        Me.Controls.Add(Me.MSK_FORNECEDORDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.MSK_FORNECEDORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSK_FORNECEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MascaraTeste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents MascaraTeste As GridFullEdit.WSGrid.MascaraTeste
    Friend WithEvents MSK_FORNECEDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MSK_FORNECEDORDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
