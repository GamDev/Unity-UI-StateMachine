using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStateManager : StateManagerBase
{
    #region |  [ Fields ] |

    UIState activeUIState = UIState.MAIN;

    #endregion

    #region  |  Methods  [ Call Backs ]  |

    public override void Awake()
    {
        base.Awake();
        LoadUIPanels();
        ChangeState(UIState.MAIN);
    }

    #endregion

    #region  |  Methods  [ Public ]  |

    public override void ChangeState(Enum nextState)
    {
        statesList[(int)activeUIState].Exit();
        this.activeUIState = (UIState)nextState;
        statesList[(int)activeUIState].Begin(this);
    }

    #endregion

    #region  |  Methods  [ Private ]  |



    #endregion
}
