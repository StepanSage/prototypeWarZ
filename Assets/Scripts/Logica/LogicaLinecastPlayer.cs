using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LogicaLinecastPlayer : MonoBehaviour
{
    [SerializeField] private Transform _positionPlayer;
    [SerializeField] private Transform _positionEnemy;
    [SerializeField] private LayerMask _layerCollision;

    public bool CollisionChek()
    {
        if(Physics.Linecast(_positionPlayer.position, _positionEnemy.position, _layerCollision))
        {
             return true;
        }
        else
        {
             return false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(_positionPlayer.position, _positionEnemy.position);
    }
}
