﻿Public Class FormCertificadoRetencion
    Private Sub FormCertificadoRetencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.habilitarControles(Me)
        Generales.asignarPermiso(Me)
    End Sub
End Class