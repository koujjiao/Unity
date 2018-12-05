using UnityEngine;
using System.Collections;
// 主界面的开始按钮使用该脚本，控制上下来回浮动
public class BallFloating : MonoBehaviour
{
    //相位
    private float radian = 0; 
    // 每秒变化的相位值
    private float perRadian = 0.03f; 
    // 振幅
    private float A = 0.8f;
    //判断手柄是否触碰的布尔值
    private bool handin = false;

    Vector3 oldPos; 
    void Start()
    {
        oldPos = transform.position; // 将最初的位置保存到oldPos
    }

    // Update is called once per frame
    void Update()
    {
        if(!handin)
        {
            //相位随时间增加
            radian += perRadian; 
            // dy定义的是针对y轴的变量，利用三角函数控制平滑滑动
            float dy = Mathf.Cos(radian) * A;
            //新位置
            transform.position = oldPos + new Vector3(0, dy, 0);
        }
        
    }

    //手柄伸入时运动暂停
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.name == "Controller (left)" || other.transform.name == "Controller (right)")
        {
            handin = true;
        } 
    }

    //手柄离开时运动继续
    private void OnTriggerExit(Collider other)
    {
        handin = false;
    }
}