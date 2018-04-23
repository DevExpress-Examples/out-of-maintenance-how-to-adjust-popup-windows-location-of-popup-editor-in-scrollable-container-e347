Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors



Namespace MyComboBoxEdit
	Partial Public Class FormMain
		Inherits Form
		Private popupHelper As MyPopupHelper


		Public Sub New()
			InitializeComponent()
			popupHelper = New MyPopupHelper(panelControl1)
		End Sub
	End Class
End Namespace
