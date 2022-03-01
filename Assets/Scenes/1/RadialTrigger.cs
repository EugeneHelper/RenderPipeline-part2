using System; 
using UnityEngine;
using UnityEditor;

public class RadialTrigger : MonoBehaviour
{
    [SerializeField] Transform targetPos;
    [SerializeField] float radius = 2;
    float distance;

    private void OnDrawGizmos()
    {
       
        distance = (transform.position.x - targetPos.position.x)* (transform.position.x - targetPos.position.x)
                   + (transform.position.y - targetPos.position.y) * (transform.position.y - targetPos.position.y);
        if (radius * radius < distance)
        {
            Handles.color = Color.red;
        }
        else
        {
            Handles.color = Color.green;
        }
        Handles.DrawWireDisc(transform.position, Vector3.forward, radius);
    }
}
