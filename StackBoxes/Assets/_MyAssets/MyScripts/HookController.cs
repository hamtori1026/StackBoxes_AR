using UnityEngine;
using System.Collections;

public class HookController : MonoBehaviour
{
    LineRenderer line;

    Vector3 pos; // 고정되어 있는 포인트
    Vector3 cur; // Sphere 움직이는 포인트

    public GameObject par; //GameObject
    public GameObject Finish; //sphere
    public GameObject cube; // box 
    public Transform F_transform; //box Transform
    public Transform P_transform; //GameObject Transform

    private bool DownMoving = true;
    private bool UpMoving = true; 
    public float speed = 70;


    void Start()
    {
        F_transform = Finish.transform; // box transform
        P_transform = par.transform; // gameObject transform

        line = gameObject.GetComponent<LineRenderer>();
        line.SetPosition(1, par.transform.position);
    }

    void Update()
    {
        pos = P_transform.position;
        cur = F_transform.position;

        if (DownMoving == false && F_transform.position.y <= P_transform.position.y)
        {
            F_transform.Translate(0, -speed * Time.deltaTime, 0);
            if (F_transform.position.y < 20f)
            {
                DownMoving = true;
                UpMoving = false;
            }
        } // 내려가

        if (UpMoving == false && F_transform.position.y > 0f)
        {
            F_transform.Translate(0, speed * Time.deltaTime, 0);
            if (F_transform.position.y > P_transform.position.y-20)
            {
                UpMoving = true;
            }
        } // 올라가

        line.SetPosition(0, cur);
        line.SetPosition(1, pos);
    }
    

    public void hook()
    {
        cube.GetComponent<Rigidbody>().useGravity = false; // 상자 중력 끄기
        DownMoving = false;
        Debug.Log(DownMoving);
    }
}
