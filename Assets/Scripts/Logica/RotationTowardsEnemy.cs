using UnityEngine;

public class RotationTowardsEnemy : MonoBehaviour
{
    [SerializeField] private Transform Enemy;
    
    public void LogicaRotetionPlayer()
    {

        transform.LookAt(Enemy);
        
    }

}
