using UnityEngine;

[CreateAssetMenu(fileName = "Weapen")]
public class WeapenScriptbleObject : ScriptableObject
{
    [SerializeField] private int _mmunition;
    [SerializeField] private float _timeRecharge;
    [SerializeField] private float _timeBetweenShots;
    

    public int Ammunition => _mmunition;
    public float TimeRecharge => _timeRecharge;
    public float TimeBetweenShots => _timeBetweenShots;
    
}
