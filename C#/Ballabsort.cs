using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballabsort : MonoBehaviour {
    //private GameObject Cont;
    // Use this for initialization

    //当距离小于distan 吸附
    private float distan = 0.05f;

    //当前碰撞触发器
    //private GameObject collidingObject;
    void Start () {
   
    }

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
    //吸附判断
    private void OnTriggerStay(Collider other)
    {
        //print(Vector3.Distance(this.transform.position, other.transform.position));
        if (distan > Vector3.Distance(this.transform.position, other.transform.position))
        {
            //吸附之后约束各个坐标
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            //取消约束
            //this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //this.transform.position 
            this.transform.position = other.transform.position;
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{

    //}
}
