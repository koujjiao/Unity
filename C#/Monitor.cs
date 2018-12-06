using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour {
    //private static int MODEL_SIZE = 100;
    public List<GameObject> LessonOneReal;
    public List<GameObject> LessonOnePlace;
    private GameObject sample;
    public GameObject realObject;
    public GameObject placeObject;
    private int i = 0;
    //private GameObject sample1;
    //private GameObject sample2;
    private string[] lessonOneRealString = { "Prefabs/Cube" , "Prefabs/Cube (1)" , "Prefabs/Cube (2)" , "Prefabs/Cube (3)" ,"Prefabs/Cube (4)"};
    private string[] lessonOnePlaceString = { "Prefabs/Cube (5)", "Prefabs/Cube (6)", "Prefabs/Cube (7)", "Prefabs/Cube (8)", "Prefabs/Cube (9)" };
    private Vector3[] lessonOnePlaceVector;
	// Use this for initialization
	void Start () {
        lessonOnePlaceVector = new Vector3[1000];
        lessonOnePlaceVector[0] = new Vector3(2,2,2 );
        lessonOnePlaceVector[1] = new Vector3(-2, 2, 2);
        lessonOnePlaceVector[2] = new Vector3(2, -2, 2);
        lessonOnePlaceVector[3] = new Vector3(2, 2, -2);
        lessonOnePlaceVector[4] = new Vector3(2, -2, 2);
        //print(1);
        //print(Application.dataPath);
        //foreach(Transform child in this.transform)
        //{
        //    ObjectPool.Add((GameObject)Instantiate(Resources.Load(child.gameObject.name)));
        //}
        Preinstall();
        lessonOneShow();
        //print(ObjectPool)
        //print(ObjectPool[0].name);
        //print(ObjectPool[1].name);
        //foreach (Object i in ObjectPool)
        //{
        //    print(i.name);
        //}
    }

    //预读物品资源进LIST
    public void Preinstall()
    {
        for(int i=0;i<lessonOneRealString.Length;i++)
        {
            sample = (GameObject)Resources.Load(lessonOneRealString[i]);
            LessonOneReal.Add(sample);
            //print(LessonOneReal[i].name);
        }
        for (int i = 0; i < lessonOnePlaceString.Length; i++)
        {
            sample = (GameObject)Resources.Load(lessonOnePlaceString[i]);
            LessonOnePlace.Add(sample);
        }
        //sample1 = (GameObject)Resources.Load("Prefabs/Cube (1)");
        //sample2 = (GameObject)Resources.Load("Prefabs/Cube (2)");

        //Lessonone[0].setLesson(12);
        //print(Lessonone[0].backLesson());
        //sample.AddComponent<Real>().setLesson(12);
        //print(sample.AddComponent<Real>().LessonOne);
        //sample.AddComponent<Real>().backLesson();
    }
	
    //控制第一节课显示
    public void lessonOneShow()
    {
        Destroy(realObject);
        Destroy(placeObject);


        //for (int i = 0; i < lessonOneString.Length; i++)
        //{

        //}
        realObject = Instantiate(LessonOneReal[i]);
        print(1);
        realObject.AddComponent<Real>();
        realObject.gameObject.AddComponent<BoxCollider>();
        realObject.gameObject.AddComponent<Rigidbody>().useGravity = false;

        placeObject = Instantiate(LessonOnePlace[i++]);
        print(LessonOneReal[i].name);
        print(lessonOnePlaceVector[i]);
        placeObject.AddComponent<Place>();
        placeObject.gameObject.AddComponent<BoxCollider>().isTrigger = true;
        placeObject.gameObject.AddComponent<Rigidbody>().useGravity = false;

        placeObject.transform.position = lessonOnePlaceVector[i];
        realObject.transform.position = new Vector3(1, 1, 1);

    }

    public void check()
    {
        
        if (realObject.transform.position == placeObject.transform.position)
        {
            print(1);
            lessonOneShow();
        }
    }
      
	// Update is called once per frame
	void Update () {
        check();
	}
}
