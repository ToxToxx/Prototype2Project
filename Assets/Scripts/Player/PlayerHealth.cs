using UnityEngine;

public sealed class PlayerHealth : HealthLogic
{
    public static PlayerHealth Instance { get; set; }

    [SerializeField] private int _healAmount;
    [SerializeField] private int _healCount;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        CurrentHealth = MaxHealth;
        GameInput.Instance.OnHeal += GameInput_OnHeal;
    }

    private void OnDestroy()
    {
        GameInput.Instance.OnHeal -= GameInput_OnHeal;
    }

    private void GameInput_OnHeal(object sender, System.EventArgs e)
    {
        Heal();
    }

    private void Heal()
    {
        if(_healCount > 0 && CurrentHealth < MaxHealth)
        {
            CurrentHealth += _healAmount;
            if(CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            _healCount--;
        } else
        {
            Debug.Log("You can't heal");
        }
        
    }

    public int GetPotionsCount()
    {
        return _healCount;
    }


}
