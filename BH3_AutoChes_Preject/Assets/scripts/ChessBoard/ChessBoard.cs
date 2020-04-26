using UnityEngine;


public class ChessBoard
{
    protected static int hourizontalNum = 11; //横向创建数量
    protected  static int verticalNum = 11; //纵向创建数量

    /// <summary>
    ///     棋盘左下角的位置
    /// </summary>
    protected Vector3 firstPosition = new Vector3(1, 1, 1);

    protected float hourizontalInterval = 0.01f;
    protected float vertiaclInterval = 0.01f;

    public Vector3[,] chessPosition = new Vector3[hourizontalNum, verticalNum]; //用一个二位数组横纵创建棋盘

    /// <summary>
    /// 创建棋盘格
    /// </summary>
    /// <param name="hourizontalNum">横向数量</param>
    /// <param name="verticalNum">纵向数量</param>
    /// <param name="firstPosition">左下角第一个位置</param>
    /// <param name="hourizontalInterval">横向间隔</param>
    /// <param name="vertiaclInterval">纵向间隔</param>
    public ChessBoard(int hourizontalNum, int verticalNum, Vector3 firstPosition, float hourizontalInterval,
        float vertiaclInterval)
    {
        ChessBoard.hourizontalNum = hourizontalNum;
        ChessBoard.verticalNum = verticalNum;
        this.firstPosition = firstPosition;
        this.hourizontalInterval = hourizontalInterval;
        this.vertiaclInterval = vertiaclInterval;
       
    }

    public Vector3[,] ChessPosition
    {
        get => chessPosition;
        set => chessPosition = value;
    }


    public void ChessCreates()
    {
     
            //开始创建棋盘
            for (var i = 0; i < verticalNum; i++)
            for (var j = 0; j < hourizontalNum; j++)
            {
                ChessPosition[i, j] = new Vector3(j + j * vertiaclInterval + firstPosition.x, 0,
                    i + i * hourizontalInterval + firstPosition.z);
                //二重循环 创建 单位1 + 间隙 + 初始左下角位置

                var obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obj1.transform.position = ChessPosition[i, j];
                //棋盘创建测试
            }

            foreach (var VARIABLE in ChessPosition)
            {
                
            }
            
        }


}
