using UnityEngine;

/// <summary>
/// 3 key types
/// </summary>
public enum KeyTrigger
{
    Once,
    Double,
    Continue,
}

public class Key
{
    public string name;
    public KeyTrigger trigger;
    public bool enable=true;
    public bool isDown;
    public bool isDoubleDown;
    public bool acceptDoubleDown;
    public float interval = 1f;
    public float realInterval;
    private KeyCode keyCode;
    
    public KeyCode GetKey()
    {
        return keyCode;
    }

    public void SetKey(KeyCode key)
    {
        keyCode = key;
    }

    public void SetEnable(bool isEnable)
    {
        enable = isEnable;
        realInterval = 0f;
    }
}

public class ValueKey
{
    public string name;
    public Vector2 range = new Vector2(0, 1);
    public float value;
    public float addSpeed = 1f;
    private KeyCode keyCode;
    public bool enable;

    public KeyCode GetKey()
    {
        return keyCode;
    }
    public void SetKey(KeyCode key)
    {
        keyCode = key;
    }

    public void SetEnable(bool isEnable)
    {
        enable = isEnable;
        value = 0;
    }
}

public class AxisKey
{
    public string name;
    public Vector2 range = new Vector2(-1, 1);
    public float value;
    private KeyCode posKey;
    private KeyCode negKey;
    public float addSpeed = 1f;
    public bool enable;

    public KeyCode GetPosKey()
    {
        return posKey;
    }

    public KeyCode GetNegKey()
    {
        return negKey;
    }

    public void SetKey(KeyCode pos, KeyCode neg)
    {
        posKey = pos;
        negKey = neg;
    }

    public void SetPosKey(KeyCode pos)
    {
        posKey = pos;
    }

    public void SetNegKey(KeyCode neg)
    {
        negKey = neg;
    }

    public void SetEnable(bool isEnable)
    {
        enable = isEnable;
        value = 0;
    }
}
