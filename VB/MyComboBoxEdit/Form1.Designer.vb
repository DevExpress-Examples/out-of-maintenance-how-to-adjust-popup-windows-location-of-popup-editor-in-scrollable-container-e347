Imports Microsoft.VisualBasic
Imports System
Namespace MyComboBoxEdit
	Partial Public Class FormMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.comboBoxEdit9 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEdit8 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEdit7 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEdit6 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEdit5 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEdit4 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.comboBoxEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(385, 449)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.AutoScroll = True
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(379, 423)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.panelControl2)
			Me.panelControl1.Controls.Add(Me.comboBoxEdit6)
			Me.panelControl1.Controls.Add(Me.comboBoxEdit5)
			Me.panelControl1.Controls.Add(Me.comboBoxEdit4)
			Me.panelControl1.Controls.Add(Me.comboBoxEdit3)
			Me.panelControl1.Controls.Add(Me.comboBoxEdit2)
			Me.panelControl1.Controls.Add(Me.comboBoxEdit1)
			Me.panelControl1.Location = New System.Drawing.Point(1, -580)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(377, 1000)
			Me.panelControl1.TabIndex = 0
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.dateEdit1)
			Me.panelControl2.Controls.Add(Me.comboBoxEdit9)
			Me.panelControl2.Controls.Add(Me.comboBoxEdit8)
			Me.panelControl2.Controls.Add(Me.comboBoxEdit7)
			Me.panelControl2.Location = New System.Drawing.Point(10, 645)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(289, 199)
			Me.panelControl2.TabIndex = 8
			' 
			' comboBoxEdit9
			' 
			Me.comboBoxEdit9.Location = New System.Drawing.Point(22, 88)
			Me.comboBoxEdit9.Name = "comboBoxEdit9"
			Me.comboBoxEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit9.Properties.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6", "7"})
			Me.comboBoxEdit9.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit9.TabIndex = 2
			' 
			' comboBoxEdit8
			' 
			Me.comboBoxEdit8.Location = New System.Drawing.Point(22, 53)
			Me.comboBoxEdit8.Name = "comboBoxEdit8"
			Me.comboBoxEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit8.Properties.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6"})
			Me.comboBoxEdit8.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit8.TabIndex = 1
			' 
			' comboBoxEdit7
			' 
			Me.comboBoxEdit7.Location = New System.Drawing.Point(19, 21)
			Me.comboBoxEdit7.Name = "comboBoxEdit7"
			Me.comboBoxEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit7.Properties.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6"})
			Me.comboBoxEdit7.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit7.TabIndex = 0
			' 
			' comboBoxEdit6
			' 
			Me.comboBoxEdit6.Location = New System.Drawing.Point(116, 34)
			Me.comboBoxEdit6.Name = "comboBoxEdit6"
			Me.comboBoxEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit6.Properties.Items.AddRange(New Object() { "item1", "item2", "item3"})
			Me.comboBoxEdit6.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit6.TabIndex = 5
			' 
			' comboBoxEdit5
			' 
			Me.comboBoxEdit5.Location = New System.Drawing.Point(10, 964)
			Me.comboBoxEdit5.Name = "comboBoxEdit5"
			Me.comboBoxEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit5.Properties.Items.AddRange(New Object() { "item1", "item2", "item3"})
			Me.comboBoxEdit5.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit5.TabIndex = 4
			' 
			' comboBoxEdit4
			' 
			Me.comboBoxEdit4.Location = New System.Drawing.Point(131, 481)
			Me.comboBoxEdit4.Name = "comboBoxEdit4"
			Me.comboBoxEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit4.Properties.Items.AddRange(New Object() { "item1", "item2", "item3"})
			Me.comboBoxEdit4.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit4.TabIndex = 3
			' 
			' comboBoxEdit3
			' 
			Me.comboBoxEdit3.Location = New System.Drawing.Point(11, 907)
			Me.comboBoxEdit3.Name = "comboBoxEdit3"
			Me.comboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit3.Properties.Items.AddRange(New Object() { "item1", "item2", "item3"})
			Me.comboBoxEdit3.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit3.TabIndex = 2
			' 
			' comboBoxEdit2
			' 
			Me.comboBoxEdit2.Location = New System.Drawing.Point(25, 481)
			Me.comboBoxEdit2.Name = "comboBoxEdit2"
			Me.comboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit2.Properties.Items.AddRange(New Object() { "item1", "item2", "item3"})
			Me.comboBoxEdit2.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit2.TabIndex = 1
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Location = New System.Drawing.Point(10, 34)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { "item1", "item2", "item3"})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEdit1.TabIndex = 0
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(379, 423)
			Me.xtraTabPage2.Text = "xtraTabPage2"
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(19, 126)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(100, 20)
			Me.dateEdit1.TabIndex = 3
			' 
			' FormMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(385, 449)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "FormMain"
			Me.Text = "Main form"
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.comboBoxEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private comboBoxEdit6 As DevExpress.XtraEditors.ComboBoxEdit
		Private comboBoxEdit5 As DevExpress.XtraEditors.ComboBoxEdit
		Private comboBoxEdit4 As DevExpress.XtraEditors.ComboBoxEdit
		Private comboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
		Private comboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
		Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private comboBoxEdit9 As DevExpress.XtraEditors.ComboBoxEdit
		Private comboBoxEdit8 As DevExpress.XtraEditors.ComboBoxEdit
		Private comboBoxEdit7 As DevExpress.XtraEditors.ComboBoxEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit


	End Class
End Namespace

