using UnityEngine;

public abstract class AbstractHealth : MonoBehaviour
{
    [SerializeField] private const int _maxHealth = 5000;
    public int _health { get; private set; }

    private void Start()
    {
        FullHealth();
    }
    private void Update()
    {
        Dead();
    }

    private void Dead()
    {
        if(_health <= 0)      
            gameObject.SetActive(false); 
    }

    private void FullHealth()
    {
        _health = _maxHealth;
    }

    public void TakeDamag(int Damag)
    {
        if(Damag <= 0 || Damag > 1000)
        {
            Debug.Log("Урон или слишком большой, или слишком маленький!!!");
        }
        else
        {
            _health -= Damag;
        }
    }

    public void AddHealth(int Regeneration)
    {
        if(Regeneration  > 100)
        {
            Debug.Log("отхил привышен");
        }
        else if (Regeneration + _health > _maxHealth)
        {
            FullHealth();
        }
    }

}
