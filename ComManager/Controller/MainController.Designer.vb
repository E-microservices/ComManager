<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainController
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainController))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutePToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterPrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Publisher = New System.Windows.Forms.DataGridView()
        Me.id_Pu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_Pu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.liens = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prospect = New System.Windows.Forms.DataGridView()
        Me.id_pr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_pr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conclud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ETAT_CONNEXION = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Publisher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prospect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ConnexionToolStripMenuItem, Me.ActualiserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1039, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutePToolStripMenuItem, Me.AjouterPrToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'AjoutePToolStripMenuItem
        '
        Me.AjoutePToolStripMenuItem.Name = "AjoutePToolStripMenuItem"
        Me.AjoutePToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AjoutePToolStripMenuItem.Text = "Ajoute Pu"
        '
        'AjouterPrToolStripMenuItem
        '
        Me.AjouterPrToolStripMenuItem.Name = "AjouterPrToolStripMenuItem"
        Me.AjouterPrToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AjouterPrToolStripMenuItem.Text = "Ajouter Pr"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ConnexionToolStripMenuItem
        '
        Me.ConnexionToolStripMenuItem.Name = "ConnexionToolStripMenuItem"
        Me.ConnexionToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ConnexionToolStripMenuItem.Text = "Connexion"
        '
        'ActualiserToolStripMenuItem
        '
        Me.ActualiserToolStripMenuItem.Name = "ActualiserToolStripMenuItem"
        Me.ActualiserToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualiserToolStripMenuItem.Text = "Actualiser"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1039, 566)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(865, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PROSPECTIONS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PUBLICATIONS"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Publisher)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Prospect)
        Me.SplitContainer2.Size = New System.Drawing.Size(1039, 537)
        Me.SplitContainer2.SplitterDistance = 522
        Me.SplitContainer2.TabIndex = 2
        '
        'Publisher
        '
        Me.Publisher.AllowUserToAddRows = False
        Me.Publisher.AllowUserToDeleteRows = False
        Me.Publisher.AllowUserToOrderColumns = True
        Me.Publisher.AllowUserToResizeRows = False
        Me.Publisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Publisher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Pu, Me.date_Pu, Me.gName, Me.liens, Me.member})
        Me.Publisher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Publisher.Location = New System.Drawing.Point(0, 0)
        Me.Publisher.Name = "Publisher"
        Me.Publisher.Size = New System.Drawing.Size(522, 537)
        Me.Publisher.TabIndex = 0
        '
        'id_Pu
        '
        Me.id_Pu.HeaderText = "id"
        Me.id_Pu.Name = "id_Pu"
        Me.id_Pu.Visible = False
        '
        'date_Pu
        '
        Me.date_Pu.HeaderText = "Date"
        Me.date_Pu.Name = "date_Pu"
        '
        'gName
        '
        Me.gName.HeaderText = "Nom du groupe"
        Me.gName.Name = "gName"
        Me.gName.Width = 200
        '
        'liens
        '
        Me.liens.HeaderText = "Liens de publication"
        Me.liens.Name = "liens"
        Me.liens.Width = 250
        '
        'member
        '
        Me.member.HeaderText = "Nombre de membre"
        Me.member.Name = "member"
        Me.member.Width = 150
        '
        'Prospect
        '
        Me.Prospect.AllowUserToAddRows = False
        Me.Prospect.AllowUserToDeleteRows = False
        Me.Prospect.AllowUserToOrderColumns = True
        Me.Prospect.AllowUserToResizeRows = False
        Me.Prospect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Prospect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pr, Me.date_pr, Me.name_pr, Me.interet, Me.observ, Me.conclud})
        Me.Prospect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Prospect.Location = New System.Drawing.Point(0, 0)
        Me.Prospect.Name = "Prospect"
        Me.Prospect.Size = New System.Drawing.Size(513, 537)
        Me.Prospect.TabIndex = 0
        '
        'id_pr
        '
        Me.id_pr.HeaderText = "id"
        Me.id_pr.Name = "id_pr"
        Me.id_pr.Visible = False
        '
        'date_pr
        '
        Me.date_pr.HeaderText = "Date"
        Me.date_pr.Name = "date_pr"
        Me.date_pr.Width = 150
        '
        'name_pr
        '
        Me.name_pr.HeaderText = "Nom et numero"
        Me.name_pr.Name = "name_pr"
        Me.name_pr.Width = 250
        '
        'interet
        '
        Me.interet.HeaderText = "Interets"
        Me.interet.Name = "interet"
        Me.interet.Width = 250
        '
        'observ
        '
        Me.observ.HeaderText = "Observation"
        Me.observ.Name = "observ"
        Me.observ.Width = 200
        '
        'conclud
        '
        Me.conclud.HeaderText = "Conclusion"
        Me.conclud.Name = "conclud"
        Me.conclud.Width = 200
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ETAT_CONNEXION})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 568)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1039, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusLabel1.Text = "Etat: "
        '
        'ETAT_CONNEXION
        '
        Me.ETAT_CONNEXION.Name = "ETAT_CONNEXION"
        Me.ETAT_CONNEXION.Size = New System.Drawing.Size(74, 17)
        Me.ETAT_CONNEXION.Text = "Deconnecter"
        '
        'MainController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainController"
        Me.Text = "MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Publisher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prospect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutePToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterPrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Publisher As DataGridView
    Friend WithEvents Prospect As DataGridView
    Friend WithEvents ConnexionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ETAT_CONNEXION As ToolStripStatusLabel
    Friend WithEvents ActualiserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents id_pr As DataGridViewTextBoxColumn
    Friend WithEvents date_pr As DataGridViewTextBoxColumn
    Friend WithEvents name_pr As DataGridViewTextBoxColumn
    Friend WithEvents interet As DataGridViewTextBoxColumn
    Friend WithEvents observ As DataGridViewTextBoxColumn
    Friend WithEvents conclud As DataGridViewTextBoxColumn
    Friend WithEvents id_Pu As DataGridViewTextBoxColumn
    Friend WithEvents date_Pu As DataGridViewTextBoxColumn
    Friend WithEvents gName As DataGridViewTextBoxColumn
    Friend WithEvents liens As DataGridViewTextBoxColumn
    Friend WithEvents member As DataGridViewTextBoxColumn
End Class
