using UnityEngine;
using UnityEngine.Events;

public class EnemyScript : MonoBehaviour
{
    public HealthBar HealthBar;
    public int MaxHP;

    [SerializeField] private UnityEvent OnDeath; 

    private int _currentHP;


    void Start()
    {
        HealthBar = GetComponentInChildren<HealthBar>();
        _currentHP = MaxHP;
    }

    void Update()
    {
        HealthBar.SetMaxHP(MaxHP);
        HealthBar.SetHP(_currentHP);

        if(Input.GetButtonDown("Fire1"))
        {
            _currentHP--;
        }
        if(Input.GetButtonDown("Jump"))
        {
            Heal(1);
        }

        if(_currentHP <= 0)
        {
            OnDeath.Invoke();
        }
    }

    void FixedUpdate()
    {
    }
 

    public void Heal(int amount)
    {
        _currentHP += amount;
        if(_currentHP > MaxHP)
        {
            _currentHP = MaxHP;
        }
    }
}
