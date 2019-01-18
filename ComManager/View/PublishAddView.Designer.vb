<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PublishAddView
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_DATE = New System.Windows.Forms.TextBox()
        Me.TXT_GROUP_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_LINK = New System.Windows.Forms.TextBox()
        Me.TXT_NUMBER_OF_MEMBER = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nom du groupe/Page web"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Liens de publication"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre de membre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TXT_DATE
        '
        Me.TXT_DATE.Location = New System.Drawing.Point(210, 21)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.ReadOnly = True
        Me.TXT_DATE.Size = New System.Drawing.Size(108, 20)
        Me.TXT_DATE.TabIndex = 0
        '
        'TXT_GROUP_NAME
        '
        Me.TXT_GROUP_NAME.Location = New System.Drawing.Point(210, 61)
        Me.TXT_GROUP_NAME.Name = "TXT_GROUP_NAME"
        Me.TXT_GROUP_NAME.Size = New System.Drawing.Size(463, 20)
        Me.TXT_GROUP_NAME.TabIndex = 1
        '
        'TXT_LINK
        '
        Me.TXT_LINK.Location = New System.Drawing.Point(210, 93)
        Me.TXT_LINK.Name = "TXT_LINK"
        Me.TXT_LINK.Size = New System.Drawing.Size(463, 20)
        Me.TXT_LINK.TabIndex = 2
        '
        'TXT_NUMBER_OF_MEMBER
        '
        Me.TXT_NUMBER_OF_MEMBER.Location = New System.Drawing.Point(210, 132)
        Me.TXT_NUMBER_OF_MEMBER.Name = "TXT_NUMBER_OF_MEMBER"
        Me.TXT_NUMBER_OF_MEMBER.Size = New System.Drawing.Size(463, 20)
        Me.TXT_NUMBER_OF_MEMBER.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(628, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Enregister"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(547, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PublishAddView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_NUMBER_OF_MEMBER)
        Me.Controls.Add(Me.TXT_LINK)
        Me.Controls.Add(Me.TXT_GROUP_NAME)
        Me.Controls.Add(Me.TXT_DATE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PublishAddView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PublishAddView"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_DATE As TextBox
    Friend WithEvents TXT_GROUP_NAME As TextBox
    Friend WithEvents TXT_LINK As TextBox
    Friend WithEvents TXT_NUMBER_OF_MEMBER As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
