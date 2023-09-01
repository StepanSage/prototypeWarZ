using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstracModel : MonoBehaviour
{
    [SerializeField] private RotationTowardsEnemy _rotationTowardsEnemy;
    [SerializeField] private LogicaLinecastPlayer _logicaLinecastPlayer;
    [SerializeField] private Weapen _weapenModel;
    

    public void FixedUpdate()
    {
        Rotetion();
        LineCast();
        Shot();

    }
    public virtual void Move(float PositionHorizontal, float PositionVertical) { }

    public void Rotetion()
    {
        _rotationTowardsEnemy.LogicaRotetionPlayer();
    }

    public bool LineCast() 
    {
        return _logicaLinecastPlayer.CollisionChek();
    }

    public void Shot()
    {
        if (!LineCast())
            _weapenModel.LogicShot();
    }

}
