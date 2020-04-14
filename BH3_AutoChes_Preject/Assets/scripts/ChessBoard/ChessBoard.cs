using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    private static int hourizontalNum = 11;
    private static int verticalNum = 11;

    public static ChessCreate chessCreate = new ChessCreate();

    /// <summary>
    ///     棋盘左下角的位置
    /// </summary>
    private Vector3 firstPosition = new Vector3(1, 1, 1);

    private float hourizontalInterval = 0.01f;
    public float vertiacl = 0.01f;

    public Vector3 FirstPosition
    {
        get => firstPosition;
        set => firstPosition = value;
    }

    public float HourizontalInterval
    {
        get => hourizontalInterval;
        set => hourizontalInterval = value;
    }

    public float Vertiacl
    {
        get => vertiacl;
        set => vertiacl = value;
    }

    public void Start()
    {
        chessCreate.ChessCreates(chessCreate);
    }

    public static int HourizontalNum
    {
        get => hourizontalNum;
        set => hourizontalNum = value;
    }

    public static int VerticalNum
    {
        get => verticalNum;
        set => verticalNum = value;
    }
}