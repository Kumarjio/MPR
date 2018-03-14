﻿
ALTER PROCEDURE [dbo].[get_count_Item_Issued]
 @Item_ID INT  
AS  
BEGIN  
 DECLARE @count INT  
SET @count = 0  
SELECT @count = @count + COUNT(*) FROM dbo.MATERIAL_ISSUE_TO_COST_CENTER_DETAIL WHERE ITEM_ID = @Item_ID  
SELECT @count = @count + COUNT(*) FROM dbo.NON_STOCKABLE_ITEMS_MAT_REC_WO_PO WHERE ITEM_ID = @Item_ID  
SELECT @count = @count + COUNT(*) FROM dbo.NON_STOCKABLE_ITEMS_MAT_REC_AGAINST_PO WHERE ITEM_ID = @Item_ID 
SELECT @count = @count + COUNT(*) FROM dbo.MATERIAL_RECEIVED_WITHOUT_PO_DETAIL WHERE ITEM_ID = @Item_ID
SELECT @count = @count + COUNT(*) FROM dbo.MATERIAL_RECEIVED_AGAINST_PO_DETAIL WHERE ITEM_ID = @Item_ID
SELECT @count = @count + COUNT(*) FROM dbo.SALE_INVOICE_DETAIL WHERE ITEM_ID = @Item_ID    
SELECT @count  
END