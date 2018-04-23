Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors



Namespace MyComboBoxEdit
	Public Class MyPopupHelper
		Private handleGotFocus As EventHandler
		Private scrControl As ScrollableControl



		Public Sub New(ByVal scrControl As ScrollableControl)
			handleGotFocus = Nothing
			Me.scrControl = Nothing
			If scrControl IsNot Nothing Then
				handleGotFocus = New EventHandler(AddressOf OnGotFocus)
				Me.scrControl = scrControl
				SetEvents(Me.scrControl)
			End If
		End Sub



		Private Sub SetEvents(ByVal sContrl As ScrollableControl)
			For Each contr As Control In sContrl.Controls
				Dim s_contrl As ScrollableControl = TryCast(contr, ScrollableControl)
				If s_contrl IsNot Nothing Then
					SetEvents(s_contrl)
					Continue For
				End If

				Dim pbe As PopupBaseEdit = TryCast(contr, PopupBaseEdit)
				If pbe Is Nothing Then
					Continue For
				End If
				AddHandler pbe.GotFocus, handleGotFocus
			Next contr
		End Sub



		Private Sub UnsetEvents(ByVal sContrl As ScrollableControl)
			For Each contr As Control In sContrl.Controls
				Dim s_contrl As ScrollableControl = TryCast(contr, ScrollableControl)
				If s_contrl IsNot Nothing Then
					UnsetEvents(s_contrl)
					Continue For
				End If

				Dim pbe As PopupBaseEdit = TryCast(contr, PopupBaseEdit)
				If pbe Is Nothing Then
					Continue For
				End If
				RemoveHandler pbe.GotFocus, handleGotFocus
			Next contr
		End Sub



		Private Sub OnGotFocus(ByVal sender As Object, ByVal e As EventArgs)
			TryCast(sender, Control).BeginInvoke(New MethodInvoker(Function() AnonymousMethod1(sender)))
		End Sub
		
		Private Function AnonymousMethod1(ByVal sender As Object) As Boolean
			Dim editor As PopupBaseEdit = TryCast(sender, PopupBaseEdit)
			If editor.IsPopupOpen Then
				editor.ClosePopup()
				editor.ShowPopup()
			End If
			Return True
		End Function



		Protected Overrides Sub Finalize()
			If scrControl IsNot Nothing AndAlso handleGotFocus IsNot Nothing Then
				Try
					UnsetEvents(scrControl)
				Catch
				End Try
			End If
		End Sub
	End Class
End Namespace
