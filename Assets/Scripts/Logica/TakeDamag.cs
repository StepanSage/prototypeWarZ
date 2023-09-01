using UnityEngine;

public class TakeDamag : MonoBehaviour
{
    [SerializeField] string _enamyTagName;
    private void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if(other.gameObject.CompareTag(_enamyTagName))
            {
                gameObject.SetActive(false);
 
            }           
        }        
    }
}
