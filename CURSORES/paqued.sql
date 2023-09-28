


NSP_UPDATE_TMP_STOCKPEDIDO2 '01',0,'018015',0

alter    PROC   NSP_UPDATE_TMP_STOCKPEDIDO2    --- '01','1302','1000008','60500005','24'                          
@CODEMPRESA UD_CODEMPRESA,                          
@CORREL  INT,                          
@CODARTI UD_CDARTI,                          
@STOCK_ACT_UND UD_MONTOS                     
AS                          
BEGIN  TRANSACTION                          
DECLARE @FACTORMIN  UD_MONTOS                          
DECLARE @FACTORMAX  UD_MONTOS                          
DECLARE @STOCK_FALT_PAQ  UD_MONTOS                          
DECLARE @CODPRESM  UD_CODPRESENTACION                          
DECLARE @DESPRESM  UD_PRESENTACION                          
DECLARE @STOCK_FALT_UND  UD_MONTOS                          
DECLARE @CODPRESU  UD_CODPRESENTACION                          
DECLARE @DESPRESU  UD_PRESENTACION                          
DECLARE @STOCK_PEDIDO_UND  UD_MONTOS                          
DECLARE @STOCKFALT  UD_MONTOS                          
DECLARE @STOCK_DISP  UD_MONTOS                          
DECLARE @RESIDUO  UD_MONTOS                          
DECLARE @CODPRESVERIF UD_CODPRESENTACION                  
DECLARE @DESPRESVERIF UD_PRESENTACION                  
DECLARE @FACTORVERIF UD_MONTOS                  
DECLARE @STOCKVERIF UD_MONTOS                  
DECLARE @FACTORVERIF2 INT                  
DECLARE @STOCKVERIF2 INT                          
                  
                  
print 'ENTRO A OTRO PROCE @CODARTI = ' + CONVERT(VARCHAR(50),@CODARTI)  
  
  
SET  @FACTORMIN=0                          
SET @FACTORMAX=0                          
SET @STOCK_FALT_PAQ=0                          
SET @CODPRESM=''                          
SET @DESPRESM=''                          
SET  @STOCK_FALT_UND=0                          
SET @CODPRESU=''                          
SET @DESPRESU=''                          
SET @STOCK_PEDIDO_UND=0                          
SET @STOCKFALT=0                          
SET @STOCK_DISP=0                          
                          
SET  @STOCK_PEDIDO_UND=186                    
--SELECT  @STOCK_PEDIDO_UND            
        
    
    
 PRINT '@CODARTI ' +  CONVERT(VARCHAR(50), @CODARTI)    
    
 PRINT '@STOCK_ACT_UND 2 ' +  CONVERT(VARCHAR(50), @STOCK_ACT_UND)         
 PRINT '@STOCK_PEDIDO_UND 2 ' +  CONVERT(VARCHAR(50), @STOCK_PEDIDO_UND)         
        
         
                      
SET @STOCK_DISP=(@STOCK_ACT_UND - @STOCK_PEDIDO_UND )         
 PRINT '@STOCK_DISP ' +  CONVERT(VARCHAR(50), @STOCK_DISP)         
        
                         
IF      @STOCK_DISP >= 0                           
 BEGIN                          
  PRINT ('HAY STOCK DISPONIBLE---')                          
                            
       /*  UPDATE    TMP_STOCKPEDIDO SET     STOCK_ACT_UND=STOCK_PEDIDO_UND                          
  WHERE   CODEMPRESA=@CODEMPRESA  AND  CORREL=@CORREL   AND  CODARTI=@CODARTI                        
  SELECT  @STOCK_DISP AS STOCKDISPONIBLE  */                        
 END                          
ELSE                          
 BEGIN                          
  PRINT ('NO  HAY STOCK DISPONIBLE')                          
  SET @STOCKFALT=@STOCK_DISP      
PRINT  '@STOCKFALT 1 = ' + CONVERT(VARCHAR(50),@STOCKFALT)       
                        
  --SELECT  @STOCKFALT                          
  IF  @STOCKFALT < 0      
PRINT  '@STOCKFALT 2 = ' + CONVERT(VARCHAR(50),@STOCKFALT)       
                          
   BEGIN                          
                             
   SET   @STOCKFALT=(@STOCKFALT * (-1))                          
    SET @CODPRESU=(SELECT  TOP 1 CODPRES   FROM  ARTIPRESENT  A WHERE A.CODARTI=@CODARTI  AND A.CODEMPRESA=@CODEMPRESA ORDER BY EQUIVALENCIA  ASC )                          
    SELECT  TOP 1 @DESPRESU=DESPRES, @FACTORMIN=FACTOR FROM PRESENTACION  WHERE  CODEMPRESA=@CODEMPRESA AND  CODPRES=@CODPRESU                           
                            
   SELECT TOP 1  @FACTORMAX=ISNULL(P.[FACTOR],0),@CODPRESM=ISNULL(P.[CODPRES],''),                          
      @DESPRESM=ISNULL(P.[DESPRES],'')  FROM PRESENTACION   P INNER JOIN   ARTIPRESENT   A                           
    ON   P.[CODEMPRESA]=A.[CODEMPRESA]   AND  P.[CODPRES]=A.[CODPRES]                            
    WHERE   A.[CODARTI]=@CODARTI  AND  P.[FACTOR] <=@STOCKFALT   ORDER BY   P.[FACTOR] DESC      
    
                         
     IF  @@ROWCOUNT =0                          
      BEGIN                           
       RAISERROR  20000  'El articulo no tiene ninguna presentacion. Verificar los registros.'              
---'EL PEDIDO ES MENOR A LA UNIDAD'                          
       ROLLBACK  TRANSACTION                          
       RETURN -1                          
      END                          
                         
      
 PRINT CONVERT(VARCHAR(50),@FACTORMIN)       
 PRINT CONVERT(VARCHAR(50),@FACTORMAX)       
                          
  IF     @FACTORMIN=@FACTORMAX                          
   BEGIN                          
   PRINT ('LA CANTIDAD ES LA MINIMA')                          
   SET    @STOCK_FALT_UND=(@STOCKFALT/@FACTORMIN)                          
   SET    @STOCK_FALT_PAQ=0                          
                          
   END                          
  ELSE                   
   BEGIN                          
    PRINT ('LA CANTIDAD PASA EL MINIMO')       
      
  
 PRINT   ('@FACTORMAX')  + CONVERT(VARCHAR(50),@FACTORMAX)  
    PRINT   ('@STOCKFALT')  + CONVERT(VARCHAR(50),@STOCKFALT)       
                         
    SET    @STOCK_FALT_PAQ= CONVERT(INT,(@STOCKFALT/@FACTORMAX))                          
    SET    @STOCK_FALT_UND=(@STOCKFALT - (@STOCK_FALT_PAQ * @FACTORMAX))/@FACTORMIN                          
    SET  @STOCKVERIF=(@STOCKFALT - (@STOCK_FALT_PAQ * @FACTORMAX))        
      
      
    PRINT   ('@STOCK_FALT_PAQ')  + CONVERT(VARCHAR(50),@STOCK_FALT_PAQ)       
         
    PRINT   ('@STOCK_FALT_UND')  + CONVERT(VARCHAR(50),@STOCK_FALT_UND)              
      
    PRINT   ('@STOCKVERIF')  + CONVERT(VARCHAR(50),@STOCKVERIF)       
     
DECLARE  CURSORVERIF   CURSOR  FOR                  
SELECT AR.[CODPRES],PR.[DESPRES],PR.[FACTOR] FROM                    
 ARTIPRESENT  AR  LEFT JOIN  PRESENTACION  PR                   
ON  AR.[CODPRES]=PR.[CODPRES] AND   AR.[CODEMPRESA]=PR.[CODEMPRESA]                    
WHERE                   
AR.[CODARTI]=@CODARTI                  
AND  AR.[CODEMPRESA]=@CODEMPRESA                  
GROUP BY AR.[CODPRES],PR.[DESPRES],PR.[FACTOR]                  
OPEN   CURSORVERIF                  
FETCH   NEXT  FROM CURSORVERIF                  
INTO    @CODPRESVERIF,@DESPRESVERIF,@FACTORVERIF                  
WHILE  @@FETCH_STATUS=0                  
BEGIN                  
IF  (@STOCKVERIF)=CONVERT(INT,@STOCKVERIF)AND (@FACTORVERIF)=CONVERT(INT,@FACTORVERIF)                  
 BEGIN                  
  SET @FACTORVERIF2=@FACTORVERIF                  
  SET @STOCKVERIF2=@STOCKVERIF                  
 IF  (@STOCKVERIF2%@FACTORVERIF2)=0                  
   BEGIN                  
   SET     @STOCK_FALT_UND=(@STOCKVERIF)/@FACTORVERIF                      
   SET @DESPRESU=@DESPRESVERIF                  
   SET @CODPRESU=@CODPRESVERIF                  
   END                  
 END                  
FETCH   NEXT  FROM CURSORVERIF                  
INTO    @CODPRESVERIF,@DESPRESVERIF,@FACTORVERIF                  
END                  
CLOSE   CURSORVERIF                  
DEALLOCATE  CURSORVERIF                  
                  
   END                          
                          
  END                          
                          
  /*UPDATE   TMP_STOCKPEDIDO   SET STOCK_ACT_UND=@STOCK_ACT_UND ,                           
  STOCK_FALT_UND=@STOCK_FALT_UND, STOCK_FALT_PAQ=@STOCK_FALT_PAQ,                          
  CODPRESM=@CODPRESM,CODPRESU=@CODPRESU,DESPRESU=@DESPRESU,                          
  DESPRESM=@DESPRESM  WHERE  CORREL=@CORREL  AND CODEMPRESA=@CODEMPRESA                     
  AND CODARTI=@CODARTI    */                  
  SELECT   '0' AS STOCKDISPONIBLE                          
                          
 END                          
                       
COMMIT  TRANSACTION  
                         
RETURN  0                         
    

  
