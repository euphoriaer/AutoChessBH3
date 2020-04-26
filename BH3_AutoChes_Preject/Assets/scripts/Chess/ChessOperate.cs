using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

namespace DefaultNamespace
{
    public class ChessOperate
    {
        private GameObject objMove=null;
        private bool isFollow;

        /// <summary>
        /// 传入需要检测的棋子层，传入棋盘（为了读取棋盘位置）
        /// </summary>
        /// <param name="Chess"></param>
        /// <param name="chessBoard"></param>
        public void Move(LayerMask Chess, ChessBoard chessBoard)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isFollow = true;
                Debug.Log("按键按下");
            }
            else if(Input.GetMouseButtonUp(0))
            {
                isFollow = false;
                Debug.Log("按键松开");
            }

            if (isFollow == true)
            {
                object ray = Camera.main.ScreenPointToRay(Input.mousePosition); //屏幕坐标转射线
                RaycastHit hit; //射线对象是：结构体类型（存储了相关信息）
                bool isHit = Physics.Raycast((Ray) ray, out hit, 50f, Chess);
                if (isHit)
                {
                    Debug.Log("碰到的是" + hit.transform.tag);
                    objMove = hit.transform.gameObject; //检测到碰撞，就把检测到的物体记录下来
                    objMove.transform.position = Input.mousePosition;
                }
            }
            else if (isFollow == false && objMove != null)
            {
                // List<float> distance = new List<float>();  1.可以使用列表的min方法查找到最短距离的 棋盘格，将物体位置设置过去
                Dictionary<float,Vector3> myDictionary= new Dictionary<float,Vector3>();//2.使用字典的min方法查找到最短距离的 棋盘格，将物体位置设置过去
                

                //进行棋盘位置检测,将棋子要落下的位置与棋盘每个位置的距离储存
                foreach (var VARIABLE in chessBoard.chessPosition)
                {
                    float z = Mathf.Abs(VARIABLE.z - objMove.transform.position.z);
                    float y = Mathf.Abs(VARIABLE.x- objMove.transform.position.x);
                    float m = Mathf.Sqrt(z * z + y * y);
                    // distance.Add(m);
                    myDictionary.Add(m,VARIABLE);
                }

                objMove.transform.position = myDictionary.Min().Value;
                myDictionary.Clear();
                objMove = null;

            }
        }
    }
}