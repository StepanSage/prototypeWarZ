using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolMono<T> where T : MonoBehaviour
{
    private T _prifab;
    private Transform _contener;
    private bool _autoExpand;
    private List<T> _pool;

    public PoolMono(T Prifab, Transform Contener, bool AutoExpand = false, int count=0)
    {
        _prifab = Prifab;
        _contener = Contener;
        _autoExpand = AutoExpand;

        CreatPool(count);
    }

    private void CreatPool(int Count)
    {
        _pool = new List<T>();

        for (int i = 0; i < Count; i++)
        {
            CreatObject();
        }
    }

    private T CreatObject(bool isActionByDefult = false)
    {
        var CreatedObjct = Object.Instantiate(_prifab, _contener);
        CreatedObjct.gameObject.SetActive(isActionByDefult);
        _pool.Add(CreatedObjct);
        return CreatedObjct;


    }

    public bool HasFreeElement(out T Element)
    {
        foreach (var mono in _pool)
        {
            if (!mono.gameObject.activeInHierarchy)
            {
                Element = mono;
                mono.gameObject.SetActive(true);
                return true;
            }  
        }
        Element = null;
        return false;
    }

    public T GetFreeElement()
    {
        if(HasFreeElement(out var Element))
            return Element;
        
        if(_autoExpand)
            return CreatObject(true);

        throw new System.Exception($"ошибка {typeof(T)}");       
    }

}
