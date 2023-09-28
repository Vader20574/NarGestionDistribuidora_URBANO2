CREATE PROC NSP_TRAER_CLIENTE_VTA_COBRAR_DOC          
@CDTIPODOC VARCHAR(10),          
@NUMDOC  UD_CORRELATIVOS           
AS          
SELECT  C.[DATOADJUNTO] AS 'CLIENTE' ,          
V.[TOTCREDBAS], V.[PAGCREDBAS],dbo.FN_NOMBRE_CLIENTE(V.CODEMPRESA,V.CDCLIENTEDEP) as CDCLIENTEDEP,V.CDCLIENTEDEP,V.FECDOCUM,V.VENCIMIENTO,V.fproceso,V.ESTADO          
FROM VENTA_X_COBRAR V LEFT JOIN CLIENTE C ON V.[CDCLIENTE] = C.[CODCLIENTE]      
WHERE V.[CDTIPODOCUM] = @CDTIPODOC AND V.[NRODOCU] = @NUMDOC    


select NRODOCU,TOTCREDBAS from VENTA_X_COBRAR where estado ='CANCELADO'


select * from VENTA_X_COBRAR where estado ='CANCELADO'


HHHEE

ALTER  PROCEDURE HHHEE
AS
DECLARE @CODARTI  varchar(255) 
DECLARE @MONTO  varchar(255)
DECLARE @CDTIPODOCUM varchar(255)

-- Declaración del cursor
DECLARE cClientes CURSOR FOR


select NRODOCU,TOTCREDBAS,CDTIPODOCUM from VENTA_X_COBRAR where estado ='CANCELADO'


OPEN cClientes
FETCH cClientes INTO @CODARTI,@MONTO,@CDTIPODOCUM
WHILE (@@FETCH_STATUS = 0 )

BEGIN
    -- Lectura de la siguiente fila del cursor
   UPDATE NARGEST.DBO.VENTA_X_COBRAR SET PAGCREDBAS =@MONTO
   WHERE  CDTIPODOCUM = @CDTIPODOCUM AND NRODOCU = @CODARTI 
FETCH cClientes INTO  @CODARTI,@MONTO,@CDTIPODOCUM
END

-- Cierre del cursor

CLOSE cClientes

-- Liberar los recursos

DEALLOCATE cClientes