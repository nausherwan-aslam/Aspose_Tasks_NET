'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports System

Namespace VisualBasic.Projects
	Public Class ReadCurrencyProperties
		Public Shared Sub Run()
			' The path to the documents directory.
			Dim dataDir As String = RunExamples.GetDataDir_Projects()
			Dim project As New Project(dataDir & "ReadCurrencyProperties.mpp")

			'Display currency properties
			Console.WriteLine("Currency Code : " & project.Get(Prj.CurrencyCode).ToString())
			Console.WriteLine("<br>Currency Digits : " & project.Get(Prj.CurrencyDigits).ToString())
			Console.WriteLine("<br>Currency Symbol : " & project.Get(Prj.CurrencySymbol).ToString())
			Console.WriteLine("Currency Symbol Position" & project.Get(Prj.CurrencySymbolPosition).ToString())
		End Sub
	End Class
End Namespace