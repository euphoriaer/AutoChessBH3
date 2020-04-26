using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace DefaultNamespace
{
    public class ChessCreateTest:MonoBehaviour
    {
        public LayerMask chess;
        public ChessBoard chessBoardCam = new ChessBoard(10,10,Vector3.zero,0.1f,0.1f);
        public ChessOperate chessOperate=new ChessOperate();
        private void Start()
        {
            chessBoardCam.ChessCreates();
           
        }

        private void Update()
        {
            chessOperate.Move(chess,chessBoardCam);
            
        }
    }
}