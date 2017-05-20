using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal") * Time.deltaTime  * speed;
        var z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        
        transform.Translate(x, 0, z);
    }
}
