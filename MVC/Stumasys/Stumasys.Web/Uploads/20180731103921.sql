USE FIT_DAT
GO

--BEGIN TRAN
--COMMIT TRAN
--ROLLBACK TRAN

  SELECT A.IdF_clicConvenio,COUNT(1) 
    FROM dbo.t_crdmAutorizacion A WITH(NOLOCK)
GROUP BY A.IdF_clicConvenio

  SELECT A.AplicaSeparacionWO,COUNT(1) 
    FROM dbo.t_crdmAutorizacion A WITH(NOLOCK)
GROUP BY A.AplicaSeparacionWO

SELECT A.AplicaWOConvenios,A.* 
  FROM dbo.t_crdgParametrosGlobal A WITH(NOLOCK)
             
SELECT *  FROM t_crdpParametros

UPDATE t_crdmAutorizacion 
   SET AplicaSeparacionWO = CASE WHEN IdF_clicConvenio IS NOT NULL THEN 1 ELSE 0 END
 WHERE 1=1

UPDATE t_crdgParametrosGlobal 
   SET AplicaWOConvenios = 1
 WHERE 1=1

  SELECT A.IdF_clicConvenio,COUNT(1) 
    FROM dbo.t_crdmAutorizacion A WITH(NOLOCK)
GROUP BY A.IdF_clicConvenio

  SELECT A.AplicaSeparacionWO,COUNT(1) 
    FROM dbo.t_crdmAutorizacion A WITH(NOLOCK)
GROUP BY A.AplicaSeparacionWO

SELECT A.AplicaWOConvenios,A.* 
  FROM dbo.t_crdgParametrosGlobal A WITH(NOLOCK)