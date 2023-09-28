SELECT * FROM NARGEST.DBO.ARTICULO WHERE PERCEP=1

select * from dbo.PRODUCTO$



HHH2


ALTER  PROCEDURE HHH2
AS
DECLARE @CODARTI  varchar(255) 
-- Declaración del cursor
DECLARE cClientes CURSOR FOR


select * from dbo.PRODUCTO$ 


OPEN cClientes
FETCH cClientes INTO @CODARTI
WHILE (@@FETCH_STATUS = 0 )

BEGIN
    -- Lectura de la siguiente fila del cursor
   UPDATE NARGEST.DBO.ARTICULO  SET PERCEP =1
   WHERE CODARTI = @CODARTI 
FETCH cClientes INTO  @CODARTI
END

-- Cierre del cursor

CLOSE cClientes

-- Liberar los recursos

DEALLOCATE cClientes