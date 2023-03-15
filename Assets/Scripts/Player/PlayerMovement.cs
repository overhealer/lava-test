using SimpleInputNamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent m_NavAgent;
    [SerializeField] private Joystick m_MovementJoystick; // REDO: Make input service

    private Vector3 m_MoveDirection;

    private void Update()
    {
        if(m_MovementJoystick.Value.sqrMagnitude > Mathf.Epsilon)
        {
            m_MoveDirection = transform.right * m_MovementJoystick.Value.x + transform.forward * m_MovementJoystick.Value.y;
        }
        else
        {
            m_MoveDirection = Vector3.zero;
        }
        m_NavAgent.Move(m_MoveDirection * Time.deltaTime * m_NavAgent.speed);

    }
}
