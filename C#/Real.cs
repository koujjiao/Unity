using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Real : MonoBehaviour {
    ////相位
    //private float radian = 0;
    //// 每秒变化的相位值
    //private float perRadian = 0.03f;
    //// 振幅
    //private float A = 0.8f;
    ////判断手柄是否触碰的布尔值
    //private bool handin = false;

    //Vector3 oldPos;
    //void Start()
    //{
    //    oldPos = transform.position; // 将最初的位置保存到oldPos
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (!handin)
    //    {
    //        //相位随时间增加
    //        radian += perRadian;
    //        // dy定义的是针对y轴的变量，利用三角函数控制平滑滑动
    //        float dy = Mathf.Cos(radian) * A;
    //        //新位置
    //        transform.position = oldPos + new Vector3(0, dy, 0);
    //    }

    //}

    //手柄伸入时运动暂停
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.transform.name == "Controller (left)" || other.transform.name == "Controller (right)")
    //    {
    //        handin = true;
    //    }
    //}

    //手柄离开时运动继续
    //private void OnTriggerExit(Collider other)
    //{
    //    handin = false;
    //}


    //当前碰撞触发器
    //private GameObject collidingObject;
    //void Start()
    //{

    //}

    //private void SetCollidingObject(Collider col)
    //{
    //    collidingObject = col.gameObject;
    //}
    // Update is called once per frame
    //void Update () {
    //    if (collidingObject)
    //    {
    //        print(Vector3.Distance(this.transform.position, collidingObject.transform.position));
    //    }
    //}

    //Is Trigger打开后OnCollision将无法使用



    //当距离小于distan 吸附
    private float ABSORT_DISTANCE = 0.25f;

    //吸附判断
    private void OnTriggerStay(Collider other)
    {
        //print(Vector3.Distance(this.transform.position, other.transform.position));
        if (ABSORT_DISTANCE > Vector3.Distance(this.transform.position, other.transform.position))
        {
            //吸附之后约束各个坐标
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            //取消约束
            //this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //this.transform.position 
            this.transform.position = other.transform.position;
        }
    }

    //public int LessonOne{ get; set; }

    //public Real(int lessonOne)
    //{
    //    LessonOne = lessonOne;
    //}

    //public int backLesson()
    //{
    //    return LessonOne;
    //}

    //public void setLesson(int number = 1)
    //{
    //    LessonOne = number;
    //}

}
