Public Class Constantes
    Public Const SI = "Si"
    Public Const NO = "No"
    Public Const SERVIDOR_FTP = "ftp://192.168.2.89//CarpetaFTP/"
    Public Const USUARIO_FTP = "AdminSoftQuality"
    Public Const CONTRASENA_FTP = "AdminSoft"
    Public Const SIGNO_PESO = "$"
    Public Const ID_PRODUCTO = "P"
    Public Const ID_SERVICIO = "S"
    Public Const CODIGO_EMPRESA = 0
    Public Const EDITABLE = 1
    Public Const NO_EDITABLE = 0
    Public Const CSERVICIO = 2
    Public Const CPRODUCTO = 1

    Public Const SOLO_LECTURA = 1
    Public Const SOLO_ESCRITURA = 2
    Public Const LECTURA_ESCRITURA = 3


    Public Enum TIPO_CONTROL
        COMBO = 0
        SELECTOR = 1
        TIEMPO = 2
    End Enum
    Public Const SIN_VALOR_NUMERICO = 0

    Public Const NOMBRE_COMBO = "combo"
    Public Const NOMBRE_SELECTOR = "Selector"
    Public Const NOMBRE_TIEMPO = "Tiempo"

    Public Const FORMATO_FECHA_LARGA = "MMMM \ dddd ,dd \ yyyy"
    Public Const FORMATO_FECHA_CORTA = "MMMM, MM \ yyyy"
    Public Const FORMATO_FECHA = "yyyy-MM-dd"
    Public Const FORMATO_FECHA2 = "dd-MM-yyyy"
    Public Const FORMATO_FECHA_HORA = "dd-MM-yyyy HH:mm"

    Public Const FORMATO_MONEDA = "c2"

    Public Const CADENA_VACIA = ""

    Public Const DIA_SEMANA = 7
    Public Const TIPO_LETRA_ELEMENTO = "[FontFamily: Name=Microsoft Sans Serif]"
    Public Const PENDIENTE = 0

    Public Const ALTO_BARRA = 50
    'Citas
    Public Const ALTURA_HORA_DISPONIBLE = 30
    Public Const ANCHURA_HORA_DISPONIBLE = 100
    '----
    Public Const ALTURA_HORA_TOMADA = 66
    Public Const ANCHURA_HORA_TOMADA = 100
    '----
    Public Const ALTURA_CITA_DISPONIBLE = 30
    Public Const ANCHURA_CITA_DISPONIBLE = 720
    '----
    Public Const ALTURA_CITA_TOMADA = 66
    Public Const ANCHURA_CITA_TOMADA = 140
    '----- 
    Public Const CITA_DISPONIBLE = "Nueva Cita"
    '----
    Public Const HORA_POCISION_PANEL_X = 5
    Public Const HORA_POCISION_LABEL_X = 32
    '--------
    Public Const VALOR_INICIAL = 10
    Public Const VALOR_INCREMENTO = 32

    Public Const PANEL_POCISION_X = 110
    Public Const CITA_CANCELADA = "C"
    Public Const CITA_PENDIENTE = "P"
    Public Const CITA_REALIZADA = "R"

    Public Const NOMBRE_PDF_SEPARADOR = "-"

    Public Const EXTENSION_ARCHIVO_PDF = ".pdf"
    '----------------------------------------------
    Public Const INVENTARIO = "I"
    Public Const FACTURA = "F"
End Class
