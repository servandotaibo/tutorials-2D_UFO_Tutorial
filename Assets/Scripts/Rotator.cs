using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float m_speed = 45f;

    private Transform m_transform;

    private void Start()
    {
        m_transform = transform;     
    }

    // Update is called once per frame
    void Update ()
    {
        m_transform.Rotate(new Vector3(0, 0, 1) * m_speed * Time.deltaTime);	
	}
}
