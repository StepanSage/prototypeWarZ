using UnityEngine;

public class KeyboardInput : IInputController
{    
    private void FixedUpdate()
    {
        MotionControl();
    }
   
   protected override void MotionControl()
   {
        AbstracModel _model = base._model;
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        _model.Move(Horizontal, Vertical);
       
   }

    




}
