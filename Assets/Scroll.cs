using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") != 0f)
        {
            GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView += (Input.GetAxis("Mouse ScrollWheel") * 10);
            if (GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView >= 60f)
                GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = 60f;
        }
    }
}
