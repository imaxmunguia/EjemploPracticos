ALTER PROCEDURE [dbo].[usp_crdTransaccionVenta_Aplicar]
    (
      @Usuario VARCHAR(50) ,
      @NumTransaccion VARCHAR(50) ,
      @NumRefFactura VARCHAR(50) ,
      @NumeroDocumento VARCHAR(50) = '' ,
      @MontoVenta DECIMAL(18, 2) ,
      @Sucursal INT ,
      @Terminal INT ,
      @TipoOperacion INT ,--1= Disposición 2= Verificación                  
      @NumResultado INT = 0 OUTPUT ,
      @MsgResultado VARCHAR(MAX) = '' OUTPUT                    
    )
AS
    BEGIN                  
/*                   
-------------------------------------------------------------------------                  
COMENTARIOS:                  
-------------------------------------------------------------------------                  
-->>>CREACION:                  
-------------------------------------------------------------------------                  
Objeto:   usp_crdTransaccionVenta_Procesar                  
Descripcion: Realiza el procesamiento de la transaccion.                  
                  
Creado por:  Randall Rodriguez                  
Version:     1.0.1                  
Fecha:    02/01/2012                  
Observaciones:                  
                  
Ejm.Ejecucion:                     
       
-------------------------------------------------------------------------    
-->>>Modificacion #1:  
-------------------------------------------------------------------------  
Objeto:			usp_crdTransaccionVenta_Procesar  
Descripcion:	Se carga el campo convenio en la tabla t_crdmAutorizacion con la consulta por t_crddPlanPromoArticulo
Creado por:		Randall Sanabria
Version:		1.0.0  
Fecha	:		2017-02-02  
Observaciones:  
-------------------------------------------------------------------------    
-------------------------------------------------------------------------
Requerimiento: 			Migración SQL Server 2016
Descripcion: 			RAISERROR
Uso: 					
Modificado por: 		Jessica Sanchez
Version: 			    2.1
Ejemplo de uso: 		
Fecha: 					13/03/2017
--------------------------------------------------------------------------
--------------------------------------------------------------------------
Requerimiento: 			Convenios (Estimacion - RQ No Funcional 02 - Facturación)
Descripcion: 			Se modifica respuesta para agregar el nombre del convenio y la entidad a la que el cliente
Uso: 					
Modificado por: 		José Ramírez
Version: 			    2.2
Ejemplo de uso: 		
Fecha: 					10/04/2018
--------------------------------------------------------------------------
--------------------------------------------------------------------------
Número de ticket:       01764782
Historia de Usuario:	01764782-26
Descripcion: 			Crear una columna para permitir o no la separación.
Uso: 					
Modificado por: 		Isack Munguia
Version: 			    
Ejemplo de uso: 		
Fecha: 					12/07/2018
--------------------------------------------------------------------------                           
*/                  
                  
        SET NOCOUNT ON; --added to prevent extra result sets from interfering with SELECT statements.                  
                  
 --+++++++++++++++++++++++++++                  
 -----------------------------                  
 --DECLARACION                   
 -----------------------------                  
                  
 --VARIABLES                  
 --Administracion errores                  
        DECLARE @Priority INT                       
        DECLARE @Severity VARCHAR(20)                   
        DECLARE @ProcessID VARCHAR(10)                   
        DECLARE @ProcessName VARCHAR(MAX)                  
        DECLARE @MessageUser VARCHAR(MAX)                  
        DECLARE @MessageSystem VARCHAR(MAX)                  
        DECLARE @FormattedMessage VARCHAR(MAX)                   
        DECLARE @Observation VARCHAR(MAX)                  
        DECLARE @UserNumber INT                       
        DECLARE @SystemNumber INT                       
        DECLARE @Severidad INT                   
        DECLARE @Parameter VARCHAR(MAX)            
		
            
                   
        DECLARE @IdRespuestaAutorizacion BIGINT ,
            @IdT_crdcTransaccion BIGINT ,
            @CountMax INT ,
            @CountMin INT ,
            @Plazo INT ,
            @TasaInteresNormal DECIMAL(18, 4) ,
            @TasaInteresNormalVenta DECIMAL(18, 4) ,
            @TasaInteresNormalExt DECIMAL(18, 4) ,
            @MontoFinanciar DECIMAL(18, 2) ,
            @Monto DECIMAL(18, 2) ,
            @Prima DECIMAL(18, 2) ,
            @MontoFomento DECIMAL(18, 2) ,
            @Concepto INT ,
            @FechaTransaccion DATETIME ,
            @IdF_crdcSubCuenta BIGINT ,
            @IdF_crdcOrigen BIGINT ,
            @IdT_crdpSegmentoExtGarantia BIGINT ,
            @IdPlanFianciero BIGINT ,
            @IdPlanPromoArticulo BIGINT ,
            @MesesGracia INT ,
            @FechaProceso DATETIME ,
            @AplicacionExtGarantia INT ,
            @IdT_crddSaldoSegmento BIGINT ,
            @IdT_crddSaldoDetallado BIGINT ,
            @IdSecuencia INT ,
            @CodigoOrganizacion BIGINT ,
            @CodEntidadAut BIGINT ,
            @CodEntidadAutDet BIGINT ,
            @ComboPadre VARCHAR(80) ,
            @ComboIdCreacion VARCHAR(80) ,
            @CodigoArticulo VARCHAR(50) ,
            @FactorOperacion INT ,
            @Descripcion VARCHAR(50) ,
            @IdNivelVisibilidad BIGINT ,
            @IdAutorizacionAux BIGINT ,
            @IdAutorizacion BIGINT ,
            @MontoFomentoDet DECIMAL(18, 2) ,
            @MontoFactura DECIMAL(18, 2) ,
            @MontoPrima DECIMAL(18, 2) ,
            @MontoTotalFinanciar DECIMAL(18, 2) ,
            @UltimoCorrelativo INT ,
            @IdPlanFinancieroBase BIGINT ,
            @IdF_crdmCiclo BIGINT ,
            @IdF_crdcCartera BIGINT ,
            @FechaCreacionCuenta DATETIME ,
            @Cuenta VARCHAR(50) ,
            @CodEntidadMonv BIGINT ,
            @CodEntidadMonvDia BIGINT ,
            @IdT_crdpSegmentoOrinal BIGINT ,
            @CuotaEnProxCiclo BIT ,
            @DescripcionArt VARCHAR(MAX) ,
            @VigenciaProveedor INT ,
            @VigenciaExtraGarantia INT ,
            @CodRespuesta VARCHAR(10) ,
            @Repuesta VARCHAR(50) ,
            @GeneraInfoDetallada BIT ,
            @IdPKDetailRef BIGINT ,
            @IdPFDetailRef BIGINT ,
            @IdT_crdmCuenta BIGINT ,
            @IdF_crdmMoneda BIGINT ,
            @IdT_crdpSegmento BIGINT ,
            @CuotaTotal DECIMAL(18, 2) ,
            @IdEntidad BIGINT ,
            @IdT_TipoTransaccionOri BIGINT ,
            @IdT_crddSaldoNivel BIGINT ,
            @IdCanalVenta BIGINT ,
            @IdF_crdcEsquemaContable BIGINT ,
            @IdArticulo BIGINT ,
            @IdT_crdmAutorizacion BIGINT ,
            @IdT_auttAutorizacion BIGINT ,
            @TasaInteresMora MONEY ,
            @CodRespuestaReapli VARCHAR(10) ,
            @RepuestaVerif VARCHAR(50) ,
            @NivelRevolvente INT ,
            @NivelRevolventeExt INT ,
            @PrimaTotal DECIMAL(18, 2) ,
            @SaldoFinal DECIMAL(18, 2) ,
            @IdF_crdcRazonStatusCuenta BIGINT ,
            @IdF_crdcRazonStatusCuentaNvo BIGINT ,
            @FechaPrimerPago DATETIME ,
            @PlazoBase INT ,
            @TasaInteresBase DECIMAL(18, 4) ,
            @Especificacion VARCHAR(MAX) ,
            @MontoCuotaMinima DECIMAL(18, 2) ,
            @AfectaDisponible DECIMAL(18, 2) ,
            @DevengaFuturo BIT ,
            @EsPromocional BIT ,
            @IdF_autcTipoAutorizacion BIGINT ,
            @FechaInicioDevengo DATETIME ,
            @FechaMaximaPago DATETIME ,
            @IdF_crdmAutorizacionPadre BIGINT ,
            @FechaProximoCorte DATETIME ,
            @MinimoDiasCuota INT ,
            @DiasPendiente INT ,
            @ContratoPromocional BIT ,
            @DescripcionPromocion VARCHAR(50) ,
            @TasaInteresTraslado DECIMAL(18, 4) ,
            @DetallePromocional VARCHAR(MAX) ,
            @IdT_crdpPromocion BIGINT ,
            @PlazoTraslado INT ,
            @IdF_crdpPlanFinancieroAsoc BIGINT ,
            @CondicionFinanciera VARCHAR(MAX) ,
            @FactorPago VARCHAR(MAX) ,
            @CondicionFinancieraAux VARCHAR(MAX) ,
            @HabilitarCuotaCero BIT ,
            @IdF_crdpModalidadFechaPago BIGINT ,
            @UsaFechaVenta BIT ,
            @CicloAnteriorPosterior INT ,
            @AlcancePago INT ,
            @PagaIndividual BIT ,
            @PrincipalCuota DECIMAL(18, 2) ,
            @ImpPrincipalCuota DECIMAL(18, 2) ,
            @CuotaCompra DECIMAL(18, 2) ,
            @CuotaCompraSinGA DECIMAL(18, 2) = 0.00 ,
            @IdF_crddPlazosInformativos BIGINT ,
            @CondicionFinancieraInformativo VARCHAR(MAX) ,
            @FactorPagoInformativo VARCHAR(MAX) ,
            @MontoTotal DECIMAL(18, 2) ,
            @Productos VARCHAR(MAX) ,
            @IdF_crdpMetodoDevengamiento BIGINT ,
            @MontoImpuesto DECIMAL(18, 2) ,
            @MontoFinanciarImpuesto DECIMAL(18, 2) ,
            @PlazoInformativo INT ,
            @NumCuotaInicial INT ,
            @ImprimioContrato BIT ,
            @ImprimioPagare BIT ,
            @ImprimioHojaResumen BIT ,
            @FechaCancelacion DATETIME ,
            @ConceptoAux INT ,
            @MessageBody XML ,
            @MessageDetail XML ,
            @NombreUsual VARCHAR(MAX) ,
            @TCEA DECIMAL(18, 4) ,
            @IdF_clicPais BIGINT ,
            @ContratoSAPV BIGINT ,
            @PagareSAPV BIGINT ,
            @HojaResumenSAPV BIGINT ,
            @IdT_climPersona BIGINT = 0

        /* MODIFICACION SOPORTE PRODUCCION - DANIEL PACHECO / 24-05-2016 */

        DECLARE @PlazoPactado INT ,
            @CuotaPactada DECIMAL(18, 2)


	  /* MODIFICACION SOPORTE PRODUCCION - DANIEL PACHECO / 24-05-2016 */
      
      --Modificacion Minor Quiros
        SELECT  @IdF_clicPais = IdF_clicPais
        FROM    t_crdgParametrosGlobal WITH ( NOLOCK )
		  
        SELECT  @ContratoSAPV = ContratoSAPV ,
                @PagareSAPV = PagareSAPV ,
                @HojaResumenSAPV = HojaResumenSAPV
        FROM    t_clipParametroDocumento WITH ( NOLOCK )
        WHERE   IdF_clicPais = @IdF_clicPais   
	 --Fin Modificacion Minor Quiros 	           
                  
        DECLARE @tblEspecificacion TABLE
            (
              Id BIGINT IDENTITY(1, 1)
                        PRIMARY KEY
                        NOT NULL ,
              Descripcion VARCHAR(MAX) NULL
            )                  
                         
        DECLARE @tblArticulo TABLE
            (
              Id BIGINT IDENTITY(1, 1)
                        PRIMARY KEY
                        NOT NULL ,
              Concepto INT NULL ,
              Monto DECIMAL(18, 2) NULL ,
              MontoImpuesto DECIMAL(18, 2) NULL ,
              MontoFomento DECIMAL(18, 2) NULL ,
              Prima DECIMAL(18, 2) NULL ,
              Plazo INT NULL ,
              ComboPadre VARCHAR(80) NULL ,
              ComboIdCreacion VARCHAR(80) NULL ,
              CodigoArticulo VARCHAR(50) NULL ,
              Descripcion VARCHAR(MAX) NULL ,
              VigenciaProveedor INT NULL ,
              IdPKDetailRef BIGINT NULL ,
              IdPFDetailRef BIGINT NULL ,
              IdArticulo BIGINT NULL ,
              Productos VARCHAR(MAX)
            )                    
                              
 --CONSTANTES                  
 -----------------------------                    
                  
        DECLARE @CONCEPTO_ARTICULO INT     = 1                  
        DECLARE @CONCEPTO_EXTRA_GARANTIA INT    = 2                   
        DECLARE @TIPO_SEGMENTO_EXT INT     = 9                  
        DECLARE @SEGMENTO_PROMOCIONAL INT    = 5                  
        DECLARE @SEGMENTO_PLAZO_FIJO INT     = 7                  
        DECLARE @RESPUESTA_APROVADO VARCHAR(1)    = 'A'                  
        DECLARE @VENTA_AL_CREDITO VARCHAR(50)    = 'VENTA_AL_CREDITO'                  
        DECLARE @VENTA_AL_CREDITO_EXT VARCHAR(50)   = 'VENTA_AL_CREDITO_EXT'                                   
        DECLARE @VENTA VARCHAR(50)       = 'VENTA'                   
        DECLARE @VENTA_MONTO_PRIMA VARCHAR(50)    = 'VENTA_MONTO_PRIMA'                   
        DECLARE @VENTA_MONTO_OPERACION VARCHAR(50)   = 'VENTA_MONTO_OPERACION'                  
        DECLARE @VENTA_MONTO_FACTURA VARCHAR(50)   = 'VENTA_MONTO_FACTURA'                  
        DECLARE @VENTA_MONTO_OPERACION_EXT VARCHAR(50)  = 'VENTA_MONTO_OPERACION_EXT'                  
        DECLARE @LLAVE_VENTA VARCHAR(50)     = 'Venta'                    
        DECLARE @LLAVE_CAMBIO_RAZON_ESTADO VARCHAR(50)  = 'CambioRazonEstado'                  
        DECLARE @LLAVE_CAMBIO_RAZON_ESTADONV VARCHAR(50) = 'NuevoCambioRazonEstado'
        
        DECLARE @VENTA_AL_CREDITO_SEG_AUTEXP VARCHAR(50) = 'VENTA_AL_CREDITO_SEG_AUTOEXPEDIBLE'
        DECLARE @SEGMENTO_AUTOEXPEDIBLE BIGINT = 70001
                  
        DECLARE @ESTADO_ACTIVO INT    = 1                    
        DECLARE @ESTADO_FINAL INT    = 4                    
        
        DECLARE @TipoSegDeudor INT = 1
        DECLARE @TipoSegFijo INT = 5
        
        DECLARE @TRUE INT = 1
        DECLARE @FALSE INT = 0

		--MODIFICACIÓN 2.2
        DECLARE @VentaConvenio BIT = 0
        DECLARE @DescripcionConvenio VARCHAR(500) = ''
        DECLARE @DescripcionEntidad VARCHAR(500) = ''
        DECLARE @IdT_clicConvenio BIGINT = NULL

        DECLARE @AplicaWOConvenios BIT = 0
                   
 --ASIGNACION                  
 -- Se asigan variable por defecto-                  
        SELECT  @NumTransaccion = CASE WHEN @NumTransaccion IS NULL THEN ''
                                       ELSE @NumTransaccion
                                  END                  
                          
        SELECT  @NumRefFactura = CASE WHEN @NumRefFactura IS NULL THEN ''
                                      ELSE @NumRefFactura
                                 END                   
                   
        SELECT  @MontoVenta = CASE WHEN @MontoVenta IS NULL THEN -1
                                   ELSE @MontoVenta
                              END                  
                   
        SELECT  @Sucursal = CASE WHEN @Sucursal IS NULL THEN -1
                                 ELSE @Sucursal
                            END                  
                   
        SELECT  @Terminal = CASE WHEN @Terminal IS NULL THEN -1
                                 ELSE @Terminal
                            END
                            
        SELECT @AplicaWOConvenios = A.AplicaWOConvenios 
          FROM dbo.t_crdgParametrosGlobal A WITH(NOLOCK)                                                                        
 -----------------------------                  
 --VARIABLES                  
        SELECT  @Priority = 1                  
        SELECT  @Severity = 'Error'                  
        SELECT  @ProcessID = '0'                  
        SELECT  @ProcessName = OBJECT_NAME(@@procid) --Obtiene el nombre del proceso en ejecucion                  
        SELECT  @MessageUser = ''                  
        SELECT  @MessageSystem = ''                  
        SELECT  @Observation = ''                  
        SELECT  @UserNumber = 75000                  
        SELECT  @SystemNumber = 0                  
        SELECT  @Severidad = 16                  
        SELECT  @Parameter = ' @Usuario   =' + CONVERT(VARCHAR, @Usuario)
                + ',@NumTransaccion =' + CONVERT(VARCHAR, @NumTransaccion)
                + ',@NumRefFactura =' + CONVERT(VARCHAR, @NumRefFactura)
                + ',@MontoVenta  =' + CONVERT(VARCHAR, @MontoVenta)
                + ',@Sucursal     =' + CONVERT(VARCHAR, @Sucursal)
                + ',@Terminal     =' + CONVERT(VARCHAR, @Terminal)
                + ',@TipoOperacion =' + CONVERT(VARCHAR, @TipoOperacion)                 
                  
                  
                           
        SELECT  @MontoFomento = 0.00 ,
                @MontoFactura = 0.00 ,
                @MontoPrima = 0.00 ,
                @MontoTotalFinanciar = 0.00                  
                              
        SELECT  @CodRespuesta = '1' ,
                @Repuesta = 'Transacción Aplicada'                  
                     
        SELECT  @CodRespuestaReapli = '2' ,
                @RepuestaVerif = 'Transacción Previamente Aplicada'                  
                     
                   
 --CONSTANTES                   
 --+++++++++++++++++++++++++++                  
        DECLARE @VENTA_MONTO_FOMENTO VARCHAR(50)  = 'VENTA_MONTO_FOMENTO'                  
                   
 -----------------------------                  
 --CUERPO PROCEDIMIENTO                  
 -----------------------------                  
        SET XACT_ABORT ON;                  
                  
        BEGIN TRY                  
  --++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++                  
            SELECT  @NumResultado = 0                    
            SELECT  @MsgResultado = ''                   
            SELECT  @ContratoPromocional = 0                
            SELECT  @PrincipalCuota = 0              
            SELECT  @ImpPrincipalCuota = 0     
            SELECT  @NumCuotaInicial = 0           
                   
            SELECT  @UserNumber = 75001                  
            SELECT  @MessageUser = 'Error al obtener la organizacion <Organizacion>.'                   
                     
            SELECT  @CodigoOrganizacion = dbo.fnc_crdObtenerIdOrganizacion()                                     
                      
            SELECT  @UserNumber = 75004                  
                       
   --Verbos a utilizar de acuerdo a la operacion=select:seleccionar, delete: eliminar, update: actualizar, insert: insertar, exec: ejecutar                  
            SELECT  @MessageUser = 'Error al actualizar la tabla t_crddSaldoDetallado los columnas de saldo principal.'                   
                       
            SELECT  @IdT_auttAutorizacion = aut.IdT_auttAutorizacion ,
                    @IdRespuestaAutorizacion = aut.IdRefAutorizacion ,
                    @FechaTransaccion = aut.Fecha ,
                    @IdPlanPromoArticulo = IdF_crddPlanPromoArticulo ,
                    @MontoFomento = ISNULL(aut.MontoFomento, 0.00) ,
                    @IdT_crdmCuenta = aut.IdF_crdmCuenta ,
                    @IdF_crdmMoneda = aut.IdF_crdmMoneda ,
                    @IdT_crdpSegmento = aut.IdF_crdpSegmento ,
                    @IdT_TipoTransaccionOri = aut.IdF_crdcTransaccion ,
                    @IdCanalVenta = aut.IdF_invcCanalVenta ,
                    @PrimaTotal = aut.Prima ,
                    @IdF_autcTipoAutorizacion = aut.IdF_autcTipoAutorizacion ,
                    @IdF_crdmAutorizacionPadre = aut.IdF_crdmAutorizacionPadre ,
                    @IdF_crddPlazosInformativos = aut.IdF_crddPlazosInformativos ,
                    @Productos = aut.Productos
            FROM    dbo.t_auttAutorizacion aut WITH ( NOLOCK )
                    INNER JOIN dbo.t_autcRespuestaAutorizacion ra WITH ( NOLOCK ) ON ( aut.IdF_autcRespuestaAutorizacion = ra.IdT_autcRespuestaAutorizacion
                                                              AND ra.TipoRespuesta = @RESPUESTA_APROVADO
                                                              )
            WHERE   NumTransaccion = @NumTransaccion                  
            IF @@ROWCOUNT = 0
                BEGIN                  
                    IF @TipoOperacion = 2
                        BEGIN                  
                       
                            SELECT  @UserNumber = 75005 ,
                                    @MessageUser = 'Error al obterner los datos de la venta tabla <t_crdmAutorizacion>. Numero de transacción: '
                                    + CONVERT(VARCHAR, @NumTransaccion)       
                         
                            SELECT  @FechaTransaccion = Fecha ,
                                    @IdRespuestaAutorizacion = IdRefAutorizacion ,
                                    @MontoPrima = aut.Prima ,
                                    @MontoTotalFinanciar = aut.MontoFinanciar ,
                                    @Plazo = aut.PlazoBase ,
                                    @CuotaTotal = aut.Cuota ,
                                    @IdT_crdmCuenta = aut.IdF_crdmCuenta ,
                                    @IdF_crdmMoneda = aut.IdF_crdmMoneda ,
                                    @IdT_crdpSegmento = aut.IdF_crdpSegmento ,
                                    @IdT_TipoTransaccionOri = aut.IdF_crdcTransaccion ,
                                    @SaldoFinal = aut.SaldoFinal ,
                                    @FechaPrimerPago = aut.FechaPrimerPago ,
                                    @TasaInteresBase = aut.TasaInteresBase ,
                                    @DetallePromocional = aut.DetallePromocional ,
                                    @CuotaCompra = aut.CuotaCompra
                            FROM    dbo.t_crdmAutorizacion aut WITH ( NOLOCK )
                            WHERE   NumTransaccion = @NumTransaccion                    
                            IF @@ROWCOUNT = 0
                                BEGIN                  
                                    SELECT  @UserNumber = 75006 ,
                                            @MessageUser = 'La venta no se encuentra pre-autorizada. Numero de transacción: '
                                            + CONVERT(VARCHAR, @NumTransaccion)                    
                         
                                    SELECT  @NumResultado = @UserNumber                  
                                    SELECT  @MsgResultado = @MessageUser;                  
       --Levanta el error                    
                                    RAISERROR(@MessageUser,16,1)  
                                    --THROW @UserNumber,@MessageUser,1                    
                                END                             
                       
                            SELECT  @TasaInteresBase = @TasaInteresBase / 12                   
                          
                            SELECT  CodRespuesta = @CodRespuestaReapli ,
                                    Fecha = CONVERT(DATE, @FechaTransaccion) ,
                                    Hora = CONVERT(TIME, @FechaTransaccion) ,
                                    NumTransaccion = @NumTransaccion ,
                                    NumTransaccionGene = @IdRespuestaAutorizacion ,
                                    Enganche = @MontoPrima ,
                                    ImporteAutorizado = @MontoTotalFinanciar ,
                                    Plazo = @Plazo ,
                                    CuotaTotal = @CuotaTotal ,
                                    Comentario = @RepuestaVerif ,
                                    SaldoFinal = @SaldoFinal ,
                                    FechaPrimerPago = @FechaPrimerPago ,
                                    TasaInteres = @TasaInteresBase ,
                                    DatosGenerales = CONVERT(VARCHAR, @CodRespuestaReapli)
                                    + '|'
                                    + CONVERT(VARCHAR, CONVERT(DATE, @FechaTransaccion))
                                    + '|'
                                    + CONVERT(VARCHAR, CONVERT(TIME, @FechaTransaccion))
                                    + '|' + CONVERT(VARCHAR, @NumTransaccion)
                                    + '|'
                                    + CONVERT(VARCHAR, @IdRespuestaAutorizacion)
                                    + '|' + CONVERT(VARCHAR, @MontoPrima)
                                    + '|'
                                    + CONVERT(VARCHAR, @MontoTotalFinanciar)
                                    + '|' + CONVERT(VARCHAR, @Plazo) + '|'
                                    + CONVERT(VARCHAR, @CuotaTotal) + '|'
                                    + CONVERT(VARCHAR, @RepuestaVerif) + '|'
                                    + CONVERT(VARCHAR, @SaldoFinal) + '|'
                                    + CONVERT(VARCHAR, @FechaPrimerPago) + '|'
                                    + CONVERT(VARCHAR, @TasaInteresBase) ,
                                    DetallePromocional = @DetallePromocional ,
                                    CuotaCompra = @CuotaCompra ,
                                    IdT_crdmAutorizacion = 0 ,
                                    ImprimioContrato = 0 ,
                                    ImprimioPagare = 0 ,
                                    FechaCancelacion = '1900-01-01' ,
                                    DetalleDeudor = '0|' ,
                                    TasaEfectiva = 0 ,
                                    CuotaCompraSinGA = 0
                       
                     
             
                            RETURN 0                  
                        END                  
                    ELSE
                        BEGIN                  
                            SELECT  @UserNumber = 75007 ,
                                    @MessageUser = 'La venta no se encuentra pre-autorizada. Numero de transacción: '
                                    + CONVERT(VARCHAR, @NumTransaccion)                    
                       
                            SELECT  @NumResultado = @UserNumber                  
                            SELECT  @MsgResultado = @MessageUser;                  
     --Levanta el error                    
                            RAISERROR(@MessageUser,16,1)
                            --THROW @UserNumber,@MessageUser,1                      
                        END                    
                      
                            
                END                   
                     
                              
            SELECT  @IdT_crdpSegmentoOrinal = @IdT_crdpSegmento                  
                     
            SELECT  @UserNumber = 75008                  
            SELECT  @MessageUser = 'Error al obtener datos de la tabla t_crdgParametrosGlobal.'                   
            SELECT  @FechaProceso = FechaProceso ,
                    @AplicacionExtGarantia = AplicacionExtGarantia ,
                    @CicloAnteriorPosterior = CicloAnteriorPosterior
            FROM    dbo.t_crdgParametrosGlobal WITH ( NOLOCK )                  
            IF @@ROWCOUNT = 0
                BEGIN                  
                    SELECT  @UserNumber = 75009 ,
                            @MessageUser = 'Error al obtener los datos goblales en la tabla <t_crdgParametrosGlobal>:No existe parametros generales definidos.'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;                 
     --Levanta el error                    
                    RAISERROR(@MessageUser,16,1) 
                    --THROW @UserNumber,@MessageUser,1                    
                  
                END                  
                                 
                 
            SELECT  @UserNumber = 75010                     
            SELECT  @MessageUser = 'Error al obtener datos de la tabla t_crdmCuenta.'                    
            SELECT  @IdPlanFinancieroBase = CU.IdF_crdpPlanFinanciero ,
                    @IdF_crdmCiclo = CU.IdF_crdmCiclo ,
                    @IdF_crdcCartera = CU.IdF_crdcCartera ,
                    @FechaCreacionCuenta = CU.FechaApertura ,
                    @Cuenta = CU.Cuenta ,
                    @IdF_crdcRazonStatusCuenta = IdF_crdcRazonStatusCuenta ,
                    @PlazoBase = PM.Plazo ,
                    @TasaInteresBase = PM.TasaInteresNormal ,
                    @FechaMaximaPago = CU.FechaMaximaPago ,
                    @MinimoDiasCuota = PF.MinimoDiasCuota ,
                    @ImprimioContrato = PE.ImprimioContrato ,
                    @ImprimioPagare = PE.ImprimioPagare ,
                    @NombreUsual = PE.NombreUsual ,
                    @IdT_climPersona = PE.IdT_climPersona
            FROM    dbo.t_crdmCuenta CU WITH ( NOLOCK )
                    INNER JOIN dbo.t_crddPlanMoneda PM WITH ( NOLOCK ) ON ( CU.IdF_crdpPlanFinanciero = PM.IdF_crdpPlanFinanciero
                                                              AND PM.IdF_crdmMoneda = @IdF_crdmMoneda
                                                              )
                    INNER JOIN dbo.t_crdpPlanFinanciero PF WITH ( NOLOCK ) ON ( CU.IdF_crdpPlanFinanciero = PF.IdT_crdpPlanFinanciero )
                    INNER JOIN dbo.t_crdmCuentaAdicional ca WITH ( NOLOCK ) ON ( CU.IdT_crdmCuenta = ca.IdF_crdmCuenta
                                                              AND ca.Titular = 1
                                                              )
                    INNER JOIN dbo.t_climPersona PE WITH ( NOLOCK ) ON ( ca.IdF_climPersona = PE.IdT_climPersona )
            WHERE   IdT_crdmCuenta = @IdT_crdmCuenta                  
                     
            IF @@ROWCOUNT = 0
                BEGIN                      
                    SELECT  @UserNumber = 75011 ,
                            @MessageUser = 'Error al obtener los datos de la Cuenta:No existe datos de la cuenta.'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;                  
     --Levanta el error                    
                    RAISERROR(@MessageUser,16,1)  
                    --THROW @UserNumber,@MessageUser,1                    
                END                      
                     
            SELECT  @UserNumber = 75012                  
            SELECT  @MessageUser = 'Error al obtener datos de la tabla t_crddSaldoMoneda.'                   
            SELECT  @UltimoCorrelativo = ISNULL(UltimoCorrelativo, 1)
            FROM    dbo.t_crddSaldoMoneda WITH ( NOLOCK )
            WHERE   IdF_crdmCuenta = @IdT_crdmCuenta
                    AND IdF_crdmMoneda = @IdF_crdmMoneda                  
                     
            IF @@ROWCOUNT = 0
                BEGIN                      
                    SELECT  @UserNumber = 75013 ,
                            @MessageUser = 'Error al obtener los datos de la Cuenta:No existe datos de la cuenta.'  
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;       
     --Levanta el error                    
                    RAISERROR(@MessageUser,16,1)
                    --THROW @UserNumber,@MessageUser,1                    
                END                   
                     
            SELECT  @IdF_crdcEsquemaContable = SV.IdF_crdcEsquemaContable
            FROM    dbo.t_invcCanalVenta CV WITH ( NOLOCK )
                    INNER JOIN dbo.t_crddSegmentoCanalVenta SV WITH ( NOLOCK ) ON ( SV.IdF_invcCanalVenta = CV.IdT_invcCanalVenta
                                                              AND SV.Estado = 1
                                                              )
            WHERE   IdT_invcCanalVenta = @IdCanalVenta
                    AND SV.IdF_crdpSegmento = @IdT_crdpSegmento
                    AND CV.Estado = 1                         
            IF @@ROWCOUNT = 0
                BEGIN                  
                    SELECT  @UserNumber = 75014 ,
                            @MessageUser = 'El canal de venta no se encuentra parametrizado por el Segmento. Canal de Venta: '
                            + CONVERT(VARCHAR, @IdCanalVenta)                    
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;                  
     --Levanta el error                
                    RAISERROR(@MessageUser,16,1) 
                    --THROW @UserNumber,@MessageUser,1                            
                END                   
                       
                     
            SELECT  @UserNumber = 75015                  
            SELECT  @MessageUser = 'Error al obtener datos de los articulos @tblArticulo.'                   
            INSERT  @tblArticulo
                    ( Concepto ,
                      Monto ,
                      MontoImpuesto ,
                      MontoFomento ,
                      Prima ,
                      Plazo ,
                      ComboPadre ,
                      ComboIdCreacion ,
                      CodigoArticulo ,
                      Descripcion ,
                      VigenciaProveedor ,
                      IdPKDetailRef ,
                      IdPFDetailRef ,
                      IdArticulo ,
                      Productos                          
                    )
                    SELECT  Concepto = Concepto ,
                            Monto = SUM(Monto) - SUM(MontoImpuesto) ,
                            MontoImpuesto = SUM(MontoImpuesto) ,
                            MontoFomento = SUM(MontoFomento) ,
                            Prima = SUM(Prima) ,
                            Plazo = MAX(Plazo) ,
                            ComboPadre = '' ,
                            ComboIdCreacion = '' ,
                            CodigoArticulo = '' ,
                            Descripcion = '' ,
                            VigenciaProveedor = 0 ,
                            IdPKDetailRef = 0 ,
                            IdPFDetailRef = 0 ,
                            IdArticulo = 0 ,
                            Productos = ''
                    FROM    dbo.t_autdAutorizacionDetalle WITH ( NOLOCK )
                    WHERE   IdF_auttAutorizacion = @IdT_auttAutorizacion
                            AND Concepto = @CONCEPTO_ARTICULO
                            AND CodigoArticulo != ComboPadre
                    GROUP BY Concepto                  
                  
            UPDATE  @tblArticulo
            SET     Descripcion = dbo.uft_crdObtenerDescripcionArticulos(@IdT_auttAutorizacion,
                                                              @CONCEPTO_ARTICULO)
                      
            INSERT  @tblArticulo
                    ( Concepto ,
                      Monto ,
                      MontoImpuesto ,
                      MontoFomento ,
                      Prima ,
                      Plazo ,
                      ComboPadre ,
                      ComboIdCreacion ,
                      CodigoArticulo ,
                      Descripcion ,
                      VigenciaProveedor ,
                      IdPKDetailRef ,
                      IdPFDetailRef ,
                      IdArticulo ,
                      Productos                          
                    )
                    SELECT  Concepto = Concepto ,
                            Monto = Monto - MontoImpuesto ,
                            MontoImpuesto = MontoImpuesto ,
                            MontoFomento = MontoFomento ,
                            Prima = Prima ,
                            Plazo = Plazo ,
                            ComboPadre = ComboPadre ,
                            ComboIdCreacion = ComboIdCreacion ,
                            CodigoArticulo = CodigoArticulo ,
                            Descripcion = Descripcion ,
              VigenciaProveedor = MesesGarantiaProveedor ,
                            IdPKDetailRef = IdPKDetailRef ,
                            IdPFDetailRef = IdPFDetailRef ,
                            IdArticulo = IdF_invcArticulo ,
                            Productos = ''
                    FROM    dbo.t_autdAutorizacionDetalle WITH ( NOLOCK )
                    WHERE   IdF_auttAutorizacion = @IdT_auttAutorizacion
                            AND Concepto = @CONCEPTO_EXTRA_GARANTIA                  
                   
            UPDATE  @tblArticulo
            SET     Productos = dbo.uft_crdObtenerDetalleArticulos(@Productos,
                                                              Concepto,
                                                              IdPKDetailRef)                    
                                                                      
            IF NOT EXISTS ( SELECT  1
                            FROM    @tblArticulo )
                BEGIN                  
                    SELECT  @UserNumber = 75016 ,
                            @MessageUser = 'La venta no tiene artículos registrados. Numero de transacción: '
                            + @NumTransaccion                    
                      
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;                  
    --Levanta el error                    
                    RAISERROR(@MessageUser,16,1)
                    --THROW @UserNumber,@MessageUser,1                   
                END                    
			
            IF ( @MontoVenta != ( SELECT    SUM(( ( AR.Monto
                                                    + AR.MontoImpuesto )
                                                  - AR.Prima )
                                                * TP.ValidaMontoAutorizacion)
                                  FROM      @tblArticulo AR
                                            INNER JOIN dbo.t_crdcTipoProducto TP
                                            WITH ( NOLOCK ) ON ( AR.Concepto = TP.IdT_crdcTipoProducto )
                                ) )
                BEGIN                  
                    SELECT  @UserNumber = 75017 ,
                            @MessageUser = 'El monto de la venta no coencide con el monto de la pre-autorizacion. Numero de transacción: '
                            + @NumTransaccion                    
                      
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;                
    --Levanta el error                    
                    RAISERROR(@MessageUser,16,1)   
                    --THROW @UserNumber,@MessageUser,1                   
                END                  
                
            IF @IdF_autcTipoAutorizacion = 1
                BEGIN                  
                    INSERT  INTO @tblEspecificacion
                            SELECT  '|Operación&'
                                    + ISNULL(CONVERT(VARCHAR, @NumRefFactura),
                                             '') + '&bigint'
                                    + '|Extra Garantía&'
                                    + ISNULL(CONVERT(VARCHAR, CASE
                                                              WHEN ISNULL(ADA.Monto,
                                                              0) > 0 THEN 'Si'
                                                              ELSE 'No'
                                                              END), '')
                                    + '&varchar' + '|Código Artículo&'
                                    + ISNULL(CONVERT(VARCHAR, AD.CodigoArticulo),
                                             '') + '&bigint' + '|Descripción&'
                                    + ISNULL(CONVERT(VARCHAR, REPLACE(AD.Descripcion,
                                                              '&', '')), '')
                                    + '&varchar' + '|Monto Artículo&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), AD.Monto
                                             - AD.MontoImpuesto)), '')
                                    + '&decimal' + '|Monto Impuesto Artículo&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), AD.MontoImpuesto)),
                                             '') + '&decimal' + '|Prima&'
                                    + ISNULL(CONVERT(VARCHAR, AD.Prima), '')
                                    + '&decimal' + '|Monto Extra&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), ISNULL(ADA.Monto
                                                              - ADA.MontoImpuesto,
                                                              0))), '')
                                    + '&decimal' + '|Monto Impuesto Extra&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), ISNULL(ADA.MontoImpuesto,
                                                              0))), '')
                                    + '&decimal' + '|Monto Total&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), CONVERT(DECIMAL(18,
                                                              2), AD.Monto)
                                             + ISNULL(ADA.Monto, 0) - AD.Prima)),
                                             '') + '&decimal'
                            FROM    dbo.t_autdAutorizacionDetalle AD WITH ( NOLOCK )
                                    LEFT JOIN dbo.t_autdAutorizacionDetalle ADA
                                    WITH ( NOLOCK ) ON ( AD.IdF_auttAutorizacion = ADA.IdF_auttAutorizacion
                                                         AND AD.IdPKDetailRef = ADA.IdPFDetailRef
                                                         AND ADA.Concepto = @CONCEPTO_EXTRA_GARANTIA
                                                       )
                            WHERE   AD.IdF_auttAutorizacion = @IdT_auttAutorizacion
                                    AND AD.Concepto = @CONCEPTO_ARTICULO                  
                END                                  
            ELSE
                BEGIN                  
                    INSERT  INTO @tblEspecificacion
                            SELECT  '|Operación&'
                                    + ISNULL(CONVERT(VARCHAR, @NumRefFactura),
                                             '') + '&bigint'
                                    + '|Extra Garantía&'
                                    + ISNULL(CONVERT(VARCHAR, CASE
                                                              WHEN ISNULL(ADA.Monto,
                                                              0) > 0 THEN 'Si'
                                                              ELSE 'No'
                                                              END), '')
                                    + '&varchar' + '|Código Artículo&'
                                    + ISNULL(CONVERT(VARCHAR, AD.CodigoArticulo),
                                             '') + '&bigint' + '|Descripción&'
                                    + ISNULL(CONVERT(VARCHAR, REPLACE(AD.Descripcion,
                                                              '&', '')), '')
                                    + '&varchar' + '|Monto Artículo&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), AD.Monto
                                             - AD.MontoImpuesto)), '')
                                    + '&decimal' + '|Monto Impuesto Artículo&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), AD.MontoImpuesto)),
                                             '') + '&decimal' + '|Prima&'
                                    + ISNULL(CONVERT(VARCHAR, AD.Prima), '')
                                    + '&decimal' + '|Monto Extra&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), ISNULL(ADA.Monto
                                                              - ADA.MontoImpuesto,
                                                              0))), '')
                                    + '&decimal' + '|Monto Impuesto Extra&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), ISNULL(ADA.MontoImpuesto,
                                                              0))), '')
                                    + '&decimal' + '|Monto Total&'
                                    + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              2), CONVERT(DECIMAL(18,
                                                              2), AD.Monto)
                                             + ISNULL(ADA.Monto, 0) - AD.Prima)),
                                             '') + '&decimal'
                            FROM    dbo.t_crddAutorizacionDetalle AD WITH ( NOLOCK )
                                    INNER JOIN dbo.t_autdAutorizacionDetalle ADA
                                    WITH ( NOLOCK ) ON ( ADA.IdF_auttAutorizacion = @IdT_auttAutorizacion
                                                         AND AD.IdPKDetailRef = ADA.IdPFDetailRef
                                                         AND ADA.Concepto = @CONCEPTO_EXTRA_GARANTIA
                                                       )
                            WHERE   AD.IdF_crdmAutorizacion = @IdF_crdmAutorizacionPadre
                                    AND AD.IdF_crdcTipoProducto = @CONCEPTO_ARTICULO                  
                END                  
                     
            SELECT  @UserNumber = 75018                      
            SELECT  @MessageUser = 'Error al obtener el maximo y minimo valor tabla sp @tblDevengoInt.'                              
            SELECT  @CountMin = MIN(Id) ,
                    @CountMax = MAX(Id) ,
                    @Especificacion = ''
            FROM    @tblEspecificacion                      
                                  
            WHILE ( @CountMin <= @CountMax )
                BEGIN                    
                    SELECT  @Especificacion = @Especificacion
                            + CASE WHEN Id = 1
                                   THEN 'Linea&' + CONVERT(VARCHAR, Id)
                                        + '&varchar' + Descripcion
                                   ELSE '|Linea&' + CONVERT(VARCHAR, Id)
                                        + '&varchar' + Descripcion
                              END
                    FROM    @tblEspecificacion
                    WHERE   Id = @CountMin                  
                       
                    SELECT  @CountMin = @CountMin + 1                  
                END                
                      
                         
            SELECT  @UserNumber = 75019 ,
                    @MessageUser = 'Error al obtener datos de la tienda en la tabla t_climTienda.'              
            SELECT  @IdF_crdcSubCuenta = IdF_crdcSubCuenta ,
                    @IdF_crdcOrigen = IdF_crdcOrigen
            FROM    dbo.t_climTienda WITH ( NOLOCK )
            WHERE   CodigoTienda = @Sucursal                  
                  
            IF @@ROWCOUNT = 0
                BEGIN                  
                        
                    SELECT  @UserNumber = 75020 ,
                            @MessageUser = 'Error al obtener los datos de la tienda:No existe la sub cuenta definida.'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;                 
     --Levanta el error                    
                    RAISERROR(@MessageUser,16,1)
                    --THROW @UserNumber,@MessageUser,1                     
                  
                END                   
                     
            SELECT  @UserNumber = 75021                  
            SELECT  @MessageUser = 'Error al obtener datos del plan financiero en la tabla t_crddPlanSegmento.'                  
                     
            SELECT  @Plazo = pm.Plazo ,
                    @TasaInteresNormal = pm.TasaInteresNormal ,
                    @IdPlanFianciero = cu.IdF_crdpPlanFinanciero ,
                    @TasaInteresMora = pm.TasaInteresMora ,
                    @NivelRevolvente = ps.NivelRevolvente ,
                    @MontoCuotaMinima = pm.MontoCuotaMinima ,
                    @IdF_crdmCiclo = cu.IdF_crdmCiclo ,
                    @IdF_crdpPlanFinancieroAsoc = IdF_crdpPlanFinancieroAsoc
            FROM    dbo.t_crdmCuenta cu WITH ( NOLOCK )
                    INNER JOIN dbo.t_crddPlanSegmento ps WITH ( NOLOCK ) ON ( cu.IdF_crdpPlanFinanciero = ps.IdF_crdpPlanFinanciero
                                                              AND ps.IdF_crdpSegmento = @IdT_crdpSegmento
                                                              )
                    INNER JOIN dbo.t_crddPlanMoneda pm WITH ( NOLOCK ) ON ( ps.IdF_crdpPlanFinancieroAsoc = pm.IdF_crdpPlanFinanciero )
            WHERE   cu.IdT_crdmCuenta = @IdT_crdmCuenta
                    AND pm.IdF_crdmMoneda = @IdF_crdmMoneda                   
            IF @@ROWCOUNT = 0
                BEGIN                  
                        
                    SELECT  @UserNumber = 75050 ,
                            @MessageUser = 'Error al obtener los datos del segmento y planfinanciero. No existen en la tabla <t_crddPlanSegmento>'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;                 
     --Levanta el error                    
                    RAISERROR(@MessageUser,16,1) 
                    --THROW @UserNumber,@MessageUser,1                     
                  
                END                  
                              
            SELECT  @UserNumber = 75022                  
            SELECT  @MessageUser = 'Error al obtener datos del tipo del segmento en la tabla t_crdpSegmento.'                  
                       
            SELECT  
			        --@IdTipoSegmento = SEG.IdF_crdcTipoSegmento ,
                    @EsPromocional = TSEG.EsPromocional ,
                    @IdF_crdpModalidadFechaPago = SEG.IdF_crdpModalidadFechaPago ,
                    @AlcancePago = SEG.AlcancePago ,
                    @PagaIndividual = SEG.PagaIndividual ,
                    @IdF_crdpMetodoDevengamiento = SEG.IdF_crdpMetodoDevengamiento
            FROM    dbo.t_crdpSegmento SEG WITH ( NOLOCK )
                    INNER JOIN dbo.t_crdcTipoSegmento TSEG WITH ( NOLOCK ) ON ( SEG.IdF_crdcTipoSegmento = TSEG.IdT_crdcTipoSegmento )
            WHERE   IdT_crdpSegmento = @IdT_crdpSegmento                          
                       
                     
   -- Si el segmento es promocional y la venta se asocio a una promocion                  
   -- se verifican los meses de gracia                   
            SELECT  @UserNumber = 75023                  
            SELECT  @MessageUser = 'Error al obtener datos dela promocion en la tabla t_crdpPromocion.'                  
            SELECT  @MesesGracia = 0                  
                              
            IF @EsPromocional = 1
                AND @IdPlanPromoArticulo > 0
                BEGIN                  
                    SELECT  @MesesGracia = MesesGracia ,
                            @Plazo = pp.Plazo ,
                            @TasaInteresNormal = pp.TasaInteresNormal ,
                            @DescripcionPromocion = pro.Descripcion ,
                            @IdT_crdpPromocion = pro.IdT_crdpPromocion
                    FROM    dbo.t_crdpPromocion pro WITH ( NOLOCK )
                            INNER JOIN dbo.t_crddPromocionPlazo pp WITH ( NOLOCK ) ON ( pro.IdT_crdpPromocion = pp.IdF_crdpPromocion )
                    WHERE   IdT_crddPromocionPlazo = @IdPlanPromoArticulo                  
                    IF @@ROWCOUNT = 0
                        BEGIN
                            SELECT  @UserNumber = 75070 ,
                                    @MessageUser = 'Error al obtener los datos de la promocion. No existen en la tabla <t_crddPromocionPlazo>'                     
                       
                            SELECT  @NumResultado = @UserNumber                  
                            SELECT  @MsgResultado = @MessageUser;                  
     --Levanta el error                    
                            RAISERROR(@MessageUser,16,1) 
                            --THROW @UserNumber,@MessageUser,1
                        END
                    
                    IF EXISTS ( SELECT  1
                                FROM    dbo.t_crddPromocionAgrupacionCliente
                                        WITH ( NOLOCK )
                                WHERE   IdF_crdpPromocion = @IdT_crdpPromocion
                                        AND Estado = @ESTADO_ACTIVO )
								--Solo validar la promocion de cliente para compras y NO para Post-Venta.
                        AND @IdF_autcTipoAutorizacion = 1
                        BEGIN 
                            SELECT  @TRUE = 1
                            FROM    dbo.t_crddPromocionAgrupacionCliente PAC
                                    WITH ( NOLOCK )
                            WHERE   PAC.IdF_crdpPromocion = @IdT_crdpPromocion
                                    AND PAC.IdF_climPersona = @IdT_climPersona
                                    AND PAC.Estado = @ESTADO_ACTIVO
                                    AND CASE WHEN PAC.TieneLimiteCompras = @TRUE
                                             THEN CASE WHEN PAC.CantidadCompras < PAC.LimiteCompras
                                                       THEN @TRUE
                                                       ELSE @FALSE
                                                  END
                                             ELSE @TRUE
                                        END = @TRUE
                            IF @@ROWCOUNT = 0
                                BEGIN                        
                                    SELECT  @UserNumber = 75068 ,
                                            @MessageUser = 'Error al obtener los datos de la promocion. El cliente no existe en esta promocion o ya alcanzo su limite de compras <t_crddPromocionAgrupacionCliente>'                     
	                       
                                    SELECT  @NumResultado = @UserNumber                  
                                    SELECT  @MsgResultado = @MessageUser;                 
		 --Levanta el error                    
                                    RAISERROR(@MessageUser,16,1)
                      --THROW @UserNumber,@MessageUser,1                  
                                END  
                        END
						                
                        
                    IF @IdF_autcTipoAutorizacion = 1
                        BEGIN                
                            SELECT  @TasaInteresTraslado = ISNULL(PF.TasaInteresNormal,
                                                              0) ,
                                    @PlazoTraslado = PF.Plazo
                            FROM    dbo.t_crddPlanSegmento PS WITH ( NOLOCK )
                                    INNER JOIN dbo.t_crddPlanSegmento PSA WITH ( NOLOCK ) ON ( PSA.IdF_crdpPlanFinanciero = @IdPlanFinancieroBase
                                                              AND PS.Idf_crdpSegmentoTrasladoporMora = PSA.IdF_crdpSegmento
                                                              AND PSA.Estado = 1
                                                              )
                                    INNER JOIN dbo.t_crddPlanMoneda PF WITH ( NOLOCK ) ON ( PF.IdF_crdpPlanFinanciero = PSA.IdF_crdpPlanFinancieroAsoc
                                                              AND PF.IdF_crdmMoneda = @IdF_crdmMoneda
                                                              AND PF.Estado = 1
                                                              )
                            WHERE   PS.IdF_crdpSegmento = @IdT_crdpSegmento
                                    AND PS.IdF_crdpPlanFinanciero = @IdPlanFinancieroBase
                                    AND PS.Estado = 1
                                    AND PS.Idf_crdpSegmentoTrasladoporMora != PS.IdF_crdpSegmento                                                   
                            IF @@ROWCOUNT > 0
                                BEGIN                
                                    SELECT  @ContratoPromocional = 1                
                                END                                          
                        END                                     
                END                  
                     
                 
            SELECT  @UsaFechaVenta = UsaFechaVenta
            FROM    dbo.t_crdpModalidadFechaPago
            WHERE   IdT_crdpModalidadFechaPago = @IdF_crdpModalidadFechaPago              
            IF @UsaFechaVenta = 1
                BEGIN              
                    SELECT  @IdF_crdmCiclo = dbo.fnc_ObtenerCiclo(@FechaProceso,
                                                              @CicloAnteriorPosterior)              
                END               
                  
            SELECT  @UserNumber = 75024                    
            SELECT  @MessageUser = 'Error al obtener los datos la tabla t_crdmCiclo.'                  
                     
            SELECT  @FechaProximoCorte = FechaProximoCorte
            FROM    dbo.t_crdmCiclo WITH ( NOLOCK )
            WHERE   IdT_crdmCiclo = @IdF_crdmCiclo                  
                     
            IF @@ROWCOUNT = 0
                BEGIN                  
                    SELECT  @UserNumber = 75025 ,
                            @MessageUser = 'Error al obtener los datos del ciclo en la tabla <t_crdmCiclo>:No se encuentra definido el ciclo.';
    --Levanta el error                    
                    RAISERROR(@MessageUser,11,1)   
                    --THROW @UserNumber,@MessageUser,1                    
                      
                END                  
                                  
            SELECT  @UserNumber = 75026                  
            SELECT  @MessageUser = 'Error al obtener los dias pendientes.'                  
   ---Calcular días entre la fecha de la transaccion y la fecha de próximo corte                  
                     
                  
            SELECT  @DiasPendiente = DATEDIFF(dd, @FechaProceso,
                                              @FechaProximoCorte)                  
                                                            
                                                                
               
            SELECT  @UserNumber = 75027                  
            SELECT  @MessageUser = 'Error al calcular la fecha de primer pago <@FechaPrimerPago>'                    
            SELECT  @FechaPrimerPago = @FechaProximoCorte                 
              
                        
   /*                  
    Si la diferencia en días es menor al parámetro del plan financiero base,                   
    entonces se usa el SegmentoAuxiliar.                  
   */                                                   
            IF ( @DiasPendiente <= @MinimoDiasCuota )
                BEGIN                  
    -- Si los dias pendientes  al proximo ciclo es menor a los Minimos de dias para generar                  
    -- cuota la fecha de primer pago se corre un ciclo                  
                    SELECT  @FechaPrimerPago = DATEADD(MM, 1,
                                                       @FechaProximoCorte)                   
                              
                      
                END        
                                               
                  
                     
   -- Si el segmento es promocional se y si la promocion tiene meses de gracia                  
   -- se le agrega los meses de gracia a la fecha de pago                  
            IF ( @MesesGracia > 0 )
                BEGIN                  
                    SELECT  @UserNumber = 75028                  
                    SELECT  @MessageUser = 'Error al inicializar la fecha de primer pago <@FechaPrimerPago>'                    
                      
                    SELECT  @FechaPrimerPago = DATEADD(MM, @MesesGracia,
                                                       @FechaPrimerPago)                  
                     
                END                  
                 
            SELECT  @CuotaEnProxCiclo = 0               
            SELECT  @HabilitarCuotaCero = 1                   
                 
                          
            IF CONVERT(VARCHAR, @FechaPrimerPago, 112) = CONVERT(VARCHAR, @FechaProximoCorte, 112)
                BEGIN                    
              
                    SELECT  @CuotaEnProxCiclo = 1 ,
                            @HabilitarCuotaCero = 0                    
                END              
                 
            SELECT  @UserNumber = 75065                  
            SELECT  @MessageUser = 'Error al ejecutar el procedimiento <usp_crdObtenerCondicionesFinancieras>'                    
                       
            EXEC dbo.usp_crdObtenerCondicionesFinancieras @IdT_crddPromocionPlazo = @IdPlanPromoArticulo,
                @IdF_crdmMoneda = @IdF_crdmMoneda,
                @IdF_crdpPlanFinanciero = @IdF_crdpPlanFinancieroAsoc,
                @EsPromocional = @EsPromocional,
                @CondicionFinanciera = @CondicionFinanciera OUTPUT,
                @FactorPago = @FactorPago OUTPUT, @Plazo = @Plazo OUTPUT,
                @TasaInteresNormal = @TasaInteresNormal OUTPUT,
                @Usuario = @Usuario, @ForzarPlazo = 0,
                @ForzarTasaInteresNormal = 0, @HabilitarCuotaMinima = 1,
                @HabilitarCuotaCero = @HabilitarCuotaCero,
                @IdT_crddPlazosInformativos = 0 
				          
             
            SELECT  @PlazoInformativo = @Plazo    
            IF @IdF_crddPlazosInformativos > 0
                BEGIN            
                    SELECT  @UserNumber = 75066                  
                    SELECT  @MessageUser = 'Error al ejecutar el procedimiento <usp_crdObtenerCondicionesFinancieras>'                    
                       
                    EXEC dbo.usp_crdObtenerCondicionesFinancieras @IdT_crddPromocionPlazo = @IdPlanPromoArticulo,
                        @IdF_crdmMoneda = @IdF_crdmMoneda,
                        @IdF_crdpPlanFinanciero = @IdF_crdpPlanFinancieroAsoc,
                        @EsPromocional = @EsPromocional,
                        @CondicionFinanciera = @CondicionFinancieraInformativo OUTPUT,
                        @FactorPago = @FactorPagoInformativo OUTPUT,
                        @Plazo = @PlazoInformativo OUTPUT,
                        @TasaInteresNormal = 0, @Usuario = @Usuario,
                        @ForzarPlazo = 0, @ForzarTasaInteresNormal = 0,
                        @HabilitarCuotaMinima = 1,
                        @HabilitarCuotaCero = @HabilitarCuotaCero,
                        @IdT_crddPlazosInformativos = @IdF_crddPlazosInformativos
						         
                END            
            
            SELECT  @TasaInteresNormalVenta = @TasaInteresNormal                
                             
            SELECT  @UserNumber = 75029                  
            SELECT  @MessageUser = 'Error el CodigoEntidad <crdmAutorizacion>.'                   
                     
            EXEC dbo.usp_utlCodigoEntidad_Obtener 'crdmAutorizacion',
                @CodEntidadAut OUTPUT                   
                           
            SELECT  @UserNumber = 75030                  
            SELECT  @MessageUser = 'Error el CodigoEntidad <crddAutorizacionDetalle>.'                    
                        
            EXEC dbo.usp_utlCodigoEntidad_Obtener 'crddAutorizacionDetalle',
                @CodEntidadAutDet OUTPUT                  
                     
            SELECT  @UserNumber = 75031                  
            SELECT  @MessageUser = 'Error el CodigoEntidad <crdmMovimientos>.'          
                     
            EXEC dbo.usp_utlCodigoEntidad_Obtener 'crdmMovimientos',
                @CodEntidadMonv OUTPUT                   
                           
            SELECT  @UserNumber = 75032                  
            SELECT  @MessageUser = 'Error el CodigoEntidad <crdmMovimientosDia>.'                    
                        
            EXEC dbo.usp_utlCodigoEntidad_Obtener 'crdmMovimientosDia',
                @CodEntidadMonvDia OUTPUT                  
                        
            BEGIN TRANSACTION                   
                       
            SELECT  @UserNumber = 750330
            SELECT  @MessageUser = 'Error al obtener el convenio y la entidad del cliente procesado en la venta'  

			--MODIFICACIÓN 2.2
			--OBTIENE EL NOMBRE DEL CONVENIO DEL CLIENTE
            SELECT TOP ( 1 )
                    @IdT_clicConvenio = CP.IdF_clicConvenio ,
                    @DescripcionConvenio = CO.Descripcion ,
                    @DescripcionEntidad = EN.Descripcion
            FROM    dbo.t_climConvenioPersona CP WITH ( NOLOCK )
                    INNER JOIN dbo.t_clicConvenios CO WITH ( NOLOCK ) ON CP.IdF_clicConvenio = CO.IdT_clicConvenio
                    INNER JOIN dbo.t_clicEntidad EN WITH ( NOLOCK ) ON EN.IdT_clicEntidad = CP.IdF_clicEntidad
            WHERE   CP.IdF_climPersona = @IdT_climPersona


            SELECT  @UserNumber = 750331                 
            SELECT  @MessageUser = 'Error al validar si la venta es de una promoción ligada a un convenio ' 

			--MODIFICACIÓN 2.2
			--VALIDA SI LA PROMOCIÓN DE LA VENTA ESTA LIGADA A UN CONVENIO
            IF EXISTS ( SELECT  1
                        FROM    dbo.t_crddPromocionConvenio PC WITH ( NOLOCK )
                        WHERE   PC.IdF_crdpPromocion IN (
                                SELECT  pro.IdT_crdpPromocion
                                FROM    dbo.t_crdpPromocion pro WITH ( NOLOCK )
                                        INNER JOIN dbo.t_crddPromocionPlazo pp
                                        WITH ( NOLOCK ) ON ( pro.IdT_crdpPromocion = pp.IdF_crdpPromocion )
                                WHERE   IdT_crddPromocionPlazo = @IdPlanPromoArticulo ) )
                BEGIN
                    SELECT  @VentaConvenio = @TRUE
                END

              
            SELECT  @UserNumber = 75033                  
            SELECT  @MessageUser = 'Error al realiar la insercion de los datos en al tabla   <t_crdmAutorizacion> ' 
			    
            INSERT  INTO dbo.t_crdmAutorizacion
                    ( IdRefAutorizacion ,
                      IdEntidad ,
                      IdOrganizacion ,
                      UsuInclusion ,
                      FechaCreacion ,
                      EnviarDWH ,
                      Estado ,
                      Fecha ,
                      Terminal ,
                      Sucursal ,
                      Cajero ,
                      NumTransaccion ,
                      MontoTotal ,
                      MontoFinanciar ,
                      Prima ,
                      Plazo ,
                      Tasa ,
                      Cuota ,
                      SaldoActual ,
                      NumRefFactura ,
                      Descripcion ,
                      IdF_crdcTransaccion ,
                      IdF_climPersona ,
                      IdF_crdmCuenta ,
                      IdF_crdpSegmento ,
                      IdF_crddPlanPromoArticulo ,
                      IdF_autcRespuestaAutorizacion ,
                      IdF_crdmMoneda ,
                      MontoFomento ,
                      IdF_invcCanalVenta ,
                      MtoPrimaDev ,
                      DevolucionPrima ,
                      DevolucionFomento ,
                      SaldoFinal ,
                      MontoExtragarantia ,
                      MontoFomentoDev ,
                      IdF_crdmAutorizacionPadre ,
                      IdF_autcTipoAutorizacion ,
                      ComboSeguro ,
                      IdF_crddPlazosInformativos ,
                      DetalleArticulos ,
                      NumeroDocumento ,
                      IdF_clicConvenio,
                      AplicaSeparacionWO                                                    
                    )
                    SELECT  @IdRespuestaAutorizacion ,
                            @CodEntidadAut ,
                            @CodigoOrganizacion ,
                            @Usuario ,
                            GETDATE() ,
                            1 ,
                            1 ,
                            Fecha ,
                            Terminal ,
                            Sucursal ,
                            Cajero ,
                            NumTransaccion ,
                            MontoTotal ,
                            @MontoTotalFinanciar ,
                            @MontoPrima ,
                            Plazo ,
                            Tasa ,
                            @CuotaTotal ,
                            SaldoActual ,
                            @NumRefFactura ,
                            Descripcion ,
                            IdF_crdcTransaccion ,
                            IdF_climPersona ,
                            IdF_crdmCuenta ,
                            IdF_crdpSegmento ,
                            IdF_crddPlanPromoArticulo ,
                            IdF_autcRespuestaAutorizacion ,
                            IdF_crdmMoneda ,
                            MontoFomento ,
                            IdF_invcCanalVenta ,
                            0.00 ,
                            0 ,
                            0 ,
                            0.00 ,
                            MontoExtragarantia ,
                            0.00 ,
                            @IdF_crdmAutorizacionPadre ,
                            IdF_autcTipoAutorizacion ,
                            ComboSeguro ,
                            IdF_crddPlazosInformativos ,
                            Productos ,
                            @NumeroDocumento ,
							--MODIFICACIÓN 2.2
							--SE ASIGNA EL CONVENIO A LA VENTA EN CASO DE COMPRAR EN UNA PROMOCIÓN LIGADA A UN CONVENIO
                            IdF_clicConvenio = CASE WHEN @VentaConvenio = @TRUE
                                                    THEN @IdT_clicConvenio
                                                    ELSE NULL
                                               END,
                            AplicaSeparacionWO = CASE WHEN @AplicaWOConvenios=0 AND @VentaConvenio != @TRUE 
                                                      THEN 1
                                                      ELSE @AplicaWOConvenios
                                                 END 
                    FROM    dbo.t_auttAutorizacion WITH ( NOLOCK )
                    WHERE   IdT_auttAutorizacion = @IdT_auttAutorizacion                    
                  
				  --Modif #1

            SELECT  @IdT_crdmAutorizacion = SCOPE_IDENTITY()                  
               
            SELECT  @UserNumber = 75033                  
            SELECT  @MessageUser = 'Error al realizar la actualizacion de los datos en al tabla <t_crddCuentaCombo> '                    
                             
            UPDATE  t_crddCuentaCombo
            SET     IdF_crdmAutorizacion = @IdT_crdmAutorizacion
            FROM    t_crddCuentaCombo CSD WITH ( NOLOCK )
                    INNER JOIN dbo.t_crddComboSeguroDetalle CSDE WITH ( NOLOCK ) ON CSD.IdF_crddComboSeguro = CSDE.IdF_crddComboSeguro
                    INNER JOIN dbo.t_crdmSeguro SE WITH ( NOLOCK ) ON ( SE.IdT_crdmSeguro = CSDE.IdF_crdmSeguro )
                    INNER JOIN dbo.t_crdpTipoSeguro TP WITH ( NOLOCK ) ON ( TP.IdT_crdpTipoSeguro = SE.IdF_crdpTipoSeguro
                                                              AND TP.AplicaSeguroPorArticulo = 1
                                                              )
            WHERE   CSD.IdF_crdmCuenta = @IdT_crdmCuenta
                    AND CSD.IdF_auttAutorizacion = @IdT_auttAutorizacion
                    AND CSD.IdF_crdpEstadoCuentaCombo = 2                          
                                
            IF @IdF_autcTipoAutorizacion = 1
                BEGIN                  
                    SELECT  @FechaInicioDevengo = @FechaTransaccion                   
                                
                END                                    

            SELECT  @UserNumber = 75035                  
            SELECT  @MessageUser = 'Error al obtener el maximo y minimo valor tabla sp @tblArticulo.'                          
            SELECT  @CountMin = MIN(Id) ,
                    @CountMax = MAX(Id)
            FROM    @tblArticulo                   
                     
            WHILE ( @CountMin <= @CountMax )
                BEGIN                  
                     
                    SELECT  @MontoFinanciar = 0.00 ,
                            @Monto = 0.00 ,
                            @Prima = 0.00 ,
                            @Concepto = 0 ,
                            @MontoFomentoDet = 0                  
                        
                    SELECT  @IdAutorizacion = @IdRespuestaAutorizacion                  
                        
                    SELECT  @Monto = Monto ,
                            @MontoImpuesto = MontoImpuesto ,
                            @Prima = Prima ,
                            @Concepto = Concepto ,
                            @ComboPadre = ComboPadre ,
                            @ComboIdCreacion = ComboIdCreacion ,
                            @CodigoArticulo = CodigoArticulo ,
                            @DescripcionArt = Descripcion ,
                            @VigenciaProveedor = VigenciaProveedor ,
                            @VigenciaExtraGarantia = Plazo ,
                            @IdPKDetailRef = IdPKDetailRef ,
                            @IdPFDetailRef = IdPFDetailRef ,
                            @IdArticulo = IdArticulo ,
                            @MontoFomentoDet = MontoFomento ,
                            @Productos = Productos ,
                  @MontoTotal = Monto
                    FROM    @tblArticulo
                    WHERE   Id = @CountMin                  

                    SELECT  @MontoFinanciar = DMF.Principal ,
                            @MontoFinanciarImpuesto = DMF.ImpPrincipal
                    FROM    dbo.fnc_crdDistribucionMontoFinanciar(@Prima/*@Prima*/,
                                                              @Monto/*@Principal*/,
                                                              @MontoImpuesto/*@ImpPrincipal*/)
                            AS DMF    
         
                    SELECT  @MontoFactura = @MontoFactura + @Monto
                            + @MontoImpuesto ,
                            @MontoPrima = @MontoPrima + @Prima ,
                            @MontoTotalFinanciar = @MontoTotalFinanciar
                            + @MontoFinanciar + @MontoFinanciarImpuesto                  
                                              
                    SELECT  @DevengaFuturo = DevengaFuturo
                    FROM    dbo.t_crdcTipoProducto WITH ( NOLOCK )
                    WHERE   IdT_crdcTipoProducto = @Concepto                         
                      
                    IF @Concepto = @CONCEPTO_EXTRA_GARANTIA
                        BEGIN                  
                       
                            SELECT  @UserNumber = 75036                  
                            SELECT  @MessageUser = 'Error al obtener el id de transaccion de la extra garantia tabla t_crdpMovimientoTransaccion.'                   
                       
                            SELECT  @IdT_crdcTransaccion = motr.IdF_crdcTransaccion
                            FROM    dbo.t_crdpMovimientoTransaccion motr WITH ( NOLOCK )
                            WHERE   motr.Descripcion = @VENTA_AL_CREDITO_EXT        
                                        
                            IF @AplicacionExtGarantia = 3
                                BEGIN      
                                    SELECT  @UserNumber = 75037                  
                                    SELECT  @MessageUser = 'Error al obtener datos del plan financiero para la extra garantia en la tabla t_crddPlanSegmento.'                  
                       
                                    SELECT  @IdT_crdcTransaccion = motr.IdF_crdcTransaccion ,
                                            @IdT_crdpSegmentoExtGarantia = ps.IdF_crdpSegmento ,
                                            @TasaInteresNormalExt = pm.TasaInteresNormal ,
                                            @GeneraInfoDetallada = ta.GeneraInfoDetallada ,
                                            @NivelRevolventeExt = ps.NivelRevolvente ,
                                            @MontoCuotaMinima = pm.MontoCuotaMinima ,
                                            @TasaInteresMora = pm.TasaInteresMora
                                    FROM    dbo.t_crdpMovimientoTransaccion motr
                                            WITH ( NOLOCK )
                                            INNER JOIN dbo.t_crdcTransaccion ta
                                            WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                                            INNER JOIN dbo.t_crddPlanSegmento ps
                                            WITH ( NOLOCK ) ON ( motr.IdF_crdpSegmento = ps.IdF_crdpSegmento )
                                            INNER JOIN dbo.t_crddPlanMoneda pm
                                            WITH ( NOLOCK ) ON ( ps.IdF_crdpPlanFinancieroAsoc = pm.IdF_crdpPlanFinanciero )
                                    WHERE   motr.Descripcion = @VENTA_AL_CREDITO_EXT
                                            AND ps.IdF_crdpPlanFinanciero = @IdPlanFianciero              
                                   -- AND motr.IdF_crdcEsquemaContable = @IdF_crdcEsquemaContable              
                        
                                    IF @@ROWCOUNT = 0
                                        BEGIN                   
                                            SELECT  @UserNumber = 75038 ,
                                                    @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <t_crdpMovimientoTransaccion>:No existe el Codigo de transaccion parametrizado para la extra garantia.';
       --Levanta el error                    
                                            RAISERROR(@MessageUser,16,1) 
                                            --THROW @UserNumber,@MessageUser,1                         
                                        END                    
                                END      
             
                            IF @AplicacionExtGarantia = 1
                                BEGIN      
                                    SELECT  @UserNumber = 75037                  
                                    SELECT  @MessageUser = 'Error al obtener datos del plan financiero para la extra garantia en la tabla t_crddPlanSegmento.'                  
                       
                                    SELECT  @IdT_crdcTransaccion = motr.IdF_crdcTransaccion ,
                                            @IdT_crdpSegmentoExtGarantia = ps.IdF_crdpSegmento ,    
                                       --     @TasaInteresNormalExt = pm.TasaInteresNormal ,    
                                            @GeneraInfoDetallada = ta.GeneraInfoDetallada ,
                                            @NivelRevolventeExt = ps.NivelRevolvente ,
                                            @MontoCuotaMinima = pm.MontoCuotaMinima ,
                                            @TasaInteresMora = pm.TasaInteresMora
                                    FROM    dbo.t_crdpMovimientoTransaccion motr
                                            WITH ( NOLOCK )
                                            INNER JOIN dbo.t_crdcTransaccion ta
                                            WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                                            INNER JOIN dbo.t_crddPlanSegmento ps
                                            WITH ( NOLOCK ) ON ( motr.IdF_crdpSegmento = ps.IdF_crdpSegmento )
                                            INNER JOIN dbo.t_crddPlanMoneda pm
                                            WITH ( NOLOCK ) ON ( ps.IdF_crdpPlanFinancieroAsoc = pm.IdF_crdpPlanFinanciero )
                                            INNER JOIN dbo.t_crdpSegmento se
                                            WITH ( NOLOCK ) ON ( se.IdT_crdpSegmento = ps.IdF_crdpSegmento
                                                              AND se.IdF_crdpMetodoDevengamiento = @IdF_crdpMetodoDevengamiento
                                                              )
                                    WHERE   motr.Descripcion = @VENTA_AL_CREDITO_EXT
                                            AND ps.IdF_crdpPlanFinanciero = @IdPlanFianciero              
                                   -- AND motr.IdF_crdcEsquemaContable = @IdF_crdcEsquemaContable                   
                        
                                    IF @@ROWCOUNT = 0
                                        BEGIN                   
                                            SELECT  @UserNumber = 75038 ,
                                                    @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <t_crdpMovimientoTransaccion>:No existe el Codigo de transaccion parametrizado para la extra garantia.';
       --Levanta el error                    
                                            RAISERROR(@MessageUser,16,1)   
                                            --THROW @UserNumber,@MessageUser,1                         
          END              
                                END      
                                      
                            IF @AplicacionExtGarantia = 3
                                BEGIN                  
                                    SELECT  @IdT_crdpSegmento = @IdT_crdpSegmentoExtGarantia ,
                                            @TasaInteresNormal = @TasaInteresNormalExt ,
                                            @NivelRevolvente = @NivelRevolventeExt                  
                                END                   
             
                            IF @AplicacionExtGarantia = 1
                                BEGIN                  
                                    SELECT  @IdT_crdpSegmento = @IdT_crdpSegmentoExtGarantia ,
                                            @NivelRevolvente = @NivelRevolventeExt                  
                                END           
                                      
                            SELECT  @IdAutorizacion = dbo.fnc_ObtenerSecuencia(@IdT_crdcTransaccion,
                                                              @Sucursal) ,
                                    @IdAutorizacionAux = @IdRespuestaAutorizacion         
                                                
                            IF @AplicacionExtGarantia = 3
                                AND @IdF_autcTipoAutorizacion = 1
                                BEGIN                        
                                    SELECT  @CondicionFinancieraAux = @CondicionFinanciera                                          
                                    SELECT  @CondicionFinanciera = ''              
                                          
                                    EXEC dbo.usp_crdObtenerCondicionesFinancieras @IdT_crddPromocionPlazo = @IdPlanPromoArticulo,
                                        @IdF_crdmMoneda = @IdF_crdmMoneda,
                                        @IdF_crdpPlanFinanciero = @IdF_crdpPlanFinancieroAsoc,
                                        @EsPromocional = @EsPromocional,
                                        @CondicionFinanciera = @CondicionFinanciera OUTPUT,
                                        @FactorPago = @FactorPago OUTPUT,
                                        @Plazo = @Plazo OUTPUT,
                                        @TasaInteresNormal = @TasaInteresNormal OUTPUT,
                                        @Usuario = @Usuario, @ForzarPlazo = 0,
                                        @ForzarTasaInteresNormal = 1,
                                        @HabilitarCuotaMinima = 0,
                                        @HabilitarCuotaCero = @HabilitarCuotaCero	
									              
                          
                                    IF @IdF_crddPlazosInformativos > 0
                                        BEGIN            
                                            SELECT  @UserNumber = 75066                  
                                            SELECT  @MessageUser = 'Error al ejecutar el procedimiento <usp_crdObtenerCondicionesFinancieras>'                    
           
              
                                            EXEC dbo.usp_crdObtenerCondicionesFinancieras @IdT_crddPromocionPlazo = @IdPlanPromoArticulo,
                                                @IdF_crdmMoneda = @IdF_crdmMoneda,
                                                @IdF_crdpPlanFinanciero = @IdF_crdpPlanFinancieroAsoc,
                                                @EsPromocional = @EsPromocional,
                                                @CondicionFinanciera = @CondicionFinancieraInformativo OUTPUT,
                                                @FactorPago = @FactorPagoInformativo OUTPUT,
                                                @Plazo = @PlazoInformativo OUTPUT,
                                                @TasaInteresNormal = @TasaInteresNormal OUTPUT,
                                                @Usuario = @Usuario,
                                                @ForzarPlazo = 0,
                                                @ForzarTasaInteresNormal = 1,
                                                @HabilitarCuotaMinima = 0,
                                                @HabilitarCuotaCero = @HabilitarCuotaCero,
                                                @IdT_crddPlazosInformativos = @IdF_crddPlazosInformativos
												          
                                        END            
                                END --IF @AplicacionExtGarantia = 3 AND @IdF_autcTipoAutorizacion = 1
							
                            IF @AplicacionExtGarantia = 3
                                AND @IdF_autcTipoAutorizacion = 2
                                BEGIN  
                                    SELECT  @Plazo = AUT.Plazo ,
                                            @CondicionFinanciera = SD.CondicionFinanciera ,
                                            @FactorPago = SD.FactorPagoMensual ,
                                            @NumCuotaInicial = PPSD.NumeroCuotaPlanPagos
                                    FROM    dbo.t_crdmAutorizacion AUT WITH ( NOLOCK )
                                            INNER JOIN dbo.t_crddAutorizacionDetalle AUTD
                                            WITH ( NOLOCK ) ON ( AUT.IdT_crdmAutorizacion = AUTD.IdF_crdmAutorizacion )
                                            INNER JOIN @tblArticulo FEG ON ( FEG.IdPFDetailRef = AUTD.IdPKDetailRef )
                                            INNER JOIN dbo.t_crddSaldoDetallado SD
                                            WITH ( NOLOCK ) ON ( SD.IdT_crddSaldoDetallado = AUTD.IdF_crddSaldoDetalladoOrigen )
                                            INNER JOIN dbo.t_crddPlanPagosSaldoDetallado PPSD
                                            WITH ( NOLOCK ) ON ( PPSD.IdF_crddSaldoDetallado = SD.IdT_crddSaldoDetallado
                                                              AND PPSD.Estado = 1
                                                              )
                                    WHERE   IdT_crdmAutorizacion = @IdF_crdmAutorizacionPadre    
				                      
                                    DECLARE @CodicionFinancieraAux VARCHAR(MAX) = ''
                                    IF @FechaProximoCorte != @FechaPrimerPago
                                        BEGIN
                                            SELECT  @CodicionFinancieraAux = @CodicionFinancieraAux
													--+ Value01 + '&' + +Value02 + '&'
													--SE MODIFICA PARA PONER LA TASA DE INTERES DE LA GARANTIA Y NO LA DEL ARTICULO
                                                    + Value01 + '&'
                                                    + CONVERT(VARCHAR, CONVERT(DECIMAL(16,
                                                              2), @TasaInteresNormalExt))
                                                    + '&'
                                                    + CONVERT(VARCHAR, CASE
                                                              WHEN CONVERT(INT, Value01) = @NumCuotaInicial
                                                              THEN CONVERT(DECIMAL(18,
                                                              4), 0.0000)
                                                              ELSE CONVERT(DECIMAL(18,
                                                              4), Value03)
                                                              END) + '&'
                                                    + Value04 + '|'
                                            FROM    dbo.uft_utlListToTableColumns(@CondicionFinanciera,
                                                              '&', '|')
                                        END
                ELSE
                                        BEGIN
                                            SELECT  @CodicionFinancieraAux = @CodicionFinancieraAux
                                                    + Value01 + '&'
                                                    + CONVERT(VARCHAR, @TasaInteresNormalExt)
                                                    + '&'
                                                    + CONVERT(VARCHAR, CONVERT(DECIMAL(18,
                                                              4), Value03))
                                                    + '&' + Value04 + '|'
                                            FROM    dbo.uft_utlListToTableColumns(@CondicionFinanciera,
                                                              '&', '|')
                                        END --(ELSE) IF @FechaProximoCorte != @FechaPrimerPago          
									
                                    SELECT  @CondicionFinanciera = @CodicionFinancieraAux
                                END --IF @AplicacionExtGarantia = 3 AND @IdF_autcTipoAutorizacion = 2
                        END                  
                    ELSE
                        BEGIN                                        
                            SELECT  @UserNumber = 75041                  
                            SELECT  @MessageUser = 'Error al obtener el id de transaccion venta al credito tabla t_crdpMovimientoTransaccion.'                   
                       
                            SELECT  @IdT_crdcTransaccion = motr.IdF_crdcTransaccion ,
                                    @GeneraInfoDetallada = ta.GeneraInfoDetallada
                            FROM    dbo.t_crdpMovimientoTransaccion motr WITH ( NOLOCK )
                                    INNER JOIN dbo.t_crdcTransaccion ta WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                                    INNER JOIN dbo.t_crdpSegmento SEG ON ( motr.IdF_crdpSegmento = SEG.IdF_crdcTipoSegmento )
                            WHERE   motr.Descripcion = CASE WHEN @IdT_crdpSegmento = @SEGMENTO_AUTOEXPEDIBLE
                                                            THEN @VENTA_AL_CREDITO_SEG_AUTEXP
                                                            ELSE @VENTA_AL_CREDITO
                                                       END
                                    AND SEG.IdT_crdpSegmento = @IdT_crdpSegmento              
                                          --  AND motr.IdF_crdcEsquemaContable = @IdF_crdcEsquemaContable                                
                            IF @@ROWCOUNT = 0
                                BEGIN                   
                                    SELECT  @UserNumber = 75042 ,
                                            @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <t_crdpMovimientoTransaccion>:No existe el Codigo de transaccion parametrizado para venta al credito.';
                         
       --Levanta el error                    
                                    RAISERROR(@MessageUser,16,1)   
                                            --THROW @UserNumber,@MessageUser,1                       
                                END                    
                      
                            SELECT  @IdAutorizacion = @IdRespuestaAutorizacion ,
                                    @IdAutorizacionAux = 0                                            
                        END                   
					
                    SELECT  @ConceptoAux = @Concepto
													                       
                    SELECT  @UserNumber = 75043                  
                    SELECT  @MessageUser = 'Error al ejecutar el sp usp_crdTransaccionSuma_Procesar.'                   
         
                    EXEC dbo.usp_crdTransaccionSuma_Procesar @Usuario = @Usuario,
           @FechaTransaccion = @FechaProceso,
                        @FechaProceso = @FechaProceso,
                        @IdT_crdcTransaccion = @IdT_crdcTransaccion,
                        @MtoTra = @MontoFinanciar,
                        @MtoTraImp = @MontoFinanciarImpuesto,
                        @IdT_crdmCuenta = @IdT_crdmCuenta,
                        @IdF_crdmMoneda = @IdF_crdmMoneda,
                        @IdT_crdpSegmento = @IdT_crdpSegmento, @Plazo = @Plazo,
                        @TasaAnual = @TasaInteresNormal,
                        @MesesGracia = @MesesGracia,
                        @NumeroReferencia = @NumRefFactura,
                        @IdF_crdcOrigen = @IdF_crdcOrigen,
                        @IdAutorizacion = @IdAutorizacion,
                        @IdF_crdcSubCuenta = @IdF_crdcSubCuenta,
                        @IdT_climTienda = @Sucursal,
                        @IdMovimientosOrigen = @IdAutorizacionAux,
                        @UltimoCorrelativo = @UltimoCorrelativo,
                        @IdPlanFinancieroBase = @IdPlanFinancieroBase,
                        @IdF_crdmCiclo = @IdF_crdmCiclo,
                        @IdF_crdcCartera = @IdF_crdcCartera,
                        @FechaCreacionCuenta = @FechaCreacionCuenta,
                        @Cuenta = @Cuenta,
                        @CodigoOrganizacion = @CodigoOrganizacion,
                        @CodEntidadMonv = @CodEntidadMonv,
                        @CodEntidadMonvDia = @CodEntidadMonvDia,
                        @DescripcionArticulo = @DescripcionArt,
                        @VigenciaProveedor = @VigenciaProveedor,
                        @VigenciaExtraGarantia = @VigenciaExtraGarantia,
                        @IdEsquemaContable = @IdF_crdcEsquemaContable,
                        @TasaInteresMora = @TasaInteresMora,
                        @IdF_crdmAutorizacion = @IdT_crdmAutorizacion,
                        @Detalle = @NumTransaccion,
                        @NivelRevolvente = @NivelRevolvente,
                        @IdF_crdcTipoProducto = @ConceptoAux,
                        @Especificacion = @Especificacion,
                        @MontoCuotaMinima = @MontoCuotaMinima,
                        @IdT_crddSaldoSegmento = @IdT_crddSaldoSegmento OUTPUT,
                        @IdT_crddSaldoDetallado = @IdT_crddSaldoDetallado OUTPUT,
                        @IdSecuencia = @IdSecuencia OUTPUT,
                        @CuotaEnProxCiclo = @CuotaEnProxCiclo,
                        @IdT_crddSaldoNivel = @IdT_crddSaldoNivel OUTPUT,
                        @FechaPrimerPago = @FechaPrimerPago,
                        @AfectaDisponible = @AfectaDisponible OUTPUT,
                        @FechaProximoCorte = @FechaProximoCorte,
                        @CondicionFinanciera = @CondicionFinanciera,
                        @FactorPago = @FactorPago, @AlcancePago = @AlcancePago,
                        @PagaIndividual = @PagaIndividual,
                        @PrincipalCuota = @PrincipalCuota OUTPUT,
                        @ImpPrincipalCuota = @ImpPrincipalCuota OUTPUT,
                        @IdF_crddPlazosInformativos = @IdF_crddPlazosInformativos,
                        @CondicionFinancieraInformativo = @CondicionFinancieraInformativo,
                        @FactorPagoInformativo = @FactorPagoInformativo,
                        @CodigosArticulos = @Productos,
                        @MontoTotalArt = @MontoTotal,
                        @PlazoInformativo = @PlazoInformativo,
                        @NumCuotaInicial = @NumCuotaInicial
            
                    IF @GeneraInfoDetallada = 1
                        BEGIN
                       
     -- Inicio de generacion de la transaccion Memo                    
     -- Generacion de transaccion Memo por el monto de la compra                  
                       
                            IF @Concepto = @CONCEPTO_EXTRA_GARANTIA
                                BEGIN
                                    SELECT  @IdT_crdcTransaccion = ta.IdT_crdcTransaccion ,
                                            @IdNivelVisibilidad = ta.IdF_crdcNivelVisibilidad ,
                                            @Descripcion = ta.Descripcion ,
                                            @FactorOperacion = ta.FactorOperacion
                                    FROM    dbo.t_crdpMovimientoTransaccion motr
                                            WITH ( NOLOCK )
                                            INNER JOIN dbo.t_crdcTransaccion ta
                                            WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                                    WHERE   motr.Descripcion = @VENTA_MONTO_OPERACION_EXT                  
                                END                  
                            ELSE
                                BEGIN
                                    SELECT  @IdT_crdcTransaccion = ta.IdT_crdcTransaccion ,
                                            @IdNivelVisibilidad = ta.IdF_crdcNivelVisibilidad ,
                                            @Descripcion = ta.Descripcion ,
                                            @FactorOperacion = ta.FactorOperacion
                                    FROM    dbo.t_crdpMovimientoTransaccion motr
                                            WITH ( NOLOCK )
                                            INNER JOIN dbo.t_crdcTransaccion ta
                                            WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                                    WHERE   motr.Descripcion = @VENTA_MONTO_OPERACION                          
                                END                  
                           
                      
                             
                            SELECT  @IdAutorizacionAux = @IdAutorizacion ,
                                    @IdAutorizacion = dbo.fnc_ObtenerSecuencia(@IdT_crdcTransaccion,
                                                              @Sucursal)                  
                            
                            SELECT  @UserNumber = 75045                   
                            SELECT  @MessageUser = 'Error al ejecutar el sp  <usp_crdMovimientos_Guardar> '                    
                            EXEC dbo.usp_crdMovimientos_Guardar @Correlativo = 0,
                                @Secuencia = @IdSecuencia,
                                @Descripcion = @Descripcion,
                                @FechaMovimiento = @FechaTransaccion,
                                @FechaAplicacion = @FechaProceso,
                                @FechaContable = @FechaProceso,
                                @Plastico = @Cuenta,
                                @NumeroReferencia = @NumRefFactura,
                                @Monto = @Monto, @MontoImp = @MontoImpuesto,
                                @Nivel = 0, @Usuario = @Usuario,
                                @IdCuenta = @IdT_crdmCuenta,
                                @IdMoneda = @IdF_crdmMoneda,
                                @IdSubCuenta = @IdF_crdcSubCuenta,
                                @IdSegmento = @IdT_crdpSegmento,
                                @IdSaldoSegmento = @IdT_crddSaldoSegmento,
                                @IdOrigen = @IdF_crdcOrigen,
                                @IdTransaccion = @IdT_crdcTransaccion,
                                @IdCartera = @IdF_crdcCartera,
                                @IdAutorizacion = @IdAutorizacion,
                                @IdMovimientosOrigen = @IdAutorizacionAux,
                                @IdNivelVisibilidad = @IdNivelVisibilidad,
                                @Observacion = @DescripcionArt,
                                @CodEntidadMonv = @CodEntidadMonv,
                             @CodEntidadMonvDia = @CodEntidadMonvDia,
                                @CodigoOrganizacion = @CodigoOrganizacion,
                                @FactorOperacion = @FactorOperacion,
                                @IdSaldoDetallado = @IdT_crddSaldoDetallado,
                                @IdEsquemaContable = @IdF_crdcEsquemaContable,
                                @IdPlanFinanciero = @IdPlanFinancieroBase,
                                @Detalle = '', @IdF_crdcTipoProducto = 0,
                                @Especificacion = @Especificacion                  
     -- Fin de la generacion la transaccion Memo         
         
                            IF @Prima > 0.00
                                BEGIN                  
      -- Generacion de transaccion Memo por el monto de la prima                  
                                    SELECT  @IdT_crdcTransaccion = ta.IdT_crdcTransaccion ,
                                            @IdNivelVisibilidad = ta.IdF_crdcNivelVisibilidad ,
                                            @Descripcion = ta.Descripcion ,
                                            @FactorOperacion = ta.FactorOperacion
                                    FROM    dbo.t_crdpMovimientoTransaccion motr
                                            WITH ( NOLOCK )
                                            INNER JOIN dbo.t_crdcTransaccion ta
                                            WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                                    WHERE   motr.Descripcion = @VENTA_MONTO_PRIMA                  
                        
                                    SELECT  @IdAutorizacionAux = @IdAutorizacion ,
                                            @IdAutorizacion = dbo.fnc_ObtenerSecuencia(@IdT_crdcTransaccion,
                                                              @Sucursal)                  
                        
                                    SELECT  @UserNumber = 75044                  
                                    SELECT  @MessageUser = 'Error al ejecutar el sp  <usp_crdMovimientos_Guardar> '                    
                                    EXEC dbo.usp_crdMovimientos_Guardar @Correlativo = 0,
                                        @Secuencia = @IdSecuencia,
                                        @Descripcion = @Descripcion,
                                        @FechaMovimiento = @FechaTransaccion,
                                        @FechaAplicacion = @FechaProceso,
                                        @FechaContable = @FechaProceso,
                                        @Plastico = @Cuenta,
                                        @NumeroReferencia = @NumRefFactura,
                                        @Monto = @Prima, @MontoImp = 0,
                                        @Nivel = 0, @Usuario = @Usuario,
                                        @IdCuenta = @IdT_crdmCuenta,
                                        @IdMoneda = @IdF_crdmMoneda,
                                        @IdSubCuenta = @IdF_crdcSubCuenta,
                                        @IdSegmento = @IdT_crdpSegmento,
                                        @IdSaldoSegmento = @IdT_crddSaldoSegmento,
                                        @IdOrigen = @IdF_crdcOrigen,
                                        @IdTransaccion = @IdT_crdcTransaccion,
                                        @IdCartera = @IdF_crdcCartera,
                                        @IdAutorizacion = @IdAutorizacion,
                                        @IdMovimientosOrigen = @IdAutorizacionAux,
                                        @IdNivelVisibilidad = @IdNivelVisibilidad,
                                        @Observacion = '',
                                        @CodEntidadMonv = @CodEntidadMonv,
                                        @CodEntidadMonvDia = @CodEntidadMonvDia,
                                        @CodigoOrganizacion = @CodigoOrganizacion,
                                        @FactorOperacion = @FactorOperacion,
                                        @IdSaldoDetallado = @IdT_crddSaldoDetallado,
                                        @IdEsquemaContable = @IdF_crdcEsquemaContable,
                                        @IdPlanFinanciero = @IdPlanFinancieroBase,
                                        @Detalle = '',
                                        @IdF_crdcTipoProducto = 0,
                                        @Especificacion = @Especificacion                  
       -- Fin de la generacion  de la transaccion Memo                   
                                END                           
                        END                           
    --- Se realiza el guardado de los datos.                  
                    IF @Concepto = @CONCEPTO_EXTRA_GARANTIA
                        BEGIN                  
                            SELECT  @UserNumber = 75046                   
                            SELECT  @MessageUser = 'Error al ingresar los datos ala tabla  <t_crddAutorizacionDetalle> '                    
                      
                            INSERT  INTO dbo.t_crddAutorizacionDetalle
                                    ( IdEntidad ,
                                      IdOrganizacion ,
                                      UsuInclusion ,
                                      FechaCreacion ,
                                      EnviarDWH ,
                                      Estado ,
                                      ComboPadre ,
                                      ComboIdCreacion ,
                                      Plazo ,
                                      Monto ,
                                      MontoImpuesto ,
                                      IdF_crdcTipoProducto ,
                                      CodigoArticulo ,
                                      IdF_crdmAutorizacion ,
                                      IdF_crdpSegmentoOrigen ,
                                      IdF_crdpSegmentoTraslado ,
                                      IdF_crddSaldoSegmentoOrigen ,
                                      IdF_crddSaldoSegmentoTraslado ,
                                      SecuenciaOrigen ,
                                      SecuenciaTraslado ,
                                      Prima ,
                                      IdF_crddSaldoDetalladoOrigen ,
                                      IdF_crddSaldoDetalladoTraslado ,
                                      Descripcion ,
                                      VigenciaProveedor ,
                                      Devolucion ,
                                      IdPKDetailRef ,
                                      IdPFDetailRef ,
                                      IdF_invcArticulo ,
                                      MontoFomento                  
                                    )
                            VALUES  ( @CodEntidadAutDet ,
                                      @CodigoOrganizacion ,
                                      @Usuario ,
                                      GETDATE() ,
                                      1 ,
                                      1 ,
                                      @ComboPadre ,
                                      @ComboIdCreacion ,
                                      @VigenciaExtraGarantia ,
                                      @Monto ,
                                      @MontoImpuesto ,
                                      @Concepto ,
                                      @CodigoArticulo ,
                                      @IdT_crdmAutorizacion ,
                                      @IdT_crdpSegmento ,
                                      @IdT_crdpSegmento ,
                     @IdT_crddSaldoSegmento ,
                                      @IdT_crddSaldoSegmento ,
                                      @IdSecuencia ,
                                      @IdSecuencia ,
                                      @Prima ,
                                      @IdT_crddSaldoDetallado ,
                                      @IdT_crddSaldoDetallado ,
                                      @DescripcionArt ,
                                      @VigenciaProveedor ,
                                      0 ,
                                      @IdPKDetailRef ,
                                      @IdPFDetailRef ,
                                      @IdArticulo ,
                                      @MontoFomentoDet                  
                                    )                  
                      
                        END                  
                    ELSE
                        BEGIN                  
                            SELECT  @UserNumber = 75047                  
                            SELECT  @MessageUser = 'Error al ingresar los datos ala tabla  <t_crddAutorizacionDetalle> '                    
                      
                            INSERT  INTO dbo.t_crddAutorizacionDetalle
                                    ( IdEntidad ,
                                      IdOrganizacion ,
                                      UsuInclusion ,
                                      FechaCreacion ,
                                      EnviarDWH ,
                                      Estado ,
                                      ComboPadre ,
                                      ComboIdCreacion ,
                                      Plazo ,
                                      Monto ,
                                      MontoImpuesto ,
                                      IdF_crdcTipoProducto ,
                                      CodigoArticulo ,
                                      IdF_crdmAutorizacion ,
                                      IdF_crdpSegmentoOrigen ,
                                      IdF_crdpSegmentoTraslado ,
                                      IdF_crddSaldoSegmentoOrigen ,
                                      IdF_crddSaldoSegmentoTraslado ,
                                      SecuenciaOrigen ,
                                      SecuenciaTraslado ,
                                      Prima ,
                                      IdF_crddSaldoDetalladoOrigen ,
                                      IdF_crddSaldoDetalladoTraslado ,
                                      Descripcion ,
                                      VigenciaProveedor ,
                                      Devolucion ,
                                      IdPKDetailRef ,
                                      IdPFDetailRef ,
                                      IdF_invcArticulo ,
                                      MontoFomento           
                                    )
                                    SELECT  @CodEntidadAutDet ,
                                            @CodigoOrganizacion ,
                                            @Usuario ,
                                            GETDATE() ,
                                            1 ,
                                            1 ,
                                            ComboPadre ,
                                            ComboIdCreacion ,
                                            Plazo ,
                                            Monto - MontoImpuesto ,
                                            MontoImpuesto ,
                                            Concepto ,
                                            CodigoArticulo ,
                                            @IdT_crdmAutorizacion ,
                                            @IdT_crdpSegmento ,
                 @IdT_crdpSegmento ,
                                            @IdT_crddSaldoSegmento ,
                                            @IdT_crddSaldoSegmento ,
                                            @IdSecuencia ,
                                            @IdSecuencia ,
                                            Prima ,
                                            @IdT_crddSaldoDetallado ,
                                            @IdT_crddSaldoDetallado ,
                                            Descripcion ,
                                            MesesGarantiaProveedor ,
                                            0 ,
                                            IdPKDetailRef ,
                                            IdPFDetailRef ,
                                            IdF_invcArticulo ,
                                            MontoFomento
                                    FROM    dbo.t_autdAutorizacionDetalle WITH ( NOLOCK )
                                    WHERE   IdF_auttAutorizacion = @IdT_auttAutorizacion
                                            AND Concepto = @CONCEPTO_ARTICULO                   
                       
                        END                   
                      
                     
    -- Si es una extragarantia y afecto la coutames se le debe de descargar una cuota                  
                    IF @DevengaFuturo = 1
                        AND @Concepto = @CONCEPTO_EXTRA_GARANTIA
                        BEGIN                  
                       
                            SELECT  @UserNumber = 75048                   
                            SELECT  @MessageUser = 'Error al ejecutar al sp <usp_crddDevengoExtraGarantia_Guardar> '                    
                      
                            EXEC dbo.usp_crdDevengoExtraGarantia_Guardar @FechaTransaccion = @FechaInicioDevengo,
                                @Monto = @Monto, @IdCuenta = @IdT_crdmCuenta,
                                @IdMoneda = @IdF_crdmMoneda,
                                @IdSubCuenta = @IdF_crdcSubCuenta,
                                @IdSegmento = @IdT_crdpSegmento,
                                @IdSaldoDetallado = @IdT_crddSaldoDetallado,
                                @VigenciaProveedor = @VigenciaProveedor,
                                @VigenciaExtraGarantia = @VigenciaExtraGarantia,
                                @Usuario = @Usuario                   
                        END                  
                   
                    IF @AfectaDisponible = 1
                        AND @Concepto = @CONCEPTO_EXTRA_GARANTIA
                        BEGIN                     
                            IF @CuotaEnProxCiclo = 1
                                BEGIN                  
                                    SELECT  @UserNumber = 75049                  
                                    SELECT  @MessageUser = 'Error al ejecutar el sp  <usp_crdCoutaRecurrente_Descargar> '                  
                                    --EXEC dbo.usp_crdCuotaRecurrente_Descargar @IdCuenta = @IdT_crdmCuenta,              
                                    --    @IdMoneda = @IdF_crdmMoneda,              
                                    --    @IdCartera = @IdF_crdcCartera,              
                                    --    @IdSaldoDetallado = @IdT_crddSaldoDetallado,              
                                    --    @IdOrigen = @IdF_crdcOrigen,              
                                    --    @IdTienda = @Sucursal,              
                                    --    @NumeroReferencia = @NumRefFactura,              
                                    --    @IdMovimientosOrigen = @IdRespuestaAutorizacion,              
                                    --    @Usuario = @Usuario,              
                                    --    @CodigoOrganizacion = @CodigoOrganizacion,              
                                    --    @CodEntidadMonv = @CodEntidadMonv,              
                                    --    @CodEntidadMonvDia = @CodEntidadMonvDia,              
                                    --    @Plastico = @Cuenta,              
                                    --    @FechaProceso = @FechaProceso,              
                                    --    @FechaTransaccion = @FechaTransaccion,              
                                    --    @IdSaldoNivel = @IdT_crddSaldoNivel,              
          --    @IdEsquemaContable = @IdF_crdcEsquemaContable,              
                                    --    @IdPlanFinanciero = @IdPlanFinancieroBase,              
                                    --    @UltimoCorrelativo = @UltimoCorrelativo OUTPUT,              
                                    --    @ModoEjecucion = 0                  
                                    EXEC dbo.usp_crdCuotaRecurrente_Habilitar @IdT_crdmCuenta = @IdT_crdmCuenta,
                                        @IdF_crdmMoneda = @IdF_crdmMoneda,
                                        @IdT_crddSaldoDetallado = @IdT_crddSaldoDetallado,
                                        @IdF_crdcOrigen = @IdF_crdcOrigen,
                                        @IdTienda = @Sucursal,
                                        @NumeroReferencia = @NumRefFactura,
                                        @IdMovimientosOrigen = @IdRespuestaAutorizacion,
                                        @Usuario = @Usuario,
                                        @FechaProceso = @FechaProceso,
                                        @FechaTransaccion = @FechaTransaccion,
                                        @UltimoCorrelativo = @UltimoCorrelativo OUTPUT,
                                        @Principal = @PrincipalCuota,
                                        @ImpPrincipal = @ImpPrincipalCuota,
                                        @Factor = 1                                                    
                                END                  
                        END                  
                       
                    SELECT  @UltimoCorrelativo = @UltimoCorrelativo + 1                        
                    SELECT  @CountMin = @CountMin + 1                  
                END                    
                     
   ---Generacion de transaccion memo monto fomento                  
   -- Se obiene  el Codigo de la transaccion para intereses normales                  
            IF @MontoFomento > 0.00
                BEGIN                  
                    SELECT  @UserNumber = 75050                  
                    SELECT  @MessageUser = 'Error al obtener los datos de la transaccion tabla  <t_crdpMovimientoTransaccion> '                    
                      
                    SELECT  @IdT_crdcTransaccion = ta.IdT_crdcTransaccion ,
                            @FactorOperacion = ta.FactorOperacion ,
                            --@ConceptoApliTrans = ta.IdF_crdcConcepto ,
                            @IdNivelVisibilidad = ta.IdF_crdcNivelVisibilidad ,
                            @Descripcion = ta.Descripcion ,
                            @FactorOperacion = ta.FactorOperacion
                    FROM    dbo.t_crdpMovimientoTransaccion motr WITH ( NOLOCK )
                            INNER JOIN dbo.t_crdcTransaccion ta WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                    WHERE   motr.Descripcion = @VENTA_MONTO_FOMENTO                       
                    IF @@ROWCOUNT = 0
                        BEGIN                   
                            SELECT  @UserNumber = 75051 ,
                                    @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <t_crdpMovimientoTransaccion>:No existe el Codigo de transaccion Memo parametrizado para Monto Fomento.';                    
                        
      --Levanta el error                    
                            RAISERROR(@MessageUser,16,1)   
                            --THROW @UserNumber,@MessageUser,1                       
                        END                    
                      
                    SELECT  @IdAutorizacion = dbo.fnc_ObtenerSecuencia(@IdT_crdcTransaccion,
                                                              @Sucursal) ,
                            @IdAutorizacionAux = @IdRespuestaAutorizacion                  
                      
                    SELECT  @UserNumber = 75067
                    SELECT  @MessageUser = 'Error al obtener IdT_crddSaldoDetallado del Tipo Producto Articulo  <t_crddSaldoDetallado> '
                    
                    SELECT  @IdT_crddSaldoDetallado = IdT_crddSaldoDetallado
                    FROM    dbo.t_crddSaldoDetallado
                    WHERE   IdF_crdmAutorizacion = @IdT_crdmAutorizacion
                            AND IdF_crdcTipoProducto = @CONCEPTO_ARTICULO
					
                    SELECT  @UserNumber = 75052                  
                    SELECT  @MessageUser = 'Error al ejecutar el sp  <usp_crdMovimientos_Guardar> '                    
                          
                    EXEC dbo.usp_crdMovimientos_Guardar @Correlativo = 0,
                        @Secuencia = 0, @Descripcion = @Descripcion,
                        @FechaMovimiento = @FechaTransaccion,
                        @FechaAplicacion = @FechaProceso,
                        @FechaContable = @FechaProceso, @Plastico = @Cuenta,
                        @NumeroReferencia = @NumRefFactura,
                        @Monto = @MontoFomento, @MontoImp = 0, @Nivel = 0,
                        @Usuario = @Usuario, @IdCuenta = @IdT_crdmCuenta,
                        @IdMoneda = @IdF_crdmMoneda,
                        @IdSubCuenta = @IdF_crdcSubCuenta,
                        @IdSegmento = @IdT_crdpSegmentoOrinal,
                        @IdSaldoSegmento = 0, @IdOrigen = @IdF_crdcOrigen,
                        @IdTransaccion = @IdT_crdcTransaccion,
                        @IdCartera = @IdF_crdcCartera,
                        @IdAutorizacion = @IdAutorizacion,
                        @IdMovimientosOrigen = @IdAutorizacionAux,
                        @IdNivelVisibilidad = @IdNivelVisibilidad,
                        @Observacion = '', @CodEntidadMonv = @CodEntidadMonv,
                        @CodEntidadMonvDia = @CodEntidadMonvDia,
                        @CodigoOrganizacion = @CodigoOrganizacion,
                        @FactorOperacion = @FactorOperacion,
                        @IdSaldoDetallado = @IdT_crddSaldoDetallado,
                        @IdEsquemaContable = @IdF_crdcEsquemaContable,
                        @IdPlanFinanciero = @IdPlanFinancieroBase,
                        @Detalle = '', @IdF_crdcTipoProducto = 0,
                        @Especificacion = @Especificacion                  
                END                    
   ---Generacion de transaccion memo monto total de la factura                  
   -- Se obiene  el Codigo de la transaccion para total de la factura                  
            SELECT  @UserNumber = 75053                  
            SELECT  @MessageUser = 'Error al obtener los datos de la transaccion tabla  <t_crdpMovimientoTransaccion> '                    
                    
            SELECT  @IdT_crdcTransaccion = ta.IdT_crdcTransaccion ,
                    @FactorOperacion = ta.FactorOperacion ,
                    --@ConceptoApliTrans = ta.IdF_crdcConcepto ,
                    @IdNivelVisibilidad = ta.IdF_crdcNivelVisibilidad ,
                    @Descripcion = ta.Descripcion ,
                    @FactorOperacion = ta.FactorOperacion
            FROM    dbo.t_crdpMovimientoTransaccion motr WITH ( NOLOCK )
                    INNER JOIN dbo.t_crdcTransaccion ta WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
            WHERE   motr.Descripcion = @VENTA_MONTO_FACTURA                  
                  
                        
            IF @@ROWCOUNT = 0
                BEGIN                   
                    SELECT  @UserNumber = 75054 ,
                            @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <@tblTransVenta>:No existe el Codigo de transaccion Memo parametrizado para Monto Fomento.';                    
                       
     --Levanta el error                    
                    RAISERROR(@MessageUser,16,1)  
                    --THROW @UserNumber,@MessageUser,1                       
                END                    
                     
            SELECT  @IdAutorizacion = dbo.fnc_ObtenerSecuencia(@IdT_crdcTransaccion,
                                                              @Sucursal) ,
                    @IdAutorizacionAux = @IdRespuestaAutorizacion                  
                     
            SELECT  @UserNumber = 75055                  
            SELECT  @MessageUser = 'Error al ejecutar el sp  <usp_crdMovimientos_Guardar> '                    
                     
            EXEC dbo.usp_crdMovimientos_Guardar @Correlativo = 0,
                @Secuencia = 0, @Descripcion = @Descripcion,
                @FechaMovimiento = @FechaTransaccion,
                @FechaAplicacion = @FechaProceso,
                @FechaContable = @FechaProceso, @Plastico = @Cuenta,
                @NumeroReferencia = @NumRefFactura, @Monto = @MontoFactura,
                @MontoImp = 0, @Nivel = 0, @Usuario = @Usuario,
                @IdCuenta = @IdT_crdmCuenta, @IdMoneda = @IdF_crdmMoneda,
                @IdSubCuenta = @IdF_crdcSubCuenta,
                @IdSegmento = @IdT_crdpSegmentoOrinal, @IdSaldoSegmento = 0,
                @IdOrigen = @IdF_crdcOrigen,
                @IdTransaccion = @IdT_crdcTransaccion,
                @IdCartera = @IdF_crdcCartera,
                @IdAutorizacion = @IdAutorizacion,
                @IdMovimientosOrigen = @IdAutorizacionAux,
                @IdNivelVisibilidad = @IdNivelVisibilidad, @Observacion = '',
                @CodEntidadMonv = @CodEntidadMonv,
                @CodEntidadMonvDia = @CodEntidadMonvDia,
                @CodigoOrganizacion = @CodigoOrganizacion,
                @FactorOperacion = @FactorOperacion, @IdSaldoDetallado = 0,
                @IdEsquemaContable = @IdF_crdcEsquemaContable,
                @IdPlanFinanciero = @IdPlanFinancieroBase, @Detalle = '',
                @IdF_crdcTipoProducto = 0, @Especificacion = @Especificacion                  
                           
            SELECT  @UserNumber = 75056                  
            SELECT  @MessageUser = 'Error al actualizar los datos de la Saldo Moneda tabla  <t_crddSaldoMoneda> '                    
                     
            UPDATE  dbo.t_crddSaldoMoneda
            SET     FechaModificacion = GETDATE() ,
                    UsuModificacion = @Usuario ,
                    UltimoCorrelativo = @UltimoCorrelativo ,
                    SaldoRefUltimaCompra = CONVERT(MONEY, @MontoTotalFinanciar) ,
                    FechaUltimaCompra = @FechaTransaccion
            WHERE   IdF_crdmCuenta = @IdT_crdmCuenta
                    AND IdF_crdmMoneda = @IdF_crdmMoneda                   
                     
                  
            SELECT  @UserNumber = 75057                  
            SELECT  @MessageUser = 'Error al cambiar  el estado de la cuenta.'                    
                  
            IF EXISTS ( SELECT  1
                        FROM    dbo.t_crdpParametros WITH ( NOLOCK )
                        WHERE   LLave01 = @LLAVE_VENTA
                                AND Llave02 = @LLAVE_CAMBIO_RAZON_ESTADO
               AND Valor02 = @IdF_crdcRazonStatusCuenta )
                BEGIN                  
                    SELECT  @IdF_crdcRazonStatusCuentaNvo = Valor02
                    FROM    dbo.t_crdpParametros WITH ( NOLOCK )
                    WHERE   LLave01 = @LLAVE_VENTA
                            AND Llave02 = @LLAVE_CAMBIO_RAZON_ESTADONV                  
                    IF @@ROWCOUNT != 0
                        BEGIN                   
                            UPDATE  t_crdmCuenta
                            SET     IdF_crdcRazonStatusCuenta = @IdF_crdcRazonStatusCuentaNvo
                            WHERE   IdT_crdmCuenta = @IdT_crdmCuenta                  
                       
                        END                   
                END                  
                     
            SELECT  @UserNumber = 75058                  
            SELECT  @MessageUser = 'Error al ajecutar el sp  <usp_crdDistribucionSaldo_Actualizar> '                    
                  
            EXEC dbo.usp_crdDistribucionSaldo_Actualizar @Usuario = @Usuario,
                @IdT_climTienda = @Sucursal,
                @NumResultado = @NumResultado OUTPUT,
                @MsgResultado = @MsgResultado OUTPUT,
                @IdT_crdmCuenta = @IdT_crdmCuenta,
                @IdT_crdmMoneda = @IdF_crdmMoneda                   
                     
            SELECT  @CuotaTotal = CuotaMensual ,
                    @SaldoFinal = SaldoFinal --+ ISNULL(MontoActual, 0)              
            FROM    dbo.t_crddSaldoMoneda WITH ( NOLOCK )
            WHERE   IdF_crdmCuenta = @IdT_crdmCuenta
                    AND IdF_crdmMoneda = @IdF_crdmMoneda                  
                                  
            SELECT  @CuotaCompra = SUM(CuotaMensualSeguro) ,
                    @FechaCancelacion = MAX(FechaCancelacion) ,
                    @TCEA = MAX(TCA)
            FROM    dbo.t_crddSaldoDetallado SDD WITH ( NOLOCK )
            WHERE   SDD.IdF_crdmAutorizacion = @IdT_crdmAutorizacion              
                                  
            SELECT  @CuotaCompraSinGA = SUM(CuotaMensual)
            FROM    dbo.t_crddSaldoDetallado SDD WITH ( NOLOCK )
            WHERE   SDD.IdF_crdmAutorizacion = @IdT_crdmAutorizacion
                    AND SDD.IdF_crdcTipoProducto <> @CONCEPTO_EXTRA_GARANTIA
                                              
            IF @ContratoPromocional = 1
                BEGIN                
                    SELECT  @DetallePromocional = '1|'
                            + CONVERT(VARCHAR, @IdT_crdpPromocion) + '|'
                            + @DescripcionPromocion + '|'
                            + CONVERT(VARCHAR, @PlazoBase) + '|'
                            + CONVERT(VARCHAR, @TasaInteresBase) + '|'
                            + CONVERT(VARCHAR, @PlazoTraslado) + '|'
                            + CONVERT(VARCHAR, @TasaInteresTraslado) + '|'
                            + CONVERT(VARCHAR, @Plazo) + '|'
                            + CONVERT(VARCHAR, @TasaInteresNormalVenta) + '|'
                            + CONVERT(VARCHAR, @MesesGracia)                
                                              
                END                
            ELSE
                BEGIN                
                    SELECT  @DetallePromocional = '0|'                
                END                
                   
                    
            SELECT  @UserNumber = 75059                  
            SELECT  @MessageUser = 'Error al actualizar los datos en al tabla   <t_crdmAutorizacion> '                    
                   
            UPDATE  dbo.t_crdmAutorizacion
            SET     MontoFinanciar = @MontoTotalFinanciar ,
                    Prima = @MontoPrima ,
                    Cuota = @CuotaTotal ,
                    Plazo = @Plazo ,
                    SaldoFinal = @SaldoFinal ,
                 FechaPrimerPago = @FechaPrimerPago ,
                    TasaInteresBase = @TasaInteresBase ,
                    PlazoBase = @PlazoBase ,
                    DetallePromocional = @DetallePromocional ,
                    CuotaCompra = @CuotaCompra
            WHERE   IdT_crdmAutorizacion = @IdT_crdmAutorizacion                    
                     
            SELECT  @UserNumber = 75060                  
            SELECT  @MessageUser = 'Error al borrar el encabezado de la autorizacion tabla  <t_auttAutorizacion> '                    
                     
            DELETE  FROM dbo.t_auttAutorizacion
            WHERE   IdT_auttAutorizacion = @IdT_auttAutorizacion                  
                     
            SELECT  @UserNumber = 75061                  
            SELECT  @MessageUser = 'Error al borrar el detalle de la autorizacion tabla  <t_autdAutorizacionDetalle> '                    
                     
            DELETE  FROM dbo.t_autdAutorizacionDetalle
            WHERE   IdF_auttAutorizacion = @IdT_auttAutorizacion              
            
			--Solo validar la promocion de cliente para compras y NO para Post-Venta.
            IF @IdF_autcTipoAutorizacion = 1
                BEGIN
                    SELECT  @UserNumber = 75064
                    SELECT  @MessageUser = 'Error al ejecutar el procedimiento <usp_crdActualizaPromocionCliente>'                    
                                   
                    EXEC dbo.usp_crdActualizaPromocionCliente @Usuario = @Usuario, -- varchar(50)
                        @IdF_crdpPromocion = @IdT_crdpPromocion, --BIGINT
                        @IdF_climPersona = @IdT_climPersona, --BIGINT
                        @Factor = 1 --INT (1/-1)
                END

            COMMIT TRANSACTION 
            
            --Modificado por Minor Quiros para el manejo de la impresion de Documentos en SAPV
            SELECT  @ImprimioPagare = CASE WHEN @PagareSAPV = 2 THEN 0 -- Obligatorio en SAPV
                                           WHEN @PagareSAPV = 1
                                           THEN @ImprimioPagare -- Depende de Genesys
                                           ELSE 1
                                      END --No se imprime en SAPV
										  
            SELECT  @ImprimioContrato = CASE WHEN @ContratoSAPV = 2 THEN 0 -- Obligatorio en SAPV
                                             WHEN @ContratoSAPV = 1
                                             THEN @ImprimioContrato
                                             ELSE 1
                                        END --NO se imprime en SAPV
										   
            SELECT  @ImprimioHojaResumen = CASE WHEN @HojaResumenSAPV = 2
                                                THEN 0 -- Obligatorio en SAPV
                                                WHEN @HojaResumenSAPV = 1
                                                THEN 1 --Depende de Genesys
                                                ELSE 1
                                           END -- NO se Imprime en SAPV 
										      		  
			--Fin Modificacion Minor Quiros							  							            
  
  	--Inicio Modificacion AdmProblemas David Calderón 26-05-2016
            SELECT  @CuotaPactada = ISNULL(SUM(sd.CuotaMensualPactada),
                                           SUM(sd.CuotaMensualSeguro)) ,
                    @PlazoPactado = ISNULL(MAX(sd.PlazoPactado), MAX(sd.Plazo))
            FROM    dbo.t_crddSaldoDetallado sd WITH ( NOLOCK )
            WHERE   sd.IdF_crdmAutorizacion = @IdT_crdmAutorizacion
            GROUP BY sd.IdF_crdmAutorizacion				  							            
			--Fin Modificacion AdmProblemas David Calderón 26-05-2016
            
            

            SELECT  CodRespuesta = @CodRespuesta ,
                    Fecha = CONVERT(DATE, @FechaTransaccion) ,
                    Hora = CONVERT(TIME, @FechaTransaccion) ,
                    NumTransaccion = @NumTransaccion ,
                    NumTransaccionGene = @IdRespuestaAutorizacion ,
                    Enganche = @MontoPrima ,
                    ImporteAutorizado = @MontoTotalFinanciar ,
                    --Plazo = @PlazoBase ,
                    Plazo = @Plazo ,
                    CuotaTotal = @CuotaTotal ,
                    Comentario = @Repuesta ,
                    SaldoFinal = @SaldoFinal ,
                    FechaPrimerPago = @FechaPrimerPago ,
                    --TasaInteres = @TasaInteresBase ,
                    TasaInteres = @TasaInteresNormalVenta ,
                    DatosGenerales = CONVERT(VARCHAR, @CodRespuesta) + '|'
                    + CONVERT(VARCHAR, CONVERT(DATE, @FechaTransaccion)) + '|'
                    + CONVERT(VARCHAR, CONVERT(TIME, @FechaTransaccion)) + '|'
                    + CONVERT(VARCHAR, @NumTransaccion) + '|'
                    + CONVERT(VARCHAR, @IdRespuestaAutorizacion) + '|'
                    + CONVERT(VARCHAR, @MontoPrima) + '|'
                    + CONVERT(VARCHAR, @MontoTotalFinanciar) + '|'
                    + CONVERT(VARCHAR, @PlazoBase) + '|'
                    + CONVERT(VARCHAR, @CuotaTotal) + '|'
                    + CONVERT(VARCHAR, @Repuesta) + '|'
                    + CONVERT(VARCHAR, @SaldoFinal) + '|'
                    + CONVERT(VARCHAR, @FechaPrimerPago) + '|'
                    + CONVERT(VARCHAR, @TasaInteresBase) ,
                    DetallePromocional = @DetallePromocional ,
                    CuotaCompra = @CuotaCompra ,
                    IdT_crdmAutorizacion = @IdT_crdmAutorizacion ,
                    ImprimioContrato = ISNULL(@ImprimioContrato, 0) ,
                    ImprimioPagare = ISNULL(@ImprimioPagare, 0) ,
                    ImprimioHojaResumen = ISNULL(@ImprimioHojaResumen, 0) ,
                    FechaCancelacion = @FechaCancelacion ,
                    DetalleSeguro = '0|' ,
                    DetalleDeudor = '0|' ,
                    TasaEfectiva = @TCEA ,
                    CuotaSinGA = ISNULL(@CuotaCompraSinGA, 0.00) ,
					/* MODIFICACION SOPORTE PRODUCCION - DANIEL PACHECO / 24-05-2016 */
                    CuotaSugerida = @CuotaPactada ,
                    PlazoSugerido = @PlazoPactado ,
					/* MODIFICACION SOPORTE PRODUCCION - DANIEL PACHECO / 24-05-2016 */
					--MODIFICACIÓN 2.2
                    Convenio = CASE WHEN @VentaConvenio = @TRUE
                                    THEN @DescripcionConvenio
                                    ELSE ''
                               END ,--MODIFICACIÓN 2.2
                    Entidad = CASE WHEN @VentaConvenio = @TRUE
                                   THEN @DescripcionEntidad
                                   ELSE ''
                              END --MODIFICACIÓN 2.2
					

					
						
                                                      
        END TRY              
        BEGIN CATCH              
-- Valida si la transaccion no se puede hacer commit                           
            IF ( XACT_STATE() ) = -1
                BEGIN              
                    IF ( @@TRANCOUNT > 0 )
                        BEGIN              
                            ROLLBACK TRANSACTION              
                        END              
                END              
            
-- Valida si la transaccion se puede hacer commit              
            IF ( XACT_STATE() ) = 1
                BEGIN              
                    IF ( @@TRANCOUNT > 0 )
                        BEGIN              
                            COMMIT TRANSACTION               
                        END               
                END                
            
--ErrorHandler:                
            SELECT  @Severity = CONVERT(VARCHAR, ERROR_SEVERITY())              
            SELECT  @Priority = ERROR_STATE()              
  SELECT  @ProcessID = CONVERT(VARCHAR, ERROR_LINE())              
            SELECT  @MessageSystem = ERROR_MESSAGE()              
            SELECT  @SystemNumber = ERROR_NUMBER()              
            
--Definicion de mensaje de error              
            SELECT  @Observation = '(' + CONVERT(VARCHAR, @@NESTLEVEl)
                    + ')-Proceso:' + ISNULL(@ProcessName, 'N/D')
                    + ',Parametros:' + ISNULL(@Parameter, 'N/D') + ',Numero:'
                    + CONVERT(VARCHAR, ISNULL(@UserNumber, 0)) + ',Mensaje:'
                    + ISNULL(@MessageUser, 'N/D') + '|'
                    + ISNULL(@MessageSystem, 'N/D');            
            
--Levanta el error              
            RAISERROR(@Observation,16,1)
            --THROW @UserNumber,@Observation,1             
            
            BEGIN TRY              
                EXEC usp_exctException_Guardar @User = @Usuario,
                    @EventID = @@SPID, @Priority = 16, @Severity = @Severity,
                    @Title = 'Error', @Timestamp = '19000101',
                    @MachineName = @@SERVERNAME, @AppDomainName = '',
                    @ProcessID = @ProcessID, @ProcessName = @ProcessName,
                    @ThreadName = '', @Win32ThreadId = '',
                    @Message = @MessageSystem,
                    @FormattedMessage = @MessageUser, @Parameter = @Parameter,
                    @Observation = @Observation, @UserNumber = @UserNumber,
                    @SystemNumber = @SystemNumber, @LogId = 0              
            
            END TRY              
            BEGIN CATCH              
                SELECT  @MessageSystem = ERROR_MESSAGE()              
            
                SELECT  @UserNumber = 76001              
--Verbos a utilizar de acuerdo a la operacion=select:seleccionar, delete: eliminar, update: actualizar, insert: insertar, exec: ejecutar              
                SELECT  @MessageUser = 'Error al ejecutar el procedimiento <usp_exttException_Guardar>'               
            
                SELECT  @Observation = '(' + CONVERT(VARCHAR, @@NESTLEVEl)
                        + ')-Proceso:' + ISNULL(@ProcessName, 'N/D')
                        + ',Numero:' + CONVERT(VARCHAR, ISNULL(@UserNumber, 0))
                        + ',Mensaje:' + ISNULL(@MessageUser, 'N/D') + '|'
                        + ISNULL(@MessageSystem, 'N/D');              
            
                RAISERROR(@Observation,16,1) 
                --THROW @UserNumber,@Observation,1             
            END CATCH            
            
            SELECT  @NumResultado = @UserNumber              
            SELECT  @MsgResultado = @Observation              
			             
            RETURN @UserNumber              
        END CATCH              
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++                
--COMMIT TRAN                
        RETURN 0              
             
    END


