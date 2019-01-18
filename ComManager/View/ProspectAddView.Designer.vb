<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProspectAddView
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXT_OBSERVATION = New System.Windows.Forms.TextBox()
        Me.TXT_INTERET = New System.Windows.Forms.TextBox()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_DATE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CONCLUSION = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(547, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(628, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Enregister"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXT_OBSERVATION
        '
        Me.TXT_OBSERVATION.Location = New System.Drawing.Point(210, 132)
        Me.TXT_OBSERVATION.Name = "TXT_OBSERVATION"
        Me.TXT_OBSERVATION.Size = New System.Drawing.Size(463, 20)
        Me.TXT_OBSERVATION.TabIndex = 3
        '
        'TXT_INTERET
        '
        Me.TXT_INTERET.Location = New System.Drawing.Point(210, 93)
        Me.TXT_INTERET.Name = "TXT_INTERET"
        Me.TXT_INTERET.Size = New System.Drawing.Size(463, 20)
        Me.TXT_INTERET.TabIndex = 2
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(210, 61)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(463, 20)
        Me.TXT_NAME.TabIndex = 1
        '
        'TXT_DATE
        '
        Me.TXT_DATE.Location = New System.Drawing.Point(210, 21)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.ReadOnly = True
        Me.TXT_DATE.Size = New System.Drawing.Size(108, 20)
        Me.TXT_DATE.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Conclusion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Observation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nom ou numéro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Interets"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'TXT_CONCLUSION
        '
        Me.TXT_CONCLUSION.Location = New System.Drawing.Point(210, 172)
        Me.TXT_CONCLUSION.Name = "TXT_CONCLUSION"
        Me.TXT_CONCLUSION.Size = New System.Drawing.Size(463, 20)
        Me.TXT_CONCLUSION.TabIndex = 4
        '
        'ProspectAddView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_CONCLUSION)
        Me.Controls.Add(Me.TXT_OBSERVATION)
        Me.Controls.Add(Me.TXT_INTERET)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.TXT_DATE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProspectAddView"
        Me.Text = "ProspectAddView"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TXT_OBSERVATION As TextBox
    Friend WithEvents TXT_INTERET As TextBox
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents TXT_DATE As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CONCLUSION As TextBox
End Class
