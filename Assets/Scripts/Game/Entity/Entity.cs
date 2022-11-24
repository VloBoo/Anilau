using UnityEngine;

public class Entity
{
    protected GameObject gameObject;
    protected string name;
    protected int level;
    protected int baseAttack;
    protected int baseHealth;
    protected int currentlyHealth;
    protected int baseProtection;
    protected int basePower;
    protected int currentlyPower;
    protected float speed;


    protected int cooldown = 0;

    public Entity()
    {
        gameObject = new GameObject();
        name = "Entity";
        level = 1;
        baseAttack = 1;
        baseHealth = 1;
        currentlyHealth = 1;
        baseProtection = 1;
        basePower = 1;
        currentlyPower = 1;
        speed = 1;
        Debug.LogWarning("If you see this message, this means that an entity with no parameters has been created. This is not recommended. Pls tell we!");
    }

    public Entity(GameObject gameObject, int level, string name, int baseAttack, int baseHealth, int baseProtection, int basePower, float speed)
    {
        this.gameObject = gameObject;
        this.level = level;
        this.name = name;
        this.baseAttack = baseAttack;
        this.baseHealth = baseHealth;
        this.currentlyHealth = baseHealth;
        this.baseProtection = baseProtection;
        this.basePower = basePower;
        this.currentlyPower = basePower;
        this.speed = speed;
    }
    public GameObject GameObject
    {
        get
        {
            return gameObject;
        }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Level
    {
        get { return level; }
        set { level = value; }
    }
    public int BaseAttack
    {
        get { return baseAttack; }
        set { baseAttack = value; }
    }

    public int BaseHealth
    {
        get { return baseHealth; }
        set { baseHealth = value; }
    }

    public int CurrentlyHealth
    {
        get { return currentlyHealth; }
        set { currentlyHealth = value; }
    }

    public int BaseProtection
    {
        get { return baseProtection; }
        set { baseProtection = value; }
    }

    public int BasePower
    {
        get { return basePower; }
        set { basePower = value; }
    }

    public int CurrentlyPower
    {
        get { return currentlyPower; }
        set { currentlyPower = value; }
    }

    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public override string ToString()
    {
        return "Entity" + GetHashCode() + "(Name: " + name + ", Level: " + level + ")";
    }


    public virtual void TakeDamage(float damage)
    {
        currentlyHealth -= (int)((1f - damage * 0.01) * baseProtection);
        Debug.Log("Attak");
    }

    public virtual float MakeDamage()
    {
        return baseAttack;
    }

    public virtual void Die(){

    }


}