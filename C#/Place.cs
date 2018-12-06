using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Dynamic();
        //this.gameObject.AddComponent<MeshCollider>();
        //this.gameObject.AddComponent<Rigidbody>().useGravity = false;
    }

    //动态加载材质
    void Dynamic()
    {
        //寻找Shader
        Material mat = new Material(Shader.Find("Custom/Alphalighting"));
        //赋给当前物体
        this.gameObject.GetComponent<Renderer>().material = mat;
    }
    //// Update is called once per frame
    //void Update () {
    //触碰之后变色
    private void OnTriggerStay(Collider other)
    {
        //print(Vector3.Distance(this.transform.position, other.transform.position));
        //变色内容
    }
    //}
}
