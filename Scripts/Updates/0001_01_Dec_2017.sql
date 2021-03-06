﻿ALTER PROCEDURE [dbo].[PROC_OUTSIDE_SALE_MASTER_SALE_NEW]
    (
      @v_SI_ID INT ,
      @v_SI_CODE VARCHAR(50) ,
      @v_SI_NO DECIMAL ,
      @v_DC_NO DECIMAL ,
      @v_SI_DATE DATETIME ,
      @v_CUST_ID INT ,
      @V_INVOICE_STATUS INT ,
      @v_REMARKS VARCHAR(500) ,
      @v_PAYMENTS_REMARKS VARCHAR(500) ,
      @v_SALE_TYPE VARCHAR(10) ,
      @v_GROSS_AMOUNT DECIMAL(18, 2) ,
      @v_VAT_AMOUNT DECIMAL(18, 2) ,
      @v_NET_AMOUNT DECIMAL(18, 0) ,
      @V_IS_SAMPLE INT ,
      @V_DELIVERY_NOTE_NO VARCHAR(50) ,
      @V_VAT_CST_PER NUMERIC(18, 2) ,
      @V_SAMPLE_ADDRESS VARCHAR(500) ,
      @v_CREATED_BY VARCHAR(50) ,
      @v_CREATION_DATE DATETIME ,
      @v_MODIFIED_BY VARCHAR(50) ,
      @v_MODIFIED_DATE DATETIME ,
      @v_DIVISION_ID INT ,
      @V_VEHICLE_NO VARCHAR(100) = NULL ,
      @V_TRANSPORT VARCHAR(70) = NULL ,
      @v_SHIPP_ADD_ID INT = NULL ,
      @v_INV_TYPE CHAR(1) = NULL ,
      @v_LR_NO VARCHAR(100) = NULL ,
      @V_MODE INT
    )
AS
    BEGIN                          
        IF @V_MODE = 1
            BEGIN    
                INSERT  INTO SALE_INVOICE_MASTER
                        ( SI_ID ,
                          SI_CODE ,
                          SI_NO ,
                          DC_GST_NO ,
                          SI_DATE ,
                          CUST_ID ,
                          INVOICE_STATUS ,
                          REMARKS ,
                          PAYMENTS_REMARKS ,
                          SALE_TYPE ,
                          GROSS_AMOUNT ,
                          VAT_AMOUNT ,
                          NET_AMOUNT ,
                          IS_SAMPLE ,
                          DELIVERY_NOTE_NO ,
                          VAT_CST_PER ,
                          SAMPLE_ADDRESS ,
                          CREATED_BY ,
                          CREATION_DATE ,
                          MODIFIED_BY ,
                          MODIFIED_DATE ,
                          DIVISION_ID ,
                          VEHICLE_NO ,
                          TRANSPORT ,
                          SHIPP_ADD_ID ,
                          LR_NO ,
                          INV_TYPE
                        )
                VALUES  ( @V_SI_ID ,
                          @V_SI_CODE ,
                          @V_SI_NO ,
                          @v_DC_NO ,
                          @V_SI_DATE ,
                          @V_CUST_ID ,
                          @V_INVOICE_STATUS ,
                          @V_REMARKS ,
                          @V_PAYMENTS_REMARKS ,
                          @V_SALE_TYPE ,
                          @V_GROSS_AMOUNT ,
                          @V_VAT_AMOUNT ,
                          @V_NET_AMOUNT ,
                          @V_IS_SAMPLE ,
                          @V_DELIVERY_NOTE_NO ,
                          @V_VAT_CST_PER ,
                          @V_SAMPLE_ADDRESS ,
                          @V_CREATED_BY ,
                          @V_CREATION_DATE ,
                          @V_MODIFIED_BY ,
                          @V_MODIFIED_DATE ,
                          @V_DIVISION_ID ,
                          @V_VEHICLE_NO ,
                          @V_TRANSPORT ,
                          @v_SHIPP_ADD_ID ,
                          @v_LR_NO ,
                          @v_INV_TYPE 
                        ) 
						
                DECLARE @Remarks VARCHAR(250)
                SET @Remarks = 'Sale against invoice No- ' + @V_SI_CODE
                    + CAST(@V_SI_NO AS VARCHAR(50))
                EXECUTE Proc_CustomerLedger_Insert @V_CUST_ID, 0,
                    @V_NET_AMOUNT, @Remarks, @V_Division_ID, @V_SI_ID, 16,
                    @V_Created_BY	
						                         
            END   
        IF @V_MODE = 2
            BEGIN  
                --UPDATE  STOCK_DETAIL
                --SET     STOCK_DETAIL.Issue_Qty = ( STOCK_DETAIL.Issue_Qty
                --                                   - SALE_INVOICE_STOCK_DETAIL.ITEM_QTY ) ,
                --        STOCK_DETAIL.Balance_Qty = ( STOCK_DETAIL.Balance_Qty
                --                                     + SALE_INVOICE_STOCK_DETAIL.ITEM_QTY )
                --FROM    dbo.STOCK_DETAIL
                --        JOIN dbo.SALE_INVOICE_STOCK_DETAIL ON SALE_INVOICE_STOCK_DETAIL.STOCK_DETAIL_ID = STOCK_DETAIL.STOCK_DETAIL_ID
                --                                              AND SALE_INVOICE_STOCK_DETAIL.ITEM_ID = STOCK_DETAIL.Item_id
                --WHERE   SI_ID = @V_SI_ID
		
                --DELETE  FROM dbo.SALE_INVOICE_DETAIL
                --WHERE   SI_ID = @V_SI_ID
                --DELETE  FROM dbo.SALE_INVOICE_STOCK_DETAIL
                --WHERE   SI_ID = @V_SI_ID
                --DECLARE @CashOut NUMERIC(18, 2)
                --DECLARE @CashIn NUMERIC(18, 2)
                --SET @CashOut = 0
                --SET @CashIn = ( SELECT  CashOut
                --                FROM    dbo.CustomerLedgerDetail
                --                WHERE   TransactionId = @v_SI_ID
                --                        AND TransactionTypeId = 16
                --              )
                --UPDATE  dbo.CustomerLedgerMaster
                --SET     AmountInHand = AmountInHand - @CashOut + @CashIn
                --WHERE   AccountId = @V_CUST_ID
                --DELETE  FROM dbo.CustomerLedgerDetail
                --WHERE   TransactionId = @v_SI_ID
                --        AND TransactionTypeId = 16
	
                UPDATE  SALE_INVOICE_MASTER
                SET    -- SI_CODE = @V_SI_CODE ,
                --        SI_NO = @V_SI_NO ,
                --        DC_GST_NO = @v_DC_NO ,
                --        SI_DATE = @V_SI_DATE ,
                        CUST_ID = @V_CUST_ID ,
                        INVOICE_STATUS = @V_INVOICE_STATUS ,
                        REMARKS = @V_REMARKS ,
                        PAYMENTS_REMARKS = @V_PAYMENTS_REMARKS ,
                        SALE_TYPE = @V_SALE_TYPE ,
                        GROSS_AMOUNT = @V_GROSS_AMOUNT ,
                        VAT_AMOUNT = @V_VAT_AMOUNT ,
                        NET_AMOUNT = @V_NET_AMOUNT ,
                        IS_SAMPLE = @V_IS_SAMPLE ,
                        DELIVERY_NOTE_NO = @V_DELIVERY_NOTE_NO ,
                        VAT_CST_PER = @V_VAT_CST_PER ,
                        SAMPLE_ADDRESS = @V_SAMPLE_ADDRESS ,
                        --CREATED_BY = @V_CREATED_BY ,
                        --CREATION_DATE = @V_CREATION_DATE ,
                        MODIFIED_BY = @V_MODIFIED_BY ,
                        MODIFIED_DATE = @V_MODIFIED_DATE ,
                        DIVISION_ID = @V_DIVISION_ID ,
                        VEHICLE_NO = @V_VEHICLE_NO ,
                        TRANSPORT = @V_TRANSPORT ,
                        SHIPP_ADD_ID = @v_SHIPP_ADD_ID ,
                        LR_NO = @v_LR_NO ,
                        INV_TYPE = @v_INV_TYPE
                WHERE   SI_ID = @V_SI_ID     
				
				
				  
                SET @Remarks = 'Sale against invoice No- ' + @V_SI_CODE
                    + CAST(@V_SI_NO AS VARCHAR(50))
                EXECUTE Proc_CustomerLedger_Insert @V_CUST_ID, 0,
                    @V_NET_AMOUNT, @Remarks, @V_Division_ID, @V_SI_ID, 16,
                    @V_Created_BY	                   
            END                      
        IF @V_MODE = 3
            BEGIN                      
                DECLARE UpdateStock CURSOR
                FOR
                    SELECT  Item_id ,
                            Item_qty ,
                            division_id
                    FROM    sale_invoice_detail
                    WHERE   si_id = @v_SI_ID                        
                OPEN UpdateStock                        
                DECLARE @DivisionId AS INT                        
                DECLARE @ItemId AS INT                        
                DECLARE @ItemQty AS NUMERIC(18, 4)                      
                FETCH NEXT FROM UpdateStock INTO @ItemId, @ItemQty,
                    @DivisionId                        
                WHILE @@FETCH_STATUS = 0
                    BEGIN                        
                        UPDATE  item_detail
                        SET     current_stock = current_stock + @ItemQty
                        WHERE   item_id = @ItemId
                                AND div_id = @DivisionId                        
                        FETCH NEXT FROM UpdateStock INTO @ItemId, @ItemQty,
                            @DivisionId                        
                    END                         
                CLOSE UpdateStock 
                DEALLOCATE UpdateStock   
                DELETE  FROM sale_invoice_Detail
                WHERE   si_id = @v_SI_ID 
                DELETE  FROM sale_invoice_master
                WHERE   si_id = @v_SI_ID                        
            END  
    END 

---------------------------------------------------------------------------------------------------------
ALTER TABLE dbo.ACCOUNT_GROUPS ADD Primary_AG_ID int  NULL DEFAULT 0

----------------------------------------------------------------------------------------------------------

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Company_Master](
	[Pk_CompanyId_num] [numeric](18, 0) NULL,
	[CompanyName_vch] [nvarchar](250) NULL,
	[Address_Vch] [nvarchar](300) NULL,
	[Fk_stateId_Num] [numeric](18, 0) NULL,
	[financialyear_dt] [datetime] NULL,
	[CinNo_vch] [varchar](50) NULL,
	[PanNo_Vch] [varchar](50) NULL,
	[GstNo_Vch] [varchar](50) NULL,
	[fk_CreatedBy_num] [numeric](18, 0) NULL,
	[CreatedDate_dt] [datetime] NULL,
	[fk_ModifiedBy_num] [numeric](18, 0) NULL,
	[ModifiedDate_dt] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

---------------------------------------------------------------------------------------------------------------------

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Label_Master](
	[Pk_LabelId_Num] [numeric](18, 0) NOT NULL,
	[LabelName_Vch] [nvarchar](250) NULL,
	[LabelDescription_Vch] [nvarchar](500) NULL,
	[CreatedBy_Num] [numeric](18, 0) NULL,
	[CreatedDate_Dt] [datetime] NULL,
	[ModifiedBy_Num] [numeric](18, 0) NULL,
	[ModifiedDate_Dt] [datetime] NULL,
 CONSTRAINT [PK_Tag_Master] PRIMARY KEY CLUSTERED 
(
	[Pk_LabelId_Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-----------------------------------------------------------------------------------------------------------

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Label_Items](
	[Pk_LabelDetailId_Num] [numeric](18, 0) NOT NULL,
	[fk_LabelId_num] [numeric](18, 0) NULL,
	[LabelItemName_vch] [nvarchar](250) NULL,
	[CreatedBy_Num] [numeric](18, 0) NULL,
	[CreatedDate_Dt] [datetime] NULL,
	[ModifiedBy_Num] [numeric](18, 0) NULL,
	[ModifiedDate_Dt] [datetime] NULL,
 CONSTRAINT [PK_Tag_Details] PRIMARY KEY CLUSTERED 
(
	[Pk_LabelDetailId_Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
--------------------------------------------------------------------------------------------------------------


SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LabelItem_Mapping](
	[Fk_LabelDetailId] [numeric](18, 0) NULL,
	[Fk_ItemId_Num] [numeric](18, 0) NULL
) ON [PRIMARY]

GO