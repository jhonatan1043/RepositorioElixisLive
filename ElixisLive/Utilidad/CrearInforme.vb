Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports System.IO
Public Class CrearInforme
    Dim Convertir As New ConvertirNumeros
    Public Sub reportePDF(ruta As String,
                          codigo As String,
                          formula As String,
                          nombreArchivo As String,
                          reporte As ReportClass,
                          Optional ByVal texto As String = "",
                          Optional params As List(Of String) = Nothing)
        Try
            Dim tblas As Tables = reporte.Database.Tables
            Generales.getConnReporte(tblas)
            reporte.Refresh()
            enviarParametros(nombreArchivo, reporte, params)
            If ruta.Contains("\/") Then
                ruta = ruta.Replace("\/", "\")
            End If
            reporte.RecordSelectionFormula = formula
            reporte.ExportToDisk(ExportFormatType.PortableDocFormat, ruta)
            reporte.Close()
            reporte.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Shared Sub enviarParametros(area As String,
                                        ByRef reporte As Object,
                                        ByRef params As List(Of String))
        Select Case area
            Case "Factura"
                reporte.SetParameterValue("TotalProducto", params(0))
                reporte.SetParameterValue("TotalServicio", params(1))
                reporte.SetParameterValue("TotalVenta", params(2))
        End Select
    End Sub
    Public Sub crearReportePDF(reporte As Object,
                               codigo As String,
                               formula As String,
                               nombreArchivo As String,
                               ruta As String,
                               Optional ByVal texto As String = "",
                               Optional ByVal noAbrirArchivo As Boolean = False,
                               Optional params As List(Of String) = Nothing,
                               Optional rutaDiferente As String = "")
        Dim cnd As String
        reporte.Close()
        If String.IsNullOrWhiteSpace(rutaDiferente) Then
            cnd = nombreArchivo & Constantes.NOMBRE_PDF_SEPARADOR & codigo & Now.Hour & Now.Minute & Now.Second & Now.Millisecond & Constantes.EXTENSION_ARCHIVO_PDF
            ruta = ruta & cnd
        Else
            ruta = rutaDiferente
        End If

        reportePDF(ruta, codigo, formula, nombreArchivo, reporte, texto, params)

        If noAbrirArchivo Then Exit Sub
        abrirReporte(ruta)
    End Sub
    Private Sub abrirReporte(rutaPDF As String)
        Process.Start(rutaPDF)
    End Sub
End Class
