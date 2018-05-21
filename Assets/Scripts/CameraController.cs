using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform m_target;

    private Transform m_transform;
    private Vector3 m_offset;

	// Use this for initialization
	void Start ()
    {
        m_transform = transform;
        m_offset = m_transform.position - m_target.position;
	}
		
	void LateUpdate ()
    {
        m_transform.position = m_target.position + m_offset;
	}
}
