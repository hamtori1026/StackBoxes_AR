using UnityEngine;
using System.Collections;

public class SphereCollider : MonoBehaviour {

    //HookController hook;

    public GameObject cube;
    public GameObject Mark;
    private bool Check = false;

    // Use this for initialization
    void Start()
    {
        Mark = GameObject.Find("ImageTarget_StackMark");
    }

    //   // Update is called once per frame
    //   void Update () {

    //   }

    public void down()
    {
        
        cube.transform.SetParent(Mark.transform);
        cube.GetComponent<Rigidbody>().useGravity = true; //상자 중력 켜서 떨어지도록
      
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "box")
        {
            print("박스충돌");
            cube.transform.SetParent(this.transform); 
        }
    }
}
