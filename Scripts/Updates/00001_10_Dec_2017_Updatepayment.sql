﻿ALTER PROCEDURE [dbo].[ProcPaymentTransaction_Insert]
    (
      @PaymentTransactionId NUMERIC = NULL ,
      @PaymentTransactionNo VARCHAR(100) = NULL ,
      @PaymentTypeId NUMERIC = NULL ,
      @AccountId NUMERIC = NULL ,
      @PaymentDate DATETIME = NULL ,
      @ChequeDraftNo VARCHAR(50) = NULL ,
      @ChequeDraftDate DATETIME = NULL ,
      @BankId NUMERIC = 0 ,
      @BankDate DATETIME = NULL ,
      @Remarks VARCHAR(200) = NULL ,
      @TotalamountReceived NUMERIC(18, 2) = 0 ,
      @UndistributedAmount NUMERIC(18, 2) = 0 ,
      @CreatedBy VARCHAR(50) = NULL ,
      @DivisionId NUMERIC = 0 ,
      @StatusId NUMERIC = NULL ,
      @PM_TYPE NUMERIC(18, 0) = NULL ,
      @ProcedureStatus INT OUTPUT 

    )
AS
    BEGIN        
        DECLARE @LedgerId NUMERIC  

        SELECT  @PaymentTransactionId = ISNULL(MAX(PaymentTransactionId), 0)
                + 1
        FROM    dbo.PaymentTransaction            

        INSERT  INTO PaymentTransaction
                ( PaymentTransactionId ,
                  PaymentTransactionNo ,
                  PaymentTypeId ,
                  AccountId ,
                  PaymentDate ,
                  ChequeDraftNo ,
                  ChequeDraftDate ,
                  BankId ,
                  Remarks ,
                  TotalAmountReceived ,
                  UndistributedAmount ,
                  CreatedBy ,
                  CreatedDate ,
                  DivisionId ,
                  StatusId ,
                  BankDate ,
                  PM_TYPE 
                )
        VALUES  ( @PaymentTransactionId ,
                  @PaymentTransactionNo ,
                  @PaymentTypeId ,
                  @AccountId ,
                  @PaymentDate ,
                  @ChequeDraftNo ,
                  @ChequeDraftDate ,
                  @BankId ,
                  @Remarks ,
                  @TotalamountReceived ,
                  @UndistributedAmount ,
                  @CreatedBy ,
                  GETDATE() ,
                  @DivisionId ,
                  @StatusId ,
                  @BankDate ,
                  @PM_TYPE 

                )   

        SET @ProcedureStatus = @PaymentTransactionId

        ---increment series

        UPDATE  PM_SERIES
        SET     CURRENT_USED = CURRENT_USED + 1
        WHERE   DIV_ID = @DivisionId
                AND IS_FINISHED = 'N'
                AND PM_TYPE = @PM_TYPE  

  ---update customer ledger 

  ---if payment status approved   than make entry in customer ledger
        IF @StatusId = 2
            BEGIN  
                IF @PM_TYPE = 1
                    BEGIN  

                        SET @Remarks = 'Payment received against reference no.: '
                            + @ChequeDraftNo  

                        EXECUTE Proc_Ledger_Insert @AccountId,
                            @TotalamountReceived, 0, @Remarks, @DivisionId,
                            @PaymentTransactionId, 18, @CreatedBy 
							 
                        EXECUTE Proc_Ledger_Insert @BankId, 0,
                            @TotalamountReceived, @Remarks, @DivisionId,
                            @PaymentTransactionId, 18, @CreatedBy 

                    END  
                IF @PM_TYPE = 2
                    BEGIN
                        SET @Remarks = 'Payment released against reference no.: '
                            + @ChequeDraftNo  

                        EXECUTE Proc_Ledger_Insert @AccountId, 0,
                            @TotalamountReceived, @Remarks, @DivisionId,
                            @PaymentTransactionId, 19, @CreatedBy  

                        EXECUTE Proc_Ledger_Insert @BankId,
                            @TotalamountReceived, 0, @Remarks, @DivisionId,
                            @PaymentTransactionId, 19, @CreatedBy 

                    END
                    
                IF @PM_TYPE = 3
                    BEGIN
                        SET @Remarks = 'Journal Entry for record no.: '
                            + @PaymentTransactionNo  

                        EXECUTE Proc_Ledger_Insert @AccountId, 0,
                            @TotalamountReceived, @Remarks, @DivisionId,
                            @PaymentTransactionId, 21, @CreatedBy  

                        EXECUTE Proc_Ledger_Insert @BankId,
                            @TotalamountReceived, 0, @Remarks, @DivisionId,
                            @PaymentTransactionId, 21, @CreatedBy 

                    END 
                    
                IF @PM_TYPE = 4
                    BEGIN
                        SET @Remarks = 'Contra Entry for record no.: '
                            + @PaymentTransactionNo  

                        EXECUTE Proc_Ledger_Insert @AccountId, 0,
                            @TotalamountReceived, @Remarks, @DivisionId,
                            @PaymentTransactionId, 22, @CreatedBy  

                        EXECUTE Proc_Ledger_Insert @BankId,
                            @TotalamountReceived, 0, @Remarks, @DivisionId,
                            @PaymentTransactionId, 22, @CreatedBy 

                    END 
                    
                IF @PM_TYPE = 5
                    BEGIN
                        SET @Remarks = 'Expense Entry for record no.: '
                            + @PaymentTransactionNo  

                        EXECUTE Proc_Ledger_Insert @AccountId, 0,
                            @TotalamountReceived, @Remarks, @DivisionId,
                            @PaymentTransactionId, 21, @CreatedBy  

                        EXECUTE Proc_Ledger_Insert @BankId,
                            @TotalamountReceived, 0, @Remarks, @DivisionId,
                            @PaymentTransactionId, 21, @CreatedBy 

                    END 

            END  

    END



-------------------------------------------------------------------------------------------------------------------------------------------
ALTER PROC Proc_AddOpeningBalance
    (
      @AccountId NUMERIC(18, 0) ,
      @Amount NUMERIC(18, 2) ,
      @DivisionId NUMERIC(18, 0) ,
      @CreatedBy NVARCHAR(50) ,
      @Openingdate DATETIME ,
      @Type BIGINT  

    )
AS
    BEGIN  

  

        UPDATE  dbo.ACCOUNT_MASTER
        SET     OPENING_BAL = @Amount
        WHERE   ACC_ID = @AccountId  

  

        DECLARE @OPENINGBALANCEID NUMERIC(18, 0)  

       

  

        SET @OPENINGBALANCEID = -( SELECT   ISNULL(COUNT(OPENINGBALANCEID), 0)
                                            + 1 AS Id
                                   FROM     OPENINGBALANCE
                                 )  
								
  

        INSERT  OPENINGBALANCE
        VALUES  ( @OPENINGBALANCEID, @AccountId, @Amount, @Openingdate )  

            

        DECLARE @Remarks VARCHAR(200)   

    

        SET @Remarks = 'Account Opening Balance as on Date: '
            + CAST(CONVERT(VARCHAR(20), @Openingdate, 106) AS VARCHAR(30))  

        IF @TYPE = 1
            BEGIN  

                EXECUTE Proc_Ledger_InsertOpening @AccountId, 0, @Amount,
                    @Remarks, @DivisionId, @OPENINGBALANCEID, 20, @Openingdate,
                    @CreatedBy  

            END  
        IF @TYPE = 2
            BEGIN  

                EXECUTE Proc_Ledger_InsertOpening @AccountId, @Amount, 0,
                    @Remarks, @DivisionId, @OPENINGBALANCEID, 20, @Openingdate,
                    @CreatedBy  

            END  

    END   
-------------------------------------------------------------------------------------------------------------------------------------

