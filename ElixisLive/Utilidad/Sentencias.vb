﻿Public Class Sentencias
    '----Cliente------
    Public Const CLIENTES_BUSCAR = "SP_INVEN_CLIENTE_CONSULTAR"
    Public Const CLIENTES_CARGAR = "SP_INVEN_CLIENTE_CARGAR"
    Public Const CLIENTE_FACTURA_CARGAR = "SP_CLIENTE_FACTURA_CARGAR"
    '----Productos------
    Public Const PRODUCTO_SERVICIO_FACTURA_BUSCAR = "SP_PRODUCTOS_SERVICIO_FACTURA_BUSCAR"
    Public Const PRODUCTO_SERVICIO_FACTURA_CARGAR = "SP_PRODUCTOS_SERVICIO_FACTURA_CARGAR"
    Public Const PRODUCTO_CONSULTAR = "[SP_PRODUCTOS_COMPRA_CONSULTAR]"
    '----Compra------
    Public Const COMPRA_CONSULTAR = "[SP_INVEN_COMPRA_CONSULTAR]"
    Public Const COMPRA_CARGAR_DETALLE = "[SP_INVEN_COMPRA_DETALLE]"
    Public Const COMPRA_CARGAR = "[SP_INVEN_COMPRA_CARGAR]"
    '----Sucursal------
    Public Const SUCURSALES_CONSULTAR = "[SP_ADMIN_CONSULTAR_SUCURSALES]"
    Public Const SUCURSAL_EMPLEADO_CONSULTAR = "[SP_ADMIN_EMPLEADO_SUCURSALES]"
    Public Const SUCURSAL_EMPLEADO_CARGAR = "[SP_EMPLEADO_SUCURSALES_CARGAR]"
    Public Const SUCURSAL_LISTA = "[SP_CONFI_SUCURSAL_LISTAR] ''"
    Public Const SUCURSAL_BODEGA_ASIGNADO = "[SP_SUCURSAL_BODEGA_ASIGNADO]"
    Public Const SUCURSAL_BODEGA_SIN_ASIGNAR = "[SP_SUCURSAL_BODEGA_SIN_ASIGNAR]"
    '----Proveedor------
    Public Const PROVEEDOR_ADMIN_CONSULTAR = "[SP_ADMIN_PROVEEDOR_CONSULTAR]"
    Public Const PROVEEDOR_ADMIN_CARGAR = "[SP_ADMIN_PROVEEDOR_CARGAR]"
    '----Cita------
    Public Const CITA_CANCELAR = "[SP_ADMIN_CANCELAR_CITA] "
    Public Const CITA_CAMBIO_ESTADO = "[SP_ADMIN_CAMBIO_ESTADO_CITA] "
    '----Empresa------
    Public Const EMPRESA_CARGAR = ""
    Public Const EMPRESA_CONSULTAR = "SP_ADMIN_EMPRESA_CONSULTAR"
    '----Persona------
    Public Const PERSONA_EMPLEADO_CONSULTAR = "[SP_PERSONA_EMPLEADO_CONSULTAR]"
    Public Const PERSONA_CARGAR = "SP_PERSONA_CARGAR"
    Public Const PERSONA_EMPLEADO_CARGAR = "[SP_PERSONA_EMPLEADO_CARGAR]"
    Public Const PERSONA_POR_IDENTIFICACION_CARGAR = "[SP_PERSONA_IDENTIFICACION_CARGAR]"
    Public Const PERSONA_PROVEEDOR_CONSULTAR = "[SP_PERSONA_PROVEEDOR_CONSULTAR]"
    Public Const PERSONA_CONSULTAR = "[SP_ADMIN_PERSONA_CONSULTAR]"
    Public Const PERSONA_VERIFICAR_USUARIO = "[SP_VERIFICAR_USUARIO]"
    Public Const PERSONA_SUCURSALES_ASIGNADO = "[SP_PERSONA_SUCURSALES_ASIGNADO]"
    Public Const PERSONA_SUCURSALES_SIN_ASIGNAR = "[SP_PERSONA_SUCURSALES_SIN_ASIGNAR]"
    '------Perfil-------
    Public Const PERFIL_LISTA = "SP_ADMIN_PERFIL_LISTA"
    Public Const PERFIL_CONSULTAR = "[SP_CONSULTAR_PERFIL]"
    Public Const ADMIN_PERFIL_DETALLE = "SP_ADMIN_PERFIL_DETALLE "
    ' ------------------------------------------------
    Public Const INFORME_CONSULTAR = "[SP_INFOR_CONSULTAR_INFORME]"
    '-----------------
    Public Const ADMIN_INICIO_SESION = "[SP_ADMIN_INICIO_SESION]"
    Public Const LOTE_CONSULTAR = "[SP_CONSULTAR_LOTE]"
    Public Const PARAMETROS_CONSULTAR = "SP_CONSULTAR_PARAMETROS"
    Public Const MARCA_CONSULTAR = "[SP_CONSULTAR_MARCA]"
    Public Const DEPARTAMENTO_CONSULTAR = "[SP_CONSULTAR_DEPARTAMENTO]"
    Public Const CIUDAD_CONSULTAR = "[SP_CONSULTAR_CIUDAD]"
    Public Const CARGO_CONSULTAR = "[SP_CONSULTAR_CARGO]"
    Public Const BANCO_CONSULTAR = "[SP_CONSULTAR_BANCO]"
    Public Const DEPARTAMENTO_TRABAJO_CONSULTAR = "[SP_CONSULTAR_DEPARTAMENTO_TRABAJO]"
    Public Const VENTA_BUSCAR = "[SP_INVEN_VENTA_BUSCAR]"
    Public Const BODEGA_CONSULTAR = "[SP_CONFI_BODEGA_CONSULTAR] ''"
    Public Const REGIMEN_CONSULTAR = "[SP_CONSULTAR_TIPO_REGIMEN]"
    Public Const SERVICIO_CONSULTAR = "[SP_SERVICIO_CONSULTAR]"
    Public Const TIPO_IDENTENTIFICACION_LISTA = "SP_TIPO_IDENTIFICACION_LISTA"
    Public Const MOVIMIENTO_CONSULTAR = "[SP_CONSULTAR_MOVIMIENTO]"
    '-------Costo de servicios-------
    Public Const CONFIGURACION_COSTO_SERVICIO_LISTAR = "[SP_CONFIGURACION_COSTO_SERVICIO_LISTAR]"
    Public Const COSTO_SERVICIO_CARGAR = "[SP_COSTO_SERVICIO_CARGAR]"
    '-------Ventas-------
    Public Const VENTA_CARGAR_PRODUCTO = "[SP_VENTA_CARGAR_PRODUCTO]"
    Public Const VENTA_CARGAR_SERVICIO = "[SP_VENTA_CARGAR_SERVICIO]"
    '------Inventario------
    Public Const INVEN_VENTA_CARGAR = "[SP_INVEN_VENTA_CARGAR]"
    '-------Factura---------
    Public Const SERVICIO_FACTURA_CONSULTAR = "[SP_SERVICIO_FACTURA_CONSULTAR]"
    Public Const PRODUCTOS_FACTURA_CARGAR = "[SP_PRODUCTOS_FACTURA_CARGAR]"
    Public Const PRODUCTOS_FACTURA_CONSULTAR = "[SP_PRODUCTOS_FACTURA_CONSULTAR]"
    Public Const PRODUCTOS_FACTURA_PENDIENTE_CARGAR = "[SP_PRODUCTOS_FACTURA_PENDIENTE_CARGAR]"
    Public Const PRODUCTO_CODIGO_BARRA_CARGAR = "[SP_PRODUCTOS_CODIGO_BARRA_CARGAR]"
    '----------------
    Public Const VERIFICAR_CAMBIAR_CLAVE = "EXEC [SP_VERIFICAR_CLAVE_USUARIO] "
    '--------Nomina------------
    Public Const NOMINA_EMPLEADO_LISTAR = "SP_NOMINA_EMPLEADO_LISTAR"
    Public Const NOMINA_BUSCAR = "SP_NOMINA_BUSCAR"
    Public Const NOMINA_CARGAR = "SP_NOMINA_CARGAR"
    Public Const NOMINA_EMPLEADOS_CARGAR = "SP_NOMINA_EMPLEADOS_CARGAR"
    Public Const NOMINA_ANULAR = "SP_NOMINA_ANULAR"
    Public Const NOMINA_REPORTE_TRANSACCIONES = "SP_NOMINA_REPORTE_TRANSACCIONES"
End Class
