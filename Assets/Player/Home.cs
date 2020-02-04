using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    private int HP = 500;

    public void setHP(int dmg)
    {
        HP = HP - dmg;
    }

    public int getHP()
    {
        return HP;
    }
}
