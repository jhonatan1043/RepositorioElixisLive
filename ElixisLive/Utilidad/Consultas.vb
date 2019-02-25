﻿Public Class Consultas
    Public Const SUMA_RETENCION = "SP_SUMA_RETENCION"
    Public Const CONSULTAR_EXISTENCIA_RECAUDO = "[SP_CONSULTAR_RECAUDO]"
    Public Const BUSQUEDA_CLIENTES = "EXEC [SP_CLIENTE_BUSCAR]"
    Public Const TIPO_CUENTA_CARGAR = "SP_TIPO_CUENTA_CARGAR"
    Public Const TIPO_CUENTA_BUSCAR = "SP_TIPO_CUENTA_BUSCAR"
    Public Const CIERRE_DOCUMENTOS_DETALLE_CIERRE_CARGAR = "SP_CIERRE_DOCUMENTOS_DETALLE_CIERRE_CARGAR"
    Public Const CIERRE_DOCUMENTOS_DETALLE_TRASLADO_CARGAR = "SP_CIERRE_DOCUMENTOS_DETALLE_TRASLADO_CARGAR"
    Public Const CIERRE_DOCUMENTOS_CARGAR = "SP_CIERRE_DOCUMENTOS_DATOS_CARGAR"
    Public Const CIERRE_DOCUMENTOS_LLENAR = "SP_CIERRE_DOCUMENTOS_LLENAR"
    Public Const CIERRE_DOCUMENTOS_CUENTAS_CRUZAR = "SP_CIERRE_DOCUMENTOS_CUENTAS_CRUZAR"
    Public Const CIERRE_DOCUMENTOS_CUENTAS_CERRAR = "SP_CIERRE_DOCUMENTOS_CUENTAS_CERRAR"
    Public Const CIERRE_DOCUMENTOS_BUSCAR = "SP_CIERRE_DOCUMENTOS_BUSCAR '',"
    Public Const RETENCION_IVA_LLENAR = "SP_RETENCION_IVA_LLENAR"
    Public Const CIERRE_MES_CARGAR = "SP_CIERRE_MES_CARGAR"
    Public Const CIERRE_MES_ABRIR = "SP_CIERRE_MES_ABRIR "
    Public Const CIERRE_AÑO_ABRIR = "SP_CIERRE_ANUAL_ABRIR "
    Public Const CIERRE_AÑO_CARGAR = "SP_CIERRE_ANUAL_CARGAR"
    Public Const CIERRE_DIA = "SP_CIERRE_DIA_ABRIR"
    Public Const TERCERO_CONTABILIDAD_CARGAR = "SP_CONTABILIDAD_TERCERO_CARGAR"
    Public Const CONSULTAR_FECHA_SERVIDOR = "[SP_FECHA_SERVIDOR]"
    Public Const CARTERA_CXP_BUSCAR = "SP_CARTERA_CXP_BUSCAR '', "
    Public Const CUENTAS_CXP_PROVEEDOR_CARGAR = "SP_CUENTAS_POR_PAGAR_CARGAR"
    Public Const CUENTAS_CXP_PROVEEDOR_DETALLE_CARGAR = "SP_CUENTAS_POR_PAGAR_DETALLE_CARGAR"
    Public Const CUENTAS_CXC_CLIENTE_CARGAR = "SP_CUENTAS_POR_COBRAR_CARGAR"
    Public Const CUENTAS_CXC_CLIENTE_DETALLE_CARGAR = "SP_FACTURA_VENTA_ASISTENCIAL_CARGAR"
    Public Const ESTADO_DE_CARTERA = "SP_ESTADO_DE_CARTERA"
    Public Const NOTAS_PROVEEDOR_DETALLE_CARGAR = "SP_NOTAS_PROVEEDOR_DETALLE_CARGAR"
    Public Const NOTA_PROVEEDOR_CARGAR = "SP_NOTA_PROVEEDOR_CARGAR"
    Public Const NOTA_INTERNA_CARGAR = "SP_NOTA_INTERNA_CARGAR"
    Public Const NOTA_PROVEEDOR_BUSCAR = "SP_NOTA_PROVEEDOR_BUSCAR '', "
    Public Const NOTA_INTERNA_BUSCAR = "SP_NOTA_INTERNA_BUSCAR '', "
    Public Const NOTAS_CLIENTE_DETALLE_CARGAR = "SP_NOTAS_CLIENTE_DETALLE_CARGAR"
    Public Const NOTA_CLIENTE_CARGAR = "SP_NOTA_CLIENTE_CARGAR"
    Public Const NOTA_CLIENTE_BUSCAR = "SP_NOTA_CLIENTE_BUSCAR '', "
    Public Const FACTURAS_NOTA_CLIENTE_BUSCAR = "SP_FACTURAS_NOTA_CLIENTE_BUSCAR '', "
    Public Const CUENTAS_POR_PAGAR_CARGAR = "SP_COMPROBANTES_CUENTA_POR_PAGAR_CARGAR"
    Public Const CUENTAS_CXP_PROVEEDOR_BUSCAR = "SP_CUENTAS_POR_PAGAR_BUSCAR '', "
    Public Const CUENTAS_POR_COBRAR_CARGAR = "SP_CUENTAS_POR_COBRAR_CARGAR"
    Public Const CUENTAS_POR_COBRAR_DETALLE_CARGAR = "SP_CUENTAS_POR_COBRAR_DETALLE_CARGAR"
    Public Const CUENTAS_CXC_CLIENTE_BUSCAR = "SP_CUENTAS_POR_COBRAR_BUSCAR '', "
    Public Const CARTERA_CXP_CARGAR = "SP_CARTERA_CXP_CARGAR "
    Public Const CARTERA_CXP_CUENTAS_CARGAR = "SP_CARTERA_CXP_CUENTAS_CARGAR"
    Public Const CARTERA_CXC_BUSCAR = "SP_CARTERA_CXC_BUSCAR '', "
    Public Const CARTERA_CXC_CARGAR = "SP_CARTERA_CXC_CARGAR "
    Public Const CARTERA_CXC_CUENTAS_CARGAR = "SP_CARTERA_CXC_CUENTAS_CARGAR"
    Public Const FACTURAS_PROVEEDOR_BUSCAR = "SP_FACTURAS_PROVEEDOR_BUSCAR '',"
    Public Const FACTURA_PROVEEDOR_GUARDADA = "SP_FACTURA_PROVEEDOR_EXISTENTE "
    Public Const FACTURA_PROVEEDOR_CARGAR = "SP_FACTURAS_PROVEEDOR_CARGAR "
    Public Const FACTURA_VENTA_CONSULTAR = "SP_FACTURA_VENTA_CONSULTAR"
    Public Const COMPROBANTE_CAUSACION_CONSULTAR = "SP_COMPROBANTE_CAUSACION_CONSULTAR"
    Public Const SALDO_PENDIENTE_CLIENTE_BUSCAR = "[SP_RECAUDO_SALDO_PENDIENTE_BUSCAR]"
    Public Const SALDO_PENDIENTE_CLIENTE_CARGAR = " [SP_RECAUDO_SALDO_PENDIENTE_CARGAR]"
    Public Const SALDO_PENDIENTE_CLIENTE_DIGITAR = "[SP_RECAUDO_SALDO_PENDIENTE_DETALLE]"
    Public Const RECAUDO_GUARDAR = "[SP_RECAUDO_CREAR]"
    Public Const RECAUDO_BUSCAR = "[SP_RECAUDO_BUSCAR] ''"
    Public Const RECAUDO_CARGAR = "[SP_RECAUDO_CARGAR]"
    Public Const RECAUDO_CARGAR_D = "[SP_RECAUDO_D_CARGAR]"
    Public Const COMPROBANTE_EGRESO_CUENTA_PUC_VERIFICAR = "EXEC [SP_COMPROBANTE_EGRESO_CUENTAS_PUC_VERIFICAR] "
    Public Const NOTA_PROVEEDOR_DETALLE_CARGAR = "SP_NOTA_PROVEEDOR_DETALLE_CARGAR"
    Public Const NOTA_INTERNA_DETALLE_CARGAR = "SP_NOTA_INTERNA_DETALLE_CARGAR"
    Public Const FACTURAS_CLIETE_BUSCAR = "SP_FACTURAS_CLIENTE_BUSCAR '',"
    Public Const FACTURA_CLIENTE_GUARDADA = "SP_FACTURA_CLIENTE_EXISTENTE "
    Public Const FACTURA_CLIENTE_CARGAR = "SP_FACTURAS_CLIENTE_CARGAR "
    Public Const CUENTAS_CONTA_GENERAL = "SP_CUENTAS_CONTA_GENERAL ''"
    Public Const DOCUMENTOS_CONTABLES_BUSCAR = "SP_E_DOCUMENTO_BUSCAR"
    Public Const CUENTAS_CAJA_BUSCAR = "EXEC SP_CUENTAS_CAJA_BUSCAR ''"
    Public Const CUENTAS_BANCO_BUSCAR = "EXEC SP_CUENTAS_BANCO_BUSCAR ''"
    Public Const AUTOCOM_CUENTAS_CAJA = "EXEC SP_AUTOCOM_CUENTAS_CAJA "
    Public Const AUTOCOM_CUENTAS_BANCO = "EXEC SP_AUTOCOM_CUENTAS_BANCO "
    Public Const DOCUMENTOS_CONTABLES_LISTAR = "EXEC SP_DOCUMENTOS_CONTABLES_LISTAR '' "
    Public Const TCUENTA_LISTAR = "EXEC SP_TCUENTA_BUSCAR ''"
    Public Const RETEFUENTE_LISTAR = "EXEC SP_RETEFUENTE_BUSCAR "
    Public Const PUC_ACTIVO = "EXEC SP_PUC_ACTIVO "
    Public Const VALIDAR_CUENTA_PUC = "SELECT dbo.FN_VALIDAR_CUENTA_PUC"
    Public Const CAJA_BANCO_CARGAR = " SP_CAJA_BANCO_CARGAR "
    Public Const CAJA_BANCO_CARGAR_CUENTAS = "EXEC SP_CAJA_BANCO_CUENTAS_CARGAR "
    Public Const CONTA_GENERAL_CARGAR_CUENTAS = " SP_CONTABILIDAD_GENERAL_CUENTAS_CARGAR "
    Public Const CONTA_PROGRAMACION_PROVEEDOR_BUSCAR = "SP_PROGRAMACION_PROVEEDOR_BUSCAR"
    Public Const AUTOCOMPLETAR_CUENTAS_CONTA_GENERAL = "SP_AUTOCOMPLETAR_CUENTAS_CONTA_GENERAL "
    Public Const ESTADO_CUENTAS_DIAS = "EXEC SP_ESTADO_CUENTAS_DIAS "
    Public Const ESTADO_CUENTAS_DIAS_CXP = "EXEC SP_ESTADO_CUENTAS_CXP_DIAS "
    Public Const ESTADO_CUENTAS_POR_COBRAR = "EXEC SP_ESTADO_CUENTAS_POR_COBRAR "
    Public Const ESTADO_CUENTAS_POR_PAGAR = "EXEC SP_ESTADO_CUENTAS_POR_PAGAR "
    Public Const CAJA_BANCO_BUSCAR = "SP_CAJA_BANCO_BUSCAR '', "
    Public Const FACTURAS_CXP_BUSCAR = "SP_FACTURAS_CXP_BUSCAR '',"
    Public Const PROVEEDOR_CXP_BUSCAR = "SP_TERCERO_CXP_BUSCAR ''"
    Public Const FACTURAS_CXC_BUSCAR = "SP_FACTURAS_CXC_BUSCAR '',"
    Public Const FACTURAS_CLIENTE_BUSCAR = "SP_FACTURAS_CLIENTE_BUSCAR '',"
    Public Const TERCERO_CXC_BUSCAR = "SP_TERCERO_CXC_BUSCAR ''"
    Public Const CONTA_GENERAL_BUSCAR = "SP_CONTA_GENERAL_BUSCAR '', "
    Public Const FECHA_CERRADA = "SP_VALIDAR_FECHA_CERRADA "
    Public Const CONTA_TERCERO_BUSCAR = "SP_CONTA_TERCERO_BUSCAR "
    Public Const CONTA_CLIENTE_BUSCAR = "SP_CONTA_EPS_BUSCAR ''"
    Public Const CONTA_PROVEEDOR_CARGAR = "SP_CONTA_PROVEEDOR_CARGAR"
    Public Const CONTA_TERCERO_CARGAR = "SP_CONTA_TERCERO_CARGAR"
    Public Const CONTA_CLIENTE_CARGAR = "SP_CONTA_CLIENTE_CARGAR"
    Public Const CUENTA_POR_PAGAR_CREAR = "SP_CUENTA_PROVEEDOR_CONSULTAR "
    Public Const CUENTA_POR_COBRAR_CREAR = "SP_CUENTA_CLIENTE_CONSULTAR "
    Public Const DOCUMENTOS_SIGLA_BUSCAR = "EXEC SP_DOCUMENTO_CONTABLE_BUSCAR '' "
    Public Const TIPO_DOCUMENTO_CONTABLE_ANULAR = "SP_DOCUMENTO_CONTABLE_ANULAR"
    Public Const CUENTAS_LISTAR = "SP_CUENTAS_LISTAR"
    Public Const CUENTAS_PUC_LISTAR = "SP_CUENTAS_PUC_LISTAR"
    Public Const PUC_CARGAR = "SP_PUC_CARGAR "
    Public Const CUENTAS_PUC_CARGAR = "SP_PUC_DETALLE_CARGAR "
    Public Const CUENTAS_UCI_CARGAR = "SP_CUENTAS_UCI_CARGAR "
    Public Const RETENCION_IVA_CARGAR = "SP_RETENCION_IVA_CARGAR"
    Public Const DOCUMENTO_CONTABLE_CARGAR = "SP_E_DOCUMENTO_CARGAR"
    Public Const CUENTAS_DETALLE_CARGAR = "SP_CUENTAS_DETALLE_CARGAR"
    Public Const SIGLA_CONTABLE_CARGAR = "SP_DOCUMENTO_CONTABLE_CARGAR"
    Public Const ANULAR_PUC = "SP_PUC_ANULAR"
    Public Const ANULAR_CUENTA_PUC = "SP_PUC_DETALLE_ANULAR"
    Public Const ANULAR_RETENCION_IVA = "SP_RETENCION_IVA_ANULAR"
    Public Const BUSQUEDA_PUC = "SP_PUC_BUSCAR ''"
    Public Const BUSQUEDA_RETENCION_IVA = "SP_RETENCION_IVA_BUSCAR"
    Public Const BUSQUEDA_CUENTAS_UCI = "SP_CUENTAS_UCI_BUSCAR "
    Public Const BUSQUEDA_CUENTAS_PUC = "SP_PUC_DETALLE_BUSCAR"
    Public Const BUSQUEDA_CUENTAS_DETALLE_PUC = "SP_PUC_CUENTAS_DETALLE_LISTAR"
    Public Const BUSQUEDA_CUENTAS_RECAUDO_PUC = "[SP_PUC_DETALLE_RECAUDO_BUSCAR] '',"
    Public Const BUSQUEDA_CUENTAS_PUC_RETENCION = "SP_PUC_DETALLE_RETENCION_BUSCAR"
    Public Const CONSECUTIVO_CONTABLE = "Select dbo.FN_CONSECUTIVO_CONTABLE"
    Public Const AUMENTAR_CONSECUTIVO = "SP_CONSECUTIVO_CONTABLE_AUMENTAR"
    Public Const BALANCE_COMPROBACION_CARGAR_PREV = "SP_E_BALANCE_COMPROBACION_CARGAR_PREV"
    Public Const BALANCE_COMPROBACION_CARGAR_XLS = "SP_E_BALANCE_COMPROBACION_CARGAR_XLS"
    Public Const RETIRO_DOCUMENTO = "EXEC SP_RETIRO_DOCUMENTO_CARGAR "
    Public Const RETIRO_DOCUMENTO_HABILITAR = "EXEC SP_RETIRO_DOCUMENTO_HABILITAR "
    Public Const RETENCION_CUENTAS_RETENCION = "EXEC [SP_RETENCION_IVA_LLENAR] "
    Public Const CERTIFICADO_RETENCION_CARGAR_XLS = "SP_E_CERTIFICADO_RETENCION_CARGAR_XLS"
    Public Const COMPROBANTE_ANULADO_VERIFICAR = "EXEC SP_COMPROBANTE_ANULADO_VERIFICAR "
    Public Const COMPROBANTE_FECHA_VERIFICAR = "EXEC SP_COMPROBANTE_FECHA_VERIFICAR "
    Public Const COMPROBANTE_EGRESO_BUSCAR = "EXEC SP_COMPROBANTE_EGRESO_BUSCAR "
    Public Const COMPROBANTE_EGRESO_CARGAR = "EXEC SP_COMPROBANTE_EGRESO_CARGAR "
    Public Const COMPROBANTE_EGRESO_DETALLE_CARGAR = "EXEC SP_COMPROBANTE_EGRESO_DETALLE_CARGAR "
End Class

