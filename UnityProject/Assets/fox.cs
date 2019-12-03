using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fox : MonoBehaviour
{
   
    [Header("速度"), Range(0, 100f)]
    public float speed = 10.5f;
    // Start is called before the first frame update
    void Start()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;

        transform.Translate(0.1f, speed, 10);
    }
    private void Rig()
    {
      
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
