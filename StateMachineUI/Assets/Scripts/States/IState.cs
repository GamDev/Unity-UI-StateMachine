using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState 
{
    void Begin(StateManagerBase stateManagerBase);
    void Exit();
}
