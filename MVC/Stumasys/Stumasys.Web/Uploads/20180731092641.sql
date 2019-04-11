
ALTER PROCEDURE [dbo].[usp_crdTransaccionVenta_ADQ]
    (
      @TipoTransaccion VARCHAR(2) = '05' ,
      @IDT_ClimPersona BIGINT ,
      @IDT_CrdmCuenta BIGINT ,			--
      @NumeroLote BIGINT ,			--NumeroTransaccion
      @IdPromocionPlazo BIGINT ,			--Idt_PromocionPlazo
      @MontoVenta DECIMAL(18, 2) , --MontoVenta
      @IdPosVirtual BIGINT ,			--Terminal
      @IDT_ClimTienda BIGINT ,			--Sucursal,
      @PkEncabezadoLote BIGINT ,			-- EncabezadoLote ADQ
      @FechaTransaccion DATETIME ,
      @CorrelativoFactura BIGINT = 0 ,
      @NumResultado INT = 0 OUTPUT ,
      @MsgResultado VARCHAR(MAX) = '' OUTPUT ,
	  --CAMBIO COSTO FORMALIZACION
      @MontoCostoFormalizacion DECIMAL(18, 2) = 0.00
    )
AS /*   
-------------------------------------------------------------------------  
Comentarios:  
-------------------------------------------------------------------------  
-->>>Creacion:  
-------------------------------------------------------------------------  
Objeto:			usp_crdTransaccionVenta_ADQ  
Descripcion:	Procedimiento que procesa la venta para ADQ afectando portafolio
Creado por:		Joshua Garcia Obando
Version:		1.0.0  
Fecha	:		2015-01-05  
Observaciones:  
-------------------------------------------------------------------------    
-->>>Modificacion #1:  
-------------------------------------------------------------------------  
Objeto:			usp_crdTransaccionVenta_ADQ  
Descripcion:	Se carga el campo convenio en la tabla t_crdmAutorizacion con la consulta por t_crddPlanPromoArticulo
Creado por:		Randall Sanabria
Version:		1.0.0  
Fecha	:		2017-02-02  
Observaciones:  
-------------------------------------------------------------------------    
Requerimiento:    Migración SQL Server 2016
Descripcion:    SE ELIMINA EL  RAISERROR . SE UTILIZA THROW
Uso:      
Modificado por:   Ricardo Melendez
Version:     2.0
Ejemplo de uso:   
Fecha:      14/03/2017
-------------------------------------------------------------------------
-------------------------------------------------------------------------    
Requerimiento:    Migración SQL Server 2016
Descripcion:    SE ELIMINA EL  RAISERROR . SE UTILIZA THROW
Uso:      
Modificado por:   Ricardo Melendez
Version:     2.0
Ejemplo de uso:   
Fecha:      14/03/2017
-------------------------------------------------------------------------
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
    BEGIN
        SET NOCOUNT ON
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
        DECLARE @Usuario VARCHAR(50) = 'VENTA_ADQ'
        DECLARE @IdT_autdAutorizacionDetalle BIGINT = 0	
		--Mod #1
        DECLARE @hora_transaccion TIME 

--Variables de trabajo
        DECLARE @IdRespuestaAutorizacion BIGINT ,
            @IdT_crdcTransaccion BIGINT ,
            @IdTipoSegmento BIGINT ,
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
            @ConceptoApliTrans BIGINT ,
            @Descripcion VARCHAR(50) ,
            @IdNivelVisibilidad BIGINT ,
            @DescripcionTrans VARCHAR(50) ,
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
            @IdF_crdmMoneda BIGINT ,
            @IdT_crdpSegmento BIGINT ,
            @CuotaTotal DECIMAL(18, 2) ,
            @IdEntidad BIGINT ,
            @IdT_TipoTransaccionOri BIGINT ,
            @IdT_crdxBitacoraTransaccional BIGINT ,
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
            @IdF_crdpStatusCuenta BIGINT ,
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
            @ComboSeguro VARCHAR(MAX) ,
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
            @Correo VARCHAR(MAX) ,
            @NombreUsual VARCHAR(MAX) ,
            @TCEA DECIMAL(18, 4) ,
            @DetalleSeguroDeudor VARCHAR(MAX) = '' ,
            @DetalleSeguroFijo VARCHAR(MAX) = '' ,
            @IdF_clicPais BIGINT ,
            @ContratoSAPV BIGINT ,
            @PagareSAPV BIGINT ,
            @HojaResumenSAPV BIGINT ,
			--Inicio Mod 08/02/2016 César Bolaños (monto de cobranza según la cuota)
            @MontoRecargaMora DECIMAL(18, 2) ,
            @FechaUltimoPago DATETIME ,
			--Fin Mod 08/02/2016 César Bolaños
			-- Rubén García Montenegro 22/03
            @TasaInteresCorriente DECIMAL(18, 2) ,
            @TasaEfectiva DECIMAL(18, 2) ,
            @CuotaGlobalPagoMinimo DECIMAL(18, 2) ,
            @EsIndividual BIT

		--Inicio Mod 01/12/2014 Allan Chavarria
        DECLARE @Hilera VARCHAR(MAX)= '' ,
            @ID_Cod_Resp_Exitoso SMALLINT = 0 ,
            @ID_Cod_Resp_Erroneo SMALLINT = 0
       
        --Fin Mod 01/12/2014 Allan Chavarria  
        
        --Inicio Mod 12/07/2018 Isack Munguia
        DECLARE @AplicaWOConvenios BIT = 0
                                               
        SELECT @AplicaWOConvenios = A.AplicaWOConvenios 
          FROM dbo.t_crdgParametrosGlobal A WITH(NOLOCK)  
        --Fin Mod 12/07/2018 Isack Munguia  
        
        
        
                  

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

        DECLARE @t_Autorizacion TABLE
            (
              --RESPUESTA
              [TipoRepuesta] [VARCHAR](1) ,
              [CodigoRespuesta] [BIGINT] ,
              [FechaRES] [DATE] ,
              [Hora] [TIME] ,
              [NumTransaccionRES] [VARCHAR](50) ,
              [NumTransaccionGene] [BIGINT] ,
              [Enganche] [DECIMAL](18, 2) ,
              [ImporteAutorizado] [DECIMAL](18, 2) ,
              [CuotaTotal] [DECIMAL](18, 2) ,
              [PlazoRES] [INT] ,
              [Descripcion] [VARCHAR](50) ,
		--ENCABEZADO
              [IdEntidad] [INT] NOT NULL ,
              [IdOrganizacion] [INT] NOT NULL ,
              [UsuInclusion] [VARCHAR](50) NULL ,
              [FechaCreacion] [DATETIME] NULL ,
              [EnviarDWH] [INT] NOT NULL ,
              [Estado] [INT] NOT NULL ,
              [Fecha] [DATETIME] NULL ,
              [Terminal] [INT] NULL ,
              [Sucursal] [INT] NULL ,
              [Cajero] [VARCHAR](30) NULL ,
              [NumTransaccion] [VARCHAR](50) NULL ,
              [MontoTotal] [DECIMAL](18, 2) NULL ,
              [MontoFinanciar] [DECIMAL](18, 2) NULL ,
              [Prima] [DECIMAL](18, 2) NULL ,
              [Plazo] [INT] NULL ,
              [Tasa] [DECIMAL](18, 4) NULL ,
              [Cuota] [DECIMAL](18, 2) NULL ,
              [SaldoActual] [DECIMAL](18, 2) NULL ,
              [EstadoAutorizacion] [VARCHAR](10) NULL ,
              [IdF_crdcTransaccion] [BIGINT] NULL ,
              [IdF_climPersona] [BIGINT] NULL ,
              [IdF_crdmCuenta] [BIGINT] NULL ,
              [IdF_crdpSegmento] [BIGINT] NULL ,
              [IdF_crddPlanPromoArticulo] [BIGINT] NULL ,
              [IdF_autcRespuestaAutorizacion] [BIGINT] NULL ,
              [IdF_crdmMoneda] [BIGINT] NULL ,
              [MontoFomento] [DECIMAL](18, 2) NULL ,
              [IdF_invcCanalVenta] [BIGINT] NULL ,
              [IdRefAutorizacion] [BIGINT] NULL ,
              [MontoExtragarantia] [DECIMAL](18, 2) NULL ,
              [IdF_autcTipoAutorizacion] [BIGINT] NULL ,
              [IdF_crdmAutorizacionPadre] [BIGINT] NULL ,
              [ComboSeguro] [VARCHAR](MAX) NULL ,
              [IdF_crddPlazosInformativos] [BIGINT] NULL ,
              [Productos] [VARCHAR](MAX) NULL ,
		--DETALLE
              [IdEntidadDetalle] [INT] NOT NULL ,
              [IdOrganizacionDetalle] [INT] NOT NULL ,
              [UsuInclusionDetalle] [VARCHAR](50) NULL ,
              [FechaCreacionDetalle] [DATETIME] NULL ,
              [EnviarDWHDetalle] [INT] NOT NULL ,
              [EstadoDetalle] [INT] NOT NULL ,
              [ComboPadre] [VARCHAR](80) NULL ,
              [CodigoArticulo] [VARCHAR](50) NULL ,
              [ComboIdCreacion] [VARCHAR](80) NULL ,
              [PlazoDetalle] [INT] NULL ,
              [Monto] [DECIMAL](18, 6) NULL ,
              [Concepto] [INT] NULL ,
              [IdF_auttAutorizacion] [BIGINT] NULL ,
              [MesesGarantiaProveedor] [INT] NULL ,
              [PrimaDetalle] [DECIMAL](18, 2) NULL ,
              [DescripcionDetalle] [VARCHAR](50) NULL ,
              [IdPKDetailRef] [BIGINT] NULL ,
              [IdPFDetailRef] [BIGINT] NULL ,
              [IdF_invcArticulo] [BIGINT] NULL ,
              [MontoFomentoDetalle] [DECIMAL](18, 2) NULL ,
              [MontoImpuesto] [DECIMAL](18, 2) NULL
            )  

        DECLARE @t_auttAutorizacion TABLE
            (
              [IdT_auttAutorizacion] [BIGINT] IDENTITY(1, 1)
                                              NOT NULL ,
              [IdEntidad] [INT] NOT NULL ,
              [IdOrganizacion] [INT] NOT NULL ,
              [UsuInclusion] [VARCHAR](50) NULL ,
              [FechaCreacion] [DATETIME] NULL ,
              [EnviarDWH] [INT] NOT NULL ,
              [Estado] [INT] NOT NULL ,
              [Fecha] [DATETIME] NULL ,
              [Terminal] [INT] NULL ,
              [Sucursal] [INT] NULL ,
              [Cajero] [VARCHAR](30) NULL ,
              [NumTransaccion] [VARCHAR](50) NULL ,
              [MontoTotal] [DECIMAL](18, 2) NULL ,
              [MontoFinanciar] [DECIMAL](18, 2) NULL ,
              [Prima] [DECIMAL](18, 2) NULL ,
              [Plazo] [INT] NULL ,
              [Tasa] [DECIMAL](18, 4) NULL ,
              [Cuota] [DECIMAL](18, 2) NULL ,
              [SaldoActual] [DECIMAL](18, 2) NULL ,
              [EstadoAutorizacion] [VARCHAR](10) NULL ,
              [IdF_crdcTransaccion] [BIGINT] NULL ,
              [IdF_climPersona] [BIGINT] NULL ,
              [IdF_crdmCuenta] [BIGINT] NULL ,
              [IdF_crdpSegmento] [BIGINT] NULL ,
              [IdF_crddPlanPromoArticulo] [BIGINT] NULL ,
              [IdF_autcRespuestaAutorizacion] [BIGINT] NULL ,
              [IdF_crdmMoneda] [BIGINT] NULL ,
              [MontoFomento] [DECIMAL](18, 2) NULL ,
              [IdF_invcCanalVenta] [BIGINT] NULL ,
              [IdRefAutorizacion] [BIGINT] NULL ,
              [MontoExtragarantia] [DECIMAL](18, 2) NULL ,
              [IdF_autcTipoAutorizacion] [BIGINT] NULL ,
              [IdF_crdmAutorizacionPadre] [BIGINT] NULL ,
              [ComboSeguro] [VARCHAR](MAX) NULL ,
              [IdF_crddPlazosInformativos] [BIGINT] NULL ,
              [Productos] [VARCHAR](MAX) NULL
            )

        DECLARE @t_autdAutorizacionDetalle TABLE
            (
              [IdT_autdAutorizacionDetalle] [BIGINT] IDENTITY(1, 1)
                                                     NOT NULL ,
              [IdEntidad] [INT] NOT NULL ,
              [IdOrganizacion] [INT] NOT NULL ,
              [UsuInclusion] [VARCHAR](50) NULL ,
              [FechaCreacion] [DATETIME] NULL ,
              [EnviarDWH] [INT] NOT NULL ,
              [Estado] [INT] NOT NULL ,
              [ComboPadre] [VARCHAR](80) NULL ,
              [CodigoArticulo] [VARCHAR](50) NULL ,
              [ComboIdCreacion] [VARCHAR](80) NULL ,
              [Plazo] [INT] NULL ,
              [Monto] [DECIMAL](18, 6) NULL ,
              [Concepto] [INT] NULL ,
              [IdF_auttAutorizacion] [BIGINT] NULL ,
              [MesesGarantiaProveedor] [INT] NULL ,
              [Prima] [DECIMAL](18, 2) NULL ,
              [Descripcion] [VARCHAR](50) NULL ,
              [IdPKDetailRef] [BIGINT] NULL ,
              [IdPFDetailRef] [BIGINT] NULL ,
              [IdF_invcArticulo] [BIGINT] NULL ,
              [MontoFomento] [DECIMAL](18, 2) NULL ,
              [MontoImpuesto] [DECIMAL](18, 2) NULL
            )

        DECLARE @vrcMontoVenta VARCHAR(50) = CAST(@MontoVenta AS VARCHAR) ,
            @NumTransaccion VARCHAR(50) = '' ,
            @NumRefFactura VARCHAR(50) = ''

--CONSTANTES                  
---------------------------
        DECLARE @CONCEPTO_ARTICULO BIGINT     = 1                  
        DECLARE @CONCEPTO_EXTRA_GARANTIA BIGINT    = 2                   
        DECLARE @CONCEPTO_SEGUROS BIGINT     = 3                  
        DECLARE @CONCEPTO_SEGUROS_AUTOEXPEDIBLES BIGINT = 5
        DECLARE @TIPO_SEGMENTO_EXT BIGINT     = 9                  
        DECLARE @SEGMENTO_PROMOCIONAL BIGINT    = 5                  
        DECLARE @SEGMENTO_PLAZO_FIJO BIGINT     = 7                  
        DECLARE @RESPUESTA_APROVADO VARCHAR(1)    = 'A'                  
        DECLARE @VENTA_AL_CREDITO VARCHAR(50)    = 'VENTA_AL_CREDITO'                  
        DECLARE @VENTA_AL_CREDITO_EXT VARCHAR(50)   = 'VENTA_AL_CREDITO_EXT'                   
        DECLARE @VENTA_AL_CREDITO_SEGUROS VARCHAR(50)  = 'VENTA_AL_CREDITO_SEGUROS'                  
        DECLARE @VENTA VARCHAR(50)       = 'VENTA'                   
        DECLARE @VENTA_MONTO_PRIMA VARCHAR(50)    = 'VENTA_MONTO_PRIMA'                   
        DECLARE @VENTA_MONTO_OPERACION VARCHAR(50)   = 'VENTA_MONTO_OPERACION'                  
        DECLARE @VENTA_MONTO_FACTURA VARCHAR(50)   = 'VENTA_MONTO_FACTURA'                  
        DECLARE @VENTA_MONTO_OPERACION_EXT VARCHAR(50)  = 'VENTA_MONTO_OPERACION_EXT'                  
        DECLARE @LLAVE_VENTA VARCHAR(50)     = 'Venta'                    
        DECLARE @LLAVE_CAMBIO_RAZON_ESTADO VARCHAR(50)  = 'CambioRazonEstado'                  
        DECLARE @LLAVE_CAMBIO_RAZON_ESTADONV VARCHAR(50) = 'NuevoCambioRazonEstado'
        
        DECLARE @VENTA_AL_CREDITO_SEG_AUTEXP VARCHAR(50) = 'VENTA_AL_CREDITO_SEG_AUTOEXPEDIBLE'
        DECLARE @VENTA_MONTO_SEG_AUTEXP VARCHAR(50) = 'VENTA_AL_CREDITO_SEGURO_AUTOEXPEDIBLE'
        DECLARE @SEGMENTO_AUTOEXPEDIBLE BIGINT = 70001
                  
        DECLARE @ESTADO_ACTIVO INT    = 1                    
        DECLARE @ESTADO_FINAL INT    = 4                    
        
        DECLARE @TipoSegDeudor INT = 1
        DECLARE @TipoSegFijo INT = 5
        
        DECLARE @TRUE INT = 1
        DECLARE @FALSE INT = 0 
        DECLARE @CodigoTienda VARCHAR(20)
        
        --Inicio Mod 01/12/2014 Allan Chavarria
        DECLARE @CODIGO_RESPUESTA_EXITOSO VARCHAR(2)= '01'
        DECLARE @CODIGO_RESPUESTA_ERRONEO VARCHAR(2)= '02'		
		--Fin Mod 01/12/2014 Allan Chavarria
         
	
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
        SELECT  @Parameter = '@Usuario =' + CONVERT(VARCHAR, @Usuario)
                + ',@IDT_ClimPersona =' + CONVERT(VARCHAR, @IDT_ClimPersona)
                + ',@IDT_CrdmCuenta =' + CONVERT(VARCHAR, @IDT_CrdmCuenta)
                + ',@NumeroLote =' + CONVERT(VARCHAR, @NumeroLote)
                + ',@IdPromocionPlazo =' + CONVERT(VARCHAR, @IdPromocionPlazo)
                + ',@MontoVenta =' + CONVERT(VARCHAR, @MontoVenta)
                + ',@IdPosVirtual =' + CONVERT(VARCHAR, @IdPosVirtual)
                + ',@IDT_ClimTienda =' + CONVERT(VARCHAR, @IDT_ClimTienda)
                + ',@PkEncabezadoLote =' + CONVERT(VARCHAR, @PkEncabezadoLote)
                           
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
        DECLARE @CANAL_VENTA_ADQUIRENCIA VARCHAR(15) = 'ADQUIRENCIA'
                   
 -----------------------------                  
 --CUERPO PROCEDIMIENTO                  
 -----------------------------                  
        SET XACT_ABORT ON;                  
                  
        BEGIN TRY                  
  --++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++    
			--Inicio Mod 01/12/2014 Allan Chavarria
            SELECT  @ID_Cod_Resp_Exitoso = IdT_crdcCodigosRespuestaADQ
            FROM    t_crdcCodigoRespuestaADQ
            WHERE   CodigoRespuesta = @CODIGO_RESPUESTA_EXITOSO
			
            SELECT  @ID_Cod_Resp_Erroneo = IdT_crdcCodigosRespuestaADQ
            FROM    t_crdcCodigoRespuestaADQ
            WHERE   CodigoRespuesta = @CODIGO_RESPUESTA_ERRONEO		        
			--Fin Mod 01/12/2014 Allan Chavarria
            
			
            DECLARE @IdentificacionPrimaria VARCHAR(50) = ''
            SELECT  @IdentificacionPrimaria = b.Descripcion
            FROM    dbo.t_crdmCuenta a WITH ( NOLOCK )
                    INNER JOIN dbo.t_clidIdentificacion b WITH ( NOLOCK ) ON ( a.IdF_climPersona = b.IdF_climPersona )
            WHERE   a.IdT_crdmCuenta = @IDT_CrdmCuenta
                    AND b.IdF_Tipo_Identificacion = 1

            IF EXISTS ( SELECT  *
                        FROM    dbo.t_crdpParametros a WITH ( NOLOCK )
                        WHERE   a.LLave01 = 'SAQ'
                                AND a.Llave02 = 'CLIENTE'
                                AND a.Llave03 = @IdentificacionPrimaria )
                BEGIN
                    SELECT  @UserNumber = 75011 ,
                            @MessageUser = 'ESTE CLIENTE ES UNICAMENTE DE CONSULTA'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser;
                    THROW @UserNumber,@MessageUser,1	  
                END
	
			    
            SELECT  @NumResultado = 0                    
            SELECT  @MsgResultado = ''        
            SELECT  @ContratoPromocional = 0                
            SELECT  @PrincipalCuota = 0              
            SELECT  @ImpPrincipalCuota = 0     
            SELECT  @NumCuotaInicial = 0           
                   
            SELECT  @UserNumber = 75001                  
            SELECT  @MessageUser = 'Error al obtener la organizacion <Organizacion>.'                   
                     
            SELECT  @CodigoOrganizacion = dbo.fnc_crdObtenerIdOrganizacion()                   
                     
            SELECT  @UserNumber = 75002                    
            SELECT  @MessageUser = '[Error al ejecutar el procedimiento <usp_utlCodigoEntidad_Obtener>]'                    
            EXEC dbo.usp_utlCodigoEntidad_Obtener @vrcNombreEntidad = 'crdxBitacoraTransaccional',
                @intCodigoEntidad = @IdEntidad OUTPUT                    
                      
            SELECT  @UserNumber = 75003                  
            SELECT  @MessageUser = '[Error al insertar en la tabla <t_crdxBitacoraTransaccional>]'                     
                     
            INSERT  INTO dbo.t_crdxBitacoraTransaccional
                    ( IdEntidad ,
                      IdOrganizacion ,
                      UsuInclusion ,
                      FechaCreacion ,
                      UsuModificacion ,
                      FechaModificacion ,
                      EnviarDWH ,
                      Estado ,
                      Observacion ,
                      TipoTransaccion ,
                      IdF_crdmCuenta ,
                      IdF_crdmMoneda ,
                      IdF_RefAutorizacion ,
                      IdF_crdcTransaccion ,
                      IdF_Identificador ,
                      IdF_crdcOrigen ,
                      IdF_climTienda ,
                      IdF_crddSaldoSegmento ,
                      IdF_crddSaldoDetallado ,
                      IdF_crdcSubCuenta ,
                      IdF_crdpSegmento ,
                      Reversion ,
                      IdF_RefOperacion                  
                    )
                    SELECT  IdEntidad = @IdEntidad ,
                            IdOrganizacion = @CodigoOrganizacion ,
                            UsuInclusion = @Usuario ,
                            FechaCreacion = GETDATE() ,
                            UsuModificacion = NULL ,
                            FechaModificacion = NULL ,
                            EnviarDWH = 1 ,
                            Estado = @ESTADO_ACTIVO ,
                            Observacion = '' ,
                            TipoTransaccion = 1 ,
                            IdF_crdmCuenta = 0 ,
                            IdF_crdmMoneda = 0 ,
                            IdF_RefAutorizacion = @NumTransaccion ,
                            IdF_crdcTransaccion = 0 ,
                            IdF_Identificador = 0 ,
                            IdF_crdcOrigen = 0 ,
                            IdF_climTienda = 0 ,
                            IdF_crddSaldoSegmento = 0 ,
                            IdF_crddSaldoDetallado = 0 ,
                            IdF_crdcSubCuenta = 0 ,
                            IdF_crdpSegmento = 0 ,
                            Reversion = 0 ,
                            IdF_RefOperacion = 0                    
                     
            SELECT  @IdT_crdxBitacoraTransaccional = SCOPE_IDENTITY()
			
            SELECT  @UserNumber = 75008                  
            SELECT  @MessageUser = 'Error al obtener datos de la tabla t_crdgParametrosGlobal.'                   
            SELECT  @IdF_crdmMoneda = Idf_crdmMoneda ,
                    @FechaProceso = FechaProceso ,
                    @AplicacionExtGarantia = AplicacionExtGarantia ,
                    @CicloAnteriorPosterior = CicloAnteriorPosterior
            FROM    dbo.t_crdgParametrosGlobal WITH ( NOLOCK )                  
            IF @@ROWCOUNT = 0
                BEGIN                  
                    SELECT  @UserNumber = 75009 ,
                            @MessageUser = 'Error al obtener los datos goblales en la tabla <t_crdgParametrosGlobal>:No existe parametros generales definidos.'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser                  
     --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
                END
			
			-- SIEMPRE LA FECHA DE TRANSACCION SEA LA MISMA FECHA DE PROCESO DEL SISTEMA
			--Mod #1, Sql no permitia la suma de una fecha y una hora
			--SELECT  @FechaTransaccion = @FechaProceso
            --        + CONVERT(TIME, @FechaTransaccion)
            SELECT  @hora_transaccion = @FechaTransaccion
            SELECT  @FechaTransaccion = CONVERT(DATETIME, @FechaProceso, 103)
                    + CAST(@hora_transaccion AS DATETIME)
			--fin Mod#1
            SELECT  @UserNumber = 75000
            SELECT  @MessageUser = '[Error al consultar en la tabla <t_climTienda>]'
	
            SELECT  @IdF_crdcSubCuenta = IdF_crdcSubCuenta ,
                    @CodigoTienda = CodigoTienda
            FROM    dbo.t_climTienda WITH ( NOLOCK )
            WHERE   IdT_climTienda = @IDT_ClimTienda
		
            SELECT  @UserNumber = 75000
            SELECT  @MessageUser = '[Error al consultar en la tabla <t_crddPromocionPlazo>]'
	
            SELECT  @IdT_crdpPromocion = PP.IdF_crdpPromocion
            FROM    dbo.t_crddPromocionPlazo PP WITH ( NOLOCK )
            WHERE   PP.IdT_crddPromocionPlazo = @IdPromocionPlazo
			
            SELECT  @UserNumber = 75000
            SELECT  @MessageUser = '[Error al consultar en la tabla <t_invcCanalVenta>]'
	
            SELECT  @IdCanalVenta = CodigoCanalVenta
            FROM    dbo.t_invcCanalVenta WITH ( NOLOCK )
            WHERE   Descripcion = @CANAL_VENTA_ADQUIRENCIA

			/**** MODIFICACION SOPORTE PRODUCCION - 06/10/2015 *****/
			--SELECT  @NumTransaccion = @TipoTransaccion + @CodigoTienda
   --                 + CONVERT(VARCHAR, @IdPosVirtual)
   --                 + CONVERT(VARCHAR, @CorrelativoFactura)
			/**** MODIFICACION SOPORTE PRODUCCION - 06/10/2015 *****/

			/**** MODIFICACION SOPORTE PRODUCCION - 06/10/2015 *****/

            SELECT  @NumTransaccion = @CodigoTienda + RIGHT('00000'
                                                            + CAST(@IdPosVirtual AS VARCHAR(5)),
                                                            5)
                    + RIGHT('000000' + CAST(@CorrelativoFactura AS VARCHAR(6)),
                            6)

			/**** MODIFICACION SOPORTE PRODUCCION - 06/10/2015 *****/

            SET @NumRefFactura = @NumTransaccion
			
			
			/******** ESCENARIOS ********/
				
            DECLARE @tblEscenario TABLE
                (
                  Cuota DECIMAL(18, 2) ,
                  Plazo INT ,
                  Tasa MONEY ,
                  Segmento BIGINT ,
                  IdPromocion BIGINT NULL ,
                  IdSeguro VARCHAR(100) ,
                  CuotaSeguro VARCHAR(100)
                )
            DECLARE @Cuota DECIMAL(18, 2) ,
                @Tasa MONEY ,
                @Segmento BIGINT ,
                @IdSeguro VARCHAR(100) ,
                @CuotaSeguro VARCHAR(100)
					

            SELECT  @UserNumber = 75000
            SELECT  @MessageUser = '[Error al ejecutar escenario <usp_crdCalculoEscenariosADQ>]'
            INSERT  INTO @tblEscenario
                    EXEC usp_crdCalculoEscenariosADQ @intCodCliente = @IDT_ClimPersona,
                        @intCodCuenta = @IDT_CrdmCuenta,
                        @intPromocion = @IdT_crdpPromocion,
                        @decMonto = @MontoVenta, @IdTienda = @IDT_ClimTienda,
                        @IdPromocionPlazo = @IdPromocionPlazo

			
            SELECT  @Cuota = Cuota ,
                    @Plazo = Plazo ,
                    @Tasa = Tasa ,
                    @Segmento = Segmento ,
                    @IdSeguro = IdSeguro ,
                    @CuotaSeguro = CuotaSeguro ,
					--Se cambia el IdPromocionPlazo para que en Revolvente se guarde en "0", en la tabla de autorizacion.
                    @IdPromocionPlazo = CASE @IdPromocionPlazo
                                          WHEN 1 THEN 0
                                          ELSE @IdPromocionPlazo
                                        END
            FROM    @tblEscenario
			
			/******** PROCESO PRE_AUTORIZACION ********/
		
            SELECT  @UserNumber = 75000
            SELECT  @MessageUser = 'Error al obtener la autorizacion sp usp_autAutorizacion_Obtener'
            INSERT  INTO @t_Autorizacion
                    EXEC usp_autAutorizacion_Obtener_ADQ @Usuario = @Usuario,
                        @Fecha = @FechaTransaccion, @Terminal = @IdPosVirtual,
                        @Sucursal = @IdF_crdcSubCuenta,
                        @NumTransaccion = @NumTransaccion,
                        @MontoTotal = @MontoVenta, @Cuota = @Cuota,
                        @Prima = 0.00, @Plazo = @Plazo, @Tasa = @Tasa,
                        @IdPersona = @IDT_ClimPersona,
                        @IdCuenta = @IDT_CrdmCuenta,
                        @CodMoneda = @IdF_crdmMoneda, @IdSegmento = @Segmento,
                        @IdPlanPromo = @IdPromocionPlazo,
                        @IdProducto = N'1&888888&0&888888',
                        @PrecioProducto = @vrcMontoVenta,
                        @IdCanalVenta = @IdCanalVenta,
                        @NumResultado = @NumResultado OUTPUT,
                        @MsgResultado = @MsgResultado OUTPUT,
                        @IdSeguro = @IdSeguro, @CuotaSeguro = @CuotaSeguro,
                        @CodigoUsuario = @Usuario,
                        @IdF_crddPlazosInformativos = 0,
						--CAMBIO COSTO FORMALIZACION
                        @MontoFomento = @MontoCostoFormalizacion;

            INSERT  INTO @t_auttAutorizacion
                    SELECT  IdEntidad ,
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
                            EstadoAutorizacion ,
                            IdF_crdcTransaccion ,
                            IdF_climPersona ,
                            IdF_crdmCuenta ,
                            IdF_crdpSegmento ,
                            IdF_crddPlanPromoArticulo ,
                            IdF_autcRespuestaAutorizacion ,
                            IdF_crdmMoneda ,
                            MontoFomento ,
                            IdF_invcCanalVenta ,
                            IdRefAutorizacion ,
                            MontoExtragarantia ,
                            IdF_autcTipoAutorizacion ,
                            IdF_crdmAutorizacionPadre ,
                            ComboSeguro ,
                            IdF_crddPlazosInformativos ,
                            Productos
                    FROM    @t_Autorizacion


			
            INSERT  INTO @t_autdAutorizacionDetalle
                    SELECT  IdEntidadDetalle ,
                            IdOrganizacionDetalle ,
                            UsuInclusionDetalle ,
                            FechaCreacionDetalle ,
                            EnviarDWHDetalle ,
                            EstadoDetalle ,
                            ComboPadre ,
                            CodigoArticulo ,
                            ComboIdCreacion ,
                            PlazoDetalle ,
                            Monto ,
                            Concepto ,
                            1 IdF_auttAutorizacion ,
                            MesesGarantiaProveedor ,
                            PrimaDetalle ,
                            DescripcionDetalle ,
                            IdPKDetailRef ,
                            IdPFDetailRef ,
                            IdF_invcArticulo ,
                            MontoFomentoDetalle ,
                            MontoImpuesto
                    FROM    @t_Autorizacion
						
			/******** PROCESO VENTA ********/
            SELECT  @UserNumber = 75004
            SELECT  @MessageUser = 'Error al actualizar la tabla t_crddSaldoDetallado los columnas de saldo principal.'
            SELECT  @IdT_auttAutorizacion = aut.IdT_auttAutorizacion ,
                    @IdRespuestaAutorizacion = aut.IdRefAutorizacion ,
                    @IdPlanPromoArticulo = IdF_crddPlanPromoArticulo ,
                    @MontoFomento = ISNULL(aut.MontoFomento, 0.00) ,
                    @IDT_CrdmCuenta = aut.IdF_crdmCuenta ,
                    @IdF_crdmMoneda = aut.IdF_crdmMoneda ,
                    @IdT_crdpSegmento = aut.IdF_crdpSegmento ,
                    @IdT_TipoTransaccionOri = aut.IdF_crdcTransaccion ,
                    @IdCanalVenta = aut.IdF_invcCanalVenta ,
                    @PrimaTotal = aut.Prima ,
                    @IdF_autcTipoAutorizacion = aut.IdF_autcTipoAutorizacion ,
                    @IdF_crdmAutorizacionPadre = aut.IdF_crdmAutorizacionPadre ,
                    @ComboSeguro = aut.ComboSeguro ,
                    @IdF_crddPlazosInformativos = aut.IdF_crddPlazosInformativos ,
                    @Productos = aut.Productos
            FROM    @t_auttAutorizacion aut
                    INNER JOIN dbo.t_autcRespuestaAutorizacion ra WITH ( NOLOCK ) ON ( aut.IdF_autcRespuestaAutorizacion = ra.IdT_autcRespuestaAutorizacion
                                                              AND ra.TipoRespuesta = @RESPUESTA_APROVADO
                                                              )
            WHERE   NumTransaccion = @NumTransaccion                  
            IF @@ROWCOUNT = 0
                BEGIN                 
                    SELECT  @UserNumber = 75007 ,
                            @MessageUser = 'La venta no se encuentra pre-autorizada. Numero de transacción: '
                            + CONVERT(VARCHAR, @NumTransaccion)                    
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser                  
--Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
                END

            
            SELECT  @IdT_crdpSegmentoOrinal = @IdT_crdpSegmento                  
                     
            IF ( SELECT COUNT(1)
                 FROM   dbo.uft_utlListToTableAll(@ComboSeguro, '|')
               ) > 0
                BEGIN              
                    IF NOT EXISTS ( SELECT  1
                                    FROM    t_crddCuentaCombo CSD WITH ( NOLOCK )
                                            INNER JOIN dbo.t_crddComboSeguroDetalle CSDE
                                            WITH ( NOLOCK ) ON CSD.IdF_crddComboSeguro = CSDE.IdF_crddComboSeguro
                                            INNER JOIN dbo.t_crdmSeguro SE
   WITH ( NOLOCK ) ON ( SE.IdT_crdmSeguro = CSDE.IdF_crdmSeguro )
                                            INNER JOIN dbo.t_crdpTipoSeguro TP
                                            WITH ( NOLOCK ) ON ( TP.IdT_crdpTipoSeguro = SE.IdF_crdpTipoSeguro
                                                              AND TP.AplicaSeguroPorArticulo = 0
                                                              )
                                    WHERE   CSD.IdF_crdmCuenta = @IDT_CrdmCuenta
                                            AND CSD.IdF_crdpEstadoCuentaCombo = 2
                                            AND CSD.IdF_crddComboSeguro IN (
                                            SELECT  CONVERT(BIGINT, StrVal)
                                            FROM    dbo.uft_utlListToTableAll(@ComboSeguro,
                                                              '|') ) )
                        AND NOT EXISTS ( SELECT 1
                                         FROM   t_crddCuentaCombo CSD WITH ( NOLOCK )
                                                INNER JOIN dbo.t_crddComboSeguroDetalle CSDE
                                                WITH ( NOLOCK ) ON CSD.IdF_crddComboSeguro = CSDE.IdF_crddComboSeguro
                                                INNER JOIN dbo.t_crdmSeguro SE
                                                WITH ( NOLOCK ) ON ( SE.IdT_crdmSeguro = CSDE.IdF_crdmSeguro )
                                                INNER JOIN dbo.t_crdpTipoSeguro TP
                                                WITH ( NOLOCK ) ON ( TP.IdT_crdpTipoSeguro = SE.IdF_crdpTipoSeguro
                                                              AND TP.AplicaSeguroPorArticulo = 1
                                                              )
                                         WHERE  CSD.IdF_crdmCuenta = @IDT_CrdmCuenta
                                                AND CSD.IdF_auttAutorizacion = @IdT_auttAutorizacion
                                                AND CSD.IdF_crdpEstadoCuentaCombo = 2
                                                AND CSD.IdF_crddComboSeguro IN (
                                                SELECT  CONVERT(BIGINT, StrVal)
                                                FROM    dbo.uft_utlListToTableAll(@ComboSeguro,
                                                              '|') ) )
                        BEGIN              
                            SELECT  @UserNumber = 75050 ,
                                    @MessageUser = 'La cotización se realizó con seguros el cual no se ha formalizado.'                     
                       
                            SELECT  @NumResultado = @UserNumber                  
                            SELECT  @MsgResultado = @MessageUser                  
     --Levanta el error                    
  		;
                            THROW @UserNumber,@MessageUser,1	  
                        END              
                                                       
        
                END                 
                 
            SELECT  @UserNumber = 75010                     
            SELECT  @MessageUser = 'Error al obtener datos de la tabla t_crdmCuenta.'                    
            SELECT  @IdPlanFinancieroBase = CU.IdF_crdpPlanFinanciero ,
                    @IdF_crdmCiclo = CU.IdF_crdmCiclo ,
                    @IdF_crdcCartera = CU.IdF_crdcCartera ,
                    @FechaCreacionCuenta = CU.FechaApertura ,
                    @Cuenta = CU.Cuenta ,
                    @IdF_crdpStatusCuenta = CU.IdF_crdpStatusCuenta ,
                    @IdF_crdcRazonStatusCuenta = IdF_crdcRazonStatusCuenta ,
                    @PlazoBase = PM.Plazo ,
                    @TasaInteresBase = PM.TasaInteresNormal ,
                    @FechaMaximaPago = CU.FechaMaximaPago ,
                    @MinimoDiasCuota = PF.MinimoDiasCuota ,
       @ImprimioContrato = PE.ImprimioContrato ,
                    @ImprimioPagare = PE.ImprimioPagare ,
                    @Correo = ( SELECT TOP 1
                                        ID.Detalle
                                FROM    t_clidContacto ID WITH ( NOLOCK )
                                        INNER JOIN t_clipTipoContacto TID WITH ( NOLOCK ) ON ( ID.IdF_clipTipoContacto = TID.IdT_clipTipoContacto )
                                        INNER JOIN t_utlpFuncionalidad FN WITH ( NOLOCK ) ON ( TID.IdT_clipTipoContacto = FN.IdF_Interface )
                                WHERE   FN.LLave01 = 'usp_crdAplicarTransaccionPrelacion'
                                        AND FN.Llave02 = 't_clipTipoContacto'
                                        AND FN.Llave03 = 'Mail'
                                        AND ID.IdF_climPersona = PE.IdT_climPersona
                                ORDER BY FN.Orden ASC
                              ) ,
                    @NombreUsual = PE.NombreUsual ,
                    @IDT_ClimPersona = PE.IdT_climPersona
            FROM    dbo.t_crdmCuenta CU WITH ( NOLOCK )
                    INNER JOIN dbo.t_crddPlanMoneda PM WITH ( NOLOCK ) ON ( CU.IdF_crdpPlanFinanciero = PM.IdF_crdpPlanFinanciero
                                                              AND PM.IdF_crdmMoneda = @IdF_crdmMoneda
                                                              )
                    INNER JOIN dbo.t_crdpPlanFinanciero PF WITH ( NOLOCK ) ON ( CU.IdF_crdpPlanFinanciero = PF.IdT_crdpPlanFinanciero )
                    INNER JOIN dbo.t_crdmCuentaAdicional ca WITH ( NOLOCK ) ON ( CU.IdT_crdmCuenta = ca.IdF_crdmCuenta
                                                              AND ca.Titular = 1
                                                              )
                    INNER JOIN dbo.t_climPersona PE WITH ( NOLOCK ) ON ( ca.IdF_climPersona = PE.IdT_climPersona )
            WHERE   IdT_crdmCuenta = @IDT_CrdmCuenta                  
                     
            IF @@ROWCOUNT = 0
                BEGIN                      
                    SELECT  @UserNumber = 75011 ,
                            @MessageUser = 'Error al obtener los datos de la Cuenta:No existe datos de la cuenta.'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser                  
     --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
                END                      
                     
            SELECT  @UserNumber = 75012                  
            SELECT  @MessageUser = 'Error al obtener datos de la tabla t_crddSaldoMoneda.'                   
            SELECT  @UltimoCorrelativo = ISNULL(UltimoCorrelativo, 1)
            FROM    dbo.t_crddSaldoMoneda WITH ( NOLOCK )
            WHERE   IdF_crdmCuenta = @IDT_CrdmCuenta
                    AND IdF_crdmMoneda = @IdF_crdmMoneda                  
                     
            IF @@ROWCOUNT = 0
                BEGIN                      
                    SELECT  @UserNumber = 75013 ,
                            @MessageUser = 'Error al obtener los datos de la Cuenta:No existe datos de la cuenta.'  
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser        
     --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
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
                    SELECT  @MsgResultado = @MessageUser                  
     --Levanta el error                
  		;
                    THROW @UserNumber,@MessageUser,1	  
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
                    FROM    @t_autdAutorizacionDetalle
                    WHERE   IdF_auttAutorizacion = @IdT_auttAutorizacion
                            AND Concepto = @CONCEPTO_ARTICULO
                            AND CodigoArticulo != ComboPadre
                    GROUP BY Concepto 
					
            INSERT  INTO dbo.t_autdAutorizacionDetalle
                    ( IdEntidad ,
                      IdOrganizacion ,
                      UsuInclusion ,
                      FechaCreacion ,
                      EnviarDWH ,
                      Estado ,
                      ComboPadre ,
                      CodigoArticulo ,
                      ComboIdCreacion ,
                      Plazo ,
                      Monto ,
                      Concepto ,
                      IdF_auttAutorizacion ,
                      MesesGarantiaProveedor ,
                      Prima ,
                      Descripcion ,
                      IdPKDetailRef ,
                      IdPFDetailRef ,
                      IdF_invcArticulo ,
                      MontoFomento ,
                      MontoImpuesto
			        )
                    SELECT  IdEntidad ,
                            IdOrganizacion ,
                            UsuInclusion ,
                            FechaCreacion ,
                            EnviarDWH ,
                            Estado ,
                            ComboPadre ,
                            CodigoArticulo ,
                            ComboIdCreacion ,
                            Plazo ,
                            Monto ,
                            Concepto ,
                            IdF_auttAutorizacion ,
                            MesesGarantiaProveedor ,
                            Prima ,
                            Descripcion ,
                            IdPKDetailRef ,
                            IdPFDetailRef ,
                            IdF_invcArticulo ,
                            MontoFomento ,
                            MontoImpuesto
                    FROM    @t_autdAutorizacionDetalle

            SELECT  @IdT_autdAutorizacionDetalle = SCOPE_IDENTITY()
	
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
                    FROM    @t_autdAutorizacionDetalle
                    WHERE   IdF_auttAutorizacion = @IdT_auttAutorizacion
                            AND Concepto = @CONCEPTO_SEGUROS
                   
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
                    SELECT  @MsgResultado = @MessageUser                  
    --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
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
                    SELECT  @MsgResultado = @MessageUser                  
    --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
                END
			
            INSERT  INTO @tblEspecificacion
                    SELECT  '|Operación&'
                            + ISNULL(CONVERT(VARCHAR, @NumRefFactura), '')
                            + '&bigint' + '|Extra Garantía&'
                            + ISNULL(CONVERT(VARCHAR, CASE WHEN ISNULL(ADA.Monto,
                                                              0) > 0 THEN 'Si'
                                                           ELSE 'No'
                                                      END), '') + '&varchar'
                            + '|Código Artículo&'
                            + ISNULL(CONVERT(VARCHAR, AD.CodigoArticulo), '')
                            + '&bigint' + '|Descripción&'
                            + ISNULL(CONVERT(VARCHAR, REPLACE(AD.Descripcion,
                                                              '&', '')), '')
                            + '&varchar' + '|Monto Artículo&'
                            + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18, 2), AD.Monto
                                     - AD.MontoImpuesto)), '') + '&decimal'
                            + '|Monto Impuesto Artículo&'
                            + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18, 2), AD.MontoImpuesto)),
                                     '') + '&decimal' + '|Prima&'
                            + ISNULL(CONVERT(VARCHAR, AD.Prima), '')
                            + '&decimal' + '|Monto Extra&'
                            + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18, 2), ISNULL(ADA.Monto
                                                              - ADA.MontoImpuesto,
                                                              0))), '')
                            + '&decimal' + '|Monto Impuesto Extra&'
                            + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18, 2), ISNULL(ADA.MontoImpuesto,
                                                              0))), '')
                            + '&decimal' + '|Monto Total&'
                            + ISNULL(CONVERT(VARCHAR, CONVERT(DECIMAL(18, 2), CONVERT(DECIMAL(18,
                                                              2), AD.Monto)
                                     + ISNULL(ADA.Monto, 0) - AD.Prima)), '')
                            + '&decimal'
                    FROM    @t_autdAutorizacionDetalle AD
                            LEFT JOIN @t_autdAutorizacionDetalle ADA ON ( AD.IdF_auttAutorizacion = ADA.IdF_auttAutorizacion
                                                              AND AD.IdPKDetailRef = ADA.IdPFDetailRef
                                                              AND ADA.Concepto = @CONCEPTO_EXTRA_GARANTIA
                                                              )
                    WHERE   AD.IdF_auttAutorizacion = @IdT_auttAutorizacion
                            AND AD.Concepto = @CONCEPTO_ARTICULO


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
            WHERE   CodigoTienda = @IdF_crdcSubCuenta                  
                  
            IF @@ROWCOUNT = 0
                BEGIN                  
                        
                    SELECT  @UserNumber = 75020 ,
                            @MessageUser = 'Error al obtener los datos de la tienda:No existe la sub cuenta definida.'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser                  
     --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
                  
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
            WHERE   cu.IdT_crdmCuenta = @IDT_CrdmCuenta
                    AND pm.IdF_crdmMoneda = @IdF_crdmMoneda                   
            IF @@ROWCOUNT = 0
                BEGIN                  
                        
                    SELECT  @UserNumber = 75050 ,
                            @MessageUser = 'Error al obtener los datos del segmento y planfinanciero. No existen en la tabla <t_crddPlanSegmento>'                     
                       
                    SELECT  @NumResultado = @UserNumber                  
                    SELECT  @MsgResultado = @MessageUser                  
     --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
                  
                END                  
                              
            SELECT  @UserNumber = 75022                  
            SELECT  @MessageUser = 'Error al obtener datos del tipo del segmento en la tabla t_crdpSegmento.'                  
                       
            SELECT  @IdTipoSegmento = SEG.IdF_crdcTipoSegmento ,
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
                            SELECT  @MsgResultado = @MessageUser                  
     --Levanta el error                    
  		;
                            THROW @UserNumber,@MessageUser,1	  
                        END
                    
                    IF EXISTS ( SELECT  1
                                FROM    dbo.t_crddPromocionAgrupacionCliente
                                        WITH ( NOLOCK )
                                WHERE   IdF_crdpPromocion = @IdT_crdpPromocion )
                        BEGIN 
                            SELECT  @TRUE = 1
                            FROM    dbo.t_crddPromocionAgrupacionCliente PAC
                                    WITH ( NOLOCK )
                            WHERE   PAC.IdF_crdpPromocion = @IdT_crdpPromocion
                                    AND PAC.IdF_climPersona = @IDT_ClimPersona
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
                                    SELECT  @MsgResultado = @MessageUser                  
		 --Levanta el error                    
  		;
                                    THROW @UserNumber,@MessageUser,1	  
                                END  
                        END
						                
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
                            @MessageUser = 'Error al obtener los datos del ciclo en la tabla <t_crdmCiclo>:No se encuentra definido el ciclo.'                     
    --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
                      
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
			
			
			--BEGIN TRANSACTION                   
                     
               
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
                            '' Descripcion ,
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
                            @NumRefFactura ,
                            Convenio = ( SELECT PC.IdF_clicConvenio
                                         FROM   dbo.t_crddPromocionPlazo PP WITH ( NOLOCK )
												LEFT JOIN dbo.t_crddPromocionConvenio PC WITH(NOLOCK)
													ON PC.IdF_crdpPromocion = PP.IdF_crdpPromocion
                                         WHERE  PP.IdT_crddPromocionPlazo = IdF_crddPlanPromoArticulo
                                       ),
                            AplicaSeparacionWO = (SELECT CASE WHEN @AplicaWOConvenios=0 AND PC.IdF_clicConvenio IS NULL
                                                              THEN 1
                                                              ELSE @AplicaWOConvenios
                                                         END
                                                    FROM dbo.t_crddPromocionPlazo PP WITH ( NOLOCK )
											LEFT JOIN dbo.t_crddPromocionConvenio PC WITH(NOLOCK)
												   ON PC.IdF_crdpPromocion = PP.IdF_crdpPromocion
                                                   WHERE PP.IdT_crddPromocionPlazo = IdF_crddPlanPromoArticulo
                                                 )
                    FROM    @t_auttAutorizacion
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
            WHERE   CSD.IdF_crdmCuenta = @IDT_CrdmCuenta
                    AND CSD.IdF_auttAutorizacion = @IdT_auttAutorizacion
                    AND CSD.IdF_crdpEstadoCuentaCombo = 2
                    AND CSD.IdF_crddComboSeguro IN (
                    SELECT  CONVERT(BIGINT, StrVal)
                    FROM    dbo.uft_utlListToTableAll(@ComboSeguro, '|') )                            
                                
                              
            SELECT  @FechaInicioDevengo = @FechaTransaccion    
			
			
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
                                             
                    IF @Concepto = @CONCEPTO_SEGUROS
                        BEGIN                  
                            SELECT  @UserNumber = 75039                  
                            SELECT  @MessageUser = 'Error al obtener datos del plan financiero para la extra garantia en la tabla t_crddPlanSegmento.'                  
                       
                            SELECT  @IdT_crdcTransaccion = motr.IdF_crdcTransaccion ,
                                    @IdT_crdpSegmento = ps.IdF_crdpSegmento ,
                                    @TasaInteresNormal = pm.TasaInteresNormal ,
                                    @GeneraInfoDetallada = ta.GeneraInfoDetallada ,
                                    @NivelRevolvente = ps.NivelRevolvente ,
                                    @MontoCuotaMinima = pm.MontoCuotaMinima ,
                                    @TasaInteresMora = pm.TasaInteresMora
                            FROM    dbo.t_crdpMovimientoTransaccion motr WITH ( NOLOCK )
                                    INNER JOIN dbo.t_crdcTransaccion ta WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                                    INNER JOIN dbo.t_crddPlanSegmento ps WITH ( NOLOCK ) ON ( motr.IdF_crdpSegmento = ps.IdF_crdpSegmento )
                                    INNER JOIN dbo.t_crddPlanMoneda pm WITH ( NOLOCK ) ON ( ps.IdF_crdpPlanFinancieroAsoc = pm.IdF_crdpPlanFinanciero )
                            WHERE   motr.Descripcion = @VENTA_AL_CREDITO_SEGUROS
                                    AND ps.IdF_crdpPlanFinanciero = @IdPlanFianciero                                                               
                        
                            IF @@ROWCOUNT = 0
                                BEGIN                   
                                    SELECT  @UserNumber = 75040 ,
                                            @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <t_crdpMovimientoTransaccion>:No existe el Codigo de transaccion parametrizado para seguros.'                     
--Levanta el error                    
  		;
                                    THROW @UserNumber,@MessageUser,1	  
                                END                    
                                                          
                          
                            SELECT  @IdAutorizacion = dbo.fnc_ObtenerSecuencia(@IdT_crdcTransaccion,
                                                              @IdF_crdcSubCuenta) ,
                                    @IdAutorizacionAux = @IdRespuestaAutorizacion                     
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
                            WHERE   motr.Descripcion = @VENTA_AL_CREDITO
                                    AND SEG.IdT_crdpSegmento = @IdT_crdpSegmento                                                                        
                            IF @@ROWCOUNT = 0
                                BEGIN                   
                                    SELECT  @UserNumber = 75042 ,
                                            @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <t_crdpMovimientoTransaccion>:No existe el Codigo de transaccion parametrizado para venta al credito.'                     
                         
--Levanta el error                    
  		;
                                    THROW @UserNumber,@MessageUser,1	  
                                END                    
                      
                            SELECT  @IdAutorizacion = @IdRespuestaAutorizacion ,
                                    @IdAutorizacionAux = 0                  
                        END                           
                                      
					
                    SELECT  @ConceptoAux = CASE WHEN @Concepto = @CONCEPTO_SEGUROS
                                                THEN @CONCEPTO_ARTICULO
                                                ELSE @Concepto
                                           END
													                       
                    SELECT  @UserNumber = 75043                  
                    SELECT  @MessageUser = 'Error al ejecutar el sp usp_crdTransaccionSuma_Procesar.'                   
                    


                    EXEC dbo.usp_crdTransaccionSuma_Procesar @Usuario = @Usuario,
                        @FechaTransaccion = @FechaTransaccion,
                        @FechaProceso = @FechaProceso,
                        @IdT_crdcTransaccion = @IdT_crdcTransaccion,
                        @MtoTra = @MontoFinanciar,
                        @MtoTraImp = @MontoFinanciarImpuesto,
                        @IdT_crdmCuenta = @IDT_CrdmCuenta,
                        @IdF_crdmMoneda = @IdF_crdmMoneda,
                        @IdT_crdpSegmento = @IdT_crdpSegmento, @Plazo = @Plazo,
                        @TasaAnual = @TasaInteresNormal,
                        @MesesGracia = @MesesGracia,
                        @NumeroReferencia = @NumRefFactura,
                        @IdF_crdcOrigen = @IdF_crdcOrigen,
                        @IdAutorizacion = @IdAutorizacion,
                        @IdF_crdcSubCuenta = @IdF_crdcSubCuenta,
                        @IdT_climTienda = @IdF_crdcSubCuenta,
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
                       
                            IF @Concepto = @CONCEPTO_SEGUROS
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
                                                              @IdF_crdcSubCuenta)                  
                            
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
                                @IdCuenta = @IDT_CrdmCuenta,
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
                                                              @IdF_crdcSubCuenta)                  
                        
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
                                        @IdCuenta = @IDT_CrdmCuenta,
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
                    IF @Concepto = @CONCEPTO_SEGUROS
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
                                    FROM    @t_autdAutorizacionDetalle
                                    WHERE   IdF_auttAutorizacion = @IdT_auttAutorizacion
                                            AND Concepto = @CONCEPTO_ARTICULO
                       
                        END                   
                           
                       
                    SELECT  @UltimoCorrelativo = @UltimoCorrelativo + 1                        
                    SELECT  @CountMin = @CountMin + 1                  
                END                    
    --CAMBIO COSTO FORMALIZACION
	--Generacion de transaccion memo monto fomento                  
    --Se obiene  el Codigo de la transaccion para intereses normales                  
            IF @MontoFomento > 0.00
                BEGIN
                    SELECT  @UserNumber = 75050;                  
                    SELECT  @MessageUser = 'Error al obtener los datos de la transaccion tabla  <t_crdpMovimientoTransaccion> ';                    
                      
                    SELECT  @IdT_crdcTransaccion = ta.IdT_crdcTransaccion ,
                            @FactorOperacion = ta.FactorOperacion ,
                            @ConceptoApliTrans = ta.IdF_crdcConcepto ,
                            @IdNivelVisibilidad = ta.IdF_crdcNivelVisibilidad ,
                            @Descripcion = ta.Descripcion ,
                            @FactorOperacion = ta.FactorOperacion
                    FROM    dbo.t_crdpMovimientoTransaccion motr WITH ( NOLOCK )
                            INNER JOIN dbo.t_crdcTransaccion ta WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
                    WHERE   motr.Descripcion = @VENTA_MONTO_FOMENTO;                       
                    IF @@ROWCOUNT = 0
         BEGIN                   
                            SELECT  @UserNumber = 75051 ,
                                    @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <t_crdpMovimientoTransaccion>:No existe el Codigo de transaccion Memo parametrizado para Monto Fomento.';                     
                        
      --Levanta el error                    
                            RAISERROR(@MessageUser,16,1);                       
                        END;                    
                      
                    SELECT  @IdAutorizacion = dbo.fnc_ObtenerSecuencia(@IdT_crdcTransaccion,
                                                              @IDT_ClimTienda) ,
                            @IdAutorizacionAux = @IdRespuestaAutorizacion;                  
                      
                    SELECT  @UserNumber = 75067;
                    SELECT  @MessageUser = 'Error al obtener IdT_crddSaldoDetallado del Tipo Producto Articulo  <t_crddSaldoDetallado> ';
                    
                    SELECT  @IdT_crddSaldoDetallado = IdT_crddSaldoDetallado
                    FROM    dbo.t_crddSaldoDetallado
                    WHERE   IdF_crdmAutorizacion = @IdT_crdmAutorizacion
                            AND IdF_crdcTipoProducto = @CONCEPTO_ARTICULO;
					
                    SELECT  @UserNumber = 75052;                  
                    SELECT  @MessageUser = 'Error al ejecutar el sp  <usp_crdMovimientos_Guardar> ';                    
                          
                    EXEC dbo.usp_crdMovimientos_Guardar @Correlativo = 0,
                        @Secuencia = 0, @Descripcion = @Descripcion,
                        @FechaMovimiento = @FechaTransaccion,
                        @FechaAplicacion = @FechaProceso,
                        @FechaContable = @FechaProceso, @Plastico = @Cuenta,
                        @NumeroReferencia = @NumRefFactura,
                        @Monto = @MontoFomento, @MontoImp = 0, @Nivel = 0,
                        @Usuario = @Usuario, @IdCuenta = @IDT_CrdmCuenta,
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
                        @Especificacion = @Especificacion;                  
                END;                 
                      
   ---Generacion de transaccion memo monto total de la factura                  
   -- Se obiene  el Codigo de la transaccion para total de la factura                  
            SELECT  @UserNumber = 75053                  
            SELECT  @MessageUser = 'Error al obtener los datos de la transaccion tabla  <t_crdpMovimientoTransaccion> '                    
            SELECT  @IdT_crdcTransaccion = ta.IdT_crdcTransaccion ,
                    @FactorOperacion = ta.FactorOperacion ,
                    @ConceptoApliTrans = ta.IdF_crdcConcepto ,
                    @IdNivelVisibilidad = ta.IdF_crdcNivelVisibilidad ,
                    @Descripcion = ta.Descripcion ,
                    @FactorOperacion = ta.FactorOperacion
            FROM    dbo.t_crdpMovimientoTransaccion motr WITH ( NOLOCK )
                    INNER JOIN dbo.t_crdcTransaccion ta WITH ( NOLOCK ) ON ( motr.IdF_crdcTransaccion = ta.IdT_crdcTransaccion )
            WHERE   motr.Descripcion = @VENTA_MONTO_FACTURA     
                        
            IF @@ROWCOUNT = 0
                BEGIN                   
                    SELECT  @UserNumber = 75054 ,
                            @MessageUser = 'Error al obtener los datos de la transaccion en la tabla <@tblTransVenta>:No existe el Codigo de transaccion Memo parametrizado para Monto Fomento.'                     
                       
     --Levanta el error                    
  		;
                    THROW @UserNumber,@MessageUser,1	  
                END                    
                     
            SELECT  @IdAutorizacion = dbo.fnc_ObtenerSecuencia(@IdT_crdcTransaccion,
                                                              @IdF_crdcSubCuenta) ,
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
                @IdCuenta = @IDT_CrdmCuenta, @IdMoneda = @IdF_crdmMoneda,
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
            
				/*LOrtiz CAMBIO APLICADO PARA RESTAR A MOVIMIENTOS DIA EL CF (@MontoFomento)-------*/
				--CAMBIO COSTO FORMALIZACION
				--IF @MontoCostoFormalizacion > 0.00 AND @MontoCostoFormalizacion < @MontoVenta
				--BEGIN
				--	SELECT  @UserNumber = 75056;                  
				--	SELECT  @MessageUser = 'Error al actualizar el monto de la venta menos el monto de fomento tabla  <t_cdmMovimientosDia> ';
				--	DECLARE @FechaProcesoContable DATETIME
				--	SELECT @FechaProcesoContable = FechaProceso FROM dbo.t_crdgParametrosGlobal WITH (NOLOCK)

				--	UPDATE  A
				--	SET     A.Monto = A.Monto - @MontoFomento
				--	FROM    dbo.t_crdmMovimientosDia A WITH ( NOLOCK )
				--	WHERE   FechaContable = @FechaProcesoContable
				--			AND A.NumeroReferencia = @NumRefFactura
				--			--AND A.UsuInclusion = 'VENTA_ADQ'
				--			AND A.IdF_crdcTransaccion IN ( 90004, 90001,10001,10005 ); /*aplica solo a estas transacciones*/

				--			/*	[10001] VENTA AL CREDITO, PLAN REVOLVENTE
				--				[10005] VENTA AL CREDITO, PLAN PLAZO Y TASA FIJO
				--				[90001] VENTA AL CREDITO
				--				[90004] MONTO DE LA FACTURA*/

				--	SELECT  @UserNumber = 75051;                  
				--	SELECT  @MessageUser = 'Error al actualizar el monto de la venta menos el monto de fomento tabla  <t_cdmMovimientos> ';

				--	UPDATE  A
				--	SET     A.Monto = A.Monto - @MontoFomento
				--	FROM    dbo.t_crdmMovimientos A WITH ( NOLOCK )
				--	WHERE   FechaContable = @FechaProcesoContable
				--			AND A.NumeroReferencia = @NumRefFactura
				--			--AND A.UsuInclusion = 'VENTA_ADQ'
				--			AND A.IdF_crdcTransaccion IN ( 90004, 90001,10001,10005 ); /*aplica solo a estas transacciones*/
				--END
				/*LOrtiz CAMBIO APLICADO PARA RESTAR A MOVIMIENTOS DIA EL CF (@MontoFomento)------------*/
                  
            SELECT  @UserNumber = 75056                  
            SELECT  @MessageUser = 'Error al actualizar los datos de la Saldo Moneda tabla  <t_crddSaldoMoneda> '                    
                     
            UPDATE  dbo.t_crddSaldoMoneda
            SET     FechaModificacion = GETDATE() ,
                    UsuModificacion = @Usuario ,
                    UltimoCorrelativo = @UltimoCorrelativo ,
                    SaldoRefUltimaCompra = @MontoTotalFinanciar ,
                    FechaUltimaCompra = @FechaTransaccion
            WHERE   IdF_crdmCuenta = @IDT_CrdmCuenta
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
                            WHERE   IdT_crdmCuenta = @IDT_CrdmCuenta                  
                       
                        END                   
                END                  
                     
            SELECT  @UserNumber = 75058                  
            SELECT  @MessageUser = 'Error al ajecutar el sp  <usp_crdDistribucionSaldo_Actualizar> '                    
                  
            EXEC dbo.usp_crdDistribucionSaldo_Actualizar @Usuario = @Usuario,
                @IdT_climTienda = @IdF_crdcSubCuenta,
                @NumResultado = @NumResultado OUTPUT,
                @MsgResultado = @MsgResultado OUTPUT,
                @IdT_crdmCuenta = @IDT_CrdmCuenta,
                @IdT_crdmMoneda = @IdF_crdmMoneda                   
                     
            SELECT  @CuotaTotal = CuotaMensual ,
                    @SaldoFinal = SaldoFinal  --+ ISNULL(MontoActual, 0)              
					-- Rubén García 01571284 Release ADQ
                    --@TasaEfectiva = TasaInteresNormal ,
                    --@TasaInteresCorriente = SaldoInteresNormal
                    --+ SaldoInteresNormalSuspenso + SaldoInteresNormalSeparada
					-- Rubén García 01571284 Release 
            FROM    dbo.t_crddSaldoMoneda WITH ( NOLOCK )
            WHERE   IdF_crdmCuenta = @IDT_CrdmCuenta
                    AND IdF_crdmMoneda = @IdF_crdmMoneda;                  
                                  
          SELECT  @CuotaCompra = SUM(CuotaMensualSeguro) ,
                    @FechaCancelacion = MAX(FechaCancelacion) ,
                    @TCEA = MAX(TCA)
            FROM    dbo.t_crddSaldoDetallado SDD WITH ( NOLOCK )
            WHERE   SDD.IdF_crdmAutorizacion = @IdT_crdmAutorizacion              
                                  
            SELECT  @CuotaCompraSinGA = SUM(CuotaMensual)
            FROM    dbo.t_crddSaldoDetallado SDD WITH ( NOLOCK )
            WHERE   SDD.IdF_crdmAutorizacion = @IdT_crdmAutorizacion
                    AND SDD.IdF_crdcTipoProducto <> @CONCEPTO_EXTRA_GARANTIA;

			-- RUBEN GARCIA TASA EFECTIVA E INTERES CORRIENTE 04/04/2017
            SELECT TOP 1
                    @EsIndividual = ISNULL(SDD.PagaIndividual, 0)
            FROM    dbo.t_crddSaldoDetallado SDD WITH ( NOLOCK )
            WHERE   SDD.IdF_crdmAutorizacion = @IdT_crdmAutorizacion
                    AND SDD.IdF_crdcTipoProducto = @CONCEPTO_ARTICULO

            IF @EsIndividual = 1
                BEGIN

                    SELECT TOP 1
                            @TasaEfectiva = ISNULL(SDD.TCA, 0) ,
                            @TasaInteresCorriente = ISNULL(SDD.TasaInteresNormal,
                                                           0)
                    FROM    dbo.t_crddSaldoDetallado SDD WITH ( NOLOCK )
                    WHERE   SDD.IdF_crdmAutorizacion = @IdT_crdmAutorizacion
                            AND SDD.IdF_crdcTipoProducto = @CONCEPTO_ARTICULO
                            AND SDD.Estado = 1
                            AND SDD.PagaIndividual = 1
                END
            ELSE
                BEGIN
                    SELECT TOP 1
                            @TasaEfectiva = ISNULL(MAX(SDD.TCA), 0) ,
                            @TasaInteresCorriente = ISNULL(MAX(SDD.TasaInteresNormal),
                                                           0)
                    FROM    dbo.t_crddSaldoDetallado SDD WITH ( NOLOCK )
                    WHERE   SDD.IdF_crdmCuenta = @IDT_CrdmCuenta
                            AND SDD.IdF_crdcTipoProducto = @CONCEPTO_ARTICULO
                            AND SDD.Estado = 1
                            AND SDD.PagaIndividual = 0
                END 
			-- FIN RUBEN GARCIA TASA EFECIT
			                                  
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
            
			
            
            
            SELECT  @UserNumber = 75064
            SELECT  @MessageUser = 'Error al ejecutar el procedimiento <usp_crdActualizaPromocionCliente>'                    
                                   
            EXEC dbo.usp_crdActualizaPromocionCliente @Usuario = @Usuario, -- varchar(50)
                @IdF_crdpPromocion = @IdT_crdpPromocion, --BIGINT
                @IdF_climPersona = @IDT_ClimPersona, --BIGINT
                @Factor = 1 --INT (1/-1)
            
            SELECT  @UserNumber = 75063             
            SELECT  @MessageUser = 'Error al actualizar las variables <@DetalleSeguroDeudor, @DetalleSeguroFijo>'                    
                                   
            SELECT  @DetalleSeguroDeudor += CASE WHEN s.IdF_crdpTipoSeguro = @TipoSegDeudor
                                                 THEN '03|' + UPPER(a.Nombre)
                                                      + '|'
                                                      + CONVERT(VARCHAR, ssd.MesesVigencia)
                                                      + '|'
                                                      + UPPER(s.Descripcion)
                                                 ELSE ''
                                            END ,
                    @DetalleSeguroFijo += CASE WHEN s.IdF_crdpTipoSeguro = @TipoSegFijo
                                               THEN '02|' + UPPER(a.Nombre)
                                                    + '|'
                                                    + CONVERT(VARCHAR, ssd.MesesVigencia)
                                                    + '|'
                                                    + UPPER(s.Descripcion)
                                               ELSE ''
                                          END
            FROM    dbo.t_crddSaldoDetallado sd WITH ( NOLOCK )
                    INNER JOIN dbo.t_crddSeguroSaldoDetallado ssd WITH ( NOLOCK ) ON sd.IdT_crddSaldoDetallado = ssd.IdF_crddSaldoDetallado
                    INNER JOIN dbo.t_crdmSeguro s WITH ( NOLOCK ) ON ssd.IdF_crdmSeguro = s.IdT_crdmSeguro
                    INNER JOIN dbo.t_crdmAseguradora a WITH ( NOLOCK ) ON a.IdT_crdmAseguradora = s.IdF_crdmAseguradora
            WHERE   sd.IdF_crdmAutorizacion = @IdT_crdmAutorizacion
           
					         
            UPDATE  t_crdxBitacoraTransaccional
            SET     IdF_crdmCuenta = @IDT_CrdmCuenta ,
                    IdF_crdmMoneda = @IdF_crdmMoneda ,
                    IdF_crdcTransaccion = @IdT_TipoTransaccionOri ,
                    IdF_crdpSegmento = @IdT_crdpSegmentoOrinal ,
                    IdF_RefOperacion = @IdAutorizacion ,
                    Estado = @ESTADO_FINAL ,
                    FechaModificacion = GETDATE()
            WHERE   IdT_crdxBitacoraTransaccional = @IdT_crdxBitacoraTransaccional                  
                      
                      
            SELECT  @TasaInteresBase = @TasaInteresBase / 12   
            SELECT  @TasaInteresNormalVenta = @TasaInteresNormalVenta / 12  
            
            
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
										      		  			

            DELETE  FROM t_autdAutorizacionDetalle
            WHERE   IdT_autdAutorizacionDetalle = @IdT_autdAutorizacionDetalle

			--Inicio Mod 08/02/2016 César Bolaños (Se establece el monto de recarga por mora segun la cuota mensual dependiendo del plan financiero del cliente)
            SET @MontoRecargaMora = ( SELECT    Monto
                                      FROM      t_crdpCargoPorMora
                                      WHERE     @Cuota >= MontoInicial
                                                AND @Cuota <= MontoFinal
                                                AND Idf_crdpPlanFinanciero = @IdPlanFinancieroBase
                                                AND Estado = 1
                                    )

			--Si la cuota no se encuentra dentro del rango del plan financiero asociado se establece en 0
            IF @MontoRecargaMora IS NULL
                BEGIN
                    SET @MontoRecargaMora = 0;
                END;

			--Se establece la fecha del ultimo pago(Se suma el plazo de 48 meses a la fecha del primer pago)
            SET @FechaUltimoPago = DATEADD(MONTH, @Plazo, @FechaPrimerPago);
			--Fin Mod 08/02/2016 César Bolaños
			
            SELECT  @CuotaGlobalPagoMinimo = SUM(CuotaMensual)
            FROM    t_crddSaldoSubCuenta
            WHERE   IdF_crdmCuenta = @IDT_CrdmCuenta
                    AND Estado = 1;
								
            SELECT  @Hilera = 'CodigoRespuesta='
                    + LTRIM(RTRIM(@CODIGO_RESPUESTA_EXITOSO)) + '|'
                    + 'MensajeRespuesta=COMPRA EXITOSA' + '|'
                    + 'Autorizacion=' + LTRIM(RTRIM(@IdT_crdmAutorizacion))
                    + '|' + 'NumRefFactura=' + LTRIM(RTRIM(@NumRefFactura))
                    + '|' + 'FechaProceso=' + LTRIM(RTRIM(@FechaProceso))
                    + '|' + 'NumeroLote=' + LTRIM(RTRIM(@NumeroLote)) + '|'
                    + 'PkEncabezadoLote=' + LTRIM(RTRIM(@PkEncabezadoLote))
					--Inicio Mod 08/02/2016 César Bolaños (Se agrega la variable @MontoRecargaMora y @FechaUltimoPago en la respuesta)
                    + '|' + 'MontoRecargaMora='
                    + LTRIM(RTRIM(@MontoRecargaMora)) + '|'
                    + 'FechaUltimoPago=' + LTRIM(RTRIM(@FechaUltimoPago))
					--Fin Mod 08/02/2016 César Bolaños					

					--- Rubén García Montenegro Inicio 01571284 Release ADQ 
                    + '|' + 'CuotaGlobalPagoMinimo='
                    + LTRIM(RTRIM(ISNULL(@CuotaGlobalPagoMinimo, 0))) + '|'
                    + 'TasaEfectiva=' + LTRIM(RTRIM(ISNULL(@TasaEfectiva, 0)))
                    + '|' + 'TasaInteresCorriente='
                    + LTRIM(RTRIM(ISNULL(@TasaInteresCorriente, 0)));
					--- Rubén García Montenegro Fin

            SELECT  @Hilera = dbo.fn_CreaSentenciaJSON(@Hilera, '=', '|', '',
                                                       '')
            
            SELECT  @CODIGO_RESPUESTA_EXITOSO AS CodigoRespuesta ,
                    'COMPRA EXITOSA' AS MensajeRespuesta ,
                    @IdT_crdmAutorizacion AS Autorizacion ,
                    @NumRefFactura AS NumRefFactura ,
                    @FechaProceso AS FechaProceso ,
                    @Hilera AS ExprJSON		                       
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
                    + ISNULL(@MessageSystem, 'N/D')              
            
--Levanta el error              
            --RAISERROR(@Observation,16,1)              
            
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
					
									
					
                IF ( @UserNumber = 75011 )
                    BEGIN
                        SELECT  @Hilera = 'CodigoRespuesta='
                                + LTRIM(RTRIM(@CODIGO_RESPUESTA_ERRONEO))
                                + '|' + 'MensajeRespuesta=' + @MessageUser
                    END
                ELSE
                    BEGIN
                        SELECT  @Hilera = 'CodigoRespuesta='
                                + LTRIM(RTRIM(@CODIGO_RESPUESTA_ERRONEO))
                                + '|'
                                + 'MensajeRespuesta=NO SE PUDO PROCESAR LA VENTA'
                    END 
				
                SELECT  @Hilera = dbo.fn_CreaSentenciaJSON(@Hilera, '=', '|',
                                                           '', '')	
				
                SELECT  @CODIGO_RESPUESTA_ERRONEO AS CodigoRespuesta ,
                        MensajeRespuesta = CASE WHEN @UserNumber = 75011
                                                THEN @MessageUser
                                                ELSE 'NO SE PUDO PROCESAR LA VENTA'
                                           END , 
					   --ERROR_MESSAGE() AS MensajeRespuesta, 
                        @Hilera AS ExprJSON
				--Fin Mod 01/12/2014 Allan Chavarria					   
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
                        + ISNULL(@MessageSystem, 'N/D')               
            
                          
            END CATCH            
            
                   
        END CATCH              
      
        RETURN 0              
            
    END 


