using UnityEngine;

public class StandardModel : AbstracModel
{
    [SerializeField] private MoveLogica _moveLogica;
   

    public override void Move(float PositionHorizontal, float PositionVertical)
    {
        _moveLogica.CurrentPositionHorizontal = PositionHorizontal;
        _moveLogica.CurrentPositionVertical = PositionVertical;
       
    }


    

    

}
