using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotateSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotateSpeed = 10;
        }
        transform.Rotate(0, 0, this.rotateSpeed); //Z���� �߽����� ��
        this.rotateSpeed *= 0.995f;
    }
}
