using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStateManager
{
    public static EStates currentState = EStates.None;
}
public enum EStates
{
    Game,
    Win,
    Lose,
    None,
}
