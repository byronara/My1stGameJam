using UnityEngine;

public class Controller_Script : MonoBehaviour
{
    public float Speed;
    public HealthBar HealthBar;
    public int MaxHP;
    [HideInInspector]
    public int CurrentHP;
    private Rigidbody2D _rigidbody2D;
    private Vector2 _movement;
    
    

    void Start()
    {
        HealthBar = GetComponentInChildren<HealthBar>();
        _rigidbody2D = GetComponent<Rigidbody2D>();

        CurrentHP = 1;
    }

    void Update()
    {
        HealthBar.SetMaxHP(MaxHP);
        HealthBar.SetHP(CurrentHP);
        GetPlayerKey();
       
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + (_movement * Speed * Time.fixedDeltaTime));
    }
    private void GetPlayerKey()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
    }

    public void Heal(int amount)
    {
        CurrentHP += amount;
        if(CurrentHP > MaxHP)
        {
            CurrentHP = MaxHP;
        }
    }
}
