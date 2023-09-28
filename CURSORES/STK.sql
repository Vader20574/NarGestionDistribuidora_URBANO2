
dbo.FN_STOCK_PAQ (A.CODARTI,'01',ARTIDAT.STKACTU)
SELECT dbo.FN_STOCK_UND ('018015','01',186)
SELECT dbo.FN_STOCK_PAQ ('018015','01',186)


ALTER FUNCTION FN_STOCK_UND  
(   

@CDART VARCHAR(50),
@CODEMPRESA VARCHAR(50),
@CANT INT
)

RETURNS INT

AS

BEGIN          

DECLARE  @CODPRESMAX UD_CODPRESENTACION                  
DECLARE  @FACTORMAX UD_MONTOS      
DECLARE  @STKACTU INT
Declare @STOCK_FALT_PAQ INT 
Declare @STOCK_FALT_UND INT 
   

SET @CODPRESMAX=(SELECT  TOP 1 CODPRES FROM  ARTIPRESENT  A WHERE A.CODARTI=@CDART AND A.CODEMPRESA=@CODEMPRESA ORDER BY EQUIVALENCIA  DESC )                  
SET @FACTORMAX=(SELECT  TOP 1 EQUIVALENCIA FROM  ARTIPRESENT  A WHERE A.CODARTI=@CDART AND A.CODEMPRESA=@CODEMPRESA ORDER BY EQUIVALENCIA  DESC )                  
         
SET    @STOCK_FALT_PAQ= (@CANT/ @FACTORMAX)   
SET    @STOCK_FALT_UND=(@CANT - (@STOCK_FALT_PAQ * @FACTORMAX))


RETURN @STOCK_FALT_UND


END