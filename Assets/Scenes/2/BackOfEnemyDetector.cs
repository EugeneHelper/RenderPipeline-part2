using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BackOfEnemyDetector : MonoBehaviour
{
    [Range(0,1)] 
    [SerializeField] float trasholdDot;
    [SerializeField] Transform EnemyTransform;
    
    Color color;
    // Start is called before the first frame update
    private void Start()
    {
       
        //EnemyTransform = EnemyTransform.gameObject. transform.right;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector2 directionPlayer = transform.right.normalized;
        Vector2 toEnemyVector = EnemyTransform.position - transform.position;
        float isEnemyForvard = Vector2.Dot(directionPlayer.normalized, toEnemyVector.normalized);
       // float scalar = directionPlayer.x * toEnemyDir.x + directionPlayer.y + toEnemyDir.y;
        Debug.Log(isEnemyForvard);
        if (isEnemyForvard > trasholdDot)
        {
            color = Color.green;
        }
        else 
        {
            color = Color.red; 
        }
        Debug.DrawRay(transform.position, directionPlayer,color);
        
    }
}
