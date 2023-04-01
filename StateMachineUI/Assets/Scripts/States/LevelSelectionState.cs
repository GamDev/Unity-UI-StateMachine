using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionState : MonoBehaviour, IState
{

    #region |  [ Fields ] |

    StateManagerBase stateManagerBase;

    #endregion


    #region  |  Mehtods  [ Public ]  |

    public void Begin(StateManagerBase stateManagerBase)
    {
        this.stateManagerBase = stateManagerBase;
        this.gameObject.SetActive(true);
    }

    public void Exit()
    {
        this.gameObject.SetActive(false);
    }

    public void OnBackButtonClicked()
    {
        this.stateManagerBase.ChangeState(UIState.MAIN);
    }

    public void OnLevelButtonClicked()
    {
        this.stateManagerBase.ChangeState(UIState.LOADING);
    }

    #endregion

    #region  |  Mehtods  [ Private ]  |

    #endregion
}
