using UnityEngine;

public class ChessCreate : ChessBoard
{
    protected Vector3[,] chessPosition = new Vector3[HourizontalNum, VerticalNum];

    /// <summary>
    ///     创建棋盘，二维数组
    /// </summary>
    /// <param name="init"></param>
    public void ChessCreates(ChessCreate init)
    {
        if (init == null)
            //开始创建棋盘
            for (var i = 0; i < VerticalNum; i++)
                for (var j = 0; j < HourizontalNum; j++)
                {
                    chessPosition[j, i] = new Vector3(i + i * Vertiacl + FirstPosition.x, 0,
                        j + j * HourizontalInterval + FirstPosition.z);
                    //二重循环 创建 单位1 + 间隙 + 初始左下角位置

                    var obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    obj1.transform.position = chessPosition[j, i];
                    //棋盘创建测试
                }
    }
}