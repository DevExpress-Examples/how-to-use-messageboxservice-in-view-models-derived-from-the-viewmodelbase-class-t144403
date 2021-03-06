﻿Imports DevExpress.Mvvm
Imports System.Windows.Input

Namespace Example.ViewModel
    Public Class ChildViewModel
        Inherits ViewModelBase

        Private privateShowMessageCommand As ICommand
        Public Property ShowMessageCommand() As ICommand
            Get
                Return privateShowMessageCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateShowMessageCommand = value
            End Set
        End Property
        Public Sub New()
            ShowMessageCommand = New DelegateCommand(AddressOf ShowMessage)
        End Sub

        Private ReadOnly Property MessageBoxService() As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)(ServiceSearchMode.PreferParents)
            End Get
        End Property
        Private Sub ShowMessage()
            MessageBoxService.Show("This is ChildView")
        End Sub
    End Class
End Namespace
