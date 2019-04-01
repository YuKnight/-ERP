Namespace LFERP.Library.Purchase.SharePurchase
    '矪Τ闽蹦潦家遏畐计,ゼユ计单璸衡ㄧ计
    Public Class SharePurchaseController
        ''' <summary>
        ''' 糵┪癶砯, э莱蹦潦虫腹莱絪絏ゼユ计
        ''' そΑ   ゼユ计=蹦潦计-喷Μ计+癶砯计
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UpdatePurchase_NoSenQty(ByVal objFile1 As SharePurchaseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdatePurchase_NoSenQty")
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.ExecuteNonQuery(dbComm)
                UpdatePurchase_NoSenQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                UpdatePurchase_NoSenQty = False
            End Try
        End Function



        ''' <summary>
        ''' 秸俱琘畐琘畐(计秖璽计)
        ''' 璝琘畐礚,玥睰癘魁  畐=@WH_ID,  絪絏=@M_Code,  计秖=@WI_Qty
        ''' 璝琘畐Τ,玥э计秖   计秖=计秖+@WI_Qty   where   畐=@WH_ID and  絪絏=@M_Code
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UpdateWareInventory_WIQty(ByVal objFile1 As SharePurchaseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateWareInventory_WIQty")
                db.AddInParameter(dbComm, "@WI_Qty", DbType.Double, objFile1.WI_Qty)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objFile1.WH_ID)
                db.ExecuteNonQuery(dbComm)
                UpdateWareInventory_WIQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateWareInventory_WIQty = False
            End Try
        End Function
        ''' <summary>
        ''' 秸俱琘畐琘畐(计秖ぃ璽计)
        ''' 璝琘畐礚,玥睰癘魁  畐=@WH_ID,  絪絏=@M_Code,  计秖=@WI_Qty
        ''' 璝琘畐Τ,玥э计秖   计秖=@WI_Qty   where   畐=@WH_ID and  絪絏=@M_Code
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UpdateWareInventory_WIQty2(ByVal objinfo As SharePurchaseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateWareInventory_WIQty2")
                db.AddInParameter(dbComm, "@WI_Qty", DbType.Double, objinfo.WI_Qty)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.ExecuteNonQuery(dbComm)

                UpdateWareInventory_WIQty2 = True

            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateWareInventory_WIQty2 = False
            End Try
        End Function


    End Class
End Namespace