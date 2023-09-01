using UnityEngine;

public class PoolExample : MonoBehaviour
{
    [SerializeField] private int _poolcount;
    [SerializeField] private bool _autoExpads = false;
    [SerializeField] private Transform _contener;
    [SerializeField] private LogicBullied _prefabs;
    public PoolMono<LogicBullied> _pool;

    private void Start()
    {
        _pool = new PoolMono<LogicBullied>(_prefabs, _contener, _autoExpads, _poolcount);
    }

   

    
}
