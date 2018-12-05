using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dcolor : MonoBehaviour {
    
	// Use this for initialization
    
	void Start () {
        Dynamic();
    }

	//动态加载材质
    void Dynamic()
    {
        //寻找Shader
        Material mat = new Material(Shader.Find("Custom/NewSurfaceShader"));
        //赋给当前物体
        this.gameObject.GetComponent<Renderer>().material = mat;
    }
}
