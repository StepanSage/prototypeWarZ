using UnityEngine;

public  class Weapen : MonoBehaviour
{
    [SerializeField] private WeapenScriptbleObject _weapenScriptbleObject;
    [SerializeField] private Transform _pointShot;   
    [SerializeField] private PoolExample _poolExample;    

    private int _ammunition;   
    private float _timeRecharge;
    private float _timeBetweenShots;    
    private float _maxTimeBetweenShots;
    private float _maxTimeRecharge;
    private int _maxAmmution;

   
    void Start()
    {
        _pointShot = transform.GetChild(0);

        _ammunition = _weapenScriptbleObject.Ammunition;

        _timeBetweenShots= _weapenScriptbleObject.TimeBetweenShots;

        _timeRecharge = _weapenScriptbleObject.TimeRecharge;

        _maxTimeBetweenShots = _timeBetweenShots;

        _maxTimeRecharge = _timeRecharge;

        _maxAmmution = _ammunition;

    } 

    public void LogicShot()
    {
        if (_ammunition <= 0)
        {
            Recharge();
        }
        else
        {
            CanShoot();
        }
    }

    private void CanShoot()
    {
        if (_timeBetweenShots > 0)
        {

            _timeBetweenShots -= Time.deltaTime;
        }
        else
        {
            --_ammunition;
            var bullet = _poolExample._pool.GetFreeElement();
            bullet.transform.position = _pointShot.position;
            _timeBetweenShots = _maxTimeBetweenShots;
        }
    }

    private void Recharge()
    {
        if (_timeRecharge > 0)
        {
            _timeRecharge -= Time.deltaTime;
        }
        else
        {
            _ammunition = _maxAmmution;   
            _timeRecharge = _maxTimeRecharge;
        }
    }



    


}
