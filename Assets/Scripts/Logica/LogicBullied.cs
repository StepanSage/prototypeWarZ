using System.Collections;
using UnityEngine;


public class LogicBullied : MonoBehaviour
{
    [SerializeField] private float _speedBullid;
    [SerializeField] private float _timeToDeactivation = 3f;
    [SerializeField] private string _nameEnemy;

    private Vector3 _flightDirection;
    private GameObject _enumyPosition;
    private MoveLogica _acterPosition;

    private void Awake()
    {
        _acterPosition = FindObjectOfType<MoveLogica>();
        _enumyPosition = GameObject.Find(_nameEnemy);

        
    }
    private void OnEnable()
    {
        _flightDirection = _acterPosition.transform.position - _enumyPosition.transform.position;
        _flightDirection = _flightDirection.normalized * (-1);
    }

    void Update()
    {
        MoveBullid();
    }

    public void MoveBullid()
    {
        transform.Translate(_flightDirection * _speedBullid*Time.deltaTime);               
        StartCoroutine(Deactivation());        
    }

    private IEnumerator Deactivation()
    {
        yield return new WaitForSeconds(_timeToDeactivation);
        gameObject.SetActive(false);

    }
}

